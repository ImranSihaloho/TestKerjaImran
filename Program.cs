using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKerjaImran
{
    //Program utama
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceOperation employeeOps = new Action();

            // Data karyawan Menggunakan HardCode
            var karyawan1 = new Karyawan("1001", "Adit", new DateTime(1954, 8, 17));
            var karyawan2 = new Karyawan("1002", "Anton", new DateTime(1954, 8, 18));
            var karyawan3 = new Karyawan("1003", "Amir", new DateTime(1954, 8, 19));

            // Menambahkan data karyawan
            employeeOps.TambahKaryawan(karyawan1);
            employeeOps.TambahKaryawan(karyawan2);
            employeeOps.TambahKaryawan(karyawan3);

            // Menampilkan data karyawan
            employeeOps.TampilkanKaryawan();

            // Menghapus data karyawan dengan Id 1002
            employeeOps.HapusKaryawan("1002");

            // Menampilkan data karyawan setelah Penghapusan
            employeeOps.TampilkanKaryawan();

            Console.ReadKey();
        }
    }
}
