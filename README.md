# CSharp GUI

[![.Net Core 7](https://img.shields.io/badge/.NetCore-v7-blue.svg)](https://nodejs.org/en/blog/release/v8.11.4/) [![avalonia ui](https://img.shields.io/badge/avaloniaUI-v11.0.2-orange.svg)](https://docs.avaloniaui.net/zh-Hans/docs/next/welcome)

## 环境

 * [.Net Core 7](https://learn.microsoft.com/zh-cn/teamblog/introducing-net-core-docs)
 * Mac pro / Windows 10
 * visual studio code
 * [avalonia ui](https://docs.avaloniaui.net/docs/next/get-started/)

## 安装

* .Net Core
* 安装Avalonia

环境配置

mac pro
```bash
cd /
vim ./~bash_profile
export PATH="$PATH:/usr/local/share/dotnet"
```

```bash
dotnet --version
```

## 运行

```shell
dotnet run
```

## 目录说明

>App.axaml

这个文件是 [Avalonia UI](https://docs.avaloniaui.net/docs/next/get-started/) 框架的应用程序配置文件，名为 App.axaml。

它定义了应用程序的主题、样式等全局设置。

- x:Class="MyAvaloniaApp.App" 指定了应用程序的主类。
- RequestedThemeVariant="Default" 设置了应用程序的主题变体。"Default" 表示跟随系统主题，"Dark" 和 "Light" 是其他可用选项。
- <Application.Styles> 中的 <FluentTheme /> 是应用程序的全局样式。

这个文件是 Avalonia UI 框架应用程序的重要组成部分，它决定了应用程序的外观和行为。


>* App.axaml.cs  

这个文件是 Avalonia UI 框架的应用程序入口点，名为 App.axaml.cs。

它定义了应用程序的初始化和启动过程。

- Initialize() 方法中，AvaloniaXamlLoader.Load(this); 用于加载应用程序的 XAML 资源。
- OnFrameworkInitializationCompleted() 方法在框架初始化完成后被调用。在这个方法中，它检查应用程序的生命周期类型，并在其为 IClassicDesktopStyleApplicationLifetime 时设置主窗口。

这个文件是 Avalonia UI 框架应用程序的重要组成部分，它决定了应用程序的启动和运行过程。


>* app.manifest

这个文件是一个应用程序清单文件，通常命名为 app.manifest。

它用于定义和描述应用程序的一些元数据和配置信息。

* MainWindow.axaml

这个文件是 Avalonia UI 框架的主窗口定义文件，名为 MainWindow.axaml。

它定义了应用程序的 主窗口的布局 和 元素。

在这个文件中：

- x:Class="MyAvaloniaApp.MainWindow" 指定了这个窗口的后台代码类。
- Title="MyAvaloniaApp" 设置了窗口的标题。
- <StackPanel> 是一个布局容器，它包含了两个子元素：一个 TextBlock 和一个 Button。TextBlock 显示了文本 "Hello Avalonia!"，Button 显示了文本 "Click Me!"。

总的来说，这个文件定义了应用程序的用户界面和交互元素。


* MainWindow.axaml.cs

这个文件是 Avalonia UI 框架的主窗口代码文件，名为 MainWindow.axaml.cs。

它定义了应用程序的 主窗口的行为 和 逻辑。

在这个文件中：

- public partial class MainWindow : Window 定义了一个名为 MainWindow 的类，它继承自 Window 类。这是应用程序的主窗口。
- public MainWindow() 是 MainWindow 类的构造函数。在这个函数中，调用了 InitializeComponent() 方法，该方法在编译时由 Avalonia 自动生成，用于加载和初始化窗口的 XAML 元素。

总的来说，这个文件定义了应用程序的主窗口的行为和逻辑。


* MyAvaloniaApp.csproj 

这个文件是一个项目文件，名为 MyAvaloniaApp.csproj。

它是用于.NET项目的XML格式文件，包含了项目的 配置信息，如：目标框架、输出类型、包引用等。

在这个文件中：

- <OutputType>WinExe</OutputType> 指定了项目的输出类型为 Windows 可执行文件。
- <TargetFramework>net6.0</TargetFramework> 指定了项目的目标框架为 .NET 6.0。
- <PackageReference Include="Avalonia" Version="11.0.2" /> 等行定义了项目的包引用。

总的来说，这个文件是.NET项目的核心，它定义了 项目的配置 和 依赖。

* MyAvaloniaApp.sln

这个文件是一个解决方案文件，名为 MyAvaloniaApp.sln。

它是 Visual Studio 用来组织和管理多个相关项目的文件。

在这个文件中：

- Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "MyAvaloniaApp", "MyAvaloniaApp.csproj", "{FA0899BD-2C43-4D81-A72F-20F451583791}" 这一行定义了一个名为 "MyAvaloniaApp" 的项目，它的项目文件是 "MyAvaloniaApp.csproj"。
- GlobalSection(SolutionConfigurationPlatforms) = preSolution 和 GlobalSection(ProjectConfigurationPlatforms) = postSolution 这两部分定义了解决方案和项目的配置平台和构建配置。

总的来说，这个文件是用来管理和组织 Visual Studio 中的多个项目，它定义了项目的结构和配置。


* Program.cs

这个文件是 Avalonia UI 框架的应用程序入口点，名为 Program.cs。它定义了应用程序的启动和初始化过程。

在这个文件中：

- Main(string[] args) 方法是应用程序的入口点。它调用 BuildAvaloniaApp().StartWithClassicDesktopLifetime(args); 来构建并启动 Avalonia 应用程序。
- BuildAvaloniaApp() 方法用于配置 Avalonia 应用程序。它使用 AppBuilder.Configure<App>() 来配置应用程序，然后调用 UsePlatformDetect(), WithInterFont(), 和 LogToTrace() 来设置平台检测，字体，和日志记录。

总的来说，这个文件是 Avalonia UI 框架应用程序的重要组成部分，它决定了应用程序的启动和运行过程。


### 示例

在Mac上使用VS Code和.NET Core创建C# GUI应用程序的一种方式是使用Avalonia框架。

[Avalonia]是一个跨平台的XAML框架，可以在Windows、Linux和Mac上运行。

以下是一个简单的Avalonia GUI应用程序的创建步骤：

1. 首先，你需要安装.NET Core SDK [下载](https://dotnet.microsoft.com/download)

2. 安装Avalonia模板。

在终端中运行以下命令：

```bash
dotnet new -i Avalonia.Templates
```

以下是一个简单的Avalonia GUI应用程序的创建步骤：

1. 首先，你需要安装.NET Core SDK。你可以在这里下载。

2. 安装Avalonia模板。在终端中运行以下命令：

```bash
dotnet new -i Avalonia.Templates
```

3. 创建一个新的Avalonia应用程序。在终端中运行以下命令：
```bash
cd MyAvaloniaApp
```
这将创建一个名为"MyAvaloniaApp"的新项目。

4. 进入新创建的项目目录：
```bash
dotnet new avalonia.app -o MyAvaloniaApp
```
5. 运行应用程序：

```bash
dotnet run
```
3. 创建一个新的Avalonia应用程序。在终端中运行以下命令：

```bash
dotnet new avalonia.app -o MyAvaloniaApp
```
这将创建一个名为"MyAvaloniaApp"的新项目。

4. 进入新创建的项目目录：

```bash
cd MyAvaloniaApp
```
5. 运行应用程序：
```bash
dotnet run
```



### 窗体

### 控件

[avvalonia官方文档](https://avaloniaui.net/docs/)

Avalonia支持许多常用的GUI控件，包括按钮、文本框、标签、列表框、复选框等。

以下是一些常用控件的使用方法：

1. Button（按钮）：按钮是最常用的控件之一，通常用于触发某种操作。

你可以通过Click事件来处理按钮点击。

```xml
<Button Content="Click Me" Click="OnClick"/>
```
在对应的C#文件中，你可以添加一个事件处理程序：

```C#
public void OnClick(object sender, RoutedEventArgs e)
{
    // 处理点击事件
}
```

2. TextBox（文本框）：文本框用于接收用户输入的文本。

你可以通过Text属性获取或设置文本框的内容。

```xml
<TextBox Name="MyTextBox"/>
```

在C#代码中，你可以这样获取或设置文本框的内容：
```C#
string text = MyTextBox.Text; // 获取文本
MyTextBox.Text = "Hello, World!"; // 设置文本
```

3. Label（标签）：标签用于显示一些文本。你可以通过Content属性设置标签的内容。

```xml
<Label Content="Hello, World!"/>
```

4. ListBox（列表框）：列表框用于显示一个列表的项。你可以通过Items属性设置列表的内容。

```xml
<ListBox Name="MyListBox"/>
```
在C#代码中，你可以这样设置列表的内容：
```C#
MyListBox.Items = new string[] { "Item 1", "Item 2", "Item 3" };
```

5. CheckBox（复选框）：复选框用于表示一个可以被选中或取消选中的选项。

你可以通过IsChecked属性获取或设置复选框的状态。

```xml
<CheckBox Name="MyCheckBox" Content="Check Me"/>
```
在C#代码中，你可以这样获取或设置复选框的状态：
```C#
bool isChecked = MyCheckBox.IsChecked; // 获取状态
MyCheckBox.IsChecked = true; // 设置状态
```

6. ComboBox（组合框）：组合框用于显示一个下拉列表，用户可以从下拉列表中选择一个选项。

7. 单选框 

8. 进度条

9. 滑块

10. 更多组件


### 布局

在Avalonia中，你可以使用XAML（Extensible Application Markup Language）来定义用户界面。XAML是一种XML的标记语言，用于描述.NET应用程序的用户界面。

#### 1.定义控件

在XAML中，你可以使用XML元素来定义控件。

例如，以下代码定义了一个包含一个按钮和一个文本框的窗口：

```xml
<Window xmlns="https://github.com/avaloniaui">
    <StackPanel>
        <Button Content="Click Me" Click="OnClick"/>
        <TextBox Name="MyTextBox"/>
    </StackPanel>
</Window>
```

#### 2.引入不同的文件

如果你的XAML代码分散在多个文件中，你可以使用<UserControl>元素来引入其他的XAML文件。

例如，如果你有一个名为MyUserControl.xaml的文件，你可以这样引入：

```xml
<UserControl xmlns="https://github.com/avaloniaui"
             x:Class="MyNamespace.MyUserControl">
    <!-- UserControl的内容 -->
</UserControl>
```

然后在其他的XAML文件中这样使用：

```xml
<Window xmlns="https://github.com/avaloniaui"
        xmlns:local="clr-namespace:MyNamespace">
    <local:MyUserControl/>
</Window>
```

Avalonia支持多种布局控件，如：StackPanel、Grid、DockPanel等，用于控制控件的布局。例

如，StackPanel可以将其子控件堆叠起来：


```xml
<StackPanel>
    <Button Content="Button 1"/>
    <Button Content="Button 2"/>
</StackPanel>
```

你可以使用样式来定义控件的外观。样式可以定义在<Window.Styles>或<Application.Styles>中。

例如，以下代码定义了一个使所有按钮的背景色为红色的样式：

```xml
<Window.Styles>
    <Style Selector="Button">
        <Setter Property="Background" Value="Red"/>
    </Style>
</Window.Styles>
```



#### 3.事件处理

在XAML中，你可以使用事件处理程序来处理事件。
例如，以下代码定义了一个按钮，当用户点击按钮时，会弹出一个消息框：
```xml
<Button Content="Click Me" Click="OnClick"/>
```
在C#代码中，你可以这样定义事件处理程序：

```C#
private void OnClick(object sender, RoutedEventArgs e)
{
    MessageBox.Show("Clicked!");
}
```

#### 4.数据绑定

在XAML中，你可以使用数据绑定来绑定数据到控件。

例如，以下代码定义了一个文本框，当用户输入文本时，会显示输入的文本：

```xml
<TextBox Text="{Binding Text}"/>
```

在C#代码中，你可以这样定义数据绑定：

```C#
public string Text
{
    get { return _text; }
    set
    {
        _text = value;
        NotifyPropertyChanged();
    }
}
```

#### 5.资源
在XAML中，你可以使用资源来定义控件的默认属性。

例如，以下代码定义了一个文本框，其默认的字体为“Consolas”：

```xml
<TextBox FontFamily="Consolas"/>
```

在C#代码中，你可以这样定义资源：
```C#
public static readonly StyledProperty<FontFamily> FontFamilyProperty =
    TextBlock.FontFamilyProperty.AddOwner<MyControl>();

public FontFamily FontFamily
{
    get { return (FontFamily)GetValue(FontFamilyProperty); }
    set { SetValue(FontFamilyProperty, value); }
}
```

#### 6.数据模板

在XAML中，你可以使用数据模板来定义控件的默认外观。

例如，以下代码定义了一个文本框，其默认的字体为“Consolas”：

```xml
<TextBox FontFamily="Consolas"/>
```

在C#代码中，你可以这样定义数据模板：
```C#   
public static readonly DependencyProperty FontFamilyProperty =
    TextBlock.FontFamilyProperty.AddOwner<MyControl>();

public FontFamily FontFamily
{
    get { return (FontFamily)GetValue(FontFamilyProperty); }
    set { SetValue(FontFamilyProperty, value); }
}
```

#### 7.命令

在XAML中，你可以使用命令来定义按钮的默认行为。

例如，以下代码定义了一个按钮，当用户点击按钮时，会弹出一个消息框：

```xml
<Button Content="Click Me" Click="OnClick"/>
```

在C#代码中，你可以这样定义命令：
```C#
public static readonly RoutedEvent ClickEvent =
    ButtonBase.ClickEvent.AddOwner(typeof(MyControl));

protected virtual void OnClick()
{
    MessageBox.Show("Clicked!");
}
```

#### 8.事件处理程序

在XAML中，你可以使用事件处理程序来定义控件的默认行为。

例如，以下代码定义了一个文本框，当用户输入文本时，会弹出一个消息框：

```xml
<TextBox TextChanged="OnTextChanged"/>
```

在C#代码中，你可以这样定义事件处理程序：
```C#
public static readonly DependencyProperty TextChangedEvent =
    TextBox.TextChangedEvent.AddOwner(typeof(MyControl));

protected virtual void OnTextChanged(TextChangedEventArgs e)
{
    MessageBox.Show("Changed!");
}
```

#### 9.依赖属性

依赖属性是XAML和C#代码之间的桥梁。

依赖属性通常定义为依赖项属性（DependencyProperty），并使用AddOwner方法添加到类型中。

例如，以下代码定义了一个依赖属性：
```C#
public static readonly DependencyProperty FontFamilyProperty =
    TextBlock.FontFamilyProperty.AddOwner(typeof(MyControl));
```

#### 10.资源字典
资源字典是XAML和C#代码之间的桥梁。

资源字典通常定义为资源字典（ResourceDictionary），并使用AddOwner方法添加到类型中。

例如，以下代码定义了一个资源字典：
```C#
public static readonly DependencyProperty FontFamilyProperty =
    TextBlock.FontFamilyProperty.AddOwner(typeof(MyControl));
```

#### 11.路由事件
路由事件是XAML和C#代码之间的桥梁。
路由事件通常定义为路由事件（RoutedEvent），并使用AddOwner方法添加到类型中。

例如，以下代码定义了一个路由事件：
```C#

public static readonly RoutedEvent ClickEvent =
    ButtonBase.ClickEvent.AddOwner(typeof(MyControl));

protected virtual void OnClick()
{
    MessageBox.Show("Clicked!");
}
```

#### 12.命令
命令是XAML和C#代码之间的桥梁。
命令通常定义为命令（ICommand），并使用AddOwner方法添加到类型中。

例如，以下代码定义了一个命令：
```C#
public static readonly DependencyProperty FontFamilyProperty =
    TextBlock.FontFamilyProperty.AddOwner(typeof(MyControl));
```

#### 13.依赖对象
依赖对象是XAML和C#代码之间的桥梁。

依赖对象通常定义为依赖对象（DependencyObject），并使用AddOwner方法添加到类型中。
例如，以下代码定义了一个依赖对象：

```C#
public static readonly DependencyProperty FontFamilyProperty =

    TextBlock.FontFamilyProperty.AddOwner(typeof(MyControl));
```


# 实践

我想写一个登录界面

在Avalonia中，你可以创建一个登录界面，包含用户名和密码输入框以及登录按钮。

以下是一个简单的登录界面的示例：

XAML文件（LoginWindow.xaml）

```xml
<Window xmlns="https://github.com/avaloniaui"
        x:Class="MyNamespace.LoginWindow">
    <StackPanel Margin="20">
        <TextBlock Text="Username:"/>
        <TextBox Name="UsernameTextBox"/>
        <TextBlock Text="Password:" Margin="0,10,0,0"/>
        <PasswordBox Name="PasswordBox"/>
        <Button Content="Login" Click="OnLogin" Margin="0,10,0,0"/>
    </StackPanel>
</Window>
```

C#文件（LoginWindow.xaml.cs）

```C#
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyNamespace
{
    public class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void OnLogin(object sender, RoutedEventArgs e)
        {
            var username = this.FindControl<TextBox>("UsernameTextBox").Text;
            var password = this.FindControl<PasswordBox>("PasswordBox").Password;

            // 这里添加你的登录逻辑
        }
    }
}
```

在这个示例中，我们使用'StackPanel'来垂直排列控件，使用'TextBlock'来显示标签，使用'TextBox'和'PasswordBox'来接收用户输入，使用'Button'来触发登录操作。

在OnLogin方法中，我们获取用户名和密码的值，并可以添加登录逻辑，例如验证用户名和密码，连接到服务器等。

[注意]:这只是一个基本的示例，实际的登录界面可能需要更复杂的布局和功能，例如:错误处理、记住我选项、忘记密码链接等。


* 完整代码，以下是一个包含错误处理、记住我选项和忘记密码链接的登录界面的示例：

```xml
<Window xmlns="https://github.com/avaloniaui"
        x:Class="MyNamespace.LoginWindow">
    <StackPanel Margin="20">
        <TextBlock Text="Username:"/>
        <TextBox Name="UsernameTextBox"/>
        <TextBlock Text="Password:" Margin="0,10,0,0"/>
        <PasswordBox Name="PasswordBox"/>
        <CheckBox Name="RememberMeCheckBox" Content="Remember me" Margin="0,10,0,0"/>
        <TextBlock Name="ErrorTextBlock" Foreground="Red" Margin="0,10,0,0"/>
        <Button Content="Login" Click="OnLogin" Margin="0,10,0,0"/>
        <TextBlock Text="Forgot password?" Foreground="Blue" PointerPressed="OnForgotPassword"/>
    </StackPanel>
</Window>
```


```C#
```

在这个示例中，我们添加了一个CheckBox来实现记住我选项，添加了一个TextBlock来显示错误信息，添加了一个忘记密码链接，当点击时触发OnForgotPassword方法。

在OnLogin方法中，我们获取用户名、密码和记住我选项的值，然后添加登录逻辑。

如果登录失败，我们可以设置ErrorTextBlock的Text属性来显示错误信息。

如果登录成功并且记住我选项为true，我们可以保存用户名和密码（注意，密码应该安全地存储，例如使用加密）。

在OnForgotPassword方法中，我们可以添加忘记密码逻辑，例如：打开一个新的窗口或者导航到一个网页。

[注意]:这只是一个基本的示例，实际的登录界面可能需要更复杂的布局和功能，例如输入验证、密码加密、连接到服务器等。


在这个示例中，我们将添加一个简单的登录逻辑，如果用户名和密码匹配，我们将显示一个成功的消息，否则我们将在ErrorTextBlock中显示错误信息。

我们还将添加一个简单的记住我逻辑，如果rememberMe为true，我们将保存用户名和密码。

```C#
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace MyNamespace
{
    public class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void OnLogin(object sender, RoutedEventArgs e)
        {
            var username = this.FindControl<TextBox>("UsernameTextBox").Text;
            var password = this.FindControl<PasswordBox>("PasswordBox").Password;
            var rememberMe = this.FindControl<CheckBox>("RememberMeCheckBox").IsChecked;
            var errorTextBlock = this.FindControl<TextBlock>("ErrorTextBlock");

            // 简单的登录逻辑：如果用户名和密码都是"admin"，则登录成功
            if (username == "admin" && password == "admin")
            {
                errorTextBlock.Text = "Login successful!";
                
                // 如果rememberMe为true，保存用户名和密码
                if (rememberMe == true)
                {
                    // 注意，这只是一个示例，实际上你应该安全地存储密码，例如使用加密
                    App.Current.Properties["username"] = username;
                    App.Current.Properties["password"] = password;
                }
            }
            else
            {
                errorTextBlock.Text = "Invalid username or password!";
            }
        }

        public void OnForgotPassword(object sender, PointerPressedEventArgs e)
        {
            // 这里添加你的忘记密码逻辑，例如打开一个新的窗口或者导航到一个网页
        }
    }
}
```

在这个示例中，我们使用App.Current.Properties来保存用户名和密码。App.Current.Properties是一个字典，可以用来存储应用程序的全局数据。

注意，这只是一个简单的示例，实际上你应该安全地存储密码，例如使用加密。

在OnLogin方法中，我们检查用户名和密码是否都是"admin"，如果是，我们显示一个成功的消息，并根据rememberMe的值决定是否保存用户名和密码，如果不是，我们显示一个错误信息。



## 常见问题

### 1. 多窗口

在Avalonia中，你可以创建多个窗口。每个窗口都是一个Window对象，可以包含自己的布局和控件。

#### 1.1 定义多个窗口

每个窗口都可以在自己的XAML文件中定义。例如，你可以有一个MainWindow.xaml和一个SecondWindow.xaml。

MainWindow.xaml：

```xml
<Window xmlns="https://github.com/avaloniaui"
        x:Class="MyNamespace.MainWindow">
    <Button Content="Open Second Window" Click="OnOpenSecondWindow"/>
</Window>
```


SecondWindow.xaml：
```xml
<Window xmlns="https://github.com/avaloniaui"
        x:Class="MyNamespace.SecondWindow">
    <!-- Second window's content -->
</Window>
```

#### 1.2 打开新窗口

在C#代码中，你可以创建一个新的窗口对象并调用其Show方法来打开新窗口。

例如，以下代码在点击主窗口中的按钮时打开第二个窗口：

```c#
public void OnOpenSecondWindow(object sender, RoutedEventArgs e)
{
    var secondWindow = new SecondWindow();
    secondWindow.Show();
}
```

#### 1.3 关闭窗口

你可以调用窗口的Close方法来关闭窗口。例如，以下代码在点击第二个窗口中的按钮时关闭该窗口：


```c#
public void OnClose(object sender, RoutedEventArgs e)
{
    this.Close();
}
```

[注意] 当你关闭应用程序的最后一个窗口时，应用程序将退出。如果你想在关闭主窗口时保持应用程序运行，你可以在App.xaml.cs中重写'OnFrameworkInitializationCompleted'方法，并设置ShutdownMode为OnExplicitShutdown：


```c#
public override void OnFrameworkInitializationCompleted()
{
    Avalonia.Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
    base.OnFrameworkInitializationCompleted();
}

```
然后，你可以在适当的时候调用Application.Current.Shutdown来退出应用程序。


### 2. 发起一个https请求


#### 2.1 get请求

在C#中，你可以使用HttpClient类来发起HTTP请求。以下是一个发起GET请求的示例：
```C#
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync("https://api.github.com");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
        catch(HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ",e.Message);
        }
    }
}
```

在这个示例中，我们创建了一个HttpClient实例，然后使用GetAsync方法来发起一个GET请求。

GetAsync方法返回一个HttpResponseMessage对象，我们可以使用EnsureSuccessStatusCode方法来抛出一个异常，如果HTTP响应状态码不表示成功。

然后，我们使用ReadAsStringAsync方法来获取响应的内容。

注意，HttpClient实例应该在应用程序的生命周期中重用，而不是为每个请求创建一个新的实例。

#### 2.2 post请求

```C#
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        var content = new StringContent("{\"key\":\"value\"}", Encoding.UTF8, "application/json");

        try
        {
            HttpResponseMessage response = await client.PostAsync("https://api.github.com", content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
        catch(HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ",e.Message);
        }
    }
}
```

在这个示例中，我们创建了一个StringContent对象来表示请求的内容，然后使用PostAsync方法来发起一个POST请求。


#### 2.3 设置请求头

在C#中，你可以使用HttpClient的DefaultRequestHeaders属性来设置请求头。

以下是一个设置User-Agent请求头的示例：

```C#
client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
```

#### 2.4 共享cookie


要共享Cookie，你可以使用HttpClientHandler并设置其UseCookies属性为true，然后将其传递给HttpClient的构造函数。

HttpClientHandler会自动管理一个CookieContainer，在所有请求之间共享Cookie。

```C#
var handler = new HttpClientHandler();
handler.UseCookies = true;
var client = new HttpClient(handler);

// 现在，client会在所有请求之间共享Cookie

```

#### 2.5 设置请求超时

你可以使用Timeout属性来设置请求的超时时间。
```C#
var client = new HttpClient();
client.Timeout = TimeSpan.FromSeconds(10);
```

#### 2.6 设置代理

你可以使用DefaultProxy属性来设置默认的代理。
```C#
var handler = new HttpClientHandler();
handler.UseProxy = true;
```

#### 2.7 设置证书
你可以使用ClientCertificate属性来设置客户端证书。
```C#
var handler = new HttpClientHandler();
handler.ClientCertificateOptions = ClientCertificateOption.Manual;
```

#### 2.8 设置请求重试
你可以使用RetryPolicy属性来设置请求的重试策略。
```C#
var handler = new HttpClientHandler();
handler.MaxAutomaticRedirections = 10;
```

#### 2.9 设置请求重定向
你可以使用AllowAutoRedirect属性来设置请求的重定向。
```C#
var handler = new HttpClientHandler();
handler.AllowAutoRedirect = false;
```

#### 2.10 设置请求内容
你可以使用Content属性来设置请求的内容。
```C#
var client = new HttpClient();
var content = new StringContent("Request Body");
```

#### 2.11 json格式
```C#
var client = new HttpClient();
var content = new StringContent("{\"name\":\"John\"}", Encoding.UTF8, "application/json");
```




3. 调用系统功能

在.NET中，你可以通过P/Invoke（Platform Invocation Services）来调用系统API。P/Invoke允许你调用在非托管动态链接库（如DLL）中定义的函数，这些函数通常是C或C++编写的。

以下是一个简单的例子，展示了如何在C#中使用P/Invoke调用Windows API的MessageBox函数：

```C#
using System.Runtime.InteropServices;

public class Program
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    static void Main()
    {
        MessageBox(IntPtr.Zero, "Hello, World!", "Test", 0);
    }
}
```


在这个例子中，DllImport属性告诉.NET运行时在哪里找到这个函数（在这种情况下是user32.dll），以及函数的名称（在这种情况下是MessageBox）。然后，你可以像调用普通的C#函数一样调用这个函数。


示例：修改系统时间

在Windows系统中，你可以使用SetSystemTime API来修改系统时间。

以下是一个C#示例：

```C#
using System;
using System.Runtime.InteropServices;

public class Program
{
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool SetSystemTime(ref SYSTEMTIME st);

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }

    public static void Main()
    {
        SYSTEMTIME st = new SYSTEMTIME();
        st.wYear = 2022; // 年
        st.wMonth = 12; // 月
        st.wDay = 31; // 日
        st.wHour = 23; // 时
        st.wMinute = 59; // 分
        st.wSecond = 59; // 秒

        SetSystemTime(ref st); // 设置系统时间
    }
}
```

注意：修改系统时间需要管理员权限,如果你的应用程序没有管理员权限，这个调用会失败。

在Linux系统中，你可以使用date命令来修改系统时间，但这需要在shell中执行，而不是直接在C#中执行。

你可以使用System.Diagnostics.Process类来执行shell命令。


4. 打包

（1）安装打包工具
```
dotnet tool install --global dotnet-deb
```

打windows安装包

```bash
dotnet publish -c Release -r win-x64
dotnet publish -c Release -r win-x86
dotnet publish -c Release -r win-arm64
dotnet publish -c Release -r win-arm
```

打linux安装包
```bash
dotnet publish -c Release -r linux-x64
dotnet publish -c Release -r linux-x86
dotnet publish -c Release -r linux-arm64
dotnet publish -c Release -r linux-arm
```

打mac安装包

```bash
dotnet publish -c Release -r osx-x64
dotnet publish -c Release -r osx-arm64
```

5. 单元测试

在 .NET Core 7 和 VSCode 环境中，你需要确保已经安装了 Xunit 测试框架。你可以通过 .NET CLI 来安装 Xunit。

打开终端，然后在你的项目目录中运行以下命令：

```bash
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
```

这将会添加 Xunit 和 Xunit 测试运行器到你的项目中。

然后，你需要在你的 .csproj 文件中检查 Xunit 的引用是否存在。它应该看起来像这样：\


```xml
<ItemGroup>
    <PackageReference Include="xunit" Version="2.4.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.4.3" />
</ItemGroup>
```

如果你已经做了以上的步骤，但是仍然看到错误，那么可能是因为你的 IDE 没有正确地加载项目的依赖。你可以尝试关闭 VSCode，然后重新打开你的项目，看看是否解决了问题。

如果问题仍然存在，你可能需要清理你的项目并重新构建。你可以在终端中运行以下命令来完成这个操作：

清除缓存

运行单元测试脚本

```bash
dotnet test
```

```bash
dotnet test --filter FullyQualifiedName~MyNamespace.MyTest
```

其他项目，通过 NuGet 包管理器来添加 Xunit 的引用，安装C# 单元测试库

```bash
dotnet add package Xunit
```


6. 清除缓存

```bash
dotnet clean
dotnet build
```


7. 报错”/Users/liyinchi/workspace/C#/MyAvaloniaApp/.history/MainWindow_20231107202706.axaml : Avalonia error AVLN:0002: Duplicate x:Class directive, MyAvaloniaApp.MainWindow is already used in /.history/MainWindow_20231107173732.axaml [/Users/liyinchi/workspace/C#/MyAvaloniaApp/MyAvaloniaApp.csproj]“

原因：我用的是vscode 历史插件，会自动生成一个.history文件夹，文件夹里就有MainWindow_20231108104157.axaml、ainWindow_20231108102528.axaml这些文件，VS Code 的历史插件确实会在 .history 文件夹中生成历史版本的文件。然而，这些文件不应该被包含在你的项目编译中。这可能是你遇到这个错误的原因。

解决办法：
你需要在你的 CSharpGUI.csproj 项目文件中排除 .history 文件夹。你可以通过编辑 CSharpGUI.csproj 文件来实现这一点，添加一个 <Compile Remove=".history\**" /> 条目来排除 .history 文件夹。

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <!-- 其他项目设置... -->

  <ItemGroup>
    <Compile Remove=".history\**" />
    <EmbeddedResource Remove=".history\**" />
    <None Remove=".history\**" />
    <Page Remove=".history\**" />
    <AvaloniaResource Remove=".history\**" />
</ItemGroup>

</Project>
```



8. 报错了”/Users/liyinchi/workspace/C#/MyAvaloniaApp/Program.cs(12,24): error CS0017: 程序定义了多个入口点。使用 /main (指定包含入口点的类型)进行编译。 [/Users/liyinchi/workspace/C#/MyAvaloniaApp/MyAvaloniaApp.csproj]“

这个错误表明你的项目中定义了多个入口点，也就是说有多个 Main 方法。在 C# 程序中，只能有一个 Main 方法作为程序的入口点。

你需要检查你的项目中的所有文件，找出所有包含 Main 方法的地方，然后删除或者注释掉多余的 Main 方法。

例如，如果你在 Program.cs 和 AnotherFile.cs 中都定义了 Main 方法，你可以选择保留 Program.cs 中的 Main 方法，并删除或注释掉 AnotherFile.cs 中的 Main 方法。

如果你想保留多个 Main 方法，你可以使用编译选项 /main 来指定包含程序入口点的类型。例如，如果你想让 Program 类的 Main 方法作为程序的入口点，你可以在项目文件（.csproj）中添加以下编译选项：


解决办法：

```xml
<PropertyGroup>
    <StartupObject>MyAvaloniaApp.Program</StartupObject>
</PropertyGroup>
```

在这个例子中，MyAvaloniaApp 是你的命名空间，Program 是包含 Main 方法的类。

然后，重新编译你的项目，这个问题应该就解决了。



9. 报错“无法从“obj/Debug/net6.0/refint/MyAvaloniaApp.dll”提取 MVID。是否确定它是引用程序集?
  MyAvaloniaApp -> /Users/liyinchi/workspace/C#/MyAvaloniaApp/bin/Debug/net6.0/MyAvaloniaApp.dll”

解决办法：

(1)清理并重新构建项目：在命令行中，导航到你的项目目录，然后运行以下命令：

```bash
dotnet clean
dotnet build
```

(2)dotnet clean 命令会删除所有生成的文件（如 .dll 和 .exe 文件），dotnet build 命令会重新构建项目。

删除 obj 和 bin 目录：如果清理并重新构建项目没有解决问题，你可以尝试手动删除 obj 和 bin 目录，然后重新构建项目。这两个目录包含了构建过程中生成的临时文件和输出文件。

(3)检查项目文件：
打开你的 .csproj 文件，检查是否有任何错误或遗漏的引用。
确保所有的项目引用和包引用都是正确的。


10. 报错了“/Users/liyinchi/workspace/C#/CSharpGUI/MainWindow.axaml(9,6,9,6): Avalonia error AVLN:0004: Unable to find a setter that allows multiple assignments to the property Child of type Avalonia.Controls:Avalonia.Controls.Decorator Line 9, position 6. [/Users/liyinchi/workspace/C#/CSharpGUI/CSharpGUI.csproj]”

原因：因为你在 Border 控件中直接放置了多个子控件。在 Avalonia UI 中，Border 控件只能包含一个子控件。如果你想在 Border 中放置多个控件，你需要使用一个容器控件，如 StackPanel 或 Grid。

解决办法：StackPanel 是 Border 的唯一子控件，然后 TextBox 和 Button 控件都是 StackPanel 的子控件。这样就可以在 Border 中放置多个控件了。

11. 报错了“error CS0246: 未能找到类型或命名空间名“MessageBoxWindow”(是否缺少 using 指令或程序集引用”

解决办法：

12. 报错了”Application”未包含“Windows”的定义，并且找不到可接受第一个“Application”类型参数的可访问扩展方法“Windows”(是否缺少 using 指令或程序集引用?)“

解决办法：


13. 报错了“Unhandled exception. System.InvalidOperationException: The window is already being shown.”

原因：这个错误是因为你试图显示一个已经显示的窗口。在Avalonia框架中，一个窗口只能被显示一次。如果你想再次显示这个窗口，你需要重新创建一个新的窗口实例。

解决办法：你可以在显示窗口之后将其设置为null，然后在需要显示时再创建新的实例。

```c#
// 按钮点击事件处理函数
private void OnClickLoginBut(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
{
    // 获取输入框的值
    string? account = this.FindControl<TextBox>("Account")?.Text;
    string? password = this.FindControl<TextBox>("Password")?.Text;

    // 在这里处理登录逻辑...

    // 判断是否为空
    if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
    {
        // 弹窗提示
        _messageBox?.ShowDialog(this);
        // 设置为null
        _messageBox = null;
    }
    else
    {
        // 隐藏当前窗口
        this.Hide();

        // 检查是否已经存在SecondWindow实例
        if (_secondWindow == null)
        {
            // 如果不存在，则创建新的实例
            _secondWindow = new SecondWindow();
        }
        
        // 显示SecondWindow实例
        _secondWindow.Show();
    }
}
```
然后在需要显示messageBox时，检查是否为null，如果是null则创建新的实例：
```c#
if (_messageBox == null)
{
    _messageBox = new Window
    {
        // ...省略其他代码
    };
}
_messageBox.ShowDialog(this);
```


