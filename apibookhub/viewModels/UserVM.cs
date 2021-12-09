using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apibookhub.viewModels
{
    public class UserVM
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Correo { get; set; }
        public string Contra { get; set; }
        public string Imagen { get; set; }
        public DateTime Fecha { get; set; }
    }
}
