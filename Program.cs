List<string> notes = new List<string>();
string username = "user";
const string filepath = "notes.txt";
const string namepath = "username.txt";

void loaddata() {
    if (File.Exists(filepath)) {
        notes = new List<string>(File.ReadAllLines(filepath));
    }
    if (File.Exists(namepath)) {
        username = File.ReadAllText(namepath);
    }
}

void savedata() {
    File.WriteAllLines(filepath, notes);
    File.WriteAllText(namepath, username);
}

void setup() {
    Console.Write("Enter your username: ");
    string? newusername = Console.ReadLine();
    if (!string.IsNullOrEmpty(newusername)) {
        username = newusername;
        savedata();
    }
}

void settings() {
    Console.WriteLine("[1] change username");
    Console.WriteLine("[2] delete all notes");
    Console.WriteLine("[3] back to main menu");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            setup();
            break;
        case "2":
            notes.Clear();
            savedata();
            Console.WriteLine("All notes deleted.");
            break;
        default:
            break;
    }
    presskey();
}

void presskey() {
    Console.WriteLine("press any key to continue...");
    Console.ReadLine();
}

bool aretherenotes() {
    return notes.Count > 0;
}

void listnotes() {
    if (!aretherenotes()) {
        Console.WriteLine("No notes found");
        presskey();
        return;
    }

    for (int i = 0; i < notes.Count; i++) {
        Console.WriteLine($"{i + 1}: {notes[i]}");
    }
}

void main() {
    loaddata();
    while (true) {
        Console.WriteLine($"\naquiffoo/notethis - welcome, {username}");
        Console.WriteLine("[1] add note");
        Console.WriteLine("[2] view notes");
        Console.WriteLine("[3] delete notes");
        Console.WriteLine("[4] settings");
        Console.WriteLine("[5] exit");

        string? menu = Console.ReadLine();

        switch (menu) {
            case "1":
                Console.Write("put your memo: ");
                string? note = Console.ReadLine();
                if (!string.IsNullOrEmpty(note)) {
                    notes.Add(note);
                    Console.WriteLine("note added!");
                } 
                else {
                    Console.WriteLine("no note entered!");
                }
                try {Console.Clear();} catch(IOException) {Console.WriteLine("[Console clear unsupported in this environment]");}
                break;
            case "2":
                listnotes();
                break;
            case "3":
                listnotes();
                if (aretherenotes()) {
                    Console.Write("Enter the number of the note to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= notes.Count) {
                        notes.RemoveAt(index - 1);
                        Console.WriteLine($"note {index} deleted");
                    } else Console.WriteLine("invalid id");
                    presskey();
                    try {Console.Clear();} catch(IOException) {Console.WriteLine("[Console clear unsupported in this environment]");}
                    break;
                } else break;
            case "4":
                settings();
                break;
            case "5":
                savedata();
                return;
            default:
                Console.WriteLine("choose something bruh");
                try {Console.Clear();} catch(IOException) {Console.WriteLine("[Console clear unsupported in this environment]");}
                break;
        }
    }
}

main();