using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _0115_10
{
    //인터페이스
    interface IAttackable
    {   
        void Attack(string target);
        int GetAttackPower();
    }

    //인터페이스 Defendable 구현
    interface IDefendable 
    { 
        void Defend();
        int GetDefensePower();
    }


    class Knight : IAttackable, IDefendable 
    {

        public string name;
        public int attackPower;
        public int defensePower;

        public Knight()
        {
            name = "검사";
            attackPower = 10;
        }
        public void Attack(string target)
        {
            Console.WriteLine(target+"을(를) 검으로 공격");
        }

        public void Defend()
        {
            Console.WriteLine("기사가 방어모드중");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetDefensePower()
        {
            return defensePower;
        }
    }
    class Magician : IAttackable 
    {
        public string name;
        public int MP;
        public int spellPower;
        public Magician()
        {
            name = "마법사";
            MP = 100;
            spellPower = 100;   
        }
        public void Attack(string target) 
        {
            Console.WriteLine(target + "을(를) 마법으로 공격");
        }

        public int GetAttackPower()
        {
            return MP * spellPower;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Attack("오크");
            knight.Defend();

            Magician magician = new Magician();
            magician.Attack("슬라임");

            IAttackable[] attacker = new IAttackable[2];
            attacker[0] = new Knight();
            attacker[1] = new Magician();

            IDefendable defender = new Knight();
            defender.Defend();

            foreach(var atk in attacker)
            {
                atk.Attack("고블린");
            }
        }
    }
}
