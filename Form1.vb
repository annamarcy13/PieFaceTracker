
Imports System.Security.Cryptography
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports Newtonsoft.Json

Public Class Form1
    Private Const strSTUDENTFILE As String = "StudentList.json"
    Private studenttable As New List(Of Student)
    Private names() As String = {"Aiden", "Alexander", "Anna", "Anthony", "Arlo", "Benjamin", "Bradley", "Brooks", "Chevy", "Collin", "Francis", "Holly", "Logan", "Matthew", "Michael", "Nathan", "Preston", "Srikar", "Tanmay", "Vincent", "Walker", "Zeph"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateStudentTable()
        populatestudentcombobox()
    End Sub
    Private Sub populatestudentcombobox()
        CBOStudents.Items.AddRange(studenttable.ToArray)
    End Sub

    Private Sub PopulateStudentTable()
        If IO.File.Exists(strSTUDENTFILE) Then
            loadStudentTableFromFIle()
        Else
            StartFresh()
        End If
    End Sub
    Private Sub loadStudentTableFromFIle()

        Dim reader As New IO.StreamReader(strSTUDENTFILE)
        Dim str As String = reader.ReadToEnd
        studenttable = JsonConvert.DeserializeObject(Of List(Of Student))(str)
        reader.Close()

    End Sub
    Private Sub StartFresh()
        For Each s As String In names
            'Add a new student object to our dictionary
            'For know we will use the first name as the key because this list is unique
            studenttable.Add(New Student(s, New List(Of Donation)))
        Next
    End Sub

    Private Sub CBOStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOStudents.SelectedIndexChanged
        UpdateValues()
    End Sub

    Private Sub UpdateValues()
        Dim s As Student = CBOStudents.SelectedItem
        If Not IsNothing(s) Then
            loadDonationListBox()
            LblStudentTotal.Text = s.Getotaldonations().ToString("C2")
            LblClassTotal.Text = GetClassTotalDOnations.ToString("C2")
        End If
        PopulateTopDonors()
    End Sub
    Private Sub PopulateTopDonors()
        LblHigh.Text = ""
        studenttable.Sort(Function(x, y) y.Getotaldonations.CompareTo(x.Getotaldonations))
        Dim i As Integer = 0
        While i < 5 AndAlso studenttable(i).Getotaldonations > 0
            Dim s As Student = studenttable(i)
            LblHigh.Text = $"{LblHigh.Text}{s.Name.PadRight(10)} {s.Getotaldonations.ToString("C2").PadLeft(8)}{vbNewLine}"
            i += 1
        End While

    End Sub

    Private Function GetClassTotalDOnations() As Double
        Dim total As Double = 0


        For Each s As Student In studenttable
            total += s.Getotaldonations

        Next
        Return total
    End Function




    Private Sub loadDonationListBox()
        LstStudentDonations.Items.Clear()
        Dim s As Student = CBOStudents.SelectedItem
        LstStudentDonations.Items.AddRange(s.Dontations.ToArray)

    End Sub

    Private Sub BtnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Dim amt As Double
        Dim valid As Boolean = Double.TryParse(TxtDonationAmt.Text, amt)
        If valid Then
            Dim s As Student = CBOStudents.SelectedItem
            s.Dontations.Add(New Donation(amt, Date.Now))
        End If
        UpdateValues()
    End Sub
    Private Sub savefiles()
        Dim json = JsonConvert.serializeobject(CBOStudents.Items)
        Dim writer = New IO.StreamWriter(strSTUDENTFILE)
        writer.Write(json)
        writer.Close()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        savefiles()

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim s As Student = CBOStudents.SelectedItem
        Dim d As Donation = LstStudentDonations.SelectedItem
        If Not IsNothing(s) AndAlso Not IsNothing(d) Then
            s.Dontations.Remove(d)
            UpdateValues()
        End If



    End Sub
End Class

Public Class Student
    Private _name As String
    Private _dontations As List(Of Donation)

    Public Sub New(name As String, donations As List(Of Donation))
        Me.Name = name
        Me.Dontations = donations
    End Sub
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Dontations As List(Of Donation)
        Get
            Return _dontations
        End Get
        Set(value As List(Of Donation))
            _dontations = value
        End Set
    End Property
    Public Function Getotaldonations() As Double
        Dim total As Double = 0
        For Each d As Donation In Dontations
            total += d.Amount

        Next

        Return total
    End Function
    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class

Public Class Donation
    Private _amount As Double
    Private _theDate As Date

    Public Property Amount As Double
        Get
            Return _amount
        End Get
        Set(value As Double)
            _amount = value
        End Set
    End Property

    Public Property TheDate As Date
        Get
            Return _theDate
        End Get
        Set(value As Date)
            _theDate = value
        End Set
    End Property

    Public Sub New(amount As Double, theDate As Date)
        Me.Amount = amount
        Me.TheDate = theDate
    End Sub

    Public Overrides Function tostring() As String
        Return Amount.ToString("C2").PadRight(10) & Me.TheDate.ToLocalTime

    End Function

End Class
