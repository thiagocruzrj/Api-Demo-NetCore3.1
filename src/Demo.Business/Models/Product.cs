using System;

namespace Demo.Business.Models
{
    public class Product : Entity
    {
        public Guid ProviderId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Value { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }

        /* EF Rel.*/
        public Provider Provider { get; set; }
    }
}
