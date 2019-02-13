using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Linq;


namespace Solicitacao_Portal_Estudante.tests.steps
{
    class RestApi
    {
        static HttpClient Client = new HttpClient();

        public bool ConsultarToken()
        {
            bool _result = true;
            string Path = "http://homologacao.fundacred.org.br:8080/portal-estudante-rest/resources/acao/buscar?sort=-dtAcao&filter=cpf=80220450048";

            var result = Client.GetStringAsync(new Uri(Path)).Result;

            string[] jSon = result.Split('\"');
            result = jSon[5];
            //return result;
            return _result;
        }

    }
}
