# gits-tech-test

## Explained  
1. WeightedStrings : This program performs repeated substring searches in a string using a while loop. Each time an identical character is found in a row, its weight is added and stored in a set (HashSet). Next, the program checks the given query. If the query value is contained in the previously calculated set of weights, then the program returns "Yes", otherwise, returns "No". This approach corresponds to the given rule, where the program must calculate all possible weights of consecutive substrings without using built-in functions for searching or sorting data.
2. BalancedBracket : The time complexity of the above implementation is O(n), where n is the number of characters in the input string. This is because we only traverse the input string once to check each character. For each character, the operations performed on the stack (push and pop) have a complexity of O(1). So, the overall complexity of the code is O(n).
3. HightedStrings : The FindHighestPalindrome function will check whether the input string is already a palindrome. If so, the function will return the string. If not, the function will try to change the characters in the opposite position so that the string becomes a palindrome and reduce the value of k by the number of characters replaced. This process is carried out recursively until the string becomes a palindrome or the k value runs out. If after all the character replacements the string still cannot be a palindrome, the function will return -1.

## Result 
1. WeightedStrings
![result_weighted_strings](https://github.com/radyatamaa/gits-tech-test/blob/dev/result_weighted_strings.png)
2. BalancedBracket
![result_balanced_bracket](https://github.com/radyatamaa/gits-tech-test/blob/dev/result_balanced_bracket.png)
3. HightedStrings
![result_weighted_strings](https://github.com/radyatamaa/gits-tech-test/blob/dev/result_weighted_strings.png)