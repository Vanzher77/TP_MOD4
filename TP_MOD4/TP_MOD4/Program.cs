// See https://aka.ms/new-console-template for more information

public class KodePos
{   
    public enum kelurahan { Batununggal, Kujangsari, Mengger, Weters, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja}
    //membuat table driven 
    public static int getKodePos(kelurahan kel)
    {
        //membuat array dengan mengisi array dengan kodepos
        int[] kodepos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodepos[(int) kel];
    }
}

public class DoorMachine
{
    //Membuat State-based construction
    enum state { terkunci, terbuka};
    
    public static void Main()
    {
        //Menampilkan nama kelurahan dan kode pos kelurahan tersebut
        Console.WriteLine("Kelurahan: " + KodePos.kelurahan.Batununggal);
        Console.WriteLine("Kodepos: " + KodePos.getKodePos(KodePos.kelurahan.Batununggal));
        Console.WriteLine();

        state state1 = state.terkunci;
        //membuat perintah menggunakan string
        string[] kondisi = { "Pintu terkunci", "Pintu Terbuka" };
        while(state1 != null)
        {
            Console.WriteLine(kondisi[(int)state1]);
            Console.WriteLine();
            Console.WriteLine("Masukan Perintah: ");

            string perintah = Console.ReadLine();
            //membuat perintah dengan menggunakan if else
            switch (state1)
            {
                //membuat case terkunci
                case state.terkunci:
                    if(perintah == "Kunci Pintu")
                    {
                        state1 = state.terkunci;
                    }
                    else if(perintah == "Buka pintu")
                    {
                        state1 = state.terbuka;
                    }
                    else
                    {
                        state1 = state.terkunci;
                        Console.WriteLine("Perintah Salah");
                    }
                    Console.WriteLine();
                    //break agar perulangan berhenti saat menjalankan perintah
                    break;
                //membuat case terbuka
                case state.terbuka:
                    if(perintah == "Kunci Pintu")
                    {
                        state1 = state.terkunci;
                    }
                    else if(perintah == "Buka Pintu")
                    {
                        state1 = state.terbuka;
                    }
                    else
                    {
                        state1 = state.terbuka;
                        Console.WriteLine("Perintah Salah");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}
