using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4BLabBooker
{
    public partial class Form1 : Form
    {
        const int size = 6;
        Request[] requests = new Request[size];
        int count = 0;
        int IDcount = 1;

        intervalScheduling inter = new intervalScheduling();

        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
            
        {
            IDcount++;
            //int Id = (int)Convert.ToInt32(IDBox.Text);
            IDlabel.Text = Convert.ToString(IDcount);
            float Start = (float)Convert.ToDouble(StartBox.Text);
            float End = (float)Convert.ToDouble(EndBox.Text);

            Request data = new Request();
            data.ID = IDcount -1;
            data.Start = Start;
            data.End = End;
            requests[count++] = data;
            

        }

        private void maxEventButton_Click(object sender, EventArgs e)
        {
            
            // nodeLabel.Text = Convert.ToString(myGraph.DisplayNum());
            
            outputLabel.Text = Convert.ToString(intervalScheduling.Maxevent(requests)) ;
        }
    }
}
