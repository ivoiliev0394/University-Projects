import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.Random;

public class SwingApp {
    private Port port;
    private JFrame frame;
    private JTable table;
    private JTextArea textArea;

    public SwingApp() {
        port = new Port();
        fillWithData();
        initUI();
    }

    private void fillWithData() {
        try {
            Random random = new Random();
            ArrayList<Ship> ships = Ship.loadFromFile("ships.txt");
            ArrayList<Company> companies = Company.loadFromFile("Companies.txt");
            for (Company i : companies) {
                for (int j = 0; j < 25; j++) { // Each company gets 25 random ships
                    i.addShip(ships.get(random.nextInt(ships.size())));
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
    private void initUI() {
        frame = new JFrame("Port Management System");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(800, 600);

        // Main Panel Layout
        JPanel panel = new JPanel(new BorderLayout());
        panel.setBackground(new Color(0, 128, 0)); // Set panel background to green

        // Buttons
        JPanel buttonPanel = new JPanel(new GridLayout(4, 3));
        buttonPanel.setBackground(new Color(0, 128, 0)); // Set button panel background to green

        JButton listCompaniesBtn = new JButton("List All Companies");
        JButton sortCompaniesBtn = new JButton("Sort Companies by Income");
        JButton filterCompaniesBtn = new JButton("Filter Companies by Activity");
        JButton oldShipsBtn = new JButton("Companies with Old Ships");
        JButton highestIncomeBtn = new JButton("Company with Highest Income");
        JButton linersBeforeDateBtn = new JButton("Liners Before Date");
        JButton saveToFileBtn = new JButton("Save to File");
        JButton loadFromFileBtn = new JButton("Load from File");
        JButton shipCountBtn = new JButton("Ship Count by Age");
        JButton portToStringBtn = new JButton("Port Overview");

        buttonPanel.add(listCompaniesBtn);
        buttonPanel.add(sortCompaniesBtn);
        buttonPanel.add(filterCompaniesBtn);
        buttonPanel.add(oldShipsBtn);
        buttonPanel.add(highestIncomeBtn);
        buttonPanel.add(linersBeforeDateBtn);
        buttonPanel.add(saveToFileBtn);
        buttonPanel.add(loadFromFileBtn);
        buttonPanel.add(shipCountBtn);
        buttonPanel.add(portToStringBtn);

        // Table and Text Area
        table = new JTable();
        JScrollPane tableScrollPane = new JScrollPane(table);
        textArea = new JTextArea(5, 40);
        JScrollPane textScrollPane = new JScrollPane(textArea);
        textScrollPane.setPreferredSize(new Dimension(800, 200)); // Задайте желаната широчина и височина

        // Add to Panel
        panel.add(buttonPanel, BorderLayout.NORTH);
        panel.add(tableScrollPane, BorderLayout.CENTER);
        panel.add(textScrollPane, BorderLayout.SOUTH);


        frame.add(panel);

        // Add Action Listeners
        listCompaniesBtn.addActionListener(e -> listAllCompanies());
        sortCompaniesBtn.addActionListener(e -> sortCompaniesByIncome());
        filterCompaniesBtn.addActionListener(e -> filterCompaniesByActivity());
        oldShipsBtn.addActionListener(e -> companiesWithOldShips());
        highestIncomeBtn.addActionListener(e -> companyWithHighestIncome());
        linersBeforeDateBtn.addActionListener(e -> companiesWithLinersBeforeDate());
        saveToFileBtn.addActionListener(e -> saveToFile());
        loadFromFileBtn.addActionListener(e -> loadFromFile());
        shipCountBtn.addActionListener(e -> shipCountByAge());
        portToStringBtn.addActionListener(e -> showPortOverview());

        frame.setVisible(true);
    }

    private void listAllCompanies() {
        updateTable(port.getCompanies(), "List of All Companies");
    }

    private void sortCompaniesByIncome() {
        updateTable(port.sortCompaniesByIncome(), "Sorted Companies by Income");
    }

    private void filterCompaniesByActivity() {
        String activity = JOptionPane.showInputDialog(frame, "Enter Activity to Filter:");
        updateTable(port.getCompaniesByActivity(activity), "Filtered Companies by Activity: " + activity);
    }

    private void companiesWithOldShips() {
        String ageInput = JOptionPane.showInputDialog(frame, "Enter Age to Filter Old Ships:");
        int age = Integer.parseInt(ageInput);
        updateTable(port.getCompaniesWithOldShips(age), "Companies with Ships Older than " + age);
    }

    private void companyWithHighestIncome() {
        Company company = port.getCompanyWithHighestIncome();
        textArea.setText("Company with the Highest Income:\n" + company);
    }

    private void companiesWithLinersBeforeDate() {
        String date = JOptionPane.showInputDialog(frame, "Enter Date (yyyy-MM-dd):");
        updateTable(port.getCompaniesWithLinersBeforeDate(date), "Companies with Liners Before " + date);
    }

    private void shipCountByAge() {
        String ageInput = JOptionPane.showInputDialog(frame, "Enter Age of Ships:");
        int age = Integer.parseInt(ageInput);
        Map<String, Integer> shipCounts = port.getShipCountByAge(age);
        StringBuilder result = new StringBuilder("Ship Count by Age:\n");
        shipCounts.forEach((company, count) -> result.append("Company: ").append(company).append(", Ships: ").append(count).append("\n"));
        textArea.setText(result.toString());
    }

    private void saveToFile() {
        String filename = JOptionPane.showInputDialog(frame, "Enter filename to save:");
        port.saveToFile(filename);
        JOptionPane.showMessageDialog(frame, "Data saved to file: " + filename);
    }

    private void loadFromFile() {
        populatePortWithRandomData();
        JOptionPane.showMessageDialog(frame, "Random Data Loaded Successfully!");
    }

    private void showPortOverview() {
        textArea.setText(port.toString());
    }

    private void updateTable(List<Company> companies, String title) {
        String[] columnNames = {"Name", "Activity", "Income"};
        DefaultTableModel model = new DefaultTableModel(columnNames, 0);

        for (Company company : companies) {
            model.addRow(new Object[]{company.getName(), company.getSubjectOfActivity(), company.getIncome()});
        }
        table.setModel(model);
        textArea.setText(title);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(SwingApp::new);
    }
}

