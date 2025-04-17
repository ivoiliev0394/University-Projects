import java.lang.*;
import java.util.*;


public class Main {
    public static void main(String[] args) {
        ArrayList<Student> ar = new ArrayList<Student>();

        ar.add(new Student(111, "John", "London"));
        ar.add(new Student(131, "Smith", "NYC"));
        ar.add(new Student(121, "Stephan", "Berlin"));
        ar.add(new Student(101, "Andrew", "London"));

        System.out.println("Unsorted:");

        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));

        Collections.sort(ar, new SortByRoll());

        System.out.println("\nSorted by rollno:");

        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));

        Collections.sort(ar, new SortByName());

        System.out.println("\nSorted by name:");

        for (int i = 0; i < ar.size(); i++)
            System.out.println(ar.get(i));
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

    public String toString() {
        return this.rollno + " " + this.name + " " + this.address;
    }
}

class SortByRoll implements Comparator<Student> {

    // Sorting in ascending order of roll number
    public int compare(Student a, Student b) {
        return a.getRollno() - b.getRollno();
    }
}

class SortByName implements Comparator<Student> {

    // Sorting in ascending order of name
    public int compare(Student a, Student b) {
        return a.getName().compareTo(b.getName());
    }
}