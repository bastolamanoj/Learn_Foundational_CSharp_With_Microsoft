###  Implement the Visual Studio Code debugging tools for C#

## Prerequisites
    An installation of Visual Studio Code that's configured for C# application development.
    Ability to develop C# console applications that implement business logic using iteration statements, selection statements, and custom methods.
    A basic understanding of code debuggers and the debug process.

    Visual Studio Code (VS Code) provides debugging tools for C# development through extensions like "C# for Visual Studio Code." Here are some basic steps to use the debugging tools in VS Code for C#:

1. **Install Visual Studio Code:**
   Ensure you have Visual Studio Code installed on your computer.

2. **Install the C# Extension:**
   - Open VS Code.
   - Go to the Extensions view by clicking the square icon on the sidebar or by pressing `Ctrl+Shift+X` (Windows/Linux) or `Cmd+Shift+X` (macOS).
   - Search for "C#" and install the "C# for Visual Studio Code" extension provided by Microsoft.

3. **Create a C# Project:**
   - Create a new C# project or open an existing one in VS Code. You can use the .NET CLI to create a new project.
   - Make sure your project has the necessary configuration files like `launch.json` for debugging.

4. **Set Breakpoints:**
   - Open the C# source code file where you want to set breakpoints.
   - Click in the left margin next to the line numbers to set breakpoints. Breakpoints are used to pause the program's execution for inspection.

5. **Run and Debug:**
   - Open the file you want to debug.
   - Click the "Run and Debug" button on the left sidebar or press `F5`.
   - If you don't have a `launch.json` configuration file, VS Code will help you create one.
   - Select the debugging configuration (e.g., ".NET Core Launch (console)").

6. **Start Debugging:**
   - After configuring the launch options, press `F5` or click the green play button in the top menu to start debugging.
   - Your program will run, and it will pause at the breakpoints you set. You can use debugging controls like Step Over, Step Into, Continue, and so on to navigate through your code.

7. **Inspect Variables:**
   - While debugging, you can inspect the values of variables by hovering over them or using the Variables and Watch panes in the debugging view.
   - You can also use the Debug Console to execute C# expressions during debugging.

8. **Stop Debugging:**
   - When you're done debugging, you can stop the debugging session by clicking the red square "Stop" button or by pressing `Shift+F5`.

9. **Review Output:**
   - The Debug Console displays program output and debugging information as you run and debug your code.

These are the basic steps to use the Visual Studio Code debugging tools for C#. The debugging experience in VS Code is powerful and helps you find and fix issues in your C# programs efficiently.

### The principles of code debugging and exception handling

## the launch configurations file
 Visual Studio Code uses the launch.json file to configure the debugger. If you're creating a simple C# console application, it's likely that Visual Studio Code generates a launch.json file that has all of the information you need to successfully debug your code. However, there are cases when you need to modify a launch configuration, so it's important to understand the attributes of a launch configuration.

# Attributes of a launch configuration
   - The launch.json file includes one or more launch configurations in the configurations list. The launch configurations use attributes to support different debugging scenarios. The following attributes are mandatory for every launch configuration:

      - name: The reader-friendly name assigned to the launch configuration.
      - type: The type of debugger to use for the launch configuration.
      - request: The request type of the launch configuration.
                 The request attribute specifies the request type for the launch configuration. Currently, the values launch and attach are supported.
       - PreLaunchTask
         The preLaunchTask attribute specifies a task to run before debugging your program. The task itself can be found in the tasks.json file, which is in the .vscode folder along with the launch.json file. Specifying a prelaunch task of build runs a dotnet build command before launching the application.

       - Program
         The program attribute is set to the path of the application dll or .NET Core host executable to launch.

         This property normally takes the form: ${workspaceFolder}/bin/Debug/<target-framework>/<project-name.dll>.

         Where:

           -  <target-framework> is the framework that the debug project is being built for. This value is normally found in the project file as the 'TargetFramework' property.
           -  <project-name.dll> is the name of debugged project's build output dll. This property is normally the same as the project file name but with a '.dll' extension.

         For example: ${workspaceFolder}/bin/Debug/net7.0/Debug101.dll

      eg.

         {
            // Use IntelliSense to learn about possible attributes.
            // Hover to view descriptions of existing attributes.
            // For more information, visit: https://go.microsoft.com/fwlink/?linkid=830387
            "version": "0.2.0",
            "configurations": [
               {
                     "name": ".NET Core Launch (console)",
                     "type": "coreclr",
                     "request": "launch",
                     "preLaunchTask": "build",
                     "program": "${workspaceFolder}/bin/Debug/net7.0/Debug101.dll.",
                     "args": [],
                     "cwd": "${workspaceFolder}",
                     "stopAtEntry": false,
                     "console": "internalConsole"
               }

                ]
         }
## Run menu options
- The Visual Studio Code Run menu provides easy access to some common run and debug commands.
- The Run menu provides menu options that are grouped into six sections.

      - Start and stop applications. This section of the menu includes options for starting and stopping code execution, with and without the debugger attached.

      - Launch configurations. This section of the menu provides access to examine or create launch configurations.

      - Runtime control. This section of the menu enables the developer to control how they want to advance through the code. Controls are enabled when execution has paused during a debug session.

      - Set Breakpoints. This section of the menu enables the developer to set breakpoints on code lines. Code execution pauses on Breakpoints during a debug session.

      - Manage Breakpoints. This section of the menu enables the developer to manage breakpoints in bulk rather than individually.

      - Install Debuggers. This section of the menu opens the Visual Studio Code EXTENSIONS view filtered for code debuggers.

## Run and Debug view user interface
- The RUN AND DEBUG view provides access to runtime tools that can be invaluable during the debug process.

      - Run and Debug controls panel. Used to configure and start a debug session.

      - VARIABLES section. Used to view and manage variable state during a debug session.

      - WATCH section. Used to monitor variables or expressions. For example, you could configure an expression using one or more variables and watch it to see when a particular condition is met.

      - CALL STACK section. Used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application. The call stack shows which method is currently being executed, as well as the method or methods in the execution path that led to the current point of execution (current line of code).

      - BREAKPOINTS section. Displays the current breakpoint settings.

      - Debug toolbar. Used to control code execution during the debug process. This toolbar is only displayed while the application is running.

      - Current execution step. Used to identify the current execution step by highlighting it in the Editor. In this case, the current execution step is a breakpoint (breakpoints are marked with a red dot to the left of the line number).

      - DEBUG CONSOLE. Used to display messages from the debugger. The DEBUG CONSOLE panel is the default console for console applications and is able to display output from Console.WriteLine() and related Console output



## Controls panel for the Run and Debug view
-  Start debugging. This button (a green arrow) is used to start a debug session.

      - Launch configurations. This dropdown menu provides access to launch configurations. The selected option is displayed.

      - Open 'launch.json'. This button (a gear shape) can be used to open the launch.json file, where you can edit the launch configuration if needed.

      - Views and More Actions. This button (an ellipsis) enables you to show/hide sections of the debug panel as well as the DEBUG CONSOLE panel.

## Debug toolbar
The Debug toolbar provides execution controls while your application is running.
   - Pause/Continue. This button can be used to pause execution when the code is running and Continue when code execution has been paused.

   - Step Over. This button can be used to execute the next method as a single command without inspecting or following its component steps.

   - Step Into. This button can be used to enter the next method or code line and observe line-by-line execution steps.

   - Step Out. When inside a method, this button can be used to return to the earlier execution context by completing all remaining lines of the current method as though they were a single command.

   - Restart. This button can be used to terminate the current program execution and start debugging again using the current configuration.

   - Stop. This button can be used to terminate the current program execution.



### QSN
1. Which of the following options can be used set a breakpoint in Visual Studio Code? 

      - Left-click in the column to the left of a line number in the code editor. (correct)

      - Select Toggle Breakpoint on the Edit menu.

      - Right-click in the middle of a line of code, and then select Toggle Breakpoint.

2. How can a developer disable a breakpoint in Visual Studio Code? 

      - Click Remove Breakpoint on the Run menu.

      - Right-click the red dot to the left of the line number and select Disable Breakpoint. (correct)

      - Left-click the red dot to the left of the line number.

3. What happens when a developer disables a breakpoint in Visual Studio Code? 

      - The breakpoint is removed from the code entirely.

      - The breakpoint is skipped over during debugging.

      - The breakpoint will only be triggered if dot to the left of the line number is changed to a grey dot.

4. What is a conditional breakpoint in Visual Studio Code? 

      - A breakpoint that only triggers when a specified condition is met. (correct)

      - A breakpoint that is triggered every time the code is run.

      - A breakpoint that is only visible in the editor and doesn't affect debugging.

5. How can a developer create a conditional breakpoint in Visual Studio Code? 

      - Left-click in the column to the left of a line number in the code editor.

      - Select Toggle Conditional Breakpoint on the Run menu.

      - Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.(correct)

6. A developer updates a launch configuration. What is the name attribute used for? 

      - To specify the type of debugger used in a launch configuration.

      - To specify the request type of a launch configuration.

      - To specify the display name for a configuration. (correct)

7. A developer is working on a launch configuration. What is the preLaunchTask attribute used for? 

      - To specify the path of the application dll or .NET Core host executable to launch.

      - To specify a task to run before debugging your program. (correct)

      - To specify the type of console that's used when the application is launched.

8. What is the console attribute of a launch configuration used for? 

      - Specifies the working directory of the target process.

      - Specifies the type of debugger to use for this launch configuration.

      - Specifies the type of console that's used when the application is launched. (correct)


## QSN-part-2

1. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

      - The VARIABLES section.

      - The CALL STACK section.(correct)
         Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application

      - The WATCH section.

2. Which of the following options can be used set a breakpoint in Visual Studio Code? 

      - Left-click in the column to the left of a line number in the code editor. (correct)

      - Select Toggle Breakpoint on the Edit menu.

      - Right-click in the middle of a line of code, and then select Toggle Breakpoint.

3. How can a developer disable a breakpoint in Visual Studio Code? 

      - Click Remove Breakpoint on the Run menu.

      - Right-click the red dot to the left of the line number and select Disable Breakpoint. (correct)

      - Left-click the red dot to the left of the line number.

4. What is a conditional breakpoint in Visual Studio Code? 

      - A breakpoint that only triggers when a specified condition is met. (correct)

      - A breakpoint that is triggered every time the code is run.

      - A breakpoint that is only visible in the editor and does not affect debugging.

5. How can a developer create a conditional breakpoint in Visual Studio Code? 

      - Left-click in the column to the left of a line number in the code editor.

      - Select Toggle Conditional Breakpoint on the Run menu.

      - Right-click in the column to the left of a line number, and then select Add Conditional Breakpoint.(correct)

6. In a launch configuration file, what is the console attribute used for? 

      - Specifies the working directory of the target process.

      - Specifies the type of debugger to use for this launch configuration.

      - Specifies the type of console that's used when the application is launched. (correct)


### QSN_3 

1. Which section of the Run menu enables a developer to edit or add launch configurations? 

      - The start and stop applications section.

      - The launch configurations section.
        Correct. The configurations section of the Run menu provides access to edit or add launch configurations in Visual Studio Code.

      - The install debuggers section.

2. Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application? 

      - VARIABLES section.

      - CALL STACK section.
        Correct. The CALL STACK section is used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application

      - WATCH section.

3. Which button on the Debug toolbar can be used resume normal code execution? 

      - The Pause/Continue button. 
         Correct. The Pause/Continue button on the Debug toolbar can be used to pause execution when the code is running and continue when code execution has been paused.

      - The Step Over button.

      - The Restart button.

4. Which section of the Run menu enables the developer to set breakpoints on code lines? 

      - The Manage Breakpoints section.

      - The Start and stop applications section.

      - The Set Breakpoints section. (correct)

5. What capability does the "More" dropdown on the right side of the Debug toolbar provide? 

      - An option to disconnect the debugger. (correct)

      - An option to edit launch configurations.

      - An option to manage breakpoints.

6. Which of the following can be used to configure and start a debug session? 

      - The Debug toolbar.

      - The VARIABLES section of the RUN AND DEBUG view.

      - The Run and Debug controls panel. (correct)
        The Run and Debug controls panel is used to configure and start a debug session from the RUN AND DEBUG view in Visual Studio Code.




### Exception Handling in C# console applications 
- Exception handling is implemented in C# using the try, catch, and finally keywords. 
- These keywords enable your code to try actions that may not succeed, to handle failures when you decide  that it's reasonable to do so, and to clean up resources afterward.
- Exceptions can be generated by the common language runtime (CLR), by .NET or third-party libraries, or by application code.




## QSN 

1. Which of the following answer choices lists the C# keywords used for exception handling? 

      - try, catch, and finally.

      - try, catch, finally, and throw.
          Correct. The try, catch, finally, and throw keywords are used for exception handling in C#.

      - try, catch, and throw.

2. What does the try code block contain? 

      - The code that cleans up resources and is executed whether an exception occurs or not.

      - The code that throws an exception object.

      - The code that may cause an exception.
         Correct. The try code block contains the guarded code that may cause an exception.

3. What is the purpose of the catch code block? 

      - To clean up any resources that are allocated in a try block.

      - To handle the exception, log it, or ignore it.
         Correct. The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it.

      - To execute code that may cause an exception.

4. What is the purpose of the finally block? 

      - To execute code that may cause an exception.

      - To handle the exception, log it, or ignore it.

      - To clean up any resources that are allocated in a try block.
         Correct. The finally block is often used to clean up any resources that are allocated in a try block. The finally code block contains code that executes whether an exception occurs or not.


## QSN-2
1. When is an ArrayTypeMismatchException exception thrown? 

      - An ArrayTypeMismatchException exception is thrown when an attempt is made to divide an integral value by zero.

      - An ArrayTypeMismatchException exception is thrown when an attempt is made to index an array outside the bounds of the array.

      - An ArrayTypeMismatchException exception is thrown when an attempt is made to store a value of one type in an array of another type.

2. When is a DivideByZeroException exception thrown? 

      - A DivideByZeroException exception is thrown when an attempt is made to divide an integral value by zero.

      - A DivideByZeroException exception is thrown when an attempt is made to index an array outside the bounds of the array.

      - A DivideByZeroException exception is thrown when an attempt is made to store a value of one type in an array of another type.

3. When is an IndexOutOfRangeException exception thrown? 

      - An IndexOutOfRangeException exception is thrown when an attempt is made to divide an integral value by zero.

      - An IndexOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.

      - An IndexOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.

4. When is an InvalidCastException exception thrown? 

      - An InvalidCastException exception is thrown when an attempt is made to divide an integral value by zero.

      - An InvalidCastException exception is thrown when an attempt is made to store a value of one type in an array of another type.

      - An InvalidCastException exception is thrown when attempting an invalid casting or explicit conversion.

5. When is a NullReferenceException exception thrown? 

      - A NullReferenceException exception is thrown when attempting an invalid casting or explicit conversion.

      - A NullReferenceException exception is thrown when an attempt is made to store a value of one type in an array of another type.

      - A NullReferenceException exception is thrown when attempting to access a member on a type whose value is null.
      Need help? See our troubleshooting guide or provide specific feedback by reporting an issue.



## QSN - 3
1. What does the try code block contain? 

      - The code that cleans up resources and is executed whether an exception occurs or not.

      - The code that throws an exception object.

      - The code that may cause an exception.

2. What is the purpose of the catch code block? 

      - To clean up any resources that are allocated in a try block.

      - To handle the exception, log it, or ignore it.

      - To execute code that may cause an exception.
3. When is an IndexOutOfRangeException exception thrown? 

      - An IndexOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.

      - An IndexOutOfRangeException exception is thrown when attempting an invalid casting or explicit conversion.

      - An IndexOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.

4. When is an ArrayTypeMismatchException exception thrown? 

      - An ArrayTypeMismatchException exception is thrown when an attempt is made to store a value of one type in an array of another type.

      - An ArrayTypeMismatchException exception is thrown when attempting to access a member on a type whose value is null.

      - An ArrayTypeMismatchException exception is thrown when an attempt is made to index an array outside the bounds of the array.

5. What is the name of the base class that all derived exception types inherit from? 

     -  Object.

     -  System.

     - Exception.

6. Which property of an exception object can be used to determine where an error occurred? 

      - InnerException.

      - StackTrace.

      - TargetSite.

7. What is the recommended approach for catching exceptions in C#? 

      - Catch any type of exception without specifying an object argument.

      - Catch only the exceptions that your code knows how to recover from.

      - Catch only the exceptions that are not derived from System.Exception.

8. What is the name of the specific exception type that occurs when attempting to divide by zero in C#? 

      - ArithmeticException.

      - InvalidCastException.

      - DivideByZeroException.




## QSN-4


1. A developer needs to create and throw an exception in a C# application. Which of the following descriptions is correct? 

      The exception type shouldn't match the intended purpose of the exception.

      The exception type that they create depends on the coding issue.

      The process for throwing an exception object involves using the catch keyword.

2. When should a method throw an exception? 

      A method should throw an exception when the method can complete its intended purpose.

      A method should throw an exception when the method can't complete its intended purpose.

      A method should throw an exception when an exception type matches the intended purpose of the method.

3. A developer needs to create an exception object that includes a specific Message property. Which of the following statements is correct? 

      The Message property of an exception is writable.

      The Message property shouldn't explain the reason for the exception.

      The Message property should explain the reason for the exception.




1. What is the purpose of catching an exception in C#? 

      - To ignore the errors that occur in a program.

      - To generate other exceptions in a program.

      - To take corrective action when an error occurs in a program.

2. What is the relationship between the type of exception and the information it contains? 

      - The type of exception and the information it contains are unrelated.

      - The type of exception determines the information it contains.

      - The information contained in an exception determines the type of exception.

3. What is a conditional breakpoint in Visual Studio Code? 

      - A breakpoint that only triggers when a specified condition is met.

      - A breakpoint that is triggered every time the code is run.

      - A breakpoint that is only visible in the editor and doesn't affect debugging.

4. When is an ArgumentOutOfRangeException exception thrown? 

      - An ArgumentOutOfRangeException exception is thrown when an attempt is made to index an array outside the bounds of the array.

      - An ArgumentOutOfRangeException exception is thrown when the value of an argument is outside the allowable range of values as defined by the method.

      - An ArgumentOutOfRangeException exception is thrown when an attempt is made to store a value of one type in an array of another type.

5. What is the recommended approach for catching exceptions in C#? 

      - Catch any type of exception without specifying an object argument.

      - Catch only the exceptions that your code knows how to recover from.

      - Catch only the exceptions that aren't derived from System.Exception.


### QSN -5

 What is the purpose of catching an exception in C#? 

To ignore errors that occur in a program.

To take corrective action when an error occurs in a program.
Correct. The purpose of catching an exception is to take corrective action when an error occurs.


To generate additional errors in a program.
2. Can a developer access the contents of an exception at runtime? 

      - No, exceptions can never be accessed.

      - Yes, exceptions can be accessed and used to take corrective action.
         Correct. Exceptions are objects that can be accessed. The properties of an exception can be used to help determine corrective action.


      - Exceptions can be accessed, but not during the application runtime.
       Incorrect. Exceptions are objects that can be accessed at runtime.

3. What happens when execution of a C# application results in a system error? 

      -  The program crashes and closes.

      -  An exception is created and thrown by the .NET runtime.
      Correct. The .NET runtime throws an exception when a C# application generates a system error.

      -  The error is silently ignored and the program continues to run.

4. What is the relationship between the type of exception and the information it contains? 

      - The type of exception and the information it contains are unrelated.

      - The type of exception determines the information it contains.
      Correct. The type of exception determines the information it contains.

      - The information contained in an exception determines the type of exception.


What is code debugging? 

A process to identify code syntax errors during the build process.

A process to isolate and fix issues in code logic.

A process to verify that code builds and runs without errors.
2. What is a debugger? 

      - A software tool used to observe and control the execution flow of a program.

      - A program that generates code automatically based on user input.

      - A tool that helps developers write their code faster.


3. What happens when execution of a C# application results in a system error? 

      - The program crashes and closes.

      - The .NET runtime creates and throws an exception.

      - The error is silently ignored and the program continues to run.

4. What is the purpose of catching an exception in C#? 

      To ignore the errors that occur in a program.

      To generate other exceptions in a program.

      To take corrective action when an error occurs in a program.

5. What is the relationship between the type of exception and the information it contains? 

      The type of exception determines the information it contains.

      The type of exception and the information it contains are unrelated.

      The information contained in an exception determines the type of exception.




