using Interface_Klimov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Klimov.Interfaces
{
    public interface IMessages
    {
        void All(out List<Messages> Messages);

        void Save(bool Update = false);

        void Delete();
    }
}
