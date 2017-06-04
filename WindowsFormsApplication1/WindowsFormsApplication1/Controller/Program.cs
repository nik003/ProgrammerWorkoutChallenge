using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgrammerWorkoutChallenge.View;
using ProgrammerWorkoutChallenge.Model;
using ProgrammerWorkoutChallenge.Controller;

namespace ProgrammerWorkoutChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String p =Directory.GetCurrentDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine(p);
            
            FormController fc = new FormController();
            fc.getForm();
            Application.Run(fc.getForm());
        }
    }
}
