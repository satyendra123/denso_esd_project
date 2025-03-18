using System;
using System.Windows.Forms;

namespace densoesd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(12, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 100);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(344, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(807, 322);
            panel4.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(1180, 357);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
