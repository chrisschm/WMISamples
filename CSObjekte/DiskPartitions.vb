Namespace Global
    Namespace CS
        Namespace System
            Namespace IO

                ''' <summary>
                ''' DiskPartitions is an ordered set of DiskPartition items that can be reffered to as a unit.
                ''' </summary>
                Public Class DiskPartitions

                    Implements IEnumerable

                    Private colDiskPartitions As New Collection

                    ''' <summary>
                    ''' Returns a value that indicates wether a DiskPartition object contains an element with a specific key
                    ''' </summary>
                    ''' <param name="Key">Required. A String expression that specifies the key for wich to search the elements of the collection</param>
                    ''' <returns>True if the DiskPartitions Object contains an element with a specific key. Otherwise False</returns>
                    Public Function Contains(Key As String) As Boolean
                        Return colDiskPartitions.Contains(Key)
                    End Function

                    ''' <summary>
                    ''' Forces the DiskPartitions object to destroy and reload its child data
                    ''' </summary>
                    Public Sub Refresh()

                        Dim mosDPs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DiskPartition")
                        If colDiskPartitions.Count > 0 Then colDiskPartitions.Clear()

                        For Each mosDP As Global.System.Management.ManagementObject In mosDPs.[Get]()
                            Dim SelDP As New DiskPartition(mosDP)
                            colDiskPartitions.Add(SelDP, mosDP("DeviceID").ToString())
                        Next

                    End Sub

                    ''' <summary>
                    ''' Creates and returns a new DiskPartitions object
                    ''' </summary>
                    Public Sub New()
                        Refresh()
                    End Sub

                    ''' <summary>
                    ''' Returns an enumerator that iterates through the collection
                    ''' </summary>
                    ''' <returns>An enumerator that can be used to iterate through the collection</returns>
                    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                        Return colDiskPartitions.GetEnumerator
                    End Function

                    ''' <summary>
                    ''' Gets the number of elements in the collection
                    ''' </summary>
                    ''' <returns>The number of elements in the collection</returns>
                    Public ReadOnly Property Count() As Integer
                        Get
                            Return colDiskPartitions.Count
                        End Get
                    End Property

                    ''' <summary>
                    ''' Gets a specific element of the DiskPartitions object either by position or by key
                    ''' </summary>
                    ''' <param name="Index">A numeric expression that specifies the position of an element of the 
                    ''' collection. Index must be a number from 1 through the value of the collections count
                    ''' property. Or an object expression that specifies the position or key string of an
                    ''' element of the collection</param>
                    ''' <returns>A specific element of the DiskPartitions object either by position or by key</returns>
                    Default Public ReadOnly Property Item(Index As Integer) As DiskPartition
                        Get
                            Return colDiskPartitions.Item(Index)
                        End Get
                    End Property

                    ''' <summary>
                    ''' Gets a specific element of the DiskPartitions object either by position or by key
                    ''' </summary>
                    ''' <param name="Key">A numeric expression that specifies the position of an element of the 
                    ''' collection. Index must be a number from 1 through the value of the collections count
                    ''' property. Or an object expression that specifies the position or key string of an
                    ''' element of the collection</param>
                    ''' <returns>A specific element of the DiskPartitions object either by position or by key</returns>
                    Default Public ReadOnly Property Item(Key As String) As DiskPartition
                        Get
                            Return colDiskPartitions.Item(Key)
                        End Get
                    End Property

                    ''' <summary>
                    ''' Gets a specific element of the DiskPartitions object either by position or by key
                    ''' </summary>
                    ''' <param name="Index">A numeric expression that specifies the position of an element of the 
                    ''' collection. Index must be a number from 1 through the value of the collections count
                    ''' property. Or an object expression that specifies the position or key string of an
                    ''' element of the collection</param>
                    ''' <returns>A specific element of the DiskPartitions object either by position or by key</returns>
                    Default Public ReadOnly Property Item(Index As Object) As DiskPartition
                        Get
                            Return colDiskPartitions.Item(Index)
                        End Get
                    End Property


                End Class


            End Namespace
        End Namespace
    End Namespace
End Namespace