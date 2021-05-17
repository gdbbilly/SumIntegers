Any set of n integers form n(n − 1)/2 sums by adding every possible pair. Your task is to ﬁnd the n integers given the set of sums.

Input: Each line of input contains n followed by n(n − 1)/2 integer numbers separated by a space, where 2 < n < 10.

Output: For each line of input, output one line containing n integers in non-descending order such that the input numbers are pairwise sums of the n numbers. If there is more than one solution, any one will do. If there is no solution, print “Impossible”. . .

Sample Input:

- 3 1269 1160 1663
- 3 1 1 1
- 5 226 223 225 224 227 229 228 226 225 227
- 5 216 210 204 212 220 214 222 208 216 210
- 5 -1 0 -1 -2 1 0 -1 1 0 -1
- 5 79950 79936 79942 79962 79954 79972 79960 79968 79924 79932

Sample Output:

- 383 777 886
- Impossible
- 111 112 113 114 115
- 101 103 107 109 113
- -1 -1 0 0 1
- 39953 39971 39979 39983 39989
