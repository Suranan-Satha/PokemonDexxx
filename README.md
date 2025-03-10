# PokemonDexxx

PokemonDexxx เป็นโปรเจกต์ที่พัฒนาโดยใช้ **C# และ Windows Forms (WinForms)** สำหรับการแสดงข้อมูลของโปเกมอน

## คุณสมบัติของโปรแกรม
- แสดงข้อมูลของโปเกมอนแต่ละตัว
- มีคลาสแยกต่างหากสำหรับโปเกมอนแต่ละตัว
- มี UI ที่พัฒนาโดยใช้ WinForms
- รองรับรูปภาพของโปเกมอนแต่ละตัว

## วิธีการติดตั้งและใช้งาน
### 1. ติดตั้งเครื่องมือที่จำเป็น
- **Visual Studio** (แนะนำให้ใช้เวอร์ชันที่รองรับ .NET Framework)
- .NET Framework เวอร์ชันที่รองรับ

### 2. เปิดโปรเจกต์
1. ดาวน์โหลดหรือโคลนโปรเจกต์นี้
2. เปิดไฟล์ `POkemonDExx.sln` ด้วย Visual Studio

### 3. รันโปรแกรม
- กดปุ่ม `Start` หรือ `F5` เพื่อคอมไพล์และรันแอปพลิเคชัน

## โครงสร้างโปรเจกต์
```
PokemonDexxx-main/
│-- Arbok.cs          # คลาสของ Arbok
│-- Drowzee.cs        # คลาสของ Drowzee
│-- Pikachu.cs        # คลาสของ Pikachu
│-- Gengar.cs         # คลาสของ Gengar
│-- Slaking.cs        # คลาสของ Slaking
│-- Snorlax.cs        # คลาสของ Snorlax
│-- Pokemon.cs        # คลาสพื้นฐานของโปเกมอน
│-- Program.cs        # จุดเริ่มต้นของโปรแกรม
│-- Form1.cs          # ฟอร์ม UI หลัก
│-- Form1.Designer.cs # ออกแบบ UI
│-- Form1.resx        # ทรัพยากร UI
│-- Resource1.Designer.cs # การจัดการทรัพยากร
│-- Resource1.resx    # ไฟล์ทรัพยากร
│-- POkemonDExx.csproj # ไฟล์โปรเจกต์
│-- POkemonDExx.sln    # ไฟล์โซลูชันสำหรับเปิดใน Visual Studio
│
├── Resources/        # โฟลเดอร์เก็บรูปภาพโปเกมอน
│   │-- PIKa.jpg
│   │-- Snor.jpg
│   │-- arbok.jpg
│   │-- drowzee.jpg
│   │-- gengar.jpg
│   │-- slaking.jpg
│
├── bin/              # โฟลเดอร์เก็บไฟล์คอมไพล์
├── obj/              # โฟลเดอร์สำหรับไฟล์ชั่วคราวที่ใช้ระหว่างคอมไพล์
└── .vs/              # โฟลเดอร์การตั้งค่าของ Visual Studio
```



