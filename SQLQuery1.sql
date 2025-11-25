-- =========================================
--  PUBLISHERS STORED PROCEDURES
-- =========================================

-- 1) Get all publishers
IF OBJECT_ID('dbo.spPublishers_GetAll', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spPublishers_GetAll;
GO

CREATE PROCEDURE dbo.spPublishers_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT pub_id,
           pub_name,
           city,
           state,
           country
    FROM publishers
    ORDER BY pub_name;
END;
GO

-- 2) Search publishers by name/city/state
IF OBJECT_ID('dbo.spPublishers_Search', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spPublishers_Search;
GO

CREATE PROCEDURE dbo.spPublishers_Search
    @searchTerm NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT pub_id,
           pub_name,
           city,
           state,
           country
    FROM publishers
    WHERE pub_name LIKE '%' + @searchTerm + '%'
       OR city     LIKE '%' + @searchTerm + '%'
       OR state    LIKE '%' + @searchTerm + '%'
       OR country  LIKE '%' + @searchTerm + '%'
    ORDER BY pub_name;
END;
GO

-- 3) Get a single publisher by ID
IF OBJECT_ID('dbo.spPublishers_GetById', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spPublishers_GetById;
GO

CREATE PROCEDURE dbo.spPublishers_GetById
    @pub_id CHAR(4)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT pub_id,
           pub_name,
           city,
           state,
           country
    FROM publishers
    WHERE pub_id = @pub_id;
END;
GO

-- 4) Insert publisher
IF OBJECT_ID('dbo.spPublishers_Insert', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spPublishers_Insert;
GO

CREATE PROCEDURE dbo.spPublishers_Insert
    @pub_id   CHAR(4),
    @pub_name NVARCHAR(40),
    @city     NVARCHAR(20),
    @state    CHAR(2),
    @country  NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO publishers (pub_id, pub_name, city, state, country)
    VALUES (@pub_id, @pub_name, @city, @state, @country);
END;
GO

-- 5) Update publisher
IF OBJECT_ID('dbo.spPublishers_Update', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spPublishers_Update;
GO

CREATE PROCEDURE dbo.spPublishers_Update
    @pub_id   CHAR(4),
    @pub_name NVARCHAR(40),
    @city     NVARCHAR(20),
    @state    CHAR(2),
    @country  NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE publishers
    SET pub_name = @pub_name,
        city     = @city,
        state    = @state,
        country  = @country
    WHERE pub_id = @pub_id;
END;
GO

-- 6) Delete publisher
IF OBJECT_ID('dbo.spPublishers_Delete', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spPublishers_Delete;
GO

CREATE PROCEDURE dbo.spPublishers_Delete
    @pub_id CHAR(4)
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM publishers
    WHERE pub_id = @pub_id;
END;
GO
