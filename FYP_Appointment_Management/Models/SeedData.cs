using Microsoft.EntityFrameworkCore;
using FYP_Appointment_Management.Data;

namespace FYP_Appointment_Management.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new FYP_Appointment_ManagementContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FYP_Appointment_ManagementContext>>()))
        {
            if (context == null || context.Department == null)
            {
                throw new ArgumentNullException("Null FYP_Appointment_ManagementContext");
            }

            // Look for any departments.
            if (context.Department.Any())
            {
                return;  // DB has been seeded
            }
            context.Department.AddRange(
                new Department
                {
                    //Dept_Id = 1233,
                    Dept_Name = "Ophthalmology",
                    Dept_phone = 2089123123
                },

                new Department
                {
                    //Dept_Id = 1234,
                    Dept_Name = "Rheumatology",
                    Dept_phone = 2089123124
                },

                new Department
                {
                    //Dept_Id = 1235,
                    Dept_Name = "Pathology",
                    Dept_phone = 2089123125
                }
            );
            context.SaveChanges();

        }

        using (var context = new FYP_Appointment_ManagementContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FYP_Appointment_ManagementContext>>()))
        {
            if (context == null || context.Patient == null)
            {
                throw new ArgumentNullException("Null FYP_Appointment_ManagementContext");
            }

            // Look for any patients.
            if (context.Patient.Any())
            {
                return;   // DB has been seeded
            }

            context.Patient.AddRange(
                new Patient
                {
                    //Patient_Id = 3443,
                    Patient_First_Name = "Shelly",
                    Patient_Last_Name = "Webb",
                    Patient_Gender = "Female",
                    Patient_DOB = DateOnly.Parse("12,05,1984"),
                    Patient_Phone = 771234123,
                    Patient_Email = "shelly.webb@aol.com"
                },

                new Patient
                {
                    //Patient_Id = 3444,
                    Patient_First_Name = "Yin",
                    Patient_Last_Name = "Lee",
                    Patient_Gender = "Female",
                    Patient_DOB = DateOnly.Parse("25,11,1998"),
                    Patient_Phone = 771234567,
                    Patient_Email = "yin.lee@gmail.com"
                },

                new Patient
                {
                    //Patient_Id = 3445,
                    Patient_First_Name = "Harry",
                    Patient_Last_Name = "Benshaw",
                    Patient_Gender = "Male",
                    Patient_DOB = DateOnly.Parse("05,02,2000"),
                    Patient_Phone = 781234567,
                    Patient_Email = "harryb@hotmail.co.uk"
                }
            );
            context.SaveChanges();
        }

        using (var context = new FYP_Appointment_ManagementContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FYP_Appointment_ManagementContext>>()))
        {
            if (context == null || context.Staff == null)
            {
                throw new ArgumentNullException("Null FYP_Appointment_ManagementContext");
            }

            // Look for any staff.
            if (context.Staff.Any())
            {
                return;   // DB has been seeded
            }

            context.Staff.AddRange(
                new Staff
                {
                    //Staff_Id = 98756,
                    Staff_First_Name = "Thomas",
                    Staff_Last_Name = "Garnald",
                    Staff_Role = "Cornea Consultant",
                    Staff_Email = "thomas.garnald@appman.com"
                },

                new Staff
                {
                    //Staff_Id = 98757,
                    Staff_First_Name = "John",
                    Staff_Last_Name = "Brickerman",
                    Staff_Role = "Glaucoma Consultant",
                    Staff_Email = "john.brickerman@appman.com"
                },

                new Staff
                {
                    //Staff_Id = 98758,
                    Staff_First_Name = "Sandra",
                    Staff_Last_Name = "Matthews",
                    Staff_Role = "Optometrist",
                    Staff_Email = "sadra.matthews@appman.com"
                }
            );
            context.SaveChanges();
        }
    }
}