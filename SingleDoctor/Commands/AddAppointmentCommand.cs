using MediatR;
using Services.DTOs;

namespace SingleDoctor.Commands
{
    public class AddAppointmentCommand : IRequest<AppointmentDTO>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Note { get; set; }
    }
}
