using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0114_09
{
    //클래스끼리 통신
    class Player
    {
        //public int hp;
        //public int att;
        private int hp;
        private int att;

        public void Render()
        {
            Console.WriteLine("플레이어");
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("공격력 : " + att);
        }

      

        public void SetHp(int hp) {this.hp = hp;}
        public int GetHp() {return hp;}
        public void SetAtt(int att) {this.att = att;}
        public int GetAtt() {return att;}
    }

    class Monster
    {
        //public int hp;
        //public int att;
        private int hp;
        private int att;

        public void Render()
        {
            Console.WriteLine("몬스터");
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("공격력 : " + att);
        }

        public void SetHp(int hp) { this.hp = hp; }
        public int GetHp() { return hp; }
        public void SetAtt(int att) { this.att = att; }
        public int GetAtt() { return att; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.SetAtt(10); player.SetHp(100);
            //player.att = 10;
            ////player.hp = 100;
            //player.Render();
            Monster monster = new Monster();
            monster.SetHp(100);monster.SetAtt(5);
            ////monster.att = 5;
            ////monster.hp = 100;
            //monster.Render();

            ////monster.hp-=player.att;
            ////player.hp-=monster.att;

            //monster.Render();
            //player.Render();

            //플레이어가 몬스터 때리기
            monster.SetHp(monster.GetHp() - player.GetAtt());

            //몬스터가 플레이어 때리기
            player.SetHp(player.GetHp()-monster.GetAtt());
        }
    }
}
