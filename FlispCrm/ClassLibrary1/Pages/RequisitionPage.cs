using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class RequisitionPage : Web
    {

        public override void BuildContents()
        {

            string persId = Dispatch.EitherField("key2");
            string loanId = Dispatch.EitherField("key7");

            //string requisitionUrl = "http://gertdevvm/ReportServer/Pages/ReportViewer.aspx?%2fRequisition&PersonId=" + persId + "&LoanId=" + loanId;

            string requisitionUrl = $@"http://NHFCHP380FLISP/ReportServer/Pages/ReportViewer.aspx?%2fRequisition&PersonId=" + persId + "&LoanId=" + loanId;

            AddContent($@"<iframe src='{requisitionUrl}' id=Requisition style='border:none; overflow:auto; width: 100%; height: 1000px;'></iframe>");

            AddUrlButton("Continue", "continue.gif", Url("260"));

        }
    }
}
