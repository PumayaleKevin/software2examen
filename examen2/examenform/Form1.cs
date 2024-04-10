using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var perComun = new Ctrabajador();
            var dalPer = new dalTrabajador();
            perComun.id = (int)txtId.Value;
            perComun.nombres = txtNombres.Text;
            perComun.apellidos = txtApellido.Text;
            perComun.sueldo =(int) txtSueldo.Text;
            perComun = txtCategoria = txtCategoria.Text;
            MessageBox.Show(perComun.ToString());
            dalPer.insertarPersona(perComun);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
