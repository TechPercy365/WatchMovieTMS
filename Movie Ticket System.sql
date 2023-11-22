CREATE Database movieTicketManagement
USE movieTicketManagement

CREATE Table [User] (
	userID int IDENTITY(1,1) PRIMARY KEY,
	userName varchar(50) NOT NULL,
	[password] varchar(16) NOT NULL,
	userType int NOT NULL
)


CREATE Table [UserInformation] (
	userInfoID int IDENTITY(1,1) PRIMARY KEY,
	lastName_Cus varchar(50),
	firstName_Cus varchar(50),
	phoneNum int,
	userID int,	
	FOREIGN KEY (userId) REFERENCES [User](userId)	
)

CREATE TABLE [dbo].[Role](
	[userType] int IDENTITY(1,1) NOT NULL,
	[roleName] nvarchar(50) NULL,
	[roleDescription] nvarchar(100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[userType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE Table [Movies] (
	Id_Movie int PRIMARY KEY,
	movieName varchar(50),
	movieGenre varchar(15),
	movieDescription varchar(100),	
	movieDate date,
	movieTime time,
	movieCost decimal(4, 2)
)

CREATE Table [BookMovie](
	BookingID int PRIMARY KEY,
	userInfoID int,
	Id_Movie int,
	movieSeat int,
	quantity int,
	totalPayment decimal(9,2)
)

SET IDENTITY_INSERT [dbo].[Role] ON 
INSERT [dbo].[Role] (userType, [roleName], [roleDescription]) VALUES (1, N'Student', N'Student ')
INSERT [dbo].[Role] (userType, [roleName], [roleDescription]) VALUES (2, N'Teacher', N'Teacher')
INSERT [dbo].[Role] (userType, [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF


CREATE PROCEDURE sp_Register 
@userInfoID int, @firstName_Cus varchar(50), @lastName_Cus varchar(50), @phoneNum int, @email varchar(50), 
@userID int, @userName varchar(50), @password varchar(16), @userType int AS
DECLARE @IDNum int = 1;
WHILE @IDNum <=100
INSERT INTO [UserInformation](userID, firstName_Cus, lastName_Cus, phoneNum, email)
VALUES(@IDNum, @firstName_Cus, @lastName_Cus, @phoneNum, @email)	
INSERT INTO [User] VALUES (@IDNum, @userName, @password, @userType)
SET @IDNum = @IDNum + 1

CREATE VIEW vw_UserInfo AS
SELECT firstName_Cus as 'First Name', lastName_Cus as 'Last Name', 
userName as 'Username', userType as 'Role', phoneNum as 'Phone Number', email as 'Email'
FROM [UserInformation] ui
JOIN [User] us ON us.userID = ui.userID 

CREATE VIEW vw_Users AS
SELECT * FROM [User]

--CREATE VIEW viewUsersAdm
--CREATE VIEW viewMovies
--CREATE VIEW viewHistory
--CREATE VIEW viewReceipt

