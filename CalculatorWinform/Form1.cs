using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AutoSize();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AutoSize();
        }
        private void AutoSize()
        {
            if (this.Width < 820)
            {
                this.tableLayoutPanelLarge.ColumnStyles[0].Width = this.Width - 20;
                this.tableLayoutPanelLarge.ColumnStyles[1].Width = 0;
            }
            else
            {
                this.tableLayoutPanelLarge.ColumnStyles[0].Width = this.Width - 400 - 10;
                this.tableLayoutPanelLarge.ColumnStyles[1].Width = 400;

            }
        }
    }
}
