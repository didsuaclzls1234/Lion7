using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0113_15
{
    //class Character
    //{
    //    //static: 모든 캐릭터가 공유
    //    public static int totalCount = 0;

    //    //일반: 각 캐릭터마다 다름
    //    public string name;

    //    public void AddCount()
    //    {
    //        totalCount++;
    //    }
    //}

    //this 키워드
    class Skill 
    {
        //필드
        private string name;
        private int atk;

        public Skill() { }
        public Skill(string name, int atk) { this.name = name;this.atk = atk; }
        public void SkillStart()
        {
            Console.WriteLine("스킬이름 : " + name);
            Console.WriteLine("스킬이름 : " + atk);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            //Character c1=new Character();
            //Character c2=new Character();

            //c1.name = "전사";
            //c2.name = "마법사";

            //Character.totalCount = 1;
            //c1.AddCount();
            //c2.AddCount();

            //Console.WriteLine(c1.name);
            //Console.WriteLine(c2.name);

            //Console.WriteLine(Character.totalCount);

            Skill s = new Skill("블리자드", 100000);
            s.SkillStart();

        }
    }
}
