use[study3]
go


IF OBJECT_ID('course') IS NOT NULL
DROP TABLE course
GO	

IF OBJECT_ID('category') IS NOT NULL
DROP TABLE category
GO

IF OBJECT_ID('lecture') IS NOT NULL
DROP TABLE lecture
GO

CREATE TABLE lecture(
id varchar(10),
name varchar(50),
gender varchar(5),
phone int,
email varchar(50),

CONSTRAINT pk_lecture_id PRIMARY KEY(id)
)
GO

CREATE TABLE category(
id varchar(10),
name varchar(20),
[description] varchar(100),

CONSTRAINT pk_category_id PRIMARY KEY(id)
)
GO

CREATE TABLE course(
id varchar(10),
name varchar(50),
lecture_id varchar(10),
category_id varchar(10),
[description] varchar(100),
prerequisite varchar(10),
semester varchar(10),

CONSTRAINT pk_course_id PRIMARY KEY(id),
CONSTRAINT fk_course_lecture_id FOREIGN KEY(lecture_id) REFERENCES lecture(id),
CONSTRAINT fk_course_category_id FOREIGN KEY(category_id) REFERENCES category(id),
CONSTRAINT fk_course_prerequisite FOREIGN KEY(prerequisite) REFERENCES course(id),
)
GO


select*from course
select*from lecture
select*from category