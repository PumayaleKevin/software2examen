using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalTrabajador
    {
        public void insertarTrabajador(Ctrabajador pTrabajador)
        {
            using (var bd = new examen2softEntities())
            {
                var per = new Trabajador();
                per.id_trabajador = pTrabajador.id;
                per.nombres = pTrabajador.nombres;
                per.apellidos = pTrabajador.apellidos;
                per.sueldo = pTrabajador.sueldo;
                per.categoria = pTrabajador.categoria;
                bd.Trabajador.Add(per);
                bd.SaveChanges();
            }

        }
    }
