using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;




namespace WindowsFormsApp28
{
    public partial class Form1 : Form, IForm1
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region SettingsForm
        private bool isClickMouse = false;
        private Point currentPosition = new Point(0, 0);



        // Button close application
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isClickMouse = false;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isClickMouse = true;
            currentPosition = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, EventArgs e)
        {
            if (!isClickMouse) { return; }
            Point buf = new Point(this.Location.X, this.Location.Y);

            buf.X += e.X - currentPosition.X;
            buf.Y += e.Y - currentPosition.Y;

            this.Location = buf;
        }
        #endregion

        private void textResult_Click(object sender, EventArgs e)
        {
        }
        private bool isPoint = false;
        private bool isNum2 = false;

        private string Num1 = null;
        private string Num2 = null;

        private string currentOperation = "";
        private object num2;
        private string num1;

        private void SetNum(string txt)
        {
            if (isNum2)
            {
                num2 += txt;
                textResult_Click.Text = num2;
            }
            else
            {
                num1 += txt;
                textResult.Text = num1;
            }
        }

        private void buttonNumberClick(object obj, EventArgs e, string txt)
        {
            var txt = ((Button)obj).Text;
            {
                if (isPoint && txt == ",") { return; }
                if (txt == ", ") { isPoint = true; }
            }
        }
    }
}

            











