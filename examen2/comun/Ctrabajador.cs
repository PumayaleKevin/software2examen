using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class Ctrabajador
    {
            public int id{ get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public decimal sueldo { get; set; }
            public string categoria {  get; set; }

            public override string ToString()
            {
                return string.Format("Trabajador (id={0},nombres={1}, apellidos={2},sueldo={3}, categoria{4}",
                    id, nombres, apellidos, sueldo,categoria);
            }
    }
}
