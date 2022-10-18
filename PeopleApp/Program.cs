using paackt.Shared;
using static System.Console;

person jack = new();//instansiasi Object dari class person dan menjadikan person sebagai deklarasi
jack.nama = "Ridho";
jack.tanggalLahir = new System.DateTime(2002,07,26);
jack.jk = gender.pria;

WriteLine(format: "{0} lahir pada tanggal {1: d MMMM yyyy} dan berjenis kelamin {2}", arg0: jack.nama, arg1: jack.tanggalLahir, arg2: jack.jk);

(string, int) buah =
