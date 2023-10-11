namespace RcNullGuard;

internal class ItemService
{
    private readonly ItemRepository _itemRepository;
    public ItemService(ItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
}

internal class ItemRepository
{

}