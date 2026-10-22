using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
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







        /// Constructor örneği 
        

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

        




        
        /// Encapsulation örneği
        
        
        class Person
        {
            private string name; // class içerisindeki field (değişkenimiz) 
            
            public string Name // property, metot gibi () içermez. İçerisine get veya set (ihtiyaca göre birisi konur [mesela  ]) . encapsulation olduğu için bu property ismini "Name" kullanmak zorundayız erişmek için. içerisinde de asıl değeri saklıyoruz, yani "name" olan değişkene direkt olarak class içerisinden erişemiyor (çünkü private), bu property ile erişiyoruz. 
            {
                get { return name; }
                set { name = value; }
            }
            
        }





        

        #region Inheritance (Kalıtım) Denemeleri
        ///  Inheritance    (başlangıcı 290 civarı)
        class Vehicle
        {
            public string brand;

            public void Honk()
            {
                Console.WriteLine("Tutt tuttt");
            }
        }

        
        
        class Carr : Vehicle
        {
            public string modelName;
        }
        #endregion








        ///  Polymorphism örneği  (451)

        
        class Shape
        {
            public virtual float Area() //virtual (ezilebilir) yapıyor ve alt sınıflarda override edilmesini sağlıyor.
            {
                return 0;
            }
        }

        
        class Circle : Shape
        {
            public float r;

            public Circle(float r)
            {
                this.r = r;
            }

            public override float Area() // override edilen parent ile aynı accessible, aynı data type ve aynı parameters'lara sahip olmalı. 
            {
                return 3.14f * r * r;
            }
        }

        class Rectangle: Shape
        {
            public float width;
            public float height;

            public Rectangle(float width, float height)
            {
                this.width = width;
                this.height = height;
            }

            public override float Area()
            {
                return width * height;
            }
        }


        class Triangle: Shape
        {
            public float height;
            public float width;

            public Triangle(float height, float width)
            {
                this.height = height;
                this.width = width;
            }

            public override float Area()
            {
                return (height * width) / 2f;
            }
        }

        





        /// üstteki Polymorphisim örneğinin get set (property) ile yazılmış hali (daha hızlı [constructor yerine geçiyor] ve bu sayede direkt değişken atarken get set ile ona erişebiliyoruz)
        /* // (486)

        class Shape
        {
            public virtual float Area() => 0f; // "=>" kod bloğu açıp return demekle aynı şey. Yani bu ifadeden sonra direkt olarak return edilecek değeri yazıyorsun 
        }


        class Circle : Shape
        {
            public float R { get; set; } // r değişkenine set ile kolayca atıyoruz ve get ile r yi kullanabiliyoruz. (Değişken ismi de property'de metotlar gibi büyük yapılırmış.)
            public override float Area() => 3.14f * R * R;
        }

        class Rectangle : Shape
        {
            public float Height { get; set; }
            public float Width { get; set; }

            public override float Area() => Height * Width;

        }

        class Triangle : Shape
        {
            public float Height { get; set; }
            public float Width { get; set; }
            public override float Area() => (Height * Width) / 2f;
        }
        */







        /// MAIN BAŞLANGICI   

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

            /*
            Car c1 = new Car("Volkswagen", "Passat", 2017);
            Console.WriteLine("\nModel: " + c1.model + ", Name: " + c1.name + ", Year: " + c1.year);
            // veya direkt olarak ToString'ten okumak, direkt olarak c1 i çağırmak için: 
            Console.WriteLine("\ndirekt c1 çağrılmış hali:\n" + c1);
            */





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


            /// Access Modifiers 
            /*
            - public: The code is accessible for all classes
            - private: The code is only accessible within the same class        
            - protected: The code is accessible within the same class, or in a class that is inherited from that class.
            - internal: The code is only accessible within its own assembly, but not from another assembly.
            */

            /*
            Person p1 = new Person();
            p1.Name = "Eray";
            Console.WriteLine("\n\n\nisim: " + p1.Name); // bu örnekte sadece basit yapısını gördük, kapsüllemekteki amaç sınır çizebilmektir, aşağıdaki örnekler farkı yukarıdaki oluşturulan class içerisindeki property'den çok daha net şekilde açıklayacaktır.
            */


            /*
            1. Korumasız Durum (public string name;)
            Burada kapı yok, değişken tamamen açıktır:

            h1.name = "";             // Boş isim atandı, engelleyemezsin.
            h1.name = "123456";       // Saçma bir metin atandı, engelleyemezsin.
            h1.name = null;           // Null atandı, sistem ilerde çökebilir.

            -----------------------------------------------------------------------

            2. Korumalı Durum (Encapsulation / Kapsülleme)
            Değişken "private string name;" olarak gizlenir. Dışarı açılan "public string Name" 
            property'sinin set bloğuna ise kural/denetim yazılır:

            class Human
            {
                private string name; // Gizli kasa

                public string Name   // Güvenlik kapısı
                {
                    get { return name; }
                    set 
                    { 
                        // Gelen değeri (value) kontrol et
                        if (string.IsNullOrWhiteSpace(value))
                        {
                            Console.WriteLine("Hata: İsim boş bırakılamaz!");
                        }
                        else
                        {
                            name = value; // Sadece kurala uyuyorsa kasaya koy
                        }
                    }
                }
            }
            
            Dışarıdaki biri artık istediği gibi atama yapamaz:
            h1.Name = ""; // Konsola hata basar ve 'name' değişkeni bozulmaz, eski halini korur.

            -----------------------------------------------------------------------

            İkinci Koruma Şekli: Değiştirilemez Yapmak (Read-Only)
            İstediğin veriyi dışarıya sadece okuma amaçlı açıp, kimsenin değiştirmesine izin vermeyebilirsin:

            public string Name
            {
                get { return name; } // Sadece okunabilir, dışarıdan kimse h1.Name = "x" diyemez (hata verir).
            }

            Özetle; enkapsülasyonda amaç verinin adını şifrelemek değil, veriye kafasına göre müdahale edilmesini engelleyip yetki ve doğrulamayı senin belirlediğin kurallara bağlamaktır.

            */





            /// Inheritance


            // iki class'ımız var birisi diğerinden miras alacak (miras alan derived class[ondan türeyen olarak kullanılıyor] (özelliklerini ve metotlarını alabilir [tabi eğer private değillerse], constructor vs alamaz) 
            // class Child : Parent [ inheritance kullanırken araya : ekleniyor ve miras almak istediğimiz diğer Class çağrılıyor] 

            /*
            Carr cc1 = new Carr();

            cc1.brand = "Volkswagen";
            cc1.modelName = "Passat";

            Console.WriteLine("cc1 brand: " + cc1.brand + ", modelname = " + cc1.modelName + ", Voicing like: ");
            cc1.Honk();
            */




            /// Polymorphism    (classlar 108.satırda) 

            // overriding -> method'un body'sini yani içeriğini değiştirerek tekrar yazmaya deniyor
            // method overloading -> metodun yapısını değiştirmeye deniyor ( parametrelerini farklı ayarlayabilirsin vs) 

            /*
            Circle c1 = new Circle(5);
            Console.WriteLine("Area of Circle: " + c1.Area()); // 3.14 x 25 = 
            
            Triangle t1 = new Triangle(9,4);
            Console.WriteLine("Area of Circle: " + t1.Area()); // 9.4 / 2 = 18 vermesi lazım

            Rectangle r1 = new Rectangle(9,4);
            Console.WriteLine("Area of Rectangle: " + r1.Area()); // 9.4 = 36 (kısa kenarla uzun kenar çarpımı) 

            // hepsinde de area metodunu kullandık, içeriğini (body'sini) override etmiş olduk. (Fakat parametreleri, değişken tipini ve erişim şeklini değiştiremeyiz, aynı olmak zorundadır. O yüzden Polymorphisimde overloading yapamayız.
            // bu arada üstte yapılan polymorphisim değilmiş, altta ortak alana alınca (listin veri tipini Shape olarak oluşturup shape grubuna onları koyunca polymorphisim olmuş) 
            
            Console.WriteLine("\n\n");
            

            // polymorphisimi kullandığımızın bir kanıtı diyebiliriz, dizinin içerisindeki tüm elemanların alanlarını hesaplıyoruz fakat hepsinde farklı çıkıyor çünkü hepsinde alan hesaplamasını şekline göre değiştirdik.
            List<Shape> shapes = new List<Shape>
            {
                c1,t1,r1
            };

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.Area());
            }
            */



            /// Nesneyi oluştururken sol tarafı Shape yapsaydım (Shape s = new Circle(5);), sistem hangi şeklin Area() metoduna gitmesi gerektiğini nasıl anlayacak?
            /*
             Tamamen sağ taraftaki "new Circle()" kısmından anlar. 
            - Sol taraf (Shape s): Sadece nesneyi gösteren bir referanstır (bir nevi kumanda).
            - Sağ taraf (new Circle): Bellekte (RAM'de) yaratılan asıl GERÇEK nesnedir.

            Arka planda "Late Binding" (Geç Bağlama) sayesinde süreç şöyle işler[cite: 11]:
            1. Derleme Zamanı (Compile): Sistem sol tarafa (Shape) bakar. "Bu kumandada Area() tuşu var mı?" der ve hata vermeden kodu onaylar[cite: 11].
            2. Çalışma Zamanı (Runtime): s.Area() komutu çalıştığında, C# sol taraftaki kılıfa (Shape) değil, bellekte o an var olan gerçek nesneye (Circle) gider[cite: 11].
            3. Ana sınıftaki metot "virtual" (ezilebilir) olduğu için, sistem doğrudan gerçek nesnenin içindeki "override" edilmiş Area() metodunu bulur ve onu çalıştırır[cite: 11].
            */



            /// Neden sol tarafı Shape yapmak isteyeyim? (Shape s = new Circle(5);) Zaten List<Shape> ile ortak noktada toplamıştık.
            /*
            Aslında List<Shape> kullandığında veya bir metoda parametre gönderdiğinde arka planda tam olarak bu (Shape s = nesne) işlemi gerçekleşir. Buna nesneye "hangi referansla (gözlükle) baktığın" denir:

            1. Kendi Gözlüğüyle Bakmak (Circle c = new Circle(5);)
               - Nesneyi tüm detaylarıyla görürsün. Sadece Shape'ten gelen Area()'yı değil, Circle'a özel olan yarıçap (R) değişkenini veya sadece ona ait metotları da kullanabilirsin.
               - Nesneye özel, spesifik işlemler yapacaksan bunu kullanırsın.

            2. Üst Sınıfın Gözlüğüyle Bakmak (Shape s = new Circle(5);)
               - Nesneye "genel bir şekil" olarak bakarsın. Derleyici sana sadece Shape sınıfında tanımlı olan ortak özellikleri (Area) gösterir; alt sınıfın detaylarına (örneğin R değerine) erişmeni kısıtlar.
               - NEDEN KULLANIRIZ? "Bana ne olduğu fark etmez, yeter ki bir şekil olsun" dediğimiz yerlerde esneklik sağlamak için. 
                 Örneğin: 
                 - Her şekli kabul eden bir liste oluştururken (List<Shape>)
                 - Her şekli kabul eden tek bir metot yazarken ( void Ciz(Shape s) { ... } )

            ÖZET: Sol tarafı üst sınıf (Shape) yapmak, kodunu alt sınıfların (Circle, Triangle) detaylarına bağımlı olmaktan kurtarır ve hepsine aynı standart kurallarla hükmetmeni sağlar (Polymorphism).
            */





            /// (177)
            // enkapsülasyon (get/set) mantığında constructorda () ile parametreleri sırayla girmek gerekiyorken
            //burada {} içlerine yazıyoruz ve sırası yok. Çünkü ikisini de get ile alıyoruz ama yapı anlayamaz hangisini kastettiğimizi, o yüzden değişken ismini de belirtmemiz şarttır burada.
            /*
            Circle c1 = new Circle { R =  5 };
            Console.WriteLine("Area of Circle: " + c1.Area()); 

            Triangle t1 = new Triangle { Height = 9, Width =  4 };
            Console.WriteLine("Area of Circle: " + t1.Area()); 

            Rectangle r1 = new Rectangle{Height = 9, Width = 4};
            Console.WriteLine("Area of Rectangle: " + r1.Area());

            Console.WriteLine("\n\n");
            List<Shape> shapes = new List<Shape>
            {
                c1,t1,r1
            };

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.Area());
            }
            */







            /// Abstraction & Interfces 

            /*
            İkisi de soyutlama(kod şablonu çıkarma) için kullanılır.
            Ortak kod paylaşımı ve tekli kalıtım gerekiyorsa Abstract Class kullanılır.
            Sadece ortak kurallar / yetenekler belirlemek ve çoklu kalıtım sağlamak gerekiyorsa Interface kullanılır.

        
            1. Abstract (Soyutlama) Class Mantığı
            ---------------------------------------------------------
            Normalde üst sınıfa "public virtual float Area() => 0;" yazıp içi 0 olan uydurma bir gövde oluşturulabilir.
            Ancak gerçekte "Dünyada tek başına 'Şekil' diye somut bir şey yoktur; daire vardır, kare vardır. Şeklin tek başına alanı nasıl 0 olsun? Saçma bir gövde uydurmak yerine gövdeyi tamamen sil ve başına abstract koy." mantığı uygulanır.

            Örnek Kullanım:
            public abstract class Shape
            {
                public abstract double Area(); // Süslü parantez yok, gövde yok! Noktalı virgülle biter.
                public abstract double Perimeter(); 
            }

            Kurallar:
            - "Shape s = new Shape();" yapılmasını yasaklar. Birisi yanlışlıkla havada kalan genel bir şekil nesnesi üretemez.
            - "Shape"ten miras alan ("Circle", "Rectangle") alt sınıflar, "Area" ve "Perimeter" metotlarını yazmak ZORUNDADIR. Yazmazlarsa derleyici hata verir, kod derlenmez.


            2. Interface (Arayüz) Mantığı
            ---------------------------------------------------------
            Interface bir sözleşmedir.

            Örnek Kullanım:
            public interface IShape
            {
                double Area(); 
                double Perimeter(); 
            }

            Kurallar:
            - "Beni uygulayacak (implements) olan sınıf, mutlaka Area() ve Perimeter() hesaplamak zorundadır" der[cite: 13]. 
            - Nasıl hesapladığı ile ilgilenmez, sadece bu iki yeteneği sağlamayı mecbur kılar[cite: 13].


            3. Abstract Class ve Interface Arasındaki Temel Farklar
            ---------------------------------------------------------
            Bir sınıf tanımlanırken (örneğin: public class Circle : Shape, IShape) her ikisi de kullanılabilir. Aralarındaki ayrım şudur:

            - Abstract Class (Miras / Extends): Aile bağıdır. Bir sınıf yalnızca tek bir sınıftan türeyebilir (One parent allowed).
            - Interface (Sözleşme / Implements): Yetenektir. Bir sınıf birden fazla interface uygulayabilir (Any number allowed).

            ÖZET:
            Temel amaç ana yapıyı (Shape) yarım/şablon bırakıp, alt sınıflara bu metotları yazmayı zorunlu kılmaktır.
            */


        }
    }
}
