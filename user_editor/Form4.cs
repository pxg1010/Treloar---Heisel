﻿using System;
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
            populateList();
            
        }
        //filename for T&H computers
        //public const string fileName = "G:\\.shortcut-targets-by-id\\0BzQ5p13p5nSCNmNuWHlNT1QxZXc\\IT SUPPORT\\Signature Generator 102022\\picLinks.js";
        public const string fileName = "C:\\Users\\17244\\Desktop\\test.js";

        private void populateList()
        {
            //lines array to store the file info since we do not want to change the information directly 
            string[] lines = File.ReadAllLines(fileName);

            //count the employees found 
            int empCounter = 1;

           
            //since the list is in ascending order, output in descending
            for(int i = lines.Length-1; i >= 0; i--)
            {
                //if a line ends with or contains case, these are our employee names
                if(lines[i].EndsWith(":") || lines[i].Contains("case"))
                {
                    if (lines[i].Contains("default"))   //if contains default we dont want to count or display 
                    {
                        Console.WriteLine("Found default");
                        //do nothing in the list generator

                    }
                    else
                    {
                        lines[i] = lines[i].Replace("case", "");
                        lines[i] = lines[i].Replace("\"", "");
                        lines[i] = lines[i].Replace(":", "");
                        lines[i] = lines[i].Trim();
                        if (empCounter <= 20)
                        {
                            
                            checkedListBox1.Items.Add(lines[i]);
                        }
                        else if (empCounter <= 40)
                        {
                            
                            checkedListBox2.Items.Add(lines[i]);
                        }
                        else if(empCounter <= 60)
                        {
                            checkedListBox3.Items.Add(lines[i]);
                        }
                        else
                        {
                            checkedListBox4.Items.Add(lines[i]);
                        }
                        empCounter++;

                       
                    }
                }
            }
            

            //display number of employees in the label 
            label2.Text = (empCounter-1).ToString();
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
