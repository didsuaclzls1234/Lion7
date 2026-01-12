using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _0112
{
    internal class Program
    {
        //1단계  기본함수
        static void SayHello()
        {
            Console.WriteLine("안녕!");
            Console.WriteLine("게임 시작!");
        }
        //함수 정의: 게임시작 메시지
        static void ShowGameStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ ⚔ RPG 게임 시작 ⚔                 ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }
        //함수 정의: 구분선 출력
        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        //2단계 매개변수가 있는 함수: int 넘겨보기
        //static void Attack(int atk)
        //{
        //    Console.WriteLine("공격력 전달받음. :"+atk);
        //}

        //매개변수 2개 넘겨보기
        static void Attack2(int atk, int def) 
        {
            Console.WriteLine("공격력: "+atk);
            Console.WriteLine("방어력: "+def);
        
        }
        //함수로 만들기
        static void status(string name,int atk, int def, int dex, int luck)
        {
            Console.WriteLine("플레이어 이름: "+name);
            Console.WriteLine("공격력: "+atk);
            Console.WriteLine("방어력: "+def);
            Console.WriteLine("민첩: "+dex);
            Console.WriteLine("운: "+luck);
            
        }
        //2단계 활용
        static void GreetPlayer(string playerName)
        {
            Console.WriteLine($"환영합니다. {playerName}님!");
        }
        static void ShowPlayerInfo(string job, int level)
        {
            Console.WriteLine($"직업: {job}");
            Console.WriteLine($"레벨: {level}");
        }
        //매개변수 3개 체력바 출력
        static void DrawHealthBar(int cur,int max, int barLength)
        {
            Console.WriteLine("HP[");
            int filledLength=(int)((double)cur/max*barLength);
            for(int i=0;i<barLength;i++)
            {
                if (i < filledLength)
                    Console.Write("■");
                else
                    Console.Write("□");
            }
            Console.WriteLine($"]{cur}/{max}");
        }
        //데미지 계산 출력
        static void ShowDamage(string attacker, string target, int damage)
        {
            Console.WriteLine($"{attacker}의 공격!");
            Console.WriteLine($"{target}에게{damage} 데미지!");
        }
        

        //3단계 반환값이 있는 함수
        //정수반환
        static int getNumber()//정수반환
        {
            return 42;
        }
        //문자열 반환
        string GetName()        // 문자열 반환
        {
            return "전사";
        }
        //문자열 반환 2단계
        static string ConnectMessage(string name)
        {
            return name + "님 접속하셨습니다.";
        }

        bool IsAlive()         // 논리값 반환
        {
            return true;
        }
        //메서드 오버로딩 예시
       

        static void Attack()
        {
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지 : 50");
        }
        //매개변수1개 
        static void Attack(string target)
        {
            Console.WriteLine($"{target}기본공격");
            Console.WriteLine("데미지 : 50");
        }
        static void Attack(string target, int damage)
        {
            Console.WriteLine($"{target}기본공격");
            Console.WriteLine($"데미지 : {damage}");
        }

        static void Attack(string skillName, string target, int damage)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        }

        //기본 매개변수 사용
        static void CastFireBall(string target="테스트", int damage = 100, int manaCost = 30)
        {
            Console.WriteLine($"파이어볼 시전");
            Console.WriteLine($"대상: {target}");
            Console.WriteLine($"데미지: {damage}");
            Console.WriteLine($"마나 소모:{manaCost}");
            
        }

        static void useItem(string potion="회복 포션",int healAmount=50)
        {
            Console.WriteLine($"\n💊 {potion} 사용!\n회복량: {healAmount} HP");
        }
        static void spawnMob(string monster = "슬라임", int level = 1, int number = 1)
        {
            Console.WriteLine($"✨ {monster} 소환!\n레벨:{level}\n수량: {number}마리");
        }
        //ref 사용 예제
        static void Attack(ref int a)
        {
            Console.WriteLine("공격력 : " + a); a++;
        }

        //out 사용 예제
        static void Attack(out int attack, out int defense) { attack = 10;defense = 20; attack++;defense++; }

        //ref 활용-swap 예제
        static void swap(ref int a,ref int b)
        {
            int swap;
            swap = a;
            a = b;
            b = swap;
        }

        //재귀함수
        static void recursive()
        {
            Console.WriteLine("?");
            recursive();//무한 루프
        }
        static int SumToN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return n + SumToN(n - 1);// n+(n-1까지의 합)
        }
        static void Main(string[] args)
        {
            //함수 정의 문법
            // 반환타입 함수이름(매개변수){함수내용}
            //{
            //    // 실행할 코드
            //    return 반환값;  // 반환타입이 void가 아닐 때
            //}

            //Console.WriteLine("함수 호출");
            //SayHello();
            //SayHello();//재사용성

            /////////////////////
            ////함수 호출
            //ShowGameStart();
            //Console.WriteLine();

            //SayHello();
            //PrintSeparator();

            //Console.WriteLine("게임 메뉴를 불러옵니다.");

            //PrintSeparator();
            //Console.WriteLine("게임 종료");
            //PrintSeparator();


            /////////
            ///////int 넘겨보기
            //Attack(100);
            //Attack2(100, 20);

            //함수로 만들어보기
            //status("홍길동", 100, 20, 20, 10);

            //2단계 활용 에제
            //GreetPlayer("홍길동");
            //Console.WriteLine();

            //ShowPlayerInfo("전사", 50);
            //Console.WriteLine();

            //DrawHealthBar(75, 100, 20);
            //DrawHealthBar(30, 100, 20);
            //DrawHealthBar(100, 100, 20);
            //Console.WriteLine();

            //ShowDamage("플레이어", "고블린", 85);
            //Console.WriteLine();
            //ShowDamage("드래곤", "플레이어", 140);

            //int num=getNumber();
            //Console.WriteLine("숫자반환: "+num);

            //string cm=ConnectMessage("홍길동");
            //Console.WriteLine(cm);

            //매서드 오버로딩
            //Attack("몬스터");

            //Attack("몬스터", 100);

            //Attack("몬스터",  "천마일섬",100000);


            //매개변수 지정 예제
            //모든 매개변수 지정
            //CastFireBall("고블린", 150, 40);
            ////미리 지정된 매개변수 있어서 사용가능한 방식
            //CastFireBall("오크", 20);
            ////target만 적기
            //CastFireBall("드래곤");
            //CastFireBall();
            ////명명된 인수 사용
            //CastFireBall("트롤", manaCost: 300);

            //기본 매개변수 예제
            //Console.WriteLine("===아이템 사용===");
            //useItem();
            //useItem("고급 회복 포션",100);
            //Console.WriteLine("===소환 마법===");
            //spawnMob();
            //spawnMob("고블린", 5);
            //spawnMob("드래곤",number:3,level:50);

            //ref 키워드
            //int a = 10;
            //Attack(ref a);
            //Console.WriteLine(a);//11이 출력됨

            //out 키워드
            //int attack;
            //int defense;
            //Attack(out attack, out defense);
            //Console.WriteLine($"{attack},{defense}");

            //swap 예제
            //int x = 10;
            //int y = 20;
            //int temp;
            ////temp = x;
            ////x = y;
            ////y = temp;
            ////Console.WriteLine($"{x},{y}"); 

            ////swap 함수
            //swap(ref x,ref y);
            //Console.WriteLine($"{x},{y}");

            //재귀함수-자기자신호출
            //recursive();

            //1부터 n 까지의 합
            int sum = SumToN(10);
            Console.WriteLine(sum);

            //전역변수 지역변수
            //필요시 사용, 관리 철저 필수
        }

    }
}
