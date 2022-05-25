

using System;

namespace SSManagment.Data.Entities
{
    public class Scholarship : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double Cost { get; set; }
        public string Description { get; set; }
    }
}
