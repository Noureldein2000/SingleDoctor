using MediatR;
using Services.DTOs;

namespace SingleDoctor.Queries
{
    public class GetAllAppointmentsQuery : IRequest<List<AppointmentDTO>>
    {

    }
}
