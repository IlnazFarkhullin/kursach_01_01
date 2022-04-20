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
    class students_class
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public students_class(ObjectId id, string surname, string name, string lname, string birth_date, string phone, string email, string medical_policy, string iNN, string series, string number, string registration)
        {
            _id = id;
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

        //[BsonElement("name")]
        public string Name { get; set; }

        //[BsonElement("lname")]
        public string Lname { get; set; }

        //[BsonElement("birth_date")]
        public string Birth_date { get; set; }
        //[BsonElement("phone")]
        public string Phone { get; set; }

        //[BsonElement("email")]
        public string email { get; set; }

        //[BsonElement("medical_policy")]
        public string Medical_policy { get; set; }

        //[BsonElement("inn")]
        public string INN { get; set; }

        //[BsonElement("series")]
        public string Series { get; set; }

        //[BsonElement("number")]
        public string Number { get; set; }

        //[BsonElement("registration")]
        public string Registration { get; set; }

    }
}

