namespace Showroom
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
            this.dgrid_xe = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_giaxe = new System.Windows.Forms.TextBox();
            this.txt_tenxe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cbo_hangxe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_10 = new System.Windows.Forms.CheckBox();
            this.chk_20 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_xe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_xe
            // 
            this.dgrid_xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_xe.Location = new System.Drawing.Point(0, 102);
            this.dgrid_xe.Name = "dgrid_xe";
            this.dgrid_xe.RowHeadersWidth = 51;
            this.dgrid_xe.RowTemplate.Height = 29;
            this.dgrid_xe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_xe.Size = new System.Drawing.Size(616, 435);
            this.dgrid_xe.TabIndex = 0;
            this.dgrid_xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_xe_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_them.Location = new System.Drawing.Point(627, 375);
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
            this.btn_xoa.Location = new System.Drawing.Point(898, 375);
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
            this.btn_sua.Location = new System.Drawing.Point(770, 375);
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
            this.label1.Location = new System.Drawing.Point(664, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giá Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Xe";
            // 
            // txt_giaxe
            // 
            this.txt_giaxe.Location = new System.Drawing.Point(766, 213);
            this.txt_giaxe.Name = "txt_giaxe";
            this.txt_giaxe.Size = new System.Drawing.Size(233, 27);
            this.txt_giaxe.TabIndex = 3;
            this.txt_giaxe.Text = "Giá Xe";
            this.txt_giaxe.Enter += new System.EventHandler(this.txt_giaxe_Enter);
            // 
            // txt_tenxe
            // 
            this.txt_tenxe.Location = new System.Drawing.Point(766, 89);
            this.txt_tenxe.Name = "txt_tenxe";
            this.txt_tenxe.Size = new System.Drawing.Size(233, 27);
            this.txt_tenxe.TabIndex = 3;
            this.txt_tenxe.Text = "Tên Xe";
            this.txt_tenxe.Enter += new System.EventHandler(this.txt_tenxe_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thuế";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(251, 34);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(365, 27);
            this.txt_search.TabIndex = 9;
            this.txt_search.Text = "Mời Bạn Nhập Tên Xe Muốn Tìm Kiếm";
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // cbo_hangxe
            // 
            this.cbo_hangxe.FormattingEnabled = true;
            this.cbo_hangxe.Location = new System.Drawing.Point(766, 158);
            this.cbo_hangxe.Name = "cbo_hangxe";
            this.cbo_hangxe.Size = new System.Drawing.Size(233, 28);
            this.cbo_hangxe.TabIndex = 11;
            this.cbo_hangxe.Text = "Mời Bạn Chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hãng Xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm Kiếm Theo Tên Xe";
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Image = ((System.Drawing.Image)(resources.GetObject("btn_hienthi.Image")));
            this.btn_hienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienthi.Location = new System.Drawing.Point(60, 25);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(115, 45);
            this.btn_hienthi.TabIndex = 13;
            this.btn_hienthi.Text = "Hiển Thị";
            this.btn_hienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // chk_10
            // 
            this.chk_10.AutoSize = true;
            this.chk_10.Location = new System.Drawing.Point(636, 291);
            this.chk_10.Name = "chk_10";
            this.chk_10.Size = new System.Drawing.Size(59, 24);
            this.chk_10.TabIndex = 15;
            this.chk_10.Text = "10%";
            this.chk_10.UseVisualStyleBackColor = true;
            this.chk_10.CheckedChanged += new System.EventHandler(this.chk_10_CheckedChanged);
            // 
            // chk_20
            // 
            this.chk_20.AutoSize = true;
            this.chk_20.Location = new System.Drawing.Point(898, 291);
            this.chk_20.Name = "chk_20";
            this.chk_20.Size = new System.Drawing.Size(59, 24);
            this.chk_20.TabIndex = 15;
            this.chk_20.Text = "20%";
            this.chk_20.UseVisualStyleBackColor = true;
            this.chk_20.CheckedChanged += new System.EventHandler(this.chk_20_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1034, 537);
            this.Controls.Add(this.chk_20);
            this.Controls.Add(this.chk_10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_hangxe);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenxe);
            this.Controls.Add(this.txt_giaxe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrid_xe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_xe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_xe;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_giaxe;
        private System.Windows.Forms.TextBox txt_tenxe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cbo_hangxe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_10;
        private System.Windows.Forms.CheckBox chk_20;
    }
}
