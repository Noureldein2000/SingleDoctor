using Infrastructure.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Repositiories.Interface;
using SingleDoctor.Commands;
using SingleDoctor.Queries;

namespace SingleDoctor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMediator _mediator;
        public AppointmentController(IAppointmentService appointmentService, IMediator mediator)
        {
            _appointmentService = appointmentService;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAppointments")]
        public async Task<ActionResult> GetAppointments()
        {
            try
            {
                var query = new GetAllAppointmentsQuery();
                var result = await _mediator.Send(query);
                return Ok(result);
            }
            catch (SDCException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AddAppointment")]
        public async Task<IActionResult> AddAppointment(AddAppointmentCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return Ok("Add Appointment Successfullyy");
            }
            catch (SDCException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
