
namespace PROJECT_.Net.SanXuat
{
    partial class FRMYeuCauSanXuat
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cblohang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkyc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtut = new System.Windows.Forms.TextBox();
            this.btnyc = new System.Windows.Forms.Button();
            this.btninan = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(552, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(520, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Ưu Tiên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btninan);
            this.groupBox2.Controls.Add(this.btnyc);
            this.groupBox2.Controls.Add(this.txtut);
            this.groupBox2.Controls.Add(this.dtpkdate);
            this.groupBox2.Controls.Add(this.dtpkyc);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbtrangthai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cblohang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 596);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 566);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lô Hàng";
            // 
            // cblohang
            // 
            this.cblohang.FormattingEnabled = true;
            this.cblohang.Location = new System.Drawing.Point(165, 43);
            this.cblohang.Name = "cblohang";
            this.cblohang.Size = new System.Drawing.Size(374, 31);
            this.cblohang.TabIndex = 1;
            this.cblohang.SelectedIndexChanged += new System.EventHandler(this.cblohang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng Thái";
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Location = new System.Drawing.Point(165, 117);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(121, 31);
            this.cbtrangthai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(165, 196);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(121, 29);
            this.txtsoluong.TabIndex = 5;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Yêu Cầu";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpkyc
            // 
            this.dtpkyc.Location = new System.Drawing.Point(165, 275);
            this.dtpkyc.Name = "dtpkyc";
            this.dtpkyc.Size = new System.Drawing.Size(374, 29);
            this.dtpkyc.TabIndex = 6;
            this.dtpkyc.ValueChanged += new System.EventHandler(this.dtpkyc_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Kết Thúc";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpkdate
            // 
            this.dtpkdate.Location = new System.Drawing.Point(165, 347);
            this.dtpkdate.Name = "dtpkdate";
            this.dtpkdate.Size = new System.Drawing.Size(374, 29);
            this.dtpkdate.TabIndex = 7;
            this.dtpkdate.ValueChanged += new System.EventHandler(this.dtpkdate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Độ Ưu Tiên";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtut
            // 
            this.txtut.Location = new System.Drawing.Point(165, 421);
            this.txtut.Name = "txtut";
            this.txtut.Size = new System.Drawing.Size(121, 29);
            this.txtut.TabIndex = 8;
            this.txtut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtut_KeyPress);
            // 
            // btnyc
            // 
            this.btnyc.Location = new System.Drawing.Point(16, 505);
            this.btnyc.Name = "btnyc";
            this.btnyc.Size = new System.Drawing.Size(219, 63);
            this.btnyc.TabIndex = 9;
            this.btnyc.Text = "Tạo Yêu Cầu";
            this.btnyc.UseVisualStyleBackColor = true;
            this.btnyc.Click += new System.EventHandler(this.btnyc_Click);
            // 
            // btninan
            // 
            this.btninan.Location = new System.Drawing.Point(320, 505);
            this.btninan.Name = "btninan";
            this.btninan.Size = new System.Drawing.Size(219, 63);
            this.btninan.TabIndex = 10;
            this.btninan.Text = "In Yêu Cầu";
            this.btninan.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FRMYeuCauSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMYeuCauSanXuat";
            this.Text = "FRMYeuCauSanXuat";
            this.Load += new System.EventHandler(this.FRMYeuCauSanXuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cblohang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtut;
        private System.Windows.Forms.DateTimePicker dtpkdate;
        private System.Windows.Forms.DateTimePicker dtpkyc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btninan;
        private System.Windows.Forms.Button btnyc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}