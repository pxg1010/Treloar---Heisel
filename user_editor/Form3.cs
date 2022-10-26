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
