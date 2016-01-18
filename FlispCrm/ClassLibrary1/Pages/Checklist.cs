using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sage.CRM.WebObject;
using Sage.CRM.Blocks;
using Sage.CRM.UI;
using Sage.CRM.Graphics;


namespace FlispCRM.Pages
{
    class Checklist : Web
    {
       

        public override void BuildContents()
        {
            string persId = Dispatch.EitherField("key2");

            string checklistURL = "http://nhfchp380flisp/ReportServer/Pages/ReportViewer.aspx?%2fChecklist&PersonId=" + persId;

            AddButtonContent(PopUpWindowButton("Checklist Report", checklistURL, "new.gif", 400, 800));

        }

        
    }
}
