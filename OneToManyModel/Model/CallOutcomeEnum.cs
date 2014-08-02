using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CATS_Interview.Model
{
    public enum CallOutcomeEnum:byte
    {
        CeasedTrading = 7,
        TargetRequestedRemoval  = 9,
        DuplicateRecord = 18,
        TelephoneNumberIncorrect = 4,
        TargetRefusedInterview = 10,
        TargetDoesNotRunTrucks = 11,
        CompletedInterview = 12,
        CallBackTargetBusy = 1,
        CallBackLineEngaged = 2,
        CallBackAnswerMachine = 3,
        CallBackTelephoneNotAnswered = 15,
        CallBackTargetOffSite = 20,
        TargetRequestedFaxInterview = 22,
        TargetRequestedMailInterview = 23,
        TargetRequestedEMailInterview = 24
    }
}