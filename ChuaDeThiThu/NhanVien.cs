using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeThiThu
{
    internal class NhanVien
    {
        private int ID { get; set; }
        private string Ten { get; set; }
        private double Luong { get; set; }

        public NhanVien()
        {
            
        }

        public NhanVien(int iD, string ten, double luong)
        {
            ID = iD;
            Ten = ten;
            Luong = luong;
        }

        public void InThongTin()
        {
            Console.WriteLine($"{ID}\t{Ten}\t{Luong}");
        }
    }
}
