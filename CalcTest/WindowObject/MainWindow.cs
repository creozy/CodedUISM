using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.TreeItems;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace White
{
    public class MainWindow : WindowObject
    {
        private Menu AddNewServerButton => _window.Get<Menu>(SearchCriteria.ByText("Add new server"));
        private Menu SettingsMenuButton => _window.Get<Menu>(SearchCriteria.ByAutomationId("BarSplitButtonItemLink").AndByClassName("BarSplitButtonItemLinkControl"));
        private MenuBar Help => _window.Get<MenuBar>(SearchCriteria.ByAutomationId("BarSubItemLink").AndByText("Help"));
        private Button About => _window.Get<Button>(SearchCriteria.ByText("About"));
        private Menu Actions => _window.Get<Menu>(SearchCriteria.ByText("Actions"));
        private Panel gridNavigations => _window.Get<Panel>(SearchCriteria.ByAutomationId("gridNavigator"));
        private Menu Actions2 => gridNavigations.Get<Menu>(SearchCriteria.ByText("Actions"));
        private Menu PokerGames => _window.Get<Menu>(SearchCriteria.ByText("Poker Games"));
        private Menu PokerTable => _window.Get<Menu>(SearchCriteria.ByText("Create poker table group"));
        private TreeNode ServerNameYgs => _window.Get<TreeNode>(SearchCriteria.ByText("Node0"));

        private Panel Filters => _window.Get<Panel>(SearchCriteria.ByAutomationId("filterCtrl"));
        private Menu Apply => _window.Get<Menu>(SearchCriteria.ByText("Apply"));
        private TextBox FilterName => TextBox("control4");
        private ListViewRow Cell => _window.Get<ListViewRow>(SearchCriteria.ByText("CreoZyTestTable3"));

        
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
        public void ClickActions2()
        {
            Cell.DoubleClick();
        }

        public bool AssertServerAdded (string name)
        {
            return ServerNameYgs.Name == name;
        }
    }
}