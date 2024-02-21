using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeThiThu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            QLNhanVien qLNhanVien = new QLNhanVien();
            int luaChon = -1;
            do
            {
                Console.WriteLine("Quan Ly Nhan Vien");
                Console.WriteLine("1. Nhap 1 hoac nhieu nhan vien");
                Console.WriteLine("2. Xuat danh sach nhan vien");
                Console.WriteLine("3. Xuat danh sach nhan vien theo luong");
                Console.WriteLine("4. Tim nhan vien theo ID");
                Console.WriteLine("0. Thoat");
                Console.Write("Xin moi lua chon: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        qLNhanVien.ChucNang1();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap khong hop le.");
                        break;
                }
            } while (luaChon != 0);
            
        }
    }
}
