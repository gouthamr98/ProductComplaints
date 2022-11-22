CREATE TABLE [dbo].[querry_table] (
    [querryId]   INT          IDENTITY (1, 1) NOT NULL,
    [customerId] INT          NOT NULL,
    [productId]  INT          NOT NULL,
    [querry]     VARCHAR (50) NOT NULL,
    [status]     VARCHAR (50) NOT NULL,
    [date]       DATE         NOT NULL,
    [reply] VARCHAR(101) NOT NULL, 
    PRIMARY KEY CLUSTERED ([querryId] ASC)
);

