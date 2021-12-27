using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using RegistrationSystem.DataTransferObject;

namespace RegistrationSystem.DataAccess.Repos
{
    public class ExtrasRepo
    {
        private readonly DataEntities _extrasEntities = new DataEntities();

        public BankDetail AddBankingDetails(BankDetail details)
        {
            if (details == null)
            {
                throw new ArgumentNullException(nameof(details));
            }

            return _extrasEntities.BankDetails.Add(details);
        }

        public SupportingDocument AddSupportingDoc(SupportingDocument document)
        {
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document));
            }

            return _extrasEntities.SupportingDocuments.Add(document);
        }

        public DbContextTransaction DbTransaction()
        {
            _extrasEntities.Database.CommandTimeout = 120;
            return _extrasEntities.Database.BeginTransaction();
        }

        public BankDetail GetBankDetails(int studentId) =>
            _extrasEntities.BankDetails.FirstOrDefault(bank => bank.StudentID == studentId);

        public IEnumerable<PaymentPlan> GetPaymentPlans() => _extrasEntities.PaymentPlans.ToList();

        public Notification SendNotification(Notification notification) =>
            _extrasEntities.Notifications.Add(notification);

        public IQueryable<Notification> GetUserNotifications(string userId) =>
            _extrasEntities.Notifications.Where(n => n.UserId == userId);

        public IEnumerable<Registration> GetRegistrations() => _extrasEntities.Registrations.ToList();

        public IEnumerable<Registration> GetRegistrationsByStatus(bool isApproved) =>
            _extrasEntities.Registrations.Where(reg => reg.IsApproved == isApproved).ToList();

        public SupportingDocument GetSupportingDocument(int docId) =>
            _extrasEntities.SupportingDocuments.FirstOrDefault(doc => doc.SupportingDocumentID == docId);

        public Admin GetAdmin(string userId) => _extrasEntities.Admins.FirstOrDefault(admin => admin.UserID == userId);
        public IQueryable<Teacher> GetTeachers() => _extrasEntities.Teachers;
        public Teacher AddTeacher(Teacher teacher) => _extrasEntities.Teachers.Add(teacher);

        public AspNetUser CreateUser(AspNetUser user)
        {
            return _extrasEntities.AspNetUsers.Add(user);
        }

        public AspNetUser RemoveUser(AspNetUser user) => _extrasEntities.AspNetUsers.Remove(user);

        public Admin CreateAdmin(Admin admin)
        {
            return _extrasEntities.Admins.Add(admin);
        }

        public IQueryable<AspNetUser> GetUsers() => _extrasEntities.AspNetUsers;

        public IQueryable<AspNetRole> GetRoles() => _extrasEntities.AspNetRoles;
        
        public AdminDto GetAdminDto(string userId)
        {
            // can return user
            // join users table and admin table for sake if new fields are added to admin table
            var queryable = _extrasEntities.AspNetUsers.Join(_extrasEntities.Admins, user => user.Id,
                admin => admin.UserID,
                (user, admin) => new {AspNetUser = user, Admin = admin});

            return queryable?.Where(q => q.AspNetUser.Id == userId)?.Select(
                x => new AdminDto
                {
                    UserId = x.AspNetUser.Id,
                    AdminId = x.Admin.AdminID,
                    FirstName = x.AspNetUser.FirstName,
                    LastName = x.AspNetUser.LastName,
                    Email = x.AspNetUser.Email,
                })?.FirstOrDefault();
        }
        public bool SaveChanges()
        {
            try
            {
                return _extrasEntities.SaveChanges() >= 0;
            }
            catch (DbEntityValidationException e)
            {
                //// uncomment for debug purposes
                //foreach (DbEntityValidationResult eve in e.EntityValidationErrors)
                //{
                //    Console.WriteLine(@"Entity of type ""{0}"" in state ""{1}"" has the following validation errors:",
                //        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                //    foreach (DbValidationError ve in eve.ValidationErrors)
                //    {
                //        Console.WriteLine(@"- Property: ""{0}"", Error: ""{1}""",
                //            ve.PropertyName, ve.ErrorMessage);
                //    }
                //}

                string errMsg = e.EntityValidationErrors.First()?.ValidationErrors.First()?.ErrorMessage;
                throw new ArgumentException(Utils.Helpers.NotNull(errMsg)
                    ? errMsg
                    : "something went wrong while saving changes");
            }
        }

    }
}