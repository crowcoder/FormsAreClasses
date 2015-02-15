using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsClasses
{
    public partial class BoxInfo : Form
    {
        Box myBox;

        public BoxInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myBox = new Box();
            myBox.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = myBox.txtWidgetCount.Text;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have to make a box first.");
            }
        }
    }
}
