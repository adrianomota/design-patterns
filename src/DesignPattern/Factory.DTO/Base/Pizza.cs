using System.Diagnostics;

namespace Factory.DataTransferObject.Base
{
    public abstract class Pizza
    {
        public abstract void Prepare();
    
        public void Bake()
        {
            Debug.WriteLine("Assar por 25 minutos...");
        }

        public void Cut()
        {
            Debug.WriteLine("Cortar a pizza em fatias diagonais...");
        }

        public void Box()
        {
            Debug.WriteLine("Colocar a pizza na caixa oficial da pizzaria");
        }
    }
}