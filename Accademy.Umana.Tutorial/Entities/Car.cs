using Accademy.Umana.Tutorial.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accademy.Umana.Tutorial.Entities
{
    public class Car : IElement
    {
        public int Id { get ; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string FullName {
            get
            {
                return ${ };    
            } 
        }

        public string Type =>"Car";

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
