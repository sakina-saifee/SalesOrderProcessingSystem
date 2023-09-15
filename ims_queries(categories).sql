create table categories(

cat_id int primary key identity(1,1) not null,
cat_name nvarchar(255),
cat_isActive tinyint not null

);

create procedure insert_categories
@name  nvarchar(255),
@is_Active tinyint
as
insert into categories(cat_name,cat_isActive) values(@name,@is_Active);

create procedure update_categories
@name  nvarchar(255),
@is_Active tinyint,
@id int
as
update categories
set 
cat_name=@name,
cat_isActive=@is_Active
where cat_id =@id;

create procedure delete_categories
@id int
as
delete from categories where cat_id=@id;

create procedure get_categories_data_info
as
select 
c.cat_id as 'Category ID',
c.cat_name as 'Category Name',
case when (c.cat_isActive=1) then 'Yes' else 'No' end as 'Active_Status'

from categories c 
order by c.cat_name asc;

create procedure get_categories_list
as
select
c.cat_name AS 'Category',
c.cat_id as 'ID'

from categories c
order by c.cat_name asc

create procedure get_categoriesdataLIKE
@data varchar(50)
as
select 
c.cat_id as 'Category ID',
c.cat_name as 'Category Name',
case when (cat_isActive = 1) then 'Yes' else 'No' end as 'Active_Status'
from categories c
where c.cat_id like '%' + @data +'%'
or
c.cat_name like '%' + @data +'%'
or
cat_isActive like '%' + @data +'%'

order by c.cat_name asc;

drop procedure get_categoriesdataLIKE;