using System;
using System.Collections.Generic;
using System.Text;

namespace todoList.views
{
    class Person
    {
        public string firstName {get;set;}
        public string lastName { get; set; }
        public string city { get; set; }
        public Person(string firstName, string lastName, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
        }

        public string fullName
        {
            get { return string.Format("{0} {1}", firstName, lastName); }
        }
    }
}
