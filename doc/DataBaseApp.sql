DROP TABLE Student CASCADE CONSTRAINTS;
DROP TABLE Course CASCADE CONSTRAINTS;
DROP TABLE Teacher CASCADE CONSTRAINTS;
DROP TABLE Sc CASCADE CONSTRAINTS;
DROP TABLE Tc CASCADE CONSTRAINTS;
DROP TABLE LoginUser CASCADE CONSTRAINTS;

CREATE TABLE Student
(
  Sno VARCHAR(10),
  Sname VARCHAR(20) NOT NULL,
  Ssex VARCHAR(5), 
  Sage NUMBER,
  CONSTRAINT PK_STU PRIMARY KEY(Sno),
  CONSTRAINT CK_SEX CHECK(Ssex IN('��','Ů'))
);
CREATE TABLE Course
(
  Cno VARCHAR(10),
  Cname VARCHAR(20) NOT NULL,
  Ccredit NUMBER,
  CONSTRAINT PK_COU PRIMARY KEY(Cno)
);
CREATE TABLE Teacher 
(
   Tno VARCHAR2(10),
   Tname VARCHAR2(20) NOT NULL,
   Post VARCHAR2(20),
   Salary NUMBER,
   CONSTRAINT PK_TEA PRIMARY KEY(Tno)
);
CREATE TABLE Sc
(
  Sno VARCHAR2(10), 
  Cno VARCHAR2(10), 
  Grade NUMBER, 
  CONSTRAINT PK_SC PRIMARY KEY(Sno,Cno), 
  CONSTRAINT FK_SCSNO FOREIGN KEY (Sno) REFERENCES Student(Sno) ON DELETE CASCADE,
  CONSTRAINT FK_SCCNO FOREIGN KEY (Cno) REFERENCES Course(Cno) ON DELETE CASCADE 
);
DROP TABLE Tc;
CREATE TABLE Tc
(
  Cno VARCHAR2(10),
  Tno VARCHAR2(10), 
  CONSTRAINT PK_TC PRIMARY KEY(Cno), 
  CONSTRAINT FK_TCTNO FOREIGN KEY (Tno) REFERENCES Teacher(Tno) ON DELETE CASCADE,
  CONSTRAINT FK_TCCNO FOREIGN KEY (Cno) REFERENCES Course(Cno) ON DELETE CASCADE   
);
DROP TABLE Client;
CREATE TABLE LoginUser(
    UserId VARCHAR2(10),
    UserType VARCHAR2(10) NOT NULL CHECK(UserType IN('Admin','Student')),
    Passwd VARCHAR2(20) DEFAULT '123456' NOT NULL,
    CONSTRAINT PK_LU PRIMARY KEY(UserId), 
    CONSTRAINT FK_LUSNO FOREIGN KEY (UserId) REFERENCES Student(Sno) ON DELETE CASCADE
);

SELECT table_name FROM user_tables;

insert into Student(sname,ssex,sno, sage) values('����','��','201215121',20);
insert into Student(sname,ssex,sno, sage) values('����','Ů','201215122',19);
insert into Student(sname,ssex,sno, sage) values('����','Ů','201215123',18);
insert into Student(sname,ssex,sno, sage) values('����','��','201215125',19);
insert into Student(sname,ssex,sno) values('��ƽ��','��','201215124');
insert into Student(sname,sno, sage) values('��Ӧ','201215126',19);
insert into Student(sname,ssex,sno, sage) values('����',null,'201215129',19);
insert into Student(sname,sno) values('����Ա','admin');
commit;

insert into teacher(tno, tname, salary,post) values('t001', '����', 20000, '����');
insert into teacher(tno, tname, salary,post) values('t002', '����', 12000,'��ʦ');
insert into teacher(tno, tname, salary,post) values('t003', '����', 9600,'��ʦ');
insert into teacher(tno, tname,salary) values('t004', '����',  9800);
insert into teacher(tno, tname,post) values('t005', '����С', '����');
insert into teacher(tno, tname,salary,post) values('t006', '��С��', 25687,'����');
insert into teacher(tno, tname) values('t007', '��è');
insert into teacher(tno, tname,salary) values('t008', '��СС', 8687);

insert into course(cno,cname,ccredit) values('6','���ݴ���',null);
insert into course(cno,cname,ccredit) values('2','��ѧ',null);
insert into course(cno,cname,ccredit) values('7','PASCAL����','6');
insert into course(cno,cname,ccredit) values('5','���ݽṹ','7');
insert into course(cno,cname,ccredit) values('1','���ݿ�','5');
insert into course(cno,cname,ccredit) values('3','��Ϣϵͳ','1');
insert into course(cno,cname,ccredit) values('4','����ϵͳ','6');

insert into sc(sno,cno,grade) values('201215121','1',92);
insert into sc(sno,cno,grade) values('201215121','2',85);
insert into sc(sno,cno,grade) values('201215121','3',88);
insert into sc(sno,cno,grade) values('201215122','2',90);
insert into sc(sno,cno,grade) values('201215122','3',80);
insert into sc(sno,cno,grade) values('201215122','1',96);
insert into sc(sno,cno,grade) values('201215123','1',96);
insert into sc(sno,cno,grade) values('201215124','1',96);
insert into sc(sno,cno) values('201215124','3');

INSERT INTO Tc(tno,cno) VALUES('t002',1);
INSERT INTO Tc(tno,cno) VALUES('t003',2);
INSERT INTO Tc(tno,cno) VALUES('t001',5);
INSERT INTO Tc(tno,cno) VALUES('t008',3);
INSERT INTO Tc(tno,cno) VALUES('t005',6);
INSERT INTO Tc(tno,cno) VALUES('t002',4);
commit;

INSERT INTO LoginUser(userid,usertype,passwd) VALUES('201215121','Admin','admin');
INSERT INTO LoginUser(userid,usertype,passwd) VALUES('admin','Admin','admin');
INSERT INTO LoginUser(userid,usertype) VALUES('201215122','Student');
INSERT INTO LoginUser(userid,usertype) VALUES('201215123','Student');
INSERT INTO LoginUser(userid,usertype) VALUES('201215124','Student');
INSERT INTO LoginUser(userid,usertype) VALUES('201215125','Student');
INSERT INTO LoginUser(userid,usertype) VALUES('201215126','Student');
commit;

DESC Student;
DESC Teacher;
DESC Course;
DESC Sc;
DESC Tc;
DESC LoginUser;

SELECT * FROM Student;
SELECT * FROM Teacher;
SELECT * FROM Course;
SELECT * FROM Sc;
SELECT * FROM Tc;
SELECT * FROM LoginUser;

SELECT * FROM user_constraints;

SELECT * FROM Teacher,Tc,Course WHERE Teacher.tno=tc.tno AND Tc.cno=course.cno;

CREATE OR REPLACE VIEW Courseinfo 
AS 
SELECT Course.cno �γ̺�,cname AS �γ���,COUNT(*) AS ѡ������, ROUND(AVG(COALESCE(grade,0)),3) AS �γ�ƽ���� ,SUM(grade) AS �γ��ܷ�,MAX(Grade) ��߷�,MIN(Grade) ��ͷ�  FROM Course,Sc WHERE Course.cno=Sc.cno GROUP BY Course.cno,cname;

CREATE OR REPLACE FORCE VIEW Studentinfo
AS 
SELECT Student.sno,Student.sname,
(SELECT SUM(grade) FROM Sc WHERE SC.sno=Student.sno) �ܷ�,
(SELECT SUM(ccredit) FROM Sc,Course WHERE Sc.cno=Course.cno AND sno=Student.sno) ��ѧ��
FROM Student;

CREATE OR REPLACE FORCE VIEW Teacherinfo
AS 
SELECT Post AS ְ��,SUM(1) ����,ROUND(AVG(COALESCE(Salary,0)),3) ƽ������,MAX(Salary) AS ��߹���,MIN(Salary) AS ��͹��� FROM Teacher GROUP BY post;

SELECT Post AS ְ��,SUM(1) ����,ROUND(AVG(COALESCE(Salary,0)),3) ƽ������ FROM Teacher GROUP BY post;

SELECT * FROM Teacherinfo;

CREATE VIEW StudentCourse
AS
SELECT Student.sno,Course.cno,Course.cname,ccredit,Sname,grade FROM Course,Student,Sc WHERE Sc.sno=Student.sno AND Course.cno=Sc.cno;

SELECT sno,sname,SUM(ccredit) FROM StudentCourse WHERE grade>60 GROUP BY sno,sname;


SELECT Passwd FROM LoginUser WHERE UserId='admin';
SELECT cno,sname,cname,ccredit,grade FROM StudentCourse;

SELECT * FROM Course WHERE cname LIKE '%' AND Course.cno NOT IN (SELECT cno FROM studentcourse WHERE sno='201215122' ) ;