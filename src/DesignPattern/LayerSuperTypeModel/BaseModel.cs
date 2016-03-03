using System;

namespace LayerSuperTypeModel
{
    public abstract class BaseModel
    {
        protected BaseModel()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }
        public Int32 Codigo { get; set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime ModifiedOn { get; private set; }

        public bool Status { get; private set; }

        public void AlterarStatus(bool status)
        {
            Status = status;
        }

        public virtual void ValidarCamposObrigatorios()
        {
            if(!Status)   
                throw new ApplicationException("Status não pode ser negativo!");
        }
    }
}