using System.ServiceModel;
using RequestResponse.DataTransferObject.Delivery;

namespace RequestResponse.Service.Contract
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        ResponseClienteDTO Listar(RequestClienteDTO request_);

        [OperationContract]
        ResponseClienteDTO Cadastrar(RequestClienteDTO request_);
    }
}