CHAPTER 1 — C# CODE AND EXPLANATIONS

Code 1: Form1 Constructor

Purpose: To initialize the Form when the program starts.

namespace hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}

Explanation:

* namespace hello_world: Defines the namespace name.
* public partial class Form1 : Form: Defines the Form1 class.
* public Form1(): This is the constructor.
* InitializeComponent();: Initializes the Form and its controls.

How it works: The program starts, the constructor runs, and InitializeComponent() prepares the Form.

⸻

Code 2: MessageBox — Displaying a Message

Purpose: To display a message when a Button is clicked.

private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}

Explanation:

* private void: Defines a method that does not return a value.
* myButton_Click: The event handler name.
* object sender: Identifies the object that caused the event.
* EventArgs e: Contains event information.
* MessageBox.Show(): Displays a message.
* "Thanks for clicking the button!": The message displayed.

How it works: The user clicks the Button, the event handler runs, and a message appears.

⸻

Code 3: Hello World

Purpose: To display “Hello World” when a Button is clicked.

private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}

Explanation:

* messageButton_Click: Handles the Button click event.
* MessageBox.Show(): Displays a message.
* "Hello World": The text displayed.

Output: A message box displays Hello World.

⸻

Code 4: Label — Displaying Text

Purpose: To display text in a Label.

answerLabel.Text = "Hello World";

Explanation:

* answerLabel: The Label’s name.
* .Text: The text displayed in the Label.
* =: The assignment operator.
* "Hello World": The text assigned to the Label.
* ;: Ends the statement.

Output: The Label displays Hello World.

⸻

Code 5: Clearing a Label

Purpose: To clear the text displayed in a Label.

answerLabel.Text = "";

Explanation:

* answerLabel: The Label’s name.
* .Text: The Label’s text property.
* "": An empty string.

Output: The Label becomes empty.

⸻

Code 6: PictureBox — Showing and Hiding Images

Purpose: To show one image and hide another image.

cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;

Explanation:

* cardBackPictureBox: The PictureBox for the back image.
* Visible = true: Makes the image visible.
* cardFacePictureBox: The PictureBox for the front image.
* Visible = false: Hides the image.

Output: The back image appears, and the front image is hidden.

⸻

Code 7: Closing a Form

Purpose: To close the current Form.

this.Close();

Explanation:

* this: Refers to the current Form.
* Close(): Closes the Form.
* ;: Ends the statement.

Output: The current Form closes.

⸻

Code 8: Closing the Entire Application

Purpose: To close the application.

Application.Exit();

Explanation:

* Application: Refers to the application.
* Exit(): Requests the application to close.
* ;: Ends the statement.

Output: The application closes.

Difference:

* this.Close(); closes the current Form.
* Application.Exit(); closes the application.

⸻

Code 9: Single-Line Comment

Purpose: To add a note inside the code.

// This is a comment.

Explanation:

* // starts a single-line comment.
* The comment is not executed as program code.
* It helps programmers understand the code.

⸻

Code 10: Multi-Line Comment

Purpose: To write a comment on multiple lines.

/*
This is a comment.
It has multiple lines.
*/

Explanation:

* /* starts the comment.
* */ ends the comment.
* The text inside is not executed.

⸻

Code 11: Syntax Error Example

Correct code:

MessageBox.Show("Hello World");

Incorrect code:

MessageBox.Show("Hello World"

Explanation:

The incorrect code is missing a closing parenthesis ) and a semicolon ;.

A Syntax Error is a mistake in the way code is written. Visual Studio helps identify these errors.

⸻

Final Summary

* InitializeComponent(); initializes the Form.
* MessageBox.Show(); displays a message.
* Label.Text displays or clears text.
* PictureBox.Visible shows or hides an image.
* this.Close(); closes the current Form.
* Application.Exit(); closes the application.
* // and /* */ are used for comments.
* Syntax Errors are mistakes in code.

Information Technology Student


The following string variables are created to store the date information entered by the user.

```csharp
string DayoftheWeek, Month, Day, Year, FullDate;
```

![Creating Variables](Screenshots/student information/week1/Sreenshot/Assign_variable.jpeg)

### 2. Assigning Variables

The values entered by the user in the TextBoxes are assigned to the corresponding variables.

```csharp
DayoftheWeek = dayOfWeekTextBox.Text;

Month = monthTextBox.Text;

Day = dayOfMonthTextBox.Text;

Year = yearTextBox.Text;
```

![Assigning Variables](student information/week1/Sreenshot/creatingvariable1.jpeg)

### 3. Concatenation

The `+` operator is used to combine the values of the date variables into one complete date string.

```csharp
FullDate = DayoftheWeek + ", " + Month + " " + Day + ", " + Year;
```

![Concatenation](student information/week1/Sreenshot/Concatenation.png)


### 4. Displaying the Result

The `FullDate` variable is assigned to the `Text` property of the `dateOutputLabel`. This displays the formatted date on the form.

```csharp
dateOutputLabel.Text = FullDate;
```

The `dateOutputLabel` is a Label control on `Form1` used to display the final date.

![Displaying Result](student information/week1/Sreenshot/Displaying_Result.jpeg)



### 5. Clearing the Input Fields

The input fields and the output label are cleared by setting their `Text` property to an empty string or by using the `Clear()` method.

```csharp
dayOfWeekTextBox.Text = "";

dayOfMonthTextBox.Clear();

monthTextBox.Text = string.Empty;

yearTextBox.Text = string.Empty;

dateOutputLabel.Text = string.Empty;
```

This allows the user to remove the previous input and output from the form.

![Clearing Input Fields](student information/week1/Sreenshot/Clearing_Input.jpeg)


