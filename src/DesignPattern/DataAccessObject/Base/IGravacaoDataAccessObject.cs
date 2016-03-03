namespace DataAccessObject.Base
{
    public interface IGravacaoDataAccessObject<T>
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(T obj);
    }
}