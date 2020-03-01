using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_DAO_DTO_Singleton.UI
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();

            IsMdiContainer = true;
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Persona Persona_View = Form_Persona.GetInstancia();

            Persona_View.MdiParent = this;

            Persona_View.Show();
        }
    }
}
