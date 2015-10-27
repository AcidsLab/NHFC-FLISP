using Sage.CRM.Controls;
using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class FlispPersonDataEdit : DataPageEdit
    {
        public FlispPersonDataEdit() 
            : base("Person", "pers_personid", "PersonBoxLong")
        {

        }

        public override void AfterSave(EntryGroup screen)
        {
            Dispatch.Redirect(UrlDotNet(ThisDotNetDll, "FlispPersonFind"));
            base.AfterSave(screen);
        }
    }
}
