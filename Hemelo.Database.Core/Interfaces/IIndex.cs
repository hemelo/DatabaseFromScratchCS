using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemelo.Database.Core.Interfaces
{
    public interface IIndex<K, V>
    {
        void Insert(K key, V value);

        Tuple<K, V>? Find(K key);

        IEnumerable<Tuple<K, V>> FindLargerThan(K key);

        IEnumerable<Tuple<K, V>> FindLargerThanOrEqual(K key);

        IEnumerable<Tuple<K, V>> FindSmallerThan(K key);

        IEnumerable<Tuple<K, V>> FindSmallerThanOrEqual(K key);

        void Delete(K key);

        bool Delete(K key, V value, IComparer<V> valueComparer);
    }
}
