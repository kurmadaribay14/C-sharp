using System;
using System.Collections.Generic;

namespace lesson10
{
    class Group
    {

        public int id {get;set;}
        public string name {get;set;}
        public ICollection<Student> Students{get;set;}
    }
}
