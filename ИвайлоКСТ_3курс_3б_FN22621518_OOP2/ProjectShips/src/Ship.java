import java.io.*;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;
import java.util.Set;

public class Ship implements FileWork {
    private String name;
    private String country;
    private String dateOfLaunch;
    private String type; // Passenger, Cargo, or Liner
    public Ship(){
        this.name="";
        this.country="";
        this.dateOfLaunch="";
        this.type="";
    }
    public Ship(String name, String country, String dateOfLaunch, String type) {
        this.name = name;
        this.country = country;
        this.dateOfLaunch = dateOfLaunch;
        this.type = type;
    }
    public Ship(Ship other) {
        this.name = other.name;
        this.country = other.country;
        this.dateOfLaunch = other.dateOfLaunch;
        this.type = other.type;
    }
    public String getType() {
        return type;
    }
    public void setType(String type) {
        this.type = type;
    }
    public String getDateOfLaunch() {
        return dateOfLaunch;
    }
    public void setDateOfLaunch(String dateOfLaunch) {
        this.dateOfLaunch = dateOfLaunch;
    }
    public String getCountry() {
        return country;
    }
    public void setCountry(String country) {
        this.country = country;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }

    @Override
    public void saveToFile(String filename) throws IOException {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(filename, true))) {
            writer.write("\tName: " + name + " Country: " + country + "\n" +
                    "\tDate Of Launch: " + dateOfLaunch + " Type: " + type + "\n");
            writer.newLine();
        }
    }

    static public ArrayList<Ship> loadFromFile(String filename) throws IOException {
        ArrayList<Ship> input=new ArrayList<>();
        try (BufferedReader reader = new BufferedReader(new FileReader(filename))) {
            String line="";
            while ((line = reader.readLine())!=null){
                if (line != null) {
                    String[] parts = line.split("\\s*\\|\\s*");
                    if (parts.length == 4) {
                        input.add(new Ship(parts[0],parts[1],parts[2],parts[3]));
                    }
                }
            }
        }
        return input;
    }

    @Override
    public String toString() {
        return  "\tName: " + name + " Country: " + country + "\n" +
                "\tDate Of Launch: " + dateOfLaunch + " Type: " + type + "\n";
    }

    public int calculateAge() {
        int currentYear = Calendar.getInstance().get(Calendar.YEAR);
        int launchYear = Integer.parseInt(dateOfLaunch.split("-")[2]);
        return currentYear - launchYear;
    }
    // Static method to count ships under European flags
    public static int countEuropeanShips(List<Ship> ships, Set<String> europeanCountries) {
        int count = 0;
        for (Ship ship : ships) {
            if (europeanCountries.contains(ship.getCountry().toLowerCase())) {
                count++;
            }
        }
        return count;
    }

    public boolean equals(Ship other) {
        return this.name.equalsIgnoreCase(other.name) &&
                this.type.equalsIgnoreCase(other.type);
    }
    public boolean isOlderThan(Ship other) {
        return this.calculateAge() < other.calculateAge();
    }
}
