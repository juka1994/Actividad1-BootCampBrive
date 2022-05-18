using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Ejercicio1.API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string editorial { get; set; }
        public int pages { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
