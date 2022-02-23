using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameStack
{
    public partial class Form1 : Form
    {
        //private List<Name> nameList;
        private nameStack stackName = new nameStack();//empty stack of jobs
        int Count = 0;
        string[] names = new string[10];
        public Form1()
        {
            InitializeComponent();
            //nameList = new List<Name>(); // creates empty list
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //name constructor
            Name newname = new Name(nameBox.Text);            
            //add into the stack
            stackName.Push(newname);

            if (Count >= 0 && Count <= 10)//updating the count
            {
                Count = Count + 1;
                countBox.Text = "count:" + Count;
                names[Count - 1] = nameBox.Text;
            }

            allNames.Text = string.Join(Environment.NewLine, names) ;
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (Count > 0)//updating the count
            {
                Count = Count - 1;
                countBox.Text = "count:" + Count;
                names[Count] = null;
            }
            stackName.Pop();
            allNames.Text = string.Join(Environment.NewLine, names);
        }
    }
}
