using System.IO;
using Microsoft.Extensions.Configuration;

namespace SME.Terceirizadas.Gateway
{
    public class Configuracao : IConfiguracao
    {
        private IConfigurationRoot _configurationRoot;

        public Configuracao()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<Program>()
                .AddEnvironmentVariables();

            _configurationRoot = builder.Build();
        }

        public string Obter(string chave)
        {
            return _configurationRoot[chave];
        }
    }
}
