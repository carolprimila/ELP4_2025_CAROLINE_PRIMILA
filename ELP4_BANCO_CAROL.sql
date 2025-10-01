create table paises(
    id int not null identity(10,1) primary key,
    pais varchar(55) not null,
    sigla varchar(3) not null,
    ddi varchar(4) not null,
    moeda varchar(3) not null
);

create table estados(
    id int not null identity(100,1) primary key,
    estado varchar(50) not null,
    uf varchar(3) not null,
    idpais int not null references paises(id)
);

create table cidades(
    id int not null identity(1000,1) primary key,
    cidade varchar(50) not null,
    ddd varchar(3) not null,
    idEstado int not null references estados(id)
);

create table fornecedores(
    id int not null identity (1000,1) primary key,
    fornecedor varchar(50) not null,
    logradouro varchar(50) not null,
    numero int not null,
    complemento varchar(50) null, 
    bairro varchar(50) not null,
    idCidade int not null references cidades(id),
    cnpj varchar(14) not null unique,
    inscricaoEstadual varchar(9) not null,
    telefone varchar(9) not null
);

create table produtos(
    id int not null identity(1000,1) primary key,
    und int not null,
    grupo varchar(25) not null,
    codBarra varchar(13) not null unique,
    referencia varchar(20) not null,
    produto varchar(35) not null
);

create table prodforn(
    id int not null identity(1000,1) primary key,
    idForn int not null references fornecedores(id),
    idProd int not null references produtos(id)
);