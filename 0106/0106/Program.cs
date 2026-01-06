using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _0106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 사용자 입력을 문자열로 받기Console.Write("이름을 입력하세요: ");
            //Console.WriteLine("이름을 입력하세요");
            //string userName = Console.ReadLine(); // 사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요,{userName}님!");//입력값 출력

            //// 문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: "); 
            //string input = Console.ReadLine();// 사용자로부터 입력 받기
            //int age = int.Parse(input); // 문자열을 정수로 변환
            //Console.WriteLine($"내년에는 {age+1}살");

            ////이진수를 정수로 변환
            //Console.WriteLine("2진수 입력");
            //string binaryInput=Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);//2진수->10진수
            ////정수를 이진수로변환
            //string binaryOutput=Convert.ToString(decimalValue,2);//10진수->2진수
            //Console.WriteLine($"입력한 이진수:{binaryInput}");
            //Console.WriteLine($"10진수로 변환:{decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환:{binaryOutput}");

            //===캐릭터 생성===
            //캐릭터 이름을 입력하세요:홍길동
            //시작 레벨을 입력하세요:5
            //홍길동님의 시작 레벨은 5입니다.

            // 콘솔의 입력 및 출력 인코딩을 UTF-16 (유니코드)로 설정합니다.
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;

            //Console.WriteLine("===캐릭터 생성===");
            //Console.Write("캐릭터 이름을 입력하세요:");
            //string playerName = Console.ReadLine();
            //Console.WriteLine($"\n환영합니다, {playerName}님!");

            //Console.Write("시작 레벨을 입력하세요:");
            //string levelInput = Console.ReadLine();
            //int playerLevel = int.Parse(levelInput);
            //Console.WriteLine($"{playerName}님의 시작 레벨은 {playerLevel}입니다.");

            ////var를 사용하여 변수 선언
            //var name = "Alice";//문자열로 추론
            //var age = 25;//정수로 추론
            //var isStudent = true;//논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이 :{age}, 학생 여부: {isStudent}");

            //default 키워드를 사용한 기본값 지정

            //int defaultInt      = default;//0
            //int defaultString   = default;//null
            //int defaultBool     = default;//false

            //Console.WriteLine($"정수 기본값:{defaultInt}");
            //Console.WriteLine($"문자열 기본값:{defaultString}");
            //Console.WriteLine($"논리값 기본값:{defaultBool}");

            //1.암시적 변환(작은타입->큰 타입)
            //int samllNumber = 100;
            //long bigNumber = samllNumber;//int->long 자동변환
            //double doubleNumber = samllNumber;//int->double 자동변환

            //Console.WriteLine("===암시적변환===");
            //Console.WriteLine($"int:{samllNumber.GetType()}");
            //Console.WriteLine($"long:{bigNumber.GetType()}");
            //Console.WriteLine($"double:{doubleNumber.GetType()}");

            ////2.명시적 변환 (큰타입->작은타입)
            //double pi = 3.141592;
            //int intPi = (int)pi;//소수점을 버림(명시적 변환 필요)
            //Console.WriteLine("\n===명시적 변환===");
            //Console.WriteLine($"double:{pi}");
            //Console.WriteLine($"int로 변환:{intPi}");

            //3. 문자열을 숫자로 변환
            //string scoreText = "95";
            //int score=int.Parse(scoreText);//문자열->상수

            //String priceText = "19.99";
            //double price = double.Parse(priceText);
            //Console.WriteLine("\n===문자열변환===");
            //Console.WriteLine($"상수(문자열) : {scoreText}->숫자: {score}");
            //Console.WriteLine($"가격(문자열) : {priceText}->숫자: {price}");

            ////4.숫자를 문자열로 변환
            //int playerLevel = 50;
            //string levelText=playerLevel.ToString();
            //Console.WriteLine("==숫자를 문자열로==");
            //Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열:{levelText}");

            ////연산자
            //int a = 5, b = 3;
            //int sum = a + b;
            //bool isEqual = (a == b);
            //Console.WriteLine($"합 : {sum}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");

            //단항 연산자
            //int number = 5; Console.WriteLine(+number); // 양수 출력: 5
            //Console.WriteLine(-number); // 음수 출력: -5

            //bool flag = true; Console.WriteLine(!flag); // 논리 부정: False

            //int a = 5;
            //int b = 4;
            //a += b;
            //Console.WriteLine(a);a = 5;
            //a -= b;
            //Console.WriteLine(a);a = 5;
            //a *= b;
            //Console.WriteLine(a);a = 5;
            //a /= b;
            //Console.WriteLine(a);a = 5;
            //a %= b;
            //Console.WriteLine(a);

            //캐릭터 스탯 계산
            //int baseAttack = 50;
            //int weaponDamage=30;
            //int totalAttack = baseAttack + weaponDamage;

            //Console.WriteLine("공격력계산");
            //Console.WriteLine($"기본공격력 : {baseAttack}");
            //Console.WriteLine($"무기데미지 : {weaponDamage}");
            //Console.WriteLine($"총 공격력 : {totalAttack}");

            ////데미지 계산
            //int playerHealth = 100;
            //int damage = 25;
            //playerHealth -= damage;
            //Console.WriteLine("\n데미지 계산");
            //Console.WriteLine($"받은 데미지 : {damage}");
            //Console.WriteLine($"남은 체력 : {playerHealth}");

            ////경험치 계산
            //int monsterSkilled = 5;
            //int expPerMonster = 100;
            //int totalExp = monsterSkilled * expPerMonster;
            //Console.WriteLine("경험치 획득");
            //Console.WriteLine($"처치한 몬스터 : {monsterSkilled}마리");
            //Console.WriteLine($"획득한 경험치 : {totalExp}");

            ////아이템 분배
            //int totalGold = 1000;
            //int playerCount = 4;
            //int goldPerPlayer = totalGold / playerCount;
            //int remainGold = totalGold % playerCount;
            //Console.WriteLine("골드분배");
            //Console.WriteLine($"총 골드 : {totalGold}");
            //Console.WriteLine($"플레이어 수 : {playerCount}명");
            //Console.WriteLine($"1인당 골드 : {goldPerPlayer}");
            //Console.WriteLine($"남은 골드 : {remainGold}");

            //증감 연산자 ++ --
            //int b = 3;
            //b++;//후위 증가
            //Console.WriteLine(b);

            //--b;//전위 감소
            //Console.WriteLine(b);

            //int killCount = 0;
            //Console.WriteLine("몬스터처치");
            //Console.WriteLine($"고블린 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"오크 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"드래곤 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"총 처지수: {killCount}");

            //int bullet = 30;
            //Console.WriteLine("\n사격");
            //Console.WriteLine($"남은 탄약: {bullet}");
            //Console.WriteLine($"발사! 남은 탄약: {--bullet}");
            //Console.WriteLine($"발사! 남은 탄약: {--bullet}");
            //Console.WriteLine($"발사! 남은 탄약: {--bullet}");

            //int countdown = 3;
            //Console.WriteLine("\n카운트다운");
            //Console.WriteLine($"{countdown--}");
            //Console.WriteLine($"{countdown--}");
            //Console.WriteLine($"{countdown--}");
            //Console.WriteLine("발사!");

            //관계형 연산자와 논리연산자
            //int x = 5, y = 10;
            //Console.WriteLine(x<y);
            //Console.WriteLine(x>y);
            //Console.WriteLine(x<=y);
            //Console.WriteLine(x>=y);
            //Console.WriteLine(x==y);
            //Console.WriteLine(x!=y);

            ////and
            //bool a=true;
            //bool b=true;
            //Console.WriteLine(a&&b);
            //a = false;
            //b = true;
            //Console.WriteLine(a && b);
            //a = true;
            //b = false;
            //Console.WriteLine(a && b);
            //a = false;
            //b = false;
            //Console.WriteLine(a && b);

            ////or
            //a = false; b = false;
            //Console.WriteLine(a || b);
            //a = false; b = true;
            //Console.WriteLine(a || b);
            //a = true; b = false;
            //Console.WriteLine(a || b);
            //a = true; b = true;
            //Console.WriteLine(a || b);

            ////not
            //a = true;
            //Console.WriteLine(!a);

            //int x = 5;//0101
            //int y = 3;//0011
            //string binary = Convert.ToString(x & y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8,'0')}");
            //binary = Convert.ToString(x | y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8,'0')}");
            //binary = Convert.ToString(x ^ y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8,'0')}");
            //binary = Convert.ToString(~x,2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8,'0')}");

            //int value = 4;//0100;
            //string binary = Convert.ToString(value<<1, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");
            //binary = Convert.ToString(value >> 1, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //int inventory = 0;// 0000 0000
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory,2).PadLeft(8,'0')}");

            ////슬롯 번호
            //int slot1 = 1;//활
            //int slot2 = 2;//지팡이

            ////슬롯 0에 활 추가
            //inventory = inventory | (1 << slot1);//2번째로 1 추가
            //Console.WriteLine($"슬롯 {slot1}에 활 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory,2).PadLeft(8,'0')}");

            ////슬롯 0에 활 추가
            //inventory = inventory | (1 << slot2);//2번째로 1 추가
            //Console.WriteLine($"슬롯 {slot2}에 활 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory,2).PadLeft(8,'0')}");


            //연습문제
            //문제 1: RPG 체력 계산기
            int currentHP = 80;
            int maxHP = 100;
            int monsterDamage = 25;
            int HealingPotion = 30;
            int poisonDamage = 5;
            Console.WriteLine("Q1");
            Console.WriteLine($"초기 체력: {currentHP}/{maxHP}");
            Console.WriteLine($"데미지 -{monsterDamage}: {currentHP -= monsterDamage}/{maxHP}");
            Console.WriteLine($"회복  +{HealingPotion}: {currentHP += HealingPotion}/{maxHP}");
            Console.WriteLine($"독 데미지 -{poisonDamage}: {currentHP -= poisonDamage}/{maxHP}");

            //문제 2: 경험치와 레벨 계산
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            Console.WriteLine("\nQ2");
            Console.WriteLine($"처치한 몬스터: {monstersKilled}마리");
            Console.WriteLine($"획득 경험치: {monstersKilled * expPerMonster}");
            Console.WriteLine($"레벨업까지 필요: {expForLevelUp - monstersKilled * expPerMonster}");

            //문제 3: 아이템 분배 시스템
            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine("\nQ3");
            Console.WriteLine($"총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMembers}");
            Console.WriteLine($"1인당 골드: {totalGold / partyMembers}");
            Console.WriteLine($"남은 골드: {totalGold % partyMembers}");

            //문제 4: 던전 입장 가능 여부
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int curHP = 60;
            int MaxHP = 100;
            Console.WriteLine("\nQ4");
            Console.WriteLine("==던전 입장 조건==");
            Console.WriteLine($"레벨 조건 ({requiredLevel} 이상): {playerLevel>=requiredLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건 (50% 이상):{curHP / MaxHP >= 0.5}");
            Console.WriteLine($"입장 가능: {(playerLevel >= requiredLevel) && hasKey && (curHP / MaxHP >= 0.5)}");
            
            //문제 5: 상점 할인 계산기
            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;
            double lastPrice = 5000;
            Console.WriteLine("\nQ5");
            Console.WriteLine($"원가: {originalPrice}골드");
            if (isVIP)
            {lastPrice = originalPrice * 0.8;
                Console.WriteLine($"VIP 할인 (20%): {lastPrice}"); }
            if (hasCoupon)
            { Console.WriteLine($"쿠폰 할인 (-500): {lastPrice-=500}"); }
            Console.WriteLine($"최종 가격:{lastPrice}");




        }
    }
}
