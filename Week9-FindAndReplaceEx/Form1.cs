using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_FindAndReplaceEx
{
    public partial class Form1 : Form
    {
        private const string STORY_TEXT = "Hamilton, from the point at which it was first colonized" + "settlers, has benefited from its geographical proximity to major land and water "+"transportation routes along the Niagara Peninsula and Lake Ontario. "+"Its strategic importance has created, by Canadian standards, a rich military "+"history which the city preserves.  Tension between maximizing economic growth "+"and minimizing environmental damage was evident, even from the city's early "+"development. The area between Burlington Bay (also known as Hamilton Harbour) "+"and theNiagara Escarpment has been greatly altered for residential, industrial "+"and recreational purposes. Cootes Paradise in Dundas also known as the Dundas Marsh "+", was a very rich wetland with plenty of fish, birds and other game. Cootes Paradise "+"was named after Captain Thomas Coote\r\n\r\n"+"https://en.wikipedia.org/wiki/History_of_Hamilton,_Ontario";
        public int StoryPosition { get; set; } = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            storyTB.Text = STORY_TEXT;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            FindFrom(findTB.Text, 0);
        }
        private void findNextBtn_Click(object sender, EventArgs e)
        {
            FindFrom(findTB.Text, StoryPosition);
        }
        private bool FindFrom(string findString, int start)
        {
            int index = storyTB.Text.IndexOf(findString, start);
            if (index != -1)
            {
                storyTB.Select(index, findString.Length);
                StoryPosition = index + findString.Length;
                return true;
            }
            else
                StoryPosition = 0;
            return false;
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            if (FindFrom(findTB.Text, StoryPosition))
            {
                string first = storyTB.Text.Substring(0, StoryPosition);
                string second = storyTB.Text.Substring(StoryPosition, storyTB.Text.Length - StoryPosition);
                first = first.Replace(findTB.Text, replaceTB.Text);

                storyTB.Text = first + second;
                storyTB.Select(StoryPosition - findTB.Text.Length, replaceTB.Text.Length);
            }
        }

        private void replaceAllBtn_Click(object sender, EventArgs e)
        {
            string text = storyTB.Text;
            text = text.Replace(findTB.Text, replaceTB.Text);
            storyTB.Text = text;
        }
    }
}
