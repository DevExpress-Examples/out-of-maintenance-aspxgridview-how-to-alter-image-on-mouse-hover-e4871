Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace ASPxGridVIew
	Public Class Data
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
		Private privateImageUrl As String
		Public Property ImageUrl() As String
			Get
				Return privateImageUrl
			End Get
			Set(ByVal value As String)
				privateImageUrl = value
			End Set
		End Property
		Private privateAltImageUrl As String
		Public Property AltImageUrl() As String
			Get
				Return privateAltImageUrl
			End Get
			Set(ByVal value As String)
				privateAltImageUrl = value
			End Set
		End Property
	End Class

	Public Class DataHelper
		Public Shared Function GenerateData() As List(Of Data)
			Return New List(Of Data) (
				New Data() {
					New Data() With {.ID = 0, .Description = "Basket/Check", .ImageUrl = "Images/Basket.png", .AltImageUrl = "Images/Check.png"}, 
					New Data() With {.ID = 1, .Description = "Customer/Folder", .ImageUrl = "Images/Customer.png", .AltImageUrl = "Images/Folder.png"}, 
					New Data() With {.ID = 2, .Description = "Home/Key", .ImageUrl = "Images/Home.png", .AltImageUrl = "Images/Key.png"}, 
					New Data() With {.ID = 3, .Description = "Mail/Printing", .ImageUrl = "Images/Mail.png", .AltImageUrl = "Images/Printing.png"}
				}
			)
		End Function
	End Class
End Namespace