using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5portA
{
    public partial class Form1 : Form
    {
        static Graph<char> myGraph = new Graph<char>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            myGraph.AddNode(Convert.ToChar(addBox.Text)); //♥♦♣♠.
            nodeLabel.Text = Convert.ToString(myGraph.DisplayNum());
            edgeLabel.Text = Convert.ToString(myGraph.NumEdgesGraph());

        }



        private void joinButton_Click(object sender, EventArgs e)
        {
            myGraph.AddEdge(Convert.ToChar(joinBox.Text), Convert.ToChar(joinBox2.Text));
            nodeLabel.Text = Convert.ToString(myGraph.DisplayNum());
            edgeLabel.Text = Convert.ToString(myGraph.NumEdgesGraph());
        }
       
        
    }
}
