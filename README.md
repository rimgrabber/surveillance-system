# Surveillance System for Military Applications (Embedded System-Based)

This project implements a remote surveillance turret system with landmine detection using embedded platforms. It integrates pan-tilt control, camera streaming via ESP32-CAM, and directional movement via Bluetooth.

## 🛠 Components

- Arduino UNO
- ESP32-CAM (AI Thinker)
- HC-05 Bluetooth Module
- 2x Servo Motors
- DC Motors for Movement
- C# GUI for Mouse-based Maneuvering
- Embedded Code (Arduino)
- Visual Studio (.NET WinForms)

## 📷 Features

- Real-time camera feed from ESP32-CAM
- Pan-Tilt turret using servo motors
- Directional movement via Bluetooth (F/B/L/R)
- Mouse-based turret control via GUI
- Future scope: Landmine detection module (sensor integration)

## 🔧 Code Overview

- `arduino_code/pan_tilt_servo.ino`: Arduino code for handling servo pan/tilt via serial
- `bluetooth_control/MouseControl.cs`: C# code using mouse to control turret
- `bluetooth_movement/movement_control.ino`: Arduino code to control robot movement via Bluetooth
- `esp32_cam/Instructions.txt`: Steps to enable camera streaming on ESP32-CAM

## 📦 Setup

1. Upload pan-tilt code to Arduino
2. Connect Bluetooth and upload movement control code
3. Upload CameraWebServer example to ESP32-CAM
4. Run MouseControl.cs in Visual Studio
5. Ensure serial ports and COM configurations match

## 📸 Live Demo

Coming soon...
