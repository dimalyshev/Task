drop database task2
create database task2
use task2
go

CREATE TABLE Product (
    Id bigint IDENTITY(1,1) NOT NULL,
    Name nvarchar(100) not null,
    PRIMARY KEY (Id)
);

CREATE TABLE Category (
    Id bigint IDENTITY(1,1) NOT NULL,
    Name nvarchar(100) not null,
    PRIMARY KEY (Id)
);

CREATE TABLE ProductCategory (
    Id int IDENTITY(1,1) NOT NULL,
    ProductId bigint NOT NULL,
    CategoryId bigint NOT NULL,
    PRIMARY KEY (Id),
    
FOREIGN KEY (ProductId) REFERENCES Product(Id),
FOREIGN KEY (CategoryId) REFERENCES Category(Id)

);

CREATE UNIQUE INDEX uidx_prod_cat
ON ProductCategory (ProductId,CategoryId);


insert into Product (name) values
('product #1'),
('product #2'),
('product #3')


insert into Category (name) values
('cat #1'),
('cat #2'),
('cat #3')


insert into ProductCategory (ProductId,CategoryId) values
--(1,1),
(2,1),
(2,2),

(3,1),
(3,2),
(3,3)


select p.name, c.name from product p 
  left join productcategory pc on p.id = pc.productid 
  left join category c on c.id = pc.categoryid