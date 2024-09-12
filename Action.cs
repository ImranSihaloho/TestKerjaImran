using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKerjaImran
{
    //Kelas Untuk Operasi CRUD
    internal class Action : InterfaceOperation
    {
        // List untuk menyimpan data karyawan
        private List<Karyawan> daftarKaryawan = new List<Karyawan>();

        // Menambah Data karyawan (validasi duplikat dan null)
        public void TambahKaryawan(Karyawan karyawan)
        {
            // Validasi apakah objek karyawan, EmployeeID, atau FullName tidak null atau kosong
            if (karyawan == null || string.IsNullOrEmpty(karyawan.EmployeeID) || string.IsNullOrEmpty(karyawan.FullName))
            {
                // Statemen jika validasi gagal, pesan error dan keluar dari method
                Console.WriteLine("Error: Data karyawan tidak boleh kosong.");
                return;
            }

            if (daftarKaryawan.Any(k => k.EmployeeID == karyawan.EmployeeID))
            {
                // Statemen jika EmployeeID sudah ada untuk menghindari duplikasi data
                Console.WriteLine("Error: EmployeeID sudah ada.");
                return;
            }

            // Jika validasi lolos, maka data akan tertambah ke daftar
            daftarKaryawan.Add(karyawan);
            //Pesan jika data berhasil di tambah
            Console.WriteLine($"Karyawan {karyawan.FullName} berhasil ditambahkan.");
        }

        // Menghapus karyawan berdasarkan id
        public void HapusKaryawan(string employeeID)
        {
            //Mencari id karyawan yang sesuai di daftar
            var karyawan = daftarKaryawan.FirstOrDefault(k => k.EmployeeID == employeeID);

            //jika id tidak ada atau null maka akan memunculkan pesan eror
            if (karyawan == null)
            {
                Console.WriteLine("Error: Karyawan dengan EmployeeID tersebut tidak ditemukan.");
                return;
            }

            //jika id karyawan di temukan maka akan menghapus data karyawan dengan id yang kita tentukan
            daftarKaryawan.Remove(karyawan);

            //pesan sukses
            Console.WriteLine($"Karyawan dengan EmployeeID {employeeID} berhasil dihapus.");
        }

        // Menampilkan semua Data karyawan dalam format tabel 
        public void TampilkanKaryawan()
        {
            //Tabel bagian atas
            Console.WriteLine("\nOutput Daftar Karyawan:");
            Console.WriteLine("=====================================");
            Console.WriteLine("| EmployeeID | FullName   | BirthDate  |");
            Console.WriteLine("=====================================");

            //perulangan untuk menampilkan data karyawan
            foreach (var k in daftarKaryawan)
            {
                // Menampilkan Output Yang berupa Data Karyawan
                Console.WriteLine($"| {k.EmployeeID,-9} | {k.FullName,-9} | {k.BirthDate:dd-MMM-yy} |");
            }
            //tabel bagian bawah
            Console.WriteLine("=====================================\n");
        }
    }
}
