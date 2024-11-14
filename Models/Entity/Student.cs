using System.ComponentModel.DataAnnotations;

namespace CRUDCodeFirst.Models.Entity
{
    public class Student
    {
        [Key]
        public Guid Guid { get; set; }
        
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
