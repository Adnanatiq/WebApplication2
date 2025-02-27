
ALTER DATABASE [LMS_LOGIN] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LMS_LOGIN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LMS_LOGIN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET ARITHABORT OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LMS_LOGIN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LMS_LOGIN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LMS_LOGIN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LMS_LOGIN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LMS_LOGIN] SET  MULTI_USER 
GO
ALTER DATABASE [LMS_LOGIN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LMS_LOGIN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LMS_LOGIN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LMS_LOGIN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LMS_LOGIN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LMS_LOGIN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LMS_LOGIN] SET QUERY_STORE = ON
GO
ALTER DATABASE [LMS_LOGIN] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LMS_LOGIN]
GO
/****** Object:  Table [dbo].[Student_Data]    Script Date: 2/6/2025 12:30:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](150) NOT NULL,
	[Email] [nchar](150) NOT NULL,
	[Reg_No] [nchar](150) NOT NULL,
	[Class] [nchar](10) NOT NULL,
	[Status] [nchar](10) NOT NULL,
	[Password] [nchar](150) NOT NULL,
	[Phone_Number] [nchar](150) NOT NULL,
	[Address] [nchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher_data]    Script Date: 2/6/2025 12:30:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](150) NOT NULL,
	[Email] [nchar](150) NOT NULL,
	[Password] [nchar](150) NOT NULL,
	[Address] [nchar](150) NOT NULL,
	[Course_Type] [nchar](150) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student_Data] ON 

INSERT [dbo].[Student_Data] ([id], [UserName], [Email], [Reg_No], [Class], [Status], [Password], [Phone_Number], [Address]) VALUES (1, N'Muhammad Ibraheem                                                                                                                                     ', N'ibraheem@gmail.com                                                                                                                                    ', N'L1F21BSCS0226                                                                                                                                         ', N'10        ', N'Active    ', N'Password                                                                                                                                              ', N'03001234567                                                                                                                                           ', N'123 Street                                                                                                                                            ')
INSERT [dbo].[Student_Data] ([id], [UserName], [Email], [Reg_No], [Class], [Status], [Password], [Phone_Number], [Address]) VALUES (2, N'Adnan                                                                                                                                                 ', N'adnan@gmail.com                                                                                                                                       ', N'L1F21BSCS0223                                                                                                                                         ', N'10        ', N'Active    ', N'1234567                                                                                                                                               ', N'03001234567                                                                                                                                           ', N'Garden Town                                                                                                                                           ')
INSERT [dbo].[Student_Data] ([id], [UserName], [Email], [Reg_No], [Class], [Status], [Password], [Phone_Number], [Address]) VALUES (3, N'Ibraheem                                                                                                                                              ', N'LMS@gmail.com                                                                                                                                         ', N'L1F21BSCS02221                                                                                                                                        ', N'10        ', N'Active    ', N'pass                                                                                                                                                  ', N'0300023045334                                                                                                                                         ', N'Garden Town                                                                                                                                           ')
SET IDENTITY_INSERT [dbo].[Student_Data] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher_data] ON 

INSERT [dbo].[Teacher_data] ([id], [UserName], [Email], [Password], [Address], [Course_Type]) VALUES (1, N'Asad Kamal                                                                                                                                            ', N'asad@gmail.com                                                                                                                                        ', N'Password                                                                                                                                              ', N'ucp Johar Town                                                                                                                                        ', N'BSCS                                                                                                                                                  ')
SET IDENTITY_INSERT [dbo].[Teacher_data] OFF
GO
USE [master]
GO
ALTER DATABASE [LMS_LOGIN] SET  READ_WRITE 
GO
