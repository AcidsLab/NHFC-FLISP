using Sage.CRM.Controls;
using Sage.CRM.Data;
using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{

    class FlispNewCheckList : DataPageEdit
    {
        public FlispNewCheckList()
            : base("ChecklistMaster", "clmr_checklistid", "Checklist")
        {

        }

        /*
        public override void BuildContents()
        {
            Record checklist = new Record("ChecklistMaster");

            EntryGroup entry = new EntryGroup("Checklist");

            entry.GetHtmlInEditMode();

            AddContent(entry);

            string sUrl = "javascript:document.EntryForm.HiddenMode.value='Save';";
            AddSubmitButton("Save", "Save.gif", sUrl);
            
            checklist.SaveChanges();

        }
        */

        public override void AfterSave(EntryGroup screen)
        {
            Record checklist = new Record("ChecklistMaster");
            screen.Fill(checklist);
            checklist.SaveChanges();

            base.AfterSave(screen);
            Dispatch.Redirect(UrlDotNet(ThisDotNetDll, "FlispDisplayCheckList"));
        }
    }
}
