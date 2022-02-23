using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_actual_one
{
    
    public partial class Form1 : Form
    {
        static LinkListGen<wordClass> wordList = new LinkListGen<wordClass>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordClass newWord = new wordClass(wordTextBox.Text,ISBMtextBox.Text);
            // if this word is not in the list alread then add it
            wordClass FoundWord = wordList.Find(newWord);
 
            if (FoundWord == null)
                wordList.InsertInOrder(newWord);//sort and add string to my link
            //otherwise update the occurrance for that word
            else
                    FoundWord.Occurrences++;



            outputLable.Text = wordList.DisplayList();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            wordClass newWord = new wordClass(wordTextBox.Text, ISBMtextBox.Text);
            // if this word is not in the list alread then add it
            wordClass FoundWord = wordList.Find(newWord);
            //sorting
            
            if (FoundWord ==null)
            {
                wordList.RemoveItem(newWord);
            }
            else
                while(FoundWord.Occurrences != 0)
                {
                    FoundWord.Occurrences--;
                }     
            outputLable.Text = wordList.DisplayList();
        }

        //when add is pressed we display sorted list
        //in order to create sorted list we nedd a function 
        //what reads inputs from a list
        //finds lowes adds to another lists and removes from actual list

    }
}
