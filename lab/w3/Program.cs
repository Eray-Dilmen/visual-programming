using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace w3
{
    internal class Program
    {
        class Student
        {
            public string name;
            public int age;
        }


        class Car
        {
            public string model;
            public string name;
            public int year;

            // creating class constructor (same name) 

            public Car( string carModel, string carName, int carYear)
            {
                model = carModel;
                name = carName;
                year = carYear;
            }

            public override string ToString()
            {
                return $"Model: {model}, Name: {name}, Year: {year}"; // constructordaki değişken isimlerini alıyoruz.
            }
        }


        static void Main(string[] args)
        {


            ///  Parameter vs Argument

            /*
            - Parameter (Parametre): Metot tanımlanırken parantez içine yazılan değişken şablonudur (mailbox / posta kutusu).
            - Argument (Argüman): Metot çağrılırken parametreye gönderilen gerçek değerdir (letter / mektup). */

            // 'name' ve 'age' birer PARAMETER'dır (metot tanımı)
            /*
            static void PrintStudent(string name, int age)
            {
                Console.WriteLine(name);
                Console.WriteLine(age);
            } 
            */

            // "Ahmed" ve 21 birer ARGUMENT'tır (çağrılırken gönderilen gerçek değerler)
            // PrintStudent("Ahmed", 21);





            /// Recursive Method 


            /* Bir metodun belirli bir durma koşuluna (base case) kadar kendi kendini çağırmasıdır.

            public class Program
            {
            // Faktöriyel hesabı: num 1 olana kadar metot kendini azaltarak çağırır
                public int factorial(int num)
                {
                    if (num == 1) // Base case (durma koşulu)
                        {
                            return 1; 
                        }
                    else
                        {
                            return factorial(num - 1) * num; // Recursive call (kendini çağırma)
                        }
                 }
            }

         Kullanımı:
         Program n = new Program();
         n.factorial(6); // 720 döner
        */






            /// OOP ///

            /* 4 farklı terimimiz var;
            Inheritance (miras alma)     : Kodun yeniden kullanımı ve hiyerarşi oluşturma.
            Polymorphism (çok biçimlilik): Aynı metot isminin farklı şekillerde davranabilmesi.
            Abstraction (soyutlama)      : Karmaşıklığı gizleyip sadece temel işlevi sunma.
            Encapsulation (kapsülleme)   : Veriyi ve erişimi koruma, dış dünyaya sınır koyma. 
            

            Temel OOP Yapı Taşları:
            Class: Nesneleri üretmek için kullanılan genel şablon / taslak.
            Attribute: Nesnenin sahip olduğu veriler ve durum bilgisi.
            Method: Nesnenin yapabildiği işler, eylemler ve operasyonlar.
            */

            Student s1 = new Student();
            s1.age = 20;
            s1.name = "Eray";

            Console.WriteLine("1.öğrencinin adı: " + s1.name + ", Yaşı: " + s1.age);
            // class'ın dışarısından attribute'lara erişebilmek için attribute'ları "public" olarak belirtmemiz gerekir yoksa varsayılan olarak private olarak gelir ve erişemeyiz.
            // veya daha doğru bir yöntem olan "encapsulation" u uygulayacağız. Ona daha sonra geleceğiz.




            /// Constructors

            /* sınıftan nesne örneği (instance) oluşturulduğunda otomatik olarak çağrılan özel metottur.
               Temel amacı: Nesnenin alanlarını (field/properties) uygun başlangıç değerleriyle başlatarak tutarlı bir durumda (consistent state) olmasını sağlamaktır.

               1. Constructor ismi, sınıf ismi ile birebir aynı olmak zorundadır.
               2. Geri dönüş tipi (return type) kesinlikle olamaz ('void' dahi yazılamaz).
               3. 'new' anahtar kelimesiyle nesne belleğe çıkarıldığı an otomatik tetiklenir. */


            Car c1 = new Car("Volkswagen", "Passat", 2017);
            Console.WriteLine("\nModel: " + c1.model + ", Name: " + c1.name + ", Year: " + c1.year);
            // veya direkt olarak ToString'ten okumak, direkt olarak c1 i çağırmak için: 
            Console.WriteLine("\ndirekt c1 çağrılmış hali:\n" + c1);






            /// Exercise: Spot the bugs

            /*
            class car // 1?
        {
            public void Car(string model)
            { // 2?
                model = model; // 3?
            }
        }

            1. class isminin ilk harfi küçük c ile yazılmış, constructor ismi büyük C ile. Aynı olmaları lazımdı. 
            2. constructor return type alamaz (void, int,float vs) [void bile alamaz diye ek not düşülmüştü]
            3. model = model demek değişkeni kendisine atar.      
            this.model = model dememiz lazım ki o durumdada this diyebilmek için zaten Class'ın içerisinde bir değişken tanımlaması yapmamız lazım. 
            this class'ın içerisindeki model ifadesini tanımlar (this, o an bellekte işlem gören nesnenin kendisini (instance) işaret eder.)



            kodun doğrusu şu şekildedir: 

            class Car

        {
            public string model;

            public Car(string model)
            {
                this.model = model;
            }
        }

            */




            /// Encapsulation & Properties






        }
    }
}
