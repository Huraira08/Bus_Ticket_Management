using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public abstract class Person
    {
        protected string name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }
        
        public string Name {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}