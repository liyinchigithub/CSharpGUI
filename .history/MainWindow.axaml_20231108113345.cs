using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CSharpGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 添加按钮点击事件监听
            this.FindControl<Button>("LoginBut").Click += OnClickLoginBut;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        // 按钮点击事件处理函数
        private void OnClickLoginBut(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // 获取输入框的值
            string account = this.FindControl<TextBox>("Account").Text;
            string password = this.FindControl<TextBox>("Password").Text;

            // 在这里处理登录逻辑...
            // 弹窗提示
            // 创建消息框
            var messageBox = new Window
            {
                Title = "提示",
                Content = new TextBlock { Text = "登录成功！" },
                Width = 200,
                Height = 100
            };
        }
    }
}