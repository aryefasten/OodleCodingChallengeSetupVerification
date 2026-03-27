# Coding Challenge - Machine Setup Requirements

Please complete the following setup **before** your interview session. This ensures you can spend your time on the actual challenge rather than installation.

---

## Required Software

### 1. .NET 9.0 SDK

- Download from: https://dotnet.microsoft.com/en-us/download/dotnet/9.0
- Install the **.NET 9.0 SDK** (not just the runtime)
- Verify installation by running in a terminal:
  ```
  dotnet --version
  ```
  You should see a version starting with `9.0`.

### 2. An IDE or Code Editor (choose one)

**Option A: Visual Studio 2022** (recommended for Windows)
- Community edition is free: https://visualstudio.microsoft.com/vs/community/
- During installation, select the **.NET desktop development** workload

**Option B: Visual Studio Code**
- Download from: https://code.visualstudio.com/
- Install the **C# Dev Kit** extension (by Microsoft) from the Extensions marketplace

**Option C: JetBrains Rider**
- Download from: https://www.jetbrains.com/rider/
- Free 30-day trial available

---

## Verify Your Setup

Clone this repository, then run the following in a terminal from the repo folder:

```
dotnet test SetupVerification.csproj
```

You should see:

```
Passed!  - Failed: 0, Passed: 4, Skipped: 0, Total: 4
```

If all 4 tests pass, your setup is ready. The repository and further instructions will be provided at the start of your session.

---

## Notes

- Internet access is not required during the challenge itself.
- If you run into any setup issues, reach out ahead of time so we can help you resolve them.
