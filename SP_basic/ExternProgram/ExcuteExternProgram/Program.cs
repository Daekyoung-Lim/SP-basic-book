using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ExcuteExternProgram
{
	class ExtProc
	{
		public void workerExternProc()
		{
			ProcessStartInfo psi = new ProcessStartInfo
			{
				FileName = @"./../../../ExternProgram.exe",
				Arguments = "args",
				RedirectStandardOutput = true,
				RedirectStandardInput = true,
				UseShellExecute = false
			};

			Process proc = Process.Start(psi);
			string strRet = proc.StandardOutput.ReadLine();
			Console.WriteLine(strRet);

			while (true)
			{
				String line = Console.ReadLine();
				proc.StandardInput.WriteLine(line);

				string strLine = proc.StandardOutput.ReadLine();
				Console.WriteLine(strLine);
			}
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			ExtProc extProc = new ExtProc();
			
			Thread th = new Thread(extProc.workerExternProc);

			th.Start();
			th.Join();
		}
    }
}
