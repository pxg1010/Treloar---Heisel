using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace user_editor
{
    
    public partial class Form3 : Form
    {
        //public const string fileName = "G:\\.shortcut-targets-by-id\\0BzQ5p13p5nSCNmNuWHlNT1QxZXc\\IT SUPPORT\\Signature Generator 102022\\picLinks.js";
        //for testing purposes, this is to my C drive ... if you are editing this program change this to your C drive
        //and then back to the g drive for T&H purposes
        public const string fileName = "C:\\Users\\17244\\Desktop\\test.js";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var content = File.ReadAllText(fileName);
           
            if(content.Contains(textBox1.Text.ToUpper()))
            {
                label3.Text = "User Found";
            }
            else
            {
                label3.Text = "User not found!";
            }
        }
    }
}
