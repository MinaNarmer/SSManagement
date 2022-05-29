

using System;

namespace SSManagment.BL.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CollegeId { get; set; }
    }
}
