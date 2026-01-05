using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace _1231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //age = 25;
            //Console.WriteLine("age");

            //100레벨 콘솔에 출력하기
            //int level;
            //level = 100;
            //Console.WriteLine(level);

            //리터럴은 코드에서 고정된 값을 의미합니다.
            //int number = 10;      // 정수형 리터럴
            //double pi = 3.14;     // 실수형 리터럴
            //char letter = 'A';    // 문자 리터럴
            //string name = "Alice"; // 문자열 리터럴

            //Console.WriteLine(number);
            //Console.WriteLine(pi);
            //Console.WriteLine(letter);
            //Console.WriteLine(name);

            //리터럴 연습
            //정수 플레이스코어에 100
            //int playscore = 100;
            ////실수 파이에 3.14
            //double pi = 3.14;
            ////등급 'a'
            //char grade = 'a';
            ////플레이어 이름 홍길동
            //string PlayerName = "홍길동";
            ////출력
            //Console.WriteLine(playscore);
            //Console.WriteLine(pi);
            //Console.WriteLine(grade);
            //Console.WriteLine(PlayerName);

            //변수 선언 후 저장
            //string greeting;
            //greeting = "안녕하세요";
            ////출력
            //Console.WriteLine(greeting);

            //변수초기화
            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; // 실수형 변수 선언과 초기화
            //string city = "Seoul";// 문자열 변수 선언과 초기화

            //Console.WriteLine(score);//출력: 100
            //Console.WriteLine(temperature); //출력: 36.5
            //Console.WriteLine(city);//출력 : Seoul

            //방법1: 선언 후 할당 ( 두 줄)
            int health;
            health = 100;


            //방법2: 선언과 동시에 초기화 ( 한줄 ) 
            //int maxHealth = 100;
            //int damage = 15;

            ////게임로직 출력
            //Console.WriteLine("체력 : " + health + "/" + maxHealth);

            ////데미지를 받았습니다.
            //Console.WriteLine("데미지수치" + damage);       

            //같은 데이터 타입의 변수를 쉼표로 구분해 한번에 선언
            //int x = 10, y = 20, z = 30; //정수형 x,y,z 선언하고 초기화

            //Console.WriteLine(x); //출력: 10
            //Console.WriteLine(y); //출력: 20
            //Console.WriteLine(z); //출력: 30

            //int age = 20;
            //int level = 10;
            //Console.WriteLine("나이:{0}",age);
            //string name = "철수";
            //Console.WriteLine("이름: {0}, 나이: {1}", name, age);

            //Console.WriteLine("나이: "+age);
            //Console.WriteLine($"나이: {age} 레벨 : {level}");

            //// 3D 좌표 예시
            //int posX = 0, posY = 50, posZ = 100;
            //Console.WriteLine($"X좌표:{posX}, y좌표:{posY}, z좌표:{posZ}");

            ////RGB 색상 값 예시
            //int red=255, green=128, blue=0;
            //Console.WriteLine($"R:{red}, G:{green}, B:{blue}");
            int level       = 9 ;
            int vigor       = 15;
            int mind        = 10;
            int endurnace   = 11;
            int strength    =14;
            int dexterity   = 13;
            int intelligence= 9;
            int faith       = 9;
            int arcane      = 7;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃    level        {level            }        ┃");
            Console.WriteLine($"┃    vigor        {vigor            }       ┃");
            Console.WriteLine($"┃    mind         {mind             }       ┃");
            Console.WriteLine($"┃    endurnace    {endurnace        }       ┃");
            Console.WriteLine($"┃    strength     {strength         }       ┃");
            Console.WriteLine($"┃    dexterity    {dexterity        }       ┃");
            Console.WriteLine($"┃    intelligence {intelligence     }        ┃");
            Console.WriteLine($"┃    faith        {faith            }        ┃");
            Console.WriteLine($"┃    arcane       {arcane           }        ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
