using Sage.CRM.Controls;
using Sage.CRM.Data;
using Sage.CRM.UI;
using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    class Testing : Web
    {
        public override void BuildContents()
        {
            AddContent(HTML.Form());
            EntryGroup screenCompanyBoxLong = new EntryGroup("CompanyBoxLong");
            screenCompanyBoxLong.Title = Metadata.GetTranslation("tabnames", "company");

            EntryGroup screenPersonBoxLong = new EntryGroup("PersonBoxLong");
            screenPersonBoxLong.Title = Metadata.GetTranslation("tabnames", "person");

            EntryGroup screenOppo = new EntryGroup("OpportunityDetailBox");
            screenOppo.Title = Metadata.GetTranslation("tabnames", "opportunity");

            string hMode = Dispatch.EitherField("HiddenMode");
            if (hMode == "Save")
            {
                Record recCompany = new Record("Company");
                screenCompanyBoxLong.Fill(recCompany);
                recCompany.SaveChanges();

                Record recPerson = new Record("Person");
                recPerson.SetField("pers_companyid", recCompany.GetFieldAsInt("comp_companyid"));
                screenPersonBoxLong.Fill(recPerson);
                recPerson.SaveChanges();

                recCompany.SetField("comp_primarypersonid", recPerson.GetFieldAsInt("pers_personid"));
                recCompany.SaveChanges();

                Record recOppo = new Record("Opportunity");
                recOppo.SetField("oppo_primarycompanyid", recCompany.GetFieldAsInt("comp_Companyid"));
                screenOppo.Fill(recOppo);
                recOppo.SaveChanges();

                //redirect to the company summary of the new company
                string rUrl = Url("200");
                string[] split = rUrl.Split(new char[] { '&' });
                string newUrl = split[0] + '&' + split[1] + "&Mode=1&CLk=T&key0=7&key1=" + recCompany.GetFieldAsInt("comp_companyid");
                Dispatch.Redirect(newUrl);
            }
            else
            {
                AddContent(HTML.InputHidden("HiddenMode", ""));
                VerticalPanel vpMainPanel = new VerticalPanel();
                vpMainPanel.AddAttribute("width", "100%");

                screenCompanyBoxLong.GetHtmlInEditMode();
                screenPersonBoxLong.GetHtmlInEditMode();
                screenOppo.GetHtmlInEditMode();

                vpMainPanel.Add(screenCompanyBoxLong);
                vpMainPanel.Add(screenPersonBoxLong);
                vpMainPanel.Add(screenOppo);
                AddContent(vpMainPanel);
                //Add Buttons
                string sUrl = "javascript:document.EntryForm.HiddenMode.value='Save';";
                AddSubmitButton("Save", "Save.gif", sUrl);
                AddUrlButton("Cancel", "cancel.gif", UrlDotNet(ThisDotNetDll, "RunEntryScreen"));
                string strHelpUrl = "/Main Menu/Default_CSH.htm?href=AI_FAQs.html";
                AddHelpButton(strHelpUrl);

            }
        }
    }
}