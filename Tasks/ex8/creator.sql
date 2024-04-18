  create table Users 
  ( ID int primary key identity(1,1),
  FirstName nvarchar(200) not null,
  LastName nvarchar(200) not null,
  Age Tinyint null,
  IsDeleted bit not null
  )

  select * from Users