using System;
using System.Windows.Forms;

namespace _10.Escribir_archivo
{
    public partial class Form1 : Form
    {        
        ManejadorDeArchivos Archivo = new ManejadorDeArchivos();

        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String NombreArchivo = txtBoxArchivo.Text;
            String Texto = txtBoxTexto.Text;
            Archivo.Escribir(NombreArchivo, Texto);
            
        }

        private void txtBoxArchivo_Enter(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblSave.Text = saveFileDialog1.FileName;
            }
        }
    }
}
