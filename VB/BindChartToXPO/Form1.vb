Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo
' ...

Namespace BindChartToXPO
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 1 To 10
				Dim record As New SeriesRecord()
				record.ArgumentMember = "Item " & i.ToString()
				record.ValueMember = i
				xpCollection1.Add(record)
			Next i
		End Sub

		Public Class SeriesRecord
			Inherits XPObject
			Public ArgumentMember As String
			Public ValueMember As Integer
		End Class

	End Class
End Namespace