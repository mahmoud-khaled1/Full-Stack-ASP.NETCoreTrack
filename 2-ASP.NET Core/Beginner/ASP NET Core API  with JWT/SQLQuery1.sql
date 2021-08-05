use BookStoreAPi;

create table Books(
BookId int identity(1,1) primary key ,
BookName nvarchar(50) not null ,
BookCategory nvarchar(50) ,
BookAuthor nvarchar(100),
BookPrice decimal not null,
BookQuantity int not null
);

create table Userr(
UserId int identity(1,1) primary key ,
UserFirstName nvarchar(50) not null ,
UserLastName nvarchar(50) ,
UserEmail nvarchar(100),
UserPassword nvarchar(100) not null,
UserCreateDate DateTime Default(GetDate()) not null
);

insert into Userr(UserFirstName,UserLastName,UserEmail,UserPassword)
values ('mahmoud','khaled','mahmoudkhaled01020@gmail.com','01020795015')

insert into Userr(UserFirstName,UserLastName,UserEmail,UserPassword)
values ('waleed','khaled','waleed54@gmail.com','waleeed8788')

insert into Userr(UserFirstName,UserLastName,UserEmail,UserPassword)
values ('tarek','aly','tarek5454@gmail.com','tarekk54545')

insert into Userr(UserFirstName,UserLastName,UserEmail,UserPassword)
values ('tamer','kamel','asde24@gmail.com','25454asas')

insert into Books(BookName ,BookCategory  ,BookAuthor ,BookPrice ,BookQuantity )
values('C# Foundmentals','programming language','Afifi Aly',200,40)

insert into Books(BookName ,BookCategory  ,BookAuthor ,BookPrice ,BookQuantity )
values('Data Structure and algorithms','programming language concept','John werd',300,10)

insert into Books(BookName ,BookCategory  ,BookAuthor ,BookPrice ,BookQuantity )
values('DataBase Foundmentals','DataBase','Alice sdfg',500,23)


select * from Books;
 
select * from Userr;