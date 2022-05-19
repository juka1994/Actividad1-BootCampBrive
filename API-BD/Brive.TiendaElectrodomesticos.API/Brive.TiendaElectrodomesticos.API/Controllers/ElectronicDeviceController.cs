using Brive.TiendaElectrodomesticos.API.Models;
using Brive.TiendaElectrodomesticos.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.TiendaElectrodomesticos.API.Controllers
{
    [EnableCors("TiendaElectrodomesticos")]
    [Route("api/[controller]")]
    [ApiController]
    public class ElectronicDeviceController : ControllerBase
    {
        private IElectronicDeviceService _electronicDeviceService;
        public ElectronicDeviceController(IElectronicDeviceService electronicDeviceService)
        {
            _electronicDeviceService = electronicDeviceService;
        }

        [HttpGet]
        [Route("electronics")]
        public ActionResult<List<ElectronicDevice>> GetAllElectronicDevice()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _electronicDeviceService.GetAllElectronicDevices());
            }
            catch (Exception e)
            {

                 throw new Exception(e.Message);
            }
        }
        [HttpGet]
        [Route("{Id}")]
        public ActionResult<ElectronicDevice> GetElectronicDeviceById(int Id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _electronicDeviceService.GetElectronicDeviceById(Id));
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<ElectronicDevice> SaveElectronicDevice([FromBody] ElectronicDevice electronicDevice)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _electronicDeviceService.SaveElectronicDevice(electronicDevice));
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public ActionResult<ElectronicDevice> EditedElectronicDevice([FromBody] ElectronicDevice electronicDevice)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _electronicDeviceService.EditedElectronicDevice(electronicDevice));
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult<List<ElectronicDevice>> DeletedElectronicDevice([FromBody] int Id)
        {
            try
            {
                ElectronicDevice electronicDevice = _electronicDeviceService.GetElectronicDeviceById(Id);
                if (electronicDevice == null)
                    return StatusCode(StatusCodes.Status400BadRequest, null);
                return StatusCode(StatusCodes.Status200OK, _electronicDeviceService.DeletedElectronicDevice(electronicDevice));
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
