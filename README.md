# Oodle Coding Challenge - Setup Verification

Welcome, and thanks for taking the time to interview with us!

This repository exists for one reason: to make sure your machine is ready before your session starts so we can spend our time together on the actual challenge — not on installation issues.

Please complete the steps below ahead of your interview.

---

## Step 1 — Install .NET 9.0 SDK

- Download from: https://dotnet.microsoft.com/en-us/download/dotnet/9.0
- Install the **.NET 9.0 SDK** (not just the runtime)

## Step 2 — Install Visual Studio Code

- Download from: https://code.visualstudio.com/
- Install the **C# Dev Kit** extension (by Microsoft) from the Extensions marketplace

Feel free to use a different IDE if you prefer, as long as it supports .NET development.

## Step 3 — Run the Tests

Clone this repository, open a terminal in the folder, and run:

```
dotnet test SetupVerification.csproj
```

You should see:

```
Passed!  - Failed: 0, Passed: 4, Skipped: 0, Total: 4
```

## Step 4 — Run the Console App

In the same terminal, run:

```
dotnet run --project SetupVerification.csproj
```

You should see output like:

```
1 squared = 1
2 squared = 4
3 squared = 9
4 squared = 16
5 squared = 25
Setup verification complete!
```

## Step 5 — Debug with Breakpoints

Confirm that you can set a breakpoint and step through code in your IDE:

1. Open the project folder in VS Code
2. Open [SetupVerificationTest.cs](SetupVerificationTest.cs)
3. Click in the gutter to the left of the `var squared = number * number;` line to set a breakpoint (a red dot should appear)
4. Press **F5** to start debugging — VS Code may ask you to select a debugger, choose **.NET 5+ and .NET Core**
5. The program should pause at your breakpoint, letting you inspect the `number` variable in the side panel
6. Press **F5** again to continue, or **F10** to step line by line

If the breakpoint hits and you can see the variable values, your setup is complete. See you at the interview!

---

If you run into any issues, please reach out ahead of time so we can help you get sorted.
