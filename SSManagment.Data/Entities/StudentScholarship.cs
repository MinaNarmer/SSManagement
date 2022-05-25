using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSManagment.Data.Entities
{
    public class StudentScholarship
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Scholarship")]
        public int ScholarshipId { get; set; }
        public DateTime SelectionDate { get; set; }


        public Student Student { get; set; }
        public Scholarship Scholarship { get; set; }
        



    }
}
