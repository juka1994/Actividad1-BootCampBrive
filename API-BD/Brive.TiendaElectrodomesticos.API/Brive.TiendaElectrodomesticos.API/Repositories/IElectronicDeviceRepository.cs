using Brive.TiendaElectrodomesticos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.TiendaElectrodomesticos.API.Repositories
{
    public interface IElectronicDeviceRepository
    {
        List<ElectronicDevice> GetAllElectronicDevices();
        ElectronicDevice GetElectronicDeviceById(int Id);
        ElectronicDevice SaveElectronicDevice(ElectronicDevice electronicDevice);
        ElectronicDevice EditedElectronicDevice(ElectronicDevice electronicDevice);
        void DeletedElectronicDevice(ElectronicDevice electronicDevice);
    }
}
