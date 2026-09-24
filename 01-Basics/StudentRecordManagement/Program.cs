class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Gpa { get; set; }
}

class Program
{
    private const string FilePath = "students.csv";
    private static List<Student> students = new List<Student>();

    static void Main() {
        // Load data from file at startup
        students = LoadStudentsFromFile(FilePath);

        bool running = true;
        while (running) {
            Console.WriteLine("\nStudent Management System (File I/O):");
            Console.WriteLine("1. View All Students (Read)");
            Console.WriteLine("2. Add New Student (Create)");
            Console.WriteLine("3. Update Student (Update)");
            Console.WriteLine("4. Delete Student (Delete)");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    ReadStudents();
                    break;
                case "2":
                    CreateStudent();
                    break;
                case "3":
                    UpdateStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose 1 to 5.");
                    break;
            }
        }
    }

    // Create student record
    static void CreateStudent() {
        Console.WriteLine("\n--- Add New Student ---");
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter GPA (0.0 - 4.0): ");
        if (!double.TryParse(Console.ReadLine(), out double gpa) || gpa < 0.0 || gpa > 4.0) {
            Console.WriteLine("Invalid GPA. Value must be between 0.0 and 4.0.");
            return;
        }

        // Determine next ID based on existing records
        int nextId = students.Count > 0 ? students.Max(s => s.Id) + 1 : 1;

        students.Add(new Student { Id = nextId, Name = name.Trim(), Gpa = gpa });
        
        // Save to the file
        SaveStudentsToFile(FilePath, students);
        Console.WriteLine($"Student #{nextId} added and saved successfully!");
    }

    // Read student data
    static void ReadStudents() {
        Console.WriteLine("\n--- Student Records ---");
        if (students.Count == 0) {
            Console.WriteLine("No student records found in file.");
            return;
        }

        Console.WriteLine($"{"ID",-5} | {"Name",-20} | {"GPA",-5}");
        Console.WriteLine(new string('-', 35));

        foreach (var student in students) {
            Console.WriteLine($"{student.Id,-5} | {student.Name,-20} | {student.Gpa,-5:F2}");
        }
    }

    // Update student record
    static void UpdateStudent() {
        Console.WriteLine("\n--- Update Student ---");
        Console.Write("Enter Student ID to update: ");

        if (!int.TryParse(Console.ReadLine(), out int id)) {
            Console.WriteLine("Invalid ID.");
            return;
        }

        var student = students.FirstOrDefault(s => s.Id == id);
        if (student == null) {
            Console.WriteLine($"Student with ID {id} not found.");
            return;
        }

        Console.Write($"Enter new name (leave blank to keep '{student.Name}'): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newName)) {
            student.Name = newName.Trim();
        }

        Console.Write($"Enter new GPA (leave blank to keep '{student.Gpa:F2}'): ");
        string gpaInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(gpaInput)) {
            if (double.TryParse(gpaInput, out double newGpa) && newGpa >= 0.0 && newGpa <= 4.0) {
                student.Gpa = newGpa;
            } else {
                Console.WriteLine("Invalid GPA entered. Keeping existing value.");
            }
        }

        // Save changes
        SaveStudentsToFile(FilePath, students);
        Console.WriteLine("Record updated and saved successfully!");
    }

    // Delete student record
    static void DeleteStudent() {
        Console.WriteLine("\n--- Delete Student ---");
        Console.Write("Enter Student ID to delete: ");

        if (!int.TryParse(Console.ReadLine(), out int id)) {
            Console.WriteLine("Invalid ID.");
            return;
        }

        var student = students.FirstOrDefault(s => s.Id == id);
        if (student == null) {
            Console.WriteLine($"Student with ID {id} not found.");
            return;
        }

        students.Remove(student);

        // Save change
        SaveStudentsToFile(FilePath, students);
        Console.WriteLine($"Student #{id} deleted and changes saved!");
    }

    // File I/O helpers
    private static List<Student> LoadStudentsFromFile(string path) {
        var list = new List<Student>();

        if (!File.Exists(path)) {
            return list;
        }

        using (var reader = new StreamReader(path)) {
            // Skip the header row
            string header = reader.ReadLine();

            while (!reader.EndOfStream) {
                string line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');
                if (parts.Length >= 3 && int.TryParse(parts[0], out int id) && double.TryParse(parts[2], out double gpa)) {
                    list.Add(new Student {
                        Id = id,
                        Name = parts[1].Trim('"'),
                        Gpa = gpa
                    });
                }
            }
        }

        return list;
    }

    private static void SaveStudentsToFile(string path, List<Student> list) {
        using (var writer = new StreamWriter(path, append: false)) {
            // Write CSV header
            writer.WriteLine("Id,Name,Gpa");

            foreach (var s in list) {
                writer.WriteLine($"{s.Id},{s.Name},{s.Gpa}");
            }
        }
    }
}