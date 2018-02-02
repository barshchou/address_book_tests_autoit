using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        private AutoItX3 aux;
        public static string WINTITTLE = "Free Address Book";
        private GroupHelper groupHelper;

        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(@"c:\Free Address Book\AddressBook.exe", "", aux.SW_SHOW);
            aux.WinWait(WINTITTLE);
            aux.WinActivate(WINTITTLE);
            aux.WinWaitActive(WINTITTLE);
            groupHelper = new GroupHelper(this);
            //Doesn't work
        }

        public void Stop()
        {
            aux.ControlClick(WINTITTLE, "", "WindowsForms10.BUTTON.app.0.1114f8110");
        }

        public AutoItX3 Aux
        {
            get { return aux; }
        }

        public GroupHelper Groups
        {
            get { return groupHelper; }
        }
    }
}
