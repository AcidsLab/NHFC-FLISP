using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class FlispDisplayCheckList : ListPage
    {
        public FlispDisplayCheckList()
            : base("ChecklistMaster", "ChecklistMasterList","ChecklistFilter")
        {
            
        }

        public override void AddNewButton()
        {

            AddUrlButton("New", "new.gif", UrlDotNet(ThisDotNetDll, "FlispNewCheckList"));
            //base.AddEditButton();



        }
    }
}
