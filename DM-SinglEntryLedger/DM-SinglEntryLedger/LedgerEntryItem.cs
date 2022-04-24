using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_SinglEntryLedger
{
    public class LedgerEntryItem
    {
        public  enum TransactionTypes
        {
            DEBIT, 
            CREDIT
        }

        public TransactionTypes TransactionType;
        public decimal Amount;
     
    }
}
