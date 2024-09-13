using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThaiTai_Buoi3
{
    internal class SinhVien
    {
        public int Mssv;
        public string Hoten = "";
        public string Ngaysinh = "";
        public string Sdt = "";
        public string Gioitinh = "";

        public void setMssv(int Mssv)
        {
            this.Mssv = Mssv;
        }

        public int getMssv()
        {
            return this.Mssv;
        }

        public void setHoten (string Hoten)
        {
            this.Hoten = Hoten;
        }

        public string getHoten()
        {
            return this.Hoten;
        }

        public void setNgaysinh(string Ngaysinh)
        {
            this.Ngaysinh = Ngaysinh;
        }

        public string getNgaysinh()
        {
            return this.Ngaysinh;
        }

        public void setSdt(string Sdt)
        {
            this.Sdt = Sdt;
        }

        public string getSdt()
        {
            return this.Sdt;
        }

        public void setGioitinh(string Gioitinh)
        {
            this.Gioitinh = Gioitinh;
        }

        public string getGioitinh()
        {
            return this.Gioitinh;
        }
    }
}
