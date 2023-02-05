using PersonesFB.Dades.Model;
using PersonesFB.Domini;
using PersonesFB.Vistes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonesFB
{

    public partial class Form1 : Form
    {
        public DominiPersona DominiPersona { get; set; }
        public List<PersonaObject> llistaPersones = new List<PersonaObject>();

        public Form1()
        {
            InitializeComponent();
            btnEditaPersona.Enabled = false;
            btnEsborrarPersona.Enabled = false;
            btnAfegirPersona.Enabled = false;
            DominiPersona = new DominiPersona();
        }

        private async void btnLoadPersonesObject_Click(object sender, EventArgs e)
        {
            lstPersones.Items.Clear();
            var personesObject = await DominiPersona.ObtenirPersonesObject();
            foreach (var persona in personesObject)
            {
                lstPersones.Items.Add(persona.Key);
                llistaPersones.Add(persona.Object);
            }
            EnableButtons();
        }

        private void EnableButtons()
        {
            btnAfegirPersona.Enabled = true;
            btnEditaPersona.Enabled = true;
            btnEsborrarPersona.Enabled = true;
        }

        private async void btnLoadPersonesArray_Click(object sender, EventArgs e)
        {
            lstPersones.Items.Clear();
            var personesArray = await DominiPersona.ObtenirPersonesArray();
            foreach (var persona in personesArray)
            {
                lstPersones.Items.Add(persona.Key);
            }
        }

        private void lstPersones_DoubleClick(object sender, EventArgs e)
        {
            Modificacio f = new Modificacio(lstPersones.SelectedItem.ToString(), llistaPersones[lstPersones.SelectedIndex],DominiPersona);
            f.Show();
            lstPersones.Refresh();
        }

        private void btnEditaPersona_Click(object sender, EventArgs e)
        {
            if (lstPersones.SelectedItems.Count == 0) MessageBox.Show("Has de seleccionar una persona per editar.");
            else
            {
                Modificacio f = new Modificacio(lstPersones.SelectedItem.ToString(), llistaPersones[lstPersones.SelectedIndex],DominiPersona);
                f.Show();
            }
            lstPersones.Refresh();
        }

        private void btnAfegirPersona_Click(object sender, EventArgs e)
        {
            Modificacio f = new Modificacio();
            f.Show();
            lstPersones.Refresh();
        }

        private void btnEsborrarPersona_Click(object sender, EventArgs e)
        {
            DominiPersona.EliminaPersonaObject(lstPersones.SelectedItem.ToString());
            lstPersones.Refresh();
        }
    }
}
