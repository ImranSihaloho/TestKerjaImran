using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKerjaImran
{
    internal class Karyawan
    {
        public string EmployeeID { get; set; } //Properti Yang berguna untuk menyimpan ID unik karyawan
        public string FullName { get; set; } // Properti untuk menyimpan nama lengkap karyawan
        public DateTime BirthDate { get; set; } // properti untuk menyimpan tanggal lahir karyawan


        //Constructor yang berguna untuk menginisialisasi properti saat objek Karyawan dibuat
        public Karyawan(string employeeID, string fullName, DateTime birthDate)
        {
            // Inisialisasi EmployeeID dengan nilai parameter yang diberikan
            EmployeeID = employeeID;
            // Inisialisasi FullName dengan nilai parameter yang diberikan
            FullName = fullName;
            // Inisialisasi BirthDate dengan nilai parameter yang diberikan
            BirthDate = birthDate;
        }
    }
}
