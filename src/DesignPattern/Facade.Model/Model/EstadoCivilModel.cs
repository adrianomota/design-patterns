using Facade.Model.Model.Base;
using System;

namespace Facade.Model.Model
{
    // uma classe quando não tem nada na frente não é private é internal.
    // classes são representações ou unidades
    public sealed class EstadoCivilModel : BaseModel
    {
        // propriedades são ESTADOS
        // são características da nossa classe
        public String Nome { get; set; }
    }
}

//}