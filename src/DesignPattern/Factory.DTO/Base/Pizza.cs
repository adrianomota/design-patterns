using System.Diagnostics;

namespace Factory.DataTransferObject.Base
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Debug.WriteLine("preparar...");
        }

        public void Bake()
        {
            Debug.WriteLine("bake...");
        }

        public void Cut()
        {
            Debug.WriteLine("cut...");
        }

        public void Box()
        {
            Debug.WriteLine("box...");
        }
    }
}