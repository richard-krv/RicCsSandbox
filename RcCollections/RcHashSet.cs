using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcCollections
{
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

        public T Value => _items.;
    }
}
