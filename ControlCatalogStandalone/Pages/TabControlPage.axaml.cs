using System;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using ControlCatalogStandalone.ViewModels;

namespace ControlCatalogStandalone.Pages
{
    using System.Collections.Generic;

    public partial class TabControlPage : UserControl
    {
        public TabControlPage()
        {
            InitializeComponent();

            DataContext = new TabControlPageViewModel
            {
                Tabs = new[]
                {
                    new TabControlPageViewModelItem
                    {
                        Header = "Arch",
                        Text = "This is the first templated tab page.",
                         Image = LoadBitmap("avares://ControlCatalogStandalone/Assets/delicate-arch-896885_640.jpg"),
                    },
                    new TabControlPageViewModelItem
                    {
                        Header = "Leaf",
                        Text = "This is the second templated tab page.",
                        Image = LoadBitmap("avares://ControlCatalogStandalone/Assets/maple-leaf-888807_640.jpg"),
                    },
                    new TabControlPageViewModelItem
                    {
                        Header = "Disabled",
                        Text = "You should not see this.",
                        IsEnabled = false,
                    },
                },
                TabPlacement = Dock.Top,
            };
        }


        private static Bitmap LoadBitmap(string uri)
        {
            return new Bitmap(AssetLoader.Open(new Uri(uri)));  
        }
    }
}
