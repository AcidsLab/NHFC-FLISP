using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Functions.SSRS;
using Sage.CRM.Data;
using Sage.CRM.Utils;
using Sage.CRM.WebObject;
using Sage;

namespace FlispCRM.Pages
{
    public class Report : Web
    {


        public override void BuildContents()
        {
            string persId = (Dispatch.EitherField("key2"));

            //Record checklistRecord = FindRecord("Person", "pers_personid = " + persId);
            //string fileNumber = checklistRecord.GetFieldAsString("pers_referenceid");

            AddError(persId);

            string sPopupURL = "http://nhfchp380flisp/ReportServer/Pages/ReportViewer.aspx?%2fChecklist&PersonId=" + persId;

            AddUrlButton("SSRS Report", "new.gif", sPopupURL);

            PopUpWindowButton("Report", sPopupURL, "new.gif", 300, 300);

            Dispatch.Redirect(sPopupURL);

            UrlForPopUpWindow(
                "http://nhfchp380flisp/ReportServer/Pages/ReportViewer.aspx?%2fChecklist&PersonId=" + persId, "Reports",500, 500);

        }



        public override bool Validate()
        {
 
            string persId = "2061";
            string fileNumber = "201509-061";
           
            Ssrs ssrsServer = new Ssrs("NHFCHP380FLISP", SsrsFileFormats.Pdf, @"\\nhfchp380flisp\c$\ASTECH\Output\");
           
            Dictionary<string, string> reportParameters = new Dictionary<string, string> { { "PersonId", persId } };
           
            ssrsServer.RunReport(fileNumber, "Checklist.rdl", reportParameters);

            return true;
        }
    }
}
