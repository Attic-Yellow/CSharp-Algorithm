using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._AlgorithmTechnic
{
    /******************************************************
    * 재귀 (Recursion)
	* 
	* 어떠한 것을 정의할 때 자기 자신을 참조하는 것
	******************************************************/

    // <재귀함수 조건>
    // 1. 함수내용 중 자기자신함수를 다시 호출해야함
    // 2. 종료조건이 있어야 함

    // <재귀함수 사용>
    // Factorial : 정수를 1이 될 때까지 차감하며 곱한 값
    // n! = n * (n-1)!;
    // 1! = 1;
    // ex) 5! = 5 * 4 * 3 * 2 * 1

    class Recursion
    {
        int Factorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        struct Directory
        {
            public List<Directory> chilDir;
        }

        void RemoveDir(Directory directory)
        {
            foreach(Directory dir in directory.chilDir)
            {
                RemoveDir(dir);
            }

            Console.WriteLine("폴더 내 파일 모두 삭제");
        }
    }
}
