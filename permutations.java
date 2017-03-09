// Permutations
// Given a word and the lenght, determine all the possible permutations of the word

// Notes** The following algorithm prints all permutations recursively. However, it does
// not account for permutations that have already occured. If we wanted to only print 
// distinct permutations, we would need to store the different permutations (in some 
// of map) and then check if it has appeared.

public class permutations {
	
	// THOUGHTS
	// lets say we have 5 letters
	// we have 5 choices for the first letter, 4 for the second, etc
	// we need to somehow display every combination of letters
	// start with an array of 5 letters, pick a letter and print it out
	// create an array of 4 letters and repeat the process until we have 1 letter
	// should be solved using recursion
	
	// This method will print out all the permutations of a word through recursion
	public static void printPermutations (char letters[], int length, String word) {
		// this method is passed an array of letters, the length of the array and a word
		// the word will be used to store the current permutation of word
		if (length == 1) { // base case, if length is == 1
			System.out.println(word + letters[0]); // simply print out word and only letter
		}
		if (length == 2) { // base case, if length is == 2
			// two letters can be arranged 2! ways, we print this out at the end with the
			// beginning we have determined
			System.out.println(word + letters[0] + letters[1]);
			System.out.println(word + letters[1] + letters[0]);
		}
		else if (length > 2) { // length is greater than one
			// loop through all the remaining letters creating an new array each time
			for (int i = 0; i < length; i++) {
				String tempWord = word + letters[i]; // add/create permutation of word
				// make a new array without the letter selected
				int count = 0;
				String newString = "";
				do {
					if (count != i) {
						newString += letters[count];
					}
					count++;
				} while (count < length);
				char newLetters[] = newString.toCharArray();
				// recursively call method again with the array of characters that have not been
				// used yet in the new word, length is 1 less while tempWord holds the permutation
				// determined so far
				printPermutations (newLetters, length - 1, tempWord);
			}
		}
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String word = "abcd";
		printPermutations (word.toCharArray(), word.length(), "");
	}

}
