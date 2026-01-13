using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0113_09
{
    //클래스 예제
    class Character 
    {
        //public 다른곳에서 사용가능
        //private 클래스 내부에서만 사용가능
        public string name;
        public int level;
        public int hp;
        public int maxHP;
        public int mp;
        public int maxMP;

        //기본생성자 - 초기화 용도로 많이 사용
        public Character()
        {
            name = "홍길동";
            level = 1;
            hp = 100;
            maxHP = 150;
            mp = 80;
            maxMP = 100;
        }
        //인자 있는 생성자
        public Character(string _name,int _level,int _hp,int _MaxHP,int _mp,int _MaxMP) 
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _MaxHP;
            mp=_mp;
            maxMP=_MaxMP;
        }
        //함수를 모아서 사용
        public void ShowStats()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("레벨: " + level);
            Console.WriteLine("hp: " + hp);
            Console.WriteLine("MaxHP: " + maxHP);
            Console.WriteLine("Mp: " + mp);
            Console.WriteLine("MaxMp: " + maxMP);
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //객체 생성
            Character player = new Character();//생성자 호출
            player.ShowStats();

            Character player2 = new Character("마법사",2,110,250,80,100);//인자 있는 생성자 호출
            player2.ShowStats();
        }
    }
}
