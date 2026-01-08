using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<9)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //예제 2: 10부터 1까지 카운트 다운
            //Console.WriteLine("\n===예제 2: 카운트 다운===");
            //int countdown = 10;
            //while (countdown > 0)
            //{
            //    Console.WriteLine(countdown);
            //    countdown--;
            //}

            ////예제 3 (1+2+3+4+5)구하기
            //Console.WriteLine("\n예제3: 합계구하기");
            //int sum = 0;
            //int i = 1;
            //while (i <= 5)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //예제4 특정 값까지 반복
            //Console.WriteLine("\n=== 예제4: 목표 달성하기===");
            //int coins = 0;
            //int target = 50;
            //int day = 0;
            //while (coins < target) {
            //    coins += 10;
            //    day++;
            //    Console.WriteLine($"{day}일차: 코인 {coins}개");
            //}
            //Console.WriteLine($"🎉목표 달성! {day}일 걸렸습니다.");

            //int x = 5;
            //do { Console.WriteLine("최소 한번 실행");x--; }while (x > 0);

            //string choice;
            //int totalPrice = 0;
            //do{
            //    //메뉴출력
            //    Console.WriteLine("메뉴판");
            //    Console.WriteLine("1. 짜장면 - 5,000원");
            //    Console.WriteLine("2. 짬뽕 - 6,000원");
            //    Console.WriteLine("3. 탕수육 - 15,000원");
            //    Console.WriteLine("4. 볶음밥 - 7,000원");
            //    Console.WriteLine("0. 주문 완료");
            //    Console.WriteLine("=========================");
            //    Console.Write("메뉴 번호를 선택하세요: ");

            //    choice = Console.ReadLine();

            //    //메뉴 선택 처리
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("짜장면 추가! (+5,000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "2":
            //            Console.WriteLine("짜장면 추가! (+6,000원)");
            //            totalPrice += 6000;
            //            break;
            //        case "3":
            //            Console.WriteLine("짜장면 추가! (+15,000원)");
            //            totalPrice += 15000;
            //            break;
            //        case "4":
            //            Console.WriteLine("짜장면 추가! (+7,000원)");
            //            totalPrice += 7000;
            //            break;
            //        case "0":
            //            Console.WriteLine("주문을 완료합니다.");
            //            break;
            //        default:
            //            Console.WriteLine("잘못된 선택입니다.");
            //            break;
            //    }

            //    //0번 선택 전까지
            //    if (choice != "0")
            //    {
            //        Console.WriteLine($"현재 총액: {totalPrice:N0}원");
            //    }
            //} while(choice!="0");

            //for(int i = 0; i <= 10; i++)
            //{
            //    if (i == 5) break;

            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5) continue;

            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i %2==0) continue;

            //    Console.WriteLine(i);
            //}
            //    int n = 1;
            //start:
            //    if (n <= 5) { Console.WriteLine(n); n++; goto start; } // 레이블로 이동}

            //////////
            //대장장이 키우기
            //Random rand = new Random();

            //Console.WriteLine(" 대장장이 키우기 ");

            //int pmoney = 100;
            //int input;
            //int rnd;

            //Thread.Sleep(500);


            ////무한반복
            //while (true)
            //{
            //    Console.Clear(); //화면지우기
            //    Console.WriteLine("1. 나무캐기 ");
            //    Console.WriteLine("2. 장비뽑기 ");
            //    Console.WriteLine("3. 나가기 ");
            //    Console.Write("입력 : ");
            //    input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

            //    if (input == 1) //나무캐기화면
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("나무캐기(엔터)");
            //            Console.WriteLine("뒤로가기 x");

            //            string str = Console.ReadLine();

            //            pmoney += 100;
            //            Console.WriteLine("소지금 : " + pmoney);
            //            if (str == "x")
            //            {
            //                Console.WriteLine("뒤로가기");
            //                break;
            //            }


            //        }
            //    }
            //    else if (input == 2)
            //    {
            //        //장비뽑기
            //        if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
            //        {
            //            pmoney -= 1000;

            //            //20번 뽑기
            //            for (int i = 1; i <= 20; i++)
            //            {
            //                rnd = rand.Next(1, 101);

            //                if (rnd == 1) // 1퍼
            //                {
            //                    Console.WriteLine("도끼등급 SSS");
            //                }
            //                else if (rnd >= 2 && rnd <= 6)
            //                {
            //                    Console.WriteLine("도끼등급 SS");
            //                }
            //                else if (rnd >= 7 && rnd <= 17)
            //                {
            //                    Console.WriteLine("도끼등급 S");
            //                }
            //                else if (rnd >= 18 && rnd <= 38)
            //                {
            //                    Console.WriteLine("도끼등급 A");
            //                }
            //                else if (rnd >= 39 && rnd <= 69)
            //                {
            //                    Console.WriteLine("도끼등급 B");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("도끼등급 C");
            //                }
            //                Thread.Sleep(500); //0.5초정도로 뽑혀라.

            //            }


            //        }
            //        else
            //        {
            //            Console.WriteLine("돈이 부족합니다. \n");
            //            Thread.Sleep(1000);
            //        }
            //    }
            //    else if (input == 3)
            //    {
            //        Console.WriteLine("게임을 나갑니다.");
            //        Environment.Exit(0);
            //    }
            //}
            ////////////
            ///

            //for (int i = 0; i < 3; i++) {
            //    for (int j = 0; j < 3; j++) {
            //        Console.WriteLine($"i:{i} j:{j} ");
            //    }
            //    Console.WriteLine();
            //}

            //예제 1: 사각형 그리기

            //for (int i = 0; i < 3; i++)
            //{
            //   for (int j = 0; j < 3; j++) {
            //           Console.Write($"□ ");
            //        }
            //        Console.WriteLine();
            //    }

            //예제 2:숫자표
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{j+1} ");
            //    }
            //    Console.WriteLine();
            //}

            //예제3: 좌표 찍기
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"({j}, {i})");
            //    }
            //    Console.WriteLine();
            //}
            //예제4: 별 찍기
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if(i>=j)Console.Write("*");
            //        else Console.Write("");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if(j>=i)Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //예제 6: 구구단 곱셈표
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1;j<=9; j++)
            //    {
            //        Console.Write($"{i}x{j} = {i*j} ");
            //    }
            //    Console.WriteLine();
            //}

            //예제 9: 미니게임 맵
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (i == 0 && j == 0)
            //        { Console.Write("🏠"); }
            //        else if (i == 3 && j == 3) { Console.Write("🎯"); }
            //        else { Console.Write("🟩"); }
            //    }
            //    Console.WriteLine("");
            //}

            //콘솔창에서 좌표 움직이기

            const int targetX = 50;
            const int targetY = 15;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            int x = 10, y = 10;
            ConsoleKeyInfo keyInfo;//키 관련 정보
            Console.CursorVisible = false;
            while (true) 
            {
                Console.Clear();
                Console.SetCursorPosition(targetX, targetY);
                Console.Write("🏠");//목적지
                Console.SetCursorPosition(x, y);
                Console.Write("●");//현재위치
               

                if (x == targetX && y == targetY) 
                {
                    Console.Clear();
                    Console.WriteLine("대장장이 키우기.");
                    break;
                }

                keyInfo=Console.ReadKey(true);//키 입력 받기(출력x)

                switch (keyInfo.Key) 
                {
                    case ConsoleKey.UpArrow:if (y > 0) y--;break;
                    case ConsoleKey.DownArrow:if (y < Console.WindowHeight-1) y++;break;
                    
                    case ConsoleKey.LeftArrow:if (x > 0) x--;break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;

                    case ConsoleKey.Spacebar:Console.Write("미사일키");break;
                    case ConsoleKey.Escape:break;

                }

            }
            //대장장이 키우기
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500);


            //무한반복
            while (true)
            {
                Console.Clear(); //화면지우기
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

                if (input == 1) //나무캐기화면
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }


                    }
                }
                else if (input == 2)
                {
                    //장비뽑기
                    if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;

                        //20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1) // 1퍼
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(500); //0.5초정도로 뽑혀라.

                        }


                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("게임을 나갑니다.");
                    Environment.Exit(0);
                }
            }


        }
    }
}
