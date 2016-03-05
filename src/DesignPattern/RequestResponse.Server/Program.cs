using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using RequestResponse.Service.Contract;
using RequestResponse.Service.Implementation;

namespace RequestResponse.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ClienteService), new Uri("http://localhost:9890/Cliente")))
            {

                host.AddServiceEndpoint(typeof (IClienteService), new WSHttpBinding(), "");

                
                    host.Description.Behaviors.Add(new ServiceMetadataBehavior() {HttpGetEnabled = true});
                    host.Open();
                    Console.WriteLine("Serviço iniciado com sucesso...");
                    Console.ReadLine();
                


            }
            Console.ReadKey();
        }
    }
}
