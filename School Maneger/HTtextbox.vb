Option Strict On
'Imports System
'Imports System.Windows.Forms
'Imports System.Drawing

Public Class HTtextbox
    Inherits TextBox

    Private oldFont As Font = Nothing
    Private waterMarkTextEnabled As Boolean = False

#Region "Attributes"
    Private _waterMarkColor As Color = Drawing.Color.Gray

    Public Property WaterMarkColor() As Color
        Get
            Return _waterMarkColor
        End Get
        Set(ByVal value As Color)
            _waterMarkColor = value
            Me.Invalidate()
        End Set
    End Property

    Private _waterMarkText As String = "Water Mark"

    Public Property WaterMarkText() As String
        Get
            Return _waterMarkText
        End Get
        Set(ByVal value As String)
            _waterMarkText = value
            Me.Invalidate()
        End Set
    End Property
#End Region

    ' Constructeur par défaut
    Public Sub New()
        JoinEvents(True)
    End Sub

    Private Sub JoinEvents(ByVal join As Boolean)
        If join Then
            AddHandler(TextChanged), AddressOf WaterMark_Toggle
            AddHandler(LostFocus), AddressOf WaterMark_Toggle
            AddHandler(FontChanged), AddressOf WaterMark_FontChanged
            'Aucun des événements ci-dessus ne commencera immédiatement
            'Contrôle TextBox toujours en construction, donc,
            'L'objet de police (par exemple) n'a pas pu être capturé à partir de WaterMark_Toggle
            'Alors, appelez WaterMark_Toggel via OnCreateControl après la création totale de TextBox
            'Pas de doute, ce ne sera qu'une seule fois

            'L'ancienne solution utilise l'événement Timer.Tick pour vérifier la propriété Create
        End If
    End Sub

    Private Sub WaterMark_Toggle(ByVal sender As Object, ByVal args As EventArgs)
        If Me.Text.Length <= 0 Then
            EnableWaterMark()
        Else
            DisableWaterMark()
        End If
    End Sub

    Private Sub WaterMark_FontChanged(ByVal sender As Object, ByVal args As EventArgs)
        If waterMarkTextEnabled Then
            oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
            Refresh()
        End If
    End Sub

    Private Sub EnableWaterMark()
        'Enregistrer la police actuelle jusqu'à ce que le style UserPaint soit renvoyé à false
        '(REMARQUE : il s'agit d'un conseil d'essai et d'erreur)
        oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)

        'Activer le gestionnaire d'événements OnPaint
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.waterMarkTextEnabled = True

        'Déclencher OnPaint immédiatement
        Refresh()

    End Sub

    Private Sub DisableWaterMark()
        'Désactiver le gestionnaire d'événements OnPaint
        Me.waterMarkTextEnabled = False
        Me.SetStyle(ControlStyles.UserPaint, False)

        'Renvoie oldFont s'il existait
        If Not oldFont Is Nothing Then
            Me.Font = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        End If
    End Sub

    ' Remplacer OnCreateControl 
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        WaterMark_Toggle(Nothing, Nothing)
    End Sub

    ' Remplacer OnPaint
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        'Utiliser la même police que celle définie dans la classe de base
        Dim drawFont As Font = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        ' Créez un nouveau pinceau de couleur grise ou
        Dim drawBrush As SolidBrush = New SolidBrush(Me.WaterMarkColor) 'utiliser WaterMarkColor
        ' Test de dessin ou filigrane
        e.Graphics.DrawString(IIf(waterMarkTextEnabled, WaterMarkText, Text).ToString(), drawFont, drawBrush, New Point(0, 0))
        MyBase.OnPaint(e)
    End Sub
End Class

