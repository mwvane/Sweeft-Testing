create table Teachers(
  id INT(6) PRIMARY KEY,
  name varchar(200),
  surname varchar(200),
  sex varchar(20),
  subject varchar(200)
);

create table Pupils (
  id INT(6) PRIMARY KEY,
  name varchar(200),
  surname varchar(200),
  sex varchar(20),
  grade varchar(200)
);

create table Teacher_Pupil (
  id INT(6) PRIMARY KEY,
  teacher_id int(6),
  pupil_id int(6),
  FOREIGN KEY (teacher_id) REFERENCES Teachers(id),
  FOREIGN KEY (pupil_id) REFERENCES Pupils(id)
);

-- Insert into teachers 
INSERT INTO Teachers(id, name, surname, sex, subject) 
VALUES (1, "jujuna", "tabatadze", "female", "c++");

INSERT INTO Teachers(id, name, surname, sex, subject) 
VALUES (2, "vaja", "saridze", "male", "c#");

INSERT INTO Teachers(id, name, surname, sex, subject) 
VALUES (3, "naiko", "beridze", "female", "Java");
-------------------------

-- Insert into pupils
INSERT INTO Pupils(id, name, surname, sex, grade) 
VALUES (1, "zuka", "gergaia", "male", "c++");

INSERT INTO Pupils(id, name, surname, sex, grade) 
VALUES (2, "Levan", "Bzishvili", "male", "c#");

INSERT INTO Pupils(id, name, surname, sex, grade) 
VALUES (3, "Giorgi", "Tarziani", "male", "Java");
----------------------


-- Create relations 
INSERT INTO Teacher_Pupil(id, teacher_id, pupil_id) VALUES (1, 1, 1);
INSERT INTO Teacher_Pupil(id, teacher_id, pupil_id) VALUES (2, 1, 2);
INSERT INTO Teacher_Pupil(id, teacher_id, pupil_id) VALUES (3, 1, 3);
INSERT INTO Teacher_Pupil(id, teacher_id, pupil_id) VALUES (4, 2, 2);
INSERT INTO Teacher_Pupil(id, teacher_id, pupil_id) VALUES (5, 2, 1);
INSERT INTO Teacher_Pupil(id, teacher_id, pupil_id) VALUES (6, 3, 3);
-------------------



-- Write selects 
select * from Teachers 
join Teacher_Pupil on Teachers.id = Teacher_Pupil.teacher_id 
join Pupils on Teacher_Pupil.pupil_id = Pupils.id 
where Pupils.name = "Giorgi";
