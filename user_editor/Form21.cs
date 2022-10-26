namespace user_editor
{
    internal class Form2 : Form
    {
        private Label label1;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Does this load?";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(838, 485);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}