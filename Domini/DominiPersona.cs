using Firebase.Database;
using Firebase.Database.Query;
using PersonesFB.Dades.Model;
using PersonesFB.Dades.Repositori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonesFB.Domini
{
    public class DominiPersona : IDominiPersona
    {
        public RepositoriPersona RepositoriPersona { get; set; }
        public List<int>index = new List<int>();
        public int keyIndex = -1;

        public DominiPersona()
        {
            RepositoriPersona = new RepositoriPersona();
        }

        public Task<IReadOnlyCollection<FirebaseObject<PersonaArray>>> ObtenirPersonesArray()
        {
            return RepositoriPersona.GetPersonesArray();
        }

        public Task<IReadOnlyCollection<FirebaseObject<PersonaObject>>> ObtenirPersonesObject()
        {
            return RepositoriPersona.GetPersonesObject();
        }
        public async Task AfegeixPersonaObject(string nom,PersonaObject persona)
        {
            await RepositoriPersona.Firebase
              .Child("PersonasObject")
              .Child(nom)
              .PutAsync(persona);
        }
        public async Task AfegeixPersonaArray(PersonaArray persona)
        {
            if (keyIndex == -1) keyIndex = GetNextIndex();
            await RepositoriPersona.Firebase
              .Child("PersonasArray")
              .Child(keyIndex.ToString())
              .PutAsync(persona);
        }
        public int GetNextIndex()
        {
            bool indexTrobat = false;
            int i = 0;
            int idxFinal = 0;
            index.Sort();
            while (i < index.Count && !indexTrobat)
            {
                if (index[i] > i) { indexTrobat = true; idxFinal = i; }
                i++;
            }
            if (!indexTrobat) idxFinal = index[index.Count - 1] + 1;

            return idxFinal;
        }
        public async Task EliminaPersonaObject(string nom)
        {
            await RepositoriPersona.Firebase
              .Child("PersonasObject").Child(nom).DeleteAsync();
        }
        public async Task EliminaPersonaArray(int index)
        {
            await RepositoriPersona.Firebase
              .Child("PersonasArray").Child(index.ToString()).DeleteAsync();
        }
    }
}
