using Sage.CRM.Data;
using Sage.CRM.WebObject;

namespace FlispCRM.Pages
{
    enum CheckTypee
    {
        Applicant,
        Spouse
    }

    class FlispChecklistChoice : Web
    {
        private readonly CheckTypee _checklistType;

        public FlispChecklistChoice(CheckTypee checklistType)
        {
            _checklistType = checklistType;
        }

        public override void BuildContents()
        {
            //throw new NotImplementedException();

            int checkId = int.Parse(Dispatch.EitherField("clsv_ChecklistSlaveId"));

            Record checklistRecord = FindRecord("ChecklistSlave", "clsv_ChecklistSlaveId = " + checkId);

            switch (_checklistType)
            {
                case CheckTypee.Applicant:
                    checklistRecord.SetField("clsv_Applicant", checklistRecord.GetFieldAsString("clsv_Applicant") == "Y" ? "N" : "Y");
                    break;
                case CheckTypee.Spouse:
                    checklistRecord.SetField("clsv_Spouse", checklistRecord.GetFieldAsString("clsv_Spouse") == "Y" ? "N" : "Y");
                    break;
            }

            checklistRecord.SaveChanges();

            Dispatch.Redirect(UrlDotNet(ThisDotNetDll, "FlispCheckListSlaveList"));

        }
    }
}
