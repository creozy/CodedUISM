using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowStripControls;

namespace White
{
    public class MainWindow : WindowObject
    {
        private Menu AddNewServerButton
        {
            get
            {
                return _window.Get<Menu>(SearchCriteria.ByText("Add new server"));
            }
        }
        private Menu SettingsMenuButton
        {
            get
            {
               return _window.Get<Menu>(SearchCriteria.ByAutomationId("BarSplitButtonItemLink").AndByClassName("BarSplitButtonItemLinkControl"));
            }
        }
        private MenuBar Help
        {
            get
            {
                return _window.Get<MenuBar>(SearchCriteria.ByAutomationId("BarSubItemLink").AndByText("Help"));
            }
        }
        private Button About
        {
            get
            {
                return _window.Get<Button>(SearchCriteria.ByText("About"));
            }
        }
        private Menu Actions
        {
            get
            {
                return _window.Get<Menu>(SearchCriteria.ByText("Actions"));
            }
        }
        private Menu PokerGames
        {
            get
            {
               return _window.Get<Menu>(SearchCriteria.ByText("Poker Games"));
            }
        }
        private Menu PokerTable
        {
            get
            {
                return _window.Get<Menu>(SearchCriteria.ByText("Create poker table group"));
            }
        }

       

        internal MainWindow(Window window) : base (window) { }

        public void AddNewServer()
        {
           AddNewServerButton.Click();
        }

        public void AddPokerTable()
        {
            Actions.Click();
            PokerGames.Click();
            PokerTable.Click();

        }
    }
}