CREATE DATABASE bloodbank
use bloodbank

create table newDonor(
Did int NOT NULL IDENTITY(1,1) primary key,
Dname varchar(250) ,
Dage int ,
Dmobile bigint ,
Dgender varchar(25) ,
Dbgroup varchar(250) ,
Daddress varchar(550),
Dcity varchar(50)
)
create table signin(
UserID int  PRIMARY KEY NOT NULL IDENTITY(1,1),
Username varchar(50) NOT NULL,
SPassword varchar(50) NOT NULL)


create table patient (
Pnum int  NOT NULL primary key identity(500,1) ,
Pname varchar(50) NOT NULL,
PAge int NOT NULL ,
Pphone int NOT NULL,
Pgender varchar (50) NOT NULL,
Pbgroupe varchar(5) NOT NULL,
Padress varchar(50),
Pcity varchar(50)
)

create table bloodtransfer (
Bgroup varchar(5) NOT NULL primary key,
Bstock int NOT NULL)


select max(did) from newDonor
select * from newDonor


create table Transfer (
TID int PRIMARY KEY NOT NULL IDENTITY(1,1),
Pname varchar(50) NOT NULL,
Dbgroup varchar(250) NOT NULL)

insert into newDonor(did) values (5);
drop table newDonor
drop table Transfer
select * from signin

