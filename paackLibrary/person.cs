using System;
using static System.Console;

namespace paackt.Shared;

    public class person: System.Object{ //system object menjadi parent dan di wariskan jika ada yang memanggil classnya dari luar
        public string nama;
        public DateTime tanggalLahir;
        public gender jk; //object dari enum gender yang menyatakan jenis kelamin
        
    // contoh field penamaan dalam tuple 

    public(string, int)GetFruit(){
        return ("apple", 44);
    }
    }

