using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Entidade
{
    public interface ILogin
    {
        string Email { get; set; }
    }
    public class LoginBase : ILogin {
        public string Email { get; set; }
        public string Senha{ get; set; }

    }
    public class Login : LoginBase
    {
        public int Id { get; set; }
        public string Role { get; set; }
    }
}
