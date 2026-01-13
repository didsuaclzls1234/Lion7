using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0113_10
{
    //캐릭터 클래스 정의
    class Character
    {
        // 필드 (Field): 클래스의 데이터
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;
        
        public Character()
        {
            name = "홍길동";
            level = 10;
            hp = 150;
            maxHP = 150;
            mp = 80;
            maxMP = 80;

        }
        public void SetInfo(string name, int level, int hp, int maxHP, int mp, int maxMP)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.maxHP = maxHP;
            this.mp = mp;
            this.maxMP = maxMP;
        }

        


        //매서드(Method): 클래스의 기능
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"MP: {mp}/{maxMP}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }
        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"   남은 HP: {hp}/{maxHP}");
        }

        public void Heal(int amount)
        {
            hp += amount;
            if (hp > maxHP) hp = maxHP;

            Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
            Console.WriteLine($"   현재 HP: {hp}/{maxHP}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //객체생성
            Character character = new Character();

            //메서드 호출 출력
            character.ShowInfo();

            //데미지 50
            character.TakeDamage(50);

            //힐 30
            character.Heal(30);

            //새 객체 생성 해서 임의값 입력후 출력
            Character character2=new Character();
            character2.SetInfo("김영희", 15, 200, 200, 120, 120);
            character2.ShowInfo();

        }
    }
}
