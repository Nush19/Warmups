using System;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }

        public string InsertWord(string container, string word) {
            public static string InsertWord(string container,string word) {
            //convert into stringArray 
            char[] c = word.ToCharArray();  
            char[] k = container.ToCharArray();
     
            string res="";
            for(int i=0;i<2;i++){
             res=res+k[i];
        }
  
            for(int i=0;i<word.Length;i++){
            res=res+c[i];
        }
   
            for(int i=2;i<container.Length;i++){
            res=res+k[i];
        }
            //convert into string
   
            return res.Trim();
        }

        public string MultipleEndings(string str)
        {
            int len = str.Length;
            return str.Substring(len - 2) + str.Substring(len - 2) + str.Substring(len - 2);
        }

        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length/2);
        }

        public string TrimOne(string str)
        {
            string s1="";
            for(int i=1;i<str.Length-1;i++)
            s1=s1+str[i];
        
            return s1;
        }

        public string LongInMiddle(string a, string b)
        {
            if(a.Length>b.Length)
            return b+a+b;
            else
            return a+b+a;
        }

        public string RotateLeft2(string str)
        {
            //if string length is greater than 2
            if(s.Length>2){
            //create a new substring str
            //such that the characters staring from index 3 
            //to end from string s are concatenated 
            //then index 0 and 1
            string str=s.Substring(2)+s[0]+s[1];
            Console.WriteLine(str);
        }
            else
        {
            //if string length is <=2 
            Console.WriteLine(s);
        }
        }

        public string RotateRight2(string str)
        {
             //create a new string
            string str="";
      
             if(s.Length>2){
            //if input string length is >2
            //concatenate last 2 characters to new string from s
            str=s.Substring(s.Length-2);
            //iterate over string s and concatenate each character 
            //to new string excluding last two characters as they are
            //concatenated n the beggining 
            for(int i=0;i<s.Length-2;i++){
                str=str+s[i];
            }
            //write data to the console
            Console.WriteLine(str);
        }
        else
        {
            //if string length is <=2
            Console.WriteLine(s);
        }
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (front)
            return str.substring(0,1);
            else
            return str.substring(str.length()-1);
        }

        public string MiddleTwo(string str)
        {
            int half = str.length() / 2;
            return str.substring(half-1,half+1);
        }

        public bool EndsWithLy(string str)
        {
            int len = str.length();
            String ly = "ly";
            if (len < 2)
            return false;
            else if (ly.equals(str.substring(len-2,len)))
            return true;
            else
            return false; 
        }

        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0,n) + str.Substring(str.Length-n);
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if(str.Length < n + 2 || n < 0)
            return str.Substring(0,2);
            return str.Substring(n,2);
        }

        public bool HasBad(string str)
        {
            if(str.Length <= 3)
            return false;
            return (str.Substring(0,3) == "bad") | (str.Substring(1,3) == "bad");
        }

        public string AtFirst(string str)
        {
            string s = "";
            s += str[0];
            if(str.Length == 1) s += "@";
            else s += str[1];
        
            return s;
        }

        public string LastChars(string a, string b)
        {
            char first, last;
            if(a.Length == 0) first = '@';
            else first = a[0];
        
            if(b.Length == 0) last = '@';
            else last = b[b.Length-1];
        
            string s = "";
            s += first;
            s += last;
        
            return s;
        }

        public string ConCat(string a, string b)
        {
            if(b.Length > 0 && a[a.Length - 1] == b[0]) return (a + b.Substring(1));
            else return (a + b);
          
        }

        public string SwapLast(string str)
        {
            //store the length of string
            int l = str.Length;

            //convert string to character array
            char[] array = str.ToCharArray();
            //swap the last two characters in the array
            array[l-2]=str[l-1];
             array[l-1]=str[l-2];
            //save the result in a new string
            string res = new string(array);

            //return the results
            return res;
        }

        public bool FrontAgain(string str)
        {
            //store the length of string
            int l = str.Length;

            //convert string to character array
            char[] array = str.ToCharArray();
            //check if last two chars are same as first two
            if (array[l-2]==str[0] && array[l-1]==str[1])
        {
            return true;
        }
            return false;
        }

        public string MinCat(string a, string b)
        {
             //store the length of strings
            int l1 = str1.Length;
            int l2 = str2.Length;
            int len;

            //choose the shorter value among the two lengths
            if (l1<l2) {
            len=l1;
        }
            else {
            len=l2;
        }

        //convert strings to character arrays
        char[] array1 = str1.ToCharArray();
        char[] array2 = str2.ToCharArray();
        //create a temporary  result array
         char[] resarr = new char[2*len];

        //loop through from 0 to len
        for (int i = 0; i < len; i = i + 1) {
        //in resarray, store last 'len' characters of array1
        resarr[i] = array1[l1-len+i];
        //in resarray, store last 'len' characters of array2
        resarr[len+i] = array2[l2-len+i];
    }


        //create final result string from array
        string res = new string(resarr);

        //return the result
        return res;
        }

        public string TweakFront(string str)
        {
            //convert into stringArray 
            char[] c = str.ToCharArray();  
    
            //check for first element 
            if(c[0]=='a' && c[1]=='b')
            return str;
            else if(c[0]=='a' && c[1]!='b'){
            c[1]=' ';
        }
            else if(c[0]!='a' && c[1]=='b'){
            c[0]=' ';
        }
            else{
            c[1]=' ';
            c[0]=' ';
        }
  
            string res="";
            for(int i=0;i<str.Length;i++){
            if(c[i]!=' ')
            res=res+c[i];
        }
  
        //convert into string
   
        return res.Trim(); 
        }

        public string StripX(string str)
        {
             //convert into stringArray 
             char[] c = str.ToCharArray();  
            int n=str.Length;
             //check for first element 
            if(c[0]=='x'||c[0]=='X')
            c[0]=' ';
            //check for last element      
            if(c[n-1]=='x'||c[n-1]=='X')
            c[n-1]=' ';
       
            //convert into string
            string charsStr = new string(c); 
            return charsStr.Trim(); 
        }
    }
}
