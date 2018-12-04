<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Page1NextStepButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TargetPathTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OriginalPathSelectTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Page2NextStepButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Page2FindPicButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ifOverwriteCheckBox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.TargetPathLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.itemsLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.Page3CopyButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.TargetPathSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.OriginalPathSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Page1NextStepButton
        '
        Me.Page1NextStepButton.Depth = 0
        Me.Page1NextStepButton.Location = New System.Drawing.Point(313, 174)
        Me.Page1NextStepButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.Page1NextStepButton.Name = "Page1NextStepButton"
        Me.Page1NextStepButton.Primary = True
        Me.Page1NextStepButton.Size = New System.Drawing.Size(122, 66)
        Me.Page1NextStepButton.TabIndex = 1
        Me.Page1NextStepButton.Text = "Next Step"
        Me.Page1NextStepButton.UseVisualStyleBackColor = True
        '
        'TargetPathTextBox
        '
        Me.TargetPathTextBox.Depth = 0
        Me.TargetPathTextBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TargetPathTextBox.Hint = ""
        Me.TargetPathTextBox.Location = New System.Drawing.Point(224, 115)
        Me.TargetPathTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.TargetPathTextBox.Name = "TargetPathTextBox"
        Me.TargetPathTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TargetPathTextBox.SelectedText = ""
        Me.TargetPathTextBox.SelectionLength = 0
        Me.TargetPathTextBox.SelectionStart = 0
        Me.TargetPathTextBox.Size = New System.Drawing.Size(348, 28)
        Me.TargetPathTextBox.TabIndex = 2
        Me.TargetPathTextBox.Text = "D:\工程\委托2\"
        Me.TargetPathTextBox.UseSystemPasswordChar = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Depth = 0
        Me.TabControl1.Location = New System.Drawing.Point(6, 118)
        Me.TabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 401)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.OriginalPathSelectTextBox)
        Me.TabPage1.Controls.Add(Me.MaterialLabel2)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.Page1NextStepButton)
        Me.TabPage1.Controls.Add(Me.TargetPathTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(807, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(439, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OriginalPathSelectTextBox
        '
        Me.OriginalPathSelectTextBox.Depth = 0
        Me.OriginalPathSelectTextBox.Hint = ""
        Me.OriginalPathSelectTextBox.Location = New System.Drawing.Point(224, 63)
        Me.OriginalPathSelectTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.OriginalPathSelectTextBox.Name = "OriginalPathSelectTextBox"
        Me.OriginalPathSelectTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OriginalPathSelectTextBox.SelectedText = ""
        Me.OriginalPathSelectTextBox.SelectionLength = 0
        Me.OriginalPathSelectTextBox.SelectionStart = 0
        Me.OriginalPathSelectTextBox.Size = New System.Drawing.Size(334, 28)
        Me.OriginalPathSelectTextBox.TabIndex = 5
        Me.OriginalPathSelectTextBox.Text = "D:\工程\委托"
        Me.OriginalPathSelectTextBox.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(147, 60)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(53, 24)
        Me.MaterialLabel2.TabIndex = 4
        Me.MaterialLabel2.Text = "Path:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(93, 115)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(107, 24)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "TargetPath:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Page2NextStepButton)
        Me.TabPage2.Controls.Add(Me.Page2FindPicButton)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(807, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Page2NextStepButton
        '
        Me.Page2NextStepButton.AutoSize = True
        Me.Page2NextStepButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Page2NextStepButton.Depth = 0
        Me.Page2NextStepButton.Location = New System.Drawing.Point(696, 322)
        Me.Page2NextStepButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Page2NextStepButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.Page2NextStepButton.Name = "Page2NextStepButton"
        Me.Page2NextStepButton.Primary = False
        Me.Page2NextStepButton.Size = New System.Drawing.Size(102, 36)
        Me.Page2NextStepButton.TabIndex = 2
        Me.Page2NextStepButton.Text = "Next Step"
        Me.Page2NextStepButton.UseVisualStyleBackColor = True
        Me.Page2NextStepButton.Visible = False
        '
        'Page2FindPicButton
        '
        Me.Page2FindPicButton.Depth = 0
        Me.Page2FindPicButton.Location = New System.Drawing.Point(6, 322)
        Me.Page2FindPicButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.Page2FindPicButton.Name = "Page2FindPicButton"
        Me.Page2FindPicButton.Primary = True
        Me.Page2FindPicButton.Size = New System.Drawing.Size(329, 41)
        Me.Page2FindPicButton.TabIndex = 0
        Me.Page2FindPicButton.Text = "Find pics in folder"
        Me.Page2FindPicButton.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(801, 313)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ifOverwriteCheckBox)
        Me.TabPage3.Controls.Add(Me.TargetPathLabel)
        Me.TabPage3.Controls.Add(Me.MaterialLabel4)
        Me.TabPage3.Controls.Add(Me.MaterialLabel3)
        Me.TabPage3.Controls.Add(Me.itemsLabel)
        Me.TabPage3.Controls.Add(Me.Page3CopyButton)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(807, 372)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ifOverwriteCheckBox
        '
        Me.ifOverwriteCheckBox.AutoSize = True
        Me.ifOverwriteCheckBox.Depth = 0
        Me.ifOverwriteCheckBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.ifOverwriteCheckBox.Location = New System.Drawing.Point(333, 152)
        Me.ifOverwriteCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ifOverwriteCheckBox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.ifOverwriteCheckBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.ifOverwriteCheckBox.Name = "ifOverwriteCheckBox"
        Me.ifOverwriteCheckBox.Ripple = True
        Me.ifOverwriteCheckBox.Size = New System.Drawing.Size(105, 30)
        Me.ifOverwriteCheckBox.TabIndex = 5
        Me.ifOverwriteCheckBox.Text = "Overwrite"
        Me.ifOverwriteCheckBox.UseVisualStyleBackColor = True
        '
        'TargetPathLabel
        '
        Me.TargetPathLabel.AutoSize = True
        Me.TargetPathLabel.BackColor = System.Drawing.Color.Transparent
        Me.TargetPathLabel.Depth = 0
        Me.TargetPathLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.TargetPathLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TargetPathLabel.Location = New System.Drawing.Point(365, 111)
        Me.TargetPathLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.TargetPathLabel.Name = "TargetPathLabel"
        Me.TargetPathLabel.Size = New System.Drawing.Size(102, 24)
        Me.TargetPathLabel.TabIndex = 3
        Me.TargetPathLabel.Text = "TargetPath"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(252, 111)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(107, 24)
        Me.MaterialLabel4.TabIndex = 4
        Me.MaterialLabel4.Text = "TargetPath:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(296, 70)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(63, 24)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "Items:"
        '
        'itemsLabel
        '
        Me.itemsLabel.AutoSize = True
        Me.itemsLabel.Depth = 0
        Me.itemsLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.itemsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.itemsLabel.Location = New System.Drawing.Point(365, 70)
        Me.itemsLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.itemsLabel.Name = "itemsLabel"
        Me.itemsLabel.Size = New System.Drawing.Size(104, 24)
        Me.itemsLabel.TabIndex = 1
        Me.itemsLabel.Text = "itemsLabel"
        '
        'Page3CopyButton
        '
        Me.Page3CopyButton.Depth = 0
        Me.Page3CopyButton.Location = New System.Drawing.Point(274, 197)
        Me.Page3CopyButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.Page3CopyButton.Name = "Page3CopyButton"
        Me.Page3CopyButton.Primary = True
        Me.Page3CopyButton.Size = New System.Drawing.Size(224, 96)
        Me.Page3CopyButton.TabIndex = 0
        Me.Page3CopyButton.Text = "Copy"
        Me.Page3CopyButton.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.TabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-1, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(822, 48)
        Me.MaterialTabSelector1.TabIndex = 3
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 495)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Page1NextStepButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TargetPathTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents TargetPathSelect As FolderBrowserDialog
    Friend WithEvents OriginalPathSelectTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents OriginalPathSelect As FolderBrowserDialog
    Friend WithEvents Page2FindPicButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents itemsLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Page3CopyButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TargetPathLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ifOverwriteCheckBox As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Page2NextStepButton As MaterialSkin.Controls.MaterialFlatButton
End Class
