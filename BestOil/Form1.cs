using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Benzin AI_92 = new Benzin() { Marka = "AI_92", qiymet = 1.00 };
        public Benzin AI_95 = new Benzin() { Marka = "AI_95", qiymet = 1.40 };
        public Benzin AI_98 = new Benzin() { Marka = "AI_98", qiymet = 1.80 };
        public Food hotdog = new Food() { Name = "Hotdog", qiymet = 1.0 };
        public Food hamburger = new Food() { Name = "Hamburger", qiymet = 1.5 };
        public Food fries = new Food() { Name = "Fries", qiymet = 2.0 };
        public Food Cola = new Food() { Name = "Coca cola", qiymet = 1.0 };



        private void rb_ltr_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ltr.Checked)
            {
                tb_litr.Enabled = true;
                tb_mnt.Enabled = false;
            }
            else
            {
                tb_mnt.Enabled = true;
                tb_litr.Enabled = false;
            }
        }
        double caf = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tb_mhot.Text != "")
            {

                hambc = int.Parse(tb_mhamb.Text);
                hotc = int.Parse(tb_mhot.Text);
                friesc = int.Parse(tb_mfries.Text);
                colac = int.Parse(tb_mcoca.Text);
                caf = (hambc * 1.5) + (hotc * 1) + (friesc * 2.0) + (colac * 1);
                lbl_mcaf.Text = caf.ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_bnz.Items.Add(AI_92);
            cb_bnz.Items.Add(AI_95);
            cb_bnz.Items.Add(AI_98);
        }

        private void cb_bnz_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtb_bqiy.Text = ((sender as ComboBox).SelectedItem as Benzin).qiymet.ToString();
        }

        double bnzq = 0;
        int hambc = 0, friesc = 0, colac = 0, hotc = 0;
        private void tb_litr_TextChanged(object sender, EventArgs e)
        {
            if (tb_litr.Text != "")
            {
                bnzq = (double.Parse(tb_litr.Text) * double.Parse(mtb_bqiy.Text));
                lbl_mbnz.Text = bnzq.ToString();
            }
            else
            {
                lbl_mbnz.Text = "0";
            }
        }

        private void tb_mnt_TextChanged(object sender, EventArgs e)
        {
            if (tb_mnt.Text != "")
            {
                bnzq = double.Parse(tb_mnt.Text);
                lbl_mbnz.Text = tb_mnt.Text;
            }
            else
            {
                lbl_mbnz.Text = "0";
            }
        }
        private void chk_food(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Text == "Hotdog")
            {                
                tb_mhot.Enabled = (sender as CheckBox).Checked;
            }
            else if((sender as CheckBox).Text == "Hamburger")
            {
                tb_mhamb.Enabled = (sender as CheckBox).Checked;
            }
            else if(( sender as CheckBox).Text == "Fries")
            {
                tb_mfries.Enabled = (sender as CheckBox).Checked;
            }
            else if((sender as CheckBox ).Text == "CocaCola")
            {
                tb_mcoca.Enabled = (sender as CheckBox).Checked;
            }            
        }

        private void lbl_mbnz_TextChanged(object sender, EventArgs e)
        {
            lbl_ym.Text = (double.Parse(lbl_mbnz.Text) + double.Parse(lbl_mcaf.Text)).ToString();
        }

        private void lbl_mcaf_TextChanged(object sender, EventArgs e)
        {
            lbl_ym.Text = (double.Parse(lbl_mbnz.Text) + double.Parse(lbl_mcaf.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hambc = 0;
            friesc = 0;
            colac = 0;
            hotc = 0;
            tb_mnt.Text = "";
            tb_litr.Text="";
            tb_mhot.Text = "0";
            tb_mcoca.Text = "0";
            tb_mfries.Text = "0";
            tb_mhamb.Text = "0";
            lbl_mbnz.Text = "0";
            lbl_mcaf.Text = "0";
            lbl_ym.Text="0";
            cb_coca.Checked = false;
            cb_fries.Checked = false;
            cb_hamburger.Checked = false;
            cb_htd.Checked = false;            
        }

        private void tb_mhamb_TextChanged(object sender, EventArgs e)
        {
            if (tb_mhamb.Text != "")
            {
                hambc = int.Parse(tb_mhamb.Text);
                hotc = int.Parse(tb_mhot.Text);
                friesc = int.Parse(tb_mfries.Text);
                colac=int.Parse(tb_mcoca.Text);
                caf = (hambc*1.5)+(hotc*1)+(friesc*2.0)+(colac*1);
                lbl_mcaf.Text = caf.ToString();
            }
            
        }

        private void tb_mfries_TextChanged(object sender, EventArgs e)
        {
            if (tb_mfries.Text != "")
            {
                hambc = int.Parse(tb_mhamb.Text);
                hotc = int.Parse(tb_mhot.Text);
                friesc = int.Parse(tb_mfries.Text);
                colac = int.Parse(tb_mcoca.Text);
                caf = (hambc * 1.5) + (hotc * 1) + (friesc * 2.0) + (colac * 1);
                lbl_mcaf.Text = caf.ToString();
            }
            
        }

        private void tb_mcoca_TextChanged(object sender, EventArgs e)
        {
            if (tb_mcoca.Text != "")
            {
                hambc = int.Parse(tb_mhamb.Text);
                hotc = int.Parse(tb_mhot.Text);
                friesc = int.Parse(tb_mfries.Text);                
                colac = int.Parse(tb_mcoca.Text);
                caf = (hambc * 1.5) + (hotc * 1) + (friesc * 2.0) + (colac * 1);
                lbl_mcaf.Text = caf.ToString();
            }
            
        }
    }
}
