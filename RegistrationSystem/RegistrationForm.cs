using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using RegistrationSystem.DataAccess;
using RegistrationSystem.DataAccess.Repos;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RegistrationSystem
{
    public partial class RegistrationForm : Form
    {
        private readonly ExtrasRepo _extrasRepo = new ExtrasRepo();

        private readonly UserManager<IdentityUser> manager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext()));

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Close_button_Click(object sender, EventArgs e) => Close();

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            Hide();
            var newLogIn = new LoginForm();
            newLogIn.ShowDialog();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            
            if (Helpers.Helpers.AllFieldsChecked(RegistrationForm_panel))
            {
                if (Passcode_control.InputText != ConfirmPasscode_control.InputText)
                {
                    MessageBox.Show($@"Your Passwords don't match!", @"Password", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                
                try
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
                        manager.AddPassword(createdUser.Id, Passcode_control.InputText);
                        manager.AddToRole(userId: user.Id, "admin");
                        var admin = new Admin
                        {
                            UserID = createdUser.Id,
                        };
                        _extrasRepo.CreateAdmin(admin);
                        _extrasRepo.SaveChanges();
                        MessageBox.Show(@"User registered successfully, you can log in now", @"Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        var portal = new LoginForm();
                        this.Close();
                        portal.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        Utils.Helpers.NotNull(ex.Message)
                            ? Utils.Helpers.GetErrorMessage(ex)
                            : @"Failed to register user", @"Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"All fields are required!", @"Incomplete", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void InputFieldError_Event(object sender, UserControls.InputFieldErrorEventArgs e)
        {
            if (!e.IsResolved)
            {
                Register_errorprovider.SetError(Register_button, "Please fix all errors in the form");
                Register_button.Enabled = false;
                Register_button.BackColor = Color.DarkGray;
            }
            else
            {
                Register_errorprovider.Clear();
                Register_button.Enabled = true;
                Register_button.BackColor = Color.Black;
            }
        }
    }
}