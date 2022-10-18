using System;
using static System.Console;

namespace paackt.Shared;

    public partial class person: System.Object{ //system object menjadi parent dan di wariskan jika ada yang memanggil classnya dari luar
        public string nama;
        public DateTime tanggalLahir;
        public gender jk; //object dari enum gender yang menyatakan jenis kelamin
        public string Hometown;
   public person(){
        nama = "unknown"; //nilai awal dari variabel/field nama
        tanggalLahir = DateTime.Now;
    } //constructor pertama dari kelas person

    public person(string nama_manusia, string asal, DateTime dob){
        nama = nama_manusia;
        Hometown = asal;
        tanggalLahir = dob;
    } //constructor kedua dari kelas person

    //contoh multiple 

    public (string jenis_kelamin, int jumlah) GetSiblings(){
        return ("Perempuan", 2);
    }
    
    }

