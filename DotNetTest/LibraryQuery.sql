CREATE DATABASE Library

GO

USE Library

GO

CREATE TABLE Admin(
Username VARCHAR(30) PRIMARY KEY,
Password VARCHAR(30)
)

GO

INSERT INTO Admin VALUES
('Ashish','admin'),
('Kiran','abcd'),
('Varun','12345')

GO

CREATE TABLE Student(
Username VARCHAR(30) PRIMARY KEY,
Password VARCHAR(30),
Name VARCHAR(30),
Age INT,
Gender CHAR,
Rollno INT,
Branch VARCHAR(30)
)

GO

INSERT INTO Student VALUES
('Abhishek1','123','Abhishek','20','M','1','Mechanics'),
('Ayushi03','abcde','Ayushi','21','F','18','Civil'),
('Meher123','xyz','Meher','23','F','23','Electronics'),
('Piyush11','omg','Piyush','20','M','39','Civil'),
('Jyoti21','12345','Jyoti','21','F','25','Mechanics'),
('Pankaj007','007','Pankaj','21','M','25','Civil'),
('Manish123','123','Manish','20','M','35','Electrical'),
('Vishal80','evergreen','Vishal','20','M','23','Computer Science'),
('Kajal21','gogo','Kajal','23','F','29','Electrical'),
('Kavita33','zzz','Kavita','21','F','49','Electronics')

GO

CREATE TABLE Books(
BookID INT PRIMARY KEY,
Name VARCHAR(100),
Author VARCHAR(50),
Category VARCHAR(30),
Quantity INT)

GO

INSERT INTO Books VALUES
('101','To Kill a Mocking Bird','Harper Lee','Fiction','2'),
('102','1984','George Orwel','Fiction','3'),
('103','Unbroken','Laura HerrenBrand','Non Fiction','1'),
('104','How to Influence People and Win Friends','Dale Carnegia','Business','4'),
('105','Start with Why?','Simon Sinek','Business','2'),
('106','Harry Potter and the Half Blood Prince','J.K.Rowling','Fiction','7'),
('107','Delivering Happiness','Tony Heislig','Business','5'),
('108','Begining ASP.NET','Imar Spaanjaars','Computer Science','2'),
('109','Graph Theory','Narsingh Deo','Computer Science','2'),
('110','And Then There Were None','Agatha Christie','Fiction','2')

GO

CREATE TABLE IssueDetails(
IssueID int IDENTITY(1,1) PRIMARY KEY,
Issuer VARCHAR(30) FOREIGN KEY REFERENCES Student(Username),
BookID INT FOREIGN KEY REFERENCES Books(BookID),
Status VARCHAR(30),
IssueDate DATETIME)

GO

INSERT INTO IssueDetails (Issuer,BookID,Status,IssueDate)VALUES
('Ayushi03','104','Issued','2015-08-04 10:16:00.000'),
('Manish123','103','Issued','2015-08-05 11:17:00.000'),
('Kajal21','101','Withdrawn','2015-08-05 9:04:00.000'),
('Piyush11','102','Issued','2015-08-06 16:16:00.000'),
('Abhishek1','107','Withdrawn','2015-08-03 12:16:00.000')

GO

SELECT * FROM Admin
SELECT * FROM Student
SELECT * FROM Books
SELECT * FROM IssueDetails