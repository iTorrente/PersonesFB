using PersonesFB.Dades.Model;
using PersonesFB.Domini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonesFB.Vistes
{
    public partial class Modificacio : Form
    {
        private string nom;
        private PersonaObject personaObject;
        private PersonaArray personaArray;
        private DominiPersona DominiPersona { get; set; }
        private bool esArray = false;

        public Modificacio()
        {
            InitializeComponent();
            personaObject=new PersonaObject();
            personaObject.rangoProfesional = new PersonaObject.RangoProfesional();
        }
        public Modificacio(string tipus,DominiPersona domini)
        {
            InitializeComponent();
            DominiPersona = domini;
            if (tipus=="object")
            {
                personaObject = new PersonaObject();
                personaObject.rangoProfesional = new PersonaObject.RangoProfesional();
            }
            else if (tipus=="array")
            {
                personaArray = new PersonaArray();
                personaArray.rangoProfesional = new Rangoprofesional();
                esArray = true;
            }
        }

        public Modificacio(string nom, PersonaObject personaObject,DominiPersona dominiPersona)
        {
            InitializeComponent();
            this.DominiPersona = dominiPersona;
            this.nom = nom;
            this.personaObject = personaObject;
            tbNom.Text = nom;
            tbDisponibilitatViatjar.Text = personaObject.disponibilidadParaViajar.ToString();
            tbEdat.Text = personaObject.edad.ToString();
            tbProfessio.Text = personaObject.profesion.ToString();
            tbNivell.Text = personaObject.rangoProfesional.nivel.ToString();
            tbAnysExp.Text = personaObject.rangoProfesional.aniosDeExperiencia.ToString();
            lstLlenguatges.Items.AddRange(personaObject.lenguajes);
        }

        public Modificacio(PersonaArray personaArray, DominiPersona dominiPersona)
        {
            InitializeComponent();
            this.personaArray = personaArray;
            DominiPersona = dominiPersona;
            esArray = true;
            tbNom.Text = personaArray.nombre;
            tbDisponibilitatViatjar.Text = personaArray.disponibilidadParaViajar.ToString();
            tbEdat.Text = personaArray.edad.ToString();
            tbProfessio.Text = personaArray.profesion;
            tbNivell.Text = personaArray.rangoProfesional.nivel;
            tbAnysExp.Text = personaArray.rangoProfesional.aniosDeExperiencia.ToString();
            lstLlenguatges.Items.AddRange(personaArray.lenguajes);
            esArray = true;
        }

        private void btnDesa_Click(object sender, EventArgs e)
        {
            if (!esArray)
            {
                personaObject.nombre = tbNom.Text;
                personaObject.edad = Convert.ToInt32(tbEdat.Text);
                personaObject.profesion = tbProfessio.Text;
                personaObject.disponibilidadParaViajar = Convert.ToBoolean(tbDisponibilitatViatjar.Text);
                personaObject.rangoProfesional.aniosDeExperiencia = Convert.ToInt32(tbAnysExp.Text);
                personaObject.rangoProfesional.nivel = tbNivell.Text;
                personaObject.lenguajes = new string[lstLlenguatges.Items.Count];
                int idx = 0;
                foreach (string idioma in lstLlenguatges.Items)
                {
                    personaObject.lenguajes[idx] = idioma;
                    idx++;
                }

                DominiPersona.AfegeixPersonaObject(tbNom.Text, this.personaObject);
                MessageBox.Show("La persona ha estat correctament afegida/modificada.");
                this.Close();
            }
            else
            {
                personaArray.nombre = tbNom.Text;
                personaArray.edad = Convert.ToInt32(tbEdat.Text);
                personaArray.profesion = tbProfessio.Text;
                personaArray.disponibilidadParaViajar = Convert.ToBoolean(tbDisponibilitatViatjar.Text);
                personaArray.rangoProfesional.aniosDeExperiencia = Convert.ToInt32(tbAnysExp.Text);
                personaArray.rangoProfesional.nivel = tbNivell.Text;
                personaArray.lenguajes = new string[lstLlenguatges.Items.Count];
                int idx = 0;
                foreach (string idioma in lstLlenguatges.Items)
                {
                    personaArray.lenguajes[idx] = idioma;
                    idx++;
                }
                DominiPersona.AfegeixPersonaArray(this.personaArray);
                MessageBox.Show("La persona ha estat correctament afegida/modificada.");
                this.Close();
            }
            
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLlenguatge_Click(object sender, EventArgs e)
        {
            lstLlenguatges.Items.Add(Microsoft.VisualBasic.Interaction.InputBox("Entra un llenguatge:", "", ""));
        }

        private void btnRemoveLlenguatge_Click(object sender, EventArgs e)
        {
            if (lstLlenguatges.SelectedItem!=null) lstLlenguatges.Items.RemoveAt(lstLlenguatges.SelectedIndex);
        }
    }
}
