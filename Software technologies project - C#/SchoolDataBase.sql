CREATE DATABASE School
USE School
CREATE TABLE Students (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Family NVARCHAR(50),
    Email NVARCHAR(100),
    EGN NVARCHAR(10),
    BirthDate DATE,
	BornTown NVARCHAR(50),
    City NVARCHAR(50),
    District NVARCHAR(50)
);
CREATE TABLE Teachers (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Subject1 NVARCHAR(50),
    Subject2 NVARCHAR(50)
);

INSERT INTO Teachers (FirstName, LastName, Subject1, Subject2)
VALUES
('Georgi', 'Ivanov', 'Mathematics', 'Physics'),
('Elena', 'Petrova', 'Biology', 'Chemistry'),
('Stoyan', 'Georgiev', 'History', 'Philosophy'),
('Maria', 'Dimitrova', 'Literature', 'Bulgarian Language'),
('Dimitar', 'Petrov', 'Geography', 'History'),
('Kristina', 'Todorova', 'English', 'German'),
('Petar', 'Stoyanov', 'IT', 'Mathematics'),
('Ivan', 'Kolev', 'PE', 'Health Education'),
('Tanya', 'Ivanova', 'Music', 'Art'),
('Borislav', 'Dimitrov', 'Physics', 'Chemistry'),
('Stefka', 'Mihailova', 'French', 'Spanish'),
('Hristo', 'Kostov', 'Philosophy', 'Sociology'),
('Valentina', 'Gospodinova', 'Bulgarian Language', 'Literature'),
('Plamen', 'Yordanov', 'Mathematics', 'IT'),
('Silvia', 'Ivanova', 'History', 'Geography'),
('Nikolay', 'Stoev', 'Physics', 'Astronomy'),
('Zornitsa', 'Daneva', 'Music', 'Art'),
('Yordan', 'Vasilev', 'PE', 'Health Education'),
('Daniela', 'Dimitrova', 'Spanish', 'English'),
('Rosen', 'Todorov', 'Chemistry', 'Biology');

--drop table Students
INSERT INTO Students (Name, Surname, Family, Email, EGN, BirthDate, City, District, BornTown)
VALUES
('Ivan', 'Petrov', 'Ivanov', 'ivan.petrov@example.com', '1234567890', '2005-06-15', 'Sofia', 'Mladost', 'Sofia'),
('Maria', 'Georgieva', 'Petrova', 'maria.georgieva@example.com', '0987654321', '2006-08-22', 'Plovdiv', 'Trakia', 'Plovdiv'),
('Georgi', 'Ivanov', 'Dimitrov', 'georgi.ivanov@example.com', '3456789012', '2005-11-10', 'Varna', 'Levski', 'Varna'),
('Elena', 'Todorova', 'Stoyanova', 'elena.todorova@example.com', '5678901234', '2004-05-30', 'Burgas', 'Zornitsa', 'Burgas'),
('Stoyan', 'Dimitrov', 'Petkov', 'stoyan.dimitrov@example.com', '6789012345', '2006-12-01', 'Ruse', 'Center', 'Ruse'),
('Nikola', 'Petkov', 'Iliev', 'nikola.petkov@example.com', '9988776655', '2005-09-20', 'Dobrich', 'Druzhba', 'Dobrich'),
('Viktoria', 'Stoyanova', 'Koleva', 'viktoria.stoyanova@example.com', '8877665544', '2006-03-12', 'Shumen', 'Center', 'Shumen'),
('Alexander', 'Mihailov', 'Georgiev', 'alex.mihailov@example.com', '7766554433', '2007-01-05', 'Pazardzhik', 'Iztok', 'Pazardzhik'),
('Kristina', 'Kirilova', 'Ivanova', 'kristina.kirilova@example.com', '6655443322', '2004-11-23', 'Veliko Tarnovo', 'Kartala', 'Veliko Tarnovo'),
('Martin', 'Dimitrov', 'Petrov', 'martin.dimitrov@example.com', '5544332211', '2005-07-18', 'Stara Zagora', 'Zheleznik', 'Stara Zagora'),
('Stefan', 'Nikolov', 'Georgiev', 'stefan.nikolov@example.com', '5566778899', '2007-07-19', 'Pleven', 'Storgozia', 'Pleven');

INSERT INTO Students (Name, Surname, Family, Email, EGN, BirthDate, City, District, BornTown)
VALUES
('Petya', 'Ivanova', 'Georgieva', 'petya.ivanova@example.com', '1122334455', '2005-02-14', 'Sofia', 'Lozenets', 'Sofia'),
('Vasil', 'Kolev', 'Petrov', 'vasil.kolev@example.com', '2233445566', '2006-03-25', 'Plovdiv', 'Karshiaka', 'Plovdiv'),
('Ani', 'Dimitrova', 'Ivanova', 'ani.dimitrova@example.com', '3344556677', '2005-07-19', 'Varna', 'Asparuhovo', 'Varna'),
('Todor', 'Petrov', 'Georgiev', 'todor.petrov@example.com', '4455667788', '2004-09-10', 'Burgas', 'Meden Rudnik', 'Burgas'),
('Radost', 'Georgieva', 'Todorova', 'radost.georgieva@example.com', '5566778899', '2006-11-05', 'Ruse', 'Druzhba', 'Ruse'),
('Kalin', 'Iliev', 'Stoyanov', 'kalin.iliev@example.com', '6677889900', '2005-04-30', 'Stara Zagora', 'Zheleznik', 'Stara Zagora'),
('Desislava', 'Stoyanova', 'Petrova', 'desislava.stoyanova@example.com', '7788990011', '2006-08-15', 'Pleven', 'Storgozia', 'Pleven'),
('Hristo', 'Todorov', 'Dimitrov', 'hristo.todorov@example.com', '8899001122', '2004-12-20', 'Dobrich', 'Druzhba', 'Dobrich'),
('Silvia', 'Kirilova', 'Ivanova', 'silvia.kirilova@example.com', '9900112233', '2005-10-12', 'Shumen', 'Center', 'Shumen'),
('Lyubomir', 'Vasilev', 'Georgiev', 'lyubomir.vasilev@example.com', '0011223344', '2006-01-25', 'Pazardzhik', 'Iztok', 'Pazardzhik'),
('Gabriela', 'Nikolova', 'Petrova', 'gabriela.nikolova@example.com', '1122334456', '2005-03-18', 'Veliko Tarnovo', 'Kartala', 'Veliko Tarnovo'),
('Radoslav', 'Petkov', 'Ivanov', 'radoslav.petkov@example.com', '2233445567', '2006-06-22', 'Sofia', 'Mladost', 'Sofia'),
('Yana', 'Ivanova', 'Georgieva', 'yana.ivanova@example.com', '3344556678', '2005-09-14', 'Plovdiv', 'Trakia', 'Plovdiv'),
('Krasimir', 'Georgiev', 'Dimitrov', 'krasimir.georgiev@example.com', '4455667789', '2004-11-30', 'Varna', 'Levski', 'Varna'),
('Maya', 'Dimitrova', 'Stoyanova', 'maya.dimitrova@example.com', '5566778890', '2006-02-10', 'Burgas', 'Zornitsa', 'Burgas'),
('Stanislav', 'Petrov', 'Iliev', 'stanislav.petrov@example.com', '6677889901', '2005-05-05', 'Ruse', 'Center', 'Ruse'),
('Teodora', 'Koleva', 'Todorova', 'teodora.koleva@example.com', '7788990012', '2006-07-19', 'Stara Zagora', 'Zheleznik', 'Stara Zagora'),
('Boris', 'Ivanov', 'Petrov', 'boris.ivanov@example.com', '8899001123', '2004-08-12', 'Pleven', 'Storgozia', 'Pleven'),
('Vanya', 'Todorova', 'Georgieva', 'vanya.todorova@example.com', '9900112234', '2005-12-25', 'Dobrich', 'Druzhba', 'Dobrich'),
('Plamen', 'Stoyanov', 'Dimitrov', 'plamen.stoyanov@example.com', '0011223345', '2006-04-18', 'Shumen', 'Center', 'Shumen'),
('Ralitsa', 'Petrova', 'Ivanova', 'ralitsa.petrova@example.com', '1122334457', '2005-01-30', 'Pazardzhik', 'Iztok', 'Pazardzhik'),
('Ivaylo', 'Georgiev', 'Kirilov', 'ivaylo.georgiev@example.com', '2233445568', '2006-03-15', 'Veliko Tarnovo', 'Kartala', 'Veliko Tarnovo'),
('Nadezhda', 'Ilieva', 'Petrova', 'nadezhda.ilieva@example.com', '3344556679', '2005-06-20', 'Sofia', 'Mladost', 'Sofia'),
('Simeon', 'Dimitrov', 'Todorov', 'simeon.dimitrov@example.com', '4455667790', '2004-10-05', 'Plovdiv', 'Trakia', 'Plovdiv'),
('Eva', 'Koleva', 'Georgieva', 'eva.koleva@example.com', '5566778891', '2006-09-12', 'Varna', 'Levski', 'Varna'),
('Vladimir', 'Petrov', 'Stoyanov', 'vladimir.petrov@example.com', '6677889902', '2005-02-28', 'Burgas', 'Zornitsa', 'Burgas'),
('Zornitsa', 'Ivanova', 'Dimitrova', 'zornitsa.ivanova@example.com', '7788990013', '2006-11-15', 'Ruse', 'Center', 'Ruse'),
('Kaloyan', 'Todorov', 'Petrov', 'kaloyan.todorov@example.com', '8899001124', '2004-07-22', 'Stara Zagora', 'Zheleznik', 'Stara Zagora'),
('Gergana', 'Georgieva', 'Ilieva', 'gergana.georgieva@example.com', '9900112235', '2005-04-10', 'Pleven', 'Storgozia', 'Pleven'),
('Dimitar', 'Petrov', 'Kolev', 'dimitar.petrov@example.com', '0011223346', '2006-08-05', 'Dobrich', 'Druzhba', 'Dobrich'),
('Radka', 'Ilieva', 'Todorova', 'radka.ilieva@example.com', '1122334458', '2005-12-18', 'Shumen', 'Center', 'Shumen'),
('Nikolay', 'Stoyanov', 'Georgiev', 'nikolay.stoyanov@example.com', '2233445569', '2006-05-22', 'Pazardzhik', 'Iztok', 'Pazardzhik'),
('Mihaela', 'Dimitrova', 'Petrova', 'mihaela.dimitrova@example.com', '3344556680', '2005-09-30', 'Veliko Tarnovo', 'Kartala', 'Veliko Tarnovo'),
('Tihomir', 'Kolev', 'Ivanov', 'tihomir.kolev@example.com', '4455667791', '2004-03-15', 'Sofia', 'Mladost', 'Sofia'),
('Yordan', 'Petrov', 'Georgiev', 'yordan.petrov@example.com', '5566778892', '2006-06-10', 'Plovdiv', 'Trakia', 'Plovdiv'),
('Violeta', 'Ivanova', 'Dimitrova', 'violeta.ivanova@example.com', '6677889903', '2005-01-25', 'Varna', 'Levski', 'Varna'),
('Kamen', 'Todorov', 'Petrov', 'kamen.todorov@example.com', '7788990014', '2006-10-12', 'Burgas', 'Zornitsa', 'Burgas'),
('Elena', 'Georgieva', 'Stoyanova', 'elena.georgieva@example.com', '8899001125', '2004-04-18', 'Ruse', 'Center', 'Ruse'),
('Stanimir', 'Iliev', 'Kolev', 'stanimir.iliev@example.com', '9900112236', '2005-07-22', 'Stara Zagora', 'Zheleznik', 'Stara Zagora');

CREATE TABLE Exams (
    ID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT FOREIGN KEY REFERENCES Students(ID),
    TeacherID INT FOREIGN KEY REFERENCES Teachers(ID),
    Subject NVARCHAR(50),
    ExamDate DATE,
    Grade DECIMAL(4,2),
    MaxGrade DECIMAL(4,2) DEFAULT 6.00,
    Comments NVARCHAR(255)
);

--drop table Exams
INSERT INTO Exams (StudentID, TeacherID, Subject, ExamDate, Grade, Comments)
VALUES
(1, 7, 'Mathematics', '2025-02-15', 5.50, 'Excellent problem-solving skills'),
(2, 10, 'Physics', '2025-02-16', 4.00, 'Needs improvement in formulas'),
(3, 5, 'Geography', '2025-02-17', 5.75, 'Great knowledge of maps'),
(4, 12, 'Philosophy', '2025-02-18', 3.50, 'Critical thinking needs work'),
(5, 3, 'History', '2025-02-19', 5.00, 'Well-prepared for the exam'),
(6, 8, 'Physical Education', '2025-02-20', 6.00, 'Outstanding performance'),
(7, 14, 'IT', '2025-02-21', 4.75, 'Good understanding of coding'),
(8, 6, 'English', '2025-02-22', 5.25, 'Strong vocabulary and grammar'),
(9, 2, 'Biology', '2025-02-23', 4.50, 'Average understanding of genetics'),
(10, 9, 'Music', '2025-02-24', 5.80, 'Beautiful singing voice'),
(11, 4, 'Chemistry', '2025-02-25', 4.20, 'Needs to practice more lab experiments'),
(12, 1, 'Art', '2025-02-26', 5.90, 'Creative and expressive work'),
(13, 13, 'French', '2025-02-27', 4.60, 'Good pronunciation but needs grammar improvement'),
(14, 15, 'Economics', '2025-02-28', 5.30, 'Understands financial concepts well'),
(15, 7, 'Mathematics', '2025-02-28', 4.80, 'Shows progress in problem-solving'),
(3, 5, 'Geography', '2025-02-17', 5.75, 'Great knowledge of maps'),
(3, 10, 'Physics', '2025-03-02', 4.20, 'Struggles with some calculations'),
(6, 7, 'Mathematics', '2025-03-05', 5.00, 'Consistent improvement'),
(10, 2, 'Biology', '2025-03-10', 4.80, 'Needs more revision on cell structure'),
(9, 9, 'Music', '2025-03-15', 6.00, 'Outstanding performance and talent');

SELECT 
    e.ID AS ExamID,
    s.ID AS StudentID,
    s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
    t.ID AS TeacherID,
    t.FirstName + ' ' + t.LastName AS TeacherName,
    e.Subject,
    e.ExamDate,
    e.Grade,
    e.MaxGrade,
    e.Comments
FROM Exams e
JOIN Students s ON e.StudentID = s.ID
JOIN Teachers t ON e.TeacherID = t.ID 
--ORDER BY e.ExamDate DESC;

SELECT 
    s.ID AS StudentID,
    s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
    e.Grade,
    e.Subject,
    e.ExamDate
FROM Exams e
JOIN Students s ON e.StudentID = s.ID
ORDER BY e.ExamDate DESC;
-------------------------------------
SELECT 
        e.ID AS ExamID,
        s.ID AS StudentID,
        s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
        t.ID AS TeacherID,
        t.FirstName + ' ' + t.LastName AS TeacherName,
        e.Subject,
        e.ExamDate,
        e.Grade,
        e.MaxGrade,
        e.Comments
        FROM Exams e
        JOIN Students s ON e.StudentID = s.ID
        JOIN Teachers t ON e.TeacherID = t.ID
    WHERE e.Subject = 'Mathematics'
ORDER BY e.Grade DESC;
-------------------------------------
 SELECT 
         e.ID AS ExamID,
         s.ID AS StudentID,
         s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
         t.ID AS TeacherID,
         t.FirstName + ' ' + t.LastName AS TeacherName,
         e.Subject,
         e.ExamDate,
         e.Grade,
         e.MaxGrade,
         e.Comments
         FROM Exams e
         JOIN Students s ON e.StudentID = s.ID
         JOIN Teachers t ON e.TeacherID = t.ID
 WHERE e.Subject= 'Biology'
----------------------------------
SELECT 
    s.ID AS StudentID,
    s.Name + ' ' + s.Surname + ' ' + s.Family AS StudentName,
    ROUND(CAST(AVG(e.Grade) AS DECIMAL(10, 2)), 2) AS AverageGrade
FROM Exams e
JOIN Students s ON e.StudentID = s.ID
WHERE s.ID = 6
GROUP BY s.ID, s.Name, s.Surname, s.Family;
-----------------------------------------------
 SELECT 
     t.ID AS TeacherID,
     t.FirstName + ' ' + t.LastName AS TeacherName,
     COUNT(e.ID) AS ExamCount
 FROM Exams e
 JOIN Teachers t ON e.TeacherID = t.ID
 GROUP BY t.ID, t.FirstName, t.LastName
 ORDER BY ExamCount DESC;


 select * from Exams


