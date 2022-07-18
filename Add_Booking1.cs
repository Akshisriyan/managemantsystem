using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hotel_managemant_system
{
    public partial class Add_Booking1 : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public Add_Booking1()
        {
            InitializeComponent();
        }


         private void Add_Booking1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sh_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txt_sh_hotel_id_name.Text.Any(c => char.IsDigit(c)))
                {
                    db = new Database();
                    DataTable dt = db.GetData("select * from hotel where hotel_name='" + txt_sh_hotel_id_name.Text + "'");
                    if (dt.Rows.Count > 0)
                    {

                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_sh_hotel_id.Text = dr["hotel_id"].ToString();
                            txt_sh_hotel_name.Text = dr["hotel_name"].ToString();
                            txt_sh_city.Text = dr["city"].ToString();
                            txt_sh_address.Text = dr["address"].ToString();
                            txt_sh_about.Text = dr["about"].ToString();
                        }

                        txt_sh_hotel_id.ReadOnly = true;
                        txt_sh_hotel_name.ReadOnly = true;
                        txt_sh_city.ReadOnly = true;
                        txt_sh_about.ReadOnly = true;
                        txt_sh_address.ReadOnly = true;

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There is no Hotel accompanied with the given Hotel ID or Hotel Name", "Invalid Model ID Or Model Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    db = new Database();
                    DataTable dt = db.GetData("select * from hotel where hotel_id='" + txt_sh_hotel_id_name.Text + "' or  hotel_name='" + txt_sh_hotel_id_name.Text + "'");
                    if (dt.Rows.Count > 0)
                    {

                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_sh_hotel_id.Text = dr["hotel_id"].ToString();
                            txt_sh_hotel_name.Text = dr["hotel_name"].ToString();
                            txt_sh_city.Text = dr["city"].ToString();
                            txt_sh_address.Text = dr["address"].ToString();
                            txt_sh_about.Text = dr["about"].ToString();
                        }

                        txt_sh_hotel_id.ReadOnly = true;
                        txt_sh_hotel_name.ReadOnly = true;
                        txt_sh_city.ReadOnly = true;
                        txt_sh_about.ReadOnly = true;
                        txt_sh_address.ReadOnly = true;

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "There is no Hotel accompanied with the given Hotel ID or Hotel Name", "Invalid Model ID Or Model Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
