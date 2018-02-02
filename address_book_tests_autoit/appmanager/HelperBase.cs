using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;


namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected string WINTITTLE = "Free Address Book";
        protected AutoItX3 aux;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            WINTITTLE = ApplicationManager.WINTITTLE;
            this.aux = manager.Aux;
        }
    }
}