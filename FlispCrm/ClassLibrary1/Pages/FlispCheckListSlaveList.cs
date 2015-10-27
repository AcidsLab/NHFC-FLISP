using Sage.CRM.Data;
using Sage.CRM.WebObject;


namespace FlispCRM.Pages
{
    class FlispCheckListSlaveList : ListPage
    {
        public FlispCheckListSlaveList() :
            base("ChecklistSlave", "ChecklistSlaveList", "ChecklistSlave")
        {
            //int oppoId = Keys[7];// int.Parse(Dispatch.EitherField("oppo_opportunityid"));
            //DeleteSql = "clsv_LoanId = " + oppoId;

            int persId = Keys[2];
            DeleteSql = "clsv_PersonId = " + persId;

            AddError("Print And Attach Signed letter when done");

        }

        public override void AddNewButton()
        {
            //base.AddNewButton();

            string persId = Dispatch.EitherField("key2");

            
            string checklistURL = "http://nhfchp380flisp/ReportServer/Pages/ReportViewer.aspx?%2fChecklist&PersonId=" + persId;

            
            AddButtonContent(PopUpWindowButton("Checklist Report", checklistURL, "new.gif", 900, 700));
            

        }
    }
}
