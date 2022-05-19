using Brive.TiendaElectrodomesticos.API.Models;
using Brive.TiendaElectrodomesticos.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.TiendaElectrodomesticos.API.Services
{
    public class ElectronicDeviceService : IElectronicDeviceService
    {
        private readonly IElectronicDeviceRepository _electronicRepository;
        public ElectronicDeviceService(IElectronicDeviceRepository electronicDeviceRepository)
        {
            _electronicRepository = electronicDeviceRepository;
        }
        public bool DeletedElectronicDevice(ElectronicDevice electronicDevice)
        {
            try
            {
                _electronicRepository.DeletedElectronicDevice(electronicDevice);
                return true;
            }
            catch
            {
                return false;
                
            }
        }

        public ElectronicDevice EditedElectronicDevice(ElectronicDevice electronicDevice)
        {
            return _electronicRepository.EditedElectronicDevice(electronicDevice);
        }

        public List<ElectronicDevice> GetAllElectronicDevices()
        {
            return _electronicRepository.GetAllElectronicDevices();
        }

        public ElectronicDevice GetElectronicDeviceById(int Id)
        {
            return _electronicRepository.GetElectronicDeviceById(Id);
        }

        public ElectronicDevice SaveElectronicDevice(ElectronicDevice electronicDevice)
        {
            return _electronicRepository.SaveElectronicDevice(electronicDevice);
        }
    }
}
