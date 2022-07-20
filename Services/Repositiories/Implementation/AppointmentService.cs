using DataAccess.Entities;
using Infrastructure.Helpers;
using Services.BaseRepository;
using Services.DTOs;
using Services.Repositiories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositiories.Implementation
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IBaseRepository<Appointment, int> _appointment;
        private readonly IUnitOfWork _unitOfWork;

        //private readonly ApplicationDbContext _context;
        public AppointmentService(
            IBaseRepository<Appointment, int> appointment,
            IUnitOfWork unitOfWork)
        {
            _appointment = appointment;
            _unitOfWork = unitOfWork;
        }

        public async Task<AppointmentDTO> AddAppointment(AppointmentDTO model)
        {
            var isReserved = _appointment.Getwhere(x => (x.AppointDate.Date == model.AppointDate.Date)
            && (x.AppointDate.TimeOfDay.Hours == model.AppointDate.TimeOfDay.Hours)).Any();

            if (isReserved)
                throw new SDCException("This Appointment is already reserved before..", "-5");

            var addedEntity = _appointment.Add(new Appointment
            {
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                AppointDate = model.AppointDate,
                Note = model.Note
            });

            _unitOfWork.SaveChanges();
            model.Id = addedEntity.ID;
            return model;
        }

        public async Task<List<AppointmentDTO>> GetAllAppointments()
        {
            return _appointment.GetAll().OrderByDescending(x => x.CreationDate).Select(model => new AppointmentDTO
            {
                Id = model.ID,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                AppointDate = model.AppointDate,
                Note = model.Note
            }).ToList();
        }
    }
}
