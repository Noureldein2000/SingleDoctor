using MediatR;
using Services.DTOs;
using Services.Repositiories.Interface;
using SingleDoctor.Commands;

namespace SingleDoctor.Handlers
{
    public class AddAppointmentHandler : IRequestHandler<AddAppointmentCommand, AppointmentDTO>
    {
        private readonly IAppointmentService _appointmentService;
        public AddAppointmentHandler(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public Task<AppointmentDTO> Handle(AddAppointmentCommand request, CancellationToken cancellationToken)
        {
         return  _appointmentService.AddAppointment(new AppointmentDTO
            {
                Name = request.Name,
                Note = request.Note,
                AppointDate = request.AppointmentDate,
                PhoneNumber = request.PhoneNumber,
            });
        }
    }
}
