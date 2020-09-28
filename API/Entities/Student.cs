using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities {
    public class Student {
        [DatabaseGeneratedAttribute (DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TenantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}