using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSize_1
{

    public partial class Form2 : Form
    {
        private int formStartX = 0;
        private int formStartY = 0;

        FormControl fc = null;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            fc = new FormControl(this);
            fc.GetInit(this, fc);

            this.formStartX = this.Width;
            this.formStartY = this.Height;

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //界面还原的按钮
            this.Width = this.formStartX;
            this.Height = this.formStartY;

            fc.Reset(this, fc);
        } 

    }


}
