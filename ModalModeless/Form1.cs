using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalModeless
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요~", "비 오는 날 아침 인사");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요~");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요~", "비 오는 날 아침 인사", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요~", "비 오는 날 아침 인사", 
                MessageBoxButtons.YesNoCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm();
            // 현재 창 내부에서 새로운 창 만들기.
            // Modal 에서는 불가능.
            frm.MdiParent = this; 
            frm.Show();
        }
    }
}
