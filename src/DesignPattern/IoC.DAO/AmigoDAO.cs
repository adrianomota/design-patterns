using FizzWare.NBuilder;
using IoC.DAO.Base;
using IoC.DataTransferObject;
using System.Collections.Generic;
using System.Diagnostics;

namespace IoC.DAO
{
    public sealed class AmigoDAO : IBaseDAO<AmigoDTO>
    {
        public IEnumerable<AmigoDTO> Listar()
        {
            var amigos = Builder<AmigoDTO>.CreateListOfSize(50)
                                          .Build();

            return amigos;
        }

        public void Cadastrar(AmigoDTO registro_)
        {
            Debug.WriteLine("Cadastrando...");
        }
    }
}