# Abort Shutdown Worker

## Description
 - Simple background worker service project to keep the computer from automatically restarting

## Quick start
 - Build the project
 - Navigate to the directory containing the compiled executable (e.g., bin\Release\net8.0)
 - Copy the folder with the executable to a location of your choice
 - Open a command prompt as an administrator
 - Navigate to the directory
 - Execute `sc.exe create "AbortShutdownWorker" binpath= "C:\Path\To\AbortShutdownWorker.exe"`
   - This will create a service named "AbortShutdownWorker" that will run the executable
   - You can further configure the service when running the `services.msc`

## Technology
 - C# .NET 8
