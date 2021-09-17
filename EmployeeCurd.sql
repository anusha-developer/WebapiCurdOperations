
Create table Tbl_Employee(
EmployeeId int Identity Primary key,
EmpName varchar(100),
EmpEmailId  Varchar(150),
EmpPhoneno BigInt,
EmpAddress varchar(100));
 
 select * from Tbl_Employee;
 drop table Tbl_Employee;
 insert into Tbl_Employee values('Anusha','anusha@gmail.com',9107764680,'Knr');
  delete from Tbl_Employee where EmployeeId=3;