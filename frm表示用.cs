using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCVTest01
{
    public partial class frm表示用 : Form
    {
        public Image p_img表示;
        public frm表示用()
        {
            InitializeComponent();
        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }

        private void frm表示用_Shown(object sender, EventArgs e)
        {
            if(p_img表示 is null ){

            }
            else
            {
                picImg.Image = p_img表示;
            }
        }

        private void btn原寸表示_Click(object sender, EventArgs e)
        {
            picImg.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
