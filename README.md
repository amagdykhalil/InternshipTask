<p align="left"><h1 align="left">INTERNSHIP-TASK</h1></p>
<p align="left">Built with the tools and technologies:</p>
<p align="left">
   <span>Frontend Technologies: </span>
	<img src="https://img.shields.io/badge/npm-CB3837.svg?style=plastic&logo=npm&logoColor=white" alt="npm">
	<img src="https://img.shields.io/badge/Vite-646CFF.svg?style=plastic&logo=Vite&logoColor=white" alt="Vite">
	<img src="https://img.shields.io/badge/React-61DAFB.svg?style=plastic&logo=React&logoColor=black" alt="React">
	<img src="https://img.shields.io/badge/TypeScript-3178C6.svg?style=plastic&logo=TypeScript&logoColor=white" alt="TypeScript">
   <img src="https://img.shields.io/badge/React Hook Form-EC5990.svg?style=plastic&logo=reacthookform&logoColor=white" alt="React Hook Form">
   <br />
   <span>Backend Technologies: </span>
   <img src="https://img.shields.io/badge/ASP.NET%20Core-512BD4.svg?style=plastic&logo=.net&logoColor=white" alt="ASP.NET Core">
	<img src="https://img.shields.io/badge/C%23-239120.svg?style=plastic&logo=c-sharp&logoColor=white" alt="C#">
	<img src="https://img.shields.io/badge/Entity%20Framework%20Core-512BD4.svg?style=plastic&logo=.net&logoColor=white" alt="Entity Framework Core">
	<img src="https://img.shields.io/badge/SQL%20Server-CC2927.svg?style=plastic&logo=microsoftsqlserver&logoColor=white" alt="SQL Server">
   <br/>
   <span>Build & Deployment: </span>
	<img src="https://img.shields.io/badge/Docker-2496ED.svg?style=plastic&logo=Docker&logoColor=white" alt="Docker">
	
</p>
<br>

## 🚀 Live Demo

[inter-task.netlify.app](https://inter-task.netlify.app)

💡 You can also run the full stack locally using [Docker Compose](#-run-with-docker-compose)

---

## 🔗 Table of Contents

- [🚀 Getting Started](#-getting-started)
  - [☑️ Prerequisites](#-prerequisites)
  - [⚙️ Installation](#-installation)
- [🤖 Usage](#🤖-usage)
- [🐳 Docker Compose](#-run-with-docker-compose)

## 🚀 Getting Started

### ☑️ Prerequisites

Before getting started with, ensure your runtime environment meets the following requirements:

- **Programming Language:** TypeScript
- **Package Manager:** Npm
- **.NET 9 SDK**
- **SQL Server**

### ⚙️ Installation

Install using one of the following methods:

**Build from source:**

1. Clone the InternshipTask repository:

```sh
❯ git clone https://github.com/amagdykhalil/InternshipTask
```

- **Frontend**

2. Navigate to the project directory:

```sh
❯ cd InternshipTask/frontend
```

3. Install the project dependencies:

**Using `npm`**

```sh
❯ npm install
```

- **Backend**

5. Navigate to the project directory:

```sh
❯ cd InternshipTask/backend
```

6. Install the project dependencies:

```sh
❯ dotnet restore
```

7. Run database migrations (to set up the database schema):

```sh
❯ dotnet ef database update
```

### 🤖 Usage

- **Frontend**

Run frontend using the following command:

```sh
❯ npm run dev
```

- **Backend**

Run backend using the following command:

```sh
❯ dotnet run
```

---

## 🐳 Run with Docker Compose

You can run the full application stack (frontend, backend, and database) using Docker Compose.

### ➤ From the project root, run:

```sh
docker-compose up -d --build

```
