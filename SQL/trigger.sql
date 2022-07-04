Create Trigger TR_IsAvailable
On Loans
After Insert
As
	Declare @id Int = (Select BookId From inserted)
	Update Books Set IsAvailable = 0 Where BookId = @id
