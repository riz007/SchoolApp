//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagementApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public int examID { get; set; }
        public int courseID { get; set; }
        public int sectionID { get; set; }
        public string examType { get; set; }
        public System.DateTime examDate { get; set; }
        public double examFullScore { get; set; }
        public double examScorePercentage { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Section Section { get; set; }
    }
}