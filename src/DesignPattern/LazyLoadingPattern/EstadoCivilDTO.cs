using System;

namespace LazyLoadingPattern
{
    public sealed class EstadoCivilDTO
    {
        public EstadoCivilDTO()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        public string Descricao { get; set; }
    }
}