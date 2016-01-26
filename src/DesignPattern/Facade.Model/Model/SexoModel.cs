using Facade.Model.Model.Base;
using System;

namespace Facade.Model.Model
{
    // uma classe quando não tem nada na frente não é private é internal.

    public sealed class SexoModel : BaseModel
    {
        public String Descricao { get; set; }
    }
}

