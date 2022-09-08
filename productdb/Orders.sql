CREATE TABLE Orders (
    ProductId INT NOT NULL,
    CategoryId INT NULL,
    FOREIGN KEY (ProductId) REFERENCES Products (Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories (Id)
);