// Linked List class

package LinkedListExample;

public class LinkedList {
	
	private Node head = null; // we do not want the user to manually change this
	private Node tail = null;
	private int size = 0;
	
	public LinkedList () { 
		// default constructor
	}
	
	// add item to linked list (default to the end)
	public void add(String s) { // user needs to pass a String to add
		Node n = new Node();
		n.next = null;
		n.word = s;
		if (head == null) { // head is null
			// new node is the head and the tail
			head = n;
			tail = n;
		}
		else { // we already have a head and other items in the linked list
			// add to the end of the linked list (tail)
			tail.next = n;
			tail = n;
		}
		size++;
	}
	
	// delete item from linked list (default delete from end)
	public String delete() { // we delete item and return string stored to user
		if (tail == null) {
			return null;
		}
		else {
			String temp = tail.word;
			// now we need to delete the tail node
			if (size == 1) { // set both head and tail to null
				head = null;
				tail = null;
			}
			else {
				// we know the size of the linked list, index of tail will be size - 1
				// use a for loop to get the node before the tail
				Node currentNode = head; // start at the head
				for (int i = 0; i < size - 2; i++) { // we want to get current node to the one before tail
					currentNode = currentNode.next;
				}
				currentNode.next = null;
				tail = currentNode;
			}
			size--;
			return temp;
		}
	}
	
	// print function 
	public void print() {
		Node currentNode = head; 
		while (currentNode != null) {
			System.out.println(currentNode.word);
			currentNode = currentNode.next;
		}
	}
	
	public Node getHead() { // method to get head node
		return head;
	}
	
	public Node getTail() { // method to get tail node
		return tail;
	}
	
	public int getSize() { // method to get size
		return size;
	}
	
}
