using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _0105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////상수: 값을 변경할수 없는 변수
            //const double Pi = 3.14159;//상수 Pi 선언 및 초기화
            //const int MaxScore = 100;//정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("MaxScore: " + MaxScore);


            //const int MAX_PLAYER_COUNT = 4;     //최대 플레이어:4명
            //const int STARTING_GOLD = 1000;     //시작골드:1000G
            //const string GAME_VERSION = "1.0.0";// 버전: 1.0.0

            //Console.WriteLine("**실행 결과**\n");
            //Console.WriteLine("==게임설정==");
            //Console.WriteLine($"최대 플레이어: {MAX_PLAYER_COUNT}명");
            //Console.WriteLine($"시작 골드: {STARTING_GOLD}G");
            //Console.WriteLine($"버전: {GAME_VERSION}");

            //숫자 데이터 형식: 정수와 실수를 다룰떄 사용하는 다양한 타입
            //int integerNum = 10;//정수 데이터
            //float floatNum = 3.14f;//단정밀도 실수
            //double doubleNum = 3.14159;//배정밀도 실수

            //Console.WriteLine(integerNum);//출력:10
            //Console.WriteLine(floatNum);//출력:3.14
            //Console.WriteLine(doubleNum);//출력:3.14159

            //            | 타입 | 크기 | 범위 | 용도 |
            //| ------| ------| ------| ------|
            //| byte | 1바이트 | 0 ~255 | 작은 양수(나이, 레벨) |
            //| sbyte | 1바이트 | -128 ~127 | 작은 정수 |
            //| short | 2바이트 | -32,768 ~32,767 | 작은 정수 |
            //| ushort | 2바이트 | 0 ~65,535 | 작은 양수 |
            //| int | 4바이트 | -21억 ~21억 | 가장 많이 사용 |
            //| uint | 4바이트 | 0 ~42억 | 큰 양수 |
            //| long | 8바이트 | 매우 큰 범위 | 아주 큰 수 |
            //| ulong | 8바이트 | 0 ~아주 큰 수 | 아주 큰 양수 |
            //게임 캐릭터 스탯
            //byte level=50;//레벨(0~255면 충분)
            //short attack = 155;//공격력
            //int gold = 1234567;//소지금
            //long experinence = 9999999L;//경험치(L접미사 필수)

            //Console.WriteLine("===캐릭터 정보===");
            //Console.WriteLine($"레벨:{level}");
            //Console.WriteLine($"공격력:{attack}");
            //Console.WriteLine($"소지금:{gold:N0}골드");//N0:천 단위 구분
            //Console.WriteLine($"경험치:{experinence:N0}");

            ////타입별 최대값 확인
            //Console.WriteLine("\n===타입별 최대값===");
            //Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            //Console.WriteLine($"short 최대값: {short.MaxValue}");
            //Console.WriteLine($"int 최대값: {int.MaxValue}");
            //Console.WriteLine($"long 최대값: {long.MaxValue}");

            //실수 데이터 형식: 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f;//단정밀도 실수(4바이트)
            //double doublePrecision = 3.1415926535;//배정밀도 실수(8바이트)
            //decimal highPrecision = 3.1415926535897932384626433833m;//고정밀도(16바이트)

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            ////접미사 사용: 숫자의 데이터 형싱을 명시
            //int integerValue = 100;//기본정수형
            //long longValue = 100L;//정수형(long)
            //float floatValue = 3.14f;//기본 실수형(double)
            //decimal decimalValue = 3.14m;//고정밀도 실수형(decimal)

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(decimalValue);


            //char 형식:단일 문자를 표현
            //char letter = 'A';//문자 'A'저장
            //char symbol = '#';//특수 기호 저장
            //char number = '9';//숫자 형태의 문자 저장(문자 '9', 숫자 9아님)

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //출력
            //====캐릭터 능력치====
            //float 이동속도 5.5
            //double 공격속도 1.25
            //decimal 아이템 가격 12.99
            //float move_speed = 5.5f;
            //double attack_speed = 1.25;
            //decimal item_price = 12.99m;

            //Console.WriteLine("====캐릭터 능력치====");
            //Console.WriteLine($"float   이동속도 {move_speed}");
            //Console.WriteLine($"double  공격속도 {attack_speed}");
            //Console.WriteLine($"decimal 아이템 가격 {item_price}");

            //string 형식:여러 문자를 저장
            //string greeting = "Hello, World";//문자열 저장
            //string name = "Alice";//이름 저장

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            //문자 (char) - 단 하나의 문자만
            //char grade = 'A';
            //char symbol = '★';
            //char number = '9';

            //// 문자열 (string) - 여러 문자의 조합
            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = ""; // 빈 문자열도 가능


            ////실행 결과:
            ////=== RPG 게임 ===
            ////플레이어: 홍길동
            ////등급: A등급 ★
            ////게임에 오신 것을 환영합니다!`
            //Console.WriteLine("===RPG 게임===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급 {symbol}");
            //Console.WriteLine($"{welcomeMessage}");

            //bool 형식 : 참(true) 또는 거짓(false)
            //bool isRunning = true;
            //bool isFinished = false;

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            //===게임 상태===
            //게임 진행중: True
            //일시정지: False
            //열쇠소지: False
            //문 열림: False
            //플레이어 생존: True

            //===캐릭터 상태===
            //체력: 80
            //건강 상태:True
            //위험 상태:False
            //bool isGameRunning = true;
            //bool isGamePuased = false;
            //bool hasKey = false;
            //bool isDoorOpen=false;
            //bool isplayerAlive = true;
            //int playerHP = 80;
            //bool isHealthy = playerHP >= 50;
            //bool isLowHealth = playerHP < 30;

            //Console.WriteLine("===게임상태===");
            //Console.WriteLine($"게임 진행중: {isGameRunning}");
            //Console.WriteLine($"일시정지: {isGamePuased}");
            //Console.WriteLine($"열쇠소지: {hasKey}");
            //Console.WriteLine($"문 열림: {isDoorOpen}");
            //Console.WriteLine($"플레이어 생존: {isplayerAlive}");
            //Console.WriteLine("\n===캐릭터상태===");
            //Console.WriteLine($"체력: {playerHP}");
            //Console.WriteLine($"건강 상태: {isHealthy}");
            //Console.WriteLine($"위험 상태: {isLowHealth}");

            //bool hasWeapon = true;
            //bool hasArmor = false;
            //bool hasPotion = true;

            //Console.WriteLine("\n=== 인벤토리 ===");
            //Console.WriteLine($"무기 보유: {(hasWeapon ? "있음" : "없음")}");
            //Console.WriteLine($"방어구 보유: {(hasArmor ? "있음" : "없음")}");
            //Console.WriteLine($"포션 보유: {(hasPotion ? "있음" : "없음")}");

            ////System.Int32 number = 1234;//int의 닷넷형식
            ////System.Console.WriteLine(number);

            //int number = 123;
            //string numberAsString=number.ToString();//정수를 문자열로 전환

            //bool flag = true;
            //string flagAsString=flag.ToString();

            //Console.WriteLine(numberAsString);
            //Console.WriteLine(flagAsString);

            //밀리초 단위, 1000==1초
            //Console.WriteLine("안");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕하");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕하세");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕하세요");
            //Thread.Sleep(1000);
            //Console.Clear();

            //과제
            //저번시간 만들었던 UI 하나 정해서
            //비주얼하게 만들어 보기

            //로딩중
            Console.WriteLine("로딩중....");
            Console.Write("진행률 : [");
            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("] 100% \n");


        }
    }
}
