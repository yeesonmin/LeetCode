using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(LengthOfLongestSubstring("dvdf").ToString());

        }


        public static int LengthOfLongestSubstring(string s)
        {
            int answer = 0;
            if (s.ToString() != "")
            {

                string substring = s[0].ToString();
                answer = 1;

                for (int i = 1; i < s.Length; i++)
                {

                    if (substring.Contains(s[i]))
                    {
                        answer = (substring.Length > answer) ? substring.Length : answer;
                        
                        string[] temp = substring.Split(s[i]);
                        substring = temp[temp.Length-1] + s[i];
                    }
                    else
                    {
                        substring += s[i];
                        answer = (substring.Length > answer) ? substring.Length : answer;
                    }

                }
            }

            return answer;
        }

    }


}
