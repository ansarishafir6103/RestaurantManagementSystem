
create procedure SP_getTaxId
@type varchar(10)
as
select from tax t where t.

create procedure SP_getOrderReport
as
begin
select 
from orders o
inner join orderDetails od
on o.o_id=od.od_orderID
inner join
end




create table tax
(
tax_id tinyint not null identity primary key,
tax_value float not null,
tax_type varchar(10) not null
)

create proc SP_taxInsert
@value float,
@type varchar(10)
as
begin
insert into tax(tax_value,tax_type)values(@value,@type)
end

create proc SP_taxUpdate
@taxID tinyint,
@value float,
@type varchar(10)
as
begin
update tax set tax_value=@value,tax_type=@type where tax_id=@taxID
end

create proc SP_taxDelete
@taxID tinyint
as
begin
delete from tax where tax_id=@taxID
end

create proc SP_taxSelectAll
as
begin
select 
t.tax_id as 'taxID',
t.tax_type as 'taxType',
t.tax_value as 'taxValue'
from tax t
end


alter procedure SP_getOrderDetailsWRTTable
@tableID smallint
as
begin
select
o.o_id as 'order ID',
o.o_totalAmount as 'total Amount',
o.o_floorId as 'floor ID',
o.o_tableId as 'table ID',
m.m_name as 'item',
m.m_id as 'item ID',
od.od_qty as 'quantity',
od.od_qty*m.m_price as 'price',
m.m_price as 'per Item Price'
from orders o
inner join orderDetails od
on o.o_id=od.od_orderID
inner join floors f
on f.f_id=o.o_floorId
inner join Tables t
on t.t_id=o.o_tableId
inner join FoodMenu m
on m.m_id=od.od_foodMenuID where t.t_id=@tableID
end

select * from  orders
select * from  orderDetails
select * from FoodMenu

truncate table orders
truncate table  orderDetails
add od_qty tinyint


create procedure SP_getPendingOrders
as
begin
select o.o_id as 'orderID',
case when (o.o_status=0) then 'pending' else
case when (o.o_status=1) then 'served' else
case when (o.o_status=2)then 'completed' end end end as 'Status' 
from orders o
order by o.o_id asc
end

create procedure SP_getOrderDetails
@orderID 
as
begin
select 
m.m_name as 'item',
od.
from orderDetails od
inner join FoodMenu m 
on od.od_foodMenuID=m.m_id
where od.od_orderID=
end

create procedure SP_checkTableBusyFree
@tableID smallint,
@floorID tinyint
as
begin
select o.o_id as 'ID' from orders o
inner join floors f
on o.o_floorId=f.f_id 
inner join Tables t 
on f.f_id=t.t_floorid
where o.o_floorId=3
and o.o_tableId=6
and (o.o_status=0 or o.o_status=1)
end

select * from orders


create  procedure SP_getCategoryWRTItem
@mname varchar(50)
as
begin
select 
c.c_id as 'cid',
c.c_name as 'cname'
from FoodMenu m
inner join Categories c
on c.c_id=m.m_catID
where m.m_name=@mname
end

create procedure SP_getLastOrderId
as
select top 1 o.o_id from orders o order by o.o_id desc

select * from orders-- truncate table orders
select * from orderDetails-- truncate table orderDetails


delete from orders --this is use for trancate table which have foreign key
desc checkident('orders',reseed,0)

truncate table roles
truncate table users
truncate table customers
truncate table floors
truncate table Tables
truncate table Categories
truncate table FoodMenu






use Db_RestaurantManagementSystem

--drop table roles
--drop table users
create table roles
(
r_id tinyint not null identity primary key,
r_name varchar(30)not null
);

create table users
(
u_id int not null primary key identity,
u_name varchar(30)not null,
u_uname varchar(30)not null unique,
u_password varchar(30)not null,
u_phone varchar(15)not null,
u_address varchar(100) not null,
u_roleId tinyint not null foreign key references roles(r_id)on delete cascade on update cascade
);
--drop proc SP_rolesUpdate

create proc SP_rolesInsert
(@r_name varchar(30))
as
begin
insert into roles (r_name)values(@r_name);
end

create proc SP_rolesUpdate
(@r_id tinyint,@r_name varchar(30))
as
begin
update roles set r_name=@r_name where r_id=@r_id 
end

drop proc SP_rolesDelete

create proc SP_rolesDelete
(@r_id tinyint)
as
begin
delete from roles where r_id=@r_id
end

create proc SP_rolesSelectAll
as
begin
select * from roles
end

create proc SP_rolesSelectbyid
(@r_id tinyint)
as
begin
select * from roles where r_id=@r_id
end


--create procedure

--insert
create procedure SP_usersInsert
(
--u_id
@u_name varchar(40),
@u_uname varchar(40),
@u_password varchar(40),
@u_phone varchar(15),
@u_address varchar(200),
@u_roleId tinyint
)
as
begin 
insert into users(u_name,u_uname,u_password,u_phone,u_address,u_roleId) values(@u_name,@u_uname,@u_password,@u_phone,@u_address,@u_roleId)
end
--update
create procedure SP_usersUpdate
(
@u_id int,
@u_name varchar(40),
@u_uname varchar(40),
@u_password varchar(40),
@u_phone varchar(15),
@u_address varchar(200),
@u_roleId tinyint
)
as
begin 
update users set u_name=@u_name,u_uname=@u_uname,u_password=@u_password,u_phone=@u_phone,u_address=@u_address,u_roleId=@u_roleId where u_id=@u_id
end

--delete
create procedure SP_usersUpdate
(
@u_id int,
@u_name varchar(40),
@u_uname varchar(40),
@u_password varchar(40),
@u_phone varchar(15),
@u_address varchar(200),
@u_roleId tinyint
)
as
begin 
update users set u_name=@u_name,u_uname=@u_uname,u_password=@u_password,u_phone=@u_phone,u_address=@u_address,u_roleId=@u_roleId where u_id=@u_id
end


--create table customer

create table customers
(
c_id bigint identity primary key,
c_name varchar(50),
c_phone varchar(15)not null,
c_address varchar(100)
)


--create procedure

create procedure SP_customersInsert
(
@c_name varchar(50),
@c_phone varchar(15),
@c_address varchar
)
as
begin
insert into customers (c_name,c_phone,c_address)values(@c_name,@c_phone,@c_address)
end

create procedure SP_customersUpdate
(
@c_id bigint,
@c_name varchar(50),
@c_phone varchar(15),
@c_address varchar
)
as
begin
update customers set c_name=@c_name,c_phone=@c_phone,c_address=@c_address where c_id=@c_id
end

drop table customers
drop procedure customersUpdate
drop procedure customersInsert
drop procedure customersDelete


create procedure SP_customersDelete 
(
@c_id bigint
)
as
begin
delete from customers where c_id=@c_id
end

create procedure [dbo].[SP_customersSelectAll]
as
begin
select
c_id as 'Customer ID',
c_name as 'Name',
c_phone as 'Phone',
c_address as 'Address'
from customers order by c_name asc
end

create table floors
(
f_id tinyint not null identity primary key,
f_name varchar(20) not null,
f_number tinyint not null unique,
)

create table Tables
(
t_id smallint not null identity primary key,
t_number smallint not null unique,
t_chair tinyint not null,
t_floorid tinyint not null foreign key references floors(f_id) on delete cascade on update cascade
)

create procedure SP_floorsInsert
(
@f_name varchar(20),
@f_number tinyint
)
as
begin
insert into floors (f_name,f_number)values(@f_name,@f_number);
end

create procedure SP_floorsUpdate
(
@f_id tinyint,
@f_name varchar(20),
@f_number tinyint
)
as
begin
update floors set f_name=@f_name,f_number=@f_number where f_id=@f_id
end


create procedure SP_floorsDelete
(
@f_id tinyint
)
as
begin
delete from floors where f_id=@f_id
end

alter procedure SP_floorsSelectAll
as
begin
select 
f_id as 'FloorID',
f_name as 'FloorName',
f_number as 'FloorNumber'
from floors 
end


create procedure SP_TablesInsert
(
@t_number smallint,
@t_chair tinyint,
@t_floorid tinyint
)
as
begin
insert into Tables (t_number,t_chair,t_floorid)values(@t_number,@t_chair,@t_floorid)
end

create procedure SP_TablesUpdate
(
@t_id smallint,
@t_number smallint,
@t_chair tinyint,
@t_floorid tinyint
)
as
begin
update Tables set t_number=@t_number,t_chair=@t_chair,t_floorid=@t_floorid where t_id=@t_id
end

create procedure SP_TablesDelete
(
@t_id smallint
)
as
begin
delete from Tables where t_id=@t_id
end

alter procedure SP_TablesSelectAll
as
begin
select 
t_id as 'TableID',
t_number as 'TableNumber',
t_chair as 'TableChair',
t_floorid as 'TableFloorID',
f.f_number as 'FloorNumber',
f.f_name as 'FloorName'
from Tables t
inner join floors f on t.t_floorid=f.f_id 
end


select * from floors


create table Categories
(
c_id int not null identity primary key,
c_name varchar(50) not null unique
);


create procedure SP_categoriesInsert
@c_name varchar(50)
as
begin
insert into Categories (c_name)values (@c_name)
end

create procedure SP_categoriesUpdate
@c_id int,
@c_name varchar(50)
as
begin
update Categories set c_name=@c_name where c_id=@c_id
end

create procedure SP_categoriesDelete
@c_id int
as
begin
delete from Categories where c_id=@c_id
end

create procedure SP_categoriesSelectAll
as
begin
select
c_id as 'CatID',
c_name as 'CatName'
from Categories
end

truncate table Categories

create procedure SP_getUserForAuthentication
(
@username varchar(30),
@password varchar(30)
)
as
begin
select
u_id as 'User ID',
u_name as 'Name',
u_uname as 'Username',
u_password as 'Password',
u_phone as 'Phone',
u_address as 'Address',
u_roleId as 'Role ID',
r.r_name as 'Role'
from users u
inner join roles r 
on r.r_id=u.u_roleId 
where u.u_uname=@username and u.u_password=@password
end
	
create table FoodMenu
(
m_id int not null identity primary key,
m_name varchar(50),
m_catID int not null foreign key references Categories(c_id) on delete cascade on update cascade,
m_price money,
m_status tinyint
)

create proc SP_FoodMenuInsert
(
@m_name varchar(50),
@m_catID int,
@m_price money,
@m_status tinyint
)
as
begin
insert into FoodMenu (m_name,m_catID,m_price,m_status)values(@m_name,@m_catID,@m_price,@m_status)
end


create proc SP_FoodMenuUpdate
(
@m_id int,
@m_name varchar(50),
@m_catID int,
@m_price money,
@m_status tinyint
)
as 
begin
update FoodMenu set m_name=@m_name,m_catID=@m_catID,m_price=@m_price,m_status=@m_status
end

create proc SP_FoodMenuDelete
@m_id int
as
begin
delete from FoodMenu where m_id=@m_id
end

alter proc SP_FoodMenuSelectAll
as
begin
select 
m_id as 'MenuID',
m_name as 'MenuItem',
m_price as 'Price',
case when(m_status=1) then 'Available' else 'Not Available' end as 'Status',
c.c_id as 'CategoryID',
c.c_name as 'Category'
from FoodMenu m
inner join Categories c on c.c_id=m.m_catID
order by c.c_name asc
end 


alter proc SP_FoodMenuSelectByCategory
@cid int
as
begin
select 
m_id as 'MenuID',
m_name as 'MenuItem',
m_price as 'Price',
case when(m_status=1) then 'Available' else 'Not Available' end as 'Status',
c.c_id as 'CategoryID',
c.c_name as 'Category'
from FoodMenu m
inner join Categories c on c.c_id=m.m_catID
where c.c_id=@cid
order by c.c_name asc
end 

select * from FoodMenu

sp_help orders


alter table FoodMenu
add m_image image not null

create proc SP_getPriceWRTItem
@m_id int
as
begin
select m.m_price as 'Price' from FoodMenu m where m.m_id=@m_id
end

Create procedure SP_getTablesWRTfloor
@f_id int
as
begin
select 
t_id as 'TableID',
t_number as 'TableNumber'
from Tables t
inner join floors f on t.t_floorid=f.f_id  
where t_floorid=@f_id
end


create table orders
(
o_id bigint not null identity primary key,
o_date date not null,
o_custID bigint not null,
o_orderType tinyint not null,
o_floorId tinyint,
o_tableId smallint,
o_totalAmount money,
o_amountPaid money,
o_amountReturn money,
o_status tinyint not null --0 pending,1 complete,2 cancelled
)

create table orderDetails
(
od_id bigint not null identity primary key,
od_orderID bigint not null,
od_foodMenuID int not null
)




tinyint


money

alter procedure SP_orderInsert
(
@o_date date,
@o_custID bigint,
@o_orderType tinyint,
@o_floorId tinyint,
@o_tableId smallint,
@o_totalAmount money,
@o_amountPaid money,
@o_amountReturn money,
@o_status tinyint
)
as
begin
insert 
into
orders
(o_date,o_custID,o_orderType,o_floorId,o_tableId,o_totalAmount,o_amountPaid,o_amountReturn,o_status)
 values 
 (@o_date,@o_custID,@o_orderType,@o_floorId,@o_tableId,@o_totalAmount,@o_amountPaid,@o_amountReturn,@o_status)
end

alter procedure SP_orderUpdate
(
@o_id bigint,
@o_date date,
@o_custID bigint,
@o_orderType tinyint,
@o_floorId tinyint,
@o_tableId smallint,
@o_totalAmount money,
@o_amountPaid money,
@o_amountReturn money,
@o_status tinyint
)
as
begin
update
orders set o_date=@o_date,o_custID=@o_custID,o_orderType=@o_orderType,o_floorId=@o_floorId,o_tableId=@o_tableId,o_totalAmount=@o_totalAmount,o_amountPaid=@o_amountPaid,o_amountReturn=@o_amountReturn,o_status=@o_status where o_id=@o_id
end


create procedure SP_orderDelete
(
@o_id bigint
)
as
begin
delete from orders where o_id=@o_id
end

sp_help orderDetails

create procedure SP_orderDetailsInsert
@od_orderID bigint,
@od_foodMenuID int
as
begin
insert into orderDetails(od_orderID,od_foodMenuID) values (@od_orderID,@od_foodMenuID)
end

create procedure SP_orderDetailsUpdate
@od_id bigint,
@od_orderID bigint,
@od_foodMenuID int
as
begin
update orderDetails set od_orderID=@od_orderID,od_foodMenuID=@od_foodMenuID where od_id=@od_id
end

create procedure SP_orderDetailsDelete
@od_id bigint
as
begin
delete from ordes where od_id=@od_id
end

alter proc SP_getCustomerIdWRTPhone
@Phone varchar(15)
as
begin
select
c.c_id as 'CustomerID',
c.c_name as 'Name',
c.c_address as 'Address'
from
customers c 
where c.c_phone=@phone
end

select * from customers


create table bill
(
bill_id bigint not null identity primary key,
bill_tblID smallint,
bill_amount float
)





