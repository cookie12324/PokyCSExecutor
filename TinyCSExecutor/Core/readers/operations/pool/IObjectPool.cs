using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSJobExecutor.Core.Readers.Operations.Pool
{
    interface IObjectPool<K, V>
    {
        V GetObject(K key);
        void StoreObject(K key, V value);

        bool ContainsKey(K key);

        IEnumerable<V> GetAllObjects();

    }
}
