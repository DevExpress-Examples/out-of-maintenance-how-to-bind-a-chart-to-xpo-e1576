Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace BindChartToXPO
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            For i As Integer = 1 To 10
                Dim record As New SeriesRecord()
                record.Argument = "Item " & i.ToString()
                record.Value = i
                xpCollection1.Add(record)
            Next i

        End Sub
    End Class

    Public Class SeriesRecord
        Inherits XPObject

        Public Argument As String
        Public Value As Integer
    End Class

End Namespace
