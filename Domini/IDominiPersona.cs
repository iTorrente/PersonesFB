using Firebase.Database;
using PersonesFB.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonesFB.Domini
{
    public interface IDominiPersona
    {
        Task<IReadOnlyCollection<FirebaseObject<PersonaObject>>> ObtenirPersonesObject();
        Task<IReadOnlyCollection<FirebaseObject<PersonaArray>>> ObtenirPersonesArray();
    }
}
