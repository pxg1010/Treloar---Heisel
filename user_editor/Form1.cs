using System.IO;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace user_editor
{
    public partial class panelChildForm : Form
    {
        //public const string fileName = "G:\\.shortcut-targets-by-id\\0BzQ5p13p5nSCNmNuWHlNT1QxZXc\\IT SUPPORT\\Signature Generator 102022\\picLinks.js";
        public const string fileName = "C:\\Users\\17244\\Desktop\\test.js";
        System.Windows.Forms.Timer tmr = null;
        public string userName = Environment.UserName;

        //store the ip globally
        public string ipAdd = GetLocalIPAddress();
        public bool connect = false;
        public int counter = 0;
        //does this change register
        public panelChildForm()
        {
            InitializeComponent();
            customizeDesign();

            //start the timer for the date and for the connection green or red
            StartTimer();

            //set the label equal to the ip
            label10.Text = ipAdd;
            connect = isConnected(ipAdd);
            label12.Text = userName;
            
        }
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("ddd. MMMM dd, yyyy");
            label8.Text = DateTime.Now.ToString("h:mm:ss tt");
            ipAdd = GetLocalIPAddress();
            connect = isConnected(ipAdd);   //double check connection status
            label10.Text = ipAdd;
            //increment counter to not make a strobe light
            counter += 1; 

            //if javascript file exists then document it
            if(File.Exists(fileName) && connect.ToString() == "True")
            {
                label17.Text = "Connected to G: Drive";
                label19.Text = "Recording...";
            }
            else
            {
                label17.Text = "";
                label19.Text = "";
            }
            //if counter is even then flash green
            if((counter % 2 == 0) && connect.ToString() == "True")
            {
                label11.BackColor = Color.LimeGreen;
               // label17.Text = "Connected to G: Drive";
                //label19.Text = "Recording...";

            }
            else if((counter % 2 == 0) && connect.ToString() == "False")
            {
                label11.BackColor = Color.Red;
                
                label17.Text = "Failed Connection to G:";
                label19.Text = "Not Connected";
            }
            else
            {
                label11.BackColor = Color.White;
                //label17.Text = "";
                //label19.Text = "";

            }

        }
        //function to return the ip address
        //will return either IPv4 or local host depending on if user is connected to internet
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public bool isConnected(string ip)
        {   //56 if testing on a home network
            if (ip.Contains("192"))
            {
                label15.Text = "Local - Can't edit";
                return false;
            }
            label15.Text = "IPv4 Connection";
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string caseState = "case " + "\"" + textBox1.Text.ToUpper() + "\"" + ": \n";
            caseState += "\t\t\t\tsigCode += sen1 + \"" + textBox2.Text + "\" + sen2; \n";
            caseState += "\t\t\t\tsigCode += sen3 + name + sen4 + title; \n";
            caseState += "\t\t\t\tbreak; \n";
            caseState += "\t\t\t//new1";
            //find the text
            var content = File.ReadAllText(fileName);

            content = content.Replace("//new1", caseState);

            File.WriteAllText(fileName, content);

            MessageBox.Show("User has been added");

            textBox1.Text = "";
            textBox2.Text = "";
             
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string caseState = "case " + "\"" + textBox3.Text.ToUpper() + "\"" + ": \n";
            caseState += "\t\t\t\tsigCode += sen1 + \"" + textBox4.Text + "\" + sen2; \n";
            caseState += "\t\t\t\tsigCode += sen3 + name + sen4 + title; \n";
            caseState += "\t\t\t\tbreak; \n";



            string replace = "//Deleted User\n";
            //find the text
            var content = File.ReadAllText(fileName);

            content = content.Replace(caseState, replace);

            File.WriteAllText(fileName, content);

            MessageBox.Show("User has been deleted");

            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void customizeDesign()
        {
            
            panelHelpMenu.Visible = false;
           
        }

        private void hideMenu()
        {
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            
            hideMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelHelpMenu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            hideMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 user = new Form3();
            user.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string myfile = "C:\\Users\\17244\\Desktop\\School\\Semester 7\\CPSC 236\\user_editor\\bin\\Debug\\net6.0-windows\\test.txt";
            Process.Start("notepad.exe", myfile);
        }
    }
}