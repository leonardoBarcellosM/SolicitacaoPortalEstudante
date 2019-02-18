using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    class ServicesApi
    {
        static string Result = null;
        HttpClient Client = new HttpClient();

        public bool ConsultarServicoCarregarSolicitacao()
        {
            return true;
        }

        public bool testar()
        {
            const string WEBSERVICE_URL = "http://homologacao.fundacred.org.br:8080/portal-estudante-rest/resources/solicitacaoCredito/carregar";
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 12000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzUxMiJ9.eyJpYXQiOjE1NTAyMzM2OTUsInN1YiI6IiIsImlzcyI6IiIsInByaW5jaXBhbCI6IntcImlkXCI6MTUzMzk5LFwibmFtZVwiOlwiTEVPTkFSRE8gQkFSQ0VMTE9TIFRFU1RFXCIsXCJjcGZcIjpcIjgwMjIwNDUwMDQ4XCIsXCJyb2xlc1wiOntcIkVzdHVkYW50ZVwiOnRydWV9LFwicGVyZmlsXCI6bnVsbCxcImlkR3J1cG9JRVNcIjpudWxsLFwiZW1wcmVzYUlkXCI6bnVsbCxcImNhbXB1c0lkXCI6bnVsbCxcInNpZ2xhc0JwbVwiOltdfSIsImV4cCI6MTU1MDIzNDU5NX0.uM2mlNYM2XnwsJ1yCT55UMRtWhR-QzaYQznTZY3BnWxCPdxohXIvvuKn0ubJTmqeO4eLIzGXn-o-d7hZ5HBeXg");

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            Console.WriteLine(String.Format("Response: {0}", jsonResponse));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return true;
        }
    }
}
