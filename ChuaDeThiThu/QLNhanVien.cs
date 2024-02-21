using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeThiThu
{
    internal class QLNhanVien
    {
        public List<NhanVien> DanhSachNhanVien { get; set; } = new List<NhanVien>();

        public void ChucNang1()
        {
            int tiepTuc = -1;
            do
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Ten: ");
                string ten = Console.ReadLine();
                Console.Write("Luong: ");
                double luong = double.Parse(Console.ReadLine());
                NhanVien nhanVien = new NhanVien(id, ten, luong);
                DanhSachNhanVien.Add(nhanVien);

                Console.Write("Ban co muon tiep tuc khong (1: co)");
                tiepTuc = int.Parse(Console.ReadLine());
            } while (tiepTuc == 1);
            
        }
    }
}
