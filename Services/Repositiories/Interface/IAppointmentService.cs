using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositiories.Interface
{
    public interface IAppointmentService
    {
        Task<List<AppointmentDTO>> GetAllAppointments();
        Task<AppointmentDTO> AddAppointment(AppointmentDTO model);

    }
}
