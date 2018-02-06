using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
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

        protected Button ButtonText(string title)
        {
            return _window.Get<Button>(SearchCriteria.ByText(title));
        }

        protected Button ButtonAID(string title)
        {
            return _window.Get<Button>(SearchCriteria.ByAutomationId(title));
        }

        protected Button Button(string title1 = null, string title2 = null)
        {
            return _window.Get<Button>(SearchCriteria.ByAutomationId(title1).AndByText(title2));
        }
    }
}