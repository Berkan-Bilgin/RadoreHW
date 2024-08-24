// See https://aka.ms/new-console-template for more information
using AttributeExample;

Console.WriteLine("Hello, World!");


Ogrenci ogrenci = new()
{
    adi = "Mehmet",
    soyadi = "Gökyar",
    bolum = "elektrik",
    sinif = "3-A"



};

Console.WriteLine(ogrenci.adi);


if (!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("ögrenci bilgileri girilmesi zorunludur");
}
else
{
    Console.WriteLine("Form başarılı.");
}