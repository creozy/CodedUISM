using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WPFUIItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowStripControls;


namespace White
{
    [TestClass]
    public class UnitTest1
    {
        private TestStack.White.Application app;

        [TestInitialize]
        public void TestSetUp()
        {
            //string ApplicationPath = @"C:\Windows\system32\calc.exe";
            //app = TestStack.White.Application.Launch(ApplicationPath);
            app = TestStack.White.Application.Attach(6172);
        }


        [TestMethod]
        public void TestMethod1()
        {
            Windows.Init(app);
            Windows.Main.AddNewServer();
            Windows.NewServerName.Create("Test Server", "http://test.url", "loginadmina", "Parol", false);

            bool check = Windows.NewServerName.Assertions("Test Server");
            Assert.IsTrue(check, "Not passed");
            
         }
        
        [TestMethod]

        public void TestMethod2()
        {
            Windows.Init(app);
            Windows.NewPokerTable.CreateTable("razrazraz");
        }

      /*  [TestCleanup]
        public void TearDown()
        {
            app.Close();
        }*/
    }
}
