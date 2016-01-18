using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class Requisition : DataPage
    {
        public Requisition() 
            : base("Opportunity", "oppo_opportunityid")
        {

        }

        public override void AddContinueButton()
        {
            string persId = Dispatch.EitherField("key2");

            string RequisitionURL = "http://nhfchp380flisp/ReportServer/Pages/ReportViewer.aspx?%2fRequisition&PersonId=" + persId;

            AddButtonContent(PopUpWindowButton("Requisition Formt", RequisitionURL, "new.gif", 900, 700));

        }

        public override void AddEditButton()
        {
            //base.AddEditButton();
        }


    }
}
