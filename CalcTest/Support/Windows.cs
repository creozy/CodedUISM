using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace White
{
    public static class Windows
    {
        private static Application _app;

        public static MainWindow Main
        {
            get
            {
                Window window = GetWindow("Service Manager20.1 20.1.86.107687 (20.1)");
                return new MainWindow(window);
            }
        }

        public static NewServerWindow NewServerName
        {
            get
            {
                Window window = GetWindow("Server name");
                return new NewServerWindow(window);
             }
        }

        public static NewPokerTableGroupWindow NewPokerTable
        {
            get
            {
                Window window = GetWindow("New Poker Table Group");
                return new NewPokerTableGroupWindow(window);
            }
        }

        public static void Init (Application app)
        {
            _app = app;
        }

        private static Window GetWindow(string title)
        {
            return Retry.For(
                () => _app.GetWindows().First(x => x.Title.Contains(title)),
                TimeSpan.FromSeconds(5));
        }
    }
}