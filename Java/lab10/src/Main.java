import java.util.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
/*
1.Interfaces
List-елементи с повторение
Set-уникални елементи без повторение
Map=Dictionary
Queue
Deque
SortedSet

2.Classes
ArrayList
Vector
Stack
LinkedList
HashSet
LinkedHashSet
HashMap
TreeMap
SortedMap
* */
public class Main
{
    public static void main(String[] arg)
    {
        /*
        List<String> list =new ArrayList<String>();
        list.add("Hello");
        list.add("World");
        list.add("from");
        list.add("Java");
        System.out.println(list);
        list.remove(1);//връща елем. който се маха
        System.out.println(list);
        for (int i = 0; i < list.size(); i++) {
            System.out.println(list.get(i));
        }
        Iterator<String>iter= list.iterator();//samo v edna posoka
        while (iter.hasNext())
        {
            System.out.println(iter.next());
        }
        ListIterator<String> listIterator=list.listIterator();//v dvete posoki
        while (listIterator.hasNext())
        {
            listIterator.next();
        }
        while (listIterator.hasPrevious())
        {
            System.out.println(listIterator.previous());
        }*/
        /*
        List<String> list = new ArrayList<>();
        list.add("Hello");
        list.add("World");
        list.add("from");
        list.add("Java");
        System.out.println(list);
        list.remove(1);

        System.out.println(list);
        for (int i = 0; i < list.size(); i++)
            System.out.println(list.get(i));

        Iterator<String> iter = list.iterator();
        while (iter.hasNext())
            System.out.println(iter.next());

        ListIterator<String> listIter = list.listIterator();
        while (listIter.hasNext())
            System.out.println(listIter.next());
        while (listIter.hasPrevious())
            System.out.println(listIter.previous());

        ArrayList<String> arrList = new ArrayList<>();
        arrList.add("Object");
        arrList.add("Oriented");
        arrList.add("Programming");

        for (int i = 0; i < arrList.size(); i++)
            System.out.println(arrList.get(i));
        System.out.println("Is Oriented in the arraylist? " + arrList.contains("Oriented"));

        HashSet<String> set = new HashSet();
        set.add("One");
        set.add("Two");
        set.add("Three");
        set.add("Four");
        set.add("Five");

        Iterator<String> it = set.iterator();
        while(it.hasNext())
            System.out.println(it.next());
         */
        Scanner scanner = new Scanner(System.in);
        StringCollection collection = new StringCollection();

        int choice = 0;
        while (choice != 5) {
            System.out.println("1. Add element");
            System.out.println("2. Add elements");
            System.out.println("3. Search element");
            System.out.println("4. Print elements");
            System.out.println("5. Exit");
            System.out.print("Enter your choice: ");

            // Защита при въвеждане на избора
            while (!scanner.hasNextInt()) {
                System.out.println("Invalid input. Please enter a number.");
                scanner.next();
            }
            choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    System.out.print("Enter element to add: ");
                    String element = scanner.next();
                    collection.addElement(element);
                    break;
                case 2:
                    System.out.print("Enter number of elements to add: ");
                    int numElements = scanner.nextInt();
                    List<String> newElements = new ArrayList<>();
                    for (int i = 0; i < numElements; i++) {
                        System.out.print("Enter element " + (i + 1) + ": ");
                        newElements.add(scanner.next());
                    }
                    collection.addElements(newElements);
                    break;
                case 3:
                    System.out.print("Enter element to search: ");
                    String searchElement = scanner.next();
                    int position = collection.searchElement(searchElement);
                    if (position != -1) {
                        System.out.println("Element found at position: " + position);
                    } else {
                        System.out.println("Element not found in the collection.");
                    }
                    break;
                case 4:
                    collection.printElements();
                    break;
                case 5:
                    System.out.println("Exiting program...");
                    break;
                default:
                    System.out.println("Invalid choice. Please enter a number between 1 and 5.");
            }
        }
        scanner.close();
    }
}