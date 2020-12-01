using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace TallerDBaaS.Models
{
    public class Communication
    {

        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        //Se indica el URL de conexión con el usuario y contraseña previamente añadidos al DBaaS de MongoDB Atlas
        public static string Connection = "mongodb+srv://Agven:123@cluster0.brbxy.mongodb.net/<dbname>?retryWrites=true&w=majority";
        //Se indica el nombre de la base de datos a la que se quiere acceder
        public static string DataBase = "DBaaS_Taller";

        public static IMongoCollection<Models.Grades> grades_collection { get; set; }

        internal static void ConnectToMongoService()
        {
            try
            {
                client = new MongoClient(Connection);
                database = client.GetDatabase(DataBase);
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}