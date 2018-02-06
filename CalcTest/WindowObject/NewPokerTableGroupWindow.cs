using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.PropertyGridItems;

namespace White
{
    public class NewPokerTableGroupWindow : WindowObject
    {
        internal NewPokerTableGroupWindow(Window window) : base (window) { }

        private TextBox TableName
        {
            get
            {
               return _window.Get<TextBox>(SearchCriteria.ByAutomationId("nameEdit"));
            }
        }
        private ListBox TableTags
        {
            get
            {
                return _window.Get<ListBox>(SearchCriteria.ByAutomationId("tagsTokenEdit"));
            }
        }
        private PropertyGrid StakesBlock
        {
            get
            {
               return _window.Get<PropertyGrid>(SearchCriteria.ByAutomationId("stakesTextRangeControl"));
            }
        }
        private TextBox StakesLow
        {
            get
            {
                return StakesBlock.GetElement<TextBox>(SearchCriteria.ByAutomationId("fromTextEdit"));
            }
        }
        public void CreateTable (string T_name)
        {
            TableName.Text = T_name;
        }
    }
}
