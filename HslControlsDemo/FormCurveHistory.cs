﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HslControlsDemo
{
    public partial class FormCurveHistory : Form
    {
        public FormCurveHistory( )
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.Text = "正在加载数据...";
            hslCurveHistory1.RemoveAllCurve( );
            new Thread( new ThreadStart( ThreadReadExample1 ) ) { IsBackground = true }.Start( );
        }

        private void ThreadReadExample1( )
        {
            Thread.Sleep( 2000 );
            // 我们假定从数据库中获取到了这些数据信息
            float[] steps = new float[2000];
            float[] data = new float[2000];
            float[] press = new float[2000];
            DateTime[] times = new DateTime[2000];

            for (int i = 0; i < data.Length; i++)
            {
                steps[i] = random.Next( 10 );
                data[i] = Convert.ToSingle( random.NextDouble( ) * 40 + 100 );
                times[i] = DateTime.Now.AddSeconds( i - 2000 );
                press[i] = Convert.ToSingle( random.NextDouble( ) * 0.5d + 4 );
            }

            // 显示出数据信息来
            Invoke( new Action( ( ) =>
             {
                 hslCurveHistory1.SetLeftCurve( "步序", steps );
                 hslCurveHistory1.SetLeftCurve( "温度", data, Color.DodgerBlue, true, "{0:F1} ℃" );
                 hslCurveHistory1.SetRightCurve( "压力", press, Color.Tomato, true, "{0:F2} Mpa" );
                 hslCurveHistory1.SetDateTimes( times );
                 hslCurveHistory1.AddMarkBackSection( new HslControls.HslMarkBackSection( ) { StartIndex = 1000, EndIndex = 1200, MarkText = "报警了" } );
                 // 添加两个背景标记的示例，可以用来标记特殊用途的背景，例如一个产品的周期，停机，维修等等状态
                 hslCurveHistory1.AddMarkForeSection( new HslControls.HslMarkForeSection( )
                 {
                     StartIndex = 900,
                     EndIndex = 1300,
                     StartHeight = 0.2f,
                     Height = 0.8f,
                 } );
                 hslCurveHistory1.AddMarkForeSection( new HslControls.HslMarkForeSection( )
                 {
                     StartIndex = 500,
                     EndIndex = 700,
                     StartHeight = 0.3f,
                     Height = 0.7f,
                     IsRenderTimeText = false,
                     LinePen = Pens.Orange,
                     MarkText = "报警区域"
                 } );

                 // 增加一个三角形的线段标记示例 Points的每个点的X是数据索引，Y是数据值（需要选对参考坐标轴，默认为左坐标轴）
                 hslCurveHistory1.AddMarkLine( new HslControls.HslMarkLine( )
                 {
                     CircleBrush = Brushes.DodgerBlue,
                     IsLeftFrame = true,
                     IsLineClosed = true,
                     LinePen = Pens.DodgerBlue,
                     TextBrush = Brushes.DodgerBlue,
                     Points = new PointF[]
                     {
                         new PointF(200, 180f), new PointF(260, 20f), new PointF(550, 150f),
                     },
                     Marks = new string[] { "AA", "BB", "CC" },
                 } );

                 // 添加一个活动的标记
                 HslControls.HslMarkForeSection active = new HslControls.HslMarkForeSection( )
                 {
                     StartIndex = 1000,
                     EndIndex = 1500,
                     Height = 0.9f,
                 };
                 active.CursorTexts.Add( "条码", "A123123124ashdiahsd是的iahsidasd" );
                 active.CursorTexts.Add( "工号", "asd2sd123dasf" );
                 hslCurveHistory1.AddMarkActiveSection( active );

                 hslCurveHistory1.SetCurveVisible( "步序", false );   // 步序不是曲线信息，不用显示出来
                 hslCurveHistory1.RenderCurveUI( );
             } ) );
        }

        private Random random = new Random( );

        private void FormCurveHistory_Load( object sender, EventArgs e )
        {
            hslCurveHistory1.AddLeftAuxiliary( 172f );
            checkBox1.Checked = true;
            checkBox2.Checked = true;

            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
        }

        private void CheckBox2_CheckedChanged( object sender, EventArgs e )
        {
            hslCurveHistory1.SetCurveVisible( "压力", checkBox2.Checked );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void CheckBox1_CheckedChanged( object sender, EventArgs e )
        {
            hslCurveHistory1.SetCurveVisible( "温度", checkBox1.Checked );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis( 0.5f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis(1f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.SetScaleByXAxis( 2f );
            hslCurveHistory1.RenderCurveUI( );
        }

        private void hslCurveHistory1_onCurveDoubleClick( HslControls.HslCurveHistory hslCurve, int index, DateTime dateTime )
        {
            MessageBox.Show( $"Index: {index} Time:{dateTime.ToString( )}" );
        }

        private void button5_Click( object sender, EventArgs e )
        {
            if (int.TryParse( textBox1.Text, out int index ))
            {
                hslCurveHistory1.AddMarkText( new HslControls.HslMarkText( )
                {
                    Index = index,
                    CurveKey = "温度",
                    MarkText = textBox2.Text,
                    CircleBrush = Brushes.HotPink,
                    TextBrush = Brushes.Pink
                } );
                hslCurveHistory1.RenderCurveUI( );
            }
            else
            {
                MessageBox.Show( "Input Error" );
            }
        }

        private void button6_Click( object sender, EventArgs e )
        {
            hslCurveHistory1.RemoveAllMarkText( );
            hslCurveHistory1.RenderCurveUI( );
        }
    }
}
