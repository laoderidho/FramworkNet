namespace paackt.Shared{
    public partial class person{
        public string Asal{ //contoh Untuk mendefinisikan Property di c#
            get{
                return $"{nama} lahir di{Hometown}";
            }
        }
             public int usia => System.DateTime.Today.Year - tanggalLahir.Year;
        }
       
    }
