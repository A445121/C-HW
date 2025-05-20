using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace 實作13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupTrafficLight();
        }
        private void SetupTrafficLight()
        {
            label1.BackColor = Color.Red;
            label1.BorderStyle = BorderStyle.FixedSingle; 
            label1.Cursor = Cursors.Hand;           
            label1.MouseDown += new MouseEventHandler(label1_MouseDown);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.BackColor = Color.Yellow;
            }
            else if (e.Button == MouseButtons.Right)
            {
                label1.BackColor = Color.Green;
            }
        }
    }
}
