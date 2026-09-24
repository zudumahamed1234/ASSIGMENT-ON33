### 1. Combining Student Information

This code combines the student's name, student ID, department, and semester into a single string. The `\n` escape sequence is used to display each piece of information on a new line.

```csharp
fullInfo = student_name + "\n"
         + student_id + ",\n"
         + department + ",\n"
         + semester;
```

![Student Information](student information/week2/sreenshoot/combining student information.jpeg)


### 2. Declaring Variables

The following variables are declared to store the student's name, student ID, department, semester, and full information.

```csharp
string student_name, department;
int student_id, semester;
string fullInfo;
```

![Declaring Variables](student information/week2/sreenshoot/Declaring_variable.jpeg)

### 3. Displaying Student Information

The `fullInfo` variable is assigned to the `Text` property of the `lbloutput` Label control to display the student's information on the form.

```csharp
lbloutput.Text = fullInfo;
```

![Displaying Student Information](student information/week2/sreenshoot/displaying student information.jpeg)

### 2. Assigning Student Information

The following code retrieves the student's information from the TextBoxes and assigns the values to the corresponding variables. The `int.Parse()` method converts the student ID and semester from text to integers.

```csharp
student_name = txtname.Text;
student_id = int.Parse(txtstudentid.Text);
department = txtdepartment.Text;
semester = int.Parse(txtsemester.Text);
```

![Assigning Student Information](student information/week2/sreenshoot/Getting student information.jpeg)
