using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PokyExecutorCore.Core.Executors.Internals
{
    class CmdOperationExecutor : IOperationExecutor<int>
    {
        private readonly string _executionString;

        public CmdOperationExecutor(string commandString)
        {
            _executionString = commandString;
        }

        public int Run()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C" + " " + _executionString;
            Process process = Process.Start(startInfo);
            process.WaitForExit();
            return process.ExitCode; 
        }
    }
}
