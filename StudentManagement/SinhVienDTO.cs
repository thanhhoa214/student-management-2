using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class SinhVienDTO
    {
        private String name;
        private int masv;
        private int year;
        private String makhoa;

        public SinhVienDTO(string name, int masv, int year, string makhoa)
        {
            this.name = name;
            this.masv = masv;
            this.year = year;
            this.makhoa = makhoa;
        }

        public SinhVienDTO()
        {
        }
        public string Name { get => name; set => name = value; }
        public int Masv { get => masv; set => masv = value; }
        public int Year { get => year; set => year = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
    }
}
