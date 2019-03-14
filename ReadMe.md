<pre>
             ///\      ///\             /////////\              ///\
            //\\/      //\/           //\\\\\\\\//\            //\\/
           //\/       //\/          //\\/       \\/           //\/
          //\/       //\/           \//\                     //\/
         /////////////\/             \//////\               //\/
        //\\\\\\\\\//\/               \\\\\//\             //\/
       //\/       //\/                     \//\           //\/
      //\/       //\/           ///\      //\\/          //\/       //\   
     ///\      ///\/            \/////////\\/           /////////////\/
     \\\/      \\\/              \\\\\\\\\/             \\\\\\\\\\\\\/             Present by Richard.Hu
</pre>

# HslControls.dll
[![NuGet Status](https://img.shields.io/nuget/v/HslControls.svg)](https://www.nuget.org/packages/HslControls/) ![NuGet Download](https://img.shields.io/nuget/dt/HslControls.svg)  [![NetFramework](https://img.shields.io/badge/Language-C%23%207.0-orange.svg)](https://blogs.msdn.microsoft.com/dotnet/2016/08/24/whats-new-in-csharp-7-0/) [![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2017-red.svg)](https://www.visualstudio.com/zh-hans/) ![copyright status](https://img.shields.io/badge/CopyRight-Richard.Hu-brightgreen.svg) 

一个工业软件的控件库，配套HslCommunication通信组件使用即可以快速开发上位机的软件系统。本项目不是源代码，是一个DEMO项目的源代码。
## Install From Nuget
```
Install-Package HslControls
```

## 输入激活码
在你的程序进入的地方输入激活码即可。
```
static void Main( )
{
    // 注册控件示例，如果注册失败，你的控件仍然只能使用8个小时
    HslControls.Authorization.SetAuthorizationCode( "你的授权码" );

    Application.EnableVisualStyles( );
    Application.SetCompatibleTextRenderingDefault( false );
    Application.Run( new FormLoad( ) );
}
```
## Demo
初步实现的控件如下所示（有些为动图，实际需要自己下载demo运行，demo仅支持免费运行8小时）：

![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/1.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/100.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/101.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/102.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/103.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/104.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/105.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/106.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/107.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/108.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/109.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/110.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/111.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/112.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/113.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/114.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/115.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/116.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/117.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/118.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/119.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/120.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/121.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/122.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/123.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/124.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/200.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/201.png)
![Picture](https://raw.githubusercontent.com/dathlin/HslControlsDemo/master/img/202.png)