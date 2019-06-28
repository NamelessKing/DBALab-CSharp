using System;
using System.Collections.Generic;
using System.Text;

namespace Accademy.Umana.Tutorial.Contracts
{
    public interface IElement
    {
        int Id { get; set; }
        string FullName { get;}
        string Type { get; }

        void Clear();
    }
}
