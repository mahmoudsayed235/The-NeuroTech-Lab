# 🧪 VR Lab Scenario – Unity VR Prototype

A modular, research-driven VR experience built in Unity to simulate interactive training scenarios in a virtual lab environment.

## 🎯 Project Overview

This prototype was developed as part of a technical task to showcase skills in:

- VR interaction design using Unity & XR Toolkit
- Object manipulation and feedback systems
- Smart assistant onboarding experience
- Scene and session management
- End-to-end planning, execution, and documentation

## 🛠️ Features

- 🧭 **User Navigation**: Joystick-based movement and smooth head tracking
- 🧱 **Object Interaction**: XR Grab Interactables with snapping, validation, and fallback logic
- 🎙️ **Smart Assistant**: Voice-guided onboarding and contextual instructions
- 💾 **Progress Saving**: Session manager for save/load mechanics
- 🎥 **Video Walkthrough**: 2-minute video demo showing key functionality (attached separately)
- 🔁 **Scene Manager**: Utility for switching or restarting scenes

## 🧪 Scenario Example: Shape Matching Task

- User grabs one of several 3D shapes
- Matches it to the correct socket/collider
- If not placed correctly, the shape returns to its original position
- Feedback provided through voice and/or visual cues

## 👓 VR Compatibility

- Developed and tested on **Meta Quest 2**
- Native VR controls used (no keyboard/mouse simulation required)

## 📁 Project Structure (Key Folders)

Assets/
│
├── Scripts/ # Core logic, interactions, manager scripts
├── Scenes/ # Main scene(s) for the lab and onboarding
├── AudioClips/ # Smart assistant voice lines
└── AURA/ # Smart Assistant Assets.


## 🚀 How to Run

1. Open the project in **Unity 2022.3.48 LTS** or later
2. Make sure XR Plug-in Management is enabled
3. Connect your Quest 2 via **Oculus Link / Air Link**
4. Play the main scene in VR

## 📹 Demo Video

A short walkthrough video (1–2 mins) is included in the submission package to demonstrate the core interactions and UX.

## 🧩 Dependencies

- Unity XR Interaction Toolkit
- Oculus Integration (optional for headset-specific tweaks)

## 📌 Notes

- The project uses XRGrabInteractable for interaction handling
- Snap-back logic for incorrect placements is handled via colliders + trigger validation
- All interactions tested in VR using actual hardware (no emulation)

## 📄 License

This prototype was built for a technical evaluation and is not intended for commercial use.

---
