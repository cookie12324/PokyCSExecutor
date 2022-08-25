using CSJobExecutor.Core.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSJobExecutor.Core.Readers.Operations
{
    class CmdOperationStringReader : IOperationReader
    {
        private readonly string _commandString;

        public CmdOperationStringReader(string command)
        {
            _commandString = command;
        }

        public IOperation read()
        {
            string executeKeyword = "execute";
            int index = executeKeyword.Length + 1;
            string targetCommandString = _commandString.Substring(index);
            return new CmdOperation(targetCommandString);
        }
    }
}
