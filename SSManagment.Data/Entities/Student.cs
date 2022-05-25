
using System;

namespace SSManagment.Data.Entities
{
    public class Student : BaseEntity
    {
        public DateTime DOB { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CollegeId { get; set; }



        public College College { get; set; }
        public StudentScholarship StudentScholarship { get; set; }
    }
}
