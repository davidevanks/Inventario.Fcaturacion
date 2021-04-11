using Inventario.Clients;
using Inventario.Entity;
using Inventario.Entity.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Business
{
   public class BUPais
    {
        private Client client;

        public BUPais()
        {
            client = new Client();
        }

        public List<ResponsePais> listaPaises(ENRegistroEmpresa paramss, string token)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<ResponsePais>>(client.Post<ENRegistroEmpresa>("RegistroEmpresas/listarPaises", paramss, token));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
