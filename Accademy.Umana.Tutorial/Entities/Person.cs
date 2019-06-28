using Accademy.Umana.Tutorial.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accademy.Umana.Tutorial.Entities
{
    public abstract class Person:IElement
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public abstract string Type { get; }


        public string FullName
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Today.Year - this.Birthday.Year;
            }
        }


        public int CalculateAge()
        {
            return DateTime.Today.Year - this.Birthday.Year;
        }

        public void Clear()
        {
            Console.WriteLine($"L'istanza {this.Id} è stata pulita");
        }



        public override string ToString()
        {
            return
                $"[PERSON]\n" +
                $"ID        =   {this.Id}\n" +
                $"Full Name =   {this.FullName}\n" +
                $"Age       =   {this.Age}\n" +
                $"Birthday  =   {this.Birthday}\n";
        }


    }
}
