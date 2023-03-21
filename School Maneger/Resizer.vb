'-------------------------------------------------------------------------------
' Redimensionner
' Cette classe est utilisée pour redimensionner et repositionner dynamiquement tous les contrôles sur un formulaire.
' Les contrôles de conteneur sont traités de manière récursive afin que tous les contrôles du formulaire
' sont manipulés.
'
' Utilisation :
' La fonctionnalité de redimensionnement ne nécessite que trois lignes de code sur un formulaire :
'
' 1. Créez une référence au niveau du formulaire à la classe Resize :
' Dim myResizer en tant que Resizer
'
' 2. Dans l'événement Form_Load, appelez la méthode FindAllControls de la classe Resizer :
' myResizer.FindAllControls(Me)
'
' 3. Dans l'événement Form_Resize, appelez la méthode ResizeAllControls de la classe Resizer :
' myResizer.ResizeAllControls(Moi)
'
'-------------------------------------------------------------------------------
Public Class Resizer

    '----------------------------------------------------------
    ' InfoContrôle
    ' Structure de l'état d'origine de tous les contrôles traités
    '----------------------------------------------------------
    Private Structure ControlInfo
        Public name As String
        Public parentName As String
        Public leftOffsetPercent As Double
        Public topOffsetPercent As Double
        Public heightPercent As Double
        Public originalHeight As Integer
        Public originalWidth As Integer
        Public widthPercent As Double
        Public originalFontSize As Single
    End Structure

    '-------------------------------------------------------------------------
    ' ctrlDict
    'Dictionnaire de (nom de contrôle, informations de contrôle) pour tous les contrôles traités
    '-------------------------------------------------------------------------
    Private ctrlDict As Dictionary(Of String, ControlInfo) = New Dictionary(Of String, ControlInfo)

    '----------------------------------------------------------------------------------------
    ' FindAllControls
    'Fonction récursive pour traiter tous les contrôles contenus dans le premier passé
    'conteneur de contrôle et stockez-le dans le dictionnaire de contrôle
    '----------------------------------------------------------------------------------------
    Public Sub FindAllControls(thisCtrl As Control)

        '-- Si le contrôle actuel a un parent, stocke toutes les positions relatives d'origine
        '-- et les informations de taille dans le dictionnaire.
        '-- Appel récursif de FindAllControls pour chaque contrôle contenu dans le
        '-- contrôle actuel
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo
                    c.name = ctl.Name
                    c.parentName = ctl.Parent.Name
                    c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight)
                    c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth)
                    c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight)
                    c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth)
                    c.originalFontSize = ctl.Font.Size
                    c.originalHeight = ctl.Height
                    c.originalWidth = ctl.Width
                    ctrlDict.Add(c.name, c)
                End If

            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try

            If ctl.Controls.Count > 0 Then
                FindAllControls(ctl)
            End If

        Next '-- For Each

    End Sub

    '----------------------------------------------------------------------------------------
    ' ResizeAllControls
    ' Fonction récursive pour redimensionner et repositionner tous les contrôles contenus dans le contrôle
    ' dictionnaire
    '----------------------------------------------------------------------------------------
    Public Sub ResizeAllControls(thisCtrl As Control)

        Dim fontRatioW As Single
        Dim fontRatioH As Single
        Dim fontRatio As Single
        Dim f As Font

        '-- Redimensionner et repositionner tous les contrôles dans le contrôle passé
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo

                    Dim ret As Boolean = False
                    Try
                        '-- Obtenir les informations du contrôle actuel à partir du dictionnaire d'informations de contrôle
                        ret = ctrlDict.TryGetValue(ctl.Name, c)

                        '-- Si trouvé, ajustez le contrôle actuel en fonction du contrôle relatif
                        '-- informations de taille et de position stockées dans le dictionnaire
                        If (ret) Then
                            '-- Size
                            ctl.Width = Int(parentWidth * c.widthPercent)
                            ctl.Height = Int(parentHeight * c.heightPercent)

                            '-- Position
                            ctl.Top = Int(parentHeight * c.topOffsetPercent)
                            ctl.Left = Int(parentWidth * c.leftOffsetPercent)

                            '-- Font
                            f = ctl.Font
                            fontRatioW = ctl.Width / c.originalWidth
                            fontRatioH = ctl.Height / c.originalHeight
                            fontRatio = (fontRatioW +
                            fontRatioH) / 2 '-- changement moyen de la hauteur et de la largeur du contrôle
                            ctl.Font = New Font(f.FontFamily,
                            c.originalFontSize * fontRatio, f.Style)

                        End If
                    Catch
                    End Try
                End If
            Catch ex As Exception
            End Try

            '-- Appel récursif des champs contenus dans le champ en cours
            If ctl.Controls.Count > 0 Then
                ResizeAllControls(ctl)
            End If

        Next '-- For Each
    End Sub

End Class