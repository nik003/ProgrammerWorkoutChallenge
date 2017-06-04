using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace ProgrammerWorkoutChallenge.Controller
{
    class LogHandler
    {

        public void startLogging(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                    if (Process.GetProcessesByName("WindowsBackgroundService").Length == 0)
                {
                    Process.Start(Directory.GetCurrentDirectory() + "/WindowsBackgroundService.exe");
                
                     ((Button)sender).Text = "Stop Debugging";
                

                }
                else
                {
                    Process[] processes = Process.GetProcessesByName("WindowsBackgroundService");
                    processes[0].Kill();
                    ((Button)sender).Text = "Stop Debugging";
                    
                }

            }
        }
        public int readEnters()
        {
            int enters;
            try
            {
               
                StreamReader sr = new StreamReader(Application.StartupPath + @"\log.txt");
                enters = Int32.Parse(sr.ReadLine());
                sr.Close();
                return enters;
            }catch(Exception e)
            {
                return 0;
            }
        }
    }
}
