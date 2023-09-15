create procedure get_user_login_details 
@user nvarchar(30),
@pass nvarchar(30)
as
select
u.usr_id as 'ID',
u.usr_namee as 'Name',
u.usr_username as 'User Name',
u.usr_pass as 'Password'
from users u
where 
u.usr_username=@user 
and
u.usr_pass=@pass;