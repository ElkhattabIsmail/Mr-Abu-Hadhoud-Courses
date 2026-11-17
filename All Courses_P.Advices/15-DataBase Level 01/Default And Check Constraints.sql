
use Db3;

create database Db3;

create table Identifer_Card
(
	ID int not null primary key,
	FirstName varchar(250) not null,
	LastName varchar (250) not null,
	age int check (age >= 20),
	city varchar(255) default 'F.B.S'
);