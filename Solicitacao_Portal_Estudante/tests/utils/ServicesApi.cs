using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    class ServicesApi
    {
        static string Result = null;
        static System.Net.Http.HttpClient Client = new System.Net.Http.HttpClient();

        public bool Testar()
        {
            string Path = "http://prod-camunda.fundacred.org.br:8080/engine-rest/incident/count";

            var result = Client.GetStringAsync(new Uri(Path)).Result;

            string[] jSon = result.Split('\"');
            Result = jSon[2];

            if(result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
