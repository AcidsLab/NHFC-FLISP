using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sage.CRM.WebObject;
using FlispCRM.Pages;

namespace FlispCRM
{
    public static class AppFactory
    {
        public static void FlispPersonFind(ref Web aretVal)
        {
            aretVal = new FlispPersonFind();
        }

        public static void FlispPersonData(ref Web aretVal)
        {
            aretVal = new FlispPersonData();
        }

        public static void FlispPersonDataEdit(ref Web aretVal)
        {
            aretVal = new FlispPersonDataEdit();
        }

        public static void FlispPersonList(ref Web aretVal)
        {
            aretVal = new FlispPersonList();
        }

        public static void FlispApplicationsList(ref Web aretVal)
        {
            aretVal = new FlispApplicationsList();

        }

        public static void FlispNewApplication(ref Web aretVal)
        {
            aretVal = new FlispNewApplication();

        }

        public static void Testing(ref Web aretVal)
        {
            aretVal = new Testing();
        }

        public static void FlispDisplayCheckList(ref Web aretVal)
        {
            aretVal = new FlispDisplayCheckList();
        }


        public static void FlispNewCheckList(ref Web aretVal)
        {
            aretVal = new FlispNewCheckList();
        }

        public static void FlispCheckListSlaveList(ref Web aretVal)
        {
            aretVal = new FlispCheckListSlaveList();
        }

        public static void FlispChecklistChoiceApplicant(ref Web aretVal)
        {
            aretVal = new FlispChecklistChoice(CheckTypee.Applicant);
        }

        public static void FlispChecklistChoiceSpouse(ref Web aretVal)
        {
            aretVal = new FlispChecklistChoice(CheckTypee.Spouse);
        }

        public static void Report(ref Report aretVal)
        {
            aretVal = new Report();
        }

        public static void Checklist(ref Web aretVal)
        {
            aretVal = new Checklist();
        }

        public static void LetterOfGrant(ref Web aretVal)
        {
            aretVal = new LetterOfGrant();
        }

        public static void Requisition(ref Web aretVal)
        {
            aretVal = new Requisition();
        }

        public static void LetterOfGrantPage(ref Web aretVal)
        {
            aretVal = new LetterOfGrantPage();
        }

        public static void RequisitionPage(ref Web aretVal)
        {
            aretVal = new RequisitionPage();
        }
        
    }
}


