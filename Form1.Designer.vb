<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dtvMatriz = New DataGridView()
        dtvDiagonal = New DataGridView()
        dtvContraDiagonal = New DataGridView()
        cmdEjecutar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(dtvMatriz, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvDiagonal, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvContraDiagonal, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtvMatriz
        ' 
        dtvMatriz.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        dtvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvMatriz.Location = New Point(15, 42)
        dtvMatriz.Name = "dtvMatriz"
        dtvMatriz.RowHeadersWidth = 51
        dtvMatriz.Size = New Size(380, 194)
        dtvMatriz.TabIndex = 0
        ' 
        ' dtvDiagonal
        ' 
        dtvDiagonal.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        dtvDiagonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvDiagonal.Location = New Point(15, 350)
        dtvDiagonal.Name = "dtvDiagonal"
        dtvDiagonal.RowHeadersWidth = 51
        dtvDiagonal.Size = New Size(380, 88)
        dtvDiagonal.TabIndex = 1
        ' 
        ' dtvContraDiagonal
        ' 
        dtvContraDiagonal.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        dtvContraDiagonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvContraDiagonal.Location = New Point(463, 353)
        dtvContraDiagonal.Name = "dtvContraDiagonal"
        dtvContraDiagonal.RowHeadersWidth = 51
        dtvContraDiagonal.Size = New Size(380, 85)
        dtvContraDiagonal.TabIndex = 2
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        cmdEjecutar.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        cmdEjecutar.Location = New Point(602, 114)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(134, 64)
        cmdEjecutar.TabIndex = 3
        cmdEjecutar.Text = "Mostrar"
        cmdEjecutar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(52, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 35)
        Label1.TabIndex = 4
        Label1.Text = "Matriz"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label2.Location = New Point(54, 287)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 35)
        Label2.TabIndex = 5
        Label2.Text = "Diagonal de la Matriz"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label3.Location = New Point(474, 287)
        Label3.Name = "Label3"
        Label3.Size = New Size(340, 35)
        Label3.TabIndex = 6
        Label3.Text = "Contradiagonal de la Matriz"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(855, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmdEjecutar)
        Controls.Add(dtvContraDiagonal)
        Controls.Add(dtvDiagonal)
        Controls.Add(dtvMatriz)
        Name = "Form1"
        Text = "Diagonales"
        CType(dtvMatriz, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvDiagonal, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvContraDiagonal, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtvMatriz As DataGridView
    Friend WithEvents dtvDiagonal As DataGridView
    Friend WithEvents dtvContraDiagonal As DataGridView
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
