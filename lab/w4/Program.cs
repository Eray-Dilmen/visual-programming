using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4
{
    internal class Program
    {


        /// CLASS vs STRUCT

        public struct Point
        {
            int x, y;

            public Point(int x, int y)
            {
                this.x = x; 
                this.y = y; 
            }

            public int X { get { return x; } set { x = value; } } 
            public int Y { get { return y; } set { y = value; } } 
        }

        // Car sınıfının kalıtım aldığı Vehicle sınıfı (Hata vermemesi için boş şablon olarak eklendi)
        public class Vehicle { }

        // Class Örneği: Kalıtım alabilir, Heap üzerinde tutulur (Karmaşık yapı).
        public class Car : Vehicle
        {
            public enum Make { GM, Honda, BMW } 
            Make make; 
            string vid; 
            Point location; // Struct'ı class içinde field olarak kullandık.

            public Car(Make m, string vid, Point loc)
            {
                this.make = m; 
                this.vid = vid; 
                this.location = loc; 
            }

            public void Drive()
            {
                Console.WriteLine("vroom"); 
            }
        }




        
        ///  MAIN BAŞLANGICI       
      
        static void Main(string[] args)
        {
            /*
            
            CLASS vs STRUCT 
            
            Benzerlikler:
            - İkisi de kullanıcı tanımlı veri tipidir (user-defined).
            - İkisi de metot, property, constructor ve field barındırabilir.
            - İkisi de birden fazla interface uygulayabilir (implements).

            Temel Farklar:
            - CLASS (Sınıf): Referans tipidir (Heap'te tutulur). Kalıtım (inheritance) ve polymorphism destekler. Null olabilir ve Garbage Collector (GC) tarafından temizlenir. Karmaşık ve büyük veri yapıları için kullanılır.
            - STRUCT (Yapı): Değer tipidir (Stack'te tutulur). Kalıtım DESTEKLEMEZ (miras alamaz/veremez). Hafif, basit ve küçük veriler (koordinat, renk vb.) için kullanılarak bellek yükünü (heap allocation) azaltır.

            Özet Kural: Küçük, sabit ve basit veriler için Struct; genişletilebilir, paylaşılan ve karmaşık nesneler için Class kullanılır.
            */


            Point p = new Point(2, 5); 
            p.X += 100; 
            int px = p.X; // px = 102 olur

            Car c = new Car(Car.Make.BMW, "JF3559QT98", new Point(3, 7)); 
            c.Drive(); 
        
    }
}
}
