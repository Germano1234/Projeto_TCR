# Tennis Court Reservation

The **Tennis Court Reservation** software is designed to help tennis academies and court owners efficiently manage court reservations, organize tennis matches, and streamline their operations. With an intuitive interface and robust features, this tool ensures optimal usage of tennis facilities for games, classes, or events.

---

## Features

### 1. **Player/Teacher Management**
- Create and manage detailed player and teacher profiles.

### 2. **Court Availability Management**
- Track which courts are available or occupied in real-time.

### 3. **Match Scheduling**
- Schedule and organize tennis matches effortlessly.

### 4. **Class Management**
- Allocate courts for tennis classes while avoiding conflicts.

### 5. **User-Friendly Interface**
- Intuitive design for seamless navigation and easy usage.

### 6. **Conflict Resolution**
- Automatically checks for scheduling conflicts to prevent double bookings.

### 7. **Agenda View**
- View court usage at a specific time, including details about who is using the court and for what purpose.

---

## Technologies Used

- **C#**
- **.NET Framework**
- **Windows Forms**
- **MySQL**

---

## Getting Started

### Prerequisites

- **Windows OS**
- **.NET Framework** installed
- **MySQL Server**

### Installation Steps

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Germano1234/Projeto_TCR.git
   ```

2. **Set Up the Database:**
   - Import the provided `script.sql` file into your SQL Server to create the necessary database and tables.
   - Update the connection string in the application configuration file to match your SQL Server settings.

3. **Run the Application:**
   - Open the project in Visual Studio.
   - Build and run the application.

---

## Usage

1. **Create Profiles:**
   - Add player and teacher profiles through the management interface.

2. **Schedule Matches and Classes:**
   - Use the scheduling feature to book courts for matches or classes.

3. **View Court Availability:**
   - Check real-time court status using the availability view.

4. **Prevent Conflicts:**
   - The system automatically flags scheduling conflicts to ensure smooth operations.

5. **Review Agenda:**
   - View detailed agendas to understand who is using which courts and for what purpose.

---

## Database Structure

The project uses the following tables in the `AgendaTCR` database:

1. **Agenda**
   - Stores scheduling details, including type, date, time, user, and court information.

2. **Jogo**
   - Records match details, including player IDs and match type.

3. **Professor**
   - Manages teacher details like name, contact information, and level.

4. **Quadra**
   - Tracks court details, including surface type and whether it is covered.

5. **Tenista**
   - Stores player details like name, contact information, and UTR rating.

---

## Future Enhancements

- Integration with mobile platforms for remote booking.
- Notifications for schedule changes or upcoming matches.
- Advanced analytics to optimize court usage.

---

## Contact

For inquiries or support, contact:

- **Germano Correa Silva de Carvalho**
- Email: germanocsc@live.com
- GitHub: [Germano1234](https://github.com/Germano1234)

---

Thank you for using the Tennis Court Reservation software! Enjoy streamlined and conflict-free court management.

