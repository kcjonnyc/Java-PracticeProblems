// File search algorithm
// Given a file and a directory, we transverse through the file system looking for the file

// Notes* although this algorithm works, it is not the most efficient as it does not check the
// current directory for the file first. It immediately starts moving deeper into the file system
// once it sees a directory instead of a file (this should be changed)

import java.io.File;

public class fileSearch {

	// TOUGHTS
	// If we are in one directory, we need to see if a file is in the directory
	// and then look at other folders/sub-directories
	// This seems like a problem that should be solved with recursion
	
	static File foundFile = null;
	
	public static void search(String name, File file) { // assume we start with a file name and a file directory
		// first list out all the files in the directory (this includes files and folders)
		File[] files = file.listFiles();
		// check if the file exists in the current directory, if yes, we are done
		for (File f : files) { // for each file in files
			if (f.isDirectory() == false) { // if the file is not a directory
				if (name.equalsIgnoreCase(f.getName())) {
					foundFile = f;
				}
			}
			else { // file is a directory
				// we are now searching in the sub-directory
				System.out.println(f.getName());
				search (name, f);
			}
		}
	}
	
	public static void main(String args[]) {
		File dir = new File("C:\\Users\\KCJon\\OneDrive");
		search("Job Search.docx", dir);
		if (foundFile != null)
			System.out.println(foundFile.getName());
		else
			System.out.println("Could not find file");
	}
	
}
