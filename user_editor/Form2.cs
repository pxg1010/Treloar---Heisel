using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_editor
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //help menu 
            if(radioButton1.Checked)
            {
                richTextBox1.Text = "This program works by taking a users name and photolink, then storing that in a javascript file switch statement. It converts the name to uppercase and then works by finding a comment //new1 in the js file and then inserting code in a generic format which will load the image into the signature. It is important that the name is spelled the same way that it is on the website and the link is correct for the photos.  \n\nIf the user wants a nickname you can insert it here but they must enter that name on the html generator.";
            }
            else if(radioButton2.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "Double check that their name is spelled the way it is on the website. Or that they are entering it correctly on their end. From a code perspective, make sure that the //new1 comment exists in the javascript file. This should be there by default but if someone edits the code then this comment could be gone. There will not be any syntax errors for the code itself as it is nearly a generic template. \n\nSometimes when entering the photolink, there will be ' that appear at the beginning or the end of the link, make sure these are gone.";
            }
            else if(radioButton3.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "This program was developed in Visual Studio 2022. The files are located in the IT Support Google Drive titled user_editor. You can open the project solution and edit the code in form1 for functionality and form2 to edit the help form. The files for the generator itself are also located in the IT Support folder in the google drive. This application searches for the picLinks.js file in the google drive and makes edits directly to it.";
            }
            else if(radioButton4.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "Yes, this program is 100% expandable and can be used as a master panel to deploy new settings to the html generator. The variables containing the css formatting are sen1, sen2, etc... Create a copy of the picLinks.js and test text insertion on a backup to configure settings. Inserting text can be tricky as identifying the text must include /t and /n characters. \n\nCss formatting can also be tricky in the method we are making this document as it has to be exported to a second file. Perhaps this can be improved. Theoretically, it would be easier to just generate the file in generator.html.";
            }
            else if(radioButton5.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "The photos on the T&H website are stored in hubspot. If a new picture is added use the new link to the image on this website. The storing of these images are in a couple different folders which is why every user needs a case statement in a switch since there is no generic link for the photos. Brute force with switch statements is the easiest way to get the data. This could also probably be improved by using an API to pull user data to the program when they are onboarded to the company and have an image.";           
            }
            else if(radioButton6.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "The middle initial is not used in the search process since every employee does not have their middle initial listed on the website. This is now an optional input box on the html generator and the program will function without the middle initial being included. \n\nSince it is optional, when adding the new user it is easier to not add the initial to avoid the possibility of errors. \n\nProgram locates by name converted to all caps ex. \"John Smith\" becomes \"JOHN SMITH\" in the syntax. ";
            }
            else if(radioButton7.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "This will create a runtime error if the program cannot locate the javascript file and the program will crash. This should not happen as long as the generator folder is not moved from its original location in the Google Drive. \n\nHowever, if we need to move the file folder for some reason, the constant filename variable in the form1.cs file contains the path to the picLinks.js file. This can be changed from *Visual Studio*, editing in notepad or another editor will not change the outcome since the project solution needs to be rebuilt.";
            }
            else if(radioButton8.Checked)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = "This input will allow us to check if the user exists in the javascript database or not. You do not need to enter the name in all caps as it will be transformed automatically in the program. Simply type the name (without middle initial) and then click find employee and the bottom text box will populate with whether the user was found or not. This can be a good way to check for duplicates. If it returns a false and you know the employee exists in the database, then you should check the filepath stored in Form3.cs. \n\nI recommend using this function prior to entering a new user.";
            }
            else if(radioButton9.Checked)
            {
                richTextBox1.Text = "The change log is used to record login information to the application as well as potential errors that may have happened when the user connected to the database. The log is automatically filled and no input is required from the user. Simply clicking the view changes button will open to text file that contains all referenced changes and login information. \n\nIf a user is deleted from the Javascript file, then the link and name will be included in the datalog. This will be useful for any errors that may have potentially occurred.";
            }
            else if(radioButton10.Checked)
            {
                richTextBox1.Text = "Your connection is being shown in order to make sure that you have a valid connection to the javascript file. Since it is located in the google drive folder, we must ensure a valid connection is in place to make sure that changes are saved to the program. It will also be used to record changes in the change log, having the ability to backtrack procedures makes it easier to fix bugs.";
            }
            else if(radioButton11.Checked)
            {
                richTextBox1.Text = "If you are flashing red on your connection it means that you are connected to the local host and not the internet (Check your settings), or there was a failed connection to the google drive. This could technically stem from either an incorrect path, or the folder in the Google Drive was moved. A green connection means that all pathways are clear and your edits will be saved. \n\nThis should always default to green on T&H computers, as the pathway is constant unless changed. Attempting to access the google drive outside of the network will not work unless the Google drive is mapped to your personal computer.";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
