namespace TemplateMethod.Business
{
    public abstract class BaseBusiness<TModel>
    {
        protected abstract bool ValidarCamposObrigatorios(TModel obj);
        protected abstract void Cadastrar(TModel obj);

        public void Execucao(TModel registro_)
        {
            if (ValidarCamposObrigatorios(registro_))
                Cadastrar(registro_);
        }
    }
}