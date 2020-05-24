# LeetCode-Algorithm
26. Remove Duplicates from Sorted Array </br>

Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Example 1 : Given nums = [1,1,2],
Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
It doesn't matter what you leave beyond the returned length.

Example 2 : Given nums = [0,0,1,1,1,2,2,3,3,4],
Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.
It doesn't matter what values are set beyond the returned length.

Clarification:
Confused why the returned value is an integer but your answer is an array?
Note that the input array is passed in by reference, which means modification to the input array will be known to the caller as well.
Internally you can think of this:

// nums is passed in by reference. (i.e., without making a copy)
int len = removeDuplicates(nums);

// any modification to nums in your function would be known by the caller.
// using the length returned by your function, it prints the first len elements.
for (int i = 0; i < len; i++) {
    print(nums[i]);
}

情境分析 : RemoveDuplicatesfromSortedArrayInputNull、RemoveDuplicatesfromSortedArray

27. Remove Element </br>

Given an array nums and a value val, remove all instances of that value in-place and return the new length.
Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
The order of elements can be changed. It doesn't matter what you leave beyond the new length.

Example 1 : Given nums = [3,2,2,3], val = 3, Your function should return length = 2, with the first two elements of nums being 2.
It doesn't matter what you leave beyond the returned length.

Example 2 : Given nums = [0,1,2,2,3,0,4,2], val = 2, Your function should return length = 5, with the first five elements of nums containing 0, 1, 3, 0, and 4. Note that the order of those five elements can be arbitrary.
It doesn't matter what values are set beyond the returned length.

Clarification:
Confused why the returned value is an integer but your answer is an array?
Note that the input array is passed in by reference, which means modification to the input array will be known to the caller as well.
Internally you can think of this:

// nums is passed in by reference. (i.e., without making a copy)
int len = removeElement(nums, val);

// any modification to nums in your function would be known by the caller.
// using the length returned by your function, it prints the first len elements.
for (int i = 0; i < len; i++) {
    print(nums[i]);
}

情境分析 : RemoveElementInputArrayNull、RemoveElementInputRemoveNull、RemoveElement

28. Implement strStr() </br>

Implement strStr().

Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1 : Input: haystack = "hello", needle = "ll" Output: 2 </br>
Example 2 : Input: haystack = "aaaaa", needle = "bba" Output: -1 </br>

Clarification:
What should we return when needle is an empty string? This is a great question to ask during an interview.
For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().

情境分析 : ImplementstrStrInputNull、ImplementstrStrFindNull、ImplementstrStrSameNull、ImplementstrStr

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

情境分析 : 
