using System;
using System.Collections.Generic;
using System.Diagnostics;
using IoC.Business.Base;
using IoC.DataTransferObject;
using IoC.DAO;

namespace IoC.Business
{
    public sealed class AmigoBusiness : IBaseBusiness<AmigoDTO>
    {
        private readonly AmigoDAO _amigoDAO;

        public AmigoBusiness(AmigoDAO amigoDao)
        {
            _amigoDAO = amigoDao;
        }

        public void Cadastrar(AmigoDTO registro_)
        {
            _amigoDAO.Cadastrar(registro_);
        }

        public IEnumerable<AmigoDTO> Listar()
        {
            return _amigoDAO.Listar();
        }
    }
}