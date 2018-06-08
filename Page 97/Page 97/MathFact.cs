using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_97
{
    class MathFact
    {
        public int mathFact(int operandOne, int operandTwo, int opNumber)
        {
            int answer = 0;
            if (opNumber == 1)
            {
                answer = operandOne + operandTwo;
            }
            else if (opNumber == 2 )
            {
                answer = operandOne - operandTwo;
            }
            
            return answer;
        }
            
        
        
    }
}
