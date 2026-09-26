Chapter 2 — Processing Data
3.1 Reading Input with TextBox Controls
A TextBox allows the user to enter data.
User input is stored as text.
TextBox controls are commonly used to receive information from the user.
3.2 #A First Look at Variables
A variable is a named memory location used to store data.
Every variable has a data type.
The data type determines what kind of value the variable can hold.
Variable Names
A variable name identifies the stored data.
It must follow C# naming rules.
It should clearly describe the information it stores.
String Variables
A string stores a sequence of characters.
It is used for text information.
String Concatenation
Concatenation means joining two or more pieces of text together.
It can also combine text with other values.
Declaring Variables Before Using Them
A variable must be declared before it can be used.
Local Variables and Scope
A local variable belongs to the method where it is declared.
Scope describes where the variable can be used.
Lifetime describes how long the variable exists in memory.
Duplicate Variable Names
Two variables cannot have the same name in the same scope.
Variables in different scopes may have the same name.
Assignment Compatibility
The value assigned to a variable must be compatible with its data type.
Initializing Variables
Initialization means giving a variable its first value.
A local variable must be initialized before it is used.
Declaring Multiple Variables with One Statement
Several variables of the same type can be declared together.
3.3 # Numeric Data Types and Variables
Numeric data types are used for numbers.
int is used for whole numbers.
double is used for numbers that may contain decimal values.
decimal is used when greater precision is required, especially for financial calculations.
Numeric Literals
A numeric literal is a number written directly in a program.
Different numeric forms represent different numeric data types.
Assignment Compatibility for int Variables
An int is designed to store whole-number values.
Values of incompatible types cannot always be assigned directly.
Assignment Compatibility for double Variables
A double can represent whole numbers and decimal values.
Some other numeric types are not directly compatible with it.
Assignment Compatibility for decimal Variables
Decimal is designed for high-precision decimal calculations.
It is especially useful for financial data.
Explicit Conversion with Cast Operators
Casting means deliberately changing a value from one data type to another.
It is used when a conversion is required.
Declaring Local Variables with the var Keyword
var allows the compiler to determine the variable's type from its initial value.
The variable must have an initial value.
It is used for local variables.
3.4# Performing Calculations

C# supports basic arithmetic operations:

Addition
Subtraction
Multiplication
Division
Modulus
Rules for Performing Calculations
Calculations follow the order of operations.
Parentheses can be used to control the order.
The data types involved can affect the type of the result.
Integer Division
Integer division produces an integer result.
A fractional part may be discarded.
A suitable decimal-based type is needed when a fractional result is required.
3.5# Inputting and Outputting Numeric Values
Input received from a TextBox is treated as text.
Numeric text must be converted into a numeric value before calculations can be performed.
Parsing is used for this conversion.
Displaying Numeric Values
GUI controls such as Labels and TextBoxes display text.
Numeric values therefore need to be converted into text for display.
3.6 # Formatting Numbers with the ToString Method
Number formatting controls how numeric values appear to the user.
Common formats include:
Number
Fixed-point
Exponential
Currency
Percentage
3.7 Simple Exception Handling
An exception is an error that occurs while a program is running.
Exceptions can result from invalid input or other unexpected situations.
Exception handling allows the program to respond to these errors.
Handling Exceptions with try-catch
The try part contains operations that may cause an error.
The catch part responds when an exception occurs.
Throwing an Exception
Throwing an exception means an error has been raised during program execution.
Throwing vs. Catching
Throwing means an exception occurs.
Catching means the program handles that exception.
Real-Life Examples
An ATM can respond to an incorrect PIN with an error message.
A vehicle can warn the driver about a problem instead of simply stopping without information.
Displaying an Exception’s Default Message
An exception contains information about the error.
The Message property provides a description of what went wrong.
3.8 Using Named Constants
A constant represents a value that does not change while the program runs.
Constants are useful for fixed values.
Named constants make programs easier to understand.
3.9 Declaring Variables as Fields
A field is a variable declared at the class level.
A field can be accessed throughout the appropriate class.
Fields have a longer lifetime than local variables.
3.10 Using the Math Class
The Math class provides tools for mathematical calculations.
It includes operations for:
Square roots
Powers
Finding maximum values
Finding minimum values
Rounding numbers
It also provides important mathematical constants such as Pi and E.
3.11 More GUI Details
Tab Order
Tab order determines how controls receive focus when the user presses the Tab key.
It allows users to move through controls using the keyboard.
TabIndex determines the position of a control in the tab sequence.
Focus Method
Focus identifies the control currently receiving keyboard input.
Focus can be moved from one control to another.
Assign Keyboard Access Key to Buttons
Access keys provide keyboard shortcuts for controls.
They allow users to interact with controls without using the mouse.
Setting Colors
BackColor controls the background color.
ForeColor controls the text or foreground color.
Colors can be selected from different color categories.
Background Images for Forms
A form can have a background image.
Background image settings determine how the image is displayed.
Different layouts can control its position and size.
GroupBoxes versus Panels
Both are containers for organizing controls.
A GroupBox can have a border and title.
A Panel is another type of container and can have its own border settings.
3.12 Using the Debugger to Locate Logic Errors
Logic Error
A logic error occurs when a program runs but produces the wrong result.
The program does not necessarily stop when a logic error occurs.
Breakpoints
A breakpoint temporarily stops program execution at a selected location.
It allows the programmer to examine what is happening at that point.
Break Mode
Break Mode is the state in which program execution is paused.
Variables and control values can be examined.
Locals and Watch Windows
Locals Window displays local variables and their values.
Watch Window allows selected variables to be monitored during debugging.
Single-Stepping
Single-stepping executes the program one statement at a time.
It helps the programmer follow the program's execution.
It is useful for locating the source of logic errors.
Quick Revision

TextBox → Variables → Data Types → Numeric Data → Calculations → Input/Output → Number Formatting → Exceptions → Constants → Fields → Math Class → GUI → Debugging