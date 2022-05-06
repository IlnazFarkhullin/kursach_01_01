using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace kursach_01_01.BD_class
{
   public class students_class
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public students_class( string surname, string name, string lname, string birth_date, string phone, string email, string medical_policy, string iNN, string series, string number, string registration)
        {
           
            Surname = surname;
            Name = name;
            Lname = lname;
            Birth_date = birth_date;
            Phone = phone;
            this.email = email;
            Medical_policy = medical_policy;
            INN = iNN;
            Series = series;
            Number = number;
            Registration = registration;
        }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Birth_date  { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public string Medical_policy { get; set; }
        public string INN { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Registration { get; set; }

    }
}

