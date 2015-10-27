using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class FlispPersonData : DataPage
    {
        public FlispPersonData() 
            : base("Person", "pers_personid", "PersonBoxLong")
        {

        }

        public override void AddEditButton()
        {

            AddUrlButton("Edit", "edit.gif", UrlDotNet(ThisDotNetDll, "FlispPersonDataEdit"));
            //base.AddEditButton();
        }
    }
}
