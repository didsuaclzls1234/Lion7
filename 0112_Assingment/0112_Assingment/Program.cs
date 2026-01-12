using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0112_Assingment
{
    internal class Program
    {
        //### 문제 1: 평균 계산 함수
        //정수 배열을 받아 평균을 반환하는 함수를 만드세요.
        static float calAvg(int[] a)
        {
            float avg = 0f;
            for (int i = 0; i < a.Length; i++)
            {
                avg += a[i];
            }
            avg/= a.Length;
            return avg;
        }

        //### 문제 2: 등급 판별 함수
        //점수를 받아 A, B, C, D, F 등급을 반환하는 함수를 만드세요.
        static string returnGrade(int score)
        {
            string grade = "";
            if (score == 100)
            {
                return "A";
            }
            else if (score >= 90)
            {
                return "B";
            }
            else if(score >=80)
            {
                 return "C";
            }
            else if(score >=70)
            {
                return "D";
            }
            else
                return "F";
        }

        //### 문제 3: 소수 판별 함수
        //숫자를 받아 소수인지 판별하는 함수를 만드세요.
        static bool checkPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //### 문제 4: 경험치 시스템
        //현재 경험치와 획득 경험치를 받아 레벨업 여부와 새 경험치를 반환하는 함수를 만드세요. (out 사용)
        static void checkEXP(int curExp,int getExp, out int newExp)
        {
           
            newExp = 0;
            int requiredExp = 100;
            if (requiredExp - (curExp+getExp) < 0)
            {
                newExp = curExp+getExp - requiredExp;
                Console.WriteLine($"레벨업 성공! 남은 경험치:{newExp}");
            }
            else
            {
                requiredExp -= (curExp + getExp);
                Console.WriteLine($"레벨업 까지 남은 경험치:{requiredExp}");
            }
        }

        //### 문제 5: 아이템 강화 시스템
        //강화 레벨에 따라 성공 확률이 달라지는
        //아이템 강화 시스템을 함수로 구현하세요.

        static void upgradeProbability(int upgrade)
        {
            int probabilty = 0;
            if (upgrade == 10){probabilty = 0;}
            else if (upgrade == 9){probabilty = 10;}
            else if (upgrade == 8){probabilty = 20;}
            else if (upgrade == 7){probabilty = 30;}
            else if (upgrade == 6){probabilty = 40;}
            else if (upgrade == 5){probabilty = 50;}
            else if (upgrade == 4){probabilty = 60;}
            else if (upgrade == 3){probabilty = 70;}
            else if (upgrade == 2){probabilty = 80;}
            else if (upgrade == 1){probabilty = 90;}
            else if (upgrade == 0){probabilty = 100;}
            Console.WriteLine($"현재 강화레벨은 {upgrade}입니다. 강화 성공확률은 {probabilty}%입니다.");
        }

        static void Main(string[] args)
        {
            //## 💪 연습 문제
            //### 문제 1: 평균 계산 함수
            Console.WriteLine("문제 1: 평균 계산 함수");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            float avg= calAvg(arr);
            Console.WriteLine($"평균: {avg}점");
            Console.WriteLine();

            //### 문제 2: 등급 판별 함수
            Console.WriteLine("문제 2: 등급 판별 함수");
            int score = 90;
            string grade=returnGrade(score);
            Console.WriteLine($"{grade}등급");
            Console.WriteLine();

            //### 문제 3: 소수 판별 함수
            Console.WriteLine("문제 3: 소수 판별 함수");
            int posintnum = 2;
            bool isPrime=checkPrime(posintnum);
            if (isPrime == true) { Console.WriteLine($"{posintnum}는 소수입니다."); }
            else { Console.WriteLine($"{posintnum}는 소수가 아닙니다."); }
            Console.WriteLine();

            //### 문제 4: 경험치 시스템
            Console.WriteLine("문제 4: 경험치 시스템");
            int newExp;
            int curExp = 30;
            int getExp = 90;
            checkEXP(curExp,getExp,out newExp);
            Console.WriteLine();

            //### 문제 5: 아이템 강화 시스템
            Console.WriteLine("문제 5: 아이템 강화 시스템");
            int upgrade = 4;
            upgradeProbability(upgrade);
        }
    }
}
