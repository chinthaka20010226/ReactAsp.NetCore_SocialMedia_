Create Database SocialNetwork

Use SocialNetwork

Create Table Registration(
Id int primary key identity(1,1) not null,
Name varchar(50) null,
Email varchar(50) null,
Password varchar(20) null,
PhoneNo varchar(20) null,
IsActive int null,
IsApproved int null
)

Create Table Article(
Id int primary key identity(1,1) not null,
Title varchar(50) null,
Content varchar(max) null, 
Email varchar(50) null,
Image varchar(50) null,
IsActive int null,
IsApproved int null
)

Create Table News(
Id int primary key identity(1,1) not null,
Title varchar(50) null,
Content varchar(max) null,
Email varchar(50) null,
IsActive int null,
CreatedOn datetime
)

Create Table Event(
Id int primary key identity(1,1) not null,
Title varchar(50) null,
Content varchar(max) null,
Email varchar(50) null,
IsActive int null,
CreatedOn datetime
)

Select *
From Registration

Select *
From Article

Select *
From News

Select *
From Event