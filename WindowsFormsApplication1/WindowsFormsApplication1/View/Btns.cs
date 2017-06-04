using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace ProgrammerWorkoutChallenge.View
{
    class Btns
    {
        public List<Button> createButtons(Size formSize)
        {
            List<Button> buttons = new List<Button>();

            Button btn = new Button();
            btn.Size = new Size(formSize.Width, 50);
            btn.Location = new Point(0, formSize.Height / 2);
            btn.Text = "Update progress";
            btn.Name = "Update";
            buttons.Add(btn);

            btn = new Button();
            btn.Size = new Size(formSize.Width/5, 50);
            btn.Location = new Point(formSize.Width/2 - (formSize.Width/10), 0);
            btn.Text = "Start logging";
            btn.Name = "LogCtrl";
            buttons.Add(btn);
            return buttons;

        }
    }
}
