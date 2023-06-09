using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid Id);
        IEnumerable<Item> GetItems();
    }
}
