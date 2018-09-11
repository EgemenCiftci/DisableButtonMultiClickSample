using System.Windows.Input;

namespace DisableButtonMultiClickSample
{
    public class VM
    {
        public virtual int ClickCount { get; set; }

        public void Click()
        {
            ClickCount++;
        }

        public void PreviewMouseDoubleClick(MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
