using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;

namespace White
{
    public class NewServerWindow : WindowObject
    {

        private TextBox ServName => TextBox("control4");
        private TextBox ServUrl => TextBox("control6");
        private TextBox ServLogin => TextBox("control7");
        private TextBox ServPass => _window.Get<TextBox>(SearchCriteria.ByAutomationId("control8").AndByText("PasswordTextEdit"));
        private CheckBox SavePass => CheckBox("control9");
        private Button Save => Button("saveButton");
        private Button Close => _window.Get<Button>(SearchCriteria.ByAutomationId("closeButton").AndByText("Close"));

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