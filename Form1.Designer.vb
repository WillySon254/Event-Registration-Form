<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        cmbTicket = New ComboBox()
        btnRegister = New Button()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(207, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 33)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRATION FORM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Cursor = Cursors.IBeam
        txtName.Location = New Point(185, 122)
        txtName.Name = "txtName"
        txtName.Size = New Size(415, 23)
        txtName.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 3
        Label3.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(185, 199)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(415, 23)
        txtEmail.TabIndex = 4
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(185, 276)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(415, 23)
        txtPhone.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(185, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 6
        Label4.Text = "Phone Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(185, 312)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 7
        Label5.Text = "Ticket Type"
        ' 
        ' cmbTicket
        ' 
        cmbTicket.FlatStyle = FlatStyle.Flat
        cmbTicket.FormattingEnabled = True
        cmbTicket.Location = New Point(185, 339)
        cmbTicket.Name = "cmbTicket"
        cmbTicket.Size = New Size(408, 23)
        cmbTicket.TabIndex = 8
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(185, 380)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(406, 43)
        btnRegister.TabIndex = 9
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Yu Gothic UI", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(272, 453)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(237, 30)
        lblStatus.TabIndex = 10
        lblStatus.Text = "Registration Successful!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 526)
        Controls.Add(lblStatus)
        Controls.Add(btnRegister)
        Controls.Add(cmbTicket)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTicket As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblStatus As Label

End Class
