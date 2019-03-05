/*Query 1*/
CREATE DATABASE ProductsDB;

/*Query 2*/
CREATE TABLE Product(
	ID int NOT NULL AUTO_INCREMENT,
    Name varchar(255),
    Price double,
    Description varchar(255),
    PRIMARY KEY (ID)
);

/*Query 3*/
INSERT INTO Product(Name, Price, Description) 
	VALUES('Dog Shampoo', 10.57, "shampoo for long hair dogs"),
			("WD Red 4 TB", 150.99, "NAS Hard drive"),
				("2018 Nissan Mourano", 37866.99, "Nissan Mourano AWD with Tech Package?");

/*Query 4*/                
SELECT * INTO 
	Product_Copy 
FROM 
	Product;

/*Query 5*/
DELETE FROM 
	Product_Copy 
WHERE
	ID = 2;


