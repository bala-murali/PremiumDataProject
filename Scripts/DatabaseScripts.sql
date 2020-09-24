Drop table OccupationRatings

Create Table OccupationRatings (OccupationRatingId int Identity(1,1), OccupationName varchar(20), Rating decimal(9,2))

Insert into OccupationRatings Select 'Professional', 1
Insert into OccupationRatings Select 'White Collar', 1.25
Insert into OccupationRatings Select 'Light Manual', 1.5
Insert into OccupationRatings Select 'Heavy Manual', 1.75

Select * from OccupationRatings

Drop table Occupation

Create Table Occupation(Id Int Identity(1,1), Occupation varchar(20), OccupationRatingId  int)

Insert into Occupation Select 'Cleaner', 3
Insert into Occupation Select 'Doctor', 1
Insert into Occupation Select 'Author', 2
Insert into Occupation Select 'Farmer', 4
Insert into Occupation Select 'Mechanic', 4
Insert into Occupation Select 'Florist', 3

Select * from Occupation
Select * from OccupationRatings

Select * from Occupation O, OccupationRatings R
Where O.OccupationRatingId = R.OccupationRatingId