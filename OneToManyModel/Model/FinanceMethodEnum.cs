using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CATS_Interview.Model
{
    public enum FinanceMethodEnum:byte
    {
        BuyOutright = 8,
        ContractHire,
        OperatingLease,
        HirePurchase,
        FinanceLease,
        Rental,
        DontKnow    
    }
}