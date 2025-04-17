import java.util.*;
import java.io.*;

public class ConsoleApp {

    private Port port;
    private Scanner scanner;

    public ConsoleApp() {
        port = new Port();
        scanner = new Scanner(System.in);
        fillWithData();
        //populatePortWithRandomData();
    }

    private void fillWithData()
    {
        try {
            Random random = new Random();
            ArrayList<Ship> ships=Ship.loadFromFile("ships.txt");
            ArrayList<Company> companies=Company.loadFromFile("Companies.txt");
            for (Company i : companies) {
                for (int j = 0; j < 25; j++) { // Each company gets 25 random ships

                        i.addShip(ships.get(random.nextInt(500)));

                }
                port.addCompany(i);
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    private void populatePortWithRandomData() {
        Random random = new Random();
        String[] companyNames = {"Alpha Shipping", "Beta Marine", "Gamma Transport", "Delta Cargo", "Epsilon Lines",
                "Zeta Vessels", "Eta Seaways", "Theta Freight", "Iota Carriers", "Kappa Ships",
                "Lambda Cargo", "Mu Logistics", "Nu Transit", "Xi Maritime", "Omicron Transport",
                "Pi Shippers", "Rho Vessels", "Sigma Lines", "Tau Maritime", "Upsilon Freight"};
        String[] subjectsOfActivity = {"Cargo Transfer", "Passenger Transport", "Freight Logistics", "Maritime Services", "Oil Transport"};
        String[] countries = {"Bulgaria", "Germany", "France", "Italy", "Spain", "Netherlands", "Greece", "Sweden", "Norway", "Denmark"};
        String[] shipTypes = {"Passenger", "Cargo", "Liner"};

        for (String companyName : companyNames) {
            String activity = subjectsOfActivity[random.nextInt(subjectsOfActivity.length)];
            double income = 100000 + random.nextDouble() * 900000; // Random income between 100,000 and 1,000,000
            Company company = new Company(companyName, activity, income);
            for (int i = 0; i < 25; i++) { // Each company gets 25 random ships
                String shipName = "Ship-" + random.nextInt(1000);
                String country = countries[random.nextInt(countries.length)];
                String dateOfLaunch = (random.nextInt(((2024 - 1960) + 1) + 1960)) + "-01-01"; // Random year from 1960 to 2024
                String type = shipTypes[random.nextInt(shipTypes.length)];
                company.addShip(new Ship(shipName, country, dateOfLaunch, type));
            }
            port.addCompany(company);
        }
    }

    public void start() {
        while (true) {
            System.out.println("\nChoose an option:");
            System.out.println("1. List All Companies");
            System.out.println("2. Sort Companies by Income");
            System.out.println("3. Filter Companies by Activity");
            System.out.println("4. Companies with Old Ships");
            System.out.println("5. Company with Highest Income");
            System.out.println("6. Companies with Liners Before a Given Date");
            System.out.println("7. Save to File");
            System.out.println("8. Load from File");
            System.out.println("9. Exit");
            System.out.println("10. Ship Count by Age for Each Company");
            System.out.println("Choose ONE: ");
            int choice = Integer.parseInt(scanner.nextLine());

            switch (choice) {
                case 1 -> listAllCompanies();
                case 2 -> sortCompaniesByIncome();
                case 3 -> filterCompaniesByActivity();
                case 4 -> companiesWithOldShips();
                case 5 -> companyWithHighestIncome();
                case 6 -> companiesWithLinersBeforeDate();
                case 7 -> saveToFile();
                case 8 -> loadFromFile();
                case 9 -> {
                    System.out.println("Exiting...");
                    return;
                }
                case 10 -> shipCountByAge();
                default -> System.out.println("Invalid option. Please try again.");
            }
        }
    }

    private void listAllCompanies() {
        System.out.println("\nAll Companies:");
        System.out.println(port.toString());

        //port.getCompaniesByActivity("").forEach(System.out::println);
    }

    private void sortCompaniesByIncome() {
        System.out.println("\nSorted Companies by Income:");
        port.sortCompaniesByIncome().forEach(System.out::println);
    }

    private void filterCompaniesByActivity() {
        System.out.print("Enter Activity to Filter: ");
        String activity = scanner.nextLine();
        System.out.println("\nFiltered Companies:");
        port.getCompaniesByActivity(activity).forEach(System.out::println);
    }

    private void companiesWithOldShips() {
        System.out.print("Enter Age to Filter Companies by Old Ships: ");
        int age = Integer.parseInt(scanner.nextLine());
        System.out.println("\nCompanies with Ships Older than " + age + ":");
        port.getCompaniesWithOldShips(age).forEach(System.out::println);
    }

    private void companyWithHighestIncome() {
        Company company = port.getCompanyWithHighestIncome();
        if (company != null) {
            System.out.println("\nCompany with the Highest Income:");
            System.out.println(company);
        } else {
            System.out.println("No companies available.");
        }
    }

    private void companiesWithLinersBeforeDate() {
        System.out.print("Enter Date (dd-MM-yyyy): ");
        String date = scanner.nextLine();
        List<Company> companies = port.getCompaniesWithLinersBeforeDate(date);
        if (!companies.isEmpty()) {
            System.out.println("\nCompanies with Liners Before " + date + ":");
            companies.forEach(System.out::println);
        } else {
            System.out.println("No companies found with liners before the specified date.");
        }
    }

    private void shipCountByAge() {
        System.out.print("Enter Age of Ships to Filter: ");
        int age = Integer.parseInt(scanner.nextLine());
        Map<String, Integer> result = port.getShipCountByAge(age);

        System.out.println("\nShip Count by Age for Each Company (Older than " + age + " years):");
        result.forEach((company, count) ->
                System.out.println("Company: " + company + ", Ships: " + count));
    }


    private void saveToFile() {
        System.out.print("Enter filename to save: ");
        String filename = scanner.nextLine();
        port.saveToFile(filename);
        System.out.println("Data saved to file: " + filename);
    }

    private void loadFromFile() {
        populatePortWithRandomData();
    }

    public static void main(String[] args) {
        ConsoleApp app = new ConsoleApp();
        app.start();
    }
}