Namespace Global
    Namespace CS
        Namespace System

            ''' <summary>
            ''' Services is an ordered set of Service items that can be reffered to as a unit.
            ''' </summary>
            Public Class Services

                Implements IEnumerable

                Private colServices As New Collection

                ''' <summary>
                ''' Returns a value that indicates wether a Services object contains an element with a specific key
                ''' </summary>
                ''' <param name="Key">Required. A String expression that specifies the key for wich to search the elements of the collection</param>
                ''' <returns>True if the Services Object contains an element with a specific key. Otherwise False</returns>
                Public Function Contains(Key As String) As Boolean
                    Return colServices.Contains(Key)
                End Function

                ''' <summary>
                ''' Forces the Services object to destroy and reload its child data
                ''' </summary>
                Public Sub Refresh()

                    Dim mosSs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_Service")
                    If colServices.Count > 0 Then colServices.Clear()

                    For Each mosS As Global.System.Management.ManagementObject In mosSs.[Get]()
                        Dim SelS As New Service(mosS)
                        colServices.Add(SelS, mosS("Name").ToString())
                    Next

                End Sub

                ''' <summary>
                ''' Creates and returns a new Services object
                ''' </summary>
                Public Sub New()
                    Refresh()
                End Sub

                ''' <summary>
                ''' Returns an enumerator that iterates through the collection
                ''' </summary>
                ''' <returns>An enumerator that can be used to iterate through the collection</returns>
                Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                    Return colServices.GetEnumerator()
                End Function

                ''' <summary>
                ''' Gets the number of elements in the collection
                ''' </summary>
                ''' <returns>The number of elements in the collection</returns>
                Public ReadOnly Property Count() As Integer
                    Get
                        Return colServices.Count
                    End Get
                End Property

                ''' <summary>
                ''' Gets a specific element of the Services object either by position or by key
                ''' </summary>
                ''' <param name="Index">A numeric expression that specifies the position of an element of the 
                ''' collection. Index must be a number from 1 through the value of the collections count
                ''' property. Or an object expression that specifies the position or key string of an
                ''' element of the collection</param>
                ''' <returns>A specific element of the Services object either by position or by key</returns>
                Default Public ReadOnly Property Item(Index As Integer) As Service
                    Get
                        Return colServices.Item(Index)
                    End Get
                End Property

                ''' <summary>
                ''' Gets a specific element of the Services object either by position or by key
                ''' </summary>
                ''' <param name="Key">A numeric expression that specifies the position of an element of the 
                ''' collection. Index must be a number from 1 through the value of the collections count
                ''' property. Or an object expression that specifies the position or key string of an
                ''' element of the collection</param>
                ''' <returns>A specific element of the Services object either by position or by key</returns>
                Default Public ReadOnly Property Item(Key As String) As Service
                    Get
                        Return colServices.Item(Key)
                    End Get
                End Property

                ''' <summary>
                ''' Gets a specific element of the Services object either by position or by key
                ''' </summary>
                ''' <param name="Index">A numeric expression that specifies the position of an element of the 
                ''' collection. Index must be a number from 1 through the value of the collections count
                ''' property. Or an object expression that specifies the position or key string of an
                ''' element of the collection</param>
                ''' <returns>A specific element of the Services object either by position or by key</returns>
                Default Public ReadOnly Property Item(Index As Object) As Service
                    Get
                        Return colServices.Item(Index)
                    End Get
                End Property

            End Class

        End Namespace
    End Namespace
End Namespace