DROP TABLE IF EXISTS Administre ;
CREATE TABLE Administre (_id_Administre BIGINT AUTO_INCREMENT NOT NULL,
_nom_Administre VARCHAR(15),
_prenom_Administre VARCHAR(15),
_adresse_Administre VARCHAR(50),
_mail_Administre VARCHAR(20),
_telephone_Administre BIGINT,
_log_id_Administre VARCHAR(15),
_log_password_Administre VARCHAR(15),
_code_Administre VARCHAR(10),
_id_ville BIGINT,
_id_role BIGINT,
PRIMARY KEY (_id_Administre)) ENGINE=InnoDB;

DROP TABLE IF EXISTS livre ;
CREATE TABLE livre (_isbn_livre BIGINT AUTO_INCREMENT NOT NULL,
_nom_livre VARCHAR(25),
_date_edition_livre DATE,
_nom_editeur_livre VARCHAR(15),
_nom_collection_livre VARCHAR(15),
bibliothèque__id_bibliothèque BIGINT,
PRIMARY KEY (_isbn_livre)) ENGINE=InnoDB;

DROP TABLE IF EXISTS ville ;
CREATE TABLE ville (_id_ville BIGINT AUTO_INCREMENT NOT NULL,
_nom_ville VARCHAR(25),
_CP_Administre BIGINT,
PRIMARY KEY (_id_ville)) ENGINE=InnoDB;

DROP TABLE IF EXISTS bibliothèque ;
CREATE TABLE bibliothèque (_id_bibliothèque BIGINT AUTO_INCREMENT NOT NULL,
_localisation_bibliothèque VARCHAR(15),
PRIMARY KEY (_id_bibliothèque)) ENGINE=InnoDB;

DROP TABLE IF EXISTS auteur ;
CREATE TABLE auteur (_id_autheur BIGINT AUTO_INCREMENT NOT NULL,
_nom_autheur VARCHAR(15),
_prenom_autheur VARCHAR(15),
PRIMARY KEY (_id_autheur)) ENGINE=InnoDB;

DROP TABLE IF EXISTS role ;
CREATE TABLE role (_id_role BIGINT AUTO_INCREMENT NOT NULL,
_role_role VARCHAR(10),
PRIMARY KEY (_id_role)) ENGINE=InnoDB;

DROP TABLE IF EXISTS Retard_en_cours ;
CREATE TABLE Retard_en_cours (_id_Retard_en_cours BIGINT AUTO_INCREMENT NOT NULL,
_regularise_Retard_en_cours BOOL,
PRIMARY KEY (_id_Retard_en_cours)) ENGINE=InnoDB;

DROP TABLE IF EXISTS emprunte ;
CREATE TABLE emprunte (_id_Administre BIGINT AUTO_INCREMENT NOT NULL,
_isbn_livre BIGINT NOT NULL,
_date_Partage DATE,
PRIMARY KEY (_id_Administre,
 _isbn_livre)) ENGINE=InnoDB;

DROP TABLE IF EXISTS Partage ;
CREATE TABLE Partage (_isbn_livre BIGINT AUTO_INCREMENT NOT NULL,
_id_Administre BIGINT NOT NULL,
_statut_livre VARCHAR(10),
PRIMARY KEY (_isbn_livre,
 _id_Administre)) ENGINE=InnoDB;

DROP TABLE IF EXISTS ecrit ;
CREATE TABLE ecrit (_isbn_livre BIGINT AUTO_INCREMENT NOT NULL,
_id_autheur BIGINT NOT NULL,
PRIMARY KEY (_isbn_livre,
 _id_autheur)) ENGINE=InnoDB;

DROP TABLE IF EXISTS en_retard ;
CREATE TABLE en_retard (_id_Administre BIGINT AUTO_INCREMENT NOT NULL,
_isbn_livre BIGINT NOT NULL,
_id_Retard_en_cours BIGINT NOT NULL,
PRIMARY KEY (_id_Administre,
 _isbn_livre,
 _id_Retard_en_cours)) ENGINE=InnoDB;

ALTER TABLE Administre ADD CONSTRAINT FK_Administre__id_ville FOREIGN KEY (_id_ville) REFERENCES ville (_id_ville);

ALTER TABLE Administre ADD CONSTRAINT FK_Administre__id_role FOREIGN KEY (_id_role) REFERENCES role (_id_role);
ALTER TABLE livre ADD CONSTRAINT FK_livre_bibliothèque__id_bibliothèque FOREIGN KEY (bibliothèque__id_bibliothèque) REFERENCES bibliothèque (_id_bibliothèque);
ALTER TABLE emprunte ADD CONSTRAINT FK_emprunte__id_Administre FOREIGN KEY (_id_Administre) REFERENCES Administre (_id_Administre);
ALTER TABLE emprunte ADD CONSTRAINT FK_emprunte__isbn_livre FOREIGN KEY (_isbn_livre) REFERENCES livre (_isbn_livre);
ALTER TABLE Partage ADD CONSTRAINT FK_Partage__isbn_livre FOREIGN KEY (_isbn_livre) REFERENCES livre (_isbn_livre);
ALTER TABLE Partage ADD CONSTRAINT FK_Partage__id_Administre FOREIGN KEY (_id_Administre) REFERENCES Administre (_id_Administre);
ALTER TABLE ecrit ADD CONSTRAINT FK_ecrit__isbn_livre FOREIGN KEY (_isbn_livre) REFERENCES livre (_isbn_livre);
ALTER TABLE ecrit ADD CONSTRAINT FK_ecrit__id_autheur FOREIGN KEY (_id_autheur) REFERENCES auteur (_id_autheur);
ALTER TABLE en_retard ADD CONSTRAINT FK_en_retard__id_Administre FOREIGN KEY (_id_Administre) REFERENCES Administre (_id_Administre);
ALTER TABLE en_retard ADD CONSTRAINT FK_en_retard__isbn_livre FOREIGN KEY (_isbn_livre) REFERENCES livre (_isbn_livre);
ALTER TABLE en_retard ADD CONSTRAINT FK_en_retard__id_Retard_en_cours FOREIGN KEY (_id_Retard_en_cours) REFERENCES Retard_en_cours (_id_Retard_en_cours);
