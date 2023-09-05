﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymViewModel.Sage
{
    public class JournalLedgerDetailVM
    {
        public string JournalType { get; set; }
        public int      Id                                       { get; set; }
        public string   TransactionDate                   { get; set; }
        public string   BatchDesc                         { get; set; }
        public string   GLCode                            { get; set; }
        public string   Reference                         { get; set; }
        public string   Remarks                           { get; set; }
        public string   AccDescription                    { get; set; }
        public bool     IsDebit                             { get; set; }
        public decimal  TransactionAmount                { get; set; }
        public string   SrceType                          { get; set; }
        public string   JrnlDesc                          { get; set; }
        public string   FiscalYearDetailId                  { get; set; }
        public int JournalLedgerId { get; set; }
       
        public string   PeriodName                          { get; set; }

        public string DepartmentId   { get; set; }
        public string SectionId      { get; set; }
        public string ProjectId      { get; set; }
        public string empcodes       { get; set; }

        public string htmlId { get; set; }
        [Display(Name = "Reverse")] 
        public bool IsReverse { get; set; } 
        [Display(Name = "Active")] 
        public bool IsActive { get; set; }       
        public bool IsArchive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedFrom { get; set; }
        public string LastUpdateBy { get; set; }
        public string LastUpdateAt { get; set; }
        public string LastUpdateFrom { get; set; }

    }
    public class JournalLedgerVM
    { 
        public int      Id                                       { get; set; }
   public string Code { get; set; }   
   public string FiscalYearDetailId { get; set; }  
 
   //public string JournalDesc { get; set; }   

   //public string TransactionDate { get; set; }   
        public string PostDate { get; set; }   
        public string Description { get; set; } 
        [Display(Name = "Reverse")] 
        public bool IsReverse { get; set; } 
        [Display(Name = "Active")] 
        public bool IsActive { get; set; }       
        public bool IsArchive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedFrom { get; set; }
        public string LastUpdateBy { get; set; }
        public string LastUpdateAt { get; set; }
        public string LastUpdateFrom { get; set; }
        public string PeriodName { get; set; }
    }
    public class JournalLedgerEmployeeHistoryVM
    {
        public int Id { get; set; }
        public string FiscalYearDetailId { get; set; }
        public string EmployeeId { get; set; }
    }
}
