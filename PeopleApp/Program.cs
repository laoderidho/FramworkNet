using paackt.Shared;
using static System.Console;


person ms4 = new(){
    nama = "Ridho",
    Hometown = "Bandung",
    tanggalLahir = new(2002, 6, 5)
};

WriteLine(ms4.Asal);
Write($"Sekarang Berumur{ms4.usia}");
