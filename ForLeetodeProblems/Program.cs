using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices.Marshalling;

namespace ForLeetodeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //Console.WriteLine(solution.ArithmeticTriplets([2, 7, 11, 15], 9));
            //Console.WriteLine(solution.IsPalindrome(121));

            //IList<int> result = solution.FindKthNumber(13);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(solution.IsMatch("mississippi", "mis*is*p*."));

            //int result = solution.FindKthNumber(804289384, 42641503);
            //Console.WriteLine(result);
            //Console.WriteLine(solution.IsPerfectSquare(36));

            //int number = solution.MinExtraChar("dwmodizxvvbosxxw", ["ox", "lb", "diz", "gu", "v", "ksv", "o", "nuq", "r", "txhe", "e", "wmo", "cehy", "tskz", "ds", "kzbu"]);
            //Console.WriteLine(number);

            //Console.WriteLine(solution.RomanToInt("MIX"));

            //Console.WriteLine(solution.LongestCommonPrefix(["flew","float","flower"]));

            //Console.WriteLine(solution.StrStr("aaa","aaaa"));

            //Console.WriteLine(solution.Reverse(1534236469));

            //Console.WriteLine(solution.Fib(6));

            //Console.WriteLine(solution.ReverseOnlyLetters("a--cd"));

            //string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            //var selectedPeople = people.Where(x => x.ToString().StartsWith("T"))
            //                        .OrderBy(x => x);

            //foreach (string person in selectedPeople)
            //{
            //    Console.WriteLine(person);
            //}

            //Solution solution1 = new Solution();
            //char output = solution.FindingHardLetter(6, "defghi", "13 24 26 30 31 33");
            //Console.WriteLine(output);

            //Solution solution1 = new Solution();
            //long answer = solution1.Maximum69Number(9996);
            //Console.WriteLine(answer);

            //var res = Solution.LetterCombinations("23");
            //foreach ( var item in res )
            //{
            //    Console.WriteLine(item);
            //}
            //Solution solution1 = new Solution();

            //Console.WriteLine(solution1.NumberToWords(123456789));

            //Solution solution1 = new Solution();

            //Console.WriteLine(solution1.MaxAscendingSum([10,20,30,5,10,50]));

            //Solution solution1 = new Solution();
            //Console.WriteLine(solution1.MyPow(2.000,10));

            //char[] message = "asdas".ToCharArray();
            //char key = 'K';

            //for (int i = 0; i < message.Length; i++)
            //{
            //    message[i] = (char)(message[i] ^ key);
            //}
            //Console.WriteLine($"Shifrlangan xabar: {new string(message)}");

            //for (int i = 0; i < message.Length; i++)
            //{
            //    message[i] = (char)(message[i] ^ key);
            //}
            //Console.WriteLine($"Asl xabar: {new string(message)}");

            //Console.WriteLine(solution.NumberOfAlternatingGroups([0,0,0,1],3));

            //Console.WriteLine(solution.GetLucky("leetcode",1));
            //Console.WriteLine((int)'i' - 96);

            //Console.WriteLine(solution.ReverseDegree("abc"));

            //Console.WriteLine(solution.NumRabbits([10,10,10]));

            //Console.WriteLine(solution.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]));

            //Console.WriteLine("asnwer: ");
            //Console.WriteLine(solution.CountCompleteSubarrays([1, 3, 1, 2, 2]));

            //Console.WriteLine(solution.CountInterestingSubarrays([3, 1, 9, 6], 3, 0));

            //Console.WriteLine(solution.CountSubarrays([3, 1, 5, 3, 4, 5], 1,3));
            //Console.WriteLine(solution.SingleNonDuplicate([1, 1, 2, 2, 3]));
            //Console.WriteLine(solution.NumSubarraysWithSum([0,0,0,0,0], 0));
            //Console.WriteLine(solution.DivisorSubstrings(430043, 2));
            //string a = "abc";
            //string b = new string("abc".ToCharArray());
            //string c = string.Intern(b);
            //string d = new string("abc");

            //Console.WriteLine(object.ReferenceEquals(a, b));
            //Console.WriteLine(object.ReferenceEquals(a, c));
            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(b.Equals(c));
            //Console.WriteLine(a.GetHashCode() == b.GetHashCode());

            //Console.WriteLine(object.ReferenceEquals(a, d));
            //Console.WriteLine(object.ReferenceEquals(d, c));
            //Console.WriteLine(a.Equals(d));
            //Console.WriteLine(d.Equals(b));
            //Console.WriteLine(b.Equals(d));
            //Console.WriteLine(d.GetHashCode() == b.GetHashCode());

            //string x = "test";
            //string y = "te" + "st";
            //Console.WriteLine(object.ReferenceEquals(x, y));

            //string part1 = "te";
            //string part2 = "st";
            //string z = part1 + part2;

            //Console.WriteLine(object.ReferenceEquals(x, z)); 

            //Console.WriteLine(solution.MaxCoins([2, 4, 1, 2, 7, 8]));

            Console.WriteLine(solution.FindLexSmallestString("5525",9,2));
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution 
    {

        public string SmallestString(string s)
        {
            var charArray = s.ToCharArray();
            int left = 0;
            while (left < charArray.Length)
            {
                if (charArray[left] != 'a')
                {
                    while (left < charArray.Length && charArray[left] != 'a')
                    {
                        charArray[left] = (char)(charArray[left] - 1);
                        left++;
                    }
                    if(left == charArray.Length-1 && charArray[left] == 'a')  
                    {
                        charArray[left - 1] = 'z';
                    }
                    break;
                }
                if (left == charArray.Length - 1 && charArray[left] == 'a')
                {
                    charArray[left - 1] = 'z';
                }
                left++;
            }

            return new string(charArray);
        }
        public string GetSmallestString(string s)
        {
            var charArray = s.ToCharArray();
            int left = 0, right = charArray.Length - 1;
            while (left < right)
            {
                if ((int.Parse(charArray[left].ToString()) % 2) == (int.Parse(charArray[left + 1].ToString()) % 2))
                {
                    if (charArray[left] > charArray[left + 1])
                    {
                        char temp = charArray[left];
                        charArray[left] = charArray[left + 1];
                        charArray[left + 1] = temp;
                        left = right;
                    }
                }
                left++;
            }

            return new string(charArray);
        }
        public string FindLexSmallestString(string s, int a, int b)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            queue.Enqueue(s);
            visited.Add(s);
            string result = s;
            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                if (string.Compare(current, result) < 0)
                {
                    result = current;
                }
                char[] addAChars = current.ToCharArray();
                for (int i = 1; i < addAChars.Length; i += 2)
                {
                    int digit = (addAChars[i] - '0' + a) % 10;
                    addAChars[i] = (char)(digit + '0');
                }
                string addAString = new string(addAChars);
                if (!visited.Contains(addAString))
                {
                    visited.Add(addAString);
                    queue.Enqueue(addAString);
                }
                var substring = current.Substring(b);
                string rotateBString = substring + current.Substring(0, b);
                if (!visited.Contains(rotateBString))
                {
                    visited.Add(rotateBString);
                    queue.Enqueue(rotateBString);
                }
            }
            return result;

        }
        public int MaxDistinctElements(int[] nums, int k)
        {
            int res = 0;
            Array.Sort(nums);
            int prevElmt = int.MinValue;
            foreach(int num in nums)
            {
                int currElmt = Math.Min(num + k, Math.Max(num - k, prevElmt + 1));

                if ((currElmt> prevElmt))
                {
                    res++;
                    prevElmt = currElmt;
                }
            }

            return res;
        }
        public int MaxCoins(int[] piles) 
        {
            int maxCnt = 0;
            int n = piles.Length;
            Array.Sort(piles);

            for(int i = n-2; i >= n/3; i--)
            {
                maxCnt += piles[i];
                i--;
            }

            return maxCnt;
        }

        public int NumberOfBeams(string[] bank)
        {
            int n = bank.Length;

            var secDevCnt = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < bank[i].Length; j++)
                {
                    if (bank[i][j] == '1')
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    secDevCnt.Add(count);
                }
            }

            int res = 0;
            for(int i = 0;i < secDevCnt.Count; i++)
            {
                res += secDevCnt[i] * secDevCnt[i + 1];
            }

            return res;
        }
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int count = 0;
            int[] rowMax = new int[grid.Length];
            int[] colMax = new int[grid[0].Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (rowMax[i] < grid[i][j])
                        rowMax[i] = grid[i][j];
                    if (colMax[j] < grid[i][j])
                        colMax[j] = grid[i][j];
                }
            }
            for (int i = 0; i < rowMax.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    count += Math.Min(rowMax[i], colMax[j]) - grid[i][j];
                }
            }
            return count;
        }
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            var numCnt = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if(numCnt.ContainsKey(num))
                {
                    numCnt[num]++;
                }
                else
                {
                    numCnt[num] = 1;
                }
            }
            int maxCnt = numCnt.Values.Max();

            var result = new List<IList<int>>();
            for(int i = 0; i < maxCnt; i++)
            {
                result.Add(new List<int>());
            }
            foreach (var kvp in numCnt)
            {
                int number = kvp.Key;
                int count = kvp.Value;
                for(int i = 0; i < count; i++)
                {
                    result[i].Add(number);
                }
            }

            return result;

        }
        public int MaxIncreasingSubarrays(IList<int> nums) // [2,5,7,8,9,2,3,4,3,1]
        {
            int n = nums.Count;
            int tempCnt = 1;
            int preCnt = 1;
            int ans = 0;

            for (int i = 1; i <= n - 1; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    tempCnt++; // 2,5,7,8,9 => 5
                }
                else
                {
                    preCnt = tempCnt; // p = 5
                    tempCnt = 1;
                }

                ans = Math.Max(ans, Math.Min(tempCnt, preCnt)); // 1
                ans = Math.Max(Math.Max(preCnt, tempCnt)/ 2, ans);
            }

            return ans;
        }
        public string[] DivideString(string s, int k, char fill)
        {
              int count = s.Length / k + (s.Length % k == 0 ? 0 : 1);
            string[] result = new string[count];
            for (int i = 0; i < count; i++)
            {
                if (i * k + k <= s.Length)
                {
                    result[i] = s.Substring(i * k, k);
                }
                else
                {
                    result[i] = s.Substring(i * k) + new string(fill, i * k + k - s.Length);
                }
            }

            return result;
        }
        public string RestoreString(string s, int[] indices)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < indices.Length; i++)
            {
                sb.Append(s[i]);
            }
            char[] result = new char[s.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                result[indices[i]] = sb[i];
            }

            return new string(result);

        }

        public int GetDecimalValue(ListNode head)
        {
            int result = 0;
            while (head != null)
            {
                result = (result << 1) | head.val; 
                head = head.next;
            }

            return result;
        }
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            var sortedPlayers = players.OrderBy(x => x).ToList();
            var sortedTrainers = trainers.OrderBy(x => x).ToList();

            int count = 0;
            int playerIndex = 0, trainerIndex = 0;
            while (playerIndex < sortedPlayers.Count && trainerIndex < sortedTrainers.Count)
            {
                if (sortedPlayers[playerIndex] <= sortedTrainers[trainerIndex])
                {
                    count++;
                    playerIndex++;
                    trainerIndex++;
                }
                else
                {
                    trainerIndex++;
                }
            }

            return count;
        }
        public int MinPartitions(string n)
        {
            int maxDigit = 0;
            foreach (char c in n)
            {
                int digit = c - '0';
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
            }

            return maxDigit;
        }

        public int SumOddLengthSubarrays(int[] arr)
        {
            int result = 0, n = arr.Length;

            for (int left = 0; left < n; left++)
            {
                for (int right = left; right < n; right++)
                {
                    if ((right - left + 1) % 2 == 1) 
                    {
                        int currentSum = 0;
                        for (int i = left; i <= right; i++)
                        {
                            currentSum += arr[i];
                        }

                        result += currentSum;
                    }
                }
            }

            return result;
        }

        public string TruncateSentence(string s, int k)
        {
            var words = s.Split(' ');

            string result = string.Join(' ', words.Take(k));

            return result;
        }

        public string RemoveOuterParentheses(string s)
        {
            StringBuilder result = new();
            int index = 0;
            foreach (char x in s)
            {
                if (x == '(' && index++ > 0)
                    result.Append(x);
                else if (x == ')' && index-- > 1)
                    result.Append(x);
            }
            return result.ToString();
        }
        public int[] MinOperations(string boxes)
        {
            int n = boxes.Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (boxes[j] == '1')
                    {
                        count += Math.Abs(i - j);
                    }
                }
                result[i] = count;
            }

            return result;
        }
        public int[][] DivideArray(int[] nums, int k)
        {
            List<int[]> result = new List<int[]>();
            Array.Sort(nums);

            int n = nums.Length;
            int left = 0;
            while (left < n)
            {
                int a = nums[left];
                int b = nums[left + 1];
                int c = nums[left + 2];

                if (c - a > k)
                {
                    return new int[0][];
                }
                else
                {
                    result.Add(new int[] { a, b, c });
                    left += 3;
                }
            }
            return result.ToArray();
        }
        public int NumberOfSubarrays(int[] nums, int k)
        {
            int res = 0;
            int n = nums.Length;
            int left = 0, right = 0;
            int count = 0;
            while (right < n)
            {
                if (nums[right] % 2 == 1)
                {
                    count++;
                }
                while (count > k)
                {
                    if (nums[left] % 2 == 1)
                    {
                        count--;
                    }
                    left++;
                }
                if (count == k)
                {
                    int tempLeft = left;
                    while (tempLeft < n && nums[tempLeft] % 2 == 0)
                    {
                        tempLeft++;
                    }
                    res += (tempLeft - left + 1);
                }
                right++;
            }

            return res;
        }
        public int MinOperations(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                    nums[i] = FlipValue(nums[i]);
                    nums[i + 1] = FlipValue(nums[i + 1]);
                    nums[i + 2] = FlipValue(nums[i + 2]);
                }
            }
            if (nums[nums.Length - 2] == 0 || nums[nums.Length - 1] == 0) return -1;
            return count;
        }
        private int FlipValue(int val)
        {
            return val == 1 ? 0 : 1;
        }
        public int NumberOfSubstrings(string s)
        {
            int count = 0;
            int left = 0;
            Dictionary<char, int> charCount = new() {
            { 'a', 0 }, { 'b', 0 }, { 'c', 0 }
        };

            for (int right = 0; right < s.Length; right++)
            {
                charCount[s[right]]++;

                while (charCount['a'] > 0 && charCount['b'] > 0 && charCount['c'] > 0)
                {
                    count += s.Length - right;
                    charCount[s[left]]--;
                    left++;
                }
            }

            return count;
        }
        public int[] BuildArray(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            for(int i = 0; i < nums.Length; i++)
            {
                int itemp = nums[i];
                result[i] = nums[itemp];
            }

            return result;
        }
        public int MinimumRecolors(string blocks, int k)
        {
            int blackCount = 0, ans = int.MaxValue;

            for (int i = 0; i < blocks.Length; i++)
            {
                if (i - k >= 0 && blocks[i - k] == 'B') blackCount--;
                if (blocks[i] == 'B') blackCount++;
                ans = Math.Min(ans, k - blackCount);
            }

            return ans;
        }

        public int DivisorSubstrings(int num, int k)
        {
            int countOfBeauty = 0;
            string number = num.ToString();
            int n = number.Length;
            int start = 0;
            while(n >= k)
            {
                int divisor = int.Parse(number.Substring(start, k));
                if(divisor == 0)
                {
                    start++;
                    n = number.Substring(start).Length;
                    continue;
                }
                else if (num % divisor == 0 ) {
                    countOfBeauty++;
                }
                start++;
                n = number.Substring(start).Length;
            }

            return countOfBeauty;
        }
        public int ArrayPairSum(int[] nums)
        {
            int result = 0;
            Array.Sort(nums);
            for(int i = 0; i < nums.Length; i += 2)
            {
                result += nums[i];
            }

            return result;
        }
        public void MinimumDifference(int[] nums, int k)
        {
            int minDiff = 0;
            int n = nums.Length;
            //if (n == 1) return 0;

            Array.Sort(nums);

            foreach(int i in nums)
            {
                //Console.WriteLine(i);
            }

            Console.WriteLine(nums[n-k]);
        }
        public int CountGoodSubstrings(string s)
        {
            int count = 0;
            var charSet = new HashSet<char>();
            for (int i = 0; i < s.Length - 2; i++)
            {
                charSet.Clear();
                charSet.Add(s[i]);
                charSet.Add(s[i + 1]);
                charSet.Add(s[i + 2]);
                if (charSet.Count == 3)
                {
                    count++;
                }
            }

            return count;
        }

        public double FindMaxAverage(int[] nums, int k)
        {
            int n = nums.Length;
            double maxAverage = double.MinValue;
            double currentSum = 0;
            int left = 0, right = 0;
            while (right < n)
            {
                currentSum += nums[right];
                if (right - left + 1 == k)
                {
                    maxAverage = Math.Max(maxAverage, currentSum / k);
                    currentSum -= nums[left];
                    left++;
                }
                right++;
            }
            return maxAverage;
        }

        public int FindLHS(int[] nums)
        {
            int maxLength = 0;
            nums = nums.OrderBy(x => x).ToArray();
            var numCount = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numCount.ContainsKey(nums[i]))
                {
                    numCount[nums[i]]++;
                    if (numCount.ContainsKey(nums[i] + 1))
                    {
                        int length = numCount[nums[i]] + numCount[nums[i] + 1];
                        if (length > maxLength)
                        {
                            maxLength = length;
                        }
                    }
                    if (numCount.ContainsKey(nums[i] - 1))
                    {
                        int length = numCount[nums[i]] + numCount[nums[i] - 1];
                        if (length > maxLength)
                        {
                            maxLength = length;
                        }
                    }
                }
                else
                {
                    numCount[nums[i]] = 1;
                    if (numCount.ContainsKey(nums[i] + 1))
                    {
                        int length = numCount[nums[i]] + numCount[nums[i] + 1];
                        if (length > maxLength)
                        {
                            maxLength = length;
                        }
                    }
                    if (numCount.ContainsKey(nums[i] - 1))
                    {
                        int length = numCount[nums[i]] + numCount[nums[i] - 1];
                        if (length > maxLength)
                        {
                            maxLength = length;
                        }
                    }
                }
            }

            return maxLength;
        }

        public int PrefixCount(string[] words, string pref)
        {
            int numberOfWords = 0;
            int length = pref.Length;
            foreach (string word in words)
            {
                if (word.Length >= length && word.Substring(0, length) == pref)
                {
                    numberOfWords++;
                }
            }

            return numberOfWords;
        }

        public string FirstPalindrome(string[] words)
        {
            string firstPalindrome = "";
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    firstPalindrome = word;
                    break;
                }
            }

            return firstPalindrome;
        }
        public bool IsPalindrome(string word)
        {
            int left = 0, right = word.Length - 1;
            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public int CountPoints(string rings)
        {
            var ringsMap = new Dictionary<int, HashSet<char>>();

            for (int i = 0; i < rings.Length; i += 2)
            {
                char color = rings[i];
                int position = rings[i + 1] - '0';
                if (!ringsMap.ContainsKey(position))
                {
                    ringsMap[position] = new HashSet<char>();
                }
                ringsMap[position].Add(color);
            }
            int result = 0;
            foreach (var kvp in ringsMap)
            {
                if (kvp.Value.Count == 3)
                {
                    result++;
                }
            }
            return result;
        }

        public int MostWordsFound(string[] sentences)
        {
            int maxWords = 0;
            foreach (string sentence in sentences)
            {
                int wordCount = sentence.Split(' ').Length;
                maxWords = Math.Max(maxWords, wordCount);
            }

            return maxWords;
        }

        public int CountWords(string[] words1, string[] words2)
        {
            int count = 0;
            var wordCount1 = new Dictionary<string, int>();
            var wordCount2 = new Dictionary<string, int>();
            foreach (string word in words1)
            {
                if (wordCount1.ContainsKey(word))
                {
                    wordCount1[word]++;
                }
                else
                {
                    wordCount1[word] = 1;
                }
            }
            foreach (string word in words2)
            {
                if (wordCount2.ContainsKey(word))
                {
                    wordCount2[word]++;
                }
                else
                {
                    wordCount2[word] = 1;
                }
            }
            foreach (var kvp in wordCount1)
            {
                if (kvp.Value == 1 && wordCount2.ContainsKey(kvp.Key) && wordCount2[kvp.Key] == 1)
                {
                    count++;
                }
            }
            return count;
        }

        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string s1 = string.Join("", word1);
            string s2 = string.Join("", word2);
            return s1 == s2;
        }

        public int MaxDepth(string s)
        {
            int count = 0;
            int maxDepth = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    count++;
                    maxDepth = Math.Max(maxDepth, count);
                }
                else if (c == ')')
                {
                    count--;
                }
            }
            return maxDepth;
        }

        public long CountSubarrays(int[] nums, int k)
        {
            long result = 0;
            int n = nums.Length;
            int left = 0, right = 0;
            int maxElementsCount = 0;
            int maxElement = nums.Max();
            while (right < n)
            {
                if (nums[right] == maxElement)
                {
                    maxElementsCount++;
                }
                while (maxElementsCount == k)
                {
                    if (nums[left] == maxElement)
                    {
                        maxElementsCount--;
                    }
                    left++;
                }

                result += left; 
            }

            return result;
        }

        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            int answer = 0, currentSum = 0;
            int n = nums.Length;
            int left = 0, right = 0;
            while (right < n)
            {
                currentSum += nums[right];
                while (currentSum > goal)
                {
                    currentSum -= nums[left];
                    left++;
                }
                if (currentSum == goal)
                {
                    answer++;
                    int tempLeft = left;
                    while (tempLeft < n && nums[tempLeft] == 0 && tempLeft < right)
                    {
                        answer++;
                        tempLeft++;
                    }
                }
                right++;
            }
            return answer;
        }

        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int n = nums.Length;
            int answer = 0, currentProduct = 1;
            int left = 0, right = 0;
            while (right < n)
            {
                currentProduct *= nums[right];
                while (currentProduct >= k && left <= right)
                {
                    currentProduct /= nums[left];
                    left++;
                }
                answer += right - left + 1;
                right++;
            }

            return answer;
        }

        public long CountSubarrays(int[] nums, long k)
        {
            long crtSum = 0, answer = 0;
            int n = nums.Length;
            int left = 0, right = 0;
            
            while(right < n)
            {
                crtSum += nums[right];
                while((right-left+1)*crtSum >= k)
                {
                    crtSum -= nums[left];
                    left++;
                }
                answer += right - left + 1;
                right++;                
            }

            return answer;
        }


        public int SingleNonDuplicate(int[] nums)
        {
            int answer = 0;
            int n = nums.Length;
            int start = 0, end = n - 1;
            if (n == 1) return nums[0];
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                {
                    answer = nums[mid];
                    break;
                }
                if (nums[mid] == nums[mid - 1])
                {
                    int leftCount = mid - start + 1;
                    if (leftCount % 2 == 1)
                    {
                        end = mid - 2;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    int rightCount = end - mid + 1;
                    if (rightCount % 2 == 1)
                    {
                        start = mid + 2;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            if (start == end)
            {
                answer = nums[start];
            }
            return answer;
        }
        public int NumIdenticalPairs(int[] nums)
        {
            int answer = 0;
            var same = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (same.ContainsKey(num))
                {
                    same[num]++;
                }
                else
                {
                    same[num] = 1;
                }
            }
            foreach (var num in same)
            {
                answer += (num.Value * (num.Value - 1)) / 2;
            }

            return answer;
        }

        public long CountSubarrays(int[] nums, int minK, int maxK) 
        {
            long res = 0;   
            int n = nums.Length;
            int minIndex = -1, maxIndex = -1, invalidIndex = -1;
            for(int i = 0; i < n; i++)
            {
                if (nums[i] < minK || nums[i] > maxK)
                {
                    invalidIndex = i;
                }
                if (nums[i] == minK)
                {
                    minIndex = i;
                }
                if (nums[i] == maxK)
                {
                    maxIndex = i;
                }
                res += Math.Max(0, Math.Min(minIndex, maxIndex) - invalidIndex);
            }

            return res;
        }
        public string DestCity(IList<IList<string>> paths)
        {
            string result = "";
            HashSet<string> startCities = new HashSet<string>();
            foreach (var path in paths)
            {
                startCities.Add(path[0]);
            }
            foreach (var path in paths)
            {
                if (!startCities.Contains(path[1]))
                {
                    result = path[1];
                    break;
                }
            }

            return result;
        }
        public string SortString(string s)
        {
            var charCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            var sortedChars = charCount.Keys.ToList();
            sortedChars.Sort();
            StringBuilder result = new StringBuilder();
            foreach (char c in sortedChars)
            {
                for (int i = 0; i < charCount[c]; i++)
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
        public int CountInterestingSubarrays(List<int> nums, int modulo, int k)
        {
            int n = nums.Count;

            for (int i = 0; i < n; i++)
            {
                nums[i] = (nums[i] % modulo == k) ? 1 : 0;
            }

            Dictionary<int, int> count = new Dictionary<int, int>();
            count[0] = 1; 

            int result = 0;
            int prefix = 0;

            for (int i = 0; i < n; i++)
            {
                prefix = (prefix + nums[i]) % modulo;

                int target = (prefix - k + modulo) % modulo;

                if (count.ContainsKey(target))
                {
                    result += count[target];
                }

                if (count.ContainsKey(prefix))
                {
                    count[prefix]++;
                }
                else
                {
                    count[prefix] = 1;
                }
            }

            return result;
        }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            bool ans = false;
            int right = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                while (right < nums.Length && right - i <= k)
                {
                    if (nums[i] == nums[right] && i != right)
                    {
                        ans = true;
                        break;
                    }
                    right++;
                }
            }

            return ans;
        }

        public int LengthOfLongestSubstring(string s)
        {
            int maxLenght = 0;
            var charSet = new HashSet<char>();
            int left = 0, right = 0;
            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    maxLenght = Math.Max(maxLenght, right - left + 1);
                    right++;
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }

            return maxLenght;
        }
        public int CountCompleteSubarrays(int[] nums)
        {
            int result = 0;
            int n = nums.Length;
            HashSet<int> uniqueNumbers = new HashSet<int>(nums);
            int uniqueCount = uniqueNumbers.Count;
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            int right = 0;
            for (int left = 0; left < n; left++)
            {
                if(left > 0)
                {
                    countMap[nums[left - 1]]--;
                    if (countMap[nums[left - 1]] == 0)
                    {
                        countMap.Remove(nums[left - 1]);
                    }
                }

                while (right < n && countMap.Count < uniqueCount)
                {
                    if (right < n)
                    {
                        if (!countMap.ContainsKey(nums[right]))
                        {
                            countMap[nums[right]] = 0;
                        }
                        countMap[nums[right]]++;
                    }
                    right++;
                }
                if (countMap.Count == uniqueCount)
                {
                    result += n - right + 1;
                }
            }
            return result;
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string sortedStr = new string(chars);
                if (groupedAnagrams.ContainsKey(sortedStr))
                {
                    groupedAnagrams[sortedStr].Add(str);
                }
                else
                {
                    groupedAnagrams[sortedStr] = new List<string>() { str };
                }
            }
            foreach (var kvp in groupedAnagrams)
            {
                result.Add(kvp.Value);
            }
            return result;
        }
        public int CountLargestGroup(int n)
        {
            var groupedNumbers = new Dictionary<int, int>();
            for (int i = 1; i <= n; i++)
            {
                int sum = SumOfDigits2(i);
                if (groupedNumbers.ContainsKey(sum))
                {
                    groupedNumbers[sum]++;
                }
                else
                {
                    groupedNumbers[sum] = 1;
                }
            }
            int maxCount = groupedNumbers.Values.Max();
            int groupCount = groupedNumbers.Values.Count(x => x == maxCount);

            return groupCount;
        }
        public int SumOfDigits2(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        public int NumberOfArrays(int[] differences, int lower, int upper)
        {
            int minPrefixSum = 0;
            int maxPrefixSum = 0;
            int prefixSum = 0;
            foreach(int diff in differences)
            {
                prefixSum += diff;
                minPrefixSum = Math.Min(minPrefixSum, prefixSum);
                maxPrefixSum = Math.Max(maxPrefixSum, prefixSum);
            }

            return Math.Max(upper - lower - maxPrefixSum + minPrefixSum + 1, 0);
        }
        public int NumRabbits(int[] answers)
        {
            HashSet<int> uniqueAnswers = 
                new HashSet<int>(answers);

            int totalRabbits = 0;
            foreach (int answer in uniqueAnswers)
            {
                int count = 0;
                foreach (int ans in answers)
                {
                    if (ans == answer)
                    {
                        count++;
                    }
                }
                totalRabbits += (count + answer) / (answer + 1) * (answer + 1); 
            }

            return totalRabbits;
        }
        public int CountKDifference(int[] nums, int k)
        {
            int answer = 0;
            for( int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        answer++;
                    }
                }
            }

            return answer;
        }
        public int CountPairs(int[] nums, int k)
        {
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>(); // key - number, value - indexes of the number
            for(int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs[nums[i]].Add(i);
                }
                else
                {
                    keyValuePairs[nums[i]] = new List<int>() { i };
                }
            }

            int count = 0;
            foreach (var kvp in keyValuePairs)
            {
                int number = kvp.Key;
                List<int> indexes = kvp.Value;
                for (int i = 0; i < indexes.Count; i++)
                {
                    for (int j = i + 1; j < indexes.Count; j++)
                    {
                        if ((indexes[i] * indexes[j]) % k == 0)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
        public bool HasSameDigits(string s)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++)
            {
                int num = (s[i] - '0' + s[i + 1] - '0') % 10;
                newString.Append(num);
            }

            string s2 = newString.ToString();

            if (s2.Length == 2)
            {
                return s2[0] == s2[1];
            }

            return HasSameDigits(s2);
        }
        public int ReverseDegree(string s) //abc
        {
            int result = 0;
            for(int i = 0; i < s.Length; i++)
            {
                result += (Math.Abs((int)s[i] - 122) + 1) * i;
            }
            return result;
        }
        public int CountQuadruplets(int[] nums)
        {
            int answer = 0;
            for (int a = 0; a < nums.Length; a++)
            {
                for (int b = a + 1; b < nums.Length; b++)
                {
                    for(int c = b + 1; c < nums.Length; c++)
                    {
                        for(int d = c + 1; d < nums.Length; d++)
                        {
                            if (nums[a] + nums[b] + nums[c] == nums[d])
                            {
                                answer++;
                            }
                        }
                    }
                }
            }

            return answer;
        }
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int answered = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(Math.Abs(arr[i] - arr[j]) < a)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if(Math.Abs(arr[j] -arr[k]) < b && Math.Abs(arr[i] - arr[k]) < c)
                            {
                                answered++;
                            }
                        }
                    }
                }
            }

            return answered;
        }
        public string DefangIPaddr(string address)
        {
            address = address.Replace(".", "[.]");

            return address;
        }
        private Dictionary<char, string> MorseMap = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."}
        };
        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<string, int> differentePairs = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string morseCode = "";
                foreach (char c in word)
                {
                    morseCode += MorseMap[c];
                }
                if (!differentePairs.ContainsKey(morseCode))
                {
                    differentePairs[morseCode] = 1;
                }
                else
                {
                    differentePairs[morseCode]++;
                }
            }

            return differentePairs.Count;
        }
        public int MinOperations(int[] nums, int k)
        {
            int n = nums.Length;
            nums = nums.OrderByDescending(x => x).ToArray();
            int minOperations = 0;
            
            for(int i = 0; i < n - 1; i++)
            {
                if (nums[i] < k)
                {
                    minOperations = -1;
                    break;
                }
                else if (nums[i] > k)
                {
                    if (nums[i+1] != nums[i])
                    {
                        minOperations++;
                    }
                }
            }

            return minOperations;
        }
        public int GetLucky(string s, int k)
        {
            string numStr = HelperMethod(s);

            int num = SumOfDigits(numStr);
            k--; 

            while (k > 0)
            {
                num = SumOfDigits(num.ToString());
                k--;
            }

            return num;
        }

        public string HelperMethod(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                result += (c - 'a' + 1).ToString();
            }
            return result;
        }

        public int SumOfDigits(string numStr)
        {
            int sum = 0;
            foreach (char c in numStr)
            {
                sum += (c - '0'); 
            }
            return sum;
        }



        public void SortColors(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;
                    high--;
                }
            }

        }
        public int MyAtoi(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;

            int index = 0, n = s.Length, sign = 1;
            long result = 0;

            while(index < n && s[index] == ' ')
            {
                index++;
            }

            if(index < n && (s[index] == '+' || s[index] == '-'))
            {
                sign = s[index] == '+' ? 1 : -1;
                index++;
            }

            while (index < n && char.IsDigit(s[index]))
            {
                result = result * 10 + (s[index] - '0');
                if (result > int.MaxValue)
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
                index++;
            }

            return (int)result * sign;

        }

        public int NumberOfAlternatingGroups(int[] colors, int k)
        {
            int res = 0;
            int n = colors.Length;

            int alternatingCount = 0;
            for (int i = 1; i < k; i++)
            {
                if (colors[i] != colors[i - 1])
                    alternatingCount++;
            }

            if (alternatingCount == k - 1) res++;

            for (int i = 1; i < n; i++)
            {
                int oldIndex = (i - 1) % n;
                int newIndex = (i + k - 1) % n; 

                if (colors[oldIndex] != colors[(oldIndex + 1) % n])
                    alternatingCount--;

                if (colors[newIndex] != colors[(newIndex - 1 + n) % n])
                    alternatingCount++;

                if (alternatingCount == k - 1) res++;
            }

            return res;
        }
        public int[] ClosestPrimes(int left, int right)
        {
            int[] answer = new int[2];
            List<int> primes = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if(IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            int minDifference = int.MaxValue;
            if(primes.Count < 2)
            {
                return new int[] { -1, -1 };
            }
            else
            {
                for(int i = 0; i < primes.Count; i++)
                {
                    int min = primes[i+1] - primes[i];
                    if (min < minDifference)
                    {
                        minDifference = min;
                        answer[0] = primes[i];
                        answer[1] = primes[i + 1];
                    }
                }
            }

            return answer;
        }
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public int[] ApplyOperations(int[] nums)
        {
            int length = nums.Length;
            for (int i = 0; i < length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = nums[i] * 2;
                    nums[i + 1] = 0;
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            nums[i] = nums[j];
                            nums[j] = 0;
                            break;
                        }
                    }
                }

            }

            return nums;
        }
        public int PunishmentNumber(int n)
        {
            int sum = 0;
            for (int i= 1; i <= n; i++)
            {
                if (SumOfPartitionsEqualsToNumber(i, i * i))
                {
                    sum += i * i;
                }
            }

            return sum;
        }
        public static bool SumOfPartitionsEqualsToNumber(int target, int partitions)
        {
            if (target == partitions)
            {
                return true;
            }
            if (partitions < 0)
            {
                return false;
            }
            if (target <= 0)
            {
                return false;
            }

            int divisor = 10;
            while (divisor <= partitions)
            {
                int left = partitions / divisor;
                int right = partitions % divisor;
                if (SumOfPartitionsEqualsToNumber(target - left, right) || SumOfPartitionsEqualsToNumber(target - right, left))
                {
                    return true;
                }

                divisor *= 10;
            }

            return false;
        }

        public int MinStoneSum(int[] piles, int k)
        {
            var q = new PriorityQueue<int,int>();
            foreach (var p in piles)
            {
                q.Enqueue(p,-p);
            }

            for (int i = 0; i < k; i++)
            {
                int maxElement = q.Peek();
                q.Dequeue();
                int addedElement = maxElement / 2;
                q.Enqueue((int)addedElement, (int)-addedElement);
            }

            int sum = 0;
            for(int i = 0; i < q.Count; i++)
            {
                sum += q.Dequeue();
            }

            return sum;
        }
        public int MinOperations2(int[] nums, int k)
        {
             var q = new PriorityQueue<long,long>();


            foreach (int i in nums)
            {
                q.Enqueue(i,i);
            }
            int countOperations = 0;

            while(q.Peek() < k)
            {
                if(q.Count >= 2)
                {
                    countOperations++;
                    long min1 = q.Dequeue();
                    long min2 = q.Dequeue();
                    long addedElement = Math.Min(min1, min2) * 2 + Math.Max(min1, min2);

                    q.Enqueue(addedElement,addedElement);
                }
            }
            
            return countOperations;
        }
        // +++++++++++++++++++++//
        public int MaximumSum(int[] nums)
        {
            int maxSum = 0;

            var groupedArray = GroupByDigitSum(nums);

            foreach (var group in groupedArray)
            {
                if(group.Value.Count() > 1)
                {
                    int sum = group.Value.Sum();
                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            return (maxSum == 0) ? -1 : maxSum;

        }
        static Dictionary<int, List<int>> GroupByDigitSum(int[] arr)
        {
            return arr.
                GroupBy(n => SumOfDigits(n))
                .ToDictionary(
                    g => g.Key,
                    g => g.OrderByDescending(x => x)
                        .Take(2)
                        .ToList()
                );
        }
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
        //---------------------------//
        public int CountKeyChanges(string s)
        {
            StringBuilder sb = new StringBuilder(s.ToLower());
            char lastKey = sb[0];
            int res = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (sb[i] != lastKey)
                {
                    res++;
                    lastKey = s[i];
                }
            }

            return res;
        }
        public string RemoveOccurrences(string s, string part)
        {
            int length = part.Length;
            while (s.Contains(part))
            {
                int index = s.IndexOf(part);

                s.Remove(index, length);
            }
            
            return s;
        }
        public string ClearDigits(string s)
        {
            for (int i = 0;i < s.Length;i++)
            {
                if (char.IsDigit(s[i]))
                {
                    if (!char.IsDigit(s[i - 1]))
                    {
                        s.Remove(i - 1, 2);
                    }
                    else if (char.IsDigit(s[i + 1])) 
                    {
                        s.Remove(s[i], 2);
                    }
                    else
                    {
                        s.Remove(i);
                    }
                }
            }

            return s;
        }
        public int DistMoney(int money, int children)
        {
            if (money < children)
                return -1;
            
            int remaining = money - children; // 15

            int maxEights = remaining / 7; // 2
            int mod = remaining % 7; // 1

            if (maxEights == children - 1 && mod == 3)
            {
                return maxEights - 1;
            }
            else if (maxEights == children && mod == 0)
            {
                return children;
            }
            else if (maxEights == children)
            {
                return children - 1;
            }
            else if (maxEights > children)
            {
                return children - 1;
            }
            if (maxEights > children)
                return children - 1;

            return maxEights;
        }
        public long CountBadPairs(int[] nums)
        {
            long n = nums.Length;

            long badPairs = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (nums[j] - j != nums[i] - i)
                        badPairs++;
                }
            }

            return badPairs;
        }
        public string MaximumOddBinaryNumber(string s)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    sb1.Append(s[i]);
                }
                else 
                    sb2.Append(s[i]);
            }
            if(sb1.Length == 1) 
                return (sb2.Append(sb1)).ToString();
            sb1.Remove(0, 1);
            sb2.Append('1');

            return sb1.Append(sb2).ToString();
        }
        public int encrypt(int x)
        {
            int maxDigit = 0;
            int count = 0;
            while (x > 0)
            {
                int digit = x % 10;
                if (digit > maxDigit ) 
                    maxDigit = digit;
                count++;
                x  /= 10;
            }
            int result = 0;
            while (count > 0)
            {
                result = result * 10 + maxDigit;
                count--;
            }

            return result;
        }
        public int GenerateKey(int num1, int num2, int num3)
        {
            int divider = 1000;
            int result = 0;
            while (num1 > 0)
            {
                int minimumDigit = Math.Min(num1 / divider,
                            Math.Min(num2 / divider, num3 / divider));
                num1 %= divider;
                num3 %= divider;
                num2 %= divider;
                divider /= 10;

                result += minimumDigit * divider;
            }

            return result;
        }
        // ++++++++++++++++++++++++++//
        public Dictionary<int, int> indexToNumber;
        public Dictionary<int, SortedSet<int>> numberToIndex;
        public Solution()
        {
            indexToNumber = new Dictionary<int, int>();
            numberToIndex = new Dictionary<int, SortedSet<int>>();
        }

        public void Change(int index, int number)
        {
            if (indexToNumber.ContainsKey(index))
            {
                int oldNumber = indexToNumber[index];

                numberToIndex[oldNumber].Remove(index);

                if (numberToIndex[oldNumber].Count == 0)
                {
                    numberToIndex.Remove(oldNumber);
                }
            }

            indexToNumber[index] = number;
            if (!numberToIndex.ContainsKey(number))
            {
                numberToIndex[number] = new SortedSet<int>();
            }
            numberToIndex[number].Add(index);
                
    }

        public int Find(int number)
        {
            if (numberToIndex.ContainsKey(number))
            {
                var result = numberToIndex[number];

                foreach(int num in result)
                {
                    return num;
                    break;
                }
            }

            return -1;
        }

        // ------------------------//

        public bool CanAliceWin(int[] nums)
        {
            int oneDigSum = 0;
            int twoDigSum = 0;
            for (int i = 0; i < nums.Length; i++)
            { 
                if (nums[i] > 9)
                {
                    twoDigSum += nums[i];
                }
                oneDigSum += nums[i];
            }

            if (oneDigSum == twoDigSum)
                return false;

            return true;
        }
        public int[] QueryResults(int limit, int[][] queries)
        {
            var ballColour = new Dictionary<int, int>();
            var colourBalls = new Dictionary<int, HashSet<int>>();

            var result = new List<int>();

            foreach(var query in queries)
            {
                int ball = query[0];
                int color = query[1];

                if (ballColour.ContainsKey(ball))
                {
                    int oldColor = ballColour[ball];
                    colourBalls[oldColor].Remove(ball);

                    if (colourBalls[oldColor].Count() == 0)
                    {
                        colourBalls.Remove(oldColor);
                    }
                }

                ballColour[ball] = color;

                if (!colourBalls.ContainsKey(color))
                {
                    colourBalls[color] = new HashSet<int>();
                }

                colourBalls[color].Add(ball);

                result.Add(colourBalls.Count);
            }

            return result.ToArray();
        }
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            for (int i = 1; i <= k; i++)
            {
                int min = nums.Min();
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == min)
                    {
                        nums[j] = min * multiplier;
                        break;
                    }
                }

            }

            return nums;
        }
        //+++++++++//
        public bool IsHappy(int n)
        {
            if ( n < 10)
            {
                if (n == 1 || n == 7) return true;
                return false;
            }

            int Sum = SumOfDigitsSquare(n);

            return IsHappy(Sum);
        }
        public int SumOfDigitsSquare(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result += (num % 10);
                num /= 10;
            }

            return result;
        }
        // -------------//

        // +++++++++++++++/////
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (isSelfDividing(i))
                    result.Add(i);
            }

            return result;
        }
        private bool isSelfDividing(int number)
        {
            bool answer = true;
            int trueNumber = number;
            while(number > 0)
            {
                int chunk = number % 10;
                if (chunk == 0)
                {
                    answer = false;
                    break;
                }
                if (trueNumber % chunk != 0)
                {
                    answer = false;
                    break;
                }
                number /= 10;
            }

            return answer;
        }
        // --------------------//
        // +++++++++++//
        public int CountPrimeSetBits(int left, int right)
        {
            int countPrime = 0;
            for (int i = left; i <= right; i++)
            {
                if (isPrime(HelperFunc(i)))
                {
                    countPrime++;
                }
            }

            return countPrime;
        }
        public int HelperFunc(int n)
        {
            string number = Convert.ToString(n, 2);
            int numberOfSit = 0;
            for (int i = 0;i < number.Length; i++)
            {
                if (number[i] == '1')
                {
                    numberOfSit++;
                }
            }

            return numberOfSit;
        }
        public bool isPrime(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            return count == 2;
        }
        // ------------------//

        public bool CheckTwoChessboards(string coordinate1, string coordinate2)
        {
            var rdMap = new Dictionary<char, int>()
            {
                {'a', 1},
                {'b', 2},
                {'c', 3},
                {'d', 4},
                {'e', 5},
                {'f', 6},
                {'g', 7},
                {'h', 8}
            };
            int SumOfC1 = coordinate1[1] + rdMap[coordinate1[0]];
            int SumOfC2 = coordinate2[1] + rdMap[coordinate2[0]];

            bool result = (((SumOfC1 & 1) == 1), ((SumOfC2 & 1) == 1)) switch
            {
                (true, true) => true,
                (false, false) => true,
                _ => false
            };

            return result;
        }

        public string ConvertDateToBinary(string date)
        {
            string[] numbers = date.Split('-');
         
            string year = Convert.ToString(int.Parse(numbers[0]),2);
            string motnh = Convert.ToString(int.Parse(numbers[1]),2);
            string day = Convert.ToString(int.Parse(numbers[2]),2);

            return year + '-' + motnh + '-' + day;
        }
        ////++++++++++++++++++//
        //public int MinElement(int[] nums)
        //{
        //    int minimumElm = 40;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (minimumElm > SumOfDigits(nums[i]))
        //        {
        //            minimumElm = SumOfDigits(nums[i]);
        //        }
        //    }

        //    return minimumElm;
        //}
        //public int SumOfDigits(int num)
        //{
        //    int result = 0;
        //    while(num > 0)
        //    {
        //        result += num % 10;
        //        num /= 10;
        //    }

        //    return result;
        //}
        ////-----------------------//

        public bool AreAlmostEqual(string s1, string s2)
        {
            bool answer = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (!s2.Contains(s2[i]))
                {
                    answer = false;
                    break;
                }
            }

            return answer;
        }

        //++++++++++++++++++++++++//
        public int SmallestNumber(int n, int t)
        {
            while (true)
            {
                if (ProductOfDigits(n) % t == 0)
                    return n;
                n++;
            }
        }
        public int ProductOfDigits(int n)
        {
            int products = 1;
            while(n > 0)
            {
                products *= (n % 10);
                n /= 10;
            }

            return products;
        }
        //---------------------------//
        public int SmallestNumber(int n)
        {
            if (n == 1) return 1;
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (n > (Math.Pow(2, i - 1)-1) && n <= Math.Pow(2, i) - 1)
                {
                    result = ((int)Math.Pow(2, i)) - 1;
                    break;
                }
            }

            return result;
        }

        public int CountPartitions(int[] nums)
        {
            int result = 0;
            int firstPat = 0;
            int SecPat = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    firstPat += nums[j];

                }
                for (int k = i; k < nums.Length; k++)
                {
                    SecPat += nums[k];
                }
                int difference = Math.Abs(firstPat - SecPat);
                if ( (difference & 1) == 0)
                {
                    result++;
                }
                firstPat = 0;
                SecPat = 0;
            }

            return result;
        }

        public int MaxDifference(string s)
        {
            var frequency = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }

            }

            List<int> evenList = frequency.Values.Where(x => x % 2 == 0).ToList();
            List<int> oddList = frequency.Values.Where(x => x % 2 != 0).ToList();

            int answer = -evenList.Max() + oddList.Min();

            return answer;
        }

        // ++++++++++++++++++++++++++//
        public int FindKthNumber(int n, int k)
        {
            long current = 1;
            k -= 1;
            while (k > 0)
            {
                long steps = CountSteps(current, n);
                if ( k < steps)
                {
                    current *= 10;
                    k -= 1;
                }
                else
                {
                    current += 1;
                    k -= (int)steps;
                }
            }

            return (int)current;
        }

        public long CountSteps(long current,long n)
        {
            long count = 0;
            long next = current + 1;
            while ( current <= n )
            {
                count += Math.Min(next, n + 1) - current; //n+1 - n ni o'zini ham olish mumkin ex: 100
                current *= 10;
                next *= 10;
            }

            return count;
        }

        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;

            double result = 1;

            long degree = n;
            if (n < 0)
            {
                x = 1 / x;
                degree = -degree;
            }

            while (degree > 0)
            {
                if ((degree & 1 )== 1)
                {
                    result *= x;
                    degree -= 1;
                }
                else
                {
                    x *= x;
                    degree >>= 1;
                }
            }

            return result;
        }

        public int MaxAscendingSum(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i-1])
                {
                    currentSum += nums[i];
                }
                else
                {
                    if (currentSum >= maxSum)
                    {
                        maxSum = currentSum;
                    }

                    currentSum = nums[i];
                }
            }

            return Math.Max(currentSum,maxSum);
        }
        // ---------------------------///
        // +++++++++++++++++++++++++++///
        string[] ToTwenty = {"", "One", "Two", "Three", "Four", "Five",
        "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen",
        "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

        string[] Tens = {"", "", "Twenty", "Thirty", "Forty",
        "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        string[] Thousands = { "Thousand", "Million", "Billion" };

        public string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";

            string answer = "";
            int level = 9; 
            int index = 2; 

            while (level >= 0)
            {
                int divisor = (int)Math.Pow(10, level);
                int chunk = num / divisor;

                if (chunk > 0)
                {
                    answer += HelperForHundreds(chunk) + (index >= 0 ? Thousands[index] + " " : "");
                    num %= divisor;
                }

                level -= 3;
                index--;
            }

            answer += HelperForHundreds(num);
            return answer.Trim();
        }

        public string HelperForHundreds(int num)
        {
            if (num == 0) return "";

            string result = "";

            if (num >= 100)
            {
                result += ToTwenty[num / 100] + " Hundred ";
                num %= 100;
            }

            if (num >= 20)
            {
                result += Tens[num / 10] + " ";
                num %= 10;
            }

            if (num > 0)
            {
                result += ToTwenty[num] + " ";
            }

            return result;
        }

        // -------------------///

        public string IntToRoman(int num)
        {
            Dictionary<string, int> dic = 
                new Dictionary<string, int>()
            {
                {"M", 1000},
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"XC", 90},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1}
            };

            StringBuilder res = new StringBuilder();
            
            foreach (var kvp in dic)
            {
                while(num > kvp.Value)
                {
                    res.Append(kvp.Key);
                    num -= kvp.Value;
                }
            }

            return res.ToString();
        }

        public int MinimumPushes(string word)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

            var sortedFrequencies = frequency.Values.OrderByDescending(x => x).ToList();

            int totalPresses = 0;
            int keyIndex = 1; 

            for (int i = 0; i < sortedFrequencies.Count; i++)
            {
                totalPresses += sortedFrequencies[i] * keyIndex;

                if ((i + 1) % 8 == 0)
                    keyIndex++;
            }

            return totalPresses;
        }


        public static IList<string> LetterCombinations(string digits)
        {
            if(string.IsNullOrEmpty(digits)) 
                return new List<string>();

            Dictionary<char, string> map = 
                new Dictionary<char, string>()
            {
                {'2', "abc" },
                {'3', "def" },
                {'4', "ghi" },
                {'5', "jkl" },
                {'6', "mno" },
                {'7', "pqrs" },
                {'8', "tuv" },
                {'9', "wxyz" },
            };

            List<string> result = new();
            var currentCombination = new List<string>() { "" };

            foreach( var digit in digits)
            {
                string letters = map[digit];

                List<string> newCombination = new();

                foreach( var current in currentCombination )
                {
                    foreach( var letter in letters )
                    {
                        newCombination.Add(current + letter);
                    }
                }

                currentCombination = newCombination;
            }
            result.AddRange(currentCombination);

            return result;
        }

        public int Maximum69Number(int num)
        {
            int answer = 0;
            for (int i = 1000; i >= 1; i /= 10)
            {
                if (num / i == 6)
                {
                    answer += num + 3 * i;
                    break;
                }
                else
                {
                    if (num > i)
                    {
                        num = num % i;
                        answer += 9 * i;
                    }
                    num = num % i;
                }
            }

            return answer;
        }


        public long MaximumSubarraySum(int[] nums, int k)
        {
            long MaximumSubarraySum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                long SubarraySum = 0;
                for (int j = i; j <= i + k; j++)
                {
                    if (i + j < nums.Length - 1)
                    {
                        if (nums[j] != nums[j + 1])
                        {
                            SubarraySum += nums[j];
                        }
                        else
                        {
                            SubarraySum += 0;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (SubarraySum > MaximumSubarraySum)
                    MaximumSubarraySum = SubarraySum;
            }

            return MaximumSubarraySum;
        }


        public char FindingHardLetter(int numbersOfLetters,string text, string times)
        {
            List<int> timesList = times.Split(' ').Select(int.Parse).ToList();
            int maxTime = timesList[0];
            char output = text[0];
            for(int i = 1; i < timesList.Count; i++)
            {
                if (timesList[i] - timesList[i-1] >= maxTime)
                {
                    maxTime = timesList[i] - timesList[i - 1];
                    output = text[i];
                }
            }

            return output;
        }


        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
                return int.MaxValue;

            bool isNegative = (dividend < 0) ^ (divisor < 0);
            long absDividend = Math.Abs((long)dividend);
            long absDivisor = Math.Abs((long)divisor);

            long result = 0;
            while (absDividend >= absDivisor)
            {
                long temp = absDivisor;
                long multiple = 1;
                while (absDividend >= (temp << 1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }
                absDividend -= temp;
                result += multiple;
            }

            if (isNegative)
                result = -result;

            if (result > int.MaxValue)
                return int.MaxValue;
            if (result < int.MinValue)
                return int.MinValue;

            return (int)result;
        }


        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[k-1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }

        public int SearchInsert(int[] nums, int target) 
        {
            int left = 0;
            int rigth = nums.Length -1;

            while (left <= rigth)
            {
                int average = left + (rigth - left) / 2;
                if (nums[average] == target)
                {
                    return average;
                }
                else if (nums[average] < target)
                {
                    left = average + 1;
                }
                else
                {
                    rigth = average - 1;
                }
            }
            return left;
            
        }

        public string ReverseOnlyLetters(string s)
        {
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (!char.IsLetter(chars[left]))
                {
                    left++;
                }
                else if (!char.IsLetter(chars[right]))
                {
                    right--;
                }
                else
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(chars.ToArray());
        }

        public int Fib(int n) 
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1) { return 1; }
            else if(n == 2) { return 1; }
            else
            {
                int fibanacci0 = 0; 
                int fibanacci1 = 1; 
                int nextFibanacci = 0; 
                int index = 1;

                while (index != n) 
                {
                    nextFibanacci = fibanacci0 + fibanacci1;  
                    fibanacci0 = fibanacci1;
                    fibanacci1 = nextFibanacci;
                    index++;
                }

                return nextFibanacci;
            }
        }

        public int Reverse(int x) 
        {
            int reversedNumber = 0;
            while (x != 0)
            {
                if (reversedNumber > int.MaxValue /10 || reversedNumber < int.MinValue / 10)
                    return 0;
                int restDigit = x % 10;
                reversedNumber = reversedNumber * 10 + restDigit;
                x /= 10;
            }
            
            return reversedNumber;
        }

        public int StrStr(string haystack, string needle)
        {
            int result = haystack.IndexOf(needle);
            return result;
        }


        //public bool IsValid(string s)
        //{
        //    int bracket1 = 0; 
        //    int bracket2 = 0; 
        //    int curlBracket = 0;
        //    int squareBrackets = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == '(')
        //        {
        //            bracket1++;
        //        }
        //        else if (s[i] == ')') { }
        //    }
        //}


        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0)
                        return "";
                }
            }


            return prefix;
        }

        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50},
                {'C',100},
                {'D',500 },
                {'M',1000 },

            };
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && map[s[i]] > map[s[i - 1]])
                {
                    result += map[s[i]] - 2 * map[s[i - 1]];
                }
                else
                    result += map[s[i]];
            }

            return result;
        }

        public int MinExtraChar(string s, string[] dictionary)
        {
            int commonChar = 0;
            foreach (var item in dictionary)
            {
                for (int i = 0; i <= s.Length - item.Length; i++)  
                {
                    if (s[i] == item[0])  
                    {
                        if (s.Substring(i, item.Length).Equals(item)) 
                        {
                            commonChar += item.Length;
                        }
                    }
                }
            }

            return s.Length - commonChar;
        }

        public bool IsPerfectSquare(int num)
        {
            bool result = false;
            for (long i = 0; i < num; i++)
            {
                while(i*i > num)
                {
                    if ((i - 1) * (i - 1) == num)
                    {
                        result = true;
                    }
                    else
                        break;
                }
            }
            return result;
        }
        public int MySqrt(int x)
        {
            int result = 0;
            for (long i = 0; i < x; i++)
            {
                if (i * i == x || i*i < x && (i+1)*(i+1) > x )
                {
                    result += (int)i;
                    break;
                }
                else
                    continue;
            }
            return result;
        }


        public bool IsMatch(string s, string p)
        {
            if (!p.Contains(".") && !p.Contains("*"))
            {
                if (p.Length == s.Length)
                {
                    return Regex.IsMatch(s, p);
                }
                else
                    return false;
            }
            return Regex.IsMatch(s, p);         
        }

        public int[] ArithmeticTriplets(int[] nums, int target)
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (nums.Contains(nums[i]) && nums.Contains(diff))
                {
                    index1 += i;
                    index2 += Array.FindIndex(nums, x => x == diff);
                } 
            }
            return new int[2] { index1, index2 };
        }
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();
            var s2 = new string(s.Reverse().ToArray());
            if(s == s2)
            {
                return true;
            }

            return false;
        }

        public IList<int> LexicalOrder(int n)
        {
            IList<int> values = new List<int>();
            for (int nums = 1;nums <= n;nums++)
            {
                values.Add(nums);                
            }

            return values.OrderBy(number => number.ToString()).ToArray();
        }

        public IList<int> LexicalOrderOptimized2(int n) 
        {
            List<int> values = new List<int>(n);

            int current = 1; // 10
            for(int i = 0; i <= n; i++)
            {
                values.Add(current);
                if (current * 10 <= n)
                {
                    current *= 10;
                }
                else
                {
                    if (current >= n)
                    {
                        current /= 10;
                    }
                    else
                    {
                        current++; // 11
                        while (current % 10 == 0)
                        {
                            current /= 10; // 1
                        }
                    }
                }
            }

            return values;
        }

        public int FindNumberDigit(int x)
        {
            int length = 0;
            while (x > 0)
            {
                x /= 10;
                length++;
            }
            return length;
        }
    }
}
