using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minggu4
{
    internal class mahasiswa
    {
        private string _nama;
        private string _nim;
        private string _kelas;
        private string _jurusan;
        private float _ipk;

        public string nama
        {
            get
            { return _nama;}
            set
            { _nama = value;}
        }

        public string nim
        {
            get
            { return _nim;}
            set
            { _nim = value; }
        }

        public string kelas
        {
            get { return _kelas;}
            set { _kelas = value;}    
        }

        public string jurusan
        {
            get { return _jurusan; }
            set { _jurusan = value;}
        }

       public float ipk
        {
            get { return _ipk;}
            set { _ipk = value;}
        }


        public void infomahasiswa()
        {
            Console.WriteLine(".......... profil mahasiswa ...........");
            Console.WriteLine("nama mahasiswa : {0}", nama);
            Console.WriteLine("nim mahasiswa : {0}", nim);
            Console.WriteLine("kelas mahasiswa : {0}", kelas);
            Console.WriteLine("jurusan mahasiswa : {0}", jurusan);
            Console.WriteLine("nilai mahasiswa : {0}", ipk);

            if (ipk < 3)
            {
                Console.WriteLine("(ipk mu rendah)");
            }
            else if (ipk <= 4)
            {
                Console.WriteLine("(ipk gege!)");
            }
            else
            {
                Console.WriteLine("(hmmmm... ipkmu di luar nalar)");
            }
        }

    
    }
}
