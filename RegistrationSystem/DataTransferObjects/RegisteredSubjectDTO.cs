using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem.DataTransferObjects
{
    public class RegisteredSubjectDto
    {
        [DisplayName("Student ID")] public int StudentId { get; set; }
        [DisplayName("Subject Code")] public string SubjectCode { get; set; }
        [DisplayName("Subject Name")] public string SubjectName { get; set; }

        [DisplayName("Matric Mark")] public int MatricMark { get; set; }

        [DisplayName("Upgrade Mark")] public int? UpgradeMark { get; set; }
    }
}