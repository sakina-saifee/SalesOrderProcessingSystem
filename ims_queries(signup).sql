create table signup(
id int identity(1,1) not null,
namee nvarchar(50) not null,
user_namee nvarchar(50) primary key  not null,
user_pass nvarchar(50) not null,
user_phonee nvarchar(50) null,
user_gender nvarchar(50) not null,
user_dob date not null,
);

drop table signup
--insertion
create Procedure signup_insertion   
@signup_name nvarchar(50) , 
@signup_usernamee nvarchar(50),
@signup_pass nvarchar(50),
@signup_gender nvarchar(50) ,
@signup_phone nvarchar(50) ,
@signup_dob nvarchar(50)
as
insert into signup (namee ,user_namee ,user_pass ,user_phonee ,user_gender,user_dob) values(@signup_name , @signup_usernamee ,@signup_pass ,@signup_phone,@signup_gender   ,@signup_dob);

drop procedure signup_insertion   

--updation
create procedure signup_updation
@signup_id int,
@signup_name nvarchar(50) , 
@signup_usernamee nvarchar(50),
@signup_pass nvarchar(50),
@signup_gender  nvarchar(50),
@signup_phone nvarchar(50) ,
@signup_dob nvarchar(50)
as
update signup_ims
set
namee=@signup_name ,
user_namee=@signup_usernamee,
user_pass=@signup_pass,
user_gender=@signup_gender,
user_phone=@signup_phone,
user_dob=@signup_dob
where
user_namee=@signup_usernamee


--deletion
create procedure signup_deletion
@signup_username  nvarchar(50)
as
delete from signup where user_namee=@signup_username;

--search
create procedure signup_search
@data varchar(50)
as
select 
s.namee as 'Name',
s.user_namee as 'Username',
s.user_pass as 'Password',
s.user_phonee as 'Phone',
s.user_gender as 'Gender',
s.user_dob as 'DOB'
from signup s
where 
s.user_namee  like '%' + @data +'%'
or
s.user_pass like '%' + @data +'%'

order by s.user_namee asc;

--to match valules in login form
create procedure get_user_details
@user nvarchar(50),
@pass nvarchar(50)
as
select 
s.id as 'ID',
s.namee as 'Name',
s.user_namee as 'Username',
s.user_pass as 'Password',
s.user_phonee as 'Phone',
s.user_gender as 'Gender',
s.user_dob as 'DOB'
from signup s
where
s.user_namee =@user and s.user_pass=@pass;

select * from  get_user_details

drop procedure get_user_details