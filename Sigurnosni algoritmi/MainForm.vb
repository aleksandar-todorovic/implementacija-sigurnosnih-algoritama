Imports System
Imports System.Text
Imports System.Security
Imports System.Security.Cryptography

Public Module Module1
    Public AesKey As String = "ABCDEFGHIJKLMNOP"
    Public DesKey As String = "ABCDEFGH"
    Public tDesKey As String = "ABCDEFGHIJKLMNOP"
End Module

Public Class MainForm

    Public Shared Function DES_Crypt(ByVal input As String) As String
        Dim des As New DESCryptoServiceProvider
        des.BlockSize = 64
        des.KeySize = 64
        des.Key = Encoding.UTF8.GetBytes(DesKey)
        Dim src As Byte() = Encoding.Unicode.GetBytes(input)
        Using enc As ICryptoTransform = des.CreateEncryptor
            Dim result As Byte() = enc.TransformFinalBlock(src, 0, src.Length)
            Return Convert.ToBase64String(result)
        End Using
    End Function

    Public Shared Function TripleDES_Crypt(ByVal input As String) As String
        Dim tDes As New TripleDESCryptoServiceProvider
        tDes.BlockSize = 64
        tDes.KeySize = 128
        tDes.Key = Encoding.UTF8.GetBytes(tDesKey)
        Dim src As Byte() = Encoding.Unicode.GetBytes(input)
        Using enc As ICryptoTransform = TripleDES.Create.CreateEncryptor
            Dim dest As Byte() = enc.TransformFinalBlock(src, 0, src.Length)
            Return Convert.ToBase64String(dest)
        End Using
    End Function

    Public Shared Function AES_Crypt(ByVal input As String) As String
        Dim aes As New AesCryptoServiceProvider()
        aes.BlockSize = 128
        aes.KeySize = 128
        aes.Key = Encoding.UTF8.GetBytes(AesKey)
        aes.Mode = CipherMode.CBC
        Dim src As Byte() = Encoding.Unicode.GetBytes(input)
        Using enc As ICryptoTransform = aes.CreateEncryptor()
            Dim dest As Byte() = enc.TransformFinalBlock(src, 0, src.Length)
            Return Convert.ToBase64String(dest)
        End Using
    End Function

    Public Shared Function MD5_Hash(ByVal input As String) As String
        Dim md5 As New MD5CryptoServiceProvider                     ' Kreira novog provajdera MD5 algoritma.
        Dim bytetohash() As Byte                                    ' Deklaracija varijable tipa byte u kojoj će se smiještati vrijednosti.
        Dim result As String = ""                                   ' Deklaracija varijable u kojoj se smiješta rezultat hash algoritma.
        bytetohash = System.Text.Encoding.ASCII.GetBytes(input)     ' Prebacijavanje inputa tipa string u tip byte.
        bytetohash = md5.ComputeHash(bytetohash)                    ' Računjanje hash algoritma.
        For Each b As Byte In bytetohash                            ' Petlja u kojoj se rezultat hash-ovanja dodaje varijabli result.
            result += b.ToString("x2")
        Next
        Return result                                               ' Vraćanje rezultata iz funkcije u glavni program.

    End Function

    Public Shared Function SHA1_Hash(ByVal input As String) As String
        Dim sha As New SHA1CryptoServiceProvider                    ' Kreiranje novog provajdera SHA1 algoritma.
        Dim bytetohash() As Byte                                    ' Deklaracija varijable tipa byte u kojoj će se smiještati vrijednosti.
        Dim result As String = ""                                   ' Deklaracija varijable u kojoj se smiješta rezultat hash algoritma.
        bytetohash = System.Text.Encoding.ASCII.GetBytes(input)     ' Prebacivanje inputa tipa string u tip byte.
        bytetohash = sha.ComputeHash(bytetohash)                    ' Računanje hash algoritma.
        For Each b As Byte In bytetohash                            ' Petlja u kojoj se rezultat hash-ovanja dodaje varijabli result.
            result += b.ToString("x2")
        Next
        Return result                                               ' Vraćanje rezultata iz funkcije u glavni program.
    End Function

    Public Shared Function SHA2_Hash(ByVal input As String) As String
        Dim sha As New SHA256CryptoServiceProvider
        Dim bytetohash() As Byte
        Dim result As String = ""
        bytetohash = System.Text.Encoding.ASCII.GetBytes(input)
        bytetohash = sha.ComputeHash(bytetohash)
        For Each b As Byte In bytetohash
            result += b.ToString("x2")
        Next
        Return result
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text
        Dim result As String = ""
        If input = "" Then
            MessageBox.Show("Niste unijeli nikakvu vrijednost u tekstualno polje!")
        Else
            If rbDES.Checked = True Then
                MessageBox.Show(DES_Crypt(input))
            End If
            If rbTripleDES.Checked = True Then
                MessageBox.Show(TripleDES_Crypt(input))
            End If
            If rbAES.Checked = True Then
                MessageBox.Show(AES_Crypt(input))
            End If
            If rbMD5.Checked = True Then
                MessageBox.Show(MD5_Hash(input))
            End If
            If rbSHA1.Checked = True Then
                MessageBox.Show(SHA1_Hash(input))
            End If
            If rbSHA256.Checked = True Then
                MessageBox.Show(SHA2_Hash(input))
            End If
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Encryption_Box.Enabled = True
            Hash_Box.Enabled = False
        ElseIf RadioButton1.Checked = False Then
            Encryption_Box.Enabled = False
            Hash_Box.Enabled = True
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Hash_Box.Enabled = True
            Encryption_Box.Enabled = False
        ElseIf RadioButton2.Checked = False Then
            Hash_Box.Enabled = False
            Encryption_Box.Enabled = True
        End If
    End Sub

    Private Sub rbMD5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMD5.CheckedChanged
        Button1.Enabled = True
    End Sub

    Private Sub rbSHA256_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSHA1.CheckedChanged
        Button1.Enabled = True
    End Sub

    Private Sub rbAES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAES.CheckedChanged
        Button1.Enabled = True
    End Sub

    Private Sub rbDES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDES.CheckedChanged
        Button1.Enabled = True
    End Sub

    Private Sub rbSHA256_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSHA256.CheckedChanged
        Button1.Enabled = True
    End Sub

    Private Sub rbTripleDES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTripleDES.CheckedChanged
        Button1.Enabled = True
    End Sub

    Private Sub AESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AESToolStripMenuItem.Click
        Process.Start("https://en.wikipedia.org/wiki/Data_Encryption_Standard")
    End Sub

    Private Sub TripleDESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TripleDESToolStripMenuItem.Click
        Process.Start("https://en.wikipedia.org/wiki/Triple_DES")
    End Sub

    Private Sub AESRijndaelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AESRijndaelToolStripMenuItem.Click
        Process.Start("https://en.wikipedia.org/wiki/Rijndael")
    End Sub

    Private Sub MD5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MD5ToolStripMenuItem.Click
        Process.Start("https://en.wikipedia.org/wiki/Md5")
    End Sub

    Private Sub SHA1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHA1ToolStripMenuItem.Click
        Process.Start("https://en.wikipedia.org/wiki/Sha-1")
    End Sub

    Private Sub SHA256ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHA256ToolStripMenuItem.Click
        Process.Start("https://en.wikipedia.org/wiki/SHA-2")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox1.Show()

    End Sub
End Class
