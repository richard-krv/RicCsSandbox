namespace RcCollections;

internal class RcHashSet<T>
{
    /// <summary>
    /// Only stores values
    /// Not sorted
    /// Dynamic size limited by stack
    /// Type specific <T>
    /// </summary>
    private readonly HashSet<T> _items;

    public RcHashSet()
    {
        _items = new HashSet<T>();
    }

    //public T Value => _items.;
}
