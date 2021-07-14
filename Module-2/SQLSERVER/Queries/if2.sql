declare @a int
declare @b int
set @a=10
set @b=20
if @a>@b
begin
print Cast(@a as varchar(20))+ ' Is Bigger'
print Cast(@b as varchar(20))+ ' Is Smaller'
end
else
begin
print Cast(@b as varchar(20))+ ' Is Bigger'
print Cast(@a as varchar(20))+ ' Is Smaller'
end