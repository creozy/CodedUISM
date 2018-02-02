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
            mainWindow.SearchProperties[WpfWindow.PropertyNames.Name] = "Service Manager20.1 20.1.86.107687 (20.1)";
            mainWindow.WindowTitles.Add("Service Manager20.1 20.1.86.107687 (20.1)");

            #endregion
        }
    }
}
