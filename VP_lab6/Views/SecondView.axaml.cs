using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace VP_lab6.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
