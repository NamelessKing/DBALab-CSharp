using System;
using System.Collections.Generic;
using System.Text;

namespace Accademy.Umana.Tutorial.Entities
{
    public class Student:Person
    {
        public int YearOfStudy { get; set; }
        public override string Type => "Studente";

        public override string ToString()
        {
            return
                $"[STUDENT]\n" +
                $"ID        =   {this.Id}\n" +
                $"Full Name =   {this.FullName}\n" +
                $"Age       =   {this.Age}\n" +
                $"Birthday  =   {this.Birthday}";
        }

    }
}
