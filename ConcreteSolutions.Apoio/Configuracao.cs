using System;
using System.Configuration;

namespace ConcreteSolutions.Apoio
{
    public static class Configuracao
    {
        public static string Obter(string nomeConfiguracao)
        {
            var valor = ConfigurationManager.AppSettings[nomeConfiguracao];

            if (string.IsNullOrEmpty(valor))
            {
                throw new ArgumentNullException(valor, "Configuração não encontrada no arquivo de configuração da aplicação.");
            }

            return valor;
        }
    }
}