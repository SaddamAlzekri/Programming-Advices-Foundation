

declare @PageNumber int = 2;
declare @RowPerPage int = 3;

Select StudentID, Name, Subject, Grade from Students order by StudentID

offset (@Pagenumber - 1) * @RowPerPage Rows
fetch next @RowPerPage Rows Only;