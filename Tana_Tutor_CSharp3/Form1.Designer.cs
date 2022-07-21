namespace Tana_Tutor_CSharp3
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
            this.dgrid_drinks = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_madouong = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tendouong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dungtich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbt_conhang = new System.Windows.Forms.RadioButton();
            this.rbt_hethang = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_loc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_timkiemdouong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_drinks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_drinks
            // 
            this.dgrid_drinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_drinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_drinks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_drinks.Location = new System.Drawing.Point(0, 200);
            this.dgrid_drinks.Name = "dgrid_drinks";
            this.dgrid_drinks.RowHeadersWidth = 51;
            this.dgrid_drinks.RowTemplate.Height = 29;
            this.dgrid_drinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_drinks.Size = new System.Drawing.Size(1195, 250);
            this.dgrid_drinks.TabIndex = 0;
            this.dgrid_drinks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_drinks_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(90, 165);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(230, 165);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 29);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(403, 165);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Location = new System.Drawing.Point(528, 177);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(143, 20);
            this.lbl_soluong.TabIndex = 2;
            this.lbl_soluong.Text = "Số Lượng Đồ Uống :";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(677, 170);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(223, 27);
            this.txt_soluong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Đồ Uống :";
            // 
            // txt_madouong
            // 
            this.txt_madouong.Location = new System.Drawing.Point(116, 6);
            this.txt_madouong.Name = "txt_madouong";
            this.txt_madouong.Size = new System.Drawing.Size(223, 27);
            this.txt_madouong.TabIndex = 3;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(597, 12);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(223, 27);
            this.txt_gia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá Đồ Uống";
            // 
            // txt_tendouong
            // 
            this.txt_tendouong.Location = new System.Drawing.Point(116, 60);
            this.txt_tendouong.Name = "txt_tendouong";
            this.txt_tendouong.Size = new System.Drawing.Size(223, 27);
            this.txt_tendouong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Đồ Uống :";
            // 
            // txt_dungtich
            // 
            this.txt_dungtich.Location = new System.Drawing.Point(609, 63);
            this.txt_dungtich.Name = "txt_dungtich";
            this.txt_dungtich.Size = new System.Drawing.Size(223, 27);
            this.txt_dungtich.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Dung Tích";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbt_conhang
            // 
            this.rbt_conhang.AutoSize = true;
            this.rbt_conhang.Location = new System.Drawing.Point(679, 121);
            this.rbt_conhang.Name = "rbt_conhang";
            this.rbt_conhang.Size = new System.Drawing.Size(96, 24);
            this.rbt_conhang.TabIndex = 10;
            this.rbt_conhang.TabStop = true;
            this.rbt_conhang.Text = "Còn Hàng";
            this.rbt_conhang.UseVisualStyleBackColor = true;
            // 
            // rbt_hethang
            // 
            this.rbt_hethang.AutoSize = true;
            this.rbt_hethang.Location = new System.Drawing.Point(806, 121);
            this.rbt_hethang.Name = "rbt_hethang";
            this.rbt_hethang.Size = new System.Drawing.Size(94, 24);
            this.rbt_hethang.TabIndex = 10;
            this.rbt_hethang.TabStop = true;
            this.rbt_hethang.Text = "Hết Hàng";
            this.rbt_hethang.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng Thái :";
            // 
            // cbo_loc
            // 
            this.cbo_loc.FormattingEnabled = true;
            this.cbo_loc.Location = new System.Drawing.Point(0, 115);
            this.cbo_loc.Name = "cbo_loc";
            this.cbo_loc.Size = new System.Drawing.Size(151, 28);
            this.cbo_loc.TabIndex = 11;
            this.cbo_loc.SelectedIndexChanged += new System.EventHandler(this.cbo_loc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(990, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm Kiếm Ở Đây";
            // 
            // txt_timkiemdouong
            // 
            this.txt_timkiemdouong.Location = new System.Drawing.Point(972, 170);
            this.txt_timkiemdouong.Name = "txt_timkiemdouong";
            this.txt_timkiemdouong.Size = new System.Drawing.Size(223, 27);
            this.txt_timkiemdouong.TabIndex = 5;
            this.txt_timkiemdouong.Text = "Mời bạn tìm kiếm đồ uống";
            this.txt_timkiemdouong.Enter += new System.EventHandler(this.txt_timkiemdouong_Enter);
            this.txt_timkiemdouong.Leave += new System.EventHandler(this.txt_timkiemdouong_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_loc);
            this.Controls.Add(this.rbt_hethang);
            this.Controls.Add(this.rbt_conhang);
            this.Controls.Add(this.txt_dungtich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tendouong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_timkiemdouong);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_madouong);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_soluong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrid_drinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_drinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_drinks;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_madouong;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tendouong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dungtich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbt_conhang;
        private System.Windows.Forms.RadioButton rbt_hethang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_loc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_timkiemdouong;
    }
}
