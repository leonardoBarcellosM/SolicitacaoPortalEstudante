﻿using OpenQA.Selenium;
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
        private ClassUtilities util = new ClassUtilities();

        HttpClient Client = new HttpClient();

        public bool ConsultarServicoCarregarSolicitacao()
        {

            String Token = ClassUtilities.getItemFromLocalStorage("value");
            bool _result = CarregarSolicitacao(Token);

            return _result;
        }

        public bool CarregarSolicitacao(string Token)
        {
            bool _result = false;
            const string WEBSERVICE_URL = "http://homologacao.fundacred.org.br:8080/portal-estudante-rest/resources/solicitacaoCredito/carregar";
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 12000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", Token);

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            string value = String.Format("Response: {0}", jsonResponse);
                            string[] values = value.Split('"');
                            if (values[5] == "CADASTRO_INICIADO")
                            {
                                _result = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return _result;
        }
    }
}
