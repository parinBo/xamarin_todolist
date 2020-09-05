using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace todoList.views
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
