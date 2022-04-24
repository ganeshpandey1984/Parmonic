using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DM_SinglEntryLedger.LedgerEntryItem;

namespace DM_SinglEntryLedger
{
    public class LedgerTransaction
    {
        public decimal GetLastBalance(List<Ledger> ledger)
        {
            return ledger.Select(x => x.Balance).LastOrDefault();
        }


        public decimal CalculateBalance(List<Ledger> lstLedger, LedgerEntryItem ledgerEntryItem)
        {
            decimal lastBalance = GetLastBalance(lstLedger);
            if (TransactionTypes.CREDIT == ledgerEntryItem.TransactionType)
            {
                lastBalance += ledgerEntryItem.Amount;
            }
            else
            {
                if (lastBalance >= ledgerEntryItem.Amount)
                    lastBalance += (ledgerEntryItem.Amount * -1);
            }
            return lastBalance;
        }
        public decimal CalculateBalance(List<Ledger> lstLedger, TransactionTypes transactionType, Decimal amount)
        {
            decimal lastBalance = GetLastBalance(lstLedger);
            if (TransactionTypes.CREDIT == transactionType)
            {
                lastBalance += amount;
            }
            else
            {
                if (lastBalance <= amount)
                    lastBalance += (amount * -1);
            }
            return lastBalance;
        }

        public void AddEntry(List<Ledger> lstledger, DateTime date, string description, LedgerEntryItem ledgerEntryItem, decimal balance)
        {
            Ledger ledger = new Ledger();
            ledger.Date = date;
            ledger.Description = description;
            ledger.LedgerEntryItems = ledgerEntryItem;
            ledger.Balance = balance;

            lstledger.Add(ledger);
        }
    }
}
