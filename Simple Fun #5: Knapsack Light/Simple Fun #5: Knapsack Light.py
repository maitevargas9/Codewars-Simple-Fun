'''
Description

Task
You found two items in a treasure chest! The first item weighs weight1 and is worth value1, and the second item weighs weight2 
and is worth value2. What is the total maximum value of the items you can take with you, assuming that your max weight capacity 
is maxW/max_w and you can't come back for the items later?

Example
For value1 = 10, weight1 = 5, value2 = 6, weight2 = 4 and maxW = 8, the output should be 10.
You can only carry the first item.
For value1 = 10, weight1 = 5, value2 = 6, weight2 = 4 and maxW = 9, the output should be 16.
You're strong enough to take both of the items with you.
For value1 = 10, weight1 = 10, value2 = 6, weight2 = 10 and maxW = 9, the output should be 0.
Unfortunately, you're not strong enough to take any one :(

Input/Output
Arguments
integer value1
integer weight1
integer value1
integer weight1
integer maxW/max_w
Contraints
2≤valueN≤50
2≤weightN≤30
1≤maxW≤50
Output
integer representing the maximum value of the items that can be carried
'''

def knapsack_light(value1, weight1, value2, weight2, max_w):
    max_value = 0
    
    if weight1 <= max_w:
        max_value = value1
        
    if weight2 <= max_w:
        max_value = max(max_value, value2)
        
    if weight1 + weight2 <= max_w:
        max_value = max(max_value, value1 + value2)

    return max_value