Option Explicit On
Option Strict On
Option Infer Off
Public Class CardInfo

    Private cardId As Integer
    Private cardName As String
    Private cardCmc As Integer
    Private cardSuper As Integer
    Private cardType As Integer
    Private cardSub As String
    Private cardColor As Integer
    Private cardRarity As Integer

    Public Property Id As Integer
        Get
            Return cardId
        End Get
        Set(value As Integer)
            cardId = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return cardName
        End Get
        Set(value As String)
            cardName = value
        End Set
    End Property

    Public Property Cost As Integer
        Get
            Return cardCmc
        End Get
        Set(value As Integer)
            cardCmc = value
        End Set
    End Property

    Public Property Super As Integer
        Get
            Return cardSuper
        End Get
        Set(value As Integer)
            cardSuper = value
        End Set
    End Property

    Public Property Type As Integer
        Get
            Return cardType
        End Get
        Set(value As Integer)
            cardType = value
        End Set
    End Property

    Public Property SubType As String
        Get
            Return cardSub
        End Get
        Set(value As String)
            cardSub = value
        End Set
    End Property

    Public Property Color As Integer
        Get
            Return cardColor
        End Get
        Set(value As Integer)
            cardColor = value
        End Set
    End Property

    Public Property Rarity As Integer
        Get
            Return cardRarity
        End Get
        Set(value As Integer)
            cardRarity = value
        End Set
    End Property

    Public Sub New(ByVal cardId As Integer, ByVal cardName As String, ByVal cardCmc As Integer, ByVal cardSuper As Integer, ByVal cardType As Integer, ByVal cardSub As String, ByVal cardColor As Integer, ByVal cardRarity As Integer)

        Id = cardId
        Name = cardName
        Cost = cardCmc
        Super = cardSuper
        Type = cardType
        SubType = cardSub
        Color = cardColor
        Rarity = cardRarity

    End Sub
End Class
