using System;
using System.Collections.Generic;

namespace LazyLoadingPattern
{
    public sealed class AmigoDTO
    {
        public AmigoDTO()
        {
            ID = Guid.NewGuid();
        }

        private SexoDTO _sexo;
        private EstadoCivilDTO _estadoCivil;

        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Guid SexoId { get; set; }
        public Guid EstadoCivilId { get; set; }

        public EstadoCivilDTO EstadoCivil
        {
            get
            {
                if (_estadoCivil == null)
                    _estadoCivil = new EstadoCivilDTO();

                _estadoCivil.Descricao = "Casado";

                return _estadoCivil;
            }
        }

        public SexoDTO Sexo
        {
            get
            {
                if (_sexo == null)
                    _sexo = new SexoDTO();

                _sexo.Descricao = "Feminino";
                return _sexo;
            }
        }

        public IEnumerable<AmigoDTO> ListarAmigoEagerLoading()
        {
            var amigos = new List<AmigoDTO>();

            for (var i = 0; i < 10; i++)
            {
                var amigo = new AmigoDTO()
                {
                    Nome = "Amigo " + i,
                    Email = "email@email.com.br",
                };

                //var sexo = new SexoDTO()
                //{
                //    Descricao = "Mascuino"
                //};
                //amigo.SexoId = sexo.ID;
                //amigo.Sexo = sexo;

                //var estadoCivil = new EstadoCivilDTO()
                //{
                //    Descricao = "Casado"
                //};

                //amigo.EstadoCivilId = estadoCivil.ID;
                //amigo.EstadoCivil = estadoCivil;

                amigos.Add(amigo);
            }

            return amigos;
        }

        public IEnumerable<AmigoDTO> ListarAmigoLazyLoading()
        {
            var amigos = new List<AmigoDTO>();

            for (var i = 0; i < 10; i++)
            {
                var amigo = new AmigoDTO()
                {
                    Nome = "Amigo " + i,
                    Email = "email@email.com.br",
                };

                //var sexo = new SexoDTO()
                //{
                //    Descricao = "Mascuino"
                //};
                //amigo.SexoId = sexo.ID;
                //amigo.Sexo = sexo;

                //var estadoCivil = new EstadoCivilDTO()
                //{
                //    Descricao = "Casado"
                //};

                //amigo.EstadoCivilId = estadoCivil.ID;
                //amigo.EstadoCivil = estadoCivil;

                amigos.Add(amigo);
            }

            return amigos;
        }
    }
}