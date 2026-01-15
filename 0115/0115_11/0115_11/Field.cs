using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0115_11
{
    public class Field
    {
        Player m_pPlayer;
        Monster m_pMonster;

        public void SetPlayer(Player pPlayer) {  m_pPlayer = pPlayer; }
        public void Progress()
        {
            //사냥터
            int iInput = 0;
            while (true) 
            {
                Console.Clear();
                m_pPlayer.Render();

                DrawMap();
                iInput=int.Parse(Console.ReadLine());
                if (iInput == 4) break;
                if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }
        //팩토리 메서드 패턴
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster(); //몬스터생성
            INFO tMonster = new INFO(); //몬스터데이터 메모리 주기 객체 생성

            tMonster.strName = _strName; //초보 몬스터 ,중, 고
            tMonster.iHp = _iHp; //체력
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster); //생성된 데이터 INFO 클래스타입 데이터 세팅
        }


        public void CreateMonster (int input)
        {
            switch(input)
            {
                case 1:
                    //공장처럼 찍어내기
                    //팩토리 메서드 패턴
                    Create("초보몹", 30, 3,out m_pMonster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out m_pMonster);
                    break;
            }
        }
        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear(); //콘솔화면 지움
                m_pPlayer.Render(); //플레이어 정보 출력
                m_pMonster.Render(); //몬스터 정보출력

                Console.WriteLine("1.공격 2.도망 : "); //1,2선택 표시
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    //플레이어 데미지 주기 몬스터 공격력 넣어서 데미지
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    //몬스터 데미지 주기 플레이어 공격력 넣기
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0) //플레이어 체력이 0이하이면
                    {
                        m_pPlayer.SetHp(100);

                        Console.WriteLine("유다이");
                        Thread.Sleep(1000);
                        break;
                    }


                }


                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null; //참조일때 null 초기화하면 가비지컬렉터에서 나중에 알아서 메모리 삭제
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("===============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
    }
}
