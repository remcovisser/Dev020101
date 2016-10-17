CREATE TABLE cities (
 city_id INT NOT NULL,
 name VARCHAR(255)
);

ALTER TABLE cities ADD CONSTRAINT PK_cities PRIMARY KEY (city_id);


CREATE TABLE countries (
 country_id INT NOT NULL,
 name VARCHAR(255)
);

ALTER TABLE countries ADD CONSTRAINT PK_countries PRIMARY KEY (country_id);


CREATE TABLE courses (
 course_id INT NOT NULL,
 name VARCHAR(100)
);

ALTER TABLE courses ADD CONSTRAINT PK_courses PRIMARY KEY (course_id);


CREATE TABLE headquaters (
 buildingName VARCHAR(100) NOT NULL,
 rooms INT,
 rent FLOAT(10)
);

ALTER TABLE headquaters ADD CONSTRAINT PK_headquaters PRIMARY KEY (buildingName);


CREATE TABLE levels (
 level_id INT NOT NULL,
 name VARCHAR(100)
);

ALTER TABLE levels ADD CONSTRAINT PK_levels PRIMARY KEY (level_id);


CREATE TABLE positions (
 position_id INT NOT NULL,
 name CHAR(10) NOT NULL,
 description CHAR(10) NOT NULL,
 fee CHAR(10) NOT NULL
);

ALTER TABLE positions ADD CONSTRAINT PK_positions PRIMARY KEY (position_id);


CREATE TABLE schools (
 school_id INT NOT NULL,
 name VARCHAR(100)
);

ALTER TABLE schools ADD CONSTRAINT PK_schools PRIMARY KEY (school_id);


CREATE TABLE addresses (
 country_id INT NOT NULL,
 postalCode VARCHAR(10) NOT NULL,
 city_id INT NOT NULL,
 street VARCHAR(10),
 number VARCHAR(10)
);

ALTER TABLE addresses ADD CONSTRAINT PK_addresses PRIMARY KEY (country_id,postalCode);


CREATE TABLE degrees (
 degree_id INT NOT NULL,
 school_id INT NOT NULL,
 level_id INT NOT NULL,
 course_id INT NOT NULL
);

ALTER TABLE degrees ADD CONSTRAINT PK_degrees PRIMARY KEY (degree_id);


CREATE TABLE employees (
 bsn INT NOT NULL,
 firstName VARCHAR(50),
 lastName VARCHAR(50),
 buildingName VARCHAR(100) NOT NULL
);

ALTER TABLE employees ADD CONSTRAINT PK_employees PRIMARY KEY (bsn);


CREATE TABLE projects (
 project_id INT NOT NULL,
 budget FLOAT(10),
 allocatedHours FLOAT(10),
 buildingName VARCHAR(100) NOT NULL,
 country_id INT NOT NULL,
 postalCode VARCHAR(10) NOT NULL
);

ALTER TABLE projects ADD CONSTRAINT PK_projects PRIMARY KEY (project_id);


CREATE TABLE employeeAdresses (
 country_id INT NOT NULL,
 postalCode VARCHAR(10) NOT NULL,
 bsn INT NOT NULL,
 residence INT
);

ALTER TABLE employeeAdresses ADD CONSTRAINT PK_employeeAdresses PRIMARY KEY (country_id,postalCode,bsn);


CREATE TABLE employeeDegrees (
 degree_id INT NOT NULL,
 bsn INT NOT NULL
);

ALTER TABLE employeeDegrees ADD CONSTRAINT PK_employeeDegrees PRIMARY KEY (degree_id,bsn);


CREATE TABLE employeePositions (
 bsn INT NOT NULL,
 project_id INT NOT NULL,
 position_id INT NOT NULL
);

ALTER TABLE employeePositions ADD CONSTRAINT PK_employeePositions PRIMARY KEY (bsn,project_id,position_id);


ALTER TABLE addresses ADD CONSTRAINT FK_addresses_0 FOREIGN KEY (country_id) REFERENCES countries (country_id);
ALTER TABLE addresses ADD CONSTRAINT FK_addresses_1 FOREIGN KEY (city_id) REFERENCES cities (city_id);


ALTER TABLE degrees ADD CONSTRAINT FK_degrees_0 FOREIGN KEY (school_id) REFERENCES schools (school_id);
ALTER TABLE degrees ADD CONSTRAINT FK_degrees_1 FOREIGN KEY (level_id) REFERENCES levels (level_id);
ALTER TABLE degrees ADD CONSTRAINT FK_degrees_2 FOREIGN KEY (course_id) REFERENCES courses (course_id);


ALTER TABLE employees ADD CONSTRAINT FK_employees_0 FOREIGN KEY (buildingName) REFERENCES headquaters (buildingName);


ALTER TABLE projects ADD CONSTRAINT FK_projects_0 FOREIGN KEY (buildingName) REFERENCES headquaters (buildingName);
ALTER TABLE projects ADD CONSTRAINT FK_projects_1 FOREIGN KEY (country_id,postalCode) REFERENCES addresses (country_id,postalCode);


ALTER TABLE employeeAdresses ADD CONSTRAINT FK_employeeAdresses_0 FOREIGN KEY (country_id,postalCode) REFERENCES addresses (country_id,postalCode);
ALTER TABLE employeeAdresses ADD CONSTRAINT FK_employeeAdresses_1 FOREIGN KEY (bsn) REFERENCES employees (bsn);


ALTER TABLE employeeDegrees ADD CONSTRAINT FK_employeeDegrees_0 FOREIGN KEY (degree_id) REFERENCES degrees (degree_id);
ALTER TABLE employeeDegrees ADD CONSTRAINT FK_employeeDegrees_1 FOREIGN KEY (bsn) REFERENCES employees (bsn);


ALTER TABLE employeePositions ADD CONSTRAINT FK_employeePositions_0 FOREIGN KEY (bsn) REFERENCES employees (bsn);
ALTER TABLE employeePositions ADD CONSTRAINT FK_employeePositions_1 FOREIGN KEY (project_id) REFERENCES projects (project_id);
ALTER TABLE employeePositions ADD CONSTRAINT FK_employeePositions_2 FOREIGN KEY (position_id) REFERENCES positions (position_id);


