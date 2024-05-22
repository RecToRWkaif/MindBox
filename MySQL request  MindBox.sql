
CREATE TABLE Products (
	id BIGINT PRIMARY KEY NOT NULL,
	calls VARCHAR(45) NOT NULL
);

INSERT INTO Products
VALUES
	(1, 'Bread'),
	(2, 'AirPods'),
	(3, 'Vegetables');

CREATE TABLE Categories (
	id BIGINT PRIMARY KEY NOT NULL,
	calls VARCHAR(45) NOT NULL
);

INSERT INTO Categories
VALUES
	(1, 'Foods'),
	(2, 'Tech'),
	(3, 'Furniture');

CREATE TABLE ProductCategories (
    ProductId BIGINT NOT NULL,
	CategoryId BIGINT NOT NULL,
    PRIMARY KEY (ProductId, CategoryId),
    
    CONSTRAINT Product_id_fk FOREIGN KEY (Productid) REFERENCES Products(id),
    CONSTRAINT Categories_id_fk FOREIGN KEY (Categoryid) REFERENCES Categories(id)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 2),
	(3, 1);

SELECT P.calls, C.calls
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;