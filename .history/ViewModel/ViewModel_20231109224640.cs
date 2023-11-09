using System.ComponentModel;

// 命名空间：CSharpGUI
namespace CSharpGUI
{
    // 创建一个 ViewModel 类，实现 INotifyPropertyChanged 接口
    public class ViewModel : INotifyPropertyChanged
    {
        // 私有字段：_message，用于存储消息
        private string _message;
        
        // 公共属性：Message，用于获取和设置消息的值
        public string Message
        {
            // get 私有字段
            get { return _message; }
            // set 私有字段
            set
            {
                // 如果消息的值发生变化
                if (_message != value)
                {
                    // 更新消息的值
                    _message = value;
                    // 调用 OnPropertyChanged 方法，通知属性变化
                    OnPropertyChanged(nameof(Message));
                }
            }
        }

        // 定义 PropertyChanged 事件
        public event PropertyChangedEventHandler PropertyChanged;

        // 触发 PropertyChanged 事件的方法
        protected virtual void OnPropertyChanged(string propertyName)
        {
            // 如果 PropertyChanged 事件不为空，则调用事件
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}