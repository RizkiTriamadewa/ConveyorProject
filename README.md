# 🏗️ VR Industrial HSE Simulation: "PT. Industrial Manufacturing"

<img width="1155" height="652" alt="image" src="https://github.com/user-attachments/assets/44c66eb6-9a68-4561-a04b-e2bab77aef65" />
*A look inside the detailed industrial facility within the VR simulation.*

## 📖 About The Project
This project is an immersive Virtual Reality (VR) application developed for the **Meta Quest** platform using **Unity**. It is a **Health, Safety, and Environment (HSE)** training simulation designed to teach workers proper safety protocols within a complex factory environment, specifically modeled for **PT. Industrial Manufacturing**.

The simulation takes a gamified, step-by-step approach to enforce real-world industrial safety procedures, from initial gear acquisition to navigating hazardous zones.

### ✨ Key Features
<img width="1148" height="643" alt="image" src="https://github.com/user-attachments/assets/1328d206-3a3b-4446-a464-29d54e35a732" />

* **Meta Quest VR Integration:** Built with the **XR Interaction Toolkit** for native Meta Quest support, offering intuitive interactions.
* **Procedural Workflows:** Guides users through a strictly enforced set of safety steps.
* **Interactive Environments:** Features detailed 3D models of factory machinery and safety zones.
* **Object Transformation Logic:** Simulates a bottle-to-package production line on a conveyor belt.
* **Contextual Information:** Displays machine-specific information (e.g., CNC, Drill, Milling) upon close approach.
* **Currency Simulation:** Includes a closed-loop system for creating and exchanging 'safety coins'.

---

## 🚀 Simulation Workflow (The HSE Journey)

The training follows a strict, required sequence of actions that the player must complete.

<img width="1154" height="648" alt="image" src="https://github.com/user-attachments/assets/fffd1586-378f-4d88-a896-90203dc24115" />

*The simulation begins outside the facility. Note the company sign and the safety zone markings.*

1.  **Welcome & Entry:** The simulation starts with the player outside the "PT. Industrial Manufacturing" facility (as seen in image 2). The player navigates into the main lobby area.

2.  **Safety Gear Acquisition (Coin Exchange):** The player locates a designated HSE kiosk/loket. To obtain a safety helmet, they must first possess a specific simulation coin. The player approaches the kiosk and initiates an exchange, using the coin as the currency to acquire the helmet.

3.  **HSE Equipment Check:** Upon successful exchange, the safety helmet model appears. The user must pick up the helmet and physically place it onto their head (or virtual character's head) to equip it. The simulation verifies the gear is correctly worn.

4.  **Factory Access:** Only *after* the safety helmet is successfully equipped is the barrier to the main factory floor (as seen in image 1) lifted, allowing access.

5.  **Navigating the Factory (Green Lanes):** Once inside the detailed facility, the player is instructed to navigate only along marked **Green Safety Lanes** (visible in image 1) to avoid hazardous machinery and workflows.

6.  **Recycling Workflow (Transformation):** The player must identify and pick up loose plastic bottles scattered in designated areas. They carry these bottles and place them onto the beginning of the automated conveyor belt system.

7.  **Bottle to Package Transformation:** When a bottle is placed on the conveyor and moves down the line, it is automatically processed and transformed, with the output being a completed cardboard **'package'**, which the player can then pick up and place in a finished goods area.

8.  **Contextual Machine Info:** As the player walks through the factory, they can approach various large machines (like the CNC, Drill Press, or Milling machine). Closer proximity triggers an informative overlay displaying the specific name and safe operation details for that asset.

9.  **Simulation Loop (Coin Creation):** To support the exchange at the beginning, a separate machine simulation is available further into the factory. This area simulates the process required to *create* the very safety coins the player used to get their helmet, completing the resource loop for new personnel.

---

## 🛠️ Built With

* **Game Engine:** Unity 2022.3.8f1
* **Target Platforms:** Meta Quest
* **Input/Interactions:** Unity XR Interaction Toolkit
* **Modeling:** Blender, Sketchfab
* **Version Control:** GitHub

---

## 💻 Getting Started

This repository contains the full Unity project source.

**1. Prerequisites:**
* Unity Hub and Unity Editor version **2022.3.8f1**.
* Meta Quest Link software (if building/testing from PC).
* A Meta Quest headset for deployment.

**2. Installation:**
1.  Clone the repository:
    ```bash
    git clone [https://github.com/your-username/your-repository-name.git](https://github.com/your-username/your-repository-name.git)
    ```
2.  Add and Open the project in Unity Hub.
3.  Ensure the **Android** build platform is selected in Unity.
4.  Navigate to the `Build Settings` to verify the main scene is included in the build.

**3. Running the Simulation:**
* **From PC (Quest Link):** Enter 'Play' mode in the Unity Editor with your Quest connected via Link. The simulation will use the XR Device Simulator or the headset if properly configured.
* **Native Build (Sideload):** Go to `File > Build and Run` in Unity. Unity will compile the APK and sideload it directly to your connected Meta Quest headset (requires Developer Mode on the Quest).

---

## 📸 Project Showcase

### Detailed Factory Interior
<img width="1143" height="649" alt="image" src="https://github.com/user-attachments/assets/bc05534c-eb79-435c-83aa-7f4ec4007497" />

*A panoramic view showing the complex 3D modeling of the factory environment.*

### Company Identity & Entry
<img width="800" height="450" alt="image" src="https://github.com/user-attachments/assets/04f78eb3-5569-43b5-9fa0-80e7c93bd39b" />

*The exterior view showing the PT. Industrial Manufacturing branding and initial HSE zone.*

---

## 👤 Author
**Rizki & Team
