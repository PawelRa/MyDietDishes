using MyDietDishes.Entities;

namespace MyDietDishes.Repositores
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
        where T : class, IEntity
    {

    }
}
