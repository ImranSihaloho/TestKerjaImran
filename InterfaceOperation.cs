using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKerjaImran
{
    // interface for operation
    interface InterfaceOperation
    {
        // Method untuk menambahkan Data karyawan baru yang parameternya adalah objek dari kelas Karyawan
        void TambahKaryawan(Karyawan karyawan);

        // Method untuk menghapus karyawan berdasarkan ID
        void HapusKaryawan(string employeeID);

        // Method untuk menampilkan daftar karyawan
        void TampilkanKaryawan();

    }
}
