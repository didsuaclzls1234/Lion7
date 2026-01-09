using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _0109
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();
        static void Main(string[] args)
        {
            //int[] score= new int[5];
            //int[] numbers = new int[] { 10, 20,30,40,50 };
            //int[] values = { 1, 2, 3, 4, 5 };
            //score[0] = 1;
            //score[1] = 2;
            //score[2] = 3;
            //score[3] = 4;
            //score[4] = 5;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(score[i]);
            //}

            //인벤토리 시스템
            //string[] inventory = new string[] {"회복포션","마나포션","강철 검","가죽 갑옷","마법 반지"};
            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} {inventory[i]}");
            //}

            //입력을 받아 아이템 추가 (10개)
            //string[] inventory = new string[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    string item = Console.ReadLine();
            //    inventory[i] = item;
            //}
            //Console.WriteLine($"아이템 목록");
            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"{i+1} {inventory[i]}");
            //}

            ////특정 아이템 사용
            //string[] inventory = new string[] { "회복포션", "마나포션", "강철 검", "가죽 갑옷", "마법 반지" };

            //Console.WriteLine($"{inventory[0]}를 사용했습니다.");
            //inventory[0] = "비어있음";
            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} {inventory[i]}");
            //}

            ////플레이어 스탯 배열
            //Console.WriteLine("===캐릭터 스탯===");
            //int[] stats = new int[] { 100, 50, 80, 60, 45 };
            //string[] statName = new string[] { "HP", "MP", "공격력", "방어력", "민첩" };
            //for (int i = 0; i < stats.Length; i++)
            //{
            //    Console.WriteLine($"{statName[i]}: {stats[i]}");
            //}

            //=== 일일 퀘스트 진행도 ===
            //고블린: 5 / 5 ✅ 완료
            //오크: 3 / 5 ⏳ 진행중
            //슬라임: 8 / 5 ✅ 완료
            //드래곤: 2 / 5 ⏳ 진행중
            //좀비: 7 / 5 ✅ 완료
            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");
            //int[] dailykills = new int[] { 5, 3, 8, 2, 7 };
            //int requiredkills = 5;
            //string[] target = new string[] { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //for (int i = 0; i < dailykills.Length; i++)
            //{
            //    if (dailykills[i] >= 5)
            //    {
            //        Console.WriteLine($"{target[i]}: {dailykills[i]} / {requiredkills} ✅ 완료");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{target[i]}: {dailykills[i]} / {requiredkills}  ⏳ 진행중");
            //    }
            //}

            //배열길이
            //int[] scores = { 85, 92, 78, 95, 88 };
            //Console.WriteLine("총 점수 개수: " + scores.Length);
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i + 1}: {scores[i]}점");
            //}

            ////합계 계산
            //int sum = 0;
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}
            //Console.WriteLine($"총점 : {sum}");
            //Console.WriteLine($"평균 : {sum/(float)scores.Length}점");

            ////최고점 찾기
            //int highScore = 0;
            //for(int i = 0;i<scores.Length;i++)
            //{
            //    if(scores[i] > highScore)
            //    {
            //        highScore = scores[i];
            //    }
            //}
            //Console.WriteLine($"최고점: {highScore}");

            ////최저점 찾기
            //int lowScore = 100;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < lowScore)
            //    {
            //        lowScore=scores[i];
            //    }
            //}
            //Console.WriteLine($"최저점: {lowScore}");

            ////Array 클래스 메서드
            //Console.WriteLine("===Array 메서드===");
            ////정렬
            //int[] sortedScores=(int[]) scores.Clone();
            //Array.Sort(sortedScores);
            //Console.WriteLine("정렬 후:");


            ////foreach 반복문
            //foreach (int score in sortedScores)
            //{
            //    Console.WriteLine(score);
            //}
            ////역순정렬
            //Array.Reverse(sortedScores);
            //Console.WriteLine("역순: ");
            //for (int i = 0; i < sortedScores.Length; i++)
            //{
            //    Console.WriteLine(sortedScores[i]);
            //}

            ////검색
            //int searchScore = 92;
            //int index=Array.IndexOf(scores, searchScore);
            //Console.WriteLine($"{searchScore}점의 위치: index{index}");
            ///////////////////

            //다차원 배열
            //// 방법 1: 크기만 지정
            //int[,] grid = new int[3, 4];  // 3행 4열

            //// 방법 2: 선언과 동시에 초기화
            //int[,] numbers = new int[2, 3]
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};
            //// 방법 3: new 생략 (간단한 초기화)
            //int[,] scores =
            //{{ 90, 85, 88 },{ 92, 78, 95 },{ 87, 91, 84 } };

            ////배열 크기 확인
            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2


            //Console.WriteLine("===좌석 배치도==");
            //string[,] seats = new string[3,3]; 
            //for(int i = 0;i < seats.GetLength(0); i++)
            //{
            //    for(int j = 0;j < seats.GetLength(1); j++)
            //    {
            //        char alphabet = (char)('A'+i);
            //        seats[i,j] = ($"[{alphabet}{j+1}]");
            //        Console.Write($"{seats[i,j]}");
            //    }
            //    Console.WriteLine();
            //}
            ////첫 번째 좌석: A1
            ////중앙 좌석: B2
            ////마지막 좌석: C3
            //Console.WriteLine("첫 번째 좌석: " + seats[0, 0]);
            //Console.WriteLine("중앙 좌석: " + seats[1, 1]);
            //Console.WriteLine("마지막 좌석: " + seats[2, 2]);

            //2D 게임맵
            //int[,] map = new int[5, 5]
            //{
            //    {0,0,1,0,0 },
            //    {0,2,1,0,3 },
            //    {0,0,1,0,0 },
            //    {1,1,1,0,3 },
            //    {0,0,0,0,9 }
            //};
            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0:통로 1:벽 2:몬스터 3:보물 9:출구\n");

            //for(int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y, x])
            //        {
            //            case 0: Console.Write("□"); break;
            //            case 1: Console.Write("■"); break;
            //            case 2: Console.Write("👹"); break;
            //            case 3: Console.Write("💎"); break;
            //            case 9: Console.Write("🚪"); break;
            //            default: break;
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //성적표
            //Console.WriteLine(" === 성적표 ===");
            //string[] subject = { "국어 ", "영어 ", "수학 ", "과학 " };
            //string[] student = { "김철수 ", "이영희 ", "박민수 " };
            //int[,] transcript= new int[3, 4] { { 85, 90, 88, 92 },{78,85,90,87 },{92,88,95,90 }};
            //Console.Write($"이름  ");
            //foreach(string sub in subject)
            //{
            //    Console.Write(sub);
            //}
            //Console.WriteLine("평균");
            //Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            //for (int i=0;i<student.Length;i++)
            //{
            //    float avg = 0;
            //    Console.Write($"{student[i]}");
            //    for(int j = 0; j < subject.Length; j++)
            //    {
            //        Console.Write($"{transcript[i,j]}   ");
            //        avg += transcript[i, j];
            //    }
            //    avg = avg / subject.Length;
            //    Console.Write($"{avg:F1}");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("/=== 과목별 평균 ===");
            //for (int i = 0; i < subject.Length; i++)
            //{
            //    float sum = 0;
            //    for (int j = 0; j < student.Length; j++)
            //    {
            //        sum += transcript[j, i];
            //    }
            //    Console.WriteLine($"{subject[i]}: {sum / student.Length:f1}");
            //}

            //가변배열
            //string[][] raid = new string[3][];
            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };
            //raid[1] = new string[] { "도적", "전사","힐러"};
            //raid[2] = new string[] { "마법사","궁수", "힐러", "전사", "탱커" };

            //Console.WriteLine("===레이드 파티 구성===");
            //for (int i = 0;  i < raid.Length; i++)
            //{
            //    Console.WriteLine($"파티{i + 1}({raid[i].Length}명):");
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.WriteLine($" - {raid[i][j]}");
            //    }
            //}


            ////동적배열 - List<T>
            ////선언 방법
            //List<int> numbers =new List<int>();
            //List<string> names =new List<string>();
            //List<float> prices=new List<float>();

            ////초기값가 함께 선언
            //List<int> scores=new List<int> { 85, 90, 78, 95 };
            //List<string> items =new List<string> {"검","방패","포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };

            //List<string> items = new List<string>();

            //// Add: 끝에 추가
            //items.Add("회복 포션");
            //items.Add("마나 포션");

            //List<string> inventory=new List<string>();
            //Console.WriteLine("===도적 인벤토리 시스템===");
            //inventory.Add("회복 포션");
            //inventory.Add("회복 포션");
            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");
            //Console.WriteLine("아이템 4개 추가");
            //Console.WriteLine($"인벤토리 ({inventory.Count}개):");
            //foreach (string s in inventory)
            //{
            //    Console.WriteLine($"{s}");
            //}
            //Console.WriteLine();
            //inventory[0] = "초록 포션";
            //foreach (string s in inventory)
            //{
            //    Console.WriteLine($"{s}");
            //}
            //Console.WriteLine();

            ////특정위치에 삽입
            //inventory.Insert(1, "칼");
            //foreach (string s in inventory)
            //{
            //    Console.WriteLine($"{s}");
            //}
            //Console.WriteLine();

            ////아이템 제거(remove) //처음 삭제 Remove, 전체삭제 RemoveAll,지정 인덱스 삭제 RemoveAt
            //inventory.Remove("회복 포션");
            //foreach (string s in inventory)
            //{
            //    Console.WriteLine($"{s}");
            //}
            //Console.WriteLine();

            //inventory.RemoveAt(0);
            //foreach (string s in inventory)
            //{
            //    Console.WriteLine($"{s}");
            //}
            //Console.WriteLine();

            ////
            //Dictionary

            //Dictionary<string, int> stats = new Dictionary<string, int>();

            ////데이터추가
            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);


            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            ////키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(stats[searchStat]);
            //}
            //else
            //{
            //    Console.WriteLine("해당스탯이 없습니다.");
            //}

            ////collection 활용해보기
            //Console.WriteLine("=== 상점 아이템 ===");
            //Dictionary<string,int> price =new Dictionary<string, int>() 
            //{
            //    {"회복포션",50},{"마나 포션",40},{"강철 검",500 },{"가죽 갑옷",300 },{"마법 반지", 1000}
            //};
            //foreach (KeyValuePair<string, int> stuff in price) { Console.WriteLine($"{stuff.Key}: {stuff.Value}골드"); }

            //int haveMoney = 600;
            //Console.WriteLine($"남은 골드: {haveMoney}");
            //string searchThig=Console.ReadLine();
            //if (price.ContainsKey(searchThig))
            //{
            //    if (price[searchThig] < haveMoney)
            //    {
            //        haveMoney-=price[searchThig];
            //        Console.WriteLine($"'✅{searchThig}' 구매 성공!");
            //        Console.WriteLine($"남은 골드: {haveMoney}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("소지 금액이 모자립니다.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("헤당 상품이 없습니다.");
            //}


            Console.SetWindowSize(80, 25);//콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);//버퍼 크기도 동일하게 설정(스크롤방지)

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };//배열 문자열로 그리기



            int playerX = 0, playerY = 12;

            string missile = "==>";
            List<int> missileX = new List<int>();
            List<int> missileY = new List<int>();

            ConsoleKeyInfo keyInfo;//키정보
            Console.CursorVisible = false;//콘솔 커서 안보이게 하기

            //시간을 계산해서 1초 루프
            int dwTime = Environment.TickCount;// 1/1000 초가 흐릅니다.
            while (true)
            {
                //0.01초마다 루프
                if (dwTime + 10 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    //키 영역
                    int pressKey; //키값을 받기 위한 정수형 변수

                    if (Console.KeyAvailable) //키가 눌렸을때 true
                    {
                        pressKey = _getch();
                        if (pressKey == 224) pressKey = _getch();

                        switch (pressKey)
                        {
                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: //스페이스바 - 미사일
                                missileX.Add(playerX + 3);
                                missileY.Add(playerY + 1);
                                break;
                        }
                    }

                    for (int i = missileX.Count - 1; i >= 0; i--)
                    {
                        missileX[i] += 2; // 미사일 속도

                        // 화면을 벗어나면 제거
                        if (missileX[i] > 77)
                        {
                            missileX.RemoveAt(i);
                            missileY.RemoveAt(i);
                        }
                        else
                        {
                            Console.SetCursorPosition(missileX[i], missileY[i]);
                            Console.WriteLine(missile);
                        }
                    }


                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }
                }
            }
        }
    }
}
