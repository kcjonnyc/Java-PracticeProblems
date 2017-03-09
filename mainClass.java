// main class to test linked list

package LinkedListExample;

public class mainClass {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		LinkedList myLinkedList = new LinkedList();
		myLinkedList.add("This");
		myLinkedList.add("is");
		myLinkedList.add("a");
		myLinkedList.add("test");
		
		myLinkedList.print();
		System.out.println("");
		myLinkedList.delete();
		myLinkedList.print();
		System.out.println("");
		myLinkedList.add("test");
		myLinkedList.print();
	}

}
