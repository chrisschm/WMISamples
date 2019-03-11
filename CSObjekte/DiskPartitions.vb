Namespace Global
    Namespace CS
        Namespace System
            Namespace IO

                Public Class DiskPartitions

                    Implements IEnumerable

                    Private colDiskPartitions As New Collection

                    Public Function Contains(Key As String) As Boolean
                        Return colDiskPartitions.Contains(Key)
                    End Function

                    Public Sub Refresh()

                        Dim mosDPs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DiskPartition")
                        If colDiskPartitions.Count > 0 Then colDiskPartitions.Clear()

                        For Each mosDP As Global.System.Management.ManagementObject In mosDPs.[Get]()
                            Dim SelDP As New DiskPartition(mosDP)
                            colDiskPartitions.Add(SelDP, mosDP("DeviceID").ToString())
                        Next

                    End Sub

                    Public Sub New()
                        Refresh()
                    End Sub

                    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                        Return colDiskPartitions.GetEnumerator
                    End Function

                    Public ReadOnly Property Count() As Integer
                        Get
                            Return colDiskPartitions.Count
                        End Get
                    End Property

                    Default Public ReadOnly Property Item(Index As Integer) As DiskDrive
                        Get
                            Return colDiskPartitions.Item(Index)
                        End Get
                    End Property

                    Default Public ReadOnly Property Item(Key As String) As DiskDrive
                        Get
                            Return colDiskPartitions.Item(Key)
                        End Get
                    End Property

                End Class


            End Namespace
        End Namespace
    End Namespace
End Namespace