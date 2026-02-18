# 🚗 DVLD — Driving Licenses Management System

A full-featured **desktop application** for managing the complete lifecycle of driving licenses — from first application and exam workflow to renewals, replacements, and detain/release operations — built with a clean **3-Tier Architecture**.

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| UI | Windows Forms + ReaLTaiizor UI |
| Business Logic | C# OOP |
| Data Access | SQL Server (SSMS) |
| Architecture | 3-Tier (UI / BLL / DAL) |

---

## ✨ Features

### 🔐 1. Authentication & Access Control
- Secure login system with distinct error handling for wrong credentials, inactive accounts, and failed attempts
- Role-based access routing upon successful login

### 👥 2. People Management
- Full CRUD operations for registering persons in the system
- Advanced filtering and search to quickly locate records
- Person profiles serve as the foundation for all downstream license operations

### 🖥️ 3. System User Administration
- Create and manage system user accounts independently from the people registry
- Activate / deactivate accounts, update passwords, or delete users entirely

### 📋 4. Local Driving License Application
The core workflow of the system — structured across three stages:

1. **Vision Test**
2. **Written Test**
3. **Street Test**

Each test can be scheduled, passed, failed, or retaken independently. Only after passing all three stages is the license issued, at which point the person is automatically registered as a driver.

### 🌍 5. International Driving License
- Drivers with a valid local license can apply for an international license directly
- Validates the existing local license and issues the international one — no need to repeat the exam process

### 🔄 6. License Renewal
- Submit renewal applications when a license reaches its expiry date
- Generates a new license with an updated expiry date and archives the old one — history is fully preserved

### 🔁 7. License Replacement
- Handle lost or damaged license cases
- Records the replacement reason, invalidates the old license, and issues a new one with the same class and expiry

### 🔒 8. Detain & Release
- Authorities can detain an active license with a recorded reason and date
- Formally release and restore licenses to active status when the issue is resolved
- Full detain/release history is preserved

---

## 🏗️ Architecture

The project follows a strict **3-Tier Architecture**:

```
┌─────────────────────────────────────┐
│          Presentation Layer          │  Windows Forms (UI)
├─────────────────────────────────────┤
│        Business Logic Layer          │  C# Classes (BLL)
├─────────────────────────────────────┤
│         Data Access Layer            │  SQL Server via ADO.NET (DAL)
└─────────────────────────────────────┘
```

Each layer is decoupled and can be modified independently — keeping the codebase maintainable and scalable.

---

## 💡 Lessons Learned

**🏗️ Mastering 3-Tier Architecture** — Separating UI, BLL, and DAL taught me the real value of decoupling. Each layer could be modified independently, and the codebase became far easier to maintain as complexity grew.

**⚙️ Modeling Real-World Workflows** — Translating multi-step processes like the three-stage exam workflow into clean, predictable code taught me to think in terms of states, transitions, and business rules.

**🧱 Applying OOP Principles in Practice** — Designing classes that properly encapsulate behavior, using inheritance where appropriate, and keeping responsibilities focused helped me internalize clean object-oriented design.

**📐 Enforcing Business Rules at the Right Layer** — Business rules don't belong in the UI. Validation logic and domain rules live in the BLL — keeping the UI thin and the logic testable.

**🗄️ Thinking in Data, Not Just Forms** — Designing the database schema to reflect relationships between people, drivers, licenses, applications, and tests gave me a deeper understanding of relational data modeling.

**🔁 Managing Complexity Through Consistency** — With 8+ distinct modules sharing overlapping logic, I learned to build reusable components rather than duplicating code. Consistency in naming and structure turned a complex system into something navigable.

---

## 📸 Demo

> Demo videos covering all modules are available in my portfolio [DVLD_Details](https://dimamusallam-portfolio.netlify.app/detailsdvld).

Modules showcased:
- Main Dashboard
- Login flows (success / failure / inactive account)
- People management (filter, add, edit, delete)
- System user management
- Local license application & exam scheduling
- International license issuance
- Renewal, replacement, detain, and release workflows
