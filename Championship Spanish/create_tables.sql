create table Teams (
id int primary key,
Name nvarchar(50)
);

create table Players (
id int primary key,
FIO nvarchar(100),
Country nvarchar(50),
NumberPlayer int,
Position nvarchar(25),
Team int foreign key references Teams(id)
);
create table TeamFights (
id int primary key,
Team1 int foreign key references Teams(id),
Team2 int foreign key references Teams(id),
CountGoal1 int,
CountGoal2 int,
PlayerGoal int foreign key references Players(id),
MatchDate date
);

