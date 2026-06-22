using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form formularioActivo = null;


        private void AbrirFormulario(Form form)
        {

            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo=form;


            form.TopLevel = false;

            panelContendor.Controls.Clear();
            panelContendor.Controls.Add(form);

            form.Show();
        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form2());
        }
    }
}
