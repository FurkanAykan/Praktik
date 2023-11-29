// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// değişken adları rakamla başlamaz
// büyük küçük harf duyarlılığı vardır 
// class ve namespace isimleri verilemez
// aynı blok içerisinde aynı isimle  değişken tanımlanamaz
// işlem operatörleri içeremez  

// DEĞİŞKEN TİPLERİ 

///
///     STRİNG
///     stringe null atama yapıla bilir.
///  
///     BYTE
///     bellek de 1 byte yer kaplar
///     0-255 arası
///  
///     SBYTE
///     belekte 1 byte yer kaplar
///     -128 ve 127 arasında değer alır
///  
///     SHORT
///     bellekte 2 byte yer kaplar
///     -32768 +32768 arasında değer alır tam sayı değerler alır
///  
/// 
///     ushort
///     2 byte yer kaplar 
///     0 65365 arasında tam sayı değerleri alır ama pozitifdir.
/// 
///     int 16 
///     bellekde 2byte yer kaplar
///     
///     İNT 
///     belekte 4 byte yer kaplar 
///     -2 milyar + 2 milyar arası kaplar
///     
///     int32 
///     bellekte 4 byte yer kaplar
///     -2 milyar + 2 milyar arası kaplar
///         
///     int 64 
///     belekte 8 byte yer kaplar
///     
///     uint 
///     bellekte 4 byte yer kaplar pozitif değer alır
///     
///     long 
///     8byte yer kaplar inti kapsar
///     
///     ulong 
///     long gibi pozitif değer alır sadece
///     
///     float
///     tam sayı ve reel sayı tutar virgüllü sayılar
///     bellkete 4 byte yer
///     
///     double 
///     8 byte 
///     reel sayı tutar
///     
///     char 
///     '' tek tırnakla kullan 
///     tek karakter alır
///     2 byte olarak kullanılır.
///     
///     string 
///     "" çift tırnakla kullan
///     herşeyi alır
///     
///     bool 
///     true false tutar
///     
///     datetime
///     DateTime de  = DateTime.Now  = şimdiki zamanı verir mesela 
///     
///     object o1 = "x";
///     object o2 ='c';
///     object o3 = 4;
///     object o4 =4.3;
///     objeler her türden veriyi tutar için de. !!! 
///     üst bir türdür. 
///     
string str1  = string.Empty; // boş değer
str1 ="furkan aykan";
string name ="furkan";
string surname ="aykan";
string fullName = name+" "+surname;

int int1 = 5;
int int2 =3;
int int3 = int1*int2;


bool _deger = 10 < 2; // false ataması oldu 

// değişken dönüşümleri

string donusum  ="20";
int int20 = 20;

string newChar = donusum + int20.ToString(); // 2020 çıktısını verir.


int deger  = int20 + Convert.ToInt32(donusum); // 40 sonucunu verir.

int deger2 = int20+int.Parse(donusum); // 40 sonucunu verir.

string date = DateTime.Now.ToString("dd.MM.yyyy"); // tarihi formatla ver 
string date1 = DateTime.Now.ToString("dd/MM/yyyy"); // tarihi / formatıyla ver 
string date2 = DateTime.Now.ToString("HH:mm"); // saati getir
