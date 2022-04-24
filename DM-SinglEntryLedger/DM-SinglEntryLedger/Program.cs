using System;
using System.Collections.Generic;
using static DM_SinglEntryLedger.LedgerEntryItem;

namespace DM_SinglEntryLedger
{
    class Program
    {
        static void Main(string[] args)
        {
            Ledger ledger = new Ledger();
            List<Ledger> lstLedger = new List<Ledger>();
            LedgerTransaction ledgerTransaction = new LedgerTransaction();
            ledgerTransaction.AddEntry(lstLedger,DateTime.Now, "opening balance", null, 5000);

            LedgerEntryItem ledgerEntryItem = new LedgerEntryItem();
            ledgerEntryItem.TransactionType = TransactionTypes.DEBIT;
            ledgerEntryItem.Amount = 1000;

            ledgerTransaction.AddEntry(lstLedger, DateTime.Now, "Rent", ledgerEntryItem, ledgerTransaction.CalculateBalance(lstLedger,ledgerEntryItem));

            LedgerEntryItem ledgerEntryItem1= new LedgerEntryItem();
            ledgerEntryItem1.TransactionType = TransactionTypes.CREDIT;
            ledgerEntryItem1.Amount = 250;

            ledgerTransaction.AddEntry(lstLedger, DateTime.Now, "Interest", ledgerEntryItem1, ledgerTransaction.CalculateBalance(lstLedger, ledgerEntryItem1));

            foreach(var item in lstLedger)
            {
                decimal? debitAmount = null;
                decimal? creditAmount = null;
                string transactionType = string.Empty;
                if(item.LedgerEntryItems!=null)
                {
                    transactionType = item.LedgerEntryItems.TransactionType.ToString();
                   debitAmount = item.LedgerEntryItems.TransactionType == TransactionTypes.DEBIT ? item.LedgerEntryItems.Amount : null;
                   creditAmount = item.LedgerEntryItems.TransactionType == TransactionTypes.CREDIT ? item.LedgerEntryItems.Amount : null;
                }
                
                Console.WriteLine($"Date: {item.Date}, Description: {item.Description}, TransactionType: {transactionType}, Debit: {debitAmount}, Credit: {creditAmount}, Balance: {item.Balance} ");
            }

            Console.ReadLine();
        }
    }
}
