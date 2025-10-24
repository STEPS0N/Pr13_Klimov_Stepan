using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Klimov.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FIO { get; set; }

        public Users() { }

        public Users(int id, string fIO)
        {
            this.Id = id;
            this.FIO = fIO;
        }
    }
}
