using System;
using System.Collections.Generic;
using RequestResponse.ValueObject;

namespace RequestResponse.DataTransferObject.Delivery
{
    public sealed class ResponseClienteDTO
    {
        public IEnumerable<ClienteDTO> Clientes { get; set; }
        public ClienteDTO Cliente { get; set; }
        public DateTime DataExecucao { get; set; }

        public TimeSpan TempoExecucao { get; set; }
        public string Mensagem { get; set; }
        public TipoResposta TipoMensagem { get; set; }
    }
}