using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;

namespace White
{
    public class NewServerWindow : WindowObject
    {
       
        private TextBox ServName
        {
            get
            {
                return _window.Get<TextBox>(SearchCriteria.ByAutomationId("control4"));
            }
        }
        private TextBox ServUrl
        {
            get
            {
                return _window.Get<TextBox>(SearchCriteria.ByAutomationId("control6"));
            }
        }
        private TextBox ServLogin
        {
            get
            {
                return _window.Get<TextBox>(SearchCriteria.ByAutomationId("control7"));
            }
        }
        private TextBox ServPass
        {
            get
            {
                return _window.Get<TextBox>(SearchCriteria.ByAutomationId("control8").AndByText("PasswordTextEdit"));
            }
        }
        private CheckBox SavePass
        {
            get
            {
                return _window.Get<CheckBox>(SearchCriteria.ByAutomationId("control9"));
            }
        }
        private Button Save
        {
            get
            {
                return ButtonAID("saveButton");
            }
        }
        private Button Close
        {
            get
            {
                return _window.Get<Button>(SearchCriteria.ByAutomationId("closeButton").AndByText("Close"));
            }
        }

        internal NewServerWindow(Window window) : base (window) { }

        public void Create(string SName, string SUrl, string SLogin, string SPass, bool Check)
        {
            ServName.Text = SName;
            ServUrl.Text = SUrl;
            ServLogin.Text = SLogin;
            ServPass.Text = SPass;
            if (Check == true) SavePass.Select();
            Save.Click();

        }

        public bool Assertions(string SName)
        {
           return ServName.Text == SName; 
        }
    }
}