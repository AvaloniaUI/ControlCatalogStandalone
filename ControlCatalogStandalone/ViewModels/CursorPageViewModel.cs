using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using MiniMvvm;

namespace ControlCatalogStandalone.ViewModels
{
    public class CursorPageViewModel : ViewModelBase
    {
        public CursorPageViewModel()
        {
            StandardCursors = Enum.GetValues(typeof(StandardCursorType))
                .Cast<StandardCursorType>()
                .Select(x => new StandardCursorModel(x))
                .ToList();
            var bitmap =
                new Bitmap(AssetLoader.Open(new Uri("avares://ControlCatalogStandalone/Assets/avalonia-32.png")));
            CustomCursor = new Cursor(bitmap, new PixelPoint(16, 16));
        }

        public IEnumerable<StandardCursorModel> StandardCursors { get; }

        public Cursor CustomCursor { get; }
    }

    public class StandardCursorModel
    {
        public StandardCursorModel(StandardCursorType type)
        {
            Type = type;
            Cursor = new Cursor(type);
        }

        public StandardCursorType Type { get; }

        public Cursor Cursor { get; }
    }
}