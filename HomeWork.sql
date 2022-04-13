create database Shirket
use Shirket


create table Mudurler(
Id int primary key,
mudurname nvarchar(25),
surname nvarchar(25),
vezifesi nvarchar(25),
maashi money
)
insert into Mudurler values (1,'Akif','Resulov',N'müdür',1200),(2,'Jhon','Clarke','mudur',1000),(3,'Keyvin','Harington','mudur',800)
create table Shobeler(
Id int primary key,
name nvarchar(25),
ishchisayi int,
yaradilmatarixi datetime,
MudurId int references Mudurler(Id)
)
insert into Shobeler values (1,'a shobesi',15,'02.04.2017',1),(2,'b shobesi',12,'02.05.2017',1),(3,'c shobesi',25,'02.08.2017',2)

create table Ishchiler(
Id int primary key,
name nvarchar(25) not null,
surname nvarchar(25) not null,
vezifesi nvarchar(25) not null,
maashi money,
ShobeId int references Shobeler(Id)
)
insert into Ishchiler values(1,'Saleh','Yasharov','muhasib',2500,1),(2,'Hurriye','Gozelova','reseption',1250,2),(3,'Edalet','Esgerov','developer',1125,2)

------------------------

select name,surname,maashi from Ishchiler where maashi < (select avg(maashi) from Ishchiler)

------------------------

select name,surname,maashi from Ishchiler where maashi > (select avg(maashi) from Mudurler)

------------------------

select name from Ishchiler where ShobeId = (select Id from Shobeler where name='a shobesi')

------------------------
alter table Ishchiler add mudurId int references mudurler(Id)
select name,surname,maashi from Ishchiler where mudurId = (select Id from Mudurler where mudurname ='Akif')