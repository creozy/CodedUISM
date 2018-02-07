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
    public partial class UnitTest1
    {
        private TestStack.White.Application app;

        [TestInitialize]
        public void TestSetUp()
        {
            //string ApplicationPath = @"C:\Windows\system32\calc.exe";
            //app = TestStack.White.Application.Launch(ApplicationPath);
            app = TestStack.White.Application.Attach(10824);
        }


        [TestMethod]
        public void TestMethod1()
        {
            Windows.Init(app);
            Windows.Main.ClickActions2();
            //Windows.Main.AddNewServer();
            //Windows.NewServerName.Create("ygs.t2", "http://ygs.20.2.t2.connectivegames.com", "admin", "Admin", true);

            /* bool check = Windows.NewServerName.Assertions("Test Server");
             Assert.IsTrue(check, "Not passed");

            bool check1 = Windows.Main.AssertServerAdded("ygs.t2");
            Assert.IsTrue(check1, "Not added");*/
            
         }
        
        [TestMethod]

        public void TestMethod2()
        {
            Windows.Init(app);
            Windows.NewPokerTable.CreateTable(TableName,/*Tabletags,*/TableCurrency,/*TableGame,*/TableLS,TableHS,TableAnte,TableBIMin,TableBIMax,TableSeats,TableCap,TableRake,
            TableStraddle,TableMin,TableMax,TableFreeSeats,TableBBJ,TableAnonym,TableRIT,TableDP,TablePass,TableUAC,TableReconnect,TableChat,TableActTime,TableTimeBank,TableTBInc);

            
        }

      /*  [TestCleanup]
        public void TearDown()
        {
            app.Close();
        }*/
    }
}
