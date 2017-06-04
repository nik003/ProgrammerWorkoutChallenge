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
        EventHandler reloadForm;
        public Form1(EventHandler ev, EventHandler reloadForm)
        {
            this.reloadForm = reloadForm;
            Load += new EventHandler(ev);
            InitializeComponent();

        }
        private void AddControls(ExceProgress ep, EventHandler keyLogger,int enters)
        {
            TextBoxes tbs = new TextBoxes();
            Labels lbs = new Labels();
            Btns btns = new Btns();
            List<TextBox> txtBoxes = tbs.createTextBoxes(ep.noExcercises, this.Size);
            List<Label> labels = lbs.createLabels(ep.noExcercises, this.Size);
            List<Label> progLabels = lbs.createProgLabels(ep.noExcercises, this.Size);
            List<Button> buttons = btns.createButtons(this.Size);
            if (txtBoxes != null && labels != null && progLabels != null && buttons != null)
            {
                for (int i = 0; i < txtBoxes.Count; i++)
                {
                    labels[i].Text = ep.nameExcercises[i] + ": "+ ((enters/ep.dividers[i])-ep.progExcercises[i]);
                    labels[i].Name = ep.nameExcercises[i];
                    txtBoxes[i].Name = ep.nameExcercises[i];
                    txtBoxes[i].Text = "Press to update progress";
                    progLabels[i].Text = "Current progress: " + ep.progExcercises[i];
                    progLabels[i].Name = ep.nameExcercises[i]+"prog";
                    this.Controls.Add(progLabels[i]);
                    this.Controls.Add(labels[i]);
                    this.Controls.Add(txtBoxes[i]);
                }
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i].Name == "LogCtrl")
                    {
                        buttons[i].Click += keyLogger;
                       
                    }
                    if (buttons[i].Name == "Update")
                    {
                        buttons[i].Click += reloadForm;

                    }
                    this.Controls.Add(buttons[i]);
                }

            }
        }
        public void updateEnters(ExceProgress ep, EventHandler keyLogger, int enters)
        {
            this.Controls.Clear();
            AddControls(ep, keyLogger, enters);
            
        }
        public void createForm(ExceProgress ep,EventHandler keyLogger,int enters) {
            this.MinimumSize = new Size(1000,500);
            if (ep != null) { 
                AddControls(ep,keyLogger,enters);
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
