using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_editor
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public const string fileName = "C:\\Users\\17244\\Desktop\\test.js";

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(fileName);
            int empCounter = 1;

           

            for(int i = lines.Length-1; i >= 0; i--)
            {
                
                if(lines[i].EndsWith(":") || lines[i].Contains("case"))
                {
                    if (lines[i].Contains("default"))
                    {
                        Console.WriteLine("Found default");

                    }
                    else
                    {
                        lines[i] = lines[i].Replace("case", "");
                        lines[i] = lines[i].Replace("\"", "");
                        lines[i] = lines[i].Replace(":", "");
                        lines[i] = lines[i].Trim();
                        richTextBox2.Text += empCounter + ". " + lines[i] + "\n";
                        empCounter++;
                    }
                }
            }
            
        }

    }
}
