CREATE DATABASE Assignmentdb1;
USE Assignmentdb1;
CREATE TABLE Orders(
firstname varchar(50) not null primary key,
lastname varchar(50) not null,
noOfTyres int not null);

INSERT INTO Orders(firstname, lastname,noOfTyres)
VALUES('john','smith',2);