using Firebase.Database;
using PersonesFB.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonesFB.Dades.Repositori
{
    public interface IRepositoriPersona
    {
        Task<IReadOnlyCollection<FirebaseObject<PersonaObject>>> GetPersonesObject();
        Task<IReadOnlyCollection<FirebaseObject<PersonaArray>>> GetPersonesArray();
    }
}
