using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ControlCatalogStandalone.Pages
{
    public partial class CheckBoxPage : UserControl
    {
        public CheckBoxPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
