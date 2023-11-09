using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Linq;

namespace CSharpGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 添加按钮点击事件监听
            Button? loginButton = this.FindControl<Button>("LoginBut");
            if (loginButton != null)
            {
                loginButton.Click += OnClickLoginBut;
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

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
                // 提示
                var messageBox = new Window
                {
                    Title = "提示",
                    Content = new TextBlock
                    {
                        Text = "账号或密码不能为空！",
                        // 居中对齐
                        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                        // 字体大小
                        FontSize = 20,
                        // 字体颜色
                        Foreground = new SolidColorBrush(Colors.Red)
                    },
                    Width = 200,
                    Height = 100,
                    // 居中对齐
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                };
                // 弹窗提示
                messageBox.ShowDialog(this);
            }
            else
            {
                // 隐藏当前窗口
                this.Hide();

                // 创建新的SecondWindow实例并显示
                var secondWindow = new SecondWindow();
                secondWindow.Show();
            }
        }
        private void OnClickLoginBut(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // 获取输入框的值
            string? account = this.FindControl<TextBox>("Account")?.Text;
            string? password = this.FindControl<TextBox>("Password")?.Text;

            // 在这里处理登录逻辑...

            // 判断是否为空
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                // 提示
                var messageBox = new Window
                {
                    Title = "提示",
                    Content = new TextBlock
                    {
                        Text = "账号或密码不能为空！",
                        // 居中对齐
                        HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                        VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                        // 字体大小
                        FontSize = 20,
                        // 字体颜色
                        Foreground = new SolidColorBrush(Colors.Red)
                    },
                    Width = 200,
                    Height = 100,
                    // 居中对齐
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                };
                // 弹窗提示
                messageBox.ShowDialog(this);
            }
            else
            {
                // 隐藏当前窗口
                this.Hide();

                // 创建新的SecondWindow实例并显示
                var secondWindow = new SecondWindow();
                secondWindow.Show();
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .Start<MainWindow>();
        }
    }
}