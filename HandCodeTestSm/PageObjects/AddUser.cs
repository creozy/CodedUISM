using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;

namespace HandCodeTestSm
{
    public partial class HandCode
    {
        public void AddUser()
        {
            #region definition AddUser
            WpfWindow mainWindow = new WpfWindow();
            mainWindow.SearchProperties[WpfWindow.PropertyNames.Name] = SMname;
            mainWindow.WindowTitles.Add(SMname);

            string Name = "Player";

            WpfWindow PlayerWindow = new WpfWindow();
            PlayerWindow.SearchProperties[WpfWindow.PropertyNames.Name] = Name;
            PlayerWindow.WindowTitles.Add(Name);

            WpfEdit PlayerLogin = new WpfEdit(PlayerWindow);
            PlayerLogin.WindowTitles.Add(Name);
            PlayerLogin.TechnologyName = "MSAA";
            PlayerLogin.SearchProperties.Add("ControlType", "Edit");
            PlayerLogin.SearchProperties.Add("ControlName", "control7");

            Keyboard.SendKeys(PlayerLogin, "ololo");

            #endregion
        }
    }
}
