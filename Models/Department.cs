using System.ComponentModel.DataAnnotations;

namespace finalproject.Models
{
    public class Department
    {
        [Required]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }

}
