namespace _18753002_Contact
{
    partial class FormContact
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataMahasiswa = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_Kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTempat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTlp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textJK = new System.Windows.Forms.TextBox();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(189, 394);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataMahasiswa
            // 
            this.dataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.Jenis_Kelamin,
            this.No_Telp,
            this.Email,
            this.Alamat});
            this.dataMahasiswa.Location = new System.Drawing.Point(6, 16);
            this.dataMahasiswa.Name = "dataMahasiswa";
            this.dataMahasiswa.Size = new System.Drawing.Size(472, 205);
            this.dataMahasiswa.TabIndex = 0;
            this.dataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMahasiswa_CellClick);
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // Jenis_Kelamin
            // 
            this.Jenis_Kelamin.HeaderText = "Jenis Kelamin";
            this.Jenis_Kelamin.Name = "Jenis_Kelamin";
            // 
            // No_Telp
            // 
            this.No_Telp.HeaderText = "No Telp.";
            this.No_Telp.Name = "No_Telp";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Alamat
            // 
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.Name = "Alamat";
            // 
            // textTempat
            // 
            this.textTempat.AutoSize = true;
            this.textTempat.Location = new System.Drawing.Point(15, 88);
            this.textTempat.Name = "textTempat";
            this.textTempat.Size = new System.Drawing.Size(48, 13);
            this.textTempat.TabIndex = 3;
            this.textTempat.Text = "No Telp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(7, 394);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(98, 394);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(116, 18);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(171, 20);
            this.textNama.TabIndex = 7;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(116, 119);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(171, 20);
            this.textEmail.TabIndex = 11;
            // 
            // textTlp
            // 
            this.textTlp.Location = new System.Drawing.Point(116, 85);
            this.textTlp.Name = "textTlp";
            this.textTlp.Size = new System.Drawing.Size(171, 20);
            this.textTlp.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataMahasiswa);
            this.groupBox2.Location = new System.Drawing.Point(315, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 237);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(714, 394);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 20;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textJK);
            this.groupBox1.Controls.Add(this.textAlamat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textTlp);
            this.groupBox1.Controls.Add(this.textNama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textTempat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 237);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // textJK
            // 
            this.textJK.Location = new System.Drawing.Point(116, 50);
            this.textJK.Name = "textJK";
            this.textJK.Size = new System.Drawing.Size(171, 20);
            this.textJK.TabIndex = 19;
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(116, 154);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(171, 20);
            this.textAlamat.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "CONTACT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bantuanToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.bantuanToolStripMenuItem.Text = "Bantuan";
            this.bantuanToolStripMenuItem.Click += new System.EventHandler(this.bantuanToolStripMenuItem_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(415, 113);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(171, 20);
            this.textSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(321, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearch_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(7, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.Color.DodgerBlue;
            this.Select.FlatAppearance.BorderSize = 0;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.ForeColor = System.Drawing.Color.White;
            this.Select.Location = new System.Drawing.Point(7, 118);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(108, 23);
            this.Select.TabIndex = 28;
            this.Select.Text = "Select Picture";
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormContact";
            this.Text = "FormContact";
            this.Load += new System.EventHandler(this.FormContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataMahasiswa;
        private System.Windows.Forms.Label textTempat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTlp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_Kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.TextBox textJK;
    }
}