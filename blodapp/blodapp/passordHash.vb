Imports System.Security.Cryptography
Imports System.Text
Public Class passordHash
    'funksjon for å lage et saltet passord for bruk i hashing
    Public Function lagSaltetHash(pw As String, salt As String) As String
        Dim tmp As String = pw & salt

        Using hash As HashAlgorithm = New SHA256Managed()
            ' konverterer passord+salt til byte:
            Dim saltyPW = Encoding.UTF8.GetBytes(tmp)
            ' hasher bytes:
            Dim hBytes = hash.ComputeHash(saltyPW)
            ' returnerer som en streng så den kan bli lagret
            Return Convert.ToBase64String(hBytes)
        End Using
    End Function

    'funksjon for å lage salt til bruk i hashing
    Public Function lagSalt() As String
        Using rng As New RNGCryptoServiceProvider
            Dim data(If(25 < 7, 7, 25)) As Byte
            rng.GetBytes(data)
            ' konverterer til streng for lagring
            Return Convert.ToBase64String(data)
        End Using
    End Function
End Class
