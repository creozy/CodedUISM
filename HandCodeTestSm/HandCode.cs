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
    /// <summary>
    /// Сводное описание для CodedUITest1
    /// </summary>
    [CodedUITest]
    public partial class HandCode
    {

        public HandCode()
        {
           
        }

        [TestMethod]
        public void BasicTest()
        {
            ServerNameTest();
            
        }

        [TestMethod]


        public void LoginServer()
        {
            WpfWindow mainWindow = new WpfWindow();
            mainWindow.SearchProperties[WpfWindow.PropertyNames.Name] = SMname;
            mainWindow.WindowTitles.Add(SMname);

            this.UIMap.ForTest();


            /*UITestControl parent = new UITestControl(mainWindow);
            parent.WindowTitles.Add("Service Manager20.1 20.1.86.107687 (20.1)");
            parent.TechnologyName = "MSAA";
            parent.SearchProperties.Add("ControlType", "MenuBar");
            parent.SearchProperties[WpfButton.PropertyNames.Name] = "Tools";

            WpfButton Actions = new WpfButton(parent);
            Actions.WindowTitles.Add("Service Manager20.1 20.1.86.107687 (20.1)");
            Actions.TechnologyName = "MSAA";
            Actions.SearchProperties.Add("ControlType", "MenuItem");
            Actions.SearchProperties[WpfButton.PropertyNames.Name] = "Actions";

            Mouse.Click(Actions);



            WpfButton Login = new WpfButton(Actions);
            Actions.WindowTitles.Add("Service Manager20.1 20.1.86.107687 (20.1)");
            Actions.TechnologyName = "MSAA";
            Actions.SearchProperties.Add("ControlType", "MenuItem");
            Actions.SearchProperties[WpfButton.PropertyNames.Name] = "Login";

            Mouse.Click(Login);

            Playback.Wait(10000);*/

        }

        #region Дополнительные атрибуты тестирования

        // При написании тестов можно использовать следующие дополнительные атрибуты:

        ////TestInitialize используется для выполнения кода перед запуском каждого теста 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Чтобы создать код для этого теста, выберите в контекстном меню команду "Формирование кода для кодированного теста пользовательского интерфейса", а затем выберите один из пунктов меню.
        //}

        ////TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Чтобы создать код для этого теста, выберите в контекстном меню команду "Формирование кода для кодированного теста пользовательского интерфейса", а затем выберите один из пунктов меню.
        //}

        #endregion

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
