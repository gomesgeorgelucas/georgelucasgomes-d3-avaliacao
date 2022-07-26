create database georgelucasgomes_d3_avaliacao;
use georgelucasgomes_d3_avaliacao;

CREATE TABLE tb_users (
	id_user UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
	name_user VARCHAR (255) NOT NULL,
	email_user VARCHAR (255) NOT NULL UNIQUE,
	password_user VARCHAR(255) NOT NULL
);

insert into tb_users (name_user, email_user, password_user) values ('user', 'user@email.com','user123');
insert into tb_users (name_user, email_user, password_user) values ('admin', 'admin@email.com','admin123');