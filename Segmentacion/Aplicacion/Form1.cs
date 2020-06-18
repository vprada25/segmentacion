using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            if(archivo.ShowDialog()==DialogResult.OK)
            {
                this.imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                imagen.Image = Image.FromFile(archivo.FileName);
                segmentar.Enabled = true;

            }
        }

        private void listado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void segmentar_Click(object sender, EventArgs e)
        {

        }
        
    }
}
