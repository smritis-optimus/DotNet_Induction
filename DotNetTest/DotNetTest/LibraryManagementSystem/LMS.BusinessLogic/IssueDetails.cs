﻿using System;

namespace LMS.BusinessLogic
{
  public class IssueDetails
    {
        public int IssueID { get; set; }
        public string Issuer { get; set; }
        public int BookID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime WithdrawDate { get; set; }
    }
}
