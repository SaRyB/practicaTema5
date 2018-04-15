using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Practica_6._1__control_de_versiones_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //===================RUM1718======================================
        private void aluNombre_TextChanged(object sender, EventArgs e)
        {
            //===================RUM1718======================================
        }

        private void aluNota_TextChanged(object sender, EventArgs e)
        {
            //===================RUM1718======================================
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //===================RUM1718======================================

            String Nombre = "", Nota = "", Alumno = "";

            Nombre = aluNombre.Text;
            Nota = aluNota.Text;

            Alumno += "Nombre: " + Nombre + " nota: " + Nota + "\n";

            

            listaAlumnos.Text = Alumno;

        }

        private void listaAlumnos_TextChanged(object sender, EventArgs e)
        {
            //hola
        }
    }
}
