create table products(

prod_id int primary key identity (1,1) not null,
prod_name nvarchar(100) not null,
prod_barcode nvarchar(150) not null,
prod_expiry date null,
prod_price money not null,

fk_cat_id int foreign key references categories(cat_id)


);

--insertion
create procedure st_insertProducts
@p_name nvarchar(100),
@p_barcode nvarchar(150),
@p_expiry date,
@p_price money,
@catID int
as
insert into products(prod_name,prod_barcode,prod_expiry,prod_price,fk_cat_id) values(@p_name,@p_barcode,@p_expiry,@p_price,@catID);

--updation
create procedure st_updateProducts
@p_id int,
@p_name nvarchar(100),
@p_barcode nvarchar(150),
@p_expiry date,
@p_price money,
@catID int
as
update products
set 
prod_name=@p_name,
prod_barcode=@p_barcode,
prod_expiry=@p_expiry,
prod_price=@p_price,
fk_cat_id=@catID
where 
prod_id=@p_id;

--deletion

create procedure st_deleteProducts
@p_id int
as
delete from products where prod_id=@p_id;

--retrieval

create procedure st_viewProducts
as
select 
p.prod_id as 'Product ID',
p.prod_name as 'Product Name',
p.prod_barcode as 'Product Barcode',
format (p.prod_expiry, 'dd-MMM-yyyy')as 'Product Expiry',
p.prod_price as 'Product Price',
c.cat_id as 'Category ID',
c.cat_name as 'Category Name'

from Products p
inner join categories c 
on c.cat_id =p.prod_id
order by prod_name asc;

--searching
create procedure st_searchProducts
@data varchar(50)
as
select 
p.prod_id as 'Product ID',
p.prod_name as 'Product Name',
p.prod_barcode as 'Product Barcode',
p.prod_expiry as 'Product Expiry',
p.prod_price as 'Product Price'

from products p
where p.prod_id like '%' + @data +'%'
or
p.prod_name like '%' + @data +'%'
or
p.prod_barcode like '%' + @data +'%'
or
p.prod_expiry like '%' + @data +'%'
or
p.prod_price like '%' + @data +'%'

order by p.prod_name asc;

drop procedure st_viewProducts