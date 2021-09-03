using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
           
        if(cigars>=40 && cigars<=60 && isWeekend==false)
        {

        return true;
        }
        else if (cigars >= 40 && isWeekend == true)
        {

        return true;
        }
        else
        {

        return false;
        }
        }
        
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            throw new NotImplementedException();
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            
        if(temp>=60 && temp<=90 && isSummer==false)
        {

        return true;
        }
        else if (temp >= 60 && temp <= 100 && isSummer == true)
        {

        return true;
        }
        else
        {
        return false;
        }
        }
        
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            //Declaring the function
            public int CaughtSpeeding(int speed, boolean isBirthday) {
            //declaring the required variables
            int ticket;
  
            //checking if birthday
            if(isBirthday)
        {
            //if speed is less than or equal to 65
            if(speed <= 65)
        {
            //ticket is 0
            ticket = 0;
        }
            //if speed is less than or equal to 85
            else if(speed <=85)
        {
            //ticket is 1
            ticket = 1;
        } 
            //speed greater than 85
            else
            {
            //ticket is 2
             ticket = 2;
        }
        }
            //if not birthday
            else
        {
            //if speed is less than or equal to 60
             if(speed <= 60)
        {
            //ticket is 0
             ticket = 0;
            }
            //if speed is less than or equal to 85
            else if(speed<=80)
        {
            //ticket is 1
             ticket = 1;
        }
            //if speed is grater than 86
              else
        {
            //ticket is 2
            ticket = 2;
        }
        }

        //returning the ticket value
        return ticket;
        }
        }
        
        public int SkipSum(int a, int b)
        {
            int sum = a+b;
  
            //checking if sum is between 10..19 then sum is equal to 20
            if(sum>=10 && sum <= 19)
        {
            //assigning sum = 20
            sum = 20;
        }
  
            //returning the sum
            return sum;
        }
        
        public string AlarmClock(int day, bool vacation)
        {
            //declaring the require function
            public static string AlarmClock(int day, boolean vacation) {
            //declaring the required string
            string time;
  
            //checking if vacation is true
            if(vacation)
        {
            //if weekend
            if(day == 0 || day == 6)
        {
            //time is off
            time = "off";
        }
            //if not weekend
            else
        {
            //time is 10
            time = "10:00";
        }           
        
        }
  
        //if not vacation
        else
        {
        //if day is between monday to friday
        if(day >= 1 && day <= 5)
         {
        //time is 7
        time = "7:00";
        }
  
        //if weekend
        else
        {
        //time is 10
        time = "10:00";
        }
        }
  
        //returning the time
        return time;
        }
        }
        
        public bool LoveSix(int a, int b)
        {
            // Check if a or b is 6 or if their sum or difference is 6
            if(a == 6 || b == 6 || (a+b) == 6 || (a-b) == 6)
      
            // Retunr true
            return true;
      
           // Check if a or b is not 6 or if their sum or difference is not 6
           else
    
            // Return false
            return false;
        }
        
        public bool InRange(int n, bool outsideMode)
        {
            // If number is in the range 1..10, inclusive & "outsideMode" is false
            if((n >= 1 && n <= 10) || outsideMode)
    
            // Return true
            return true;
      
            // if the number is less or equal to 1, or greater or equal to 10
            else
    
            // Return false
            return false;
        }
        
        public bool SpecialEleven(int n)
        {
            // If number is a multiple of 11 or if it is one more than a multiple of 11
            if((n%11 == 0) || (n-1)%11 == 0)
    
            // Return true
            return true;
      
            // If number is a not multiple of 11 or if it is not one more
            // than a multiple of 11
            else
    
            // Return false
            return false;
        }       
        
        public bool Mod20(int n)
        {
            if(n % 20 == 1 || n % 20 == 2)
            return true;
            return false;
        }
        
        public bool Mod35(int n)
        {
            if(n % 15 == 0)
            return false;
            else if(n%3 == 0 || n%5==0)
            return true;
            return false;
        }
        
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if(isAsleep)
            return false;
            else if(isMom && isMorning)
            return true;
             else if (!isMom && isMorning)
            return false;
            else if(!isMorning)
            return true;
            return true;
        }
        
        public bool TwoIsOne(int a, int b, int c)
        {
            if ( a + b == c || c + b == a || c + a == b)
            return true;
            else
             return false;
        }
        
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if(bOk) {
            if (c > b)
            return true;
            else
            return false;
        }
            if (b > a && c > b)
            return true;
            else
            return false; 
        }
        
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (!equalOk && a < b && b < c)
            return true;
            if (equalOk && a <= b && b <= c)
            return true;
            else
            return false;
        }
        
        public bool LastDigit(int a, int b, int c)
        {
            if((a%10==b%10)||(a%10==c%10)) //check last digit of a with other two(b and c)
            {
                return true;
            }
            else if((b%10==a%10)||(b%10==c%10))  //check last digit of b with other two(a and c) 
            {
                return true;
            }
            return false;
        }
        
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            throw new NotImplementedException();
        }

    }
}
