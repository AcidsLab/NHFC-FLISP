using System.Collections.Generic;
using Sage.CRM.WebObject;
using Functions;
using Functions.SSRS;

namespace FlispCRM.Pages
{
    class FlispApplicationsList : ListPage
    {
        public FlispApplicationsList()
            : base("Opportunity", "FlispApplications", "FlispApplicationFilter")
        {
            //AddTabHead("Applications");
            
        }

        public override void AddNewButton()
        {

        //    AddUrlButton("New", "new.gif", UrlDotNet(ThisDotNetDll, "FlispNewApplication"));
        //    //base.AddEditButton();
        }

        private Ssrs reportSsrs = new Ssrs("ReportServer", SsrsFileFormats.Pdf, "ExportDir");

        public Ssrs ReportSsrs
        {
            get { return reportSsrs; }
            set { reportSsrs = value; }
        }


    }
 

}
