using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                lstTareas.Items.Remove(lstTareas.SelectedItem);
                MessageBox.Show("Se eliminó la tarea seleccionada de la lista.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.");
            }
        }
        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            String tareasPendientes = txtTarea.Text;
            lstTareas.Items.Add(tareasPendientes);
            MessageBox.Show("Se agrego la tarea pendiente a la lista");
            txtTarea.Clear();
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Clear();
            MessageBox.Show("Se han eliminado todas las tareas de la lista.");
        }
    }
}
