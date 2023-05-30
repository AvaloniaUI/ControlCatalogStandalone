using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Notifications;
using Avalonia.Dialogs;
using Avalonia.Platform;
using Avalonia.Reactive;
using System;
using System.ComponentModel.DataAnnotations;
using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
using MiniMvvm;

namespace ControlCatalogStandalone.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty] private bool _isMenuItemChecked = true;
        [ObservableProperty] private WindowState _windowState;
        [ObservableProperty] private WindowState[] _windowStates = Array.Empty<WindowState>();

        [ObservableProperty]
        private ExtendClientAreaChromeHints _chromeHints = ExtendClientAreaChromeHints.PreferSystemChrome;

        [ObservableProperty] private bool _extendClientAreaEnabled;
        [ObservableProperty] private bool _systemTitleBarEnabled;
        [ObservableProperty] private bool _preferSystemChromeEnabled;
        [ObservableProperty] private double _titleBarHeight;
        [ObservableProperty] private bool _isSystemBarVisible;
        [ObservableProperty] private bool _displayEdgeToEdge;
        [ObservableProperty] private Thickness _safeAreaPadding;
        [ObservableProperty] private DateTime? _validatedDateExample;

        public MainWindowViewModel()
        {
            AboutCommand = MiniCommand.CreateFromTask(async () =>
            {
                var dialog = new AboutAvaloniaDialog();

                if ((Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow is
                    { } mainWindow)
                {
                    await dialog.ShowDialog(mainWindow);
                }
            });
            ExitCommand = MiniCommand.Create(() =>
            {
                (Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.Shutdown();
            });

            ToggleMenuItemCheckedCommand = MiniCommand.Create(() => { IsMenuItemChecked = !IsMenuItemChecked; });

            WindowState = WindowState.Normal;

            WindowStates = new WindowState[]
            {
                WindowState.Minimized,
                WindowState.Normal,
                WindowState.Maximized,
                WindowState.FullScreen,
            };

            this.WhenAnyValue(x => x.SystemTitleBarEnabled, x => x.PreferSystemChromeEnabled)
                .Subscribe(x =>
                {
                    var hints = ExtendClientAreaChromeHints.NoChrome | ExtendClientAreaChromeHints.OSXThickTitleBar;

                    if (x.Item1)
                    {
                        hints |= ExtendClientAreaChromeHints.SystemChrome;
                    }

                    if (x.Item2)
                    {
                        hints |= ExtendClientAreaChromeHints.PreferSystemChrome;
                    }

                    ChromeHints = hints;
                });

            SystemTitleBarEnabled = true;
            TitleBarHeight = -1;
        }


        public MiniCommand AboutCommand { get; }

        public MiniCommand ExitCommand { get; }

        public MiniCommand ToggleMenuItemCheckedCommand { get; }
    }
}