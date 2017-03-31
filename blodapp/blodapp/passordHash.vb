Imports System.Security.Cryptography
Imports System.Text
Public Class passordHash
    Public Function lagSaltetHash(pw As String, salt As String) As String
        Dim tmp As String = pw & salt

        ' or SHA512Managed
        Using hash As HashAlgorithm = New SHA256Managed()
            ' convert pw+salt to bytes:
            Dim saltyPW = Encoding.UTF8.GetBytes(tmp)
            ' hash the pw+salt bytes:
            Dim hBytes = hash.ComputeHash(saltyPW)
            ' return a B64 string so it can be saved as text 
            Return Convert.ToBase64String(hBytes)
        End Using

    End Function

    Public Function lagSalt() As String
        ' use the crypto random number generator to create
        ' a new random salt 
        Using rng As New RNGCryptoServiceProvider
            ' dont allow very small salt
            Dim data(If(25 < 7, 7, 25)) As Byte
            ' fill the array
            rng.GetBytes(data)
            ' convert to B64 for saving as text
            Return Convert.ToBase64String(data)
        End Using
    End Function
End Class
