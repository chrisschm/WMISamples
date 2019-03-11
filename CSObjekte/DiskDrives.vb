Namespace Global
    Namespace CS
        Namespace System
            Namespace IO


                Public Class DiskDrives

                    Implements IEnumerable

                    Private colDiskDrives As New Collection

                    Public Function Contains(Key As String) As Boolean
                        Return colDiskDrives.Contains(Key)
                    End Function

                    Public Sub Refresh()

                        Dim mosDDs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
                        If colDiskDrives.Count > 0 Then colDiskDrives.Clear()

                        For Each mosDD As Global.System.Management.ManagementObject In mosDDs.[Get]()
                            Dim SelDD As New DiskDrive(mosDD)
                            colDiskDrives.Add(SelDD, mosDD("SerialNumber").ToString())
                        Next

                    End Sub

                    Public Sub New()
                        Refresh()
                    End Sub

                    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                        Return colDiskDrives.GetEnumerator
                    End Function

                    Public ReadOnly Property Count() As Integer
                        Get
                            Return colDiskDrives.Count
                        End Get
                    End Property

                    Default Public ReadOnly Property Item(Index As Integer) As DiskDrive
                        Get
                            Return colDiskDrives.Item(Index)
                        End Get
                    End Property

                    Default Public ReadOnly Property Item(Key As String) As DiskDrive
                        Get
                            Return colDiskDrives.Item(Key)
                        End Get
                    End Property


                End Class


            End Namespace
        End Namespace
    End Namespace
End Namespace