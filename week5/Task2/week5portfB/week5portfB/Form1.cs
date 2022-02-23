using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5portfB
{
    public partial class Form1 : Form
    {
        static Graph<string> myGraph = new Graph<string>();
        static List<string> myList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //outputLabel.Text = Convert.ToString(myGraph.DisplayNum());
            //outputLabel2.Text = Convert.ToString(myGraph.NumEdgesGraph());
            myGraph.AddNode(AirportInput.Text);
            
            outputLabel2.Text = string.Join(" ", myGraph);
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            myGraph.DepthFirstTraverse(AirportInput.Text, ref myList);
            outputLabel.Text = string.Join("-", myList);

        }

        private void LinkButton_Click(object sender, EventArgs e)
        {
            myGraph.AddEdge(firstLink.Text, secondLink.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            myGraph.RemoveEdge(firstLink.Text, secondLink.Text);
            outputLabel.Text = string.Join("-", myList);
        }
    }
}
