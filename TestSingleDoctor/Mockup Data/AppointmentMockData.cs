using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleDoctor.Mockup_Data
{
    public class AppointmentMockData
    {
        public static List<Appointment> GetAppointments()
        {
            return new List<Appointment>(){
             new Appointment{
                 ID = 1,
                Name= "Nour",
                PhoneNumber="010254210",
                Note="smfos",
                AppointDate=DateTime.Now
             },
                new Appointment{
                 ID = 2,
                Name= "Nour",
                PhoneNumber="010254210",
                Note="smfos",
                AppointDate=DateTime.Now
             },
                new Appointment{
                 ID = 3,
                Name= "Nour",
                PhoneNumber="010254210",
                Note="smfos",
                AppointDate=DateTime.Now
             },
            };
        }
    }
}
