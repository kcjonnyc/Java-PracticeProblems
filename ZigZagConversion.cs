public class Solution {
    // Converts string into a zigzag pattern and concatenates
    // the rows of the zigzag pattern together
    public string Convert(string s, int numRows) {
        // When we have three rows, we add to 1 2 3
        // then we add to 2 and back up to 1
        // The numRows specifies how many rows of letters we need
        // EDGE CASE - numRows is 1
        if (numRows == 1) {
            return s;
        }

        string[] rowsOfStrings = new string[numRows];
        // We need to initialize the array of strings
        for (int row = 0; row < numRows; row++) {
            rowsOfStrings[row] = string.Empty;
        }

        int rowTracker = 0;
        bool movingDown = true;
        // We only need one pass through the characters of s
        // This algorithm has a running time of O(n)
        for (int index = 0; index < s.Length; index++) {
            rowsOfStrings[rowTracker] += s[index];
            if (movingDown) {
                rowTracker++;
            }
            else {
                rowTracker--;
            }

            if (rowTracker == numRows - 1 || rowTracker == 0) {
                movingDown = !movingDown;
            }
        }

        // Concatenate strings
        string result = string.Empty;
        foreach (string str in rowsOfStrings) {
            result += str;
        }

        return result;
    }
}
