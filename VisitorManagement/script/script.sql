USE [master]
GO
/****** Object:  Database [visitor]    Script Date: 3/21/2017 16:49:12 ******/
CREATE DATABASE [visitor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'visitor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\visitor.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'visitor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\visitor_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [visitor] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [visitor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [visitor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [visitor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [visitor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [visitor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [visitor] SET ARITHABORT OFF 
GO
ALTER DATABASE [visitor] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [visitor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [visitor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [visitor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [visitor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [visitor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [visitor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [visitor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [visitor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [visitor] SET  DISABLE_BROKER 
GO
ALTER DATABASE [visitor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [visitor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [visitor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [visitor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [visitor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [visitor] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [visitor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [visitor] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [visitor] SET  MULTI_USER 
GO
ALTER DATABASE [visitor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [visitor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [visitor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [visitor] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [visitor]
GO
/****** Object:  Table [dbo].[BlockVisitor]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BlockVisitor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fk_visitor] [int] NULL,
	[IsBlock] [bit] NULL DEFAULT ((1)),
	[Reason] [varchar](100) NULL,
	[ActionTaken] [varchar](100) NULL,
	[Fk_User] [int] NULL,
	[dateon] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Buildings]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buildings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Complain]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Complain](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fk_Flats] [int] NULL,
	[IsIssueResolved] [bit] NULL DEFAULT ((1)),
	[Complain] [varchar](100) NULL,
	[Solution] [varchar](100) NULL,
	[Fk_User] [int] NULL,
	[dateon] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Flats]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Flats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Owner] [varchar](100) NULL,
	[FK_Buildings] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[isAdmin] [bit] NULL DEFAULT ((0)),
	[Name] [varchar](100) NULL,
	[PhoneNo] [varchar](10) NULL,
	[Address] [varchar](100) NULL,
	[AdminKey] [varchar](100) NULL,
	[IsLogin] [bit] NULL DEFAULT ((0)),
	[LoggedInDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[visitor]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[visitor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[GovnNo] [varchar](100) NULL,
	[GovnIdName] [varchar](100) NULL,
	[PhoneNo] [varchar](10) NULL,
	[Gender] [bit] NULL,
	[name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[visitor_history]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[visitor_history](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FromPlace] [varchar](500) NULL,
	[Fk_Flats] [int] NULL,
	[OnDate] [datetime] NULL,
	[reason] [varchar](500) NULL,
	[Fk_Visitor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BlockVisitor]  WITH CHECK ADD FOREIGN KEY([Fk_User])
REFERENCES [dbo].[tblUser] ([id])
GO
ALTER TABLE [dbo].[BlockVisitor]  WITH CHECK ADD FOREIGN KEY([Fk_visitor])
REFERENCES [dbo].[visitor] ([id])
GO
ALTER TABLE [dbo].[Complain]  WITH CHECK ADD FOREIGN KEY([Fk_Flats])
REFERENCES [dbo].[Flats] ([id])
GO
ALTER TABLE [dbo].[Complain]  WITH CHECK ADD FOREIGN KEY([Fk_User])
REFERENCES [dbo].[tblUser] ([id])
GO
ALTER TABLE [dbo].[Flats]  WITH CHECK ADD FOREIGN KEY([FK_Buildings])
REFERENCES [dbo].[Buildings] ([id])
GO
ALTER TABLE [dbo].[visitor_history]  WITH CHECK ADD FOREIGN KEY([Fk_Flats])
REFERENCES [dbo].[Flats] ([id])
GO
ALTER TABLE [dbo].[visitor_history]  WITH CHECK ADD FOREIGN KEY([Fk_Visitor])
REFERENCES [dbo].[visitor] ([id])
GO
/****** Object:  StoredProcedure [dbo].[bcedit]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[bcedit](@id int,@fk_visitor int,@isblock bit,@reason varchar(100),@actiontaken varchar(100),@fk_user varchar(100),@request varchar(100))
as

begin
if(@request='insert')
	begin
	   insert into blockvisitor(fk_visitor,isblock,reason,actiontaken,fk_user)
	   values(@fk_visitor,@isblock,@reason,@actiontaken,(select top 1 id from tbluser where username= @fk_user))
	end
	if(@request='update')
	begin
		update blockvisitor set  isblock=@isblock,reason=@reason,actiontaken=@actiontaken,fk_user=(select top 1 id from tbluser where username= @fk_user)
		where fk_visitor=@fk_visitor
	end

end


 

GO
/****** Object:  StoredProcedure [dbo].[blockvisitordetails]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[blockvisitordetails](@request varchar(100),@id int,@tilldate datetime =null)
as
begin
 if(@request='details')
	begin
		select 	v.id ,v.GovnNo,	v.GovnIdName,	v.PhoneNo,	  Gender,	v.name ,
			bv.isblock,bv.reason,bv.actiontaken
		from visitor v
		join blockvisitor bv on bv.fk_visitor=v.id 
		where bv.id=@id
	end
	else  if(@request='list')
	 begin
		 select bv.id,v.name,v.phoneno,bv.isblock,bv.reason,bv.actionTaken 
		 ,tu.username as byuser,bv.dateon
		 from blockvisitor bv
		 join visitor v on v.id=bv.fk_visitor
		 join tbluser tu on tu.id=bv.fk_user
		 where dateon<=@tilldate
		 order by v.name
	end
end
GO
/****** Object:  StoredProcedure [dbo].[blockvisitorSearch]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[blockvisitorSearch](@govnno varchar(100),@govnidname varchar(100)) 
as
begin

select 	id,GovnNo,	GovnIdName,	PhoneNo,	 case Gender when 0 then 'M' else 'F' end as Gender,	name from visitor v
where govnno=@govnno and govnidname=@govnidname


end
GO
/****** Object:  StoredProcedure [dbo].[complaindetails]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[complaindetails](@request varchar(100),@id int,@dateon datetime =null)
as
begin
  if(@request='list')
	begin
		 select c.id,c.complain,c.solution 
		 ,tu.username,c.isissueresolved as IssueResolved,f.Name as flatname,
		 b.Name as buildingname 
		 from complain c 
		 join Flats f on f.id=c.fk_flats
		 join Buildings b on b.id=f.FK_Buildings
		 join tbluser tu on tu.id=c.fk_user
		 where c.dateon<=@dateon
		 
	end
	else if(@request='single')
	begin
		 select c.id,c.complain,c.solution,c.fk_flats,f.FK_Buildings
		 ,tu.username,c.isissueresolved as IssueResolved,f.Name as flatname,
		 b.Name as buildingname 
		 from complain c 
		 join Flats f on f.id=c.fk_flats
		 join Buildings b on b.id=f.FK_Buildings
		 join tbluser tu on tu.id=c.fk_user
		 where c.id=@id


	end

end
GO
/****** Object:  StoredProcedure [dbo].[complainsave]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[complainsave](@id int,@fk_flats int ,@complain varchar(100),@solution varchar(100),@isIssueResolved bit,@fk_user varchar(100),@requestType varchar(100))
as 
begin
	if(@RequestType='insert')
	begin
		insert into complain (fk_flats,isissueresolved,complain,solution,fk_user)
		values(@fk_flats,@isIssueResolved,@complain,@solution,(select top 1 id from tbluser where username= @fk_user))
	end
	else if(@RequestType='update')
	begin
		update complain set solution=@solution,complain=@complain,isissueresolved=@isissueresolved where id=@id
	end
end

GO
/****** Object:  StoredProcedure [dbo].[GetSearchList]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	
CREATE proc [dbo].[GetSearchList]
(
@FromDate datetime,
@ToDate datetime
)as 
begin

select v.name,v.PhoneNo,v.GovnIdName as IdName,v.GovnNo,case v.Gender when 0 then 'M' else 'F' end as Gender,
vh.FromPlace,b.Name+' '+ f.Name as FlatName,vh.reason,vh.OnDate
 from visitor_history vh
join visitor v on v.id=vh.Fk_Visitor
join Flats f on f.id=vh.Fk_Flats 
join Buildings b on b.id=f.FK_Buildings
where OnDate between @FromDate and @ToDate



end
GO
/****** Object:  StoredProcedure [dbo].[GetSearchRecord]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetSearchRecord]
(
@vc int,
@vq varchar(100),
@Fid int
)
as
begin

	select @vq=case @vq when '' then ' ' else @vq end
	 
	declare @param varchar(100)=''
	declare @query varchar(1000)=null
	select @param= case @vc when 1 then 'v.name' when 2 then 'v.PhoneNo' else 'v.GovnNo' end

	set @query='select v.name,v.PhoneNo,v.GovnIdName as IdName,v.GovnNo,case v.Gender when 0 then ''M'' else ''F'' end as Gender,
	vh.FromPlace,b.Name+'' ''+ f.Name as FlatName,vh.reason,vh.OnDate
	 from visitor_history vh
	join visitor v on v.id=vh.Fk_Visitor
	join Flats f on f.id=vh.Fk_Flats 
	join Buildings b on b.id=f.FK_Buildings
	where f.id='+cast(@Fid as varchar(100))+
	' or '+@param+ ' like ''%'+cast(@vq as varchar(100))+'%'''

	exec(@query)





end

GO
/****** Object:  StoredProcedure [dbo].[loggedin]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[loggedin](@UserName varchar(100),@Password varchar(100),@RequestType varchar(50)=null,@Admin bit output,@Validate bit output)
as 
begin
set @Validate=0
set @Admin=0
if(@RequestType='login')
begin
	if exists(select 1 from tblUser where username=@UserName and password=@Password)
	begin
		select top 1 @Admin=isAdmin from tblUser where username=@UserName and password=@Password
		update tblUser set islogin=0
		update tbluser set islogin=1 ,loggedindate=getdate() where username=@UserName and password=@Password
		set @Validate=1
	end
end
	else if(@RequestType='logout')
	begin
		update tblUser set islogin=0
	end
	else if(@RequestType='islogin')
	begin
		select 1 from tblUser where username=@UserName and islogin=1
	end
	else if(@RequestType='isloginValid')
	begin
		select top 1 @Validate=1  from tblUser where adminkey=@Password
	end
	else if(@RequestType='passwordupdate')
	begin
		update tblUser set password=@password where adminkey=@UserName
	end
 
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllFlat]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetAllFlat](@Fk_flat int)
	as 
	begin
	 select id,Name+'-('+Owner+')' as Flat from Flats where FK_Buildings=@Fk_flat
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetBuilding]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create proc [dbo].[spGetBuilding]
	as 
	begin
	 select * from Buildings
	end
GO
/****** Object:  StoredProcedure [dbo].[spSearchAVisitor]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spSearchAVisitor]
(@GovnIdName varchar(100),
@GovnNo varchar(100))
as
begin

select top 1 v.name,v.PhoneNo,v.GovnIdName as IdName,v.GovnNo,case v.Gender when 0 then 'M' else 'F' end as Gender,
vh.FromPlace,b.Name+' '+ f.Name as FlatName,vh.reason,vh.OnDate,bv.fk_visitor as block,
b.Name+' '+ f.Name as FName,b.id BuildingId,f.id as FlatId from visitor_history vh
join visitor v on v.id=vh.Fk_Visitor
join Flats f on f.id=vh.Fk_Flats 
join Buildings b on b.id=f.FK_Buildings
left join blockVisitor bv on bv.fk_visitor=v.id and bv.isblock=1
where v.GovnIdName =@GovnIdName and GovnNo=@GovnNo
order by vh.id desc
end

GO
/****** Object:  StoredProcedure [dbo].[spVisitor]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spVisitor]
(
@GovnIdName varchar(100)=null,
@GovnNo varchar(100)=null,
@Name varchar(100)=null,
@PhoneNo varchar(10)=null,
@Gender bit=null,
@From varchar(500)=null,
@Fk_FlatId int=null,
@Reason varchar(500)=null,
@RequestType varchar(50)=''


)
as
begin
declare @id int =null
if(@RequestType='del')
begin
	delete from visitor_history where Fk_Visitor in 
		(select id from visitor where GovnIdName=@GovnIdName and GovnNo=@GovnNo)

	delete from visitor where GovnIdName=@GovnIdName and GovnNo=@GovnNo
end
else if exists(select 1 from visitor where GovnNo=@GovnNo )
begin
	select @id=id from visitor where GovnIdName=@GovnIdName and GovnNo=@GovnNo
	update visitor set name=@Name,PhoneNo=@PhoneNo,Gender=@Gender 
	where id=@id

end
else
begin
	insert into visitor(GovnIdName,GovnNo,Name,PhoneNo,Gender)
	values(@GovnIdName,@GovnNo,@Name,@PhoneNo,@gender)

	set @id=SCOPE_IDENTITY()
end

if exists(select 1 from visitor_history where @RequestType='update' and Fk_Visitor=@id and Fk_Flats=@Fk_FlatId)
begin
	
	update visitor_history set FromPlace=@From ,OnDate=getdate(),reason=@Reason
	where Fk_Visitor=@id and Fk_Flats=@Fk_FlatId

end
else if(@RequestType!='del')
begin
	insert into visitor_history (FromPlace,Fk_Flats,OnDate,reason,Fk_Visitor)
	values(@From,@Fk_FlatId,getdate(),@Reason,@id)
end



end

GO
/****** Object:  StoredProcedure [dbo].[userinfo]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[userinfo] (@username varchar(100),@RequestType varchar(100))
as
begin
if(@RequestType='detailsshow')
	begin
		select id,Name,Phoneno,address,password from tbluser where username=@username
	end

end
GO
/****** Object:  StoredProcedure [dbo].[userinfosave]    Script Date: 3/21/2017 16:49:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[userinfosave] (@username varchar(100),@name varchar(100),@phoneno varchar(10),@Address varchar(100),@password varchar(100))
as
begin

update tbluser set name=@name,phoneno=@phoneno,address=@address,password=@password where username=@username

end
GO
USE [master]
GO
ALTER DATABASE [visitor] SET  READ_WRITE 
GO
