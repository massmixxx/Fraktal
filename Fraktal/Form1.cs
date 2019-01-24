using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraktal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            System.GC.Collect();
            FractalGenerator fractalGenerator = new FractalGenerator(rolesPanel,Convert.ToInt32(iterationsInput.Value) ,Convert.ToInt32(angleInput.Value), axoimInput.Text);
            fractalGenerator.Start();
            
        }

        ////////////////////////////////////////////////////////
        private void autoFill(String param)
        {
            switch (param)
            {
                case "sierpinski_triangles":

                    axoimInput.Text = "F-G-G";
                    iterationsInput.Value =6;
                    angleInput.Value = 120;
                    roleInput_1.Text = "F=F-G+F+G-F";
                    roleInput_2.Text = "G=GG";
                    roleInput_3.Text = null;
                    roleInput_4.Text = null;
                    roleInput_5.Text = null;
                    break;

                case "sierpinski_curves":

                    axoimInput.Text = "A";
                    iterationsInput.Value = 7;
                    angleInput.Value = 60;
                    roleInput_1.Text = "A=B-A-B";
                    roleInput_2.Text = "B=A+B+A";
                    roleInput_3.Text = null;
                    roleInput_4.Text = null;
                    roleInput_5.Text = null;
                    break;

                case "sierpinski_carpet":

                    axoimInput.Text = "F";
                    iterationsInput.Value = 4;
                    angleInput.Value = 90;
                    roleInput_1.Text = "F=F+F-F-F-G+F+F+F-F";
                    roleInput_2.Text = "G=GGG";
                    roleInput_3.Text = null;
                    roleInput_4.Text = null;
                    roleInput_5.Text = null;
                    break;

                case "koch":

                    axoimInput.Text = "F++F++F";
                    iterationsInput.Value =4;
                    angleInput.Value = 60;
                    roleInput_1.Text = "F=F-F++F-F";
                    roleInput_2.Text = "X=FF";
                    roleInput_3.Text = null;
                    roleInput_4.Text = null;
                    roleInput_5.Text = null;
                    break;

                case "dragon":

                    axoimInput.Text = "FX";
                    iterationsInput.Value = 10;
                    angleInput.Value = 90;
                    roleInput_1.Text = "X=X+YF";
                    roleInput_2.Text = "Y=FX-Y";
                    roleInput_3.Text = null;
                    roleInput_4.Text = null;
                    roleInput_5.Text = null;
                    break;
            }

            axoimInput.Update();
            iterationsInput.Update();
            angleInput.Update();
            roleInput_1.Update();
            roleInput_2.Update();
            roleInput_3.Update();
            roleInput_4.Update();
            roleInput_5.Update();


        }

        private void sierpinski_item_triangles_Click(object sender, EventArgs e)
        {
            autoFill("sierpinski_triangles");
        }

        private void sierpinski_item_curves_Click(object sender, EventArgs e)
        {
            autoFill("sierpinski_curves");
        }

        private void sierpinskie_item_carpet_Click(object sender, EventArgs e)
        {
            autoFill("sierpinski_carpet");
        }

        private void item_koch_Click(object sender, EventArgs e)
        {
            autoFill("koch");
        }

        private void item_dragon_Click(object sender, EventArgs e)
        {
            autoFill("dragon");
        }
    }

}
