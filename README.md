# LeetCode-Algorithm
35. Search Insert Position </br>

Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Example 1 : Input: [1,3,5,6], 5 Output: 2  Example 2 : Input: [1,3,5,6], 2 Output: 1 </br>
Example 3 : Input: [1,3,5,6], 7 Output: 4  Example 4 : Input: [1,3,5,6], 0 Output: 0 </br>

情境分析 : SearchInsertPositionInputNull、SearchInsertPositionTargetNull、SearchInsertPosition

38. Count and Say </br>

The count-and-say sequence is the sequence of integers with the first five terms as following:

1     1 </br>
2     11 </br>
3     21 </br>
4     1211 </br>
5     111221 </br>
1 is read off as "one 1" or 11. </br>
11 is read off as "two 1s" or 21. </br>
21 is read off as "one 2, then one 1" or 1211. </br>

Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence. You can do so recursively, in other words from the previous member read off the digits, counting the number of digits in groups of the same digit.

Note: Each term of the sequence of integers will be represented as a string.

Example 1 : Input: 1 Output: "1"  Explanation: This is the base case. </br>
Example 2 : Input: 4 Output: "1211" </br>
Explanation: For n = 3 the term was "21" in which we have two groups "2" and "1", "2" can be read as "12" which means frequency = 1 and value = 2, the same way "1" is read as "11", so the answer is the concatenation of "12" and "11" which is "1211".

情境分析 : CountandSayInputZero、CountandSayScopeOut、CountandSay

53. Maximum Subarray </br>

Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

Example : Input: [-2,1,-3,4,-1,2,1,-5,4], Output: 6  Explanation: [4,-1,2,1] has the largest sum = 6.
Follow up : If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.

情境分析 : MaximumSubarrayInputNull、MaximumSubarray

58. Length of Last Word </br>

Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word (last word means the last appearing word if we loop from left to right) in the string. If the last word does not exist, return 0.
Note: A word is defined as a maximal substring consisting of non-space characters only.

Example : Input: "Hello World" Output: 5

情境分析 : LenghtOfLastWordInputNull、LenghtOfLastWordNotMapping、LenghtOfLastWord

66. Plus One </br>

Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.

You may assume the integer does not contain any leading zero, except the number 0 itself.

Example 1: Input: [1,2,3] Output: [1,2,4]  Explanation: The array represents the integer 123. </br>
Example 2: Input: [4,3,2,1] Output: [4,3,2,2]  Explanation: The array represents the integer 4321. </br>

情境分析 : 
