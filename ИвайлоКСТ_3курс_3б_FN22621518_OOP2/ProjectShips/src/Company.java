import java.io.*;
import java.util.ArrayList;

public class Company implements FileWork {
    private String name;
    private String subjectOfActivity;
    private double income;
    private ArrayList<Ship> ships;

    public Company() {
        this.name = "";
        this.subjectOfActivity = "";
        this.income = 0;
    }
    public Company(String name, String subjectOfActivity, double income) {
        this.name = name;
        this.subjectOfActivity = subjectOfActivity;
        this.income = income;
        this.ships = new ArrayList<>();
    }

    public void addShip(Ship ship) {
        ships.add(ship);
    }

    public ArrayList<Ship> getShips() {
        return ships;
    }
   public void setShips(ArrayList<Ship> sh) {
       this.ships=sh;
   }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public String getSubjectOfActivity() {
        return subjectOfActivity;
    }
    public void setSubjectOfActivity(String subjectOfActivity) {
        this.subjectOfActivity = subjectOfActivity;
    }
    public double getIncome() {
        return income;
    }
    public void setIncome(double income) {
        this.income = income;
    }

    public int countShipsByAge(int age) {
        return (int) ships.stream().filter(ship -> ship.calculateAge() > age).count();
    }

    @Override
    public void saveToFile(String filename) throws IOException {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(filename))) {
            String help="";
            int count=0;
            for(Ship i : ships)
            {
                count++;
                help+="  Ship "+count+"\n";
                help+=i.toString();

            };
            writer.write("Name: " + name + " Subject Of Activity: " + subjectOfActivity +  " Income: " + income
                    +"\n"+help+"\n");
            writer.newLine();
        }
    }

    static public ArrayList<Company> loadFromFile(String filename) throws IOException {
        ArrayList<Company> out=new ArrayList<>();
        try (BufferedReader reader = new BufferedReader(new FileReader(filename))) {
            String line="";
            while ((line = reader.readLine())!=null) {
                if (line != null) {
                    String[] parts = line.split(", ");
                    out.add(new Company(parts[0], parts[1], Double.parseDouble(parts[2])));
                }
            }
        }
        return out;
    }
    @Override
    public String toString() {
        String help="";
        int count=0;
        for(Ship i : ships)
        {
            count++;
            help+="  Ship "+count+"\n";
            help+=i.toString();

        };
        return "Name: " + name + " Subject Of Activity: " + subjectOfActivity +  " Income: " + income
                +"\n"+help+"\n";

    }
}
