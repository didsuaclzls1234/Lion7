using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //삼항연산자
            //int a = 10, b = 20;
            //int max = ( a > b )? a : b;//삼항연산자
            //Console.WriteLine(max);

            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";
            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수: {score}");
            //Console.WriteLine($"결과: {result}");

            //int level = 45;
            //string grade = (level >= 50) ? "고급" :
            //               (level >= 30) ? "중급":"초급";
            //Console.WriteLine("===플레이어 등급===");
            //Console.WriteLine($"레벨:{level}");
            //Console.WriteLine($"등급:{grade}");

            //int health = 30; int maxHealth = 100;
            //string state = (health >= 70) ? "안전" :
            //               (health >= 30) ? "주의" : "위험";
            //Console.WriteLine("===플레이어 등급===");
            //Console.WriteLine($"현제 체력:{health}/{maxHealth}");
            //Console.WriteLine($"상태:{state}");

            //연산자 우선순위
            //int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
            //Console.WriteLine(result); //20

            //int adjustedResult = (10 + 2) * 5; //괄호로 우선순위 변경
            //Console.WriteLine(adjustedResult); //출력 60

            // 예제 2: 데미지 계산
            //int baseDamage=50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1= baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage +bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

            //조건문
            //int score = 85;
            //if(score >= 90){Console.WriteLine("A");}
            //else{Console.WriteLine("90점 미만");}

            //int number = 10; if (number > 15){ Console.WriteLine("15보다 큽니다"); } 
            //else { Console.WriteLine("15보다 작거나 같습니다"); }

            //int score = 75;
            //if (score >= 90) { Console.WriteLine("A 학점"); }
            //else if (score >= 80) { Console.WriteLine("B 학점"); }
            //else if (score >= 70) { Console.WriteLine("C 학점"); }
            //else {Console.WriteLine("F 학점"); }
            //int a = 10;

            //if (a == 10)
            //{
            //    Console.WriteLine("A가 " + a + "입니다.");

            //}
            //else
            //{
            //    Console.WriteLine("여긴 10이 아닌경우야");
            //}

            //Console.WriteLine("if else 끝나고나서 실행되는곳이야");

            //int a = 100;

            //if (a >= 90)
            //{
            //    Console.WriteLine("1통과");
            //}

            //if (a >= 80)
            //{
            //    Console.WriteLine("2통과");
            //}

            //int curHP = 30;
            //int maxHP = 100;

            //Console.WriteLine($"현재 체력: {curHP}/{maxHP}");
            //if (curHP <= 30)
            //{
            //    Console.WriteLine("경고 체력이 위험합니다!.");
            //    Console.WriteLine("회복 아이템을 사용하세요!.");
            //}
            //if (curHP / maxHP < 0.5)
            //{
            //    Console.WriteLine("체력이 50%이하입니다.");
            //}
            //if (curHP == 0)
            //{
            //    Console.WriteLine("게임오버");
            //    Console.WriteLine("부활 지점에서 다시 시작합니다.");
            //}
            //int enemyDistance = 5;
            //int attackRange = 3;

            //if (enemyDistance <= attackRange)
            //{
            //    Console.WriteLine("\n 적이 사거리 안에 있습니다!");
            //    Console.WriteLine("공격 가능!");
            //}

            ////아이템 구매 시스템
            //int playerGold = 500;
            //int itemPrice = 250;
            //string itemName = "강철 검";
            //Console.WriteLine("====상점===");
            //Console.WriteLine($"아이템: {itemName}");
            //Console.WriteLine($"가격: {itemPrice}골드");
            //Console.WriteLine($"소지금: {playerGold}골드\n");

            //if (playerGold >= itemPrice) //구매가능
            //{ 
            //    playerGold-=itemPrice;
            //    Console.WriteLine("구매 성공");
            //    Console.WriteLine($"{itemName}을 획득");
            //    Console.WriteLine($"남은 골드: {playerGold}");
            //}
            //else//구매불가
            //{
            //    int needGold=itemPrice-playerGold;
            //    Console.WriteLine("골드가 부족");
            //    Console.WriteLine($"필요한 골드: {needGold}골드 더 필요");
            //}
            //Console.WriteLine("====던전입장===");
            //int playerLevel = 48;
            //int requiredLevel = 50;
            //if(playerGold >= requiredLevel)
            //{
            //    Console.WriteLine("입장가능");
            //}
            //else
            //{
            //    Console.WriteLine("레벨이 부족합니다.");
            //    Console.WriteLine($"필요 레벨: {requiredLevel}");
            //    Console.WriteLine($"현재 레벨: {playerLevel}");
            //    Console.WriteLine($"레벨업이 필요합니다: {requiredLevel-playerLevel}레벨");
            //}

            //int score = 0;
            //string rank;
            //Console.WriteLine("===게임 랭크 시스템===");
            //Console.WriteLine("스코어를 입력하세요 : ");
            //score = int.Parse(Console.ReadLine());
            //Console.WriteLine($"점수:{score}");
            //if (score >= 10000)
            //{
            //    rank = "SSS";
            //    Console.WriteLine($"등급: {rank}(레전드)");
            //    Console.WriteLine("보상: 전설 아이템 + 골드 10000");
            //}
            //else if (score >= 8000)
            //{
            //    rank = "SS";
            //    Console.WriteLine($"등급: {rank}(마스터)");
            //    Console.WriteLine("보상: 영웅 아이템 + 골드 5000");
            //}
            //else if (score >= 6000)
            //{
            //    rank = "S";
            //    Console.WriteLine($"등급: {rank}(다이아)");
            //    Console.WriteLine("보상: 희귀 아이템 + 골드 3000");
            //}
            //else if (score >= 4000)
            //{
            //    rank = "A";
            //    Console.WriteLine($"등급: {rank}(플래티넘)");
            //    Console.WriteLine("보상: 고급 아이템 + 골드 1500");
            //}
            //else
            //{
            //    rank = "B";
            //    Console.WriteLine($"등급: {rank}(골드)");
            //    Console.WriteLine("보상: 일반 아이템 + 골드 500");
            //}


            //// 캐릭터 상태 판정
            //Console.WriteLine("\n=== 캐릭터 상태 ===");
            //int health = 90;
            ////헬스값을 입력받아서 테스트해보시오.

            //if (health >= 80)
            //{
            //    Console.WriteLine(" 상태: 매우 좋음");
            //}
            //else if (health >= 60)
            //{
            //    Console.WriteLine(" 상태: 좋음");
            //}
            //else if (health >= 40)
            //{
            //    Console.WriteLine(" 상태: 보통");
            //}
            //else if (health >= 20)
            //{
            //    Console.WriteLine(" 상태: 위험");
            //}
            //else
            //{
            //    Console.WriteLine(" 상태: 매우 위험!");
            //}

            //int day = 3;
            //switch (day)
            //{
            //    case 0:
            //    case 1: Console.WriteLine("월");break;
            //    case 2: Console.WriteLine("화");break;
            //    case 3: Console.WriteLine("수");break;
            //    default: Console.WriteLine("유효하지 않은 요일");break;
            //}

            //switch활용
            //jobChoice 1:전사 2:마법사 3:궁수 4:도적
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.UTF8;
            //Console.WriteLine("===캐릭터 생성===");

            //int jobChoice = int.Parse(Console.ReadLine());
            //switch (jobChoice)
            //{
            //    case 1:
            //        Console.WriteLine("직업: ⚔️ 전사");
            //        Console.WriteLine("특성: 높은 체력과 방어력");
            //        Console.WriteLine("주 무기: 검, 도끼");
            //        Console.WriteLine("스탯: HP +50, 공격력 +10"); break;
            //    case 2:
            //        Console.WriteLine("직업: 🔮 마법사");
            //        Console.WriteLine("특성: 강력한 마법 공격");
            //        Console.WriteLine("주 무기: 지팡이, 마법서");
            //        Console.WriteLine("스탯: 마나 +100, 마법력 +20"); ; break;
            //    case 3:
            //        Console.WriteLine("직업: 🏹 궁수");
            //        Console.WriteLine("특성: 원거리 공격 특화");
            //        Console.WriteLine("주 무기: 활, 석궁");
            //        Console.WriteLine("스탯: 민첩 +15, 크리티컬+10%"); break;
            //    case 4:
            //        Console.WriteLine("직업: 🗡️ 도적");
            //        Console.WriteLine("특성: 빠른 속도와 치명타");
            //        Console.WriteLine("주 무기: 단검, 쌍검");
            //        Console.WriteLine("스탯: 민첩 +20, 회피율 +15%"); break;
            //    default:
            //        Console.WriteLine("❌ 잘못된 선택입니다.");
            //        Console.WriteLine("1~4 중에서 선택해주세요."); break;
            //}
            //Console.WriteLine("\n=== 아이템 정보 ===");
            //string itemType = "weapon";

            //switch (itemType)
            //{
            //    case "weapon":
            //        Console.WriteLine("🗡️ 무기 - 공격력 증가");
            //        break;
            //    case "armor":
            //        Console.WriteLine("🛡️ 방어구 - 방어력 증가");
            //        break;
            //    case "potion":
            //        Console.WriteLine("🧪 물약 - 체력/마나 회복");
            //        break;
            //    case "accessory":
            //        Console.WriteLine("💍 장신구 - 특수 능력 부여");
            //        break;
            //    default:
            //        Console.WriteLine("❓ 알 수 없는 아이템");
            //        break;
            //}

            //// 요일별 이벤트
            //Console.WriteLine("\n=== 오늘의 이벤트 ===");
            //int dayOfWeek = 3;  // 0:일, 1:월, 2:화, 3:수, 4:목, 5:금, 6:토

            //switch (dayOfWeek)
            //{
            //    case 0:
            //        Console.WriteLine("🎁 일요일: 경험치 2배");
            //        break;
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("📅 평일: 일반 보상");
            //        break;
            //    case 5:
            //        Console.WriteLine("💰 금요일: 골드 2배");
            //        break;
            //    case 6:
            //        Console.WriteLine("🎲 토요일: 아이템 드롭률 2배");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 요일");
            //        break;}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("천마연산신공"); //엄청길게 캐스팅해야하는 구절
            //}
            //Console.WriteLine("===몬스터 웨이브 시작===");
            //int waveMonsterCount = 5;
            //for (int i = 0; i < waveMonsterCount; i++)
            //{
            //    Console.WriteLine($"👹고블린 #{i+1} 생성!");
            //}
            //Console.WriteLine($"총 {waveMonsterCount}마리 생성 완료!");

            //Console.WriteLine("===게임 시작 카운트 다운===");
            //int count = 0;
            //for (int i = 5; i > count; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}
            //Console.WriteLine("🎮 게임시작!");

            //for(; ; )
            //{
            //    Console.WriteLine("무한반복");
            //    Thread.Sleep(1000);
            //}

            //랜덤함수
            //Random random = new Random();
            //int number1=random.Next();//0~int maxValue
            //int number2=random.Next(10);//0~10
            //int number3=random.Next(1,7);//1~6
            //double number4=random.NextDouble();//0.0~1.0

            //검 종류
            //무한의 대검    10%
            //카타나         20%
            //엑스칼리버     30%
            //정기점검       40%

            //string sword = "무한의 대검";
            //Console.WriteLine("당신은 20번 뽑기가 가능합니다. 지금 실행합니다.");
            //Random rnd=new Random();
            //int random = 0;
            //for(int i = 0; i < 20; i++)
            //{
            //    random = rnd.Next(1, 101);
            //    if (random >= 90)
            //    {
            //        sword = "무한의 대검";
            //    }
            //    else if (random >= 70)
            //    {
            //        sword = "카타나";
            //    }
            //    else if (random >= 40)
            //    {
            //        sword = "엑스칼리버";
            //    }
            //    else
            //    {
            //        sword = "정기점검";
            //    }
            //    Console.WriteLine($"{sword}"); Thread.Sleep(100);
            //}

            //문제1
            //오늘의 온도를 입력받아 적잘한 옷차림을 추천하는 프로그램
            Console.Write("현재 온도: ");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature >= 30) { Console.WriteLine("🔥매우 더워요!반팔과 반바지를 입으세요."); }
            else if (temperature >= 20) { Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요."); }
            else if (temperature >= 10) { Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요."); }
            else if (temperature >= 0) { Console.WriteLine("추워요! 코트를 입으세요."); }
            else if (temperature < 0) { Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요."); }

            //문제2 게임 캐릭터 직업 선택
            Console.Write("\n 직업 선택 (1:전사, 2:마법사, 3:궁수, 4:도적): ");
            int job = int.Parse(Console.ReadLine());
            Console.WriteLine("===캐릭터 생성===");
            switch (job)
            {
                case 1:
                    Console.WriteLine("⚔️ 전사 - 높은 체력과 방어력 / 시작 스탯: HP +50, 공격력 +10"); break;
                case 2:
                    Console.WriteLine("🔮 마법사 - 특성: 강력한 마법 공격 / 시작 스탯: 마나 +100, 마법력 +20"); ; break;
                case 3:
                    Console.WriteLine("🏹 궁수 - 특성: 원거리 공격 특화 / 시작 스탯: 민첩 +15, 크리티컬+10%"); break;
                case 4:
                    Console.WriteLine("🗡️ 도적 - 특성: 빠른 속도와 회피 / 시작 스탯: 민첩 +20, 회피율 +15%"); break;
                default:
                    Console.WriteLine("❌ 잘못된 선택입니다. 1~4 중에서 선택해주세요."); break;

            }
        }
    }
}