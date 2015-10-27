using Sage.CRM.Controls;
using Sage.CRM.Data;
using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class FlispNewApplication : DataPageNew
    {
        public FlispNewApplication()
            : base("Opportunity", "oppo_opportunityid", "FlispApplicationScreen")
        {
            //public override void BuildContents()
            //{
            //    AddInfo("Find person info");

            //    Record pers = new Record("Person");

            //    EntryGroup entry = new EntryGroup("FlispPersonFind");

            //    entry.GetHtmlInEditMode();

            //    AddContent(entry);

            //    AddUrlButton("Go To Data Page", "new.gif", UrlDotNet(ThisDotNetDll, "FlispPersonData"));

            //    //throw new NotImplementedException();
            //}
            
        }
        /*
        public override void BuildContents()
        {
            AddInfo("Capture Application Information");

            Record oppo = new Record("Opportunity");

            EntryGroup webPicker = new EntryGroup("OpportunityWebPicker");

            EntryGroup entry = new EntryGroup("OpportunityDetailBox");

            entry.GetHtmlInEditMode();
            webPicker.GetHtmlInEditMode();
            

            AddContent(webPicker);
            AddContent(entry);

            AddSaveButton();

            oppo.SaveChanges();

            //Dispatch.Redirect(UrlDotNet(ThisDotNetDll, "FlispApplicationsList"));

            //AddUrlButton("Go To List", "new.gif", UrlDotNet(ThisDotNetDll, "FlispApplicationsList"));

            //base.BuildContents();

        }*/

        public override void AfterSave(EntryGroup screen)
        {
            Record oppo = new Record("Opportunity");

            screen.Fill(oppo);
            oppo.SaveChanges();

            Dispatch.Redirect(UrlDotNet(ThisDotNetDll, "FlispApplicationList"));
            base.AfterSave(screen);
        }

    }
    
}
