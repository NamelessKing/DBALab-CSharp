using System;
using System.Collections.Generic;
using System.Text;

namespace Accademy.Umana.Tutorial.Entities
{
    public class Teacher:Person
    {
        public string Subject{ get; set; }
        public override string Type => "Teacher";

        public override string ToString()
        {
            return
                $"[TEACHER]\n" +
                $"ID        =   {this.Id}\n" +
                $"Full Name =   {this.FullName}\n" +
                $"Age       =   {this.Age}\n" +
                $"Birthday  =   {this.Birthday}\n";
        }
    }
}
