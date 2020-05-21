# LeetCode-Algorithm
1.Two Sum</br>

Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example: Given nums = [2, 7, 11, 15], target = 9, Because nums[0] + nums[1] = 2 + 7 = 9, return [0, 1].

分析情境 : TwoSumInputNull、TwoSumNotFind、TwoSum

7.Reverse Integer </br>

Given a 32-bit signed integer, reverse digits of an integer.

Example 1: Input: 123 Output: 321 ~ Example 2: Input: -123 Output: -321 ~ Example 3: Input: 120 Output: 21</br>

Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows

分析情境 : ReverseInteger、ReverseIntegerOverPower

9.Palindrome Number </br>

Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

Example 1: Input: 121 Output: true </br>
Example 2: Input: -121 Output: false </br>
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome. </br>

Example 3: Input: 10 Output: false </br>
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.</br>

分析情境 : PalindromeNumber、PalindromeNumberSingleInput

13.Roman to Integer </br>
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

I 1 , V 5 , IV 4 , IX 9 , X 10 , X L 40 , L 50 , X C 90 , C 100 , C D 400 , D 500 , C M 900 , M 1000 
For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

Example 1: Input: "III" Output: 3 Example 2: Input: "IV" Output: 4 Example 3: Input: "IX" Output: 9 </br>
Example 4: Input: "LVIII" Output: 58 Explanation: L = 50, V= 5, III = 3. </br>
Example 5: Input: "MCMXCIV" Output: 1994 Explanation: M = 1000, CM = 900, XC = 90 and IV = 4. </br>

分析情境 : RomantoInteger、RomantoIntegerNotMap

14.Longest Common Prefix </br>

Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".

Example 1: Input: ["flower","flow","flight"] Output: "fl" </br>
Example 2: Input: ["dog","racecar","car"] Output: "" </br>

Explanation: There is no common prefix among the input strings.
Note:All given inputs are in lowercase letters a-z.

分析情境 : LongestCommonPrefixInputNull、LongestCommonPrefixNotCommon、LongestCommonPrefix

20.Valid Parentheses </br>

Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.

Example 1: Input: "()" Output: true  Example 2: Input: "()[]{}" Output: true  Example 3: Input: "(]" Output: false </br>
Example 4: Input: "([)]" Output: false  Example 5: Input: "{[]}" Output: true </br>

分析情境 : ValidParenthesesInputNull、ValidParenthesesInputError、ValidParentheses

21. Merge Two Sorted Lists </br>

Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

Example: Input: 1->2->4, 1->3->4  Output: 1->1->2->3->4->4 </br>

分析情境 : MergeTwoSortedListsInputNull、MergeTwoSortedLists
