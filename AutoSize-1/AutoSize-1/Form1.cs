using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSize_1
{
    public partial class Form1 : Form
    {
        //AutoSizeFormClass asc = new AutoSizeFormClass();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //asc.controllInitializeSize(this);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //asc.controlAutoSize(this);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
