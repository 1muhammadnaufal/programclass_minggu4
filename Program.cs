using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minggu4
{
    class program
    {
        static void Main(string[] arg)
        {
            mahasiswa mahasiswa1 = new minggu4.mahasiswa();
            mahasiswa1.nama = "muhammad naufal ihza";
            mahasiswa1.nim = "22.11.4868";
            mahasiswa1.kelas = "if 05";
            mahasiswa1.jurusan = "informatika";
            mahasiswa1.ipk = 7f;
            mahasiswa1.infomahasiswa();
            Console.ReadLine();
        }
    }
}
