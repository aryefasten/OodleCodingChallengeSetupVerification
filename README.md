# Oodle Coding Challenge - Setup Verification

Welcome, and thanks for taking the time to interview with us!

This repository exists for one reason: to make sure your machine is ready before your session starts so we can spend our time together on the actual challenge — not on installation issues.

Please complete the steps below ahead of your interview.

---

## Step 1 — Install .NET 9.0 SDK

- Download from: https://dotnet.microsoft.com/en-us/download/dotnet/9.0
- Install the **.NET 9.0 SDK** (not just the runtime)

## Step 2 — Install an IDE or Code Editor

Pick whichever you are most comfortable with:

**Visual Studio 2022** (recommended for Windows)
- Community edition is free: https://visualstudio.microsoft.com/vs/community/
- During installation, select the **.NET desktop development** workload

**Visual Studio Code**
- Download from: https://code.visualstudio.com/
- Install the **C# Dev Kit** extension (by Microsoft) from the Extensions marketplace

**JetBrains Rider**
- Download from: https://www.jetbrains.com/rider/
- Free 30-day trial available

## Step 3 — Verify Your Setup

Clone this repository, open a terminal in the folder, and run:

```
dotnet test SetupVerification.csproj
```

You should see:

```
Passed!  - Failed: 0, Passed: 4, Skipped: 0, Total: 4
```

If all 4 tests pass, you are all set. See you at the interview!

---

If you run into any issues, please reach out ahead of time so we can help you get sorted.
