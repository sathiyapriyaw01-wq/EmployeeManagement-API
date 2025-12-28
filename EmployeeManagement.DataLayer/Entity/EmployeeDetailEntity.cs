using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeeManagement.DataLayer.Entity
{
    [Table("EmployeeDetails",Schema="project")]
    public class EmployeeDetailEntity
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        [Required]
        public string Gmail { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDateTime { get; set; }
    }
}
