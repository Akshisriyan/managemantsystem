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
    public partial class Add_Booking2 : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        String gHotel_name;
        String gHotel_id;
        public Add_Booking2(String hotel_name, String hotel_id)
        {
            InitializeComponent();
            txt_ab_hotel_name.Text = hotel_name;
            txt_ab_hotel_id.Text = hotel_id;

            gHotel_name = hotel_name;
            gHotel_id = hotel_id;
            cmb_ab_room_type.Items.Clear();
            getRoomType();
            getBookingID();
        }

        public void getRoomType()
        {
            try
            {
                db = new Database();
                DataTable dt = db.GetData("select * from hotel_details where hotel_id='" + gHotel_id + "'");
                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        cmb_ab_room_type.Items.Add(dr["type"].ToString());
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getBookingID()
        {
            try
            {
                DataTable dt = db.GetData("select top 1 booking_id from booking order by booking_id desc");
                if (dt.Rows.Count == 0)
                {
                    txt_ab_booking_id.Text = 1.ToString();
                }
                else
                {
                    int no = Int32.Parse(dt.Rows[0][0].ToString());
                    no++;
                    txt_ab_booking_id.Text = no.ToString();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error on load ID!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Booking_Load(object sender, EventArgs e)
        {

        }