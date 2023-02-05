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
        public List<PersonaObject> llistaPersonesObject = new List<PersonaObject>();
        public List<PersonaArray> llistaPersonesArray = new List<PersonaArray>();
        public string tipus = "";

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
            llistaPersonesObject.Clear();
            var personesObject = await DominiPersona.ObtenirPersonesObject();
            foreach (var persona in personesObject)
            {
                lstPersones.Items.Add(persona.Key);
                llistaPersonesObject.Add(persona.Object);
            }
            EnableButtons();
            tipus = "object";
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
            llistaPersonesArray.Clear();
            DominiPersona.index.Clear();
            var personesArray = await DominiPersona.ObtenirPersonesArray();
            var personesOrdenades = personesArray.OrderBy(p => p.Key);
            foreach (var persona in personesOrdenades)
            {
                
                lstPersones.Items.Add(persona.Key+": "+persona.Object.nombre);
                llistaPersonesArray.Add(persona.Object);
                DominiPersona.index.Add(Convert.ToInt32(persona.Key));
            }
            int i=DominiPersona.GetNextIndex();
            EnableButtons();
            tipus = "array";
        }

        private void lstPersones_DoubleClick(object sender, EventArgs e)
        {
            if (tipus=="object")
            {
                Modificacio f = new Modificacio(lstPersones.SelectedItem.ToString(), llistaPersonesObject[lstPersones.SelectedIndex], DominiPersona);
                f.Show();
                lstPersones.Refresh();
            }
            else if (tipus=="array")
            {
                DominiPersona.keyIndex = lstPersones.SelectedIndex;
                Modificacio f = new Modificacio(llistaPersonesArray[lstPersones.SelectedIndex], DominiPersona);
                f.Show();
                lstPersones.Refresh();
            }
            
        }

        private void btnEditaPersona_Click(object sender, EventArgs e)
        {
            if (lstPersones.SelectedItems.Count == 0) MessageBox.Show("Has de seleccionar una persona per editar.");
            else
            {
                if (tipus == "object")
                {
                    Modificacio f = new Modificacio(lstPersones.SelectedItem.ToString(), llistaPersonesObject[lstPersones.SelectedIndex], DominiPersona);
                    f.Show();
                    lstPersones.Refresh();
                }
                else if (tipus == "array")
                {
                    DominiPersona.keyIndex = lstPersones.SelectedIndex;
                    Modificacio f = new Modificacio(llistaPersonesArray[lstPersones.SelectedIndex], DominiPersona);
                    f.Show();
                    lstPersones.Refresh();
                }
            }
            lstPersones.Refresh();
        }

        private void btnAfegirPersona_Click(object sender, EventArgs e)
        {
            Modificacio f = new Modificacio(tipus,DominiPersona);
            f.Show();
            lstPersones.Refresh();
        }

        private void btnEsborrarPersona_Click(object sender, EventArgs e)
        {
            if (tipus=="object")
            {
                DominiPersona.EliminaPersonaObject(lstPersones.SelectedItem.ToString());
                MessageBox.Show("Persona esborrada amb éxit.");
            }
            else if (tipus=="array")
            {
                DominiPersona.EliminaPersonaArray(lstPersones.SelectedIndex);
                MessageBox.Show("Persona esborrada amb éxit.");
            }
            lstPersones.Refresh();
        }
    }
}
