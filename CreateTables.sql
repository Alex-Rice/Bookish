create table users (
	Id int Identity not null primary key,
	Name nvarchar(256)
	);

create table Author (
	Id int Identity not null primary key,
	Name nvarchar(256)
	);

create table books (
	ISBN nvarchar(256) primary key,
	Title nvarchar(256) not null,
	AuthorId int not null,
	copiesLeft int not null
	);

create table transactions(
	BookISBN nvarchar(256) not null,
	UserId int not null,
	DueDate date,
	primary key (BookISBN,UserId)
	);



