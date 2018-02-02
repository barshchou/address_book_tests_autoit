using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    public class GroupHelper : HelperBase
    {
        public static string GROUPWINTITTLE = "Group Editor";
        public GroupHelper(ApplicationManager manager) : base(manager)
        {

        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>();
            OpenGroupDialogue();
            string count = aux.ControlTreeView(GROUPWINTITTLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", 
                    "GetItemCount", "#0","");
            int.Parse(count);
            for (int i = 0; i < int.Parse(count); i++)
            {
                string item = aux.ControlTreeView(GROUPWINTITTLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                    "GetText", "#0|#" + i, "");
                list.Add(new GroupData()
                {
                    Name = item
                });
            }
            CloseDialogue();
            return list;
        }

        public void AddGroup(GroupData newGroup)
        {
            OpenGroupDialogue();
            aux.ControlClick(GROUPWINTITTLE, "","WindowsForms10.BUTTON.app.0.1114f813");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            CloseDialogue();

        }

        private void CloseDialogue()
        {
            aux.ControlClick(GROUPWINTITTLE, "", "WindowsForms10.BUTTON.app.0.1114f814");
        }

        private void OpenGroupDialogue()
        {
            aux.ControlClick(WINTITTLE, "", "WindowsForms10.BUTTON.app.0.1114f8112");
            aux.WinWait(GROUPWINTITTLE);
        }
    }
}