create database imsdb

use imsdb;

create table users(

usr_id int not null identity primary key,
usr_namee nvarchar(40) not null,
usr_username nvarchar(30) not null,
usr_pass nvarchar(30) not null,
usr_phone nvarchar(15) not null,
usr_mail nvarchar(50) not null,
usr_status tinyint not null default 1

);

drop table users;

--for insertion
create procedure st_insertUsers
@name nvarchar(40),
@username nvarchar(30),
@pwd  nvarchar(15),
@phone nvarchar(15),
@mail nvarchar(50)
as
insert into users(usr_namee,usr_username,usr_pass,usr_phone,usr_mail) values(@name,@username,@pwd,@phone,@mail);

--for updation
create procedure st_updationUsers
@name nvarchar(40),
@username nvarchar(30),
@pwd  nvarchar(15),
@phone nvarchar(15),
@mail nvarchar(50),
@id int
as
update users 
set
usr_namee=@name,
usr_username=@username,
usr_pass=@pwd,
usr_phone=@phone,
usr_mail=@mail
where
usr_id = @id;

--for deletion
create procedure st_deleteUsers
@id int
as
delete from users where usr_id = @id;

create procedure get_usersdata
as
select 
u.usr_id as 'ID',
u.usr_namee as 'Name',
u.usr_username as 'Username',
u.usr_pass as 'Password',
u.usr_phone as 'Phone',
u.usr_mail as 'Mail',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status'
from users u
order by u.usr_username asc;

Exec get_usersdata