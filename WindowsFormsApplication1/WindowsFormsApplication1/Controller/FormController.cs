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
        public FormController()
        {
            form = new Form1(new EventHandler(Form1_Load));
        }
         
           private void Form1_Load(object sender, System.EventArgs e)
             {
            
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\progress.dat");
                string json = sr.ReadToEnd();
                ExceProgress prog = JsonConvert.DeserializeObject<ExceProgress>(json);


                sr.Close();
                form.createForm(prog);

            }
            catch (Exception ev)
            {
                ExceProgress ep = new ExceProgress();
                ep.noExcercises = 3;
                ep.nameExcercises = new List<String> { "Pushups", "Crunches", "Running" };
                ep.progExcercises = new List<int> { 0, 0, 0 };
                form.createForm(ep);
            }
            
        }
        public Form getForm()
        {
            return form;
        }
    }
    
}
