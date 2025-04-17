import java.util.*;
import java.util.stream.Collectors;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.io.*;

public class Port implements FileWork {
    private ArrayList<Company> companies;

    public Port() {
        this.companies = new ArrayList<>();
    }

    public void addCompany(Company company) {
        companies.add(company);
    }

    // 1. Sort Companies by Income
    public List<Company> sortCompaniesByIncome() {
        return companies.stream()
                .sorted(Comparator.comparingDouble(Company::getIncome))
                .collect(Collectors.toList());
    }

    // 2. Get Companies with Subject of Activity as Cargo Transfer
    public List<Company> getCompaniesByActivity(String activity) {
        return companies.stream()
                .filter(company -> company.getSubjectOfActivity().equalsIgnoreCase(activity))
                .collect(Collectors.toList());
    }

    // 3. Get Companies with Ships Older than a Given Age
    public List<Company> getCompaniesWithOldShips(int shipAge) {
        return companies.stream()
                .filter(company -> company.getShips().stream()
                        .anyMatch(ship -> ship.calculateAge() > shipAge))
                .collect(Collectors.toList());
    }

    // 4. Get the Company with the Highest Income
    public Company getCompanyWithHighestIncome() {
        return companies.stream()
                .max(Comparator.comparingDouble(Company::getIncome))
                .orElse(null);
    }

    // 5. Get Companies with Liners Launched Before a Given Date
    public List<Company> getCompaniesWithLinersBeforeDate(String date) {
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        Date targetDate;
        try {
            targetDate = sdf.parse(date);
        } catch (ParseException e) {
            System.out.println("Invalid date format. Please use dd-MM-yyyy.");
            return Collections.emptyList();
        }

        return companies.stream()
                .filter(company -> company.getShips().stream()
                        .anyMatch(ship -> {
                            try {
                                return ship.getType().equalsIgnoreCase("liner") &&
                                        sdf.parse(ship.getDateOfLaunch()).before(targetDate);
                            } catch (ParseException e) {
                                return false;
                            }
                        }))
                .collect(Collectors.toList());
    }

    @Override
    public void saveToFile(String filename) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(filename))) {
            writer.write(this.toString());
            writer.newLine();
        } catch (IOException e) {
            System.out.println("Error saving to file: " + e.getMessage());
        }
    }


    @Override
    public String toString() {
        String out="";int count=0;
        for(Company y: companies)
        {
                count++;
                out+="Company "+count+"\n";
                out+=y.toString();
        }
        return out;
    }

    public ArrayList<Company> getCompanies() {
        return companies;
    }
    public Map<String, Integer> getShipCountByAge(int age) {
        Map<String, Integer> result = new HashMap<>();
        for (Company company : companies) {
            result.put(company.getName(), company.countShipsByAge(age));
        }
        return result;
    }

}

