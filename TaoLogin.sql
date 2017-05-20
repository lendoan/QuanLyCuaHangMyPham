create proc Tao_Login
@LogName nvarchar(50),
@Pass nvarchar(50),
@Username nvarchar(50),
@Role nvarchar(50)
as
declare @Ret int
exec @Ret = sp_addlogin @LogName,@Pass,'QuanLyCuaHangMP'
if(@Ret=1)
return 1
exec @Ret = sp_grantdbaccess @LogName,@Username

if(@Ret=1)
begin
	exec sp_droplogin @LogName
	return 2
	
end
if(@Role = 'QuanLy')
begin
exec sp_addsrvrolemember @LogName, 'SecurityAdmin'
exec sp_addsrvrolemember @LogName, 'DBCreator'
exec sp_addsrvrolemember @LogName ,'ProcessAdmin'
exec sp_addrolemember 'QuanLy',@Username

end
else
begin
exec sp_addsrvrolemember @LogName, 'SecurityAdmin'
exec sp_addrolemember 'NhanVien',@Username
end
return 0


