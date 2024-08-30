using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupaMegaGamaBot.User
{
    public class UserData
    {
        public string Name {  get; set; }

        public override string ToString()
        {
            return $"Имя={Name}"; 
        }
    }
}
