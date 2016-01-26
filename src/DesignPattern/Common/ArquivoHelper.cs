using System.IO;

namespace Common
{
    public sealed class ArquivoHelper
    {
        public static void GravarLog(string mensagem_)
        {
            var caminho = @"c:\LOG";

            Directory.CreateDirectory(caminho);

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.WriteLine(mensagem_);
            }
        }
    }
}