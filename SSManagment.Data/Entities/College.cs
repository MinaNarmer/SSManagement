
using System.Collections.Generic;


namespace SSManagment.Data.Entities
{
    public class College : BaseEntity
    {

        public int UniversityId { get; set; }

        public University University { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
