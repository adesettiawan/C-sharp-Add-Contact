using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18753002_Contact
{
    public partial class FormContact : Form
    {
        int indexRow;
        public FormContact()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            string teks = textNama.Text;
            if (teks == "")
            {
                MessageBox.Show("Data Tidak Lengkap!");
                textNama.Focus();
            }
            else
            {
                textNama.Text = teks.ToUpper();
            }
            if (textJK.Text == "")
            {
                MessageBox.Show("Data Tidak Lengkap!");
                textJK.Focus();
            }
            if (textAlamat.Text == "")
            {
                MessageBox.Show("Data Tidak Lengkap!");
                textAlamat.Focus();
            }
            if (textTlp.Text == "")
            {
                MessageBox.Show("Data Tidak Lengkap!");
                textTlp.Focus();
            }
            if (textEmail.Text == "")
            {
                MessageBox.Show("Data Tidak Lengkap!");
                textEmail.Focus();
            }

            int baris = 0;
            dataMahasiswa.Rows.Add();
            baris = dataMahasiswa.Rows.Count - 2;

            dataMahasiswa[0, baris].Value = dataMahasiswa.Rows.Count - 1;
            dataMahasiswa["Nama", baris].Value = textNama.Text;
            dataMahasiswa["Jenis_Kelamin", baris].Value = textJK.Text;
            dataMahasiswa["No_Telp", baris].Value = textTlp.Text;
            dataMahasiswa["Email", baris].Value = textEmail.Text;
            dataMahasiswa["Alamat", baris].Value = textAlamat.Text;

            textNama.Text = "";
            textTlp.Text = "";
            textJK.Text = "";
            textAlamat.Text = "";
            textEmail.Text = "";


        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dataMahasiswa.SelectedRows.Count > 0)
            {
                dataMahasiswa.Rows.RemoveAt(this.dataMahasiswa.SelectedRows[0].Index);
            };
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe Me = new AboutMe();
            Me.Show();
            this.Hide();
        }

        private void bantuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bantuan help = new Bantuan();
            help.Show();
            this.Hide();
        }

        private void dataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataMahasiswa.Rows[indexRow];

            textNama.Text = row.Cells[0].Value.ToString();
            textJK.Text = row.Cells[1].Value.ToString();
            textTlp.Text = row.Cells[2].Value.ToString();
            textEmail.Text = row.Cells[3].Value.ToString();
            textAlamat.Text = row.Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataMahasiswa.Rows[indexRow];
            newDataRow.Cells[0].Value = textNama.Text.ToUpper();
            newDataRow.Cells[1].Value = textJK.Text;
            newDataRow.Cells[2].Value = textTlp.Text;
            newDataRow.Cells[3].Value = textEmail.Text;
            newDataRow.Cells[4].Value = textAlamat.Text;
        }

        private void FormContact_Load(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG | *.Jpg", ValidateNames = true, Multiselect = false })
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ((DataTable)dataMahasiswa.DataSource).DefaultView.RowFilter = string.Format("Name like '%{0}%'", textSearch.Text.Trim().Replace("'", "''"));
            }
            catch (Exception) { }
        }
    }
    }
    

