using System;

namespace Warmups.BLL
{
    public class Loops
    {

        public string StringTimes(string str, int n)
        {
            string result = "";
            for(int i = 0; i < n; i++){
            result += s;
        }
            return result;
        }

        public string FrontTimes(string str, int n)
        {
            string sub = "";
            string result = "";
            if(s.Length < 3)
            sub = s.Substring(0, s.Length);
            else
            sub = s.Substring(0,3);
            for(int i = 0; i < n; i++){
            result += sub;
        }
            return result;
           
        }

        public int CountXX(string str)
        {
            int count = 0;
            for(int i = 0; i < s.Length-1;i++){
            if(s[i] == 'x' && s[i+1] == 'x')
            count += 1;
        }
            return count;
        }
        

        public bool DoubleX(string str)
        {
            // iterate into each character into string
        for (int i = 0; i <= str.Length - 1; i++)
        {
            // if character x found in list
            if(str[i]=='x')
            {
                // if it is last element
                if(i==str.Length)
                {
                    return false;
                }
                // if string is equal to next character of string
                if(str[i]==str[i+1])
                {
                    return true;
                }
                // else return false
                else
                {
                     return false;
                }
            }
        }
        // if x is not found in string
        return false;
        }

        public string EveryOther(string str)
        {
             string s1="";
        // itereare string skip the each element after iteration
        for (int i = 0; i <= str.Length - 1; i=i+2)
        {
            // append character into s1
           s1=s1+str[i];
        }
        // return s1
        return s1;
        }

        public string StringSplosion(string str)
        {
            string s1="";
        // itereate all characters on string
        for (int i = 0; i <= str.Length - 1; i++)
        {
            // string index condition
            if(i!=str.Length)
            {
                // append substring from 0 to i+1 index into string into s1
                s1=s1+str.Substring(0,i+1);
            }
        }
        // return s1
        return s1;
        }

        public int CountLast2(string str)
        {
             int n = str.Length;
                int res = 0;
                for(int i = 1; i < n - 2; i++)
                {
                        //we check all the pairs of adjacent characters with 
                        //the last 2 and if they match we increase the res
                        if(str[i] == str[n-1] && str[i-1] == str[n-2])
                                res++;
                }
                return res;
        }

        public int Count9(int[] numbers)
        {
             int n = numbers.Length;
                int res = 0;
                //iteratre over all the elements of the array
                //and count the numbers of 9s
                for(int i = 0; i < n; i++)
                {
                        if(numbers[i] == 9) res++;
                }
                return res;
        }

        public bool ArrayFront9(int[] numbers)
        {
            int n = numbers.Length;
                //we will check only the first 4 or all the elements of the array
                //whichever is minimum
                for(int i = 0; i < Math.Min(n, 4); i++)
                {
                        //if 9 is among them, we return true
                        if(numbers[i] == 9)
                                return true;
                }
                //else we return false
                return false;
        }

        public bool Array123(int[] numbers)
        {
            int i;
            for(i=0;i<num.Length - 2;i++){
            if(num[i]==1 && num[i+1] ==2 && num[i+2] == 3){
            Console.WriteLine("True");
              return true;
          }
        }
             return false;
        }

        public int SubStringMatch(string a, string b)
        {
            x=0;
            y=2;
           count=0;
           while y<=len(a):
           if a[x:y]==b[x:y]:
            count=count+1
            x=x+1;
            y=y+1;
            return count;
        }

        public string StringX(string str)
        {
            char[] c = str.ToCharArray();  
            for(int i=1;i<str.Length-1;i++){
            if(c[i]=='x')
            c[i]=' ';
        }
            string res="";
            for(int i=0;i<str.Length;i++){
            if(c[i]!=' ')
            res=res+c[i];
        }

        public string AltPairs(string str)
        {
            string altPairsStr="";
            for(int i=0;i<str.Length;i+=4)
        {
            altPairsStr+=str[i];
            if(i+1<str.Length)
            altPairsStr+=str[i+1];
        }
            return altPairsStr; 
        }

        public string DoNotYak(string str)
        {
            string DoNotYakStr="";
            for(int i=0;i<str.Length;i++)
        {
            if(i<str.Length-3)
        {
            if(!String.Equals("yak",str.Substring(i,3)))
            DoNotYakStr+=str[i];
            else
            i+=2;
        }
            else
            DoNotYakStr+=str[i];
        }
            return DoNotYakStr;
        }

        public int Array667(int[] numbers)
        {
            int count=0;
            for(int i=0;i<numbers.Length-1;i++)
        {
            if(numbers[i]==6&&(numbers[i+1]==6||numbers[i+1]==7))
            count++;
        }
            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            for(int i=0; i<numbers.Length-2; i++){
            if(numbers[i] == numbers[i+1] && numbers[i+1] == numbers[i+2]){
                return false;
            }
        }
        return true;
        }

        public bool Pattern51(int[] numbers)
        {
            for(int i=0; i<numbers.Length-2; i++){
            if(numbers[i] == (numbers[i+1] - 5) && numbers[i] == (numbers[i+2] + 1)){
                return true;
            }
        }
        return false;
        }

    }
}
