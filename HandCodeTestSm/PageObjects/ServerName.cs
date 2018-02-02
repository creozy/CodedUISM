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
            // 1. Launch SM
            /*string AppPath = "C:\\Users\\Creozy\\Documents\\SM\\SM__(20.1)_20.1.46.106674\\Launcher.exe";
              ApplicationUnderTest App = ApplicationUnderTest.Launch(AppPath);

              Playback.Wait(30000);*/
            //Main SM Window
            double i = 0;

            WpfWindow mainWindow = new WpfWindow();
            mainWindow.SearchProperties[WpfWindow.PropertyNames.Name] = SMname;
            mainWindow.WindowTitles.Add(SMname);

            //Check server is created
            //try
            //{
            try
            {
                WpfCell Servercell = new WpfCell(mainWindow);
                Servercell.WindowTitles.Add("Service Manager20.1 20.1.86.107687 (20.1)");
                Servercell.TechnologyName = "MSAA";
                Servercell.SearchProperties.Add("ControlType", "Cell");
                Servercell.SearchProperties[WpfCell.PropertyNames.Value] = "ygs.t1";
                //}
                Mouse.Click(Servercell);
                Playback.Wait(3000);
            }
            catch (UITestControlNotFoundException)
            {
                WpfButton AddNewServer = new WpfButton(mainWindow);
                AddNewServer.WindowTitles.Add("Service Manager20.1 20.1.86.107687 (20.1)");
                AddNewServer.TechnologyName = "MSAA";
                AddNewServer.SearchProperties.Add("ControlType", "MenuItem");
                AddNewServer.SearchProperties[WpfButton.PropertyNames.Name] = "Add new server";

                Mouse.Click(AddNewServer);
                Playback.Wait(3000);
                //Server name Window

                WpfWindow ServerName = new WpfWindow();
                ServerName.SearchProperties[WpfWindow.PropertyNames.Name] = "Server name";
                ServerName.WindowTitles.Add("Server name");

                WpfEdit ServNameEdit = new WpfEdit(ServerName);
                ServNameEdit.WindowTitles.Add("Server name");
                ServNameEdit.TechnologyName = "MSAA";
                ServNameEdit.SearchProperties.Add("ControlType", "Edit");
                ServNameEdit.SearchProperties[WpfEdit.PropertyNames.Name] = "Server Name";

                Keyboard.SendKeys(ServNameEdit, "ygs.t1");

                WpfEdit ServUrlEdit = new WpfEdit(ServerName);
                ServUrlEdit.WindowTitles.Add("Server name");
                ServUrlEdit.TechnologyName = "MSAA";
                ServUrlEdit.SearchProperties.Add("ControlType", "Edit");
                ServUrlEdit.SearchProperties[WpfEdit.PropertyNames.Name] = "http://server.url";

                Keyboard.SendKeys(ServUrlEdit, "http://ygs.20.1.t1.connectivegames.com");

                WpfEdit AdminLogin = new WpfEdit(ServerName);
                AdminLogin.WindowTitles.Add("Server name");
                AdminLogin.TechnologyName = "MSAA";
                AdminLogin.SearchProperties.Add("ControlType", "Edit");
                AdminLogin.SearchProperties[WpfEdit.PropertyNames.Name] = "(none)";

                Keyboard.SendKeys(AdminLogin, "admin");

                WpfEdit AdminPass = new WpfEdit(ServerName);
                AdminPass.WindowTitles.Add("Server name");
                AdminPass.TechnologyName = "MSAA";
                AdminPass.SearchProperties.Add("ControlType", "Edit");
                AdminPass.SearchProperties[WpfEdit.PropertyNames.Name] = "PasswordTextEdit";

                Keyboard.SendKeys(AdminPass, "Admin");

                /*WpfCheckBox PassRemember = new WpfCheckBox(ServerName);
                PassRemember.WindowTitles.Add("Server name");
                PassRemember.TechnologyName = "MSAA";
                PassRemember.SearchProperties.Add("ControlType", "CheckBox");
                PassRemember.SearchConfigurations[] = "control9";

                PassRemember.Checked = checked(true);
                */
                WpfButton SaveButton = new WpfButton(ServerName);
                SaveButton.WindowTitles.Add("Server name");
                SaveButton.TechnologyName = "MSAA";
                SaveButton.SearchProperties.Add("ControlType", "Button");
                SaveButton.SearchProperties[WpfButton.PropertyNames.Name] = "Save";

                try
                {
                    Assert.AreEqual("admin", AdminLogin.GetProperty("Text").ToString(), "Error in admin text");
                }
                catch (AssertFailedException)
                {
                    Console.WriteLine("Admin text not correct");
                    i++;
                }
                try
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
            // Mouse.Click(SaveButton);
        }
    }
}
