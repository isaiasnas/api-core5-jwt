using ApiCore.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Servico
{
    public class ServicoLogin
    {
        public static Login Get(string email, string senha)
        {
            var users = new List<Login>();
            users.Add(new Login { Id = 1, Email = "admin", Senha = "123", Role = "admin" });
            users.Add(new Login { Id = 2, Email = "vendedor", Senha = "123", Role = "admin" });
            return users
                .Where(x => x.Email.ToLower() == email.ToLower() && x.Senha == senha)
                .FirstOrDefault();
        }
    }
}
