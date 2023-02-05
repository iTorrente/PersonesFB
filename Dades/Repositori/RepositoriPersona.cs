using Firebase.Database;
using Firebase.Database.Query;
using PersonesFB.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonesFB.Dades.Repositori
{
    public class RepositoriPersona : IRepositoriPersona
    {
        public FirebaseClient Firebase { get; set; }

        public RepositoriPersona()
        {
            Firebase = FireBaseClient.GetFireBaseClient();
        }

        public async Task<IReadOnlyCollection<FirebaseObject<PersonaObject>>> GetPersonesObject()
        {
            return await Firebase.Child("PersonasObject")
                .OrderByKey()
                .OnceAsync<PersonaObject>();
        }

        public async Task<IReadOnlyCollection<FirebaseObject<PersonaArray>>> GetPersonesArray()
        {
            return await Firebase.Child("PersonasArray")
                .OrderByKey()
                .OnceAsync<PersonaArray>();
        }
    }
}
