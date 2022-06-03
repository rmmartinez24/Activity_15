using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Results
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.magicNumberResultLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Lucky Number is";
            // 
            // magicNumberResultLabel2
            // 
            this.magicNumberResultLabel2.AutoSize = true;
            this.magicNumberResultLabel2.Location = new System.Drawing.Point(137, 124);
            this.magicNumberResultLabel2.Name = "magicNumberResultLabel2";
            this.magicNumberResultLabel2.Size = new System.Drawing.Size(0, 13);
            this.magicNumberResultLabel2.TabIndex = 1;
            // 
            // Results
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.magicNumberResultLabel2);
            this.Controls.Add(this.label1);
            this.Name = "Results";
            this.Text = "Your Result";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Results_Load(object sender, EventArgs e)
        {
            
        }
    }
}
