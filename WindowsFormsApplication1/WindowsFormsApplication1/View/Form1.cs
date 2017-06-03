using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProgrammerWorkoutChallenge.View;
using ProgrammerWorkoutChallenge.Model;

namespace ProgrammerWorkoutChallenge
{
    public partial class Form1 : Form
    {
        public Form1(EventHandler ev)
        {
            Load += new EventHandler(ev);
            InitializeComponent();

        }
        private void AddControls(int nrOfExercises)
        {
            TextBoxes tbs = new TextBoxes();
            Labels lbs = new Labels();
            List<TextBox> txtBoxes = tbs.createTextBoxes(nrOfExercises,this.Size);
            List<Label> labels = lbs.createLabels(nrOfExercises, this.Size);
            if (txtBoxes != null)
            {
                for (int i = 0; i < txtBoxes.Count; i++)
                {
                    this.Controls.Add(labels[i]);
                    this.Controls.Add(txtBoxes[i]);
                }
            }


            
        }
        public void createForm(ExceProgress ep) {
            this.MinimumSize = new Size(1000,500);
            if (ep != null) { 
                AddControls(ep.noExcercises);
            }

            this.Activate();
        }
        private void changeText(object sender, System.EventArgs e)
        {
            if(sender is Button)
            {
                ((Button)sender).Text = "APA";  
            }
        }

        
    }
}
