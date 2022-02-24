using SME.Terceirizadas.Gateway.Dtos;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml.Serialization;
using BodyCancelamento = SME.Terceirizadas.Gateway.Dtos.BodyCancelamento;
using BodySolicitacao = SME.Terceirizadas.Gateway.Dtos.BodySolicitacao;
using EnvelopeCancelamento = SME.Terceirizadas.Gateway.Dtos.EnvelopeCancelamento;
using EnvelopeSolicitacao = SME.Terceirizadas.Gateway.Dtos.EnvelopeSolicitacao;


namespace SME.Terceirizadas.Gateway
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SmeProxySigpaeService : ISmeProxySigpaeService
    {

        private readonly IConfiguracao _configuracao;

        public SmeProxySigpaeService(IConfiguracao configuracao)
        {
            _configuracao = configuracao;
        }

        public codresMOD Cancelamento(acessMOD oWsAcessoModel, CancelamentoMOD ArqCancelamento)
        {
            var urlSolicitacao = _configuracao.Obter("UrlSolicitacao");

            var request = new EnvelopeCancelamento();
            var body = new BodyCancelamento();
            var cancelamento = new CancelamentoToProxy();

            cancelamento.ArqSolicitacaoMOD = ArqCancelamento;
            cancelamento.OWsAcessoModel = oWsAcessoModel;
            body.Cancelamento = cancelamento;
            request.Body = body;
            string xmlforPostIntoSigpae = GeraXmlRequisicaoCancelamento(request);

            return EnviaRequisicaoCancelamento(urlSolicitacao, xmlforPostIntoSigpae);
        }

        public codresMOD Entrega(acessMOD oWsAcessoModel, EntregaMOD[] ArqEntregaMOD)
        {
            throw new NotImplementedException();
        }

        public codresMOD Solicitacao(acessMOD oWsAcessoModel, SolicitacaoMOD ArqSolicitacaoMOD)
        {
            try
            {

                var urlSolicitacao = _configuracao.Obter("UrlSolicitacao");

                var request = new EnvelopeSolicitacao();
                var body = new BodySolicitacao();
                var solicitacao = new SolicitacaoToProxy();

                solicitacao.ArqSolicitacaoMOD = ArqSolicitacaoMOD;
                solicitacao.OWsAcessoModel = oWsAcessoModel;
                body.Solicitacao = solicitacao;
                request.Body = body;
                string xmlforPostIntoSigpae = GeraXmlRequisicaoSolicitacao(request);

                return EnviaRequisicaoSolicitacao(urlSolicitacao, xmlforPostIntoSigpae);

            }
            catch (Exception e)
            {
                return new codresMOD() { StrStatus = "false", StrMensagem = $"Erro interno no proxy. ex.: {e.Message}" };                
            }

        }

        private static codresMOD EnviaRequisicaoSolicitacao(string urlSolicitacao, string xmlforPostIntoSigpae)
        {

            Console.WriteLine(xmlforPostIntoSigpae);

            using (var httpClient = new HttpClient())
            {
                var requestForSigpae = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(urlSolicitacao),
                    Content = new StringContent(xmlforPostIntoSigpae)
                    {
                        Headers =
                            {
                            ContentType = new MediaTypeHeaderValue("application/xml")
                            }
                    }
                };

                using (var response = httpClient.SendAsync(requestForSigpae).Result)
                {
                    response.EnsureSuccessStatusCode();
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    XmlSerializer serializer = new XmlSerializer(typeof(Dtos.ProxyResult.EnvelopeSolicitacao));

                    using (StringReader reader = new StringReader(responseBody))
                    {
                        var test = (Dtos.ProxyResult.EnvelopeSolicitacao)serializer.Deserialize(reader);
                        return test.Body.SolicitacaoResponse.SolicitacaoResult;
                    }
                }

            }
        }
        private static codresMOD EnviaRequisicaoCancelamento(string urlSolicitacao, string xmlforPostIntoSigpae)
        {
            Console.WriteLine(xmlforPostIntoSigpae);

            using (var httpClient = new HttpClient())
            {
                var requestForSigpae = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(urlSolicitacao),
                    Content = new StringContent(xmlforPostIntoSigpae)
                    {
                        Headers =
                            {
                            ContentType = new MediaTypeHeaderValue("application/xml")
                            }
                    }
                };

                using (var response = httpClient.SendAsync(requestForSigpae).Result)
                {
                    response.EnsureSuccessStatusCode();
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    XmlSerializer serializer = new XmlSerializer(typeof(Dtos.ProxyResult.EnvelopeCancelamento));

                    using (StringReader reader = new StringReader(responseBody))
                    {
                        var test = (Dtos.ProxyResult.EnvelopeCancelamento)serializer.Deserialize(reader);
                        return test.Body.CancelamentoResponse.CancelamentoResult;
                    }
                }

            }
        }

        private static string GeraXmlRequisicaoSolicitacao(EnvelopeSolicitacao request)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EnvelopeSolicitacao));
            var memoryStream = new MemoryStream();
            TextWriter writer = new StreamWriter(memoryStream);
            xmlSerializer.Serialize(writer, request);
            writer.Flush();

            memoryStream.Position = 0;

            var streamReader = new StreamReader(memoryStream);
            var xmlforPostIntoSigpae = streamReader.ReadToEnd();
            return xmlforPostIntoSigpae;
        }
        private static string GeraXmlRequisicaoCancelamento(EnvelopeCancelamento request)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EnvelopeCancelamento));
            var memoryStream = new MemoryStream();
            TextWriter writer = new StreamWriter(memoryStream);
            xmlSerializer.Serialize(writer, request);
            writer.Flush();

            memoryStream.Position = 0;

            var streamReader = new StreamReader(memoryStream);
            var xmlforPostIntoSigpae = streamReader.ReadToEnd();
            return xmlforPostIntoSigpae;
        }
    }

}
