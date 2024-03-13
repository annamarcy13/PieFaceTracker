<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDonationAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.CBOStudents = New System.Windows.Forms.ComboBox()
        Me.LblstudentAmt = New System.Windows.Forms.Label()
        Me.LstStudentDonations = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblStudentTotal = New System.Windows.Forms.Label()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblClassTotal = New System.Windows.Forms.Label()
        Me.LblHigh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'TxtDonationAmt
        '
        Me.TxtDonationAmt.Location = New System.Drawing.Point(410, 19)
        Me.TxtDonationAmt.Multiline = True
        Me.TxtDonationAmt.Name = "TxtDonationAmt"
        Me.TxtDonationAmt.Size = New System.Drawing.Size(120, 20)
        Me.TxtDonationAmt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Donation amount"
        '
        'btnDonate
        '
        Me.btnDonate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonate.Location = New System.Drawing.Point(563, 19)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(146, 37)
        Me.btnDonate.TabIndex = 4
        Me.btnDonate.Text = "Add donation"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'CBOStudents
        '
        Me.CBOStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOStudents.FormattingEnabled = True
        Me.CBOStudents.Location = New System.Drawing.Point(83, 21)
        Me.CBOStudents.Name = "CBOStudents"
        Me.CBOStudents.Size = New System.Drawing.Size(121, 21)
        Me.CBOStudents.TabIndex = 5
        '
        'LblstudentAmt
        '
        Me.LblstudentAmt.AutoSize = True
        Me.LblstudentAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblstudentAmt.Location = New System.Drawing.Point(79, 65)
        Me.LblstudentAmt.Name = "LblstudentAmt"
        Me.LblstudentAmt.Size = New System.Drawing.Size(0, 20)
        Me.LblstudentAmt.TabIndex = 6
        '
        'LstStudentDonations
        '
        Me.LstStudentDonations.FormattingEnabled = True
        Me.LstStudentDonations.Location = New System.Drawing.Point(16, 65)
        Me.LstStudentDonations.Name = "LstStudentDonations"
        Me.LstStudentDonations.Size = New System.Drawing.Size(188, 69)
        Me.LstStudentDonations.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Student Total:"
        '
        'LblStudentTotal
        '
        Me.LblStudentTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudentTotal.Location = New System.Drawing.Point(296, 270)
        Me.LblStudentTotal.Name = "LblStudentTotal"
        Me.LblStudentTotal.Size = New System.Drawing.Size(77, 20)
        Me.LblStudentTotal.TabIndex = 9
        Me.LblStudentTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnRemove
        '
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.Location = New System.Drawing.Point(16, 140)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(119, 32)
        Me.BtnRemove.TabIndex = 10
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total Donations"
        '
        'LblClassTotal
        '
        Me.LblClassTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblClassTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClassTotal.Location = New System.Drawing.Point(349, 228)
        Me.LblClassTotal.Name = "LblClassTotal"
        Me.LblClassTotal.Size = New System.Drawing.Size(163, 26)
        Me.LblClassTotal.TabIndex = 12
        '
        'LblHigh
        '
        Me.LblHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHigh.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHigh.Location = New System.Drawing.Point(563, 68)
        Me.LblHigh.Name = "LblHigh"
        Me.LblHigh.Size = New System.Drawing.Size(163, 158)
        Me.LblHigh.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(437, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Highest Donors"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 318)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblHigh)
        Me.Controls.Add(Me.LblClassTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.LblStudentTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstStudentDonations)
        Me.Controls.Add(Me.LblstudentAmt)
        Me.Controls.Add(Me.CBOStudents)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDonationAmt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDonationAmt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDonate As Button
    Friend WithEvents CBOStudents As ComboBox
    Friend WithEvents LblstudentAmt As Label
    Friend WithEvents LstStudentDonations As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblStudentTotal As Label
    Friend WithEvents BtnRemove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LblClassTotal As Label
    Friend WithEvents LblHigh As Label
    Friend WithEvents Label6 As Label
End Class
