using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace White
{
    public class WindowObject
    {
        protected Window _window;

        protected WindowObject(Window window)
        {
            _window = window;
        }
     
        protected Button Button(string title)
        {
            return _window.Get<Button>(SearchCriteria.ByAutomationId(title));
        }

        protected TextBox TextBox(string title)
        {
            return _window.Get<TextBox>(SearchCriteria.ByAutomationId(title));
        }

        protected ComboBox ComboBox(string title)
        {
            return _window.Get<ComboBox>(SearchCriteria.ByAutomationId(title));
        }
         protected CheckBox CheckBox(string title)
        {
            return _window.Get<CheckBox>(SearchCriteria.ByAutomationId(title));
        }
        protected ListItem Selectvalue(string value)
        {
            return _window.Get<ListItem>(SearchCriteria.ByText(value));
        }
      
    }
}