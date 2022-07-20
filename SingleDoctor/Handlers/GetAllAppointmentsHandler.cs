using MediatR;
using Services.DTOs;
using Services.Repositiories.Interface;
using SingleDoctor.Queries;

namespace SingleDoctor.Handlers
{
    public class GetAllAppointmentsHandler : IRequestHandler<GetAllAppointmentsQuery, List<AppointmentDTO>>
    {
        private readonly IAppointmentService _appointmentService;
        public GetAllAppointmentsHandler(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        public async Task<List<AppointmentDTO>> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
        {
            return await _appointmentService.GetAllAppointments();
        }
    }
}
