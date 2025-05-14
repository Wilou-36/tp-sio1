create table Commande(
    ID_commande int primary key,
    'date' date not null,
    etat varchar(50) not null,
    
);

create table Pièces_automobiles(
    ID_pièces int primary key,
    Nom varchar(50) not null,
    'Description' text not null,
    Prix_unitaire int not null,
    Seuil_de_reapprovisionnement int,
    Quantité int not null,
    foreign key(id_commande) references Commande(ID_commande),
    foreign key(id_vente) references Vente(ID_vente)
);

create table Fournisseur(
    ID_fournisseur in primary key,
    Nom varchar(50)not null,
    adresse text not null,
    Telephone varchar(50),
    Adresse_mail text
);

create table Vente(
    ID_vente int primary key,
    'date' date not null,
    foreign key(id_client) references Client(ID_Client)
);
create table Client(
    ID_Client int primary key,
    Nom varchar(50)not null,
    prenom varchar(50) not null
);

create table liste_de_pièces(
    quantite int not null,
    foreign key(id_commande) references Commande(ID_commande),
    foreign key(id_pièces) references Pièces_automobiles(ID_pièces)
)

create table liste_de_ventes(
    Quantité int,
    foreign key(id_pièces) references Pièces_automobiles(ID_pièces),
    foreign key(id_vente) references Vente(ID_vente)
);

--Partie corriger

create table Commande(
    ID_commande int primary key,
    date date not null,
    etat varchar(50) not null
);

create table PiecesAutomobiles(
    ID_pieces int primary key,
    Nom varchar(50) not null,
    Description text not null,
    Prix_unitaire int not null,
    Seuil_de_reapprovisionnement int,
    Quantite int not null,
    ID_commande int,  
    ID_vente int,  
    foreign key(ID_commande) references Commande(ID_commande),
    foreign key(ID_vente) references Vente(ID_vente)
);

create table Fournisseur(
    ID_fournisseur int primary key,
    Nom varchar(50) not null,
    adresse text not null,
    Telephone varchar(50),
    Adresse_mail text
);

create table Vente(
    ID_vente int primary key,
    date date not null,
    ID_client int,  -- Add ID_client for foreign key
    foreign key(ID_client) references Client(ID_Client)
);

create table Client(
    ID_Client int primary key,
    Nom varchar(50) not null,
    prenom varchar(50) not null
);

create table liste_de_pièces(
    ID_commande int,
    ID_pièces int,
    quantite int not null,
    primary key(ID_commande, ID_pièces), -- Composite key for the relationship
    foreign key(ID_commande) references Commande(ID_commande),
    foreign key(ID_pièces) references Pièces_automobiles(ID_pièces)
);

create table liste_de_ventes(
    ID_vente int,
    ID_pièces int,
    Quantité int,
    primary key(ID_vente, ID_pièces), -- Composite key for the relationship
    foreign key(ID_vente) references Vente(ID_vente),
    foreign key(ID_pièces) references Pièces_automobiles(ID_pièces)
);


