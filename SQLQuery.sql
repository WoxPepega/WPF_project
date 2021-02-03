use STP_test

--Создание таблицы менеджеров
create table Manager ( 
	idManager int not null primary key identity(1,1),
	nameManager nvarchar(128) not null
);

--Ñîçäàíèå òàáëèöû ñòàòóñîâ êëèåíòîâ
create table ClientStatus (
	idStatus int not null primary key identity(1,1),
	nameStatus nvarchar(64) not null
);

--Ñîçäàíèå òàáëèöû êëèåíòîâ
create table Client (
	idClient int not null primary key identity(1,1),
	nameClient nvarchar(128) not null,
	idStatus int not null foreign key references ClientStatus(idStatus),
	idManager int not null foreign key references Manager(idManager) on delete cascade,
	--Êóïëåííûå òîâàðû
);

--Ñîçäàíèå òàáëèöû òèïîâ òîâàðîâ
create table ProductType (
	idProductType int not null primary key identity(1,1),
	nameType nvarchar(128) not null
)

--Ñîçäàíèå òàáëèöû òîâàðîâ
create table Product (
	idProduct int not null primary key identity(1,1),
	nameProduct nvarchar(128) not null,
	priceProduct decimal(12,2) not null,
	typeProduct int not null foreign key references ProductType(idProductType),
	subTerm int null
);

--Ñîçäàíèå ñâÿçóþùåé òàáëèöû êóïëåííûõ òîâàðîâ êëèåíòàìè
create table ClientProduct (
	idClientProd int not null primary key identity(1,1),
	idClient int not null foreign key references Client(idClient) on delete cascade,
	idProduct int not null foreign key references Product(idProduct) on delete cascade
);
