using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RegistrationSystem.DataAccess;
using RegistrationSystem.DataAccess.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class TeacherForm : Form
    {
        private readonly ExtrasRepo _extrasRepo = new ExtrasRepo();

        private readonly UserManager<IdentityUser> manager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext()));

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void AddTeacher_btn_Click(object sender, EventArgs e)
        {
            if (Helpers.Helpers.AllFieldsChecked(TeacherDetails_groupbox))
            {
                var user = new AspNetUser
                {
                    FirstName = FirstName_control.InputText,
                    LastName = LastName_control.InputText,
                    Email = EmailAddress_control.InputText,
                    UserName = EmailAddress_control.InputText,
                    Id = Guid.NewGuid().ToString(),
                };
                var createdUser = _extrasRepo.CreateUser(user);
                if (_extrasRepo.SaveChanges())
                {
                    manager.AddPassword(createdUser.Id, $"new@teacher");
                    var teacher = new Teacher
                    {
                        UserID = createdUser.Id,
                        Qualification = Qualification_control.InputText,
                        Gender = Gender_combobox?.Text.Substring(0, 1),
                    };
                    _extrasRepo.AddTeacher(teacher);
                    try
                    {
                        _extrasRepo.SaveChanges();
                        manager.AddToRole(userId: user.Id, "teacher");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // if changes failed to be saved to Db, SaveChanges throws an Ex and try reverse creation of user
                        _extrasRepo.RemoveUser(createdUser);
                        _extrasRepo.SaveChanges();
                        MessageBox.Show(
                        Utils.Helpers.NotNull(ex.Message)
                            ? Utils.Helpers.GetErrorMessage(ex)
                            : @"Failed to register user", @"Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show( @"Failed to register new teacher", @"Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"All fields are required!", @"Incomplete", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
