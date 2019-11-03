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
        Me.combo_network = New System.Windows.Forms.ComboBox()
        Me.label_mactext = New System.Windows.Forms.Label()
        Me.mac_text = New System.Windows.Forms.TextBox()
        Me.bt_defaultmac = New System.Windows.Forms.Button()
        Me.bt_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'combo_network
        '
        Me.combo_network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_network.FormattingEnabled = True
        Me.combo_network.Location = New System.Drawing.Point(105, 12)
        Me.combo_network.Name = "combo_network"
        Me.combo_network.Size = New System.Drawing.Size(243, 21)
        Me.combo_network.Sorted = True
        Me.combo_network.TabIndex = 1
        '
        'label_mactext
        '
        Me.label_mactext.AutoSize = True
        Me.label_mactext.Location = New System.Drawing.Point(102, 48)
        Me.label_mactext.Name = "label_mactext"
        Me.label_mactext.Size = New System.Drawing.Size(13, 13)
        Me.label_mactext.TabIndex = 1
        Me.label_mactext.Text = "?"
        '
        'mac_text
        '
        Me.mac_text.Location = New System.Drawing.Point(105, 75)
        Me.mac_text.Name = "mac_text"
        Me.mac_text.Size = New System.Drawing.Size(244, 20)
        Me.mac_text.TabIndex = 2
        '
        'bt_defaultmac
        '
        Me.bt_defaultmac.Location = New System.Drawing.Point(105, 101)
        Me.bt_defaultmac.Name = "bt_defaultmac"
        Me.bt_defaultmac.Size = New System.Drawing.Size(121, 23)
        Me.bt_defaultmac.TabIndex = 3
        Me.bt_defaultmac.Text = "Default Mac"
        Me.bt_defaultmac.UseVisualStyleBackColor = True
        '
        'bt_update
        '
        Me.bt_update.Location = New System.Drawing.Point(228, 101)
        Me.bt_update.Name = "bt_update"
        Me.bt_update.Size = New System.Drawing.Size(121, 23)
        Me.bt_update.TabIndex = 4
        Me.bt_update.Text = "Set Custom Mac"
        Me.bt_update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Network Adapter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Currrent Mac :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mac To Set :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Generate Random Mac"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 156)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_update)
        Me.Controls.Add(Me.bt_defaultmac)
        Me.Controls.Add(Me.mac_text)
        Me.Controls.Add(Me.label_mactext)
        Me.Controls.Add(Me.combo_network)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "IP Change  ~ 𝒥𝑜𝓇𝒹𝒶𝓃"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combo_network As System.Windows.Forms.ComboBox
    Friend WithEvents label_mactext As System.Windows.Forms.Label
    Friend WithEvents mac_text As System.Windows.Forms.TextBox
    Friend WithEvents bt_defaultmac As System.Windows.Forms.Button
    Friend WithEvents bt_update As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
