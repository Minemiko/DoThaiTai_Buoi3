namespace DoThaiTai_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setCd(int.Parse(txtCd.Text));
            hinhChuNhat.setCr(int.Parse(txtCr.Text));

            MessageBox.Show("Chiều dài: " + hinhChuNhat.getCd() + "\nChiều rộng: " + hinhChuNhat.getCr());
        }

        private void btnKt2_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.setMssv(int.Parse(txtMs.Text));
            sinhVien.setHoten(txtHt.Text);
            sinhVien.setNgaysinh(txtNs.Text);
            sinhVien.setSdt(txtSdt.Text);
            sinhVien.setGioitinh(txtGt.Text);

            MessageBox.Show("MSSV: " + sinhVien.getMssv() +
                            "\nHọ và tên: " + sinhVien.getHoten() +
                            "\nNgày sinh: " + sinhVien.getNgaysinh() +
                            "\nSđt: " + sinhVien.getSdt() +
                            "\nGiới tính: " + sinhVien.getGioitinh());
        }
    }
}
