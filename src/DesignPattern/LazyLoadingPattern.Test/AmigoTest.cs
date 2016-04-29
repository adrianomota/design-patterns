using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LazyLoadingPattern.Test
{
    [TestClass]
    public class AmigoTest
    {
        [TestMethod]
        public void TestarAmigoLazyLoading()
        {
            var amigo = new AmigoDTO();

            var amigos = amigo.ListarAmigoLazyLoading();

            var primeiroAmigo = amigos.First();

            var estadoCivilDoPrimeiroAmigo = primeiroAmigo.EstadoCivil;
        }

        [TestMethod]
        public void TestarAmigoEagerLoading()
        {
            var amigo = new AmigoDTO();

            var amigos = amigo.ListarAmigoEagerLoading();
        }

        [TestMethod]
        public void Testar_variavel_lazy()
        {
            var amigo = new Lazy<AmigoDTO>();

            var status1 = amigo.IsValueCreated;

            var amigos = amigo.Value.ListarAmigoLazyLoading();

            var status2 = amigo.IsValueCreated;

            var primeiroAmigo = amigos.First();

            var estadoCivilDoPrimeiroAmigo = primeiroAmigo.EstadoCivil;
        }
    }
}