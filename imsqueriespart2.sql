create procedure get_usersdataLIKE
@data varchar(50)
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
where u.usr_id like '%' + @data +'%'
or
u.usr_namee like '%' + @data +'%'
or
u.usr_username like '%' + @data +'%'
or
u.usr_pass like '%' + @data +'%'
or
u.usr_phone like '%' + @data +'%'
or
u.usr_mail like '%' + @data +'%'
order by u.usr_username asc;