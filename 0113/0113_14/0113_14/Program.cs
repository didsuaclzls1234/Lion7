using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0113_14
{
    class Player
    {
        private string name;
        private int gold;
        private int maxHP;
        public Player()
        {
            maxHP = 100;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Gold {
             get { return gold; }
             set
                {
                    if (value < 0) { Console.WriteLine("골드가 부족합니다."); }
                    else { gold = value; }
                } 
            }
        public int MaxHP { get { return maxHP; } private set { maxHP = value; } }
     
    }
    //    프로퍼티 연습 문제(쉬운 난이도)
    //📝 문제 1: 학생 성적 관리 시스템
    //문제 설명
    //Student 클래스를 만들어 학생의 성적을 관리하세요.

    //요구사항
    //name (이름) - 읽기 전용 프로퍼티
    //score (점수) - 0~100 사이의 값만 허용하는 프로퍼티
    //Grade (등급) - 점수에 따라 자동 계산되는 읽기 전용 프로퍼티
    //90점 이상: "A"
    //80점 이상: "B"
    //70점 이상: "C"
    //60점 이상: "D"
    //60점 미만: "F"

    class Student
    {
        private string name;
        private int score;
 
       
        public string Name { get { return name; } private set { name = value; } }
     
        public int Score
        {
            get { return score; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine($"잘못된 값 입력.");
                    score = 0;
                }

                else
                {
                    score = value;
                }
            }
        }
        public string Grade
        {
            get
            { 
                if (score >= 90){return "A";}
                else if (score >= 80){return "B";}
                else if (score >= 70){return "C";}
                else if (score >= 60){return "D";}
                else { return "F";}
            }
        }

        public Student(string studentName)
        {
            name = studentName;
            score = 0;
        }

        // 정보 출력
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"점수: {Score}점");
            Console.WriteLine($"등급: {Grade}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Player player = new Player();
            //player.Name = "홍길동";
            //player.Gold = -100;
            //Console.WriteLine($"이름 : {player.Name}");

            //Console.WriteLine($"골드 : {player.Gold}");

            Student student = new Student("홍길동");

            student.Score = 95;
            student.ShowInfo();

            Console.WriteLine();

            student.Score = 75;
            student.ShowInfo();

            Console.WriteLine();

            //// 잘못된 값 입력 시도
            student.Score = 150;  // 100으로 제한되어야 함
            student.Score = -10;  // 0으로 제한되어야 함
            student.ShowInfo();
        }
    }
}
