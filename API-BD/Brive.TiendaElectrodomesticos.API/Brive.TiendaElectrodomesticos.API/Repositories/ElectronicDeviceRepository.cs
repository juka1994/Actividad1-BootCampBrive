using Brive.TiendaElectrodomesticos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.TiendaElectrodomesticos.API.Repositories
{
    public class ElectronicDeviceRepository : IElectronicDeviceRepository
    {
        private readonly TiendaElectrodomesticosContext context;
        public ElectronicDeviceRepository(TiendaElectrodomesticosContext _context)
        {
            context = _context;
        }
        public void DeletedElectronicDevice(ElectronicDevice electronicDevice)
        {
            context.ElectronicDevice.Remove(electronicDevice);
            context.SaveChanges();
        }

        public ElectronicDevice EditedElectronicDevice(ElectronicDevice electronicDevice)
        {
            ElectronicDevice editedElectronicDevice = context.ElectronicDevice.Find(electronicDevice.Id);
            if (editedElectronicDevice == null)
                return null;
            editedElectronicDevice.Nombre = electronicDevice.Nombre;
            editedElectronicDevice.Marca = electronicDevice.Marca;
            editedElectronicDevice.Color = electronicDevice.Color;
            editedElectronicDevice.Precio = electronicDevice.Precio;
            editedElectronicDevice.Descripcion = electronicDevice.Descripcion;

            context.ElectronicDevice.Update(editedElectronicDevice);
            context.SaveChanges();

            return editedElectronicDevice;
        }

        public List<ElectronicDevice> GetAllElectronicDevices()
        {
            return context.ElectronicDevice.ToList();
        }

        public ElectronicDevice GetElectronicDeviceById(int Id)
        {
            return context.ElectronicDevice.Find(Id);
        }

        public ElectronicDevice SaveElectronicDevice(ElectronicDevice electronicDevice)
        {
            context.ElectronicDevice.Add(electronicDevice);
            context.SaveChanges();
            return electronicDevice;
        }
    }
}
