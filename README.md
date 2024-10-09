# notethis

notethis is a simple console application written in C# that allows users to store and manage notes. It supports persistent storage to retain notes and user settings across sessions. It's just a c# project (and no, i'm not making a course)

## Features
- Add new notes.
- View existing notes.
- Delete individual notes.
- Change username.
- Delete all notes.
- Persistent storage of notes and username.

## Requirements
- .NET Core SDK

## Usage
1. **Clone the repository:**
    ```bash
    git clone <repository-url>
    cd notethis
    ```

2. **Build and run the application:**
    ```bash
    dotnet run
    ```

3. **Menu Options:**
    - `[1] add note` - Prompt to input a note.
    - `[2] view notes` - Displays the list of all saved notes.
    - `[3] delete notes` - Displays the list of notes for deletion and prompts for the note number to delete.
    - `[4] settings` - Change username or delete all notes.
    - `[5] exit` - Save changes and exit the application.

## File Storage
- **notes.txt**: This file stores all the notes.
- **username.txt**: This file stores the username.

Both files are created in the root directory of the project and are accessed when the application starts or exits.

## Credits
- Developed using C# by aquiffoo, a learning developer in the language.

## License
This project is licensed under the AGPL v2 License. See the [LICENSE](LICENSE) file for more details.
