using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ControlCatalogStandalone.Pages
{
    public partial class BorderPage : UserControl
    {
        public BorderPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
