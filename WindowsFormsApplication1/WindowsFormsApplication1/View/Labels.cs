using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProgrammerWorkoutChallenge.View
{
    class Labels
    {
        private List<Label> labels;
        public Labels()
        {
            

        }
        public List<Label> createLabels(int excercises, Size formSize)
        {
            labels = new List<Label>();
            Label la;
            for (int i = 0; i < excercises; i++)
            {
                la = new Label();
                la.Size = new Size((formSize.Width / excercises) - 10, 50);
                la.Location = new Point((formSize.Width / excercises) * i, formSize.Height / 6);
                la.Text = i + "";
                labels.Add(la);
                

            }
            return labels;
        }
        public List<Label>  createProgLabels(int excercises, Size formSize)
        {
            labels = new List<Label>();
            Label la;
            for (int i = 0; i < excercises; i++)
            {
                la = new Label();
                la.Size = new Size((formSize.Width / excercises) - 10, 50);
                la.Location = new Point((formSize.Width / excercises) * i, (3 * formSize.Height) / 12);
                la.Text = i + "";
                labels.Add(la);
            }
            return labels;
        }
    }
}
