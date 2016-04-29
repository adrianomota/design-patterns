using System;

namespace IoC.Presentation.ViewModel
{
    public sealed class AmigoViewModel
    {
        public AmigoViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }

    }
}