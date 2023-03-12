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


