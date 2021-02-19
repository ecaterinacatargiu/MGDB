create database MiniFacebook
use MiniFacebook
go



create table Users(
	userID int primary key identity(1,1),
	userName varchar(255),
	userCity varchar(255),
	userDob varchar(255)
)

create table Categories(
	categoryID int primary key identity(1,1),
	categoryName varchar(255),
	categoryDescription varchar(255)
)


create table Pages(
	pageID int primary key identity(1,1),
	pageName varchar(255),
	categoryID int foreign key references Categories(categoryID)
)

create table Likes(
	userID int references Users(userID),
	pageID int references Pages(pageID),
	likeDate varchar(255),
	constraint likeID primary key(userID, pageID)
)

create table Posts(
	postID int primary key identity(1,1),
	postDate varchar(255),
	postText varchar(255),
	postShares int,
	userID int foreign key references Users(userID)
)


create table Comments(
	commentID int primary key identity(1,1),
	commentDate Date,
	commentText varchar(255),
	commentFlag bit,
	postID int foreign key references Posts(postID)
)

insert Users values('Cati', 'Suceava', '2010-10-10'), ('Andreea', 'Bucuresti', '1998-10-10')
insert Categories values('Category1', 'fabulous'), ('Category2', 'aw3some')
insert Pages values('Page1', 1), ('Page2', 1)
insert Likes values(1,1,'2/21/2020'), (1,2,'16/7/2020'), (2,1, '12/3/2017')
insert Posts values ('1/1/2018', 'Post1', 3, 1), ('3/23/2018', 'Post2',5, 2)
insert Comments values ('6/8/2019','damn', 1,1), ('6/9/2017', 'damn u nice af', 0,2)select * from Users
select * from Categories
select * from Pages
select * from Likes
select * from Posts
select * from Comments

