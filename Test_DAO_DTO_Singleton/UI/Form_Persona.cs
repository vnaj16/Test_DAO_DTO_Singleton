using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_DAO_DTO_Singleton.DAO;

namespace Test_DAO_DTO_Singleton.UI
{
    public partial class Form_Persona : Form
    {
        #region PATRON SINGLETON
        private static Form_Persona Instancia = null;

        public static Form_Persona GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Form_Persona();
                Instancia.FormClosed += new FormClosedEventHandler(reset);
            }

            return Instancia;
        }

        private Form_Persona()
        {
            InitializeComponent();

        }

        private static void reset(object sender, FormClosedEventArgs e)
        {
            Instancia = null;
        }
        #endregion

        private void Form_Persona_Load(object sender, EventArgs e)
        {
            VerRegistros();
        }

        private void VerRegistros(string Condicion = "")
        {
            PersonaDAO DAO_Persona = new PersonaDAO();

            //ObservableCollection<PersonaDAO> Obj = (ObservableCollection<PersonaDAO>)DAO_Persona.VerRegistros();

            dataGridView1.DataSource = DAO_Persona.VerRegistros(Condicion).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerRegistros((sender as TextBox).Text);
        }
    }
}
