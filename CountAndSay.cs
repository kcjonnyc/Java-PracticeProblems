public class Solution {
    // Generates a count and say sequence of integers
    public string CountAndSay(int n) {
        // Base case
        if (n == 1) {
            return "1";
        }

        string sayString = "1";
        // We need the nth count and say sequence
        // We already have the first term so we still need n-1 iterations
        for (int index = 1; index < n; index++) {
            sayString = CountAndSay(sayString);
        }

        return sayString;
    }

    // Helper method is used to convert a string into a count and say sequence
    public string CountAndSay(string countString) {
        string sayString = string.Empty;
        char character = countString[0];
        int consecutiveCharacterCount = 1;
        // Move through countString keeping track of the current character
        // as well as the number of occurances to generate the say sequence
        for (int index = 0; index < countString.Length; index++) {
            if (countString[index] != character) {
                // Build the resultant string
                sayString += consecutiveCharacterCount.ToString() + character;

                // Reset tracking variables
                character = countString[index];
                consecutiveCharacterCount = 1;
            }
            else if (index != 0) {
                consecutiveCharacterCount++;
            }


            if (index == countString.Length - 1) {
                sayString += consecutiveCharacterCount.ToString() + character;
            }
        }

        return sayString;
    }
}
