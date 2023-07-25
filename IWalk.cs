using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public interface IWalk
    {
        public int Legs { get; set; }
        public void Walks();

    }
}
