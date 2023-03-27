using System;
using System.Diagnostics.Metrics;

public class Mobil
{
    //propertis
    public string Warna { get; set; }
    public int JumlahPintu { get; set; }
    public string Merk { get; set; }
    public string Model { get; set; }
    public int TahunKeluar { get; set; }

    //method
    public void Gas(int kecepatan)
    {
        Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}", Model, kecepatan);
    }
    public void Klakson()
    {
        Console.WriteLine("dengan klakson tooooooooot");
    }

    public void tampilkaninfo()
    {
        Console.WriteLine("Mobil saya berwarna {0},merek {1} model {2} keluaran tahun {3} dengan jumlah pintu sebanyak {4}\n", Warna, Merk, Model, TahunKeluar, JumlahPintu);
    }

}
