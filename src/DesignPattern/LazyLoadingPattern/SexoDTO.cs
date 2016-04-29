using System;

namespace LazyLoadingPattern
{
    public sealed class SexoDTO
    {
        public SexoDTO()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        public string Descricao { get; set; }
    }
} 