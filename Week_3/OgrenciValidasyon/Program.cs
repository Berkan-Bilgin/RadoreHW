// See https://aka.ms/new-console-template for more information
using AttributeExample;

Console.WriteLine("Hello, World!");


Ogrenci ogrenci = new Ogrenci();

ogrenci.sinif = "4-A";
ogrenci.adi = "mahmut";
ogrenci.bolum = "elektrik";
ogrenci.soyadi = "yılmaz";


if (!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("ögrenci bilgileri girlmesi zorunldur");
}
else
{
    Console.WriteLine("form basarili");
}