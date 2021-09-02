using System; 

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if((aSmile == true & bSmile == true) || (aSmile == false & bSmile == false)){
            return true;
        }
            else
        {
            return false;
        }
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if((isWeekday == false) || (isVacation == true)){
            return true;
        }
            else
        {
            return false;
        }
        }

        public int SumDouble(int a, int b)
        {
            if(a == b){
            return 2 * (a+b);
        }
            else
        {
            return (a+b);
        }
        }
        
        public int Diff21(int n)
        {
            int  diff;
            //if n>21 then we need to double the value of difference..
            if(n>21)
        {
            diff = n-21;
            return Math.Abs(temp*2);
        }
            //else return the difference of absolute value...
            else
        {
            diff = 21-n;
            return Math.Abs(temp);
        }
        }
        
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            //if istalking is true and hour is before 7 or after 20 we retuen true
        if((isTalking == true) && ((hour<7)||(hour>20)))
        {
            return true;
        }
        else
            return false;//else false...
        }
        
        public bool Makes10(int a, int b)
        {
            //Stores the sum of the two numbers
            int total ;
            total = a + b;
  
            //Chceking if either of the two numbers is 10
            //or their sum is 10
            if(a == 10 || b == 10 || total == 10)
        {
            //Returns true if condition satisfied
            return true;
        }
  
        //If none of them is 10 return false
        return false;
        }
        
        public bool NearHundred(int n)
        {
            if((n>=90 && n<=110) || (n>=190 && n<=210))
            return true;
            else
            return false;
        }
        
        public bool PosNeg(int a, int b, bool negative)
        {
            if((a<0&&b>=0)||(a>=0&&b<0))
        {
           if(negative==false)
           return true;
           else
           return false;
        }
           else if(a<0&&b<0)
        {
           if(negative==true)
           return true;
        }
           return false;
        }
        
        public string NotString(string s)
        {
            if(s[0]=='n'&&s[1]=='o'&&s[2]=='t')
            return s;
            else
            return "not "+s;
            
        }
        
        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
        
        public string FrontBack(string str)
        {
            return str.Length > 1
            ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
        
        public string Front3(string str)
        {
            if (str.Length < 3)
        {
        return str + str + str;
        }
        else
        {
        string front = str.Substring(0, 3);
        return front + front + front;
        }
        }
        
        public string BackAround(string str)
        {
            int x=0;
            string str = Console.ReadLine();
  
            x = str.Length;
            Console.WriteLine(str[(x-1)] + str + str[(x-1)]);

        }
        
        public bool Multiple3or5(int number)
        {
            int x;
            x=Convert.ToInt32(Console.ReadLine());
            if ((x%3 == 0)|| (x%5 == 0))
            
        }
        
        public bool StartHi(string str)
        {
            string str;
            str=Console.ReadLine();

            if ((str == "hi")|| (str.Substring(0,3) == "hi "))
            Console.WriteLine(true);
            else
            Console.WriteLine(false);
        }
        
        public bool IcyHot(int temp1, int temp2)
        {
            if(temp1<0 && temp2>100 || temp2<0 && temp1>100 ){
            return true;
        }
            else
        {
            return false;
        }
        }
        
        public bool Between10and20(int a, int b)
        {
             return ((a >= 10 && a <= 20) || (b >=10 && b <=20));
        }
        
        public bool HasTeen(int a, int b, int c)
        {
            return ((a > 12 & a < 20) || (b > 12 & b < 20) || (c > 12 & c < 20));
        
           
        }
        
        public bool SoAlone(int a, int b)
        {
            if ((x >= 13 && x <= 19) && (y >= 13 && y <= 19))
        {
            return false;
        }
            return true;
        }
        
        public string RemoveDel(string str)
        {
            if (str.Length <= 3)
        {
           return str;
        }
        if (str.Substring(1, 4 - 1).Equals("del"))
        {
           var sb = new StringBuilder(str);
           sb.Remove(1, 3);
           return sb.ToString();
        }
        return str;
        }
        
        public bool IxStart(string str)
        {
            if (str.Length < 3)
        {
           return false;
        }
        return str.Substring(1, 2).Equals("ix");
        }
        
        public string StartOz(string str)
        {
            //declare an empty string...
        string ans = "";
                //check first character is 'o' or not...
        if(String.Equals(str[0], 'o'))
        {
                        //append the 'o' in ans...
            ans = ans + "o";
        }
                
                //check second character is 'z' or not...
        if(String.Equals(str[1], 'z'))
        {
                        //append the 'z' in ans...
            ans = ans + "z";
        }
        //return ans...
        return ans;
        }
        
        public int Max(int a, int b, int c)
        {
            //declare a varialbe maximum...
            int maximum;
            
            //check for a first...
            if (a>b) 
            {
                //if a is greter than set maximum = a...
            if (a>c) 
            {
               maximum = a;
            } 
            //if c is greter than set maximum = c...
            else 
            {
               maximum = c;
            }
        }
        //check for b is greater than c then set maximum = b...
        else if (b > c)
            maximum = b;
        else
        //otherwise c is maximum...
            maximum = c;
            
        //return maximum...
        return maximum;
        }
        
        public int Closer(int a, int b)
        {
            //find the subtraction from 10 of both numbers...
        int a_10, b_10;
        a_10 = a - 10;
        b_10 = b - 10;

        //if subtraction is less than 0 then change the sign of the a_10...
        if(a_10 < 0)
        {
            a_10 = a_10*(-1);
        }
        
        //if subtraction is less than 0 then change the sign of the b_10...
        if(b_10 < 0)
        {
            b_10 = b_10*(-1);
        }

        //whichever is less, return that number...
        if(a_10<b_10)
        {
            return a;
        }
        else if(b_10==a_10)
        {
            return 0;
        }
        else
        {
            return b;
        }
        }
        
        public bool GotE(string str)
        {
            int count=0; //declare count=0
            for(int i=0;i<str.Length;i++){ //loop from 0 to string length
            if((str[i]=='e') || (str[i]=='E')) //if string has 'e' or 'E' at any index
        {
            count=count+1; //increment count by 1
        }
        }
        if(count>=1 && count<=3){
        return true; //if count is 1-3, return true
        }
        return false; //if count is other than 1-3, return false
        }
        
        public string EndUp(string str)
        {
            //create function by passing string variable argument and return type as string
        string newstr="",newstrlast3=""; //declare empty strings
        int len=str.Length; //calculate length of string
        if(len>=3) //if length is greater than equal to 3
        {
        newstr=str.Substring(0,len-3);//intialize newstr= string from 0 to len-3 index
        newstrlast3=str.Substring(len-3,3); //intialize newstrlast3= string from len-3 to len index
        newstr=newstr+newstrlast3.ToUpper(); //convert string to uppercase string and add to newstr variable
        }
        else { 
        //if length is less than 3
        newstr=str.ToUpper();//convert string to uppercase string and assign to newstr variable
        }
        return newstr; //return newstr
        }
        
        public string EveryNth(string str, int n)
        {
            //create function by passing 2 string arguments and return type as string
            string newstr=""; //declare empty string :newstr
            for(int i=0;i<str.Length;i+=n){ //loop from 0 to length of strng and increment i by n
            newstr=newstr+str.at(i); //append string at index i to newstr
        }
            return newstr; //return newstr
        }
    }
}
