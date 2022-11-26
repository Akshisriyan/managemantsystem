namespace hotel_managemant_system
{
    partial class Add_Booking1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sh_search = new MetroFramework.Controls.MetroButton();
            this.txt_sh_hotel_id_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txt_sh_hotel_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_sh_about = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_sh_address = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_sh_city = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_sh_hotel_name = new MetroFramework.Controls.MetroTextBox();
            this.lable_ah1_hotel_name = new MetroFramework.Controls.MetroLabel();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            this.btn_search_hotel_exit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();

             // 
            // btn_sh_search
            // 
            this.btn_sh_search.Highlight = true;
            this.btn_sh_search.Location = new System.Drawing.Point(566, 113);
            this.btn_sh_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sh_search.Name = "btn_sh_search";
            this.btn_sh_search.Size = new System.Drawing.Size(131, 34);
            this.btn_sh_search.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_sh_search.TabIndex = 12;
            this.btn_sh_search.Text = "Search";
            this.btn_sh_search.UseSelectable = true;
            this.btn_sh_search.Click += new System.EventHandler(this.btn_sh_search_Click);

              // 
            // txt_sh_hotel_id_name
            // 
            // 
            // 
            // 
            this.txt_sh_hotel_id_name.CustomButton.Image = null;
            this.txt_sh_hotel_id_name.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txt_sh_hotel_id_name.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sh_hotel_id_name.CustomButton.Name = "";
            this.txt_sh_hotel_id_name.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_sh_hotel_id_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sh_hotel_id_name.CustomButton.TabIndex = 1;
            this.txt_sh_hotel_id_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sh_hotel_id_name.CustomButton.UseSelectable = true;
            this.txt_sh_hotel_id_name.CustomButton.Visible = false;
            this.txt_sh_hotel_id_name.Lines = new string[0];
            this.txt_sh_hotel_id_name.Location = new System.Drawing.Point(290, 113);
            this.txt_sh_hotel_id_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sh_hotel_id_name.MaxLength = 32767;
            this.txt_sh_hotel_id_name.Name = "txt_sh_hotel_id_name";
            this.txt_sh_hotel_id_name.PasswordChar = '\0';
            this.txt_sh_hotel_id_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sh_hotel_id_name.SelectedText = "";
            this.txt_sh_hotel_id_name.SelectionLength = 0;
            this.txt_sh_hotel_id_name.SelectionStart = 0;
            this.txt_sh_hotel_id_name.ShortcutsEnabled = true;
            this.txt_sh_hotel_id_name.Size = new System.Drawing.Size(229, 34);
            this.txt_sh_hotel_id_name.TabIndex = 10;
            this.txt_sh_hotel_id_name.UseSelectable = true;
            this.txt_sh_hotel_id_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sh_hotel_id_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);


                        // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(105, 113);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 25);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Hotel ID/Name";
            // 
            // metroPanel1
            // 
             this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txt_sh_hotel_id);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txt_sh_about);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txt_sh_address);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txt_sh_city);
                        this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txt_sh_hotel_name);
            this.metroPanel1.Controls.Add(this.lable_ah1_hotel_name);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
             this.metroPanel1.Location = new System.Drawing.Point(83, 174);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(856, 279);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;

            // 
            // txt_sh_hotel_id
            // 
            this.txt_sh_hotel_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_sh_hotel_id.CustomButton.Image = null;
            this.txt_sh_hotel_id.CustomButton.Location = new System.Drawing.Point(54, 2);
            this.txt_sh_hotel_id.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sh_hotel_id.CustomButton.Name = "";
            this.txt_sh_hotel_id.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_sh_hotel_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sh_hotel_id.CustomButton.TabIndex = 1;
            this.txt_sh_hotel_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sh_hotel_id.CustomButton.UseSelectable = true;
            this.txt_sh_hotel_id.CustomButton.Visible = false;
            this.txt_sh_hotel_id.Enabled = false;
            this.txt_sh_hotel_id.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_sh_hotel_id.Lines = new string[0];
            this.txt_sh_hotel_id.Location = new System.Drawing.Point(206, 33);
            this.txt_sh_hotel_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sh_hotel_id.MaxLength = 32767;
            this.txt_sh_hotel_id.Name = "txt_sh_hotel_id";
            this.txt_sh_hotel_id.PasswordChar = '\0';
            this.txt_sh_hotel_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sh_hotel_id.SelectedText = "";
            this.txt_sh_hotel_id.SelectionLength = 0;
            this.txt_sh_hotel_id.SelectionStart = 0;
            this.txt_sh_hotel_id.ShortcutsEnabled = true;
            this.txt_sh_hotel_id.Size = new System.Drawing.Size(86, 34);
            this.txt_sh_hotel_id.TabIndex = 47;
            this.txt_sh_hotel_id.UseSelectable = true;
            this.txt_sh_hotel_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sh_hotel_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
              // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(32, 42);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 25);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Hotel ID";
            // 
             // txt_sh_about
            // 
            this.txt_sh_about.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_sh_about.CustomButton.Image = null;
            this.txt_sh_about.CustomButton.Location = new System.Drawing.Point(569, 2);
            this.txt_sh_about.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sh_about.CustomButton.Name = "";
            this.txt_sh_about.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_sh_about.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sh_about.CustomButton.TabIndex = 1;
            this.txt_sh_about.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sh_about.CustomButton.UseSelectable = true;
            this.txt_sh_about.CustomButton.Visible = false;
            this.txt_sh_about.Enabled = false;
            this.txt_sh_about.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_sh_about.Lines = new string[0];
            this.txt_sh_about.Location = new System.Drawing.Point(206, 203);
            this.txt_sh_about.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sh_about.MaxLength = 32767;
            this.txt_sh_about.Name = "txt_sh_about";
            this.txt_sh_about.PasswordChar = '\0';
            this.txt_sh_about.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sh_about.SelectedText = "";
            this.txt_sh_about.SelectionLength = 0;
            this.txt_sh_about.SelectionStart = 0;
            this.txt_sh_about.ShortcutsEnabled = true;
            this.txt_sh_about.Size = new System.Drawing.Size(601, 34);
            this.txt_sh_about.TabIndex = 45;
            this.txt_sh_about.UseSelectable = true;
            this.txt_sh_about.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sh_about.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
        }



    
       

        private MetroFramework.Controls.MetroButton btn_sh_search;
        private MetroFramework.Controls.MetroTextBox txt_sh_hotel_id_name;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_sh_hotel_id;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_sh_about;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_sh_address;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_sh_city;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_sh_hotel_name;
        private MetroFramework.Controls.MetroLabel lable_ah1_hotel_name;
        private MetroFramework.Controls.MetroButton btn_reset;
        private MetroFramework.Controls.MetroButton btn_search_hotel_exit;
    }
}