using System;
using System.Collections.Generic;
using System.Text;
using Accademy.Umana.Tutorial.Contracts;
using Accademy.Umana.Tutorial.Entities;


namespace Accademy.Umana.Tutorial.Tools
{
    public class NameRepository
    {
        public Person[] GetPeople()
        {

            return new Person[]
            {
                new Student{
                    Id = 1,
                    FirstName = "Tanjin",
                    LastName  = "Habibur",
                    Birthday = new DateTime(1995,5,3),
                    YearOfStudy = 5
                },
                new Student{
                    Id = 2,
                    FirstName = "Hendry",
                    LastName  = "Rakoto",
                    Birthday = new DateTime(1992,1,28),
                    YearOfStudy = 5
                },
                new Student{
                    Id = 3,
                    FirstName = "Marco",
                    LastName  = "Polo",
                    Birthday = new DateTime(1995,1,3),
                    YearOfStudy = 5
                },
                new Teacher{
                    Id = 4,
                    FirstName = "Andrea",
                    LastName  = "Boschin",
                    Birthday = new DateTime(1968,10,27),
                    Subject = "c#"
                },

            };

        }


        public IElement[] GetIElements()
        {
            return new IElement[]
            {
                new Car
                {
                    Id = 234,
                    Brand = "Ferrari",
                    Model = "Testarossa"
                },
                new Student{
                    Id = 1,
                    FirstName = "Tanjin",
                    LastName  = "Habibur",
                    Birthday = new DateTime(1995,5,3),
                    YearOfStudy = 5
                },
                new Student{
                    Id = 2,
                    FirstName = "Hendry",
                    LastName  = "Rakoto",
                    Birthday = new DateTime(1992,1,28),
                    YearOfStudy = 5
                },
                new Student{
                    Id = 3,
                    FirstName = "Marco",
                    LastName  = "Polo",
                    Birthday = new DateTime(1995,1,3),
                    YearOfStudy = 5
                },
                new Teacher{
                    Id = 4,
                    FirstName = "Andrea",
                    LastName  = "Boschin",
                    Birthday = new DateTime(1968,10,27),
                    Subject = "c#"
                },

            };

        }

    }
}
