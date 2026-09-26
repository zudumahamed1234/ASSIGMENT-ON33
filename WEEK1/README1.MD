Chapter 1: Introduction to Visual C#



Slide 1: Introduction to Visual C#

Starting Out with Visual C# — Sixth Edition


Explanation: This slide shows the main topics of the chapter. You will learn how to use Visual Studio, create a program, add controls, write code, and find errors.

Slide 3: 1.1 Objects

An object is a part of a program that contains data and performs operations.

Objects have:

1. Properties: Describe the object or store its data.
2. Methods: Actions the object can perform.

Example: A Button is an object. Its Text property controls the text displayed on it.

Slide 4: Wage Calculator

The Wage Calculator contains:

* Two Labels
* Two TextBoxes
* Two Buttons

The Labels display:

* Number of hours worked
* Hourly pay rate

The Buttons display:

* Calculate gross pay
* Exit

Explanation: The user enters the hours worked and hourly pay rate. The Calculate Gross Pay button calculates the total pay, and the Exit button closes the program.

Slide 5: Controls

Controls are objects used in a program’s GUI.

Examples:

* Label: Displays text.
* Button: Performs an action when clicked.
* TextBox: Allows users to enter text.

Some objects, such as Timers and OpenFileDialog, are not visible.

A Class describes a type of object.

Slide 6: .NET Framework

.NET is a collection of classes and code used to create Windows applications.

C# is supported by .NET. It provides classes for controls, and programmers can also create their own classes.

Slide 7: Getting Started with Visual Studio (1 of 5)

Visual Studio is an Integrated Development Environment (IDE).

It includes:

* Designer Window: Used to design the application.
* Solution Explorer: Shows projects and files.
* Properties Window: Used to change object settings.

Slide 8: Getting Started with Visual Studio (2 of 5)

This slide shows the Visual Studio environment and helps you become familiar with its layout and windows.

Slide 9: Getting Started with Visual Studio (3 of 5)

The Visual Studio environment contains several panes.

Solution Explorer displays the project as an expandable list, including Properties, References, and Form1.

Slide 10: Getting Started with Visual Studio (4 of 5)

This slide continues the introduction to the Visual Studio environment and its programming workspace.

Slide 11: Getting Started with Visual Studio (5 of 5)

Auto Hide allows a window to appear as a tab on the edge of the screen. Clicking the tab displays the window.

Slide 12: Menu Bar and Standard Toolbar

* Menu Bar: Contains menus such as File, Edit, View, and Project.
* Standard Toolbar: Contains buttons for frequently used commands.

Slide 13: Standard Toolbar Icons

* Left Arrow: Go backward.
* Right Arrow: Go forward.
* New Project: Create a new project.
* Open File: Open a file.
* Save: Save a file.
* Save All: Save all files.
* Undo: Cancel the last action.
* Redo: Restore an action.
* Solution Configuration: Choose the build configuration.
* Solution Platform: Choose the target platform.
* Start: Start debugging.
* Find: Search for something.

Slide 14: The Toolbox (1 of 2)

The Toolbox is used to select controls for an application. It usually appears on the left side of Visual Studio and may be in Auto Hide mode.

Slide 15: The Toolbox (2 of 2)

The Toolbox contains sections such as All Windows Forms and Common Controls.

Common Controls include:

* Pointer
* Button
* CheckBox
* CheckedListBox
* ComboBox
* DateTimePicker
* Label
* LinkLabel
* ListBox
* ListView
* MaskedTextBox
* MonthCalendar

Slide 16: Tooltips

A Tooltip is a small box that appears when you move the mouse pointer over an item. It shows information about the tool or button.

Slide 17: Docked and Floating Windows

* Docked: The window is attached to the edge of Visual Studio.
* Floating: The window can move freely around the screen.

You can right-click the title bar and select Float or Dock. A window cannot float while in Auto Hide mode.

Slide 18: Projects and Solutions

A Project is where you create your application. It contains files such as Form1.cs and Program.cs.

A Solution is a container that can hold one or more Projects.

Slide 19: Solution, Project, and Files

* Solution: The main container.
* Project: An application inside the Solution.
* Project Files: The code and resources needed to build the application.

Slide 20: Specifying the Project Name

When creating a Project, you can choose:

* Name: The Project’s name.
* Location: Where the Solution folder is saved.
* Solution Name: The Solution’s name.

Slide 21: Displaying the Designer

To display a Form in the Designer:

1. Right-click Form1.cs in Solution Explorer.
2. Click View Designer.

Slide 22: Forms and Controls

A new Windows Forms application automatically creates an empty Form named Form1.

The initial size is 300 pixels wide and 300 pixels high.

Slide 23: Bounding Box and Sizing Handles

The Bounding Box is the dotted outline around the Form.

Sizing Handles are used to change the Form’s size. Drag the handles to make the Form larger or smaller.

Slide 24: The Properties Window

Properties control how a GUI object looks and behaves.

The Properties Window has two columns:

* Left: Property name.
* Right: Property value.

Slide 25: Changing a Property’s Value

To change a property:

1. Select an object.
2. Open the Properties Window.
3. Find the property.
4. Change its value.

The Text property controls the text displayed in the Form’s title bar.

Example: Change Form1 to My First Program.

Slide 26: Alphabetical and Categorized Properties

* Alphabetical: Displays properties in alphabetical order.
* Categorized: Groups similar properties together.

Categorized is the default setting.

Slide 27: Adding Controls to a Form

You can add a control by double-clicking it in the Toolbox or dragging it onto the Form.

You can resize, move, and change its properties.

To delete a control, select it and press Delete.

Slide 28: Rules for Naming Controls

Control names are called Identifiers.

Rules:

1. The first character must be a letter or underscore (_).
2. Other characters can be letters, numbers, or underscores.
3. Names cannot contain spaces.

Examples:

* showDayButton
* DisplayTotal
* _ScoreLabel

Slide 29: camelCase Naming Convention

camelCase is a naming style.

The first word starts with a lowercase letter. The following words start with uppercase letters.

Example: showDayButton

Slide 30: Creating the GUI for Your First Application

Create an application with a Form and a Button.

When the Button is clicked, the application displays “Hello World”.

This section focuses on creating the GUI.

Slide 31: Introduction to C# Code

C# code is organized into three main parts:

1. Namespace
2. Class
3. Method

A source code file contains program code.

Slide 32: Source Code in Solution Explorer (1 of 2)

Two important source code files are:

* Program.cs: Contains the application’s startup code.
* Form1.cs: Contains code associated with Form1.

Slide 33: Source Code in Solution Explorer (2 of 2)

You can open source code files through Solution Explorer to view or edit their code.

Slide 34: Organization of Form1.cs

Form1.cs contains:

* Namespace
* Class declaration
* Method

The Namespace contains the Class, and the Class contains Methods.

Slide 35: Adding Your Code

GUI applications are event-driven.

Events include:

* Clicking a mouse.
* Pressing a key.
* Moving the mouse.

An Event Handler is a Method that runs when a specific event occurs. Double-clicking a control in the Designer creates an Event Handler.

Slide 36: Message Boxes

A MessageBox displays a message.

Code example:

private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}

Explanation: When the Button is clicked, the program displays the message “Thanks for clicking the button!”

Slide 37: Writing Code for the Hello World Application

This slide shows the completed source code of Form1.cs.

The application displays a message when the user clicks a Button.

Slide 38: Hello World Code Explanation

* namespace hello_world: Defines the Namespace.
* public partial class Form1 : Form: Defines the Form1 Class.
* public Form1(): The Constructor of Form1.
* InitializeComponent();: Initializes the Form’s components.
* messageButton_Click: Handles the Button click event.
* MessageBox.Show("Hello World");: Displays the Hello World message.

Slide 39: Label Controls

A Label displays text on a Form.

Common properties:

* Text: The displayed text.
* Name: The control’s name.
* Font: The font style and size.
* BorderStyle: The border around the Label.
* AutoSize: Controls automatic sizing.
* TextAlign: Controls text alignment.

Slide 40: Handling Text Alignments

TextAlign supports nine positions:

* TopLeft
* TopCenter
* TopRight
* MiddleLeft
* MiddleCenter
* MiddleRight
* BottomLeft
* BottomCenter
* BottomRight

Explanation: TextAlign controls where the text appears inside a Label.

Slide 41: Using Code to Display Output in a Label

The Assignment Operator (=) assigns a value to a property or variable.

Example:

answerLabel.Text = "Hello World";

This displays “Hello World” in the Label.

To clear the text:

answerLabel.Text = "";

Slide 42: Making Sense of IntelliSense

IntelliSense provides automatic code completion.

It suggests:

* Keywords
* Variables
* Methods
* Classes
* Properties

It helps programmers write code faster.

Slide 43: PictureBox Controls

A PictureBox displays an image on a Form.

Common properties:

* Image: Selects the picture.
* SizeMode: Controls how the picture is displayed.
* Visible: Determines whether the PictureBox appears.

Slide 44: Creating Clickable Images and Sequential Execution

Double-clicking a PictureBox in the Designer creates a Click Event Handler.

Explanation:

1. The first statement shows the back of the card.
2. The second statement hides the front of the card.

Statements execute in the order in which they appear.

Slide 45: Comments, Blank Lines, Indentation, Closing Forms, and Syntax Errors

Part 1: Comments

Comments are notes in the source code that explain how the program works.

A line comment uses //.

// Make image of the card back visible.
cardBackPictureBox.Visible = true;

A block comment uses /* and */.

/*
   Line one
   Line two
*/

Comments are not executed as program instructions.

Part 2: Blank Lines and Indentation

* Blank Lines: Empty lines used to separate sections of code.
* Indentation: Spaces at the beginning of lines that organize code clearly.

They make code easier to read.

Part 3: Closing an Application’s Form

this.Close();

This closes the current Form.

Application.Exit();

This closes the entire application.

Part 4: Dealing with Syntax Errors

A Syntax Error is a mistake in the way code is written.

Visual Studio checks code and marks errors with a jagged underline. You must correct syntax errors before the program can compile successful