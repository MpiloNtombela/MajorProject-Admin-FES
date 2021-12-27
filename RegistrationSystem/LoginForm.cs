using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RegistrationSystem.DataAccess.Repos;

namespace RegistrationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly ExtrasRepo _extrasRepo = new ExtrasRepo();
        private UserManager<IdentityUser> manager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext()));
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInAccount()
        {
            var email = EmailAddress_control.InputText.ToLower();
            var pass = Passcode_control.InputText;

            var user = manager.FindByEmail(email);
            if(user != null && manager.CheckPassword(user, pass))
            {
                if(manager.IsInRole(user.Id, "admin"))
                {
                    var admin = _extrasRepo.GetAdminDto(userId: user.Id);
                    var portal = new AdminPortal(admin);
                    try
                    {
                        FormCollection formsList = Application.OpenForms;
                        for (int i = formsList.Count - 1; i >= 0; i--)
                        {
                            if (formsList[i].Name.ToLower() == "landingpage")
                            {
                                formsList[i].WindowState = FormWindowState.Minimized;
                            }
                            else
                            {
                                formsList[i].Close();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // ignored
                    }

                    this.Close();
                    portal.WindowState = FormWindowState.Maximized;
                    portal.Show();
                } else
                {
                    MessageBox.Show(@"Only Admin accounts have access", @"Unauthorized Access", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show(@"Incorrect Email or Password", @"Login Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LogIn_button_Click(object sender, EventArgs e) => LogInAccount();

        private void RegisterNow_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newRegForm = new RegistrationForm();
            newRegForm.ShowDialog();
        }
    }
}