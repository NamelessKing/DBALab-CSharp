using System;
using Accademy.Umana.Tutorial.Contracts;
using Accademy.Umana.Tutorial.Entities;
using Accademy.Umana.Tutorial.Tools;

namespace Accademy.Umana.Tutorial.Application
{
    class Program
    {
        static void Main(string[] args)
        {

            var nameRepo = new NameRepository();

            IElement[] elements = nameRepo.GetIElements();


            foreach (IElement element in elements)
            {
                if (element.IsOfType(element,"Car")) {

                }
                //Console.WriteLine(person);
                Console.WriteLine(
                    $"Elemento di nome {element.FullName}\n" +
                    $"di tipo {element.Type}");

                Console.ReadLine();

            }


        }
    }
}
