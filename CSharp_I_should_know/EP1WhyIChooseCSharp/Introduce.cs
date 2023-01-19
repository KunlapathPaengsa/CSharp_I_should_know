using System.Diagnostics;

namespace CSharp_I_should_know.EP1WhyIChooseCSharp
{
    public interface IEP1
    {
        void GoToEP1();
    }

    public class Introduce : IEP1
    {
        public void GoToEP1()
        {
            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("start chrome https://medium.com/@kunlapath.paengsa/c-i-should-know-ep-1-why-i-choose-c-c82def0aebea");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.StandardOutput.ReadToEnd();
        }
    }
}