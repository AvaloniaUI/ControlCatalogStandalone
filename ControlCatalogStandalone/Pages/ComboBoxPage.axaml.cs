using System.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using ControlCatalogStandalone.ViewModels;

namespace ControlCatalogStandalone.Pages
{
    public partial class ComboBoxPage : UserControl
    {
        public ComboBoxPage()
        {
            InitializeComponent();
            DataContext = new ComboBoxPageViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            var fontComboBox = this.Get<ComboBox>("fontComboBox");
            fontComboBox.ItemsSource = FontManager.Current.SystemFonts;
            fontComboBox.SelectedIndex = 0;
        }
    }
}
