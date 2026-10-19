using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w2
{

    internal class Program
    {
        static void BitwiseOperations()
        {
            int A = 60;
            int B = 13;


            // A&B bitwise AND. Not &&. Returns 1 only if both bits are 1.
            Console.WriteLine("\nA&B: " + (A & B)); /* output: 12
            A: 0 0 1 1   1 1 0 0 (60)
            B: 0 0 0 0   1 1 0 1 (13)
            -------------------------
          A&B: 0 0 0 0   1 1 0 0 -> 8 + 4 = 12 */


            // A|B bitwise OR. Not ||. Returns 1 if at least one bit is 1.
            Console.WriteLine("\nA|B: " + (A | B)); /* output: 61
            A: 0 0 1 1   1 1 0 0 (60)
            B: 0 0 0 0   1 1 0 1 (13)
            -------------------------
          A|B: 0 0 1 1   1 1 0 1 -> 32 + 16 + 8 + 4 + 1 = 61 */


            // A^B bitwise XOR. Returns 1 if bits are different, 0 if same.
            Console.WriteLine("\nA^B: " + (A ^ B)); /* output: 49
             A: 0 0 1 1   1 1 0 0 (60)
             B: 0 0 0 0   1 1 0 1 (13)
            -------------------------
           A^B: 0 0 1 1   0 0 0 1 -> 32 + 16 + 1 = 49 */


            Console.WriteLine("~A: " + (~A));
            // A in bit: 00111100 -> 32 + 16 + 8 + 4
            // ~ (NOT) operand makes reverse 1 & 0's 
            // A~ -> 11000011 -> very left part is declaring sign (1 is negative, 0 is positive) (extra note: this is applied on signed types [int, short, sbyte, long]. unsigned types [uint, ushort, ulong, byte].
            // -> -128 + 64 + 2 + 1 -> -128 + 67 -> -61. So output will be -61


            // Left Shift 
            Console.WriteLine("\nA<<2: " + (A << 2)); // output: 240 because in left shift, each shifting multiply by 2 so 2^2 60x4 = 240  

            // Right Shift
            Console.WriteLine("\nA>>2: " + (A >> 2)); // output: 15. in right shift, each shifting divide by 2. 2^2 -> 60/4 = 15.

        }

        class Person
        {
            public int age;
        }


        enum weekdays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }


        [Flags]
        enum Permissions
        {
            Read = 1,
            Write = 2,
            Execute = 4
        }

        static void Main(string[] args)
        {

            ///  Calculating Area 
            /*
            Console.WriteLine("Enter Width");
            string w = Console.ReadLine();

            Console.WriteLine("Enter Height");
            string h = Console.ReadLine();

            int A = Convert.ToInt32(w) * Convert.ToInt32(h);
            Console.WriteLine("Area: " + A);
            */



            /// Bitwise Operations 

            // yukarıda fonksiyon var tamamını içerisine detaylı bir şekilde yazdım 
            // BitwiseOperations();




            /// ?: Ternary conditional expression
            /*
            int age = 6;
            Console.WriteLine(age == 5 ? "yeah, it's 5" : "no, it's not 5 ");

            
            bool isActive = true;
            string state = isActive ? "\nActive" : "Passsive";
            Console.WriteLine(state);
            */



            /*
            /// DEĞER TİPLERİ (VALUE) vs REFERANS TİPLERİ (REFERENCE)
          
            // 1. DEĞER TİPİ (VALUE TYPE)
            // Bellekte Stack'te tutulur. Atama yapıldığında verinin kopyası çıkarılır.

            int a = 5;
            int b = a; // Verinin kendisi kopyalandı (a ve b bağımsız)

            b = 10; // Sadece b güncellendi

            Console.WriteLine(a); // Çıktı: 5  (a etkilenmedi)
            Console.WriteLine(b); // Çıktı: 10


            // 2. REFERANS TİPİ (REFERENCE TYPE)
            // Veri Heap'te, adresi Stack'te tutulur. Atama yapıldığında sadece adres kopyalanır.

            Person p1 = new Person();
            p1.age = 20;

            Person p2 = p1; // Adres kopyalandı (p1 ve p2 bellekte aynı nesneyi işaret ediyor)

            p2.age= 30; // p2 üzerinden yapılan değişiklik nesneyi doğrudan değiştirdi

            Console.WriteLine(p1.age); // Çıktı: 30 (p1 de değişti, çünkü aynı adrese bakıyorlar)
            Console.WriteLine(p2.age); // Çıktı: 30
            */




            /// Nullable 
            /*
            //  int a = null;   // HATA: Değer tipi null alamaz.
                int? b = null;  // GEÇERLİ: Nullable tip olduğu için null atanabilir.
            */
            // Kullanım amacı; özellikle veritabanlarında NULL gelebilecek sayısal veya mantıksal alanları(örneğin kullanıcının yaşını girmemesi durumu) kod tarafında 0 ile karıştırmadan doğru şekilde temsil etmektir.






            /// Enum

            /*
            we have structure above the main: 
              
            enum weekdays
            {
                Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            }
            */
            /*
            Console.WriteLine(weekdays.Monday); // Output: Monday
            int day = (int)weekdays.Monday;
            Console.WriteLine("\n"+day); // output: 0  unless you change the values, it will increase orderly starting from 0

            var wd = (weekdays)5; // var ifadesi sağdaki kısmın veri tipini değişkene uyarlar. 
            Console.WriteLine("\n"+wd); // 0.indexten başlamak üzere 6.günü basacak yani cumartesi (Saturday)
            
            // otomatik olarak enum içerisindeki ifadelerin value'sini alamayız. Yukarıda yaptığımız gibi casting uygulayarak (explicitly) value'sine ulaşabiliriz.
            */




            /// Enum Flags (Bitwise Operations)
            // yukarıda şöyle bir enum yapısı var:
            /*
            [Flags]
        enum Permissions
        {
            Read = 1,
            Write = 2,
            Execute = 4
        }
            */

            /*
            Permissions p = Permissions.Read | Permissions.Write;
            Console.WriteLine(p);
            */

            /*
            [Flags] özniteliği: Enum'ın tek bir değer yerine birden fazla seçeneğin kombinasyonunu tutabileceğini belirtir.
            2'nin kuvvetleri (1, 2, 4): Her yetkinin ikilik tabanda ayrı bir biti (001, 010, 100) temsil etmesini sağlar.
            | (Bitwise OR) operatörü: Read(1) ve Write(2) yetkilerini bit düzeyinde birleştirerek 3(011) değerini üretir.
            Çıktı mantığı: [Flags] sayesinde Console.WriteLine(p) ekrana sayısal değer(3) yerine birleşen isimleri 'Read, Write' olarak yazdırır.
            */





            /// Arrays



            // iki türlü oluşturma yöntemi var, fakat size ayarlamak istiyorsak new int[] ile oluşturmak zorundayız

            int[] arr = new int[10]; // 10 size'lık sabit bir int array tanımladık.
            // int[] arr = new int[10] {1,2,3,4,5,6,7,8,9,10};  // içerisine böyle değer de atayarak oluşturabiliriz.
            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // bu şekilde oluşturursakta size'ı sabittir, 10 elemanımız var en fazla 10 eleman atanabilir. İndex değerlerini değiştirebiliriz fakat sayısını 11 elemana çıkartamayız.

            // sonuç olarak iki türlü de size'ı sabit kalacaktır.
            // Dinamik olarak büyüyüp küçülen bir yapıya ihtiyacımız olduğunda dizi yerine List<T> kullanacağız (örnek, yani dahda farklı syntaxlar veya yöntemler de olabilir henüz bilmiyorum).

            
            
            // Copy an array variable — both point to the SAME memory location 
            int[] marks = new int[] { 99, 98, 92, 97, 95 };
            int[] score = marks;

            // bunun anlamı score'da ne değiştirirsem marksdada o şekilde değişim yaşanacaktır çünkü referansları aynı, yani gösterdikleri referans noktası aynı, aynı yere ulaşıp aynı yerdeki mevcut değeri değiştiriyoruz.
            // örnek: 
            /*
            Console.WriteLine("\nmarks 0 th index value BEFORE change = "+marks[0]); // output: 99
            score[0] = 12;
            Console.WriteLine("\nmarks 0 th index value AFTER change = " + marks[0]); // output: 12 
            */


            



            /// C#'ta diziler üçe ayrılır: Tek boyutlu (single-dimensional), çok boyutlu (multidimensional) ve düzensiz (jagged) diziler.


            /* 1. Tek Boyutlu Diziler (Single-Dimensional Arrays)
               Elemanlar bellekte ardışık (contiguous) olarak yerleşir.
               İlk eleman (indeks 0) en düşük bellek adresinde, son eleman en yüksek adrestedir. */
            int[] singleArr = new int[4] { 10, 20, 30, 40 };

            /* 2. Çok Boyutlu / Matris Diziler (Multidimensional Arrays)
               Satır ve sütunlardan oluşan ızgara (grid) yapısıdır.
               Köşeli parantez içindeki virgül sayısı = Boyut sayısı - 1 formülüyle belirlenir (C# en fazla 32 boyuta kadar destekler).
               [,] 2 boyutlu, [,,] 3 boyutlu, [,,,] 4 boyutlu dizi belirtir.
               3 satır ve 3 sütundan oluşan 2 boyutlu dizi: */
            int[,] multiArr = new int[3, 3]
                {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
                };

            /* 3. Düzensiz Diziler (Jagged Arrays)
               Dizilerin dizisidir (array of arrays).
               Her satırın sütun uzunluğu birbirinden farklı olabilir.
               Satır sayısı sabittir, ancak her satıra atanacak alt dizinin boyutu bağımsız olarak tanımlanır.*/
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 3, 5, 7 };
            jaggedArray[1] = new int[] { 1, 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 8, 9 };





            /// Collections


            // Boyutu sabit dizilerin aksine dinamik veri depolama yapılarıdır. İki ana aileye ayrılır: Non-Generic ve Generic.

            /* Namespace Kuralı:
            List<T> ve Dictionary gibi Generic koleksiyonları doğrudan adlarıyla kullanabilmek için dosyanın en başına 'using System.Collections.Generic;' eklenmelidir.
            ArrayList ve Hashtable gibi Non-Generic koleksiyonlar için ise 'using System.Collections;' eklenir.
            Bu using ifadeleri eklenmezse türlerin başına her defasında tam namespace yolunu yazmak gerekir. */


            /* 1. Non-Generic Koleksiyonlar (System.Collections)
            - Elemanları 'object' türünde tutar; her türlü veri tipi aynı listeye eklenebilir.
            - Dezavantajları: Tür güvenliği (type safety) yoktur, hatalar çalışma zamanında (runtime) çıkar.
            - Boxing/unboxing işlemlerinden dolayı performans maliyeti yüksektir.
            - Örnekler: ArrayList, Hashtable */
            ArrayList nonGenericList = new ArrayList(); // mesela burda en başına System.Collections; yazmamıza gerek kalmadı çünkü en yukarıda namespace üstünde "using.System.Collections;" ifademiz yer almakta.
            // Yoksa aşağıdaki gibi uzun uzun 2 tarafa da yazmamız gerekecekti.
            // System.Collections.ArrayList nonGenericList = new System.Collections.ArrayList();
            nonGenericList.Add(10);
            nonGenericList.Add("Hello"); // Farklı tipleri kabul eder
            object item = nonGenericList[0];
            // başa object yazmamızın sebebi:
            // ArrayList elemanları 'object' türünde saklar ve indeksleyici geriye doğrudan 'object' döner.
            // Bunu 'int' gibi özgül bir türe doğrudan atayamazsın; ya 'object' olarak karşılaman ya da açıkça tür dönüşümü (unboxing / cast) yapman gerekir. 

            //CASTING mantığı ile Dönüştürmek istediğin hedef türü parantez içine alıp ifadenin önüne yazarak yaparsın:
            // int item = (int)nonGenericList[0];



            /* 2. Generic Koleksiyonlar (System.Collections.Generic)
            - Tanımlanırken belirli bir veri tipi (<T>) alır ve sadece o tipi kabul eder.
            - Avantajları: Tür güvenliği sağlar, tip uyuşmazlığı derleme anında (compile-time) hata verir.
            - Boxing/unboxing yapılmadığı için daha hızlı ve performanslıdır; okunabilirliği yüksektir.
            - Örnekler: List<T>, Dictionary<TKey, TValue> */

            List<int> genericList = new List<int>();
            genericList.Add(10);
            // genericList.Add("Hello"); // Derleme zamanında (compile-time) hata verir, derlenmez. Çünkü tipini en baştan "int" olarak belirledik.
            int number = genericList[0];
            // Görüldüğü üzere List<int> elemanları zaten doğrudan int olarak sakladığından cast işlemine gerek kalmadan doğrudan int değişkene atanabilir.





            /// Other Generic & Nongeneric Types (w2/81)
            

            /* 1. Generic Collections (System.Collections.Generic) */

            // SortedList<TKey, TValue>: Key-Value çiftlerini saklar ve anahtarlara (Key) göre varsayılan olarak artan (ascending) sırada otomatik sıralar.
            SortedList<int, string> sortedListGeneric = new SortedList<int, string>();

            // Queue<T>: FIFO (First In First Out - İlk giren ilk çıkar) mantığıyla çalışır. Eleman eklemek için Enqueue(), çıkarmak için Dequeue(), sıradakine bakmak için Peek() kullanılır.
            Queue<int> queueGeneric = new Queue<int>();

            // Stack<T>: LIFO (Last In First Out - Son giren ilk çıkar) mantığıyla çalışır. Eleman eklemek için Push(), çıkarmak için Pop(), en üsttekine bakmak için Peek() kullanılır.
            Stack<int> stackGeneric = new Stack<int>();


            /* 2. Non-Generic Collections (System.Collections) */

            // SortedList: Key-Value çiftlerini 'object' türünde saklar ve anahtarlara göre otomatik sıralar. Generic versiyonu gibi çalışır ancak tip güvenliği (type safety) yoktur.
            System.Collections.SortedList sortedListNonGeneric = new System.Collections.SortedList();

            // Queue: FIFO mantığıyla çalışan fakat değerleri 'object' olarak tutan kuyruk yapısıdır.
            System.Collections.Queue queueNonGeneric = new System.Collections.Queue();

            // Stack: LIFO mantığıyla çalışan fakat değerleri 'object' olarak tutan yığın yapısıdır.
            System.Collections.Stack stackNonGeneric = new System.Collections.Stack();




            /// Array Sınıfı Metotları ve Özellikleri (System.Array) 


            int[] scores = { 42, 7, 19 };

            // Length: Dizideki toplam eleman sayısını döner (metot değil, property/özelliktir).
            int count = scores.Length; // 3

            // Array.Sort(): Elemanları yerinde (in-place) artan sırada (küçükten büyüğe) sıralar.
            Array.Sort(scores); // { 7, 19, 42 }

            // Array.Reverse(): Dizideki elemanların sırasını tersine çevirir.
            Array.Reverse(scores); // { 42, 19, 7 }

            // Array.IndexOf(): Belirtilen değerin ilk görüldüğü indeksi döner; dizide yoksa -1 döner.
            int pos = Array.IndexOf(scores, 19); // 1

            // Array.Clear(): Belirtilen aralıktaki elemanları tipin varsayılan değerine (sayılar için 0'a) sıfırlar; boyutu küçültmez.
            Array.Clear(scores, 0, 2); // 0. indeksten başlayıp 2 elemanı sıfırlar -> { 0, 0, 7 }

            // Array.Copy(): Bir dizideki eleman aralığını başka bir hedef diziye kopyalar.
            int[] copyScores = new int[3];
            Array.Copy(scores, copyScores, scores.Length);




            /// Kaçış Karakterleri (Escape Sequences: \' ve \")
            

            // Metin veya karakter sınırlandırıcı işaretleri veri olarak kullanmak için başına '\' konur.
            // \' (Single Quote): Tek tırnak karakteri tanımlarken sözdizimi çakışmasını önler.
            char tekTirnak = '\'';

            // \" (Double Quote): String metin içinde çift tırnak işareti basmak için zorunludur.
            string alinti = "Ali \"merhaba\" dedi"; // Çıktı: Ali "merhaba" dedi




            /// Değişken Kapsamı ve İsimlendirme Kuralı (Variable Scope: One Name, One Scope)
            

            // C#'ta bir yerel değişkenin etki alanı (scope) içindeyken, alt bir blokta aynı isimle yeni bir değişken tanımlanamaz (Variable Hiding / Shadowing yerel düzeyde yasaktır). */

            // 1. Hatalı Kullanım: İç İçe (Nested) Scope
            {
                int x = 10;
                {
                    // int x = 20; // HATA (Compile-time Error): 'x' değişkeni dış blokta zaten tanımlı, gizlenemez.
                }
            }

            // 2. Geçerli Kullanım: Ardışık / Bağımsız (Sibling) Scope
            {
                int y = 10;
            } // İlk y değişkeninin yaşam süresi ve kapsamı burada bitti.

            {
                int y = 20; // GEÇERLİ: Önceki blok sonlandığı için aynı isim yeniden kullanılabilir.
            }




            /// Ternary Operation (?:) 
            
            /*
            // if-else yapısının tek satırlık kısa halidir (koşul ? true_ise : false_ise).
            int age = 20;
            string status = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine(status); // Adult
            */


            
            
            /// break vs continue 

            /*
            // 1. break (Exit the Loop): Döngüyü tamamen sonlandırır ve döngüden çıkar.
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) { break; }
                Console.WriteLine(i); // Çıktı: 0, 1, 2, 3
            }

            // 2. continue (Skip an Iteration): Döngüyü bitirmez; sadece o anki turu atlar, bir sonraki adıma geçer.
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) { continue; }
                Console.WriteLine(i); // Çıktı: 0, 1, 2, 3, 5, 6, 7, 8, 9 (yalnızca 4 atlandı)
            }
            */




            /// XML Yorum Satırları (XML Comments: ///)

            /*
            Class, metot, property ve alanları dokümante etmek için üç eğik çizgiyle (///) yazılır.
            Amacı: Kod dokümantasyonu sağlamak, Visual Studio / IntelliSense ipuçlarını beslemek ve Reflection ile çalışma zamanında okunabilmektir.

            Yaygın XML Etiketleri: 
            - <summary>: Tip veya üyenin genel açıklaması.  
            - <remarks>: Ekstra detaylar/notlar.    
            - <param name="...">: Metot parametresinin tanımı.
            - <returns>: Metodun dönüş değerinin tanımı.
            - <exception>: Metodun fırlatabileceği istisnalar/hatalar.  
            - <example>, <code>, <c>: Örnek kod blokları. */

            /// <summary>
            /// Bu sınıf XML dokümantasyonunu örnekler.
            /// </summary>

            /*
            public class MyClass
        {
            /// <summary>
            /// Verilen sayıyı işler.
            /// </summary>
            /// <param name="value">Girdi olarak alınan tam sayı.</param>
            /// <returns>İşlem sonucu dönen tam sayı.</returns>
            public int MyMethod(int value)
            {
                return value * 2;
            }
        }
            */






            /// Exception Handling 
            


            // Programların çökmesini engellemek ve hataları zarifçe (gracefully) yönetmek için kullanılır

            try
            {
                // Hata üretme potansiyeli olan asıl kodlar buraya yazılır.
                int a = 10;
                int b = 0;
                int sonuc = a / b; // Sıfıra bölme hatası (DivideByZeroException) tetiklenir.
            }
            catch (Exception ex) // veya ->  catch (DivideByZeroException ex) dediğimizde alt tarafa "ex.Message" yazmak zorunda kalmıyoruz çünkü kendi tanımladığımız hata türü değil. 
            {
                // try bloğunda bir hata (exception object) oluşursa program çökmez, akış buraya geçer ve hatayı yönetir.
                Console.WriteLine("Hata yakalandı: " + ex.Message);
            }
            finally
            {
                // Hata olsun veya olmasın her durumda en son kesinlikle çalışacak olan bloktur. (Örn: Açık dosyaları veya bağlantıları kapatmak).
                Console.WriteLine("İşlem sonlandı.");
            }

            // throw: Kendi belirlediğimiz bir kural ihlal edildiğinde bilinçli olarak manuel hata fırlatmak için kullanılır.
            int age = 15;
            if (age < 18)
            {
                throw new ArgumentException("Yaş 18'den küçük olamaz.");
            }

            /// C#'ta Yaygın Hatalar (Common Exceptions) 

            // DivideByZeroException: (dividing by zero).
            // NullReferenceException: (using an object that is null).
            // IndexOutOfRangeException: (array index is invalid).
            // FileNotFoundException: (file does not exist).


        }
    }
}
