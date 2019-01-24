using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraktal
{
    class FractalGenerator
    {
        private int _maxX = 0;
        private int _minX = 0;
        private int _maxY = 0;
        private int _minY = 0;
        private int iterations = 1;
        private int angle = 0;
        private float pathLength = 10;
        private String axoim = null;
        private String finalAxoim = null;
        private Dictionary<Char, String> rules = new Dictionary<char, string>();
        private Stack<State> states = new Stack<State>();
        private State state;

        public FractalGenerator(System.Windows.Forms.Panel panel, int iterations, int agle, String axoim) {
            this.iterations = iterations;
            this.angle = agle;
            this.axoim = axoim;

            foreach (Control textBox in panel.Controls)
            {
                if (textBox is TextBox && !String.IsNullOrEmpty(textBox.Text.Trim()))
                {
                    String input = textBox.Text;
                    rules.Add(input[0], input.Substring(input.IndexOf('=') + 1, input.Length - 2));
                }
            }

        }


        public void Start()
        {
            finalAxoim = Replace(axoim);
            List<List<Point>> toDrawPoints = Generate(finalAxoim);
            Form3 resultWindow = new Form3();
            Image image = Draw(toDrawPoints);
            resultWindow.pictureBox1.Image = image;
            resultWindow.Show();
        }

        public Image Draw(List<List<Point>> toDrawPoints)
        {
            int rangeX = clamp(_minX, _maxX);
            int rangeY = clamp(_minY, _maxY);

            Image image = new Bitmap(rangeX, rangeY);
            Graphics imageObject = Graphics.FromImage(image);
            imageObject.Clear(Color.White);
            imageObject.TranslateTransform(Convert.ToInt32(Math.Abs(_minX)),Convert.ToInt32(Math.Abs(_minY)));
            Pen pen = new Pen(Color.Black, 1);


            foreach (List<Point> list in toDrawPoints)
            {
                imageObject.DrawLines(pen, list.ToArray());
            }

          
           // image.Save("Path\\obiekt1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            return image;
        }

        public List<List<Point>> Generate(String input)
        {
            List<List<Point>> result = new List<List<Point>>();
            result.Add(new List<Point>());
            result.Last().Add(new Point(0, 0));

            state = new State()
            {
                x = 0,
                y = 0,
                dir = 0,
                size = pathLength,
                angle = angle
            };

            for(int i=0; i<input.Length; i++)
            {
                char c = input[i];

                switch (c)
                {
                    default:


                        if (Char.IsLetter(c))
                        {

                            int newX = Convert.ToInt32(Math.Round(state.x + state.size * Math.Cos(state.dir * Math.PI / 180)));
                            int newY = Convert.ToInt32(Math.Round(state.y + state.size * Math.Sin(state.dir * Math.PI / 180)));


                            result.Last().Add(new Point(newX, newY));

                            if (newX > _maxX)
                                _maxX = newX;
                            if (newX < _minX)
                                _minX = newX;
                            if (newY > _maxY)
                                _maxY = newY;
                            if (newY < _minY)
                                _minY = newY;

                            state.x = newX;
                            state.y = newY;
                        }
                        break;
                    case '+':
                        state.dir += state.angle;
                        break;
                    case '-':
                        state.dir -= state.angle;
                        break;
                    case '[':
                        states.Push(state.Clone());
                        if (input[i+1] != '[')
                        {
                            result.Add(new List<Point>());
                            result.Last().Add(new Point(state.x, state.y));
                        }
                        break;
                    case ']':
                        state = states.Pop();
                        result.Add(new List<Point>());
                        result.Last().Add(new Point(state.x, state.y));
                        break;
                    case '!':
                        state.angle *= -1;
                        break;
                    case '|':
                        state.dir += 180;
                        break;
                }
            }
            return result;
        }

        public string Replace(string s)
        {
            String input = s;
            StringBuilder sb;
            
            for (int i = 0; i < iterations; i++)
            {
                sb = new StringBuilder();

                foreach (char c in input)
                {
                    if (rules.ContainsKey(c))
                    {
                        sb.Append(rules[c]);
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }

                input = sb.ToString();
            }

            return input;
        }

        private int clamp(int param1, int param2){
            int result = 0;
            int start;
            int stop;
            start = (param1 <= param2) ? param1 : param2;
            stop = (param1 >= param2) ? param1 : param2;

            if (start >= 0 && stop > 0)
                result = stop - start;
            if (start < 0 && stop >= 0)
                result = Convert.ToInt32(Math.Abs(start) + stop); ;
            if (start <= 0 && stop <= 0)
                result =Convert.ToInt32( Math.Abs(start - stop));
            return result;
        }
    }
}
