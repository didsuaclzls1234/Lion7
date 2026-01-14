using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0114_13
{
    // 부모 클래스 (기반 클래스, Base Class)
    //class Parent
    //{
    //    // 공통 멤버
    //}

    //// 자식 클래스 (파생 클래스, Derived Class)
    //class Child : Parent  // : Parent로 상속
    //{
    //    // 상속받은 멤버 + 추가 멤버
    //}

    //부모클래스:기본 캐릭터
    class Character
    {   //public, private, protected
        protected string name;
        protected int level;
        protected int hp;
        protected int maxHP;
        protected int attack;
        protected int defense;

        public Character(string characterName)
        {
            name = characterName;
            level = 1;
            maxHP = 100;
            hp = maxHP;
            attack = 30;
            defense = 30;
            Console.WriteLine($"캐릭터 {name} 생성");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
        }
    }

    //자식 클래스
    class Warrior : Character 
    {
        private int rage;

        public Warrior(string name) :base(name)
        {
            //base.name ="전사";
            attack = 60;
            defense = 40;
            maxHP = 150;
            hp=maxHP;
            rage = 0;
            Console.WriteLine("직업 : 전사");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();//부모 클래스의 함수 호출
            Console.WriteLine($"분노 : {rage}");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character("주인공");
            character.ShowInfo();
            Warrior warrior=new Warrior("홍길동");
            
            warrior.ShowInfo();

            
        }
    }
}
