using PokyExecutorCore.Core.Readers.Operations.Pool;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace PokyExecutorCore.Core.Readers.Operations.Pool
{
    class OperationsReadersObjectPool : IObjectPool<OperationType, IOperationReader>
    {
        private IDictionary<OperationType, IOperationReader> _operations;

        public OperationsReadersObjectPool()
        {
            _operations = new Dictionary<OperationType, IOperationReader>();
        }

        public bool ContainsKey(OperationType key)
        {
            return _operations.ContainsKey(key);
        }

        public IEnumerable<IOperationReader> GetAllObjects()
        {
            return _operations.Values;
        }

        public IOperationReader GetObject(OperationType key)
        {
            return _operations[key];
        }

        public void StoreObject(OperationType key, IOperationReader value)
        {
            _operations.Add(key, value);
        }
    }
}
