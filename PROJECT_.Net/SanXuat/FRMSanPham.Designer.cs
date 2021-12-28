
namespace PROJECT_.Net.SanXuat
{
    partial class FRMSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cblohang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.btnsuasp = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnxoasp = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btndinhmua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(431, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm";
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
            this.dataGridView1.Size = new System.Drawing.Size(423, 547);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lô Hàng";
            // 
            // cblohang
            // 
            this.cblohang.FormattingEnabled = true;
            this.cblohang.Location = new System.Drawing.Point(569, 19);
            this.cblohang.Name = "cblohang";
            this.cblohang.Size = new System.Drawing.Size(332, 31);
            this.cblohang.TabIndex = 2;
            this.cblohang.SelectedIndexChanged += new System.EventHandler(this.cblohang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(569, 99);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(332, 29);
            this.txttensp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn Giá";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(569, 183);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(224, 29);
            this.txtdongia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Lượng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(569, 269);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(132, 29);
            this.txtsoluong.TabIndex = 3;
            this.txtsoluong.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnthemsp
            // 
            this.btnthemsp.Location = new System.Drawing.Point(442, 346);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(200, 53);
            this.btnthemsp.TabIndex = 4;
            this.btnthemsp.Text = "Thêm Sản Phẩm";
            this.btnthemsp.UseVisualStyleBackColor = true;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // btnsuasp
            // 
            this.btnsuasp.Location = new System.Drawing.Point(701, 346);
            this.btnsuasp.Name = "btnsuasp";
            this.btnsuasp.Size = new System.Drawing.Size(200, 53);
            this.btnsuasp.TabIndex = 4;
            this.btnsuasp.Text = "Sủa Sản Phẩm";
            this.btnsuasp.UseVisualStyleBackColor = true;
            this.btnsuasp.Click += new System.EventHandler(this.btnsuasp_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(701, 433);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(200, 53);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Làm Mới";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnxoasp
            // 
            this.btnxoasp.Location = new System.Drawing.Point(442, 433);
            this.btnxoasp.Name = "btnxoasp";
            this.btnxoasp.Size = new System.Drawing.Size(200, 53);
            this.btnxoasp.TabIndex = 4;
            this.btnxoasp.Text = "Xoá Sản Phẩm";
            this.btnxoasp.UseVisualStyleBackColor = true;
            this.btnxoasp.Click += new System.EventHandler(this.btnxoasp_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(442, 512);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(200, 53);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Huỷ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndinhmua
            // 
            this.btndinhmua.Location = new System.Drawing.Point(701, 512);
            this.btndinhmua.Name = "btndinhmua";
            this.btndinhmua.Size = new System.Drawing.Size(200, 53);
            this.btndinhmua.TabIndex = 4;
            this.btndinhmua.Text = "Định Mức";
            this.btndinhmua.UseVisualStyleBackColor = true;
            this.btndinhmua.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.btnsuasp);
            this.Controls.Add(this.btndinhmua);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoasp);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnthemsp);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cblohang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMSanPham";
            this.Text = "FRMSanPham";
            this.Load += new System.EventHandler(this.FRMSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cblohang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.Button btnsuasp;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnxoasp;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndinhmua;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}