void Method(ref int refArgument){
refArgument = 44; // kita bisa mengisi kode jika memakai ref
}

int number = 20;
Method(ref number); //memanggil number sebagai isi parameter
Console.WriteLine("Ref Modifier parameter = "+number);

void Method1(in int refArgument){
    //tidak bisa di ubah untuk isi arguments nya di dalam kode
   
}

int number_one = 20;
Method1(in number_one);
Console.WriteLine("In modifier paramater = "+number_one);

void Method2(out int refArgument){
    refArgument = 12;
}

int number_two = 20;
Method2(out number_two); //ini mengambil dari void method 
Console.WriteLine("out modifier parameter = "+number_two);

