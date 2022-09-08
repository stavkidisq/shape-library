SELECT Products.ProductName, Categories.CategoryName
FROM Orders
LEFT JOIN Products ON Products.Id = Orders.ProductId
LEFT JOIN Categories ON Categories.Id = Orders.CategoryId;