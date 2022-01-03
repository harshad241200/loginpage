create database form;
use form;
create table logins(
id int primary key identity not null,
email varchar (250),
password varchar (50)
);

select * from logins
