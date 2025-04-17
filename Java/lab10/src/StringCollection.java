import java.util.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
public class StringCollection {
    private List<String> elements;

    public StringCollection() {
        elements = new ArrayList<>();
    }

    public void addElement(String element) {
        elements.add(element);
        System.out.println("Element added successfully.");
    }

    public void addElements(List<String> newElements) {
        elements.addAll(newElements);
        System.out.println("Elements added successfully.");
    }

    public int searchElement(String element) {
        return elements.indexOf(element);
    }
    public void printElements() {
        System.out.println("Elements in the collection:");
        for (String element : elements) {
            System.out.println(element);
        }
    }
}
