create table suppliers(
supplier_id int primary key identity(1,1),
supplier_company nvarchar (100) not null,
supplier_name nvarchar (100) not null,
supplier_phone nvarchar (20)  null,
supplier_nic nvarchar (25) not null
);

--insertion
create procedure insert_supplier
@company nvarchar (100),
@suppname nvarchar (100),
@phone nvarchar (20),
@nic nvarchar (25)
as
insert into suppliers(supplier_company,supplier_name,supplier_phone,supplier_nic)values(@company,@suppname,@phone,@nic);

--updation
create procedure update_supplier
@id int,
@company nvarchar (100),
@suppname nvarchar (100),
@phone nvarchar (20),
@nic nvarchar (25)
as
update suppliers
set
supplier_company=@company,
supplier_name=@suppname,
supplier_phone=@phone,
supplier_nic=@nic
where
supplier_id=@id;

--deletion
create procedure delete_supplier
@id int
as
delete from suppliers where supplier_id=@id;

--retrieval
create procedure search_supplier
@data nvarchar(100)
as
select
s.supplier_id 'Supplier ID',
s.supplier_company as'Company Name',
s.supplier_name as 'Supplier Name',
s.supplier_phone as 'Supplier contact',
s.supplier_nic as 'NIC'
from suppliers s
where s.supplier_id like '%' + @data +'%'
or
s.supplier_company like '%' + @data +'%'
or
s.supplier_name like '%' + @data +'%'
or
s.supplier_phone like '%' + @data +'%'
or
s.supplier_nic like '%' + @data +'%'

order by s.supplier_name asc;

create procedure view_supplier
as
select 
s.supplier_id 'Supplier ID',
s.supplier_company as'Company Name',
s.supplier_name as 'Supplier Name',
s.supplier_phone as 'Supplier contact',
s.supplier_nic as 'NIC'
from suppliers s