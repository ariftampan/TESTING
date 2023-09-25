<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.pnlClose = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.ctrlboxMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlboxMaximize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblWelcomeApplication = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.pnRegister = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txtRegPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCreateAccount = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBackLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCreateNewAccount = New System.Windows.Forms.Label()
        Me.pnLogin = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblinkForgetMe = New System.Windows.Forms.LinkLabel()
        Me.lblRememberMe = New System.Windows.Forms.Label()
        Me.tglswtchRememberMe = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.txtLogPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLogCreateAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.lblLoginContinue = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pcFrmStart1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtLogUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlClose.SuspendLayout()
        Me.pnRegister.SuspendLayout()
        Me.pnLogin.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcFrmStart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlClose
        '
        Me.pnlClose.BackColor = System.Drawing.Color.Transparent
        Me.pnlClose.BorderColor = System.Drawing.Color.LightGray
        Me.pnlClose.BorderThickness = 1
        Me.pnlClose.Controls.Add(Me.lblAppName)
        Me.pnlClose.Controls.Add(Me.ctrlboxMinimize)
        Me.pnlClose.Controls.Add(Me.ctrlboxMaximize)
        Me.pnlClose.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Transition1.SetDecoration(Me.pnlClose, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlClose.Location = New System.Drawing.Point(0, 0)
        Me.pnlClose.Name = "pnlClose"
        Me.pnlClose.Size = New System.Drawing.Size(1186, 47)
        Me.pnlClose.TabIndex = 0
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lblAppName, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(12, 9)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(150, 31)
        Me.lblAppName.TabIndex = 4
        Me.lblAppName.Text = "Application 3"
        '
        'ctrlboxMinimize
        '
        Me.ctrlboxMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlboxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.ctrlboxMinimize, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ctrlboxMinimize.FillColor = System.Drawing.Color.Transparent
        Me.ctrlboxMinimize.IconColor = System.Drawing.Color.Gray
        Me.ctrlboxMinimize.Location = New System.Drawing.Point(1039, 3)
        Me.ctrlboxMinimize.Name = "ctrlboxMinimize"
        Me.ctrlboxMinimize.PressedColor = System.Drawing.Color.DarkGray
        Me.ctrlboxMinimize.Size = New System.Drawing.Size(42, 41)
        Me.ctrlboxMinimize.TabIndex = 3
        '
        'ctrlboxMaximize
        '
        Me.ctrlboxMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlboxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2Transition1.SetDecoration(Me.ctrlboxMaximize, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ctrlboxMaximize.FillColor = System.Drawing.Color.Transparent
        Me.ctrlboxMaximize.IconColor = System.Drawing.Color.Gray
        Me.ctrlboxMaximize.Location = New System.Drawing.Point(1087, 3)
        Me.ctrlboxMaximize.Name = "ctrlboxMaximize"
        Me.ctrlboxMaximize.PressedColor = System.Drawing.Color.DarkGray
        Me.ctrlboxMaximize.Size = New System.Drawing.Size(42, 41)
        Me.ctrlboxMaximize.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1135, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(42, 41)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.lblCompanyName, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblCompanyName.Font = New System.Drawing.Font("Segoe UI", 13.28!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.Black
        Me.lblCompanyName.Location = New System.Drawing.Point(90, 110)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(178, 31)
        Me.lblCompanyName.TabIndex = 4
        Me.lblCompanyName.Text = "Eltran Indonesia"
        '
        'lblWelcomeApplication
        '
        Me.lblWelcomeApplication.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcomeApplication.AutoSize = True
        Me.lblWelcomeApplication.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.lblWelcomeApplication, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblWelcomeApplication.Font = New System.Drawing.Font("Segoe UI Semibold", 19.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeApplication.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblWelcomeApplication.Location = New System.Drawing.Point(792, 165)
        Me.lblWelcomeApplication.Name = "lblWelcomeApplication"
        Me.lblWelcomeApplication.Size = New System.Drawing.Size(378, 45)
        Me.lblWelcomeApplication.TabIndex = 6
        Me.lblWelcomeApplication.Text = "Welcome to Application!"
        Me.lblWelcomeApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.DragMode = Guna.UI2.WinForms.Enums.DragMode.Control
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation3
        '
        'pnRegister
        '
        Me.pnRegister.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnRegister.BackColor = System.Drawing.Color.Transparent
        Me.pnRegister.Controls.Add(Me.txtRegUsername)
        Me.pnRegister.Controls.Add(Me.txtRegPassword)
        Me.pnRegister.Controls.Add(Me.txtRegEmail)
        Me.pnRegister.Controls.Add(Me.btnCreateAccount)
        Me.pnRegister.Controls.Add(Me.btnBackLogin)
        Me.pnRegister.Controls.Add(Me.lblCreateNewAccount)
        Me.Guna2Transition1.SetDecoration(Me.pnRegister, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnRegister.FillColor = System.Drawing.Color.White
        Me.pnRegister.Location = New System.Drawing.Point(782, 213)
        Me.pnRegister.Name = "pnRegister"
        Me.pnRegister.Radius = 10
        Me.pnRegister.ShadowColor = System.Drawing.Color.Navy
        Me.pnRegister.ShadowDepth = 60
        Me.pnRegister.ShadowShift = 4
        Me.pnRegister.Size = New System.Drawing.Size(327, 350)
        Me.pnRegister.TabIndex = 7
        '
        'txtRegPassword
        '
        Me.txtRegPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPassword.BorderRadius = 8
        Me.txtRegPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtRegPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtRegPassword.DefaultText = ""
        Me.txtRegPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRegPassword.ForeColor = System.Drawing.Color.Black
        Me.txtRegPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPassword.IconLeft = Global.Application3.My.Resources.Resources.icons8_password_48
        Me.txtRegPassword.Location = New System.Drawing.Point(49, 156)
        Me.txtRegPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegPassword.Name = "txtRegPassword"
        Me.txtRegPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRegPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtRegPassword.PlaceholderText = "Password"
        Me.txtRegPassword.SelectedText = ""
        Me.txtRegPassword.Size = New System.Drawing.Size(229, 39)
        Me.txtRegPassword.TabIndex = 16
        Me.txtRegPassword.UseSystemPasswordChar = True
        '
        'txtRegEmail
        '
        Me.txtRegEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegEmail.BorderRadius = 8
        Me.txtRegEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtRegEmail, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtRegEmail.DefaultText = ""
        Me.txtRegEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRegEmail.ForeColor = System.Drawing.Color.Black
        Me.txtRegEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegEmail.IconLeft = Global.Application3.My.Resources.Resources.Email
        Me.txtRegEmail.Location = New System.Drawing.Point(49, 62)
        Me.txtRegEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtRegEmail.PlaceholderText = "Email"
        Me.txtRegEmail.SelectedText = ""
        Me.txtRegEmail.Size = New System.Drawing.Size(229, 39)
        Me.txtRegEmail.TabIndex = 12
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateAccount.Animated = True
        Me.btnCreateAccount.AutoRoundedCorners = True
        Me.btnCreateAccount.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.btnCreateAccount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateAccount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateAccount.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCreateAccount.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.Location = New System.Drawing.Point(49, 220)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(229, 45)
        Me.btnCreateAccount.TabIndex = 14
        Me.btnCreateAccount.Text = "CREATE ACCOUNT"
        '
        'btnBackLogin
        '
        Me.btnBackLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackLogin.Animated = True
        Me.btnBackLogin.AutoRoundedCorners = True
        Me.btnBackLogin.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.btnBackLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnBackLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackLogin.FillColor = System.Drawing.Color.Transparent
        Me.btnBackLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnBackLogin.ForeColor = System.Drawing.Color.Black
        Me.btnBackLogin.Image = Global.Application3.My.Resources.Resources.Left
        Me.btnBackLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBackLogin.Location = New System.Drawing.Point(49, 282)
        Me.btnBackLogin.Name = "btnBackLogin"
        Me.btnBackLogin.Size = New System.Drawing.Size(229, 45)
        Me.btnBackLogin.TabIndex = 15
        Me.btnBackLogin.Text = "Back to Login"
        '
        'lblCreateNewAccount
        '
        Me.lblCreateNewAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreateNewAccount.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lblCreateNewAccount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblCreateNewAccount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateNewAccount.Location = New System.Drawing.Point(111, 23)
        Me.lblCreateNewAccount.Name = "lblCreateNewAccount"
        Me.lblCreateNewAccount.Size = New System.Drawing.Size(117, 25)
        Me.lblCreateNewAccount.TabIndex = 0
        Me.lblCreateNewAccount.Text = "Register Here"
        '
        'pnLogin
        '
        Me.pnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnLogin.Controls.Add(Me.txtLogUsername)
        Me.pnLogin.Controls.Add(Me.lblinkForgetMe)
        Me.pnLogin.Controls.Add(Me.lblRememberMe)
        Me.pnLogin.Controls.Add(Me.tglswtchRememberMe)
        Me.pnLogin.Controls.Add(Me.txtLogPassword)
        Me.pnLogin.Controls.Add(Me.btnLogin)
        Me.pnLogin.Controls.Add(Me.btnLogCreateAccount)
        Me.pnLogin.Controls.Add(Me.lblLoginContinue)
        Me.Guna2Transition1.SetDecoration(Me.pnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnLogin.FillColor = System.Drawing.Color.White
        Me.pnLogin.Location = New System.Drawing.Point(782, 213)
        Me.pnLogin.Name = "pnLogin"
        Me.pnLogin.Radius = 10
        Me.pnLogin.ShadowColor = System.Drawing.Color.Navy
        Me.pnLogin.ShadowDepth = 60
        Me.pnLogin.ShadowShift = 4
        Me.pnLogin.Size = New System.Drawing.Size(327, 350)
        Me.pnLogin.TabIndex = 17
        '
        'lblinkForgetMe
        '
        Me.lblinkForgetMe.AutoSize = True
        Me.lblinkForgetMe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.lblinkForgetMe, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblinkForgetMe.Font = New System.Drawing.Font("Segoe UI", 7.28!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinkForgetMe.Location = New System.Drawing.Point(212, 176)
        Me.lblinkForgetMe.Name = "lblinkForgetMe"
        Me.lblinkForgetMe.Size = New System.Drawing.Size(69, 17)
        Me.lblinkForgetMe.TabIndex = 20
        Me.lblinkForgetMe.TabStop = True
        Me.lblinkForgetMe.Text = "Forget Me"
        '
        'lblRememberMe
        '
        Me.lblRememberMe.AutoSize = True
        Me.lblRememberMe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.lblRememberMe, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblRememberMe.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRememberMe.Location = New System.Drawing.Point(82, 178)
        Me.lblRememberMe.Name = "lblRememberMe"
        Me.lblRememberMe.Size = New System.Drawing.Size(95, 17)
        Me.lblRememberMe.TabIndex = 19
        Me.lblRememberMe.Text = "Remember Me"
        '
        'tglswtchRememberMe
        '
        Me.tglswtchRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tglswtchRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tglswtchRememberMe.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tglswtchRememberMe.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.tglswtchRememberMe, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tglswtchRememberMe.Location = New System.Drawing.Point(49, 178)
        Me.tglswtchRememberMe.Name = "tglswtchRememberMe"
        Me.tglswtchRememberMe.Size = New System.Drawing.Size(30, 18)
        Me.tglswtchRememberMe.TabIndex = 18
        Me.tglswtchRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tglswtchRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tglswtchRememberMe.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tglswtchRememberMe.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'txtLogPassword
        '
        Me.txtLogPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogPassword.BorderRadius = 8
        Me.txtLogPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtLogPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtLogPassword.DefaultText = ""
        Me.txtLogPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLogPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLogPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLogPassword.ForeColor = System.Drawing.Color.Black
        Me.txtLogPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogPassword.IconLeft = Global.Application3.My.Resources.Resources.icons8_password_48
        Me.txtLogPassword.Location = New System.Drawing.Point(49, 119)
        Me.txtLogPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLogPassword.Name = "txtLogPassword"
        Me.txtLogPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtLogPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtLogPassword.PlaceholderText = "Password"
        Me.txtLogPassword.SelectedText = ""
        Me.txtLogPassword.Size = New System.Drawing.Size(229, 39)
        Me.txtLogPassword.TabIndex = 16
        Me.txtLogPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.Animated = True
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(49, 220)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(229, 45)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.Text = "LOGIN"
        '
        'btnLogCreateAccount
        '
        Me.btnLogCreateAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogCreateAccount.Animated = True
        Me.btnLogCreateAccount.AutoRoundedCorners = True
        Me.btnLogCreateAccount.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.btnLogCreateAccount, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnLogCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogCreateAccount.FillColor = System.Drawing.Color.Transparent
        Me.btnLogCreateAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnLogCreateAccount.ForeColor = System.Drawing.Color.Black
        Me.btnLogCreateAccount.Image = Global.Application3.My.Resources.Resources.Right
        Me.btnLogCreateAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnLogCreateAccount.Location = New System.Drawing.Point(49, 282)
        Me.btnLogCreateAccount.Name = "btnLogCreateAccount"
        Me.btnLogCreateAccount.Size = New System.Drawing.Size(229, 45)
        Me.btnLogCreateAccount.TabIndex = 15
        Me.btnLogCreateAccount.Text = "Create Account"
        '
        'lblLoginContinue
        '
        Me.lblLoginContinue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoginContinue.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lblLoginContinue, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblLoginContinue.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginContinue.Location = New System.Drawing.Point(92, 23)
        Me.lblLoginContinue.Name = "lblLoginContinue"
        Me.lblLoginContinue.Size = New System.Drawing.Size(154, 25)
        Me.lblLoginContinue.TabIndex = 0
        Me.lblLoginContinue.Text = "Login to Continue"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Transition1.SetDecoration(Me.PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox4.Location = New System.Drawing.Point(53, 111)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'pcFrmStart1
        '
        Me.pcFrmStart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcFrmStart1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.pcFrmStart1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pcFrmStart1.Image = Global.Application3.My.Resources.Resources._4380
        Me.pcFrmStart1.ImageRotate = 0!
        Me.pcFrmStart1.Location = New System.Drawing.Point(0, 110)
        Me.pcFrmStart1.Name = "pcFrmStart1"
        Me.pcFrmStart1.Size = New System.Drawing.Size(754, 537)
        Me.pcFrmStart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcFrmStart1.TabIndex = 1
        Me.pcFrmStart1.TabStop = False
        Me.pcFrmStart1.UseTransparentBackground = True
        '
        'txtLogUsername
        '
        Me.txtLogUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogUsername.BorderRadius = 8
        Me.txtLogUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtLogUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtLogUsername.DefaultText = ""
        Me.txtLogUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLogUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLogUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLogUsername.ForeColor = System.Drawing.Color.Black
        Me.txtLogUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogUsername.IconLeft = Global.Application3.My.Resources.Resources.icons8_user_48__1_
        Me.txtLogUsername.Location = New System.Drawing.Point(49, 62)
        Me.txtLogUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLogUsername.Name = "txtLogUsername"
        Me.txtLogUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLogUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtLogUsername.PlaceholderText = "Username"
        Me.txtLogUsername.SelectedText = ""
        Me.txtLogUsername.Size = New System.Drawing.Size(229, 39)
        Me.txtLogUsername.TabIndex = 21
        '
        'txtRegUsername
        '
        Me.txtRegUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.BorderRadius = 8
        Me.txtRegUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtRegUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtRegUsername.DefaultText = ""
        Me.txtRegUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRegUsername.ForeColor = System.Drawing.Color.Black
        Me.txtRegUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.IconLeft = Global.Application3.My.Resources.Resources.icons8_user_48__1_
        Me.txtRegUsername.Location = New System.Drawing.Point(49, 109)
        Me.txtRegUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtRegUsername.PlaceholderText = "Username"
        Me.txtRegUsername.SelectedText = ""
        Me.txtRegUsername.Size = New System.Drawing.Size(229, 39)
        Me.txtRegUsername.TabIndex = 22
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1186, 727)
        Me.Controls.Add(Me.pnLogin)
        Me.Controls.Add(Me.pnRegister)
        Me.Controls.Add(Me.lblWelcomeApplication)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.pcFrmStart1)
        Me.Controls.Add(Me.pnlClose)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStart"
        Me.pnlClose.ResumeLayout(False)
        Me.pnlClose.PerformLayout()
        Me.pnRegister.ResumeLayout(False)
        Me.pnRegister.PerformLayout()
        Me.pnLogin.ResumeLayout(False)
        Me.pnLogin.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcFrmStart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlClose As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlboxMaximize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlboxMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pcFrmStart1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblAppName As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblWelcomeApplication As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents pnRegister As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblCreateNewAccount As Label
    Friend WithEvents txtRegPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCreateAccount As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBackLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnLogin As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txtLogPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnLogCreateAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblLoginContinue As Label
    Friend WithEvents lblinkForgetMe As LinkLabel
    Friend WithEvents lblRememberMe As Label
    Friend WithEvents tglswtchRememberMe As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtLogUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegUsername As Guna.UI2.WinForms.Guna2TextBox
End Class
