using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinform
{
    public partial class Form1 : Form
    {
        //是否点击了运算符
        //点击了运算符号flag 就变为true
        //当点击了数字就变为false
        public bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AutoPartSize();
            textBox2.Text = "0";
            textBox2.Focus();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AutoPartSize();
        }
        /// <summary>
        /// 控制整体控件的宽度以及控件是否显示
        /// </summary>
        private void AutoPartSize()
        {
            if (this.Width < 820)
            {
                this.tableLayoutPanelLarge.ColumnStyles[0].Width = this.Width - 20;
                this.tableLayoutPanelLarge.ColumnStyles[1].Width = 0;
                history.Visible = true;
            }
            else
            {
                this.tableLayoutPanelLarge.ColumnStyles[0].Width = this.Width - 400 - 10;
                this.tableLayoutPanelLarge.ColumnStyles[1].Width = 400;
                history.Visible = false;

            }
        }

        public decimal Calculate(string formulaStr)
        {
            NormalCalculate normalCalculate = new NormalCalculate();
            if (formulaStr == null || formulaStr.Length < 1)
            {
                return 0;
            }
            else if (formulaStr.Contains("➗"))
            {
                string[] strings = formulaStr.Split('➗');

            }
            return 1;
        }
        /// <summary>
        /// 清除
        /// </summary>
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        /// <summary>
        /// 数字键给textBox2赋值
        /// </summary>
        /// <param name="sender"></param>
        public void SetValue(object sender)
        {
            if (flag == true)
            {
                textBox2.Text = string.Empty;
            }

            flag = false;
            Button button = (Button)sender;
            textBox2.Text = textBox2.Text + button.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void fraction_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void square_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void ride_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void one_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void two_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void three_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void four_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void five_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void six_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            SetValue(sender);
        }
    }
}
