
Imports System
Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Public Class MDIChlor : Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        frm01 = New frmOption1
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Public WithEvents mnuTop As System.Windows.Forms.MenuItem
    Public WithEvents _MnuProject_4 As System.Windows.Forms.MenuItem
    Public WithEvents _MnuProject_5 As System.Windows.Forms.MenuItem
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As MenuItem
    Friend WithEvents MenuItem11 As MenuItem
    Friend WithEvents MenuItem12 As MenuItem
    Friend WithEvents MenuItem13 As MenuItem
    Friend WithEvents MenuItem14 As MenuItem
    Friend WithEvents MenuItem15 As MenuItem
    Friend WithEvents MenuItem16 As MenuItem
    Friend WithEvents MenuItem7 As MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuTop = New System.Windows.Forms.MenuItem()
        Me._MnuProject_4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me._MnuProject_5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTop, Me.MenuItem1, Me.MenuItem5, Me.MenuItem3, Me.MenuItem10})
        '
        'mnuTop
        '
        Me.mnuTop.Index = 0
        Me.mnuTop.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me._MnuProject_4, Me.MenuItem14, Me.MenuItem15, Me.MenuItem13, Me._MnuProject_5})
        Me.mnuTop.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuTop.Text = "Pro&ject"
        '
        '_MnuProject_4
        '
        Me._MnuProject_4.Index = 0
        Me._MnuProject_4.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me._MnuProject_4.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "PhreeqC"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "FEM"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "OpenGl"
        '
        '_MnuProject_5
        '
        Me._MnuProject_5.Index = 4
        Me._MnuProject_5.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me._MnuProject_5.Text = "E&xit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "C&limat"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "MeteoFile"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem5.Text = "&Transport model"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Text = "&GeometryFile"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "In&put"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "&Calcul"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "&Graph"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem9})
        Me.MenuItem3.Text = "Probabilistic"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Analyse"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "Graph"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 4
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.MenuItem12})
        Me.MenuItem10.Text = "?"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "Manual"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "Version"
        '
        'MDIChlor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(773, 445)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(11, 57)
        Me.Menu = Me.MainMenu1
        Me.Name = "MDIChlor"
        Me.Text = "EPFL  Chloride Ion Penetration Model"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public CPTerase As Short = 0
    Dim Para5 As Short
    Dim frm01 As frmOption1
    Dim frmC As New frmChlor

    ' Xuande 10/06/2020
    Private Nodes() As NodeTrans
    Private Elements() As ElementTrans
    Private NNodes, NElements, Nbloc As Integer
    Private MeshFileOk = False

    'Lorsque la fen�tre est activ�e
    Private Sub MDIChlor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        My.Application.ChangeCulture("en-US")
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized

        frmC.Left = 0
        frmC.Top = 0
        frmC.Height = (Me.Height)
        frmC.Width = (Me.Width)
        frmC.Hide()
    End Sub

    'Programme de lecture des donnees maillage D. C et Xuande  10/06/2020
    '    Private Sub ReadFileMSH()

    '        ''''''''''''''''''''''''''''''''''''''''''''
    '        'lire des fichiers maillage
    '        Dim nFic As Integer = FreeFile()
    '        Dim OutFile As String
    '        Dim Filtre As String
    '        Dim Index As Short
    '        Dim Directoire As Boolean
    '        Dim Titre As String
    '        Dim Canc As Boolean = False
    '        Dim Temp As String
    '        Dim NCoorCont As Long
    '        Dim NCoorTemp As Long
    '        Dim NgCoor As Long
    '        Dim NNoeuds As Long
    '        Dim i As Long
    '        Dim j As Long
    '        Dim k As Long
    '        Dim LnTemp(0) As Long
    '        'Dim Bord(0) as Boolean false=pas bord true=bord
    '        'Dim NCoor(2, 0) As Double 'x,y + + num�ro de noeuds
    '        ''''''''''''''''''''''''''''''''''''''''''''
    '        Filtre = "Mesh files (*.msh)|*.msh"
    '        Index = 1
    '        Directoire = True
    '        Titre = "Select mesh file"
    '        OpenDialog(OutFile, Canc, Filtre, Index, Directoire, Titre)
    '        If Canc = True Then GoTo b
    '        '''''''''''''''''''''''''''''''''''''''''''''
    '        FileOpen(nFic, OutFile, OpenMode.Input, OpenAccess.Read, OpenShare.Shared)
    '        Do While Temp <> "$Entities"
    '            Input(nFic, Temp)
    '        Loop
    '        Input(nFic, NCoorCont)
    '        Do While Temp <> "$EndEntities"
    '            Input(nFic, Temp)
    '        Loop
    '        Do While Temp <> "$Nodes"
    '            Input(nFic, Temp)
    '        Loop


    '        Input(nFic, NgCoor)
    '        Input(nFic, NNoeuds)
    '        Input(nFic, Temp)
    '        Input(nFic, Temp)

    '        ReDim Bord(NNoeuds)

    '        For i = 0 To NNoeuds - 1
    '            Bord(i) = False
    '        Next
    '        ReDim NCoor(2, NNoeuds)
    '        For i = 1 To NCoorCont
    '            Input(nFic, j)
    '            For k = 0 To 2
    '                Input(nFic, NCoor(k, j))
    '            Next
    '            Bord(j) = True
    '            Input(nFic, Temp)
    '        Next
    '        For j = 0 To (NgCoor - 1) - NCoorCont
    '            For i = 1 To 4
    '                Input(nFic, NCoorTemp)
    '            Next
    '            ReDim LnTemp(NCoorTemp)
    '            For i = 0 To NCoorTemp - 1
    '                Input(nFic, LnTemp(i))
    '            Next
    '            For i = 0 To NCoorCont - 1
    '                For k = 0 To 2
    '                    Input(nFic, NCoor(k, LnTemp(i)))
    '                Next
    '                Bord(LnTemp(i)) = True  'a verifier
    '            Next
    '        Next
    '        Do While Temp <> "$EndNodes"
    '            Input(nFic, Temp)
    '        Loop
    '        Do While Temp <> "$Elements"
    '            Input(nFic, Temp)
    '        Loop
    '        'continuer avec la lecture de la connectivit�

    '        FileClose(nFic)
    'b:
    'terminer lecture des fichiers maillage
    ''''''''''''''''''''''''''''''''''''''''''''
    'End Sub

    'quitter le programme
    Private Sub _MnuProject_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _MnuProject_5.Click
        Me.Close()
        End
    End Sub

    'Ouverture de Input dans le menu d�roulant
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        frm01.ShowDialog()
        frm01.Hide()
        frm01.Close()
    End Sub

    'Lancement de Open dans le menu d�roulant
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        ' Moisture Parameters 
        ' Diffusion Coefficient
        Dim aa As Single ' Function coefficient
        Dim Hc As Single ' Function coefficient
        Dim ab As Single ' Function coefficient
        Dim tc As Single ' Function coefficient
        Dim ImpHydr As Boolean
        ' chloride
        Dim LambdaT(1) As Single
        Dim LambdaH(1) As Single
        Dim aOH As Single
        Dim EbG As Single
        Dim toG As Single
        Dim faG As Single
        Dim hMin As Single
        Dim hEcart As Single
        Dim wMin As Single
        Dim wEcart As Single
        Dim CTmin As Single
        Dim CTecart As Single
        Dim CLmin As Single
        Dim CLecart As Single
        Dim Tecart As Single
        Dim H_snap As Single
        Dim Retard As Single
        ' Structural data
        Dim TimeMax As Single
        Dim Length As Single 'length of the layer [mm]
        Dim Ne As Short 'Number of finite elements
        Dim Le(1) As Decimal 'element length
        Dim PosProf(1) As Decimal
        'Computational data
        Dim Dofs As Short
        'computationals values
        Dim Duration As Single
        Dim DeltaT As Single
        'boundary conditions
        Dim NEXPO As Short
        Dim NQUAL As Short
        Dim taff As Single
        Dim Hsauv As Single
        Dim Wsauv As Single
        Dim CTsauv As Single
        Dim CLsauv As Single
        Dim Tsauv As Single
        Dim Carbsauv As Single
        Dim Filebeton(1) As String
        Dim Fileres(1) As String
        Dim PD(1) As Single
        Dim qGran(1) As Single
        Dim Dcl(1) As Single
        Dim SAT(1) As Single
        Dim ciment(1) As Single
        Dim FileGexpo(1) As String
        Dim FileDexpo(1) As String
        Dim proba(1, 1) As Single
        Dim ChoixRep As Short
        Dim nChmt As Short
        Dim Nbreel(1) As Short
        Dim LenApp(1) As Single
        Dim EC(1) As Single
        Dim tProt(1) As Single
        Dim Vct(1) As Single
        Dim Nct(1) As Single
        Dim capCal As Single
        Dim Hydr(1) As Single
        '---------------------------------------------------------------------------------------
        'Lecture du fichier txt
        Dim Para1 As Single
        Dim Para2 As Single
        Dim Para3 As Single
        Dim Para4 As Single
        Dim test As Single
        Dim i As Short
        Dim j As Short
        Dim nFic As Integer = FreeFile()
        Dim OutFile As String
        Dim Filtre As String
        Dim Index As Short
        Dim Directoire As Boolean
        Dim Titre As String
        Dim Canc As Boolean = False
        Dim ED(1) As Single
        Dim ToHydr(1) As Single
        Dim Ecl(1) As Single
        Dim ToCl(1) As Single
        Dim PostFile As String
        Dim Creadtherm(1, 1) As Double
        Dim Creadhydr(1, 1) As Double
        Dim Creadion(1, 1) As Double
        Dim Ctherm(1) As Double
        Dim Chydr(1) As Double
        Dim Cion(1) As Double
        Dim Nbre1 As Short
        Dim Nbre2 As Short
        Dim Nbre3 As Short
        Dim Var As Double
        Dim Var1 As Double
        Dim GyCO2 As Single
        Dim DyCO2 As Single
        Dim RoC(1) As Single
        Dim RoA(1) As Single

        Dim Option2d As Boolean

        Dim PintermManual As Integer = 0

        ''''''''''''''''''''''''''''''''''''''''''''
        Filtre = "Text files (INPUT_*.txt)|INPUT_*.txt"
        Index = 1
        Directoire = True
        Titre = "S�lectionner le fichier d'exposition"
        OpenDialog(OutFile, Canc, Filtre, Index, Directoire, Titre)
        If Canc = True Then GoTo b
        ''''''''''''''''''''''''''''''''''''''''''''

        FileOpen(nFic, OutFile, OpenMode.Input, OpenAccess.Read, OpenShare.Shared)
        FilePost(OutFile, PostFile)

        Input(nFic, Length)
        Input(nFic, Ne)
        Input(nFic, ChoixRep)
        ReDim Le(Ne + CShort(1))
        ReDim PosProf(Ne + CShort(2))

        PosProf(1) = 0
        Select Case ChoixRep
            Case CShort(1)
                For i = CShort(1) To Ne
                    Le(i) = CDec(Length) / CDec(Ne)
                    PosProf(i + CShort(1)) = PosProf(i) + Le(i)
                Next i
            Case CShort(2)
                Input(nFic, Le(1))
                Para1 = CSng(0)
                Para2 = CSng(0)
                For i = CShort(1) To Ne / CShort(2) - CShort(1)
                    Para1 = Para1 + CSng(1)
                    Para2 = Para2 + Para1
                Next i
                If Le(1) > CDec(Length) Then GoTo b
                Para1 = (Length / CSng(2) - CSng(Ne) / CSng(2) * CSng(Le(1))) / Para2
                PosProf(2) = Le(1)
                PosProf(Ne + CShort(1)) = CDec(Length)
                PosProf(Ne) = CDec(Length) - Le(1)
                For i = CShort(2) To Ne / CShort(2)
                    Le(i) = Le(1) + (CDec(i) - CDec(1)) * CDec(Para1)
                    PosProf(i + CShort(1)) = PosProf(i) + Le(i)
                    Le(Ne - i) = Le(i)
                    PosProf(Ne + CShort(1) - i) = PosProf(Ne + CShort(2) - i) - Le(i)
                Next i
            Case 3
                Input(nFic, Le(1))
                Para3 = CSng(Le(1))
                test = CSng(10)
                If Le(1) > CDec(Length) Then GoTo b
                Do While System.Math.Abs(test) > 0.0001
                    Para1 = CSng(1) - Length / (CSng(2) * CSng(Le(1)))
                    Para2 = CSng(1)
                    For i = CShort(1) To Ne / CShort(2) - CShort(1)
                        Para1 = Para1 + Para3 ^ CSng(i)
                        If i < Ne / CShort(2) - CShort(1) Then Para2 = Para2 + (CSng(i) + CSng(1)) * Para3 ^ CSng(i)
                    Next i
                    Para4 = Para3 - Para1 / Para2
                    test = Para4 - Para3
                    Para3 = Para4
                Loop
                PosProf(2) = Le(1)
                PosProf(Ne + CShort(1)) = CDec(Length)
                PosProf(Ne) = CDec(Length) - Le(1)
                For i = CShort(2) To Ne / CShort(2)
                    Le(i) = Le(1) * CDec(Para4) ^ (CDec(i) - CDec(1))
                    PosProf(i + CShort(1)) = PosProf(i) + Le(i)
                    Le(Ne - i) = Le(i)
                    PosProf(Ne + CShort(1) - i) = PosProf(Ne + CShort(2) - i) - Le(i)
                Next i
            Case 4
                Input(nFic, nChmt)
                ReDim Nbreel(nChmt - CShort(1))
                ReDim LenApp(nChmt - CShort(1))
                PosProf(Ne + CShort(1)) = CDec(Length)
                Para1 = CSng(0)
                Para2 = CSng(0)
                For i = CShort(1) To nChmt - CShort(1)
                    Input(nFic, Nbreel(i))
                    Input(nFic, LenApp(i))
                    For j = CShort(1) To Nbreel(i)
                        Le(j + CShort(Para1)) = CDec(LenApp(i)) / CDec(Nbreel(i))
                        PosProf(j + CShort(1) + CShort(Para1)) = PosProf(j + CShort(Para1)) + Le(j + CShort(Para1))
                        Le(Ne + CShort(1) - j - CShort(Para1)) = Le(j + CShort(Para1))
                        PosProf(Ne + CShort(1) - j - CShort(Para1)) = PosProf(Ne + CShort(2) - j - CShort(Para1)) - Le(j + CShort(Para1))
                    Next j
                    Para1 = Para1 + CSng(Nbreel(i))
                    Para2 = Para2 + LenApp(i)
                Next i
                Para3 = CSng(Ne) - CSng(2) * Para1
                Para2 = Length - CSng(2) * Para2
                For i = CShort(Para1) + CShort(1) To CShort(Para1) + CShort(Para3)
                    Le(i) = CDec(Para2) / CDec(Para3)
                    PosProf(i + CShort(1)) = PosProf(i) + Le(i)
                Next i
            Case 5
                Input(nFic, nChmt)
                ReDim Nbreel(nChmt - CShort(1))
                ReDim LenApp(nChmt - CShort(1))
                PosProf(Ne + CShort(1)) = CDec(Length)
                Para1 = CSng(0)
                Para2 = CSng(0)
                For i = CShort(1) To nChmt - CShort(1)
                    Input(nFic, Nbreel(i))
                    Input(nFic, LenApp(i))
                    For j = CShort(1) To Nbreel(i)
                        Le(j + CShort(Para1)) = CDec(LenApp(i)) / CDec(Nbreel(i))
                        PosProf(j + CShort(1) + CShort(Para1)) = PosProf(j + CShort(Para1)) + Le(j + CShort(Para1))
                    Next j
                    Para1 = Para1 + CSng(Nbreel(i))
                    Para2 = Para2 + LenApp(i)
                Next i
                Para3 = CSng(Ne) - Para1
                Para2 = Length - Para2
                For i = CShort(Para1) + CShort(1) To CShort(Para1) + CShort(Para3)
                    Le(i) = CDec(Para2) / CDec(Para3)
                    PosProf(i + CShort(1)) = PosProf(i) + Le(i)
                Next i
        End Select

        Input(nFic, TimeMax)
        Input(nFic, DeltaT)
        Input(nFic, taff)
        Input(nFic, Hsauv)
        Input(nFic, Wsauv)
        Input(nFic, CTsauv)
        Input(nFic, CLsauv)
        Input(nFic, Tsauv)
        Input(nFic, Carbsauv)
        Input(nFic, hMin)
        Input(nFic, hEcart)
        Input(nFic, wMin)
        Input(nFic, wEcart)
        Input(nFic, CLmin)
        Input(nFic, CLecart)
        Input(nFic, CTmin)
        Input(nFic, CTecart)
        Input(nFic, Tecart)
        Input(nFic, aa)
        Input(nFic, Hc)
        Input(nFic, ab)
        Input(nFic, tc)
        Input(nFic, ImpHydr)
        Input(nFic, H_snap)
        Input(nFic, Retard)
        Input(nFic, aOH)
        Input(nFic, EbG)
        Input(nFic, toG)
        Input(nFic, faG)
        Input(nFic, capCal)
        Input(nFic, GyCO2)
        Input(nFic, DyCO2)

        Input(nFic, NEXPO)
        ReDim FileGexpo(NEXPO)
        ReDim FileDexpo(NEXPO)
        For i = CShort(1) To NEXPO
            Input(nFic, FileGexpo(i))
            Input(nFic, FileDexpo(i))
        Next i

        Input(nFic, NQUAL)
        ReDim Filebeton(NQUAL)
        ReDim Fileres(NQUAL)
        ReDim PD(NQUAL)
        ReDim Dcl(NQUAL)
        ReDim qGran(NQUAL)
        ReDim LambdaH(NQUAL)
        ReDim LambdaT(NQUAL)
        ReDim SAT(NQUAL)
        ReDim ciment(NQUAL)
        ReDim EC(NQUAL)
        ReDim tProt(NQUAL)
        ReDim Vct(NQUAL)
        ReDim Nct(NQUAL)
        ReDim Hydr(NQUAL)
        ReDim ED(NQUAL)
        ReDim ToHydr(NQUAL)
        ReDim Ecl(NQUAL)
        ReDim ToCl(NQUAL)
        ReDim RoA(NQUAL)
        ReDim RoC(NQUAL)
        ReDim proba(NQUAL, 19)
        For i = CShort(1) To NQUAL
            Input(nFic, Filebeton(i))
            Input(nFic, Fileres(i))
            Input(nFic, PD(i))
            Input(nFic, Dcl(i))
            Input(nFic, qGran(i))
            Input(nFic, LambdaH(i))
            Input(nFic, LambdaT(i))
            Input(nFic, SAT(i))
            Input(nFic, ciment(i))
            Input(nFic, EC(i))
            Input(nFic, tProt(i))
            Input(nFic, Hydr(i))
            Input(nFic, Vct(i))
            Input(nFic, Nct(i))
            Input(nFic, ED(i))
            Input(nFic, ToHydr(i))
            Input(nFic, Ecl(i))
            Input(nFic, ToCl(i))
            Input(nFic, RoA(i))
            Input(nFic, RoC(i))
            For j = 0 To 19
                Input(nFic, proba(i, j))
            Next
        Next i

        Input(nFic, Nbre1)
        ReDim Creadtherm(1, Nbre1)
        For i = 1 To Nbre1
            Input(nFic, Creadtherm(0, i))
            Input(nFic, Creadtherm(1, i))
        Next

        Input(nFic, Nbre2)
        ReDim Creadhydr(1, Nbre2)
        For i = 1 To Nbre2
            Input(nFic, Creadhydr(0, i))
            Input(nFic, Creadhydr(1, i))
            Creadhydr(1, i) = Creadhydr(1, i) / 100
        Next

        Input(nFic, Nbre3)
        ReDim Creadion(1, Nbre3)
        For i = 1 To Nbre3
            Input(nFic, Creadion(0, i))
            Input(nFic, Creadion(1, i))
        Next

        Dofs = Ne + CShort(1)
        'calcul des conditions initiales
        j = 0
        ReDim Ctherm(Dofs + 1)
        For i = 1 To Nbre1 - 1
            Var = (Creadtherm(1, i + 1) - Creadtherm(1, i)) / (Creadtherm(0, i + 1) - Creadtherm(0, i))
            Var1 = Creadtherm(1, i) - Var * Creadtherm(0, i)
            Do While PosProf(j) <= Creadtherm(0, i + 1)
                Ctherm(j) = Var * PosProf(j) + Var1
                j = j + 1
                If j > Dofs Then Exit Do
            Loop
            Ctherm(Dofs + 1) = Ctherm(Dofs)
        Next
        j = 0
        ReDim Chydr(Dofs + 1)
        For i = 1 To Nbre2 - 1
            Var = (Creadhydr(1, i + 1) - Creadhydr(1, i)) / (Creadhydr(0, i + 1) - Creadhydr(0, i))
            Var1 = Creadhydr(1, i) - Var * Creadhydr(0, i)
            Do While PosProf(j) <= Creadhydr(0, i + 1)
                Chydr(j) = Var * PosProf(j) + Var1
                j = j + 1
                If j > Dofs Then Exit Do
            Loop
            Chydr(Dofs + 1) = Chydr(Dofs)
            If j > Dofs + 1 Then Exit For
        Next
        j = 0
        ReDim Cion(Dofs + 1)
        For i = 1 To Nbre3 - 1
            Var = (Creadion(1, i + 1) - Creadion(1, i)) / (Creadion(0, i + 1) - Creadion(0, i))
            Var1 = Creadion(1, i) - Var * Creadion(0, i)
            Do While PosProf(j) <= Creadion(0, i + 1)
                Cion(j) = Var * PosProf(j) + Var1
                j = j + 1
                If j > Dofs Then Exit Do
            Loop
            Cion(Dofs + 1) = Cion(Dofs)
        Next

        Le(0) = CDec(1)       'couche limite
        Le(Dofs) = CDec(1)    'couche limite

        Input(nFic, Option2d)
        If Option2d = True And MeshFileOk = False Then
            Dim result As DialogResult = MsgBox("MeshFile doesn't found for 2D transport. Transport will be in 1D. Do you want to continue ?", MsgBoxStyle.YesNo, "Error with Mesh File")
            If result = DialogResult.Yes Then
                Option2d = False
            ElseIf result = DialogResult.No Then
                GoTo b
            End If
        End If

        Try
            Input(nFic, PintermManual)
            MsgBox("Le nombre de points est de" & CStr(PintermManual), MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Information Points de discretisation")
        Catch
            MsgBox("Attention aucun points pris en compte manuellement", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Information Points de discretisation")
        End Try

        FileClose(nFic)

        '---------------------------------------------------------------------------------------
        Dim myThread As System.Threading.Thread

        SetParameters(frmC, Length, Ne, ChoixRep, Le, PosProf, nChmt, Nbreel, LenApp, TimeMax, DeltaT, taff, Hsauv, Wsauv, CTsauv, CLsauv, Tsauv, Carbsauv, hMin, hEcart, wMin, wEcart, CLmin, CLecart, CTmin, CTecart, Tecart, aa, Hc, ab, tc, ImpHydr, H_snap, Retard, aOH, EbG, toG, faG, NEXPO, FileGexpo, FileDexpo, NQUAL, Filebeton, Fileres, PD, Dcl, capCal, LambdaH, LambdaT, SAT, ciment, EC, tProt, Vct, Nct, proba, Dofs, qGran, Hydr, ED, ToHydr, Ecl, ToCl, PostFile, Ctherm, Chydr, Cion, GyCO2, DyCO2, RoA, RoC, Option2d, PintermManual)

        myThread = New System.Threading.Thread(AddressOf Compute_All)

        frmC.MdiParent = Me
        frmC.Show()
        If Para5 <> CShort(1) Then
            myThread.Start()
        End If

b:      'user pressed cancel error

    End Sub

    'construction de graphique
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Using frm03 As New frmScale1
            frmC.MdiParent = Me
            frmC.Show()
            manage_graph(frmC, frm03)
        End Using
    End Sub

    'traitement des donn�es m�t�orologiques
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        MeteoTreatment()
    End Sub

    'lancement de l'approche probabiliste
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Using frm03 As New frmProb
            frm03.MdiParent = Me
            frm03.Show()
        End Using
    End Sub

    'lancement du traitement graphique des probabilit�s
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Using frm03 As New frmScale1
            frmC.MdiParent = Me
            frmC.Show()
            ProbGraph(frmC, frm03)
        End Using
    End Sub

    Private Sub MenuItem12_Click(sender As Object, e As EventArgs) Handles MenuItem12.Click 'Thomas 28/04/2020
        Using frm04 As New frmSplash
            frm04.ShowDialog()
        End Using
    End Sub

    Private Sub MenuItem11_Click(sender As Object, e As EventArgs) Handles MenuItem11.Click 'Thomas 28/04/2020
        Dim manual As Byte() = My.Resources.ModeEmploi_v4
        Using tmp As New FileStream("ModeEmploi_v4.pdf", FileMode.Create)
            tmp.Write(manual, 0, manual.Length)
        End Using
        Process.Start("ModeEmploi_v4.pdf")
    End Sub

    Private Sub MenuItem13_Click(sender As Object, e As EventArgs) Handles MenuItem13.Click
        Using frm04 As New frmMesh
            frm04.ShowDialog()
        End Using
    End Sub
    'Lecture du module PhreeqC
    Private Sub MenuItem14_Click(sender As Object, e As EventArgs) Handles MenuItem14.Click
        Using frm04 As New frmPhreeqC
            frm04.ShowDialog()
        End Using
    End Sub

    'Lecture du module FEM mechical analyse
    Private Sub MenuItem15_Click(sender As Object, e As EventArgs) Handles MenuItem15.Click
        Using frm04 As New frmbtFem
            frm04.ShowDialog()
        End Using
    End Sub

    'Lecture du fichier Maillage dans le menu 'Xuande  10/06/2020
    Private Sub MenuItem16_Click(sender As Object, e As EventArgs) Handles MenuItem16.Click
        Dim d As New OpenFileDialog
        d.Title = "Open Mesh file"
        d.Filter = "Mesh files (*.msh)|*.msh"

        If d.ShowDialog = DialogResult.OK Then
            If ReadFile(d.FileName) = False Then
                MsgBox("Error with Mesh file.", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Mesh file")
                MeshFileOk = False
            ElseIf ReadFile(d.FileName) = True Then
                MsgBox("Mesh file imported successfully!", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Mesh file")
                MeshFileOk = True
            End If
            'DrawModel()
        End If
    End Sub
    'Fonction de lecture des donnees geometrie 'Xuande  10/06/2020
    Private Function ReadFile(f As String) As Boolean
        Try

            Dim sr As New StreamReader(f)
            Dim s As String
            Dim Arr(0) As String
            Dim Temp As String
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim NN(0), XX(0), YY(0), ZZ(0) As Integer
            Dim n0 As Integer
            Dim n, n1, n2, n3, n4 As Integer
            Dim x, y, z As Double
            Dim brd As Boolean
            Dim bloc_node As Integer
            Dim bloc_type As Integer
            Dim bloc_element As Integer

            'Skip the version data
            Temp = readLine(sr)

            'Skip the unnecessary first few lines
            Do While Temp <> "$Nodes"
                Temp = sr.ReadLine.Trim
            Loop

            'Read total number of nodes and blocks 
            s = readLine(sr)
            Arr = Split(s, " "c)
            Try
                Nbloc = Integer.Parse(Arr(0))
                NNodes = Integer.Parse(Arr(1))
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

            'Read node coordinates block by block
            ReDim Nodes(NNodes - 1)
            For i = 0 To Nbloc - 1
                'read bloc information for how many nodes should be read inside
                s = readLine(sr)
                Arr = Split(s, " "c)
                bloc_type = Integer.Parse(Arr(0))
                bloc_node = Integer.Parse(Arr(3))
                ReDim NN(bloc_node - 1)
                ReDim XX(bloc_node - 1)
                ReDim YY(bloc_node - 1)
                ReDim ZZ(bloc_node - 1)
                For j = 0 To bloc_node - 1
                    'read first lines of node number
                    s = readLine(sr)
                    Arr = Split(s, " "c)
                    n = Integer.Parse(Arr(0))
                    NN(j) = n
                Next
                'read corresponding lines of coordinates
                For k = 0 To bloc_node - 1
                    'judging wether points of current block belongs to the boundary
                    If bloc_type <= 1 Then
                        brd = True
                    Else
                        brd = False
                    End If
                    'read corresponding lines of coordinates
                    s = readLine(sr)
                    Arr = Split(s, " "c)
                    x = Double.Parse(Arr(0))
                    XX(k) = x
                    y = Double.Parse(Arr(1))
                    YY(k) = y
                    z = Double.Parse(Arr(2))
                    ZZ(k) = z
                    Nodes(NN(k) - 1) = New NodeTrans(NN(k), XX(k), YY(k), ZZ(k), brd)
                Next
            Next

            'Read total number of elements and blocks 
            s = readLine(sr)
            Arr = Split(s, " "c)
            Try
                Nbloc = Integer.Parse(Arr(0))
                NElements = Integer.Parse(Arr(1))
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

            'Read element connectivity block by block
            ReDim Elements(NElements - 1)
            For i = 0 To Nbloc - 1
                'read bloc information for how many nodes should be read inside
                s = readLine(sr)
                Arr = Split(s, " "c)
                bloc_type = Integer.Parse(Arr(0))
                bloc_element = Integer.Parse(Arr(3))
                For j = 0 To bloc_element - 1
                    If bloc_type <= 1 Then
                        Temp = readLine(sr)
                    Else
                        'read first lines of element number
                        If j = 0 Then
                            s = readLine(sr)
                            Arr = Split(s, " "c)
                            n0 = Integer.Parse(Arr(0))
                            n = 1
                            n1 = Integer.Parse(Arr(1))
                            n2 = Integer.Parse(Arr(2))
                            n3 = Integer.Parse(Arr(3))
                            n4 = Integer.Parse(Arr(4))
                            n = 1
                        Else
                            s = readLine(sr)
                            Arr = Split(s, " "c)
                            n = Integer.Parse(Arr(0)) - n0
                            n1 = Integer.Parse(Arr(1))
                            n2 = Integer.Parse(Arr(2))
                            n3 = Integer.Parse(Arr(3))
                            n4 = Integer.Parse(Arr(4))
                        End If
                        Elements(j) = New ElementTrans(n, n1, n2, n3, n4)
                    End If

                Next

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    'Routine pour tracer la geometrie et le maillage 'Xuande  10/06/2020
    'Private Sub DrawModel()
    '    gr.Clear(Color.White)

    '    Dim eleColor As Color = Color.Lavender
    '    Dim eleColorDeformed As Color = Color.Turquoise
    '    Dim supportColor As Color = Color.Black
    '    Dim pointLoadColor As Color = Color.Red

    '    Dim MarginX, MarginY As Integer
    '    MarginX = 50
    '    MarginY = 50

    '    'Draw the triangles.
    '    Dim shiftx As Integer = MarginX - hs.Value
    '    Dim shifty As Integer = pbModel.Height - MarginY - vs.Value

    '    Dim i As Integer
    '    Dim n1, n2, n3 As Integer

    '    Dim ptsf(2) As PointF


    '    'Draw the undeformed model

    '    If ShowModel = True Then
    '        'Draw the elements .
    '        For i = 0 To NElements - 1

    '            n1 = Elements(i).Node1 - 1
    '            n2 = Elements(i).Node2 - 1
    '            n3 = Elements(i).Node3 - 1

    '            ptsf(0) = New PointF(CSng(Nodes(n1).x * zoom + shiftx), CSng(-Nodes(n1).y * zoom + shifty))
    '            ptsf(1) = New PointF(CSng(Nodes(n2).x * zoom + shiftx), CSng(-Nodes(n2).y * zoom + shifty))
    '            ptsf(2) = New PointF(CSng(Nodes(n3).x * zoom + shiftx), CSng(-Nodes(n3).y * zoom + shifty))

    '            'Draw the element
    '            gr.FillPolygon(New SolidBrush(eleColor), ptsf)
    '            gr.DrawPolygon(New Pen(Color.Black), ptsf)

    '        Next

    '        'Draw the node numbers
    '        If ShowNodeNumbers = True Then
    '            Dim p As New Pen(Color.Black)
    '            Dim nx, ny As Integer
    '            Dim fnt As New Font("Arial", 8)
    '            Dim brsh As New SolidBrush(Color.Red)
    '            For i = 0 To NNodes - 1
    '                nx = CInt(Nodes(i).x * zoom + shiftx)
    '                ny = CInt(-Nodes(i).y * zoom + shifty)
    '                Dim r As New Rectangle(nx - 3, ny - 3, 6, 6)
    '                gr.DrawEllipse(p, r)

    '                gr.DrawString((i + 1).ToString, fnt, brsh, New PointF(nx + 5, ny + 5))

    '            Next
    '        End If

    '        'Draw the supports
    '        'we draw squares for supports
    '        ReDim ptsf(3)
    '        Dim squareHalfSize As Integer = 5
    '        For i = 0 To NSupports - 1
    '            n1 = Supports(i).Node - 1
    '            ptsf(0) = New PointF(CSng(Nodes(n1).x * zoom + shiftx - squareHalfSize),
    '                                 CSng(-Nodes(n1).y * zoom + shifty - squareHalfSize))
    '            ptsf(1) = New PointF(CSng(Nodes(n1).x * zoom + shiftx + squareHalfSize),
    '                                 CSng(-Nodes(n1).y * zoom + shifty - squareHalfSize))
    '            ptsf(2) = New PointF(CSng(Nodes(n1).x * zoom + shiftx + squareHalfSize),
    '                                 CSng(-Nodes(n1).y * zoom + shifty + squareHalfSize))
    '            ptsf(3) = New PointF(CSng(Nodes(n1).x * zoom + shiftx - squareHalfSize),
    '                                 CSng(-Nodes(n1).y * zoom + shifty + squareHalfSize))
    '            gr.FillPolygon(New SolidBrush(supportColor), ptsf)

    '        Next

    '        'draw the loads
    '        Dim px, py As Integer
    '        For i = 0 To NPointLoads - 1
    '            n1 = PointLoads(i).Node - 1
    '            If Math.Abs(PointLoads(i).Fx) > 0.0001 Then
    '                'if the pointload is significant
    '                'draw the arrow
    '                px = CInt(Nodes(n1).x * zoom + shiftx)
    '                py = CInt(-Nodes(n1).y * zoom + shifty)
    '                If PointLoads(i).Fx > 0 Then
    '                    DrawHArrow(px, py, pointLoadColor, False)
    '                Else
    '                    DrawHArrow(px, py, pointLoadColor, True)
    '                End If
    '            End If

    '            If Math.Abs(PointLoads(i).Fy) > 0.0001 Then
    '                px = CInt(Nodes(n1).x * zoom + shiftx)
    '                py = CInt(-Nodes(n1).y * zoom + shifty)
    '                If PointLoads(i).Fy > 0 Then
    '                    DrawVArrow(px, py, pointLoadColor, False)
    '                Else
    '                    DrawVArrow(px, py, pointLoadColor, True)
    '                End If

    '            End If


    '        Next
    '    End If
    '    'Now, plot results if available
    '    If Deformations IsNot Nothing AndAlso Deformations.Length > 0 Then
    '        Dim eColor As Color
    '        'we can plot now.
    '        If ShowDeformations = True Then
    '            ReDim ptsf(2)

    '            'compute the colormap

    '            'set the colormap if required
    '            Select Case ShowResult
    '                Case Results.None
    '                    'create a dummy colormap
    '                    ColorMap = New ColorMap(1, 0)
    '                Case Results.SigmaX
    '                    ColorMap = New ColorMap(SigmaXRange.Max, SigmaXRange.Min)
    '                Case Results.SigmaY
    '                    ColorMap = New ColorMap(SigmaYRange.Max, SigmaYRange.Min)
    '                Case Results.TauXY
    '                    ColorMap = New ColorMap(TauXYRange.Max, TauXYRange.Min)
    '                Case Results.EpsilonX
    '                    ColorMap = New ColorMap(EpsilonXRange.Max, EpsilonXRange.Min)
    '                Case Results.EpsilonY
    '                    ColorMap = New ColorMap(EpsilonYRange.Max, EpsilonYRange.Min)
    '                Case Results.GammaXY
    '                    ColorMap = New ColorMap(GammaXYRange.Max, GammaXYRange.Min)
    '                Case Else
    '                    'just for completeness.. otherwise this block wont ever execute
    '                    'create a dummy colormap
    '                    ColorMap = New ColorMap(1, 0)
    '            End Select

    '            For i = 0 To NElements - 1

    '                'ecolor depends on the value of result to be shown

    '                Select Case ShowResult
    '                    Case Results.None
    '                        eColor = eleColorDeformed
    '                    Case Results.SigmaX
    '                        eColor = ColorMap.getColor(Elements(i).Stresses(0))
    '                    Case Results.SigmaY
    '                        eColor = ColorMap.getColor(Elements(i).Stresses(1))
    '                    Case Results.TauXY
    '                        eColor = ColorMap.getColor(Elements(i).Stresses(2))
    '                    Case Results.EpsilonX
    '                        eColor = ColorMap.getColor(Elements(i).Strains(0))
    '                    Case Results.EpsilonY
    '                        eColor = ColorMap.getColor(Elements(i).Strains(1))
    '                    Case Results.GammaXY
    '                        eColor = ColorMap.getColor(Elements(i).Strains(2))
    '                    Case Else
    '                        eColor = eleColor
    '                End Select


    '                n1 = Elements(i).Node1 - 1
    '                n2 = Elements(i).Node2 - 1
    '                n3 = Elements(i).Node3 - 1

    '                ptsf(0) = New PointF(CSng((Nodes(n1).x * zoom + getDeformationX(n1) * DeformationZoom) + shiftx),
    '                                     CSng((-Nodes(n1).y * zoom - getDeformationY(n1) * DeformationZoom) + shifty))
    '                ptsf(1) = New PointF(CSng((Nodes(n2).x * zoom + getDeformationX(n2) * DeformationZoom) + shiftx),
    '                                     CSng((-Nodes(n2).y * zoom - getDeformationY(n2) * DeformationZoom) + shifty))
    '                ptsf(2) = New PointF(CSng((Nodes(n3).x * zoom + getDeformationX(n3) * DeformationZoom) + shiftx),
    '                                     CSng((-Nodes(n3).y * zoom - getDeformationY(n3) * DeformationZoom) + shifty))

    '                'Draw the element
    '                gr.FillPolygon(New SolidBrush(eColor), ptsf)
    '                If ShowElementsOnDeformedShape = True Then
    '                    gr.DrawPolygon(New Pen(Color.Black), ptsf)
    '                End If

    '            Next

    '            'Draw Colormap at right top of the picturebox
    '            'only if required
    '            If ShowResult <> Results.None Then
    '                Dim cmap As New ColorMap(250, 0)
    '                Dim c As Color
    '                Dim x1, x2, y As Integer
    '                y = 50
    '                x1 = bmp.Width - 100
    '                x2 = x1 + 50
    '                For i = 250 To 0 Step -1
    '                    c = cmap.getColor(i)
    '                    y += 1
    '                    gr.DrawLine(New Pen(c), New Point(x1, y), New Point(x2, y))
    '                Next
    '                'write the max, min and mid values
    '                'max

    '                Dim strWidth As Integer
    '                Dim MaxWidth, MinWidth, AvgWidth As Single
    '                Dim Max, Min, Avg As String
    '                Dim barFont As New Font("Arial", 9)
    '                Dim barBrush As New SolidBrush(Color.Black)
    '                Max = ColorMap.Max.ToString
    '                Min = ColorMap.Min.ToString
    '                Avg = ((ColorMap.Max + ColorMap.Min) / 2).ToString
    '                MaxWidth = gr.MeasureString(Max, barFont).Width
    '                MinWidth = gr.MeasureString(Min, barFont).Width
    '                AvgWidth = gr.MeasureString(Avg, barFont).Width

    '                strWidth = CInt(Math.Max(Math.Max(MaxWidth, MinWidth), AvgWidth)) + 10

    '                gr.DrawLine(Pens.Black, x1, 50, x1 - 5, 50)
    '                gr.DrawString(Max, barFont, barBrush, New PointF(x1 - strWidth, 30))

    '                gr.DrawLine(Pens.Black, x1, 175, x1 - 5, 175)
    '                gr.DrawString(Avg, barFont, barBrush, New PointF(x1 - strWidth, 155))

    '                gr.DrawLine(Pens.Black, x1, 300, x1 - 5, 300)
    '                gr.DrawString(Min, barFont, barBrush, New PointF(x1 - strWidth, 320))
    '            End If


    '        End If
    '    End If
    '    pbModel.Refresh()
    'End Sub
    'Fonction readline  'Xuande  10/06/2020
    Private Function readLine(ByRef sr As StreamReader) As String
        Dim s As String
        If sr.EndOfStream = True Then Return ""
        While sr.EndOfStream = False
            s = sr.ReadLine.Trim
            If s.Length > 0 Then
                If s.Substring(0, 1) <> "$" Then
                    Return s
                End If
            End If
        End While
        Return ""
    End Function
End Class