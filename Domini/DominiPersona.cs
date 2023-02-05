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
        public async void AfegeixPersonaObject(string nom,PersonaObject persona)
        {
            await RepositoriPersona.Firebase
              .Child("PersonasObject")
              .Child(nom)
              .PutAsync(persona);
        }
        public async void EliminaPersonaObject(string nom)
        {
            await RepositoriPersona.Firebase
              .Child("PersonasObject").Child(nom).DeleteAsync();
        }
    }
}
