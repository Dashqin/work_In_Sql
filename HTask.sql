create database Library
use Library

create table Authors(
Id int primary key identity,
Name nvarchar(15) not null,
Surname nvarchar(15) not null
)

insert into Authors values ('Mark','Twain'),('Stephen','King'),('John','Steinbeck')

create table Genre(
Id int primary key identity,
GenreName nvarchar(15) not null
)

insert into Genre values ('Historical'),('Romance'),('Thriller')

create table Books(
Id int primary key identity,
Name nvarchar(35) not null,
GenreId int references Genre(Id),
AuthorId int references Authors(Id)
)

insert into Books values ('Doctor Sleep',1,1),('Tom and Huck',2,2),('East of Eden',3,3)

-----------------------------

select Books.Name 'Kitab',Genre.GenreName 'Janr',Authors.Name 'Yazar' from Books
join Genre on Books.GenreId = Genre.Id
join Authors on Books.AuthorId = Authors.Id

