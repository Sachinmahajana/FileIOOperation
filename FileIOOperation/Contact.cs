using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    [Serializable]
    internal class Contact
    {   
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name:{Name}, Id:{Id},Age:{Age}";
        }

    }
}
