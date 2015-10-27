using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMDataAccess;
using Sage.CRM.Controls;
using Sage.CRM.WebObject;
using Record = Sage.CRM.Data.Record;

namespace FlispCRM.Pages
{
    class LetterOfGrantPage : Web
    {
        public override void BuildContents()
        {
            string persId = Dispatch.EitherField("key2");

            string grantLetterURL = "http://gertdevvm/ReportServer/Pages/ReportViewer.aspx?%2fGrantLetter&PersonId=" + persId;


            AddContent($@"<iframe src='{grantLetterURL}' id=LetterOfGrant style='border:none; overflow:auto; width: 100%; height: 1000px;'></iframe>");

            AddUrlButton("Continue", "continue.gif", Url("260"));

        }
    }
}
