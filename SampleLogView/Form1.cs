using System;
using System.Windows.Forms;

namespace SampleLogView
{
    public partial class Form1 : Form
    {
        private readonly ControlLog controlLog = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelLog.Controls.Add(controlLog);
        }

        public void SetLogText(string text)
        {
            if (controlLog != null)
            {
                controlLog.SetLogText(text);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            if (data.Length > 0)
            {
                SetLogText(data);
            }
        }
    }
}
