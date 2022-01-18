using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ablauf_widerstandsnetzwerk
{
    public partial class frm_rnw : Form
    {
        public frm_rnw()
        {
            InitializeComponent();
        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            double R1, R2, Rges, Gges;
            
            //Eingabe
            R1 = Convert.ToDouble(tb_r1.Text);
            R2 = Convert.ToDouble(tb_r2.Text);

            //Verarbeitung
            if (rb_reihe.Checked)
            {
                Rges = R1 + R2;
            }
            else 
            { 
                Rges = R1 * R2 / (R1 + R2);
            }

            Gges = 1 / Rges;
            
            //Ausgabe
            if (Rges > 1000)
            {
                tb_rges.Text = (Rges/1000).ToString("0.000");
                tb_gges.Text = (Gges*1000).ToString("0.000");
                lbl_rges.Text = "Rges [kOhm]";
                lbl_gges.Text = "Gges [mSiemens]";

            }
            else
            {
                tb_rges.Text = Rges.ToString("0.000");
                tb_gges.Text = Gges.ToString("0.000");
                lbl_rges.Text = "Rges [Ohm]";
                lbl_gges.Text = "Gges [Siemens]";
            }      
        }

        private void btn_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_r1_uebernehmen_Click(object sender, EventArgs e)
        {
            tb_r1.Text = tb_rges.Text;
        }

        private void frm_rnw_Load(object sender, EventArgs e)
        {
            rb_reihe.Checked = true;
            tb_rges.Enabled = false;
            tb_gges.Enabled = false;
            tb_r1.TextAlign = HorizontalAlignment.Right;
            tb_r2.TextAlign = HorizontalAlignment.Right;
            tb_rges.TextAlign = HorizontalAlignment.Right;
            tb_gges.TextAlign = HorizontalAlignment.Right;
            

        }
    }
}
