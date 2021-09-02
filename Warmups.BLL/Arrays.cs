using System;

namespace Warmups.BLL
{
    public class Arrays
    {

        public bool FirstLast6(int[] numbers)
        {
            // array length will be >= 1
            // if (numbers[0] == 6 OR numbers[length - 1] == 6)
           // return true
           // otherwise return false
           return (numbers.Length >= 1 && numbers[0] == 6 || numbers[numbers.Length - 1] == 6);
        }

        public bool SameFirstLast(int[] numbers)
        {
            // first check array length >= 1
            // after that numbers[0] == numbers[length - 1]
            // if satisfy, return true
            // otherwise false
            return (numbers.Length >= 1 && numbers[0] == numbers[numbers.Length - 1]);
            
        }

        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            var str = pi.ToString().Remove(1,1);
            var numbers = new int[n];

            for(int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(str[i].ToString());
        }
            return numbers;
        }
        
        public bool CommonEnd(int[] a, int[] b)
        {
            // check for first element
            if(a[0] == b[0])
            return true;
            // check for last element
            if(a[a.Length - 1] == b[b.Length - 1])
            return true;
            //else command end not exist
            return false;    
        }
        
        public int Sum(int[] numbers)
        {
            //variable to sum all elements
            int sum = 0;
            //loop through the array and add each element
            for(int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }
            return sum;
        }
        
        public int[] RotateLeft(int[] numbers)
        {
            int num = numbers[0]; //first element in num
            //for loop that shift element by 1 in left
            for(int i = 0; i < numbers.Length - 1; i++);
            numbers[i] = numbers[i + 1];
            //first number is shifted to last
            numbers[numbers.Length - 1] = num;
            return numbers;  
        }
        
        public int[] Reverse(int[] numbers)
        {
            //defining beginning and end variable
            int beg = 0, end = numbers.Length - 1;
            //loop iterate till beg has lesser value than end
            for(beg < end);{
            int t = numbers[beg]; //t has a element which is reffered by beg
            numbers[beg]=numbers[end]; //storing end index's element at beg index
            numbers[end]=t; //t is stored at end position
            beg++; //incrementing beg index
            end--;//decrementing end index
        }
        return numbers;
        }
        
        public int[] HigherWins(int[] numbers)
        {
            //Get first element
            int first = numbers[0];
            //Get last element
            int last = numbers[numbers.Length - 1];
            //Find highest
            int highest = first > last ? first : last;
            //Replace with highest
            for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = highest;
        }
            //Return
            return numbers;
        }
        
        public int[] GetMiddle(int[] a, int[] b)
        {
            //Get middle value of 2 arrays
            return new int[] {a[1],b[1]};
        }
        
        public bool HasEven(int[] numbers)
        {
            foreach(int num in numbers){
            if(num%2 == 0)
            return true;
        }
            return false;
        }
        
        public int[] KeepLast(int[] numbers)
        {
            int length = numbers.Length;
            int[] newArr = new int[2*length];
            newArr[2*length-1] = numbers[length-1];
            for(int i=0; i<2*length-1; i++){
            newArr[i] = 0;
        }
            return newArr;
        }
        
        public bool Double23(int[] numbers)
        {
            int countTwo = 0, countThree = 0;
            for(int i=0;i<numbers.Length; i++){
            if(numbers[i] == 2) countTwo++;
            else if(numbers[i] == 3) countThree++;
        }
            return (countTwo == 2 || countThree == 2);
        }
        
        public int[] Fix23(int[] numbers)
        {
            for(int i=1;i<numbers.Length;i++){
            if(numbers[i] == 3 && numbers[i-1] == 2){
                numbers[i] = 0;
            }
        }
            return numbers;
        }
        
        public bool Unlucky1(int[] numbers)
        {
            if (nums.Length < 2) {
            return false;
        }     
            else if ((nums[0] == 1 && nums[1] == 3) || (nums[nums.Length-2] == 1 && nums[nums.Length-1] == 3)) {
            return true;
        } 
            else if (nums.Length > 2 && nums[1] == 1 && nums[2] == 3) {
            return true;
        } 
            else
            return false;
        }
        
        public int[] Make2(int[] a, int[] b)
        {
            int[] make = new int[2];//declaring array make[] to store the resultant values
            //checking all possible conditions and storing values of make[] array...
            if(a.Length == 1 && b.Length !=0)
        {
            make[0] = a[0];
            make[1] = b[0];
        }
            else if(a.Length == 0 && b.Length !=0)
        {
            if(b.Length == 1)
            {
                make[0] = b[0];
            }
            else
            {
                make[0] = b[0];
                make[1] = b[1];
            }
        }
            else
        {
            make[0] = a[0];
            make[1] = a[1];
        }
            return make;
        }

    }
}
