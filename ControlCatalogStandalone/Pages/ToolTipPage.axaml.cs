using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ControlCatalogStandalone.Pages
{
    public partial class ToolTipPage : UserControl
    {
        public ToolTipPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
