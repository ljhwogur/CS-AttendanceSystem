﻿-- 1. 학생 테이블
CREATE TABLE Students (
    StudentID VARCHAR2(20) PRIMARY KEY,
    Name VARCHAR2(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    PhoneNumber VARCHAR2(15),
    Grade NUMBER(1) CHECK (Grade BETWEEN 1 AND 4),
    Major VARCHAR2(50)
);

-- 2. 교수 테이블
CREATE TABLE Professors (
    ProfessorID NUMBER PRIMARY KEY,
    Name VARCHAR2(100) NOT NULL,
    Department VARCHAR2(100)
);

-- 3. 과목 테이블
CREATE TABLE Courses (
    CourseID NUMBER PRIMARY KEY,
    CourseName VARCHAR2(100) NOT NULL
);

-- 4. 담당 교수 테이블
CREATE TABLE CourseProfessors (
    CourseID NUMBER NOT NULL,      -- 과목 ID
    ProfessorID NUMBER NOT NULL,   -- 교수 ID
    PRIMARY KEY (CourseID, ProfessorID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    FOREIGN KEY (ProfessorID) REFERENCES Professors(ProfessorID)
);

-- 5. 학생-과목 관계 테이블
CREATE TABLE StudentCourses (
    StudentID VARCHAR2(20),
    CourseID NUMBER,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- 6. 출석 테이블
CREATE TABLE Attendance (
    AttendanceID NUMBER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY,
    StudentID VARCHAR2(20) NOT NULL,
    CourseID NUMBER NOT NULL,
    AttendanceDate DATE NOT NULL,
    Status VARCHAR2(10) CHECK (Status IN ('출석', '지각', '결석')),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- 7. 교수 데이터 삽입
INSERT INTO Professors (ProfessorID, Name, Department)
VALUES (1, '김철수', '컴퓨터 공학과'); -- 컴퓨터 네트워크 담당 교수
INSERT INTO Professors (ProfessorID, Name, Department)
VALUES (2, '이영희', '컴퓨터 공학과'); -- 데이터베이스 시스템 담당 교수
INSERT INTO Professors (ProfessorID, Name, Department)
VALUES (3, '박민수', '소프트웨어 공학과'); -- 운영체제 담당 교수
INSERT INTO Professors (ProfessorID, Name, Department)
VALUES (4, '최수진', '소프트웨어 공학과'); -- 소프트웨어 공학 담당 교수

-- 8. 과목 데이터 삽입
INSERT INTO Courses (CourseID, CourseName)
VALUES (1, '컴퓨터 네트워크');
INSERT INTO Courses (CourseID, CourseName)
VALUES (2, '데이터베이스 시스템');
INSERT INTO Courses (CourseID, CourseName)
VALUES (3, '운영체제');
INSERT INTO Courses (CourseID, CourseName)
VALUES (4, '소프트웨어 공학');

-- 9. 과목-교수 관계 데이터 삽입
INSERT INTO CourseProfessors (CourseID, ProfessorID)
VALUES (1, 1); -- 컴퓨터 네트워크 -> 김철수
INSERT INTO CourseProfessors (CourseID, ProfessorID)
VALUES (2, 2); -- 데이터베이스 시스템 -> 이영희
INSERT INTO CourseProfessors (CourseID, ProfessorID)
VALUES (3, 3); -- 운영체제 -> 박민수
INSERT INTO CourseProfessors (CourseID, ProfessorID)
VALUES (4, 4); -- 소프트웨어 공학 -> 최수진
