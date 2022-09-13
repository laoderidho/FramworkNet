// See https://aka.ms/new-console-template for more information
/*
string[] names;

names= new string[4];

//menyimpan value berdasarkan masing" index array 

// names[0] = "Ridho";
// names[1] = "Fahreza"; 
// names[2] = "La Ode";
// names[3] = "La Ode Ridho Fahreza"; 

string[] nama = new[] {"Reza", "Affa", "Fix", "Fahreza"}; //cara simple

for(int i =0; i<names.Length; i++){
    Console.WriteLine(nama[i]);
}
*/
//contoh Numbered Positional Arguments

int jumlahApple = 12;
decimal hargaApple = 0.35M; //menyatakan nilainya decimal
            //format{0} dan {1} adalah format dalam deklarasi variable pertama dan kedua 
Console.WriteLine(format: "{0} apples harganya {1:C}", arg0: jumlahApple, arg1: hargaApple * jumlahApple);

string contohFormat = string.Format(format: "{0} apples harganya {1:C}", arg0: jumlahApple, arg1: hargaApple * jumlahApple);
Console.WriteLine(contohFormat);

//interpolated string 
//contoh 
Console.WriteLine($"{jumlahApple} apel harganya {hargaApple*jumlahApple:C}");


//Getting text Input from user 

// Console.WriteLine("Input Nama dan tekan Enter");
// string? nama = Console.ReadLine();//readline membuat input 

// Console.Write("Input Usia anda dan tekan enter");
// string? usia = Console.ReadLine(); 

// Console.WriteLine($"Hello {nama}, anda berumur {usia}.");

//read key

// Console.Write("Tekan Tombol apapun dari keyboard");
// ConsoleKeyInfo key = Console.ReadKey();
// Console.WriteLine();
// Console.WriteLine("Key {0}, Char:{1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);

//Statemen conditional 

//using if Statement 

string pass = "Fahrezaoiusba";
if(pass.Length<8){
    Console.WriteLine("Password harus 8 karakter");
}else{
    Console.WriteLine($"Selamat datang {pass}");
}

//pattern matching using if statement

object o= 3;
int j =4;

if(o is int i){
    Console.WriteLine($"{i} x {j} = {i*j}");
}else{
    Console.WriteLine("Object Bukan Bilangan Bulat");
}

