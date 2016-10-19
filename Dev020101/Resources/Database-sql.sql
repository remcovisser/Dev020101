CREATE TABLE cities (
 city_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 city_name VARCHAR(255) NOT NULL
);


CREATE TABLE countries (
 country_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 country_name VARCHAR(255) NOT NULL
);


CREATE TABLE courses (
 course_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 course_name VARCHAR(100) NOT NULL
);


CREATE TABLE headquarters (
 buildingName VARCHAR(100) NOT NULL,
 rooms INT,
 rent FLOAT(10)
);

ALTER TABLE headquarters ADD CONSTRAINT PK_headquarters PRIMARY KEY (buildingName);


CREATE TABLE levels (
 level_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 level_name VARCHAR(100) NOT NULL
);


CREATE TABLE positions (
 position_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 name CHAR(255) NOT NULL,
 description CHAR(255) NOT NULL,
 fee FLOAT(10) NOT NULL
);


CREATE TABLE schools (
 school_id INT PRIMARY KEY  AUTO_INCREMENT NOT NULL,
 school_name VARCHAR(100) NOT NULL
);


CREATE TABLE streets (
 street_id INT  PRIMARY KEY AUTO_INCREMENT NOT NULL,
 street_name VARCHAR(255) NOT NULL
);


CREATE TABLE addresses (
 address_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 number VARCHAR(255),
 postalCode VARCHAR(255) NOT NULL,
 street_id INT  ,
 city_id INT  ,
 country_id INT  
);


CREATE TABLE degrees (
 degree_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 course_id INT  ,
 school_id INT  ,
 level_id INT  
);


CREATE TABLE employees (
 bsn INT PRIMARY KEY NOT NULL,
 firstName VARCHAR(50),
 lastName VARCHAR(50),
 buildingName VARCHAR(100)  
);


CREATE TABLE projects (
 project_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 name VARCHAR(255),
 budget FLOAT(10),
 allocatedHours FLOAT(10),
 address_id INT  ,
 buildingName VARCHAR(100)  
);


CREATE TABLE employeeAddresses (
 employeeAddress_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 bsn INT NOT NULL,
 address_id INT NOT NULL,
 residence INT
);


CREATE TABLE employeeDegrees (
 employeeDegrees_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
 bsn INT NOT NULL,
 degree_id INT NOT NULL
);


CREATE TABLE employeePositions (
 employeePositions_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL, 
 bsn INT NOT NULL,
 project_id INT   NOT NULL,
 position_id INT   NOT NULL,
 hours float(10)
);



ALTER TABLE addresses ADD CONSTRAINT FK_addresses_0 FOREIGN KEY (street_id) REFERENCES streets (street_id);
ALTER TABLE addresses ADD CONSTRAINT FK_addresses_1 FOREIGN KEY (city_id) REFERENCES cities (city_id);
ALTER TABLE addresses ADD CONSTRAINT FK_addresses_2 FOREIGN KEY (country_id) REFERENCES countries (country_id);


ALTER TABLE degrees ADD CONSTRAINT FK_degrees_0 FOREIGN KEY (course_id) REFERENCES courses (course_id);
ALTER TABLE degrees ADD CONSTRAINT FK_degrees_1 FOREIGN KEY (school_id) REFERENCES schools (school_id);
ALTER TABLE degrees ADD CONSTRAINT FK_degrees_2 FOREIGN KEY (level_id) REFERENCES levels (level_id);


ALTER TABLE employees ADD CONSTRAINT FK_employees_0 FOREIGN KEY (buildingName) REFERENCES headquarters (buildingName);


ALTER TABLE projects ADD CONSTRAINT FK_projects_0 FOREIGN KEY (address_id) REFERENCES addresses (address_id);
ALTER TABLE projects ADD CONSTRAINT FK_projects_1 FOREIGN KEY (buildingName) REFERENCES headquarters (buildingName);


ALTER TABLE employeeAddresses ADD CONSTRAINT FK_employeeAddresses_0 FOREIGN KEY (bsn) REFERENCES employees (bsn);
ALTER TABLE employeeAddresses ADD CONSTRAINT FK_employeeAddresses_1 FOREIGN KEY (address_id) REFERENCES addresses (address_id);


ALTER TABLE employeeDegrees ADD CONSTRAINT FK_employeeDegrees_0 FOREIGN KEY (degree_id) REFERENCES degrees (degree_id);
ALTER TABLE employeeDegrees ADD CONSTRAINT FK_employeeDegrees_1 FOREIGN KEY (bsn) REFERENCES employees (bsn);


ALTER TABLE employeePositions ADD CONSTRAINT FK_employeePositions_0 FOREIGN KEY (bsn) REFERENCES employees (bsn);
ALTER TABLE employeePositions ADD CONSTRAINT FK_employeePositions_1 FOREIGN KEY (position_id) REFERENCES positions (position_id);
ALTER TABLE employeePositions ADD CONSTRAINT FK_employeePositions_2 FOREIGN KEY (project_id) REFERENCES projects (project_id);