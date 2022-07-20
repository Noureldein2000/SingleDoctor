using Moq;
using Services.Repositiories.Interface;
using SingleDoctor.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSingleDoctor.Mockup_Data;

namespace TestSingleDoctor.System.Controllers
{
    public class TestAppointmentController
    {
        
        //reference UnitTest
        //https://www.learmoreseekmore.com/2022/02/dotnet6-unit-testing-aspnetcore-web-api-using-xunit.html
        
        [Fact]
        public async Task GetAllAppointment_ShouldReturn200Status()
        {
            ///Arrange
            //var appointmentService = new Mock<IAppointmentService>();
            //appointmentService.Setup(_ => _.GetAllAppointments()).ReturnsAsync(AppointmentMockData.GetAppointments());
            //var sut = new AppointmentController(appointmentService.Object);

            ///Act



            ///Assert
        }
    }
}
