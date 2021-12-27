using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.DataTransferObject
{
    public class SubjectDTO
    {
        [DisplayName("Code")] public string SubjectCode { get; set; }
        [DisplayName("Teacher ID")] public int TeacherID { get; set; }
        [DisplayName("Name")] public string SubjectName { get; set; }
        [DisplayName("Description")] public string SubjectDescription { get; set; }
        [DisplayName("Price")] public decimal SubjectPrice { get; set; }
        [DisplayName("Active/Available")] public bool IsActive { get; set; }
    }
}