using Accademy.Umana.Tutorial.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accademy.Umana.Tutorial.Entities
{
    public abstract class Resource
    {
        public abstract string Type { get; }

        public static bool IsOfType(IElement element, string type)
        {
            return element.Type.ToLower() == type.ToLower();

        }

    }


    public static class Checks {



    }
}
