
using System.Collections.Generic;

namespace SSManagment.Data.Entities
{
    public class University : BaseEntity
    {
        public ICollection<College> Colleges { get; set; }
    }
}
