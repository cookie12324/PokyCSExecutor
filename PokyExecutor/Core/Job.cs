using PokyExecutorCore.Core.Operations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokyExecutorCore.Core
{
    class Job : IEnumerable<IOperation>
    {
        public string Name { get; private set; }

        public Job(string Name)
        {
            this.Name = Name;
            this.Commands = new List<IOperation>();
        }

        public List<IOperation> Commands { get; private set; }

        public void AddOperation(IOperation command)
        {
            this.Commands.Add(command);
        }

        public IEnumerator<IOperation> GetEnumerator()
        {
            return Commands.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Commands.GetEnumerator();
        }

        public bool HasCommands()
        {
            return Commands.Any();
        }
    }
}
