using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using todoList.views;

namespace todoList.models
{
     class Page1model 
    {
        public ObservableCollection<Person> people { get; set; }
        public Page1model() 
        {
            people = new ObservableCollection<Person>
            {
                
                new Person("parinya","thingtavee","pathumthani"),
                new Person("Arenakorn","Suk","pathumthani"),
            };
        }

     
    }
    

}
