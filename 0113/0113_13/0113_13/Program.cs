using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0113_13
{
    class Character
    {
        private int atk;

        ////Get,Set 함수
        //public void SetAtk(int atk)
        //{
        //    this.atk = atk;
        //}
        //public int GetAtk()
        //{
        //    return atk;
        //}

        //property
        //public int Atk
        //{
        //    get {  return atk; }
        //    set { atk = value; }
        //}

        //자동 프로퍼티
        public int Atk { get; set; }

        // 읽기 전용
        public int MaxHP { get; private set; }
    }



    internal class Program
    {
        
        static void Main(string[] args)
        {
            Character c = new Character();
            //c.SetAtk(10);
            //Console.WriteLine($"공격력: {c.GetAtk()}");
            c.Atk=10;
            Console.WriteLine($"공격력: {c.Atk}");
        }
    }
}
