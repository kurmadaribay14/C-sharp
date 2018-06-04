using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lesson10
{
    class RefSubjectStudent
    {
        [Key]
        public Student RefStudent {get;set;}
        [Key]
        public Subject RefSubject {get;set;}
      //  public ICollection<Student> Students{get;set;}
    }
}
//dotnet ef database update