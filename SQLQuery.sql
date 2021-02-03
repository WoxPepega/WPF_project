use STP_test

--�������� ������� ����������
create table Manager ( 
	idManager int not null primary key identity(1,1),
	nameManager nvarchar(128) not null
);

--�������� ������� �������� ��������
create table ClientStatus (
	idStatus int not null primary key identity(1,1),
	nameStatus nvarchar(64) not null
);

--�������� ������� ��������
create table Client (
	idClient int not null primary key identity(1,1),
	nameClient nvarchar(128) not null,
	idStatus int not null foreign key references ClientStatus(idStatus),
	idManager int not null foreign key references Manager(idManager) on delete cascade,
	--��������� ������
);

--�������� ������� ����� �������
create table ProductType (
	idProductType int not null primary key identity(1,1),
	nameType nvarchar(128) not null
)

--�������� ������� �������
create table Product (
	idProduct int not null primary key identity(1,1),
	nameProduct nvarchar(128) not null,
	priceProduct decimal(12,2) not null,
	typeProduct int not null foreign key references ProductType(idProductType),
	subTerm int null
);

--�������� ��������� ������� ��������� ������� ���������
create table ClientProduct (
	idClientProd int not null primary key identity(1,1),
	idClient int not null foreign key references Client(idClient) on delete cascade,
	idProduct int not null foreign key references Product(idProduct) on delete cascade
);