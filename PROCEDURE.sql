CREATE PROC DONOR
@Did int,
@Dname varchar(250),
@Dage int,
@Dmobile bigint,
@Dgender varchar(25),
@Dbgroup varchar(250),
@Daddress varchar(550),
@Dcity varchar(50)
AS
 IF @Did = 0
 INSERT INTO newDonor(Dname,Dage,Daddress,Dbgroup,Dcity,Dgender,Dmobile)
 VALUES (@Dname,@Dage,@Daddress,@Dbgroup,@Dcity,@Dgender,@Dmobile)
 ELSE 
 UPDATE newDonor
 SET 
 Dname = @Dname,
 Dage = @Dage,
 Daddress = @Daddress,
 Dbgroup = @Dbgroup,
 Dmobile = @Dmobile,
 Dcity = @Dcity,
 Dgender = @Dgender
 WHERE Did = @Did