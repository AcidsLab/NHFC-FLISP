using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class FlispPersonFind : ListPage
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

        public FlispPersonFind()
            : base("Person", "PersonGrid","FlispPersonFind")
        {
            //AddInfo("Person data list");
            //AddHeaderContent("Person List");
            AddTabHead("Person Info");
        }

    }
}
