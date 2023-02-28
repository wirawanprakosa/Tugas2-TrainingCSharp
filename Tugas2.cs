using System;

public class Mutu
{
    static void Main (string[] args)
    {
        Console.Write("Pilih Mutu/Nilai : ");
        string pilih = Console.ReadLine();
        string mutu;
        int nilai;

        if(pilih.ToLower() == "mutu")
        {
            Console.Write("Masukkan Huruf Mutu : ");
            mutu = Console.ReadLine();

            switch(mutu)
            {
                case "A":
                    Console.WriteLine("Kategori : Sangat Baik");
                    break;
                case "B":
                    Console.WriteLine("Kategori : Baik");
                    break;
                case "C":
                    Console.WriteLine("Kategori : Cukup");
                    break;
                case "D":
                    Console.WriteLine("Kategori : Kurang");
                    break;
                case "E":
                    Console.WriteLine("Kategori : Sangat Kurang");
                    break;
                default:
                    Console.WriteLine("Tidak ada kategori dengan huruf mutu tersebut");
                    break;
            }
        }
        else if(pilih.ToLower() == "nilai")
        {
            Console.Write("Masukkan Nilai : ");
            nilai = Convert.ToInt32(Console.ReadLine());

            if(nilai>=80)
            {
                Console.WriteLine("Kategori : Sangat Baik");
            }
            else if(nilai>=70 && nilai < 80)
            {
                Console.WriteLine("Kategori : Baik");
            }
            else if(nilai>=60 && nilai < 70)
            {
                Console.WriteLine("Kategori : Cukup");
            }
            else if(nilai>=40 && nilai < 60)
            {
                Console.WriteLine("Kategori : Kurang");
            }
            else if(nilai<40)
            {
                Console.WriteLine("Kategori : Sangat Kurang");
            }
        }
        else
        {
            Console.WriteLine("Inputan hanya ada nilai/mutu");
        }
    }
}