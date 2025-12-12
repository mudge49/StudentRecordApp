Student Records Management System

Requirement:
•	MySQL 
•	XAMPP (Run the following SQL code in your phpmyadmin):

Pre-requisite instructions:
Step 1: Open XAMPP
Step 2: On your browser, go to phpmyadmin: http://localhost/phpmyadmin
Step 3: Open up the console and run the following code:
CREATE DATABASE studentdb;

USE studentdb;

CREATE TABLE students (
studentID INT PRIMARY KEY AUTO_INCREMENT,
surname VARCHAR(100),
firstname VARCHAR(100),
birthdate DATE,
gender VARCHAR(10),
address VARCHAR(255)
);

Instructions:
Opening the file: Open the program named “Student Records Management App” inside the “Student Records Management App” folder.

Adding a Record: Click on the “Add” Button and input your data. Type in your first name, surname and address, and pick your birthdate and gender.

Editing a Record: Select a row in the database and click on the “Edit” Button to edit any of the data of the selected record.

Viewing a Record: Select a row in the database and click on the “View” Button. This will let you view the student data of the selected row.

Deleting a Record: Select a row in the database and click on the “Delete” Button. This will prompt you to confirm the deletion of the selected record.

Sorting a Record: Click on the “Sort” Button to sort the database by its studentID in ascending or descending order.
