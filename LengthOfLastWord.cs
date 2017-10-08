public class Solution {
    // Determines the length of the last word in a string
    public int LengthOfLastWord(string s) {
        // Consider if we need to check for s == null
        // Start at the last character in the string
        int lastIndex = s.Length - 1;
        while (lastIndex >= 0 && s[lastIndex] == ' ') {
            // Move until we do not have whitespace
            lastIndex--;
        }

        // lastIndex will now be at the first location without whitespace (from end)
        int startIndex = lastIndex;
        while (startIndex >= 0 && s[startIndex] != ' ') {
            // Move through non whitespace
            startIndex--;
        }

        // startIndex is at the position one before the last word
        return lastIndex - startIndex;
    }
}
