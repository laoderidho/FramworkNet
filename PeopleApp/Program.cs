// See https://aka.ms/new-console-template for more information
using Packt.Shared;
using static System.Console;

Person ms = new(); //inisialisasi objek dari kelas person

ms.nama = "Johansen Sagala";
ms.tanggalLahir = new System.DateTime(2001,06,05);
ms.jk = gender.Pria;

// WriteLine(format: "{0} lahir pada tanggal {1: d MMMM yyyy} berjenis kelamin {2}", arg0: ms.nama, arg1: ms.tanggalLahir, arg2: ms.jk);

Person ms2 = new();
ms2.jk = gender.Pria;
WriteLine(format: "{0} lahir pada tanggal: {1: d MMMM yyyy}, dan berasal dari {2}",
arg0: ms2.nama,
arg1: ms2.tanggalLahir,
arg2: ms2.HomeTown);

Person ms3 = new(nama_manusia:"Meilani", asal:"Depok", dob: new System.DateTime(2002,05,09));
ms3.tanggalLahir = new System.DateTime(2002,05,09);
WriteLine(format: "{0} lahir pada tanggal: {1: d MMMM yyyy}, dan berasal dari {2}",
arg0: ms3.nama,
arg1: ms3.tanggalLahir,
arg2: ms3.HomeTown);

var saudara = ms3.GetSiblings();
WriteLine($"{ms3.nama} memiliki {saudara.jumlah} saudara {saudara.jenis_kelamin}");