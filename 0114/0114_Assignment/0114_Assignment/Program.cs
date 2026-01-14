using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0114_Assignment
{
    //    💪 연습 문제


    //문제 1: 동물원 시스템

    //Animal 부모 클래스와 다양한 동물 자식 클래스를 만들고,
    //다형성으로 관리하세요.
    class Animal
    {
        protected string name;
        protected String species;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"종류 : {name}");
            Console.WriteLine($"나이 : {age}");
        }

    }
    class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age) { }
        public override void ShowInfo()
        {
            Console.WriteLine($"{name}");
        }
    }
    class Cat : Animal
    {
        protected Cat(string name, int age) : base(name, age) { }
        public override void ShowInfo() { Console.WriteLine($"{name}"); }
    }
    class Kitten : Cat
    {
        private bool isBaby = false;
        public Kitten(string name, int age) : base(name, age) { isBaby = true; }
        public override void ShowInfo()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine("아직 새끼 입니다.");
        }
    }

    //문제 2: 상점 시스템
    //다양한 상품 타입을 다형성으로 관리하고,
    //타입별로 다른 할인율을 적용하세요.


    //문제 3: 파일 시스템

    //File 추상 클래스와 TextFile, ImageFile, VideoFile을
    //만들고 타입별로 다르게 처리하세요.

    //문제4: 알림 시스템

    //Notification 부모 클래스와 Email, SMS, Push 자식을 만들고
    //is/as로 타입별 특수 처리를 구현하세요.






    internal class Program
    {
        static void Main(string[] args)
        {
            //문제 1
            Animal animal = new Animal("사자", 1);
            animal.ShowInfo();
            Animal animal1 = new Lion("사자", 2); //업캐스팅
            animal1.ShowInfo();
            Animal animal2 = new Lion("사자", 3);//다운 캐스팅
            Lion lion = (Lion)animal2;
            animal2.ShowInfo();
            /////
        }
    }
}
