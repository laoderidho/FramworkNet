using static System.Console; //menyingkat agar console tidak di ketik

Write("Berapa jumlah mahasiswa yang hadir di kelas =");

string? input= ReadLine(); //untuk mempersilahkan input yang masuk

if(int.TryParse(input, out int count)){
    WriteLine($"Ada {count} mahasiswa yang hadir saat ini");
}else{
    WriteLine("input tidak bisa di parsing");
}

WriteLine("Sebelum Parsing");
Write("Input Usia Anda");
string? input1 = ReadLine();

try
{
    int usia = int.Parse(input1);
    WriteLine($"saat ini anda berusia {usia} Tahun");
}
catch (Exception ex)
{
    WriteLine($"Tipe Error{ex.GetType}, pesan {ex.Message}");
}