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
    public class LetterOfGrant : DataPage
    {


        public LetterOfGrant()
            : base("LetterOfGrant", "ltgt_LetterOfGrantId", "LetterOfGrantInfo")
        {

        }

        public override void AddContinueButton()
        {
            string persId = Dispatch.EitherField("key2");

            string grantLetterURL = "http://nhfchp380flisp/ReportServer/Pages/ReportViewer.aspx?%2fGrantLetter&PersonId=" + persId;

            AddButtonContent(PopUpWindowButton("Letter of Grant", grantLetterURL, "new.gif", 900, 700));

        }

        public override void AddEditButton()
        {
            //base.AddEditButton();
        }
    }
}
