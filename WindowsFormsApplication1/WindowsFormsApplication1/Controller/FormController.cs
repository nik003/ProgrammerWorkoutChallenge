using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using ProgrammerWorkoutChallenge.Model;
using Newtonsoft.Json;

namespace ProgrammerWorkoutChallenge.Controller
{
    class FormController
    {
        Form1 form;
        LogHandler lh;
        EventHandler keyLogger;
        public FormController( )
        {
           
            lh = new LogHandler();
            keyLogger = new EventHandler(lh.startLogging);
            form = new Form1(new EventHandler(Form1_Load), new EventHandler(reload_form));
        }
         
           private void Form1_Load(object sender, System.EventArgs e)
             {
            int enters = lh.readEnters();
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\progress.dat");
                string json = sr.ReadToEnd();
                ExceProgress prog = JsonConvert.DeserializeObject<ExceProgress>(json);


                sr.Close();
                form.createForm(prog,keyLogger,enters);

            }
            catch (Exception ev)
            {
                ExceProgress ep = new ExceProgress();
                ep.noExcercises = 3;
                ep.nameExcercises = new List<String> { "Pushups", "Crunches", "Running" };
                ep.progExcercises = new List<int> { 0, 0, 0};
                ep.dividers = new List<double> { 1, 1, 1 };
                form.createForm(ep, keyLogger,enters);
            }
            
        }
        public Form getForm()
        {
            return form;
        }
        public void reload_form(object sender, EventArgs e)
        {
            int enters = lh.readEnters();
            ExceProgress ep = new ExceProgress();
            ep.noExcercises = 3;
            ep.nameExcercises = new List<String> { "Pushups", "Crunches", "Running" };
            ep.progExcercises = new List<int> { 0, 0, 0 };
            ep.dividers = new List<double> { 1, 1, 1 };
            form.updateEnters(ep,keyLogger,enters);
        }
    }
    
}
