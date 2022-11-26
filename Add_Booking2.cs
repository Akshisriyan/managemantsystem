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
          private void btn_ab_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ab_booking_id.Text))
                {
                    MetroMessageBox.Show(this, "Booking Id Can't Be A Empty. Plese Check Your Database Connection", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_ab_hotel_id.Text))
                {
                    MetroMessageBox.Show(this, "Hotel Id Can't Be A Empty. Plese Check Your Database Connection", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_ab_customer_name.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Customer Name!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_ab_address.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Address!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_ab_telephone.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Telephone Number!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_ab_nic.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter NIC Number!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(cmb_ab_gender.Text))
                {
                    MetroMessageBox.Show(this, "Please Select Gender!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(cmb_ab_room_type.Text))
                {
                    MetroMessageBox.Show(this, "Please Select Room Type!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_ab_number_of_room.Text))
                {
                    MetroMessageBox.Show(this, "Please Enter Number Of Rooms!", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_ab_number_of_room.Text.Any(c => char.IsLetter(c)))
                {
                    MetroMessageBox.Show(this, "Number Of Rooms can not contain Letters!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txt_ab_number_of_room.Text.Any(c => char.IsDigit(c)))
                {
                    MetroMessageBox.Show(this, "Number Of Rooms can not contain Letters or Symbols!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_ab_number_of_room.Text.Any(c => char.IsPunctuation(c)))
                {
                    MetroMessageBox.Show(this, "Number Of Rooms can contain Full Numbers only!", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int ret = db.save_delete_update("insert into booking values('" + txt_ab_booking_id.Text + "', '" + txt_ab_hotel_id.Text + "', '" + txt_ab_customer_name.Text + "', '" + txt_ab_address.Text + "', '" + txt_ab_telephone.Text + "', '" + txt_ab_nic.Text + "', '" + datetime_ab_birth_date.Value.ToShortDateString() + "', '" + cmb_ab_gender.Text + "', '" + cmb_ab_room_type.Text + "', '" + txt_ab_number_of_room.Text + "', '" + datetime_ab_check_in_date.Value.ToShortDateString() + "', '" + datetime_ab_check_in_time.Value.ToShortDateString() + "')");
                    if (ret == 1)
                    {
                        txt_ab_customer_name.Clear();
                        txt_ab_address.Clear();
                        txt_ab_telephone.Clear();
                        txt_ab_nic.Clear();
                        datetime_ab_birth_date.ResetText();
                        cmb_ab_gender.SelectedIndex = -1;
                        cmb_ab_room_type.SelectedIndex = -1;
                        txt_ab_number_of_room.Clear();
                        datetime_ab_check_in_date.ResetText();
                        datetime_ab_check_in_time.ResetText();
                        getBookingID();

                        MetroMessageBox.Show(this, "Booking Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Booking Add Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
