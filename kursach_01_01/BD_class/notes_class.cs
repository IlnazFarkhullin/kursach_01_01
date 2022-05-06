using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace kursach_01_01.BD_class
{
    public class notes_class
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public notes_class( string name_notes, string text, DateTime date)
        {
            Name_notes = name_notes;
            Text = text;
            Date = date;
        }
        public string Name_notes { get; set; }
        public string Text { get; set; }
        public DateTime Date{get;set;}
    }
}
