using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    public class AccountService//SubSystem  which may be complex in real life context
    {
        public bool CheckBalance(int AccountId) => true;
    }
}
