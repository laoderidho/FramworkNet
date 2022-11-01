using System;
using static System.Console;

// namespace Packt.Shared{

// }

namespace Packt.Shared;
public class Person : System.Object
{
    public string nama;
    public DateTime tanggalLahir;
    public gender jk; //object dari enum gender yang menyatakan jenis kelamin
    public const string Species = "Manusia";
    public readonly string HomeTown = "Bandung";

    public Person(){
        nama = "unknown"; //nilai awal dari variabel/field nama
        tanggalLahir = DateTime.Now;
    } //constructor pertama dari kelas person

    public Person(string nama_manusia, string asal, DateTime dob){
        nama = nama_manusia;
        HomeTown = asal;
        tanggalLahir = dob;
    } //constructor kedua dari kelas person

    //contoh multiple 

    public (string jenis_kelamin, int jumlah) GetSiblings(){
        return ("Perempuan", 2);
    }
}