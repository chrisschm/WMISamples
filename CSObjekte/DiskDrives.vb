Namespace Global
    Namespace CS
        Namespace System
            Namespace IO

                ''' <summary>
                ''' DiskDrives is an ordered set of DiskDrive items that can be reffered to as a unit.
                ''' </summary>
                Public Class DiskDrives

                    Implements IEnumerable

                    Private colDiskDrives As New Collection

                    ''' <summary>
                    ''' Returns a value that indicates wether a DiskDrive object contains an element with a specific key
                    ''' </summary>
                    ''' <param name="Key">Required. A String expression that specifies the key for wich to search the elements of the collection</param>
                    ''' <returns>True if the DiskDrives Object contains an element with a specific key. Otherwise False</returns>
                    Public Function Contains(Key As String) As Boolean
                        Return colDiskDrives.Contains(Key)
                    End Function

                    ''' <summary>
                    ''' Forces the DiskDrives object to destroy and reload its child data
                    ''' </summary>
                    Public Sub Refresh()

                        Dim mosDDs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
                        If colDiskDrives.Count > 0 Then colDiskDrives.Clear()

                        For Each mosDD As Global.System.Management.ManagementObject In mosDDs.[Get]()
                            Dim SelDD As New DiskDrive(mosDD)
                            colDiskDrives.Add(SelDD, mosDD("SerialNumber").ToString())
                        Next

                    End Sub

                    ''' <summary>
                    ''' Creates and returns a new DiskDrives object
                    ''' </summary>
                    Public Sub New()
                        Refresh()
                    End Sub

                    ''' <summary>
                    ''' Returns an enumerator that iterates through the collection
                    ''' </summary>
                    ''' <returns>An enumerator that can be used to iterate through the collection</returns>
                    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                        Return colDiskDrives.GetEnumerator
                    End Function

                    ''' <summary>
                    ''' Gets the number of elements in the collection
                    ''' </summary>
                    ''' <returns>The number of elements in the collection</returns>
                    Public ReadOnly Property Count() As Integer
                        Get
                            Return colDiskDrives.Count
                        End Get
                    End Property

                    ''' <summary>
                    ''' Gets a specific element of the DiskDrives object either by position or by key
                    ''' </summary>
                    ''' <param name="Index">A numeric expression that specifies the position of an element of the 
                    ''' collection. Index must be a number from 1 through the value of the collections count
                    ''' property. Or an object expression that specifies the position or key string of an
                    ''' element of the collection</param>
                    ''' <returns>A specific element of the DiskDrives object either by position or by key</returns>
                    Default Public ReadOnly Property Item(Index As Integer) As DiskDrive
                        Get
                            Return colDiskDrives.Item(Index)
                        End Get
                    End Property

                    ''' <summary>
                    ''' Gets a specific element of the DiskDrives object either by position or by key
                    ''' </summary>
                    ''' <param name="Key">A numeric expression that specifies the position of an element of the 
                    ''' collection. Index must be a number from 1 through the value of the collections count
                    ''' property. Or an object expression that specifies the position or key string of an
                    ''' element of the collection</param>
                    ''' <returns>A specific element of the DiskDrives object either by position or by key</returns>
                    Default Public ReadOnly Property Item(Key As String) As DiskDrive
                        Get
                            Return colDiskDrives.Item(Key)
                        End Get
                    End Property

                    ''' <summary>
                    ''' Gets a specific element of the DiskDrives object either by position or by key
                    ''' </summary>
                    ''' <param name="Index">A numeric expression that specifies the position of an element of the 
                    ''' collection. Index must be a number from 1 through the value of the collections count
                    ''' property. Or an object expression that specifies the position or key string of an
                    ''' element of the collection</param>
                    ''' <returns>A specific element of the DiskDrives object either by position or by key</returns>
                    Default Public ReadOnly Property Item(Index As Object) As DiskDrive
                        Get
                            Return colDiskDrives.Item(Index)
                        End Get
                    End Property

                End Class


            End Namespace
        End Namespace
    End Namespace
End Namespace