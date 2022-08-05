namespace CuaHangTrangSuc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgrid_trangsuc = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matrangsuc = new System.Windows.Forms.TextBox();
            this.rbt_conhang = new System.Windows.Forms.RadioButton();
            this.rbt_hethang = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.chk_ten = new System.Windows.Forms.CheckBox();
            this.chk_ma = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbo_mausac = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_nsx = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_trangsuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_trangsuc
            // 
            this.dgrid_trangsuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_trangsuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_trangsuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_trangsuc.Location = new System.Drawing.Point(0, 503);
            this.dgrid_trangsuc.Name = "dgrid_trangsuc";
            this.dgrid_trangsuc.RowHeadersWidth = 51;
            this.dgrid_trangsuc.RowTemplate.Height = 29;
            this.dgrid_trangsuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_trangsuc.Size = new System.Drawing.Size(1216, 188);
            this.dgrid_trangsuc.TabIndex = 0;
            this.dgrid_trangsuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_foods_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_them.Location = new System.Drawing.Point(413, 351);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(105, 39);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(684, 351);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 39);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(556, 351);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 39);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Trang Sức";
            // 
            // txt_matrangsuc
            // 
            this.txt_matrangsuc.Location = new System.Drawing.Point(126, 6);
            this.txt_matrangsuc.Name = "txt_matrangsuc";
            this.txt_matrangsuc.Size = new System.Drawing.Size(233, 27);
            this.txt_matrangsuc.TabIndex = 3;
            // 
            // rbt_conhang
            // 
            this.rbt_conhang.AutoSize = true;
            this.rbt_conhang.Location = new System.Drawing.Point(26, 119);
            this.rbt_conhang.Name = "rbt_conhang";
            this.rbt_conhang.Size = new System.Drawing.Size(96, 24);
            this.rbt_conhang.TabIndex = 4;
            this.rbt_conhang.TabStop = true;
            this.rbt_conhang.Text = "Còn Hàng";
            this.rbt_conhang.UseVisualStyleBackColor = true;
            // 
            // rbt_hethang
            // 
            this.rbt_hethang.AutoSize = true;
            this.rbt_hethang.Location = new System.Drawing.Point(265, 119);
            this.rbt_hethang.Name = "rbt_hethang";
            this.rbt_hethang.Size = new System.Drawing.Size(94, 24);
            this.rbt_hethang.TabIndex = 4;
            this.rbt_hethang.TabStop = true;
            this.rbt_hethang.Text = "Hết Hàng";
            this.rbt_hethang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trạng Thái";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(939, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 247);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(385, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cửa Hàng Trang Sức Tana";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(750, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(413, 450);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(365, 27);
            this.txt_search.TabIndex = 9;
          
            // 
            // chk_ten
            // 
            this.chk_ten.AutoSize = true;
            this.chk_ten.Location = new System.Drawing.Point(413, 411);
            this.chk_ten.Name = "chk_ten";
            this.chk_ten.Size = new System.Drawing.Size(81, 24);
            this.chk_ten.TabIndex = 10;
            this.chk_ten.Text = "Lọc Tên";
            this.chk_ten.UseVisualStyleBackColor = true;
           
            // 
            // chk_ma
            // 
            this.chk_ma.AutoSize = true;
            this.chk_ma.Location = new System.Drawing.Point(556, 411);
            this.chk_ma.Name = "chk_ma";
            this.chk_ma.Size = new System.Drawing.Size(98, 24);
            this.chk_ma.TabIndex = 10;
            this.chk_ma.Text = "Mã Đồ Ăn";
            this.chk_ma.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(684, 411);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 24);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbo_mausac
            // 
            this.cbo_mausac.FormattingEnabled = true;
            this.cbo_mausac.Location = new System.Drawing.Point(929, 58);
            this.cbo_mausac.Name = "cbo_mausac";
            this.cbo_mausac.Size = new System.Drawing.Size(233, 28);
            this.cbo_mausac.TabIndex = 11;
            this.cbo_mausac.Text = "Mời Bạn Chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên Trang Sức";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(126, 55);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(233, 27);
            this.txt_ten.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(929, 12);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(233, 27);
            this.txt_gia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà Sản Xuất";
            this.label2.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(745, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Màu Sắc";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbo_nsx
            // 
            this.cbo_nsx.FormattingEnabled = true;
            this.cbo_nsx.Location = new System.Drawing.Point(929, 98);
            this.cbo_nsx.Name = "cbo_nsx";
            this.cbo_nsx.Size = new System.Drawing.Size(233, 28);
            this.cbo_nsx.TabIndex = 11;
            this.cbo_nsx.Text = "Mời Bạn Chọn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(403, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1216, 691);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbo_nsx);
            this.Controls.Add(this.cbo_mausac);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.chk_ma);
            this.Controls.Add(this.chk_ten);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbt_hethang);
            this.Controls.Add(this.rbt_conhang);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_matrangsuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrid_trangsuc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_trangsuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_trangsuc;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matrangsuc;
        private System.Windows.Forms.RadioButton rbt_conhang;
        private System.Windows.Forms.RadioButton rbt_hethang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.CheckBox chk_ten;
        private System.Windows.Forms.CheckBox chk_ma;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox cbo_mausac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_nsx;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
