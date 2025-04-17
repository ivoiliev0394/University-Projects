// Java Program to Demonstrate Working of
// Comparator Interface

import java.lang.*;
import java.util.*;


public class Main {
    public static void main(String[] args) {
        ArrayList<Student> ar = new ArrayList<Student>();

        ar.add(new Student(111, "John", "London"));
        ar.add(new Student(119, "Antony", "Athens"));
        ar.add(new Student(131, "Smith", "NYC"));
        ar.add(new Student(121, "Stephan", "Berlin"));
        ar.add(new Student(101, "Andrew", "London"));
        ar.add(new Student(105, "Andrew", "Athens"));

        System.out.println("Unsorted:");

        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));
        SortByRoll sbr = new SortByRoll(true);
        Collections.sort(ar, sbr);

        System.out.println("\nSorted by rollno ascending:");
        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));
        sbr.setOrder(false);
        Collections.sort(ar, sbr);
        System.out.println("\nSorted by rollno descending:");
        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));

        SortByName sbn = new SortByName(true);
        Collections.sort(ar, sbn);

        System.out.println("\nSorted by name:");

        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));
      
        System.out.println("Sort by roll:");
        sbr.setOrder(true);
        Collections.sort(ar, sbr);      
        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));
        int pos = Collections.binarySearch(ar, new Student(105, "Andrew", "Athens"), sbr);
        System.out.println("Index: " + (pos));      
    }
}

class Student {
    private int rollno;
    private String name, address;

    public Student(int rollno, String name, String address) {
        this.rollno = rollno;
        this.name = name;
        this.address = address;
    }
    public int getRollno() {
        return rollno;
    }

    public String getName() {
        return name;
    }

    public String getAddress() {
        return address;
    }

    @Override
    public String toString() {
        return this.rollno + " " + this.name + " " + this.address;
    }
}

class SortByRoll implements Comparator<Student> {

    private boolean ascOrder = true;
    public SortByRoll() {

    }
    public SortByRoll(boolean order) {
        this.ascOrder = order;
    }
    // Sorting in ascending or descending order of roll number
    //ascOrder = true
    //ascOrder = false
    public int compare(Student a, Student b) {
        if (ascOrder) {
            return a.getRollno() - b.getRollno();
        }
        else {
            return b.getRollno() - a.getRollno();
        }
    }

    public void setOrder(boolean order) {
        ascOrder = order;
    }
}


class SortByName implements Comparator<Student> {
    private boolean ascOrder = true;
    public SortByName() {
    }
    public SortByName(boolean order) {
        this.ascOrder = order;
    }
    // Sorting in ascending or descending order of roll number
    //ascOrder = true
    //ascOrder = false
    public int compare(Student a, Student b) {
        if (ascOrder) {
            if (a.getName().compareTo(b.getName()) == 0) {
                if (ascOrder) {
                    return a.getAddress().compareTo(b.getAddress());
                }
                else {
                    return b.getAddress().compareTo(a.getAddress());
                }
            }
            else return a.getName().compareTo(b.getName());
        }
        else {
            if (b.getName().compareTo(a.getName()) == 0) {
                if (ascOrder) {
                    return a.getAddress().compareTo(b.getAddress());
                } else {
                    return b.getAddress().compareTo(a.getAddress());
                }
            }
            else return b.getName().compareTo(a.getName());
        }
    }
}

class SortByAddress implements Comparator<Student> {
    public boolean ascOrder;
    public SortByAddress(boolean order) {
        ascOrder = order;
    }
    public void setOrder(boolean order) {
        ascOrder = order;
    }
    public int compare(Student a, Student b) {
        if (ascOrder)
            return a.getAddress().compareTo(b.getAddress());
        else
            return b.getAddress().compareTo(a.getAddress());
    }
}
