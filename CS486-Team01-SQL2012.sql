-- CS486-Team01

CREATE DATABASE CS486_Team01_DB
GO 

USE CS486_Team01_DB
GO 

create table Song (
SongID int not null,
Name nvarchar(100) not null,
ReleaseTime datetime not null,
NumOfListen int not null default 0,
primary key (SongID)
)

create table Artist (
ArtistID int not null,
Name nvarchar(100) not null,
primary key(ArtistID)
)

create table ArtistSong(
ArtistID int not null,
SongID int not null,
primary key(ArtistID, SongID)
)

create table Region(
RegionID nvarchar(100) not null,
primary key(RegionID)

)

create table TypeRegion(
TypeID nvarchar(100) not null,
RegionID nvarchar(100) not null,
primary key (TypeID, RegionID)
)

create table SongToType(
SongID int not null,
TypeID nvarchar(100) not null,
RegionID nvarchar(100) not null,
primary key(SongID, TypeID, RegionID)
)

go
Alter table ArtistSong
add constraint fk_to_song
foreign key(SongID)
references Song(SongID);

go
Alter table ArtistSong
add constraint fk_to_artist
foreign key(ArtistID)
references Artist(ArtistID);

go
Alter table TypeRegion
add constraint fk_type_region
foreign key(RegionID)
references Region(RegionID);

go
Alter table SongToType
add constraint fk_songToType_Type
foreign key(TypeID, RegionID)
references TypeRegion(TypeID, RegionID);

go
Alter table SongToType
add constraint fk_songToType_Song
foreign key(SongID)
references Song(SongID);

go


GO
USE MASTER
GO
DROP database CS486_Team01_DB