using PupaMegaGamaBot.User.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupaMegaGamaBot.User
{
    public record class UserState(IPage Page, UserData UserData)
    {

    }
}
