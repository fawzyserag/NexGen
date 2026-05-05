# 🚀 NexGen Solutions - Full Stack Landing Page

<div align="center">

![Angular](https://img.shields.io/badge/Angular-21.1.4-red?style=for-the-badge&logo=angular)
![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet)
![TypeScript](https://img.shields.io/badge/TypeScript-5.x-blue?style=for-the-badge&logo=typescript)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

**A modern, responsive landing page for a fictional tech agency**

[Quick Start](#-quick-start) • [Features](#-features) • [Documentation](#-documentation) • [Demo](#-demo)

</div>

---

## 📋 Table of Contents

- [About](#-about)
- [Quick Start](#-quick-start)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Documentation](#-documentation)
- [Screenshots](#-screenshots)
- [API Documentation](#-api-documentation)
- [Testing](#-testing)
- [Deployment](#-deployment)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About

This project is a **complete Full Stack Landing Page** built for the **iExperts Full Stack Developer Intern Assessment**. It demonstrates proficiency in modern web development technologies including Angular, .NET, and responsive design principles.

### 🎓 Assessment Details
- **Developer**: Fawzy Serag
- **Purpose**: iExperts Full Stack Developer Intern Assessment
- **Deadline**: Sunday, 10 May 2026
- **Status**: ✅ **COMPLETED**

---

## ⚡ Quick Start

Get the project running in **5 minutes**!
### Prerequisites

- Node.js v20+ ([Download](https://nodejs.org))
- .NET SDK 9.0+ ([Download](https://dotnet.microsoft.com/download))
- Angular CLI v21+ (`npm install -g @angular/cli`)

### Installation

**1. Clone the repository**
```bash
git clone <repository-url>
cd iExpert-Task
```

**2. Start Backend**
```bash
cd LandingPageAPI
dotnet run --urls "http://localhost:5000"
```

**3. Start Frontend** (in a new terminal)
```bash
cd landing-page-frontend
npm install
ng serve
```

**4. Open Browser**
```
http://localhost:4200
```

🎉 **That's it!** The landing page should now be running.

> 📖 For detailed instructions, see [QUICK_START.md](QUICK_START.md)

---

## ✨ Features

### Core Features
- ✅ **Angular 21** with Standalone Components
- ✅ **.NET 9 Web API** with RESTful architecture
- ✅ **Fully Functional Contact Form** with real API integration
- ✅ **Responsive Design** (Mobile, Tablet, Desktop)
- ✅ **Form Validation** (Client & Server side)
- ✅ **Clean Code** with best practices

### UI/UX Features
- 🎨 Modern gradient design
- ⚡ Smooth animations and transitions
- 🎯 Professional typography
- 🔤 Font Awesome icons
- 📱 Mobile-first approach
- ♿ Accessibility compliant

### Technical Features
- 🔄 Reactive Forms
- 🌐 CORS configuration
- 📝 Input validation
- 🔒 XSS protection
- 📊 Logging
- ⚠️ Error handling

> 📖 For complete feature list, see [FEATURES_AND_HIGHLIGHTS.md](FEATURES_AND_HIGHLIGHTS.md)

---

## 🛠️ Tech Stack

### Frontend
| Technology | Version | Purpose |
|------------|---------|---------|
| Angular | 21.1.4 | Frontend Framework |
| TypeScript | 5.x | Programming Language |
| SCSS | - | Styling |
| RxJS | 7.x | Reactive Programming |
| Font Awesome | 6.4.0 | Icons |

### Backend
| Technology | Version | Purpose |
|------------|---------|---------|
| .NET | 9.0 | Backend Framework |
| C# | 12.0 | Programming Language |
| ASP.NET Core | 9.0 | Web API |

---

## � Project Structure

```
iExpert-Task/
├── landing-page-frontend/          # Angular Frontend
│   ├── src/
│   │   ├── app/
│   │   │   ├── components/
│   │   │   │   ├── hero/
│   │   │   │   ├── about/
│   │   │   │   ├── services/
│   │   │   │   ├── why-choose-us/
│   │   │   │   ├── contact-form/
│   │   │   │   └── footer/
│   │   │   ├── models/
│   │   │   │   └── contact.model.ts
│   │   │   ├── services/
│   │   │   │   └── contact.ts
│   │   │   ├── app.ts
│   │   │   └── app.config.ts
│   │   ├── index.html
│   │   └── styles.scss
│   └── package.json
│
└── LandingPageAPI/                 # .NET Backend
    ├── Controllers/
    │   └── ContactController.cs
    ├── Models/
    │   └── ContactMessage.cs
    ├── Program.cs
    └── appsettings.json
```

---

## � Documentation

This project includes comprehensive documentation:

| Document | Description |
|----------|-------------|
| [README.md](README.md) | Main documentation (you are here) |
| [QUICK_START.md](QUICK_START.md) | Get started in 5 minutes |
| [HOW_TO_RUN.md](HOW_TO_RUN.md) | Detailed running instructions |
| [FEATURES_AND_HIGHLIGHTS.md](FEATURES_AND_HIGHLIGHTS.md) | Complete features list |
| [API_TESTING.md](API_TESTING.md) | API testing guide |
| [SCREENSHOTS_GUIDE.md](SCREENSHOTS_GUIDE.md) | Screenshots guide |
| [DEPLOYMENT_GUIDE.md](DEPLOYMENT_GUIDE.md) | Deployment instructions |
| [TROUBLESHOOTING.md](TROUBLESHOOTING.md) | Common issues & solutions |
| [PROJECT_SUMMARY.md](PROJECT_SUMMARY.md) | Project overview |

---

## 📸 Screenshots

### Desktop View
![Hero Section](screenshots/hero-section.png)
![Services Section](screenshots/services-section.png)
![Contact Form](screenshots/contact-form.png)

### Mobile View
![Mobile Hero](screenshots/mobile-hero.png)
![Mobile Form](screenshots/mobile-form.png)

> 📖 For screenshot guide, see [SCREENSHOTS_GUIDE.md](SCREENSHOTS_GUIDE.md)

---

## 🔌 API Documentation

### Endpoint: POST /api/contact

**Request:**
```json
{
  "name": "John Doe",
  "email": "john@example.com",
  "message": "Hello, I'm interested in your services."
}
```

**Success Response (200 OK):**
```json
{
  "success": true,
  "message": "Thank you for contacting us! We'll get back to you soon."
}
```

**Error Response (400 Bad Request):**
```json
{
  "success": false,
  "message": "All fields are required"
}
```

> 📖 For complete API documentation, see [API_TESTING.md](API_TESTING.md)

---

## 🧪 Testing

### Manual Testing

**Test the Contact Form:**
1. Fill in all fields
2. Click "Send Message"
3. Verify success message appears

**Test Validation:**
1. Leave fields empty
2. Click "Send Message"
3. Verify error messages appear

### API Testing

**PowerShell:**
```powershell
$body = '{"name":"Test","email":"test@test.com","message":"Hello"}' 
Invoke-RestMethod -Uri "http://localhost:5000/api/contact" -Method Post -Body $body -ContentType "application/json"
```

**cURL:**
```bash
curl -X POST http://localhost:5000/api/contact \
  -H "Content-Type: application/json" \
  -d '{"name":"Test","email":"test@test.com","message":"Hello"}'
```

> 📖 For complete testing guide, see [API_TESTING.md](API_TESTING.md)

---

## 🚀 Deployment

### Build for Production

**Frontend:**
```bash
cd landing-page-frontend
ng build --configuration production
```

**Backend:**
```bash
cd LandingPageAPI
dotnet publish -c Release -o ./publish
```

### Deployment Options
- **Azure**: Static Web Apps + App Service
- **Vercel + Railway**: Easy deployment
- **AWS**: S3 + Elastic Beanstalk
- **Netlify + Heroku**: Alternative option

> 📖 For complete deployment guide, see [DEPLOYMENT_GUIDE.md](DEPLOYMENT_GUIDE.md)

---

## 🤝 Contributing

This is an assessment project, but suggestions are welcome!

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📄 License

This project is created for assessment purposes.

---

## 👨‍💻 Developer

**Fawzy Serag**

Built as part of the **iExperts Full Stack Developer Intern Assessment**

---

## � Acknowledgments

- iExperts for the opportunity
- Angular team for the amazing framework
- Microsoft for .NET
- Font Awesome for the icons

---

## 📞 Support

If you have any questions or issues:

1. Check [TROUBLESHOOTING.md](TROUBLESHOOTING.md)
2. Review [HOW_TO_RUN.md](HOW_TO_RUN.md)
3. Check the documentation files

---

<div align="center">

**⭐ If you found this project helpful, please give it a star! ⭐**

**Built with ❤️ by Fawzy Serag**

**Deadline**: Sunday, 10 May 2026 | **Status**: ✅ Complete

</div>
