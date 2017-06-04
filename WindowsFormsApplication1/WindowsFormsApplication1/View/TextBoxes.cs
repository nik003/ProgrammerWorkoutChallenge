using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProgrammerWorkoutChallenge.View
{
    class TextBoxes
    {
        private List<TextBox> textBoxes;
        public TextBoxes()
        {
            textBoxes = new List<TextBox>();
        }
        public List<TextBox> createTextBoxes(int excercises,Size formSize)
        {
           
            TextBox tb;
            for (int i = 0; i < excercises; i++)
            {
                tb = new TextBox();
                tb.Size = new Size((formSize.Width / excercises)-10,50);
                tb.Location = new Point((formSize.Width / excercises) * i, (5*formSize.Height) /12 );
                tb.Text = i+"";
                textBoxes.Add(tb);

            }
            return textBoxes;
        }
    }
}
