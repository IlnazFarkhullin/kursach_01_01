using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using kursach_01_01.BD_class;

namespace kursach_01_01.BD_class
{
    class DataBaseMethods
    {
        public static  List<students_class> ShowStudents()
        {
            var stud = new MongoClient("mongodb://localhost"); // подключение
            var database = stud.GetDatabase("guide"); // бд
            var collection = database.GetCollection<BD_class.students_class>("Students"); // коллекция внутри БД
            return collection.Find(x => true).ToList(); // возвращение всех данных из коллекции
        }

        public static void EditStudent(string Surname, string Name, string Lname, string Phone,   string Registration, string NewPhone, string NewSurname, string NewName, string newLname,  string newRegistration) 
        {
            var stud = new MongoClient("mongodb://localhost");
            var database = stud.GetDatabase("guide");
            var collection = database.GetCollection<students_class>("Students");
            var updateSurname = Builders<students_class>.Update.Set(x => x.Surname, NewSurname);
            var updateName = Builders<students_class>.Update.Set(x => x.Name, NewName);  
            var updateLname = Builders<students_class>.Update.Set(x => x.Lname, newLname);
            var updatePhone = Builders<students_class>.Update.Set(x => x.Phone, NewPhone);
            var updateRegistration = Builders<students_class>.Update.Set(x => x.Registration, Registration);
            collection.UpdateOne(s => s.Surname == Surname , updateSurname);
            collection.UpdateOne(n => n.Name == Name , updateName);
            collection.UpdateOne(d => d.Lname== Lname , updateLname);
            collection.UpdateOne(z => z.Phone == Phone , updatePhone);
            collection.UpdateOne(o => o.Registration == Registration, updateRegistration);

    }

        public static void AddStudentToDatabase(students_class students_)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("guide");
            var collection = database.GetCollection<students_class>("Students");
            collection.InsertOne(students_);
        }

        public static async void RemoveStudentToDatabase(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("guide");
            var collection = database.GetCollection<students_class>("Students");
           var result = await collection.DeleteOneAsync(s => s._id == id);

        }

        public static List<notes_class> ShowNotes()
        {
            var notes = new MongoClient("mongodb://localhost");
            var datbase = notes.GetDatabase("guide");
            var collection = datbase.GetCollection<notes_class>("Notes");
            return collection.Find(x => true).ToList();
        }

        public static async  void RemoveNotes(ObjectId id)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("guide");
            var collection = database.GetCollection<notes_class>("Notes");
            var result = await collection.DeleteOneAsync(z => z._id == id);
        }
        
        public static void AddSNotes(notes_class nots_)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("guide");
            var collection = database.GetCollection<notes_class>("Notes");
            collection.InsertOne(nots_);
        }

        public static notes_class GetisNote(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("guide");
            var collection = database.GetCollection<notes_class>("Notes");
            var founded = collection.Find(n => n.Name_notes == name).FirstOrDefault();
            return founded;
        }

        public static List<authorization> Authorizations()
        {
            var auth = new MongoClient("mongodb://localhost");
            var database = auth.GetDatabase("guide");
            var collection = database.GetCollection<authorization>("auth");
            return collection.Find(x => true).ToList();
        }
    }
}
