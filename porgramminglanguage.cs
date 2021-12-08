using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;</font>
<font size="3">
 
namespace ExecutingPythonScript
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
 
            int x = 1;
            int y = 2;
            string progToRun = "code.py";
            char[] splitter = {'\r'};
 
            Process proc = new Process();
            proc.StartInfo.FileName = "python.exe";
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
 
            // call hello.py to concatenate passed parameters
            proc.StartInfo.Arguments = string.Concat(progToRun, " ", x.ToString(), " ", y.ToString());
            proc.Start();
 
            StreamReader sReader = proc.StandardOutput;
            string[] output = sReader.ReadToEnd().Split(splitter);
 
            foreach (string s in output)
                Console.WriteLine(s);
 
            proc.WaitForExit();
</font>
<font size="3">            Console.ReadLine();
        }
    }
}
