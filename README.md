## 🚀 CoolMuscle Controller (VB.NET)

This project is a **VB.NET application** for controlling a **CoolMuscle motor** via serial communication. The application allows users to:
✅ Connect & Disconnect the motor  
✅ Move the motor to a specified position  
✅ Stop motion anytime  
✅ Enable/Disable the motor  
✅ Read real-time position updates  

---

### 📌 Features
- **Serial Communication**: Communicates with the motor using `System.IO.Ports`.
- **Position Tracking**: Reads and updates motor position dynamically.
- **User Controls**: Provides buttons for movement, stopping, enabling/disabling, and homing.
- **Graphical UI**: Simple interface for user interaction with position slider control.

---

### 🛠️ Installation
1. Clone this repository:
   ```sh
   git clone https://github.com/Izonetoyou/Control-Cool-Muscle-CM1.git
   cd your-repo
   ```
2. Open the project in **Visual Studio**.
3. Ensure **.NET Framework 4.5** (or later) is installed.
4. Build & run the project.

---

### ⚙️ Usage
- Click **Connect** to establish a serial connection.
- Enter **Position, Speed, and Acceleration**, then click **Move**.
- Click **Stop** to halt movement immediately.
- Click **Enable** or **Disable** to control motor power.
- Use the **slider** to adjust position dynamically.

---

### 📜 Code Overview
#### **Main Functions**
- `OpenPort("COM5", 38400)`: Opens a serial connection.
- `ClosePort()`: Closes the serial connection.
- `PTP(position, speed, acc)`: Moves motor to a target position.
- `StopMotion()`: Stops motor movement.
- `Enable() / Disable()`: Turns the motor on or off.
- `Home()`: Moves motor to its home position.
- `readPosition()`: Reads the current position and updates the label.

---

### 📌 Dependencies
- **VB.NET (.NET Framework 4.5+)**
- **CoolMuscle SDK (if required)**
- **Serial Port Communication Library**

---

### 📞 Contact
👨‍💻 Developed by **Nitikorn T**  
📧 Email: Hilikeclub@gmail.com
🔗 GitHub: [Izonetoyou](https://github.com/Izonetoyou)  

---

🎯 *Feel free to contribute! Fork, submit PRs, or open issues!* 🚀
