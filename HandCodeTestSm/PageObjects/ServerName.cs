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
        public void ServerNameTest()
        {
            string Name = "Server Name";
            #region ServerNameWindow
            
            WpfWindow ServerName = new WpfWindow();
            ServerName.SearchProperties[WpfWindow.PropertyNames.Name] = "Server name";
            ServerName.WindowTitles.Add(Name);

            WpfEdit ServNameEdit = new WpfEdit(ServerName);
            ServNameEdit.WindowTitles.Add(Name);
            ServNameEdit.TechnologyName = "MSAA";
            ServNameEdit.SearchProperties.Add("ControlType", "Edit");
            ServNameEdit.SearchProperties[WpfEdit.PropertyNames.Name] = "Server Name";

            WpfEdit ServUrlEdit = new WpfEdit(ServerName);
            ServUrlEdit.WindowTitles.Add(Name);
            ServUrlEdit.TechnologyName = "MSAA";
            ServUrlEdit.SearchProperties.Add("ControlType", "Edit");
            ServUrlEdit.SearchProperties[WpfEdit.PropertyNames.Name] = "http://server.url";

            WpfEdit AdminLogin = new WpfEdit(ServerName);
            AdminLogin.WindowTitles.Add(Name);
            AdminLogin.TechnologyName = "MSAA";
            AdminLogin.SearchProperties.Add("ControlType", "Edit");
            AdminLogin.SearchProperties[WpfEdit.PropertyNames.Name] = "(none)";

            WpfEdit AdminPass = new WpfEdit(ServerName);
            AdminPass.WindowTitles.Add(Name);
            AdminPass.TechnologyName = "MSAA";
            AdminPass.SearchProperties.Add("ControlType", "Edit");
            AdminPass.SearchProperties[WpfEdit.PropertyNames.Name] = "PasswordTextEdit";

            WpfButton SaveButton = new WpfButton(ServerName);
            SaveButton.WindowTitles.Add(Name);
            SaveButton.TechnologyName = "MSAA";
            SaveButton.SearchProperties.Add("ControlType", "Button");
            SaveButton.SearchProperties[WpfButton.PropertyNames.Name] = "Save";

            WpfCheckBox PassRemember = new WpfCheckBox(ServerName);
            PassRemember.WindowTitles.Add(Name);
            PassRemember.TechnologyName = "MSAA";
            PassRemember.SearchProperties.Add("ControlType", "CheckBox");
            #endregion

          //  #region definition MainWindow
            WpfWindow mainWindow = new WpfWindow();
            mainWindow.SearchProperties[WpfWindow.PropertyNames.Name] = "Service Manager20.1 20.1.86.107687 (20.1)";
            mainWindow.WindowTitles.Add("Service Manager20.1 20.1.86.107687 (20.1)");

            WpfCell Servercell = new WpfCell(mainWindow);
            Servercell.WindowTitles.Add(SMname);
            Servercell.TechnologyName = "MSAA";
            Servercell.SearchProperties.Add("ControlType", "Cell");
            Servercell.SearchProperties[WpfCell.PropertyNames.Value] = "ygs.t1";

            WpfButton AddNewServer = new WpfButton(mainWindow);
            AddNewServer.WindowTitles.Add(SMname);
            AddNewServer.TechnologyName = "MSAA";
            AddNewServer.SearchProperties.Add("ControlType", "MenuItem");
            AddNewServer.SearchProperties[WpfButton.PropertyNames.Name] = "Add new server";
          //  #endregion


            double i = 0;
            
            try
            {
                Mouse.Click(Servercell);
                Playback.Wait(3000);
            }
            catch (UITestControlNotFoundException)
            {
                Mouse.Click(AddNewServer);
                Playback.Wait(3000);
                
                Keyboard.SendKeys(ServNameEdit, "ygs.t1");

                Keyboard.SendKeys(ServUrlEdit, "http://ygs.20.1.t1.connectivegames.com");

                Keyboard.SendKeys(AdminLogin, "admin");

                Keyboard.SendKeys(AdminPass, "Admin");
                                 
                try // Check admin name
                {
                    Assert.AreEqual("admin", AdminLogin.GetProperty("Text").ToString(), "Error in admin text");
                }
                catch (AssertFailedException)
                {
                    Console.WriteLine("Admin text not correct");
                    i++;
                }
                try //Check server name
                {
                    Assert.AreEqual("ygs.t1", ServNameEdit.GetProperty("Text").ToString(), "Error in server name text");
                }
                catch (AssertFailedException)
                {
                    Console.WriteLine("Server text not correct");
                    i++;
                }
                Mouse.Click(SaveButton);
            }
            Assert.AreEqual(0, i, 0, i + " Error(s) in test");
            
        }
    }
}
