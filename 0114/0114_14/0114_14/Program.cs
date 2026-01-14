using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0114_14
{
    public class Character
    {
        public virtual void Render()
        {
            Console.WriteLine("캐릭터");
        }
    }
    public class Warrior : Character
    {
        public override void Render()
        {
            Console.WriteLine("워리어");
        }

    }
    public class Mage : Warrior
    {
        public override void Render()
        {
            Console.WriteLine("마법사");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Character character = new Character();
            // character.Render();

            //Character character1=new Warrior();//업 캐스팅
            // character1.Render();

            // Character mage = new Mage();
            // mage.Render();

            Character character = new Warrior();//업캐스팅
                                                
            //Warrior warrior = (Warrior)character;//다운캐스팅


            //is 연산자 문법
            //if (obj is SpecificType)
            //{
            //    // obj는 SpecificType이거나 그 자식
            //    SpecificType specific = (SpecificType)obj;
            //}

            //// C# 7.0+ 패턴 매칭
            //if (obj is SpecificType specific)
            //{
            //    // 타입 확인 + 변환을 동시에
            //    specific.Method();
            //}

            //is 연산자 문법
            //if (character is Warrior)
            //{
            //    Warrior warrior = (Warrior)character;
            //    warrior.Render();
            //}

            // as 연산자 문법
            //ChildType child = parent as ChildType;

            //if (child != null)
            //{
            //    // 캐스팅 성공
            //    child.Method();
            //}
            //else
            //{
            //    // 캐스팅 실패
            //}

            Warrior warrior = character as Warrior;

            if (warrior != null)
            {
                warrior.Render();
            }
        }
    }
}
