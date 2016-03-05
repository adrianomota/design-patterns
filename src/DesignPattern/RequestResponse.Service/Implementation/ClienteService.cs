using System;
using System.Collections.Generic;
using System.Diagnostics;
using RequestResponse.DataTransferObject;
using RequestResponse.DataTransferObject.Delivery;
using RequestResponse.Service.Contract;
using RequestResponse.ValueObject;

namespace RequestResponse.Service.Implementation
{
    public sealed class ClienteService:IClienteService
    {
        private readonly ResponseClienteDTO _response = new ResponseClienteDTO();
        private readonly Stopwatch _cronometro = new Stopwatch();

        public ResponseClienteDTO Listar(RequestClienteDTO request_)
        {
            Debug.WriteLine("Listando......");

            _cronometro.Start();

            _response.DataExecucao = DateTime.Now;
            _response.Mensagem = "Listando clientes...";
            _response.TipoMensagem  = TipoResposta.Sucesso;
            _response.Clientes = new List<ClienteDTO>()
            {
                new ClienteDTO()
                {
                    Nome = "Adriano Mota",
                    Telefone = "0122223333",
                    Email = "adrianowsh@hotmail.com"
                }
            };

            _cronometro.Stop();


            _response.TempoExecucao = _cronometro.Elapsed;

            return _response;
        }

        public ResponseClienteDTO Cadastrar(RequestClienteDTO request_)
        {
            Debug.WriteLine("Cadastrando.....");

            _cronometro.Start();

            _response.DataExecucao = DateTime.Now;
            _response.Mensagem = "Cliente cdastrado com sucesso";
            _response.TipoMensagem = TipoResposta.Sucesso;

            if (request_.Cliente == null)
            {
                _response.Mensagem = "Informe o cliente";
                _response.TipoMensagem = TipoResposta.Aviso;
            } 

            _cronometro.Stop();


            _response.TempoExecucao = _cronometro.Elapsed;

            return _response;
        }
    }
}