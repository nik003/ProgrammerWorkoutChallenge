using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.View;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

        }
        private TextBox AddTextboxes(int nrOfExercises) 
        {
            TextBoxes tbs = new TextBoxes();
            List<TextBox> boxes = tbs.createTextBoxes(nrOfExercises);
            for (int i = 0; i < boxes.Count; i++)
            {
                this.Controls.Add(boxes[i]);
            }
            
          

            return tb;
        }
    }
}
