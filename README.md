# 🩺 SymptomCheckerGPT

An AI-powered healthcare mini-project built with **ASP.NET Core MVC** and **OpenAI GPT**.  
This application takes user-entered symptoms and provides possible causes or suggestions using the GPT API.

---

## 🔧 Tech Stack

- ASP.NET Core MVC (.NET 6+)
- C# & Razor Views
- OpenAI GPT-3.5/4 via API
- HttpClient-based service layer
- Optional: Azure App Service for deployment

---

## 📸 Demo

![demo](https://user-images.githubusercontent.com/your-placeholder/symptom-demo.gif)  
> *Input symptoms like: "fever, body pain, headache" and get AI-based suggestions instantly.*

---

## 🚀 Features

- Submit symptoms via form
- Backend calls OpenAI's GPT model to generate advice
- View formatted AI response on the same page
- Easily extendable for voice input or logging

---

## 🧱 Project Structure
- SymptomCheckerGPT/
- ├── Controllers/
- ├── Models/
- ├── Services/
- ├── Views/Symptom/
- ├── Program.cs
- └── appsettings.json


---

## 🛠️ Setup Instructions

1. **Clone the repository**
```bash
git clone https://github.com/YOUR_USERNAME/SymptomCheckerGPT.git
cd SymptomCheckerGPT
```
2. **Set your OpenAI API Key**
   
  Edit OpenAIService.cs and replace:
```
private readonly string _apiKey = "your-openai-api-key";
```
  with your actual OpenAI API key


3. **Run the project**

```
dotnet restore
dotnet run
```
4. **Visit:**
https://localhost:5001/Symptom

## ✨ Future Improvements
- Azure OpenAI integration
- Voice-to-text input (Azure Speech)
- Logging & Analytics
- Secure access with roles (Doctor/Admin)

## 📄 License
 **MIT © [madhu320]**
 
