-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE Or Alter FUNCTION dbo.CapitalizeFirstLetter (@input NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
    IF @input IS NULL OR LEN(@input) = 0
        RETURN @input;

    RETURN UPPER(LEFT(@input, 1)) + LOWER(SUBSTRING(@input, 2, LEN(@input)));
END;


