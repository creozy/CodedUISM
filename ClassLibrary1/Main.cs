using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.Finders;

using Xunit;

namespace SMWhite
{
    public class SmokeTest
    {
        [TestInitialize]
        public void TestSetUp()
        {

        }

        [Fact]
        public void MyFirstTest()
        {
            Application SM = Application.Launch(@"C:\Users\Creozy\Documents\SM\SM__(20.1)_20.1.46.106674\Launcher.exe");

            Window main = SM.GetWindow("Service Manager20.0new 20.1.86.107687");
            var AddButton = main.Get<Menu>();
            AddButton.("Add new server").Select();
           
        }
    }
}
