# Instructions

## Task 5

- `dotnet new webapp --no-https`
- Go to pages/index.cshtml and ur code
- `dotnet watch` or `dotnet run`

## Task 6

- String class [Programiz](https://www.programiz.com/csharp-programming/string)
- String Buffer class [GFG](geeksforgeeks.org/stringbuilder-in-c-sharp/)
  - also use System.Text

## Task 7

**Thread:** thread is defined as the execution path of a program. Each thread defines a unique flow of control.

**Delegates:** A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods. Delegates in C# are similar to the function pointer in C/C++.

- Thread : `public Thread(ThreadStart start);`
- Here, ThreadStart is a delegate which represents a method to be invoked when this thread begins executing
- Start() method starts the exexution of the thread by calling delegate
- public static void Sleep(int millisecondsTimeout)
- Abort() The Abort() method is used for destroying threads.
  The runtime aborts the thread by throwing a ThreadAbortException

## task 8

- `dotnet new console`

- `dotnet add package Mysql.data`

- Setup the connection string using XAMPP
- Write code in Program.cs
- Run the Project

- `dotnet run`

## Task 9

- `dotnet new winforms`
- Code in Program.cs and Run the project

## Task 10

- Same as Task 9

## Task 11

**DLL:**

- Dynamic-link library (DLL) is Microsoft's implementation of the shared library concept in the Microsoft Windows and OS/2 operating systems.
- A shared library or shared object is a file that is intended to be shared by executable files and further shared object files. Modules used by a program are loaded from individual shared objects into memory at load time or runtime, rather than being copied by a linker when it creates a single monolithic executable file for the program.

- libname.cs -> libname.dll
  - `csc /target:library /out:libname.dll libname.cs`
- MainFile.cs -> MainFile.exe
  - `csc /reference:libname.dl MainFile.cs`
- Final Execution of MainFile.cs
  - `.\MainFile.exe 10 11`
