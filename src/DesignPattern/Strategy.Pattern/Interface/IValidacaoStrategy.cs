using Strategy.Model.Model;

namespace Strategy.Pattern
{
    public interface IValidacaoStrategy
    {
        void ValidarCamposObrigatorios(Cliente cliente);
    }
}