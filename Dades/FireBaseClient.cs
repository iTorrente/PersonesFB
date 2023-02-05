using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;

namespace PersonesFB.Dades
{
    public class FireBaseClient
    {
        /// <summary>
        /// Devuelve un cliente de conexión con una base de datos de Firebase
        /// </summary>
        /// <returns>FirebaseClient</returns>
        public static FirebaseClient GetFireBaseClient()
        {
            string URL = "https://personesfb-default-rtdb.europe-west1.firebasedatabase.app/";
            string secret = "MbEPsdBDooF66s97Z4w3ZEHwKfeD2KZoRLtASQKq";
            FirebaseClient firebaseClient;
            if (string.IsNullOrEmpty(secret))
            {
                firebaseClient = new FirebaseClient(URL);
            }
            else
            {
                firebaseClient = new FirebaseClient(
                URL,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(secret)
                });
            }
            return firebaseClient;
        }
    }
}
