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

DROP TABLE BookMovie
CREATE Table [BookMovie](
	BookingID int PRIMARY KEY,
	userInfoID int,
	Id_Movie int,
	quantity int,
	amount decimal(9,2),
	totalPayment decimal(9,2),
	totalChange decimal(9,2)
)

SET IDENTITY_INSERT [dbo].[Role] ON 
INSERT [dbo].[Role] (userType, [roleName], [roleDescription]) VALUES (1, N'Customer', N'Customer ')
INSERT [dbo].[Role] (userType, [roleName], [roleDescription]) VALUES (2, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF

DROP TABLE [dbo].[Role]

-- PROCEDURES ABOUT USERS
CREATE PROCEDURE sp_Register 
    @firstName_Cus varchar(50), 
    @lastName_Cus varchar(50), 
    @phoneNum int, 
    @email varchar(50), 
    @userID int, 
    @userName varchar(50), 
    @password varchar(16), 
    @userType int 
AS
BEGIN
    INSERT INTO [UserInformation](userID, firstName_Cus, lastName_Cus, phoneNum, email)
    VALUES(@userID, @firstName_Cus, @lastName_Cus, @phoneNum, @email)	
    
    INSERT INTO [User] VALUES (@userID, @userName, @password, @userType)
END;

CREATE PROCEDURE sp_addUsers
@userName varchar(50),
@password varchar(16),
@userType int
AS
INSERT INTO [User](userName, password, userType) VALUES(@userName, @password, @userType)

CREATE PROCEDURE sp_deleteUsers
@userName varchar(50)
AS
DELETE FROM [User] WHERE [userName] = @userName


-- VIEWS ABOUT USERS
CREATE VIEW vw_UserInfo AS
SELECT firstName_Cus as 'First Name', lastName_Cus as 'Last Name', 
userName as 'Username', userType as 'Role', phoneNum as 'Phone Number', email as 'Email'
FROM [UserInformation] ui
JOIN [User] us ON us.userID = ui.userID 

CREATE VIEW vw_Users AS
SELECT us.userID as 'User ID', userName as 'Username', [password] as 'Password', userType as 'User Type',
userInfoID as 'User Info ID', lastName_Cus as 'Last Name', firstName_Cus as 'First Name', 
phoneNum as 'Phone Number', email as 'Email Account'
FROM [User] us
JOIN [UserInformation] ui ON us.userID = ui.userID

CREATE VIEW vw_Movies AS
SELECT movieName as 'Movie Name', movieGenre as 'Genre', 
movieDate as 'Date', movieTime as 'Time', movieCost as 'Price'
FROM Movies

CREATE VIEW vw_BookHistory_User AS
SELECT BookingID as 'Booking ID', movieName as 'Movie', movieCost as 'Price' , 
quantity as 'Quantity', totalPayment as 'Payment', amount as 'Amount Pay', totalChange as 'Change'
FROM BookMovie bm
JOIN Movies mov ON mov.Id_Movie = bm.Id_Movie

CREATE PROCEDURE dbo.InsertBooking
    @UserInfoID INT,
    @MovieId INT,
    @Quantity INT,
    @Amount DECIMAL(9,2),
    @TotalPayment DECIMAL(9,2),
    @TotalChange DECIMAL(9,2)
AS
BEGIN
    INSERT INTO BookMovie (userInfoID, Id_Movie, quantity, amount, totalPayment, totalChange)
    VALUES (@UserInfoID, @MovieId, @Quantity, @Amount, @TotalPayment, @TotalChange)
END


SELECT * FROM [User]
SELECT * FROM [UserInformation]

--CREATE VIEW viewUsersAdm
--CREATE VIEW viewMovies
--CREATE VIEW viewHistory
--CREATE VIEW viewReceipt

SELECT * FROM [User]
SELECT * FROM [UserInformation]
SELECT * FROM [Role]
SELECT * FROM [Movies]
SELECT * FROM [BookMovie]

INSERT INTO BookMovie VALUES(1, 1, 1, 1, 100, 99, 1);
INSERT INTO BookMovie VALUES(2, 1, 2, 3, 300, 70, 90);
INSERT INTO BookMovie VALUES(3, 3, 5, 1, 90, 85, 5);

INSERT INTO [Movies] VALUES(3, 'Jumanji 2', 'Comedy', 'A comedic adventure', '2023-12-11', '12:00:00', 70.00)
INSERT INTO [Movies] VALUES(4, 'Saw: X', 'Horror', 'A Thriller Life and Death Situation', '2023-12-13', '17:00:00', 70.00)
INSERT INTO [Movies] VALUES(5, 'Rampage', 'Adventure', 'A strong and big white kong?', '2023-12-10', '7:30:00', 85.00)


INSERT INTO [User](userID, userName, [password], userType) VALUES(4, 'Julia', 'julia365', 1)
INSERT INTO [User](userID, userName, [password], userType) VALUES(5, 'Christine', 'cm143', 1)




