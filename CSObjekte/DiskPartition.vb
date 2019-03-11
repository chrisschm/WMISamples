Namespace Global
    Namespace CS
        Namespace System
            Namespace IO

                Public Class DiskPartition

#Region "PrivateVariables"
                    ' Private Variables to store Attributes of Win32_DiskPartition WMI Object
                    ' Documentation: https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-diskpartition

                    Private srtAccess As UShort
                    Private srtAvailability As UShort
                    Private lngBlockSize As ULong
                    Private bolBootable As Boolean
                    Private bolBootPartition As Boolean
                    Private strCaption As String
                    Private intConfigManagerErrorCode As Integer
                    Private bolConfigManagerUserConfig As Boolean
                    Private strCreationClassName As String
                    Private strDescription As String
                    Private strDeviceID As String
                    Private intDiskIndex As UInteger
                    Private strDiskName As String ' Win32_DiskPartition Attributename = Name
                    Private bolErrorCleared As Boolean
                    Private strErrorDescription As String
                    Private strErrorMethodology As String
                    Private intHiddenSectors As UInteger
                    Private dtInstallDate As Date
                    Private intLastErrorCode As UInteger
                    Private lngNumberOfBlocks As ULong
                    Private intPartitionIndex As UInteger ' Win32_DiskPartition Attributename = Index
                    Private strPNPDeviceID As String
                    Private bolPrimaryPartition As Boolean
                    Private strPurpose As String
                    Private bolRewritePartition As Boolean
                    Private lngSize As ULong
                    Private lngStartingOffset As ULong
                    Private strStatus As String
                    Private strSystemCreationClassName As String
                    Private strSystemName As String
                    Private strType As String
#End Region

                    Friend Sub New(SelectedPartition As Global.System.Management.ManagementObject)

                        srtAccess = SelectedPartition("Access")
                        srtAvailability = SelectedPartition("Availability")
                        lngBlockSize = SelectedPartition("BlockSize")
                        bolBootable = SelectedPartition("Bootable")
                        bolBootPartition = SelectedPartition("BootPartition")
                        strCaption = SelectedPartition("Caption")
                        intConfigManagerErrorCode = SelectedPartition("ConfigManagerErrorCode")
                        bolConfigManagerUserConfig = SelectedPartition("ConfigManagerUserConfig")
                        strCreationClassName = SelectedPartition("CreationClassName")
                        strDescription = SelectedPartition("Description")
                        strDeviceID = SelectedPartition("DeviceID")
                        intDiskIndex = SelectedPartition("DiskIndex")
                        strDiskName = SelectedPartition("Name")
                        bolErrorCleared = SelectedPartition("ErrorCleared")
                        strErrorDescription = SelectedPartition("ErrorDescription")
                        strErrorMethodology = SelectedPartition("ErrorMethodology")
                        intHiddenSectors = SelectedPartition("HiddenSectors")
                        dtInstallDate = SelectedPartition("InstallDate")
                        intLastErrorCode = SelectedPartition("LastErrorCode")
                        lngNumberOfBlocks = SelectedPartition("NumberOfBlocks")
                        intPartitionIndex = SelectedPartition("Index")
                        strPNPDeviceID = SelectedPartition("PNPDeviceID")
                        bolPrimaryPartition = SelectedPartition("PrimaryPartition")
                        strPurpose = SelectedPartition("Purpose")
                        bolRewritePartition = SelectedPartition("RewritePartition")
                        lngSize = SelectedPartition("Size")
                        lngStartingOffset = SelectedPartition("StartingOffset")
                        strStatus = SelectedPartition("Status")
                        strSystemCreationClassName = SelectedPartition("SystemCreationClassName")
                        strSystemName = SelectedPartition("SystemName")
                        strType = SelectedPartition("Type")

                    End Sub

#Region "PublicProperties"
                    Public ReadOnly Property Access() As UShort
                        Get
                            Return srtAccess
                        End Get
                    End Property

                    Public ReadOnly Property Availability() As UShort
                        Get
                            Return srtAvailability
                        End Get
                    End Property

                    Public ReadOnly Property BlockSize() As ULong
                        Get
                            Return lngBlockSize
                        End Get
                    End Property

                    Public ReadOnly Property Bootable() As Boolean
                        Get
                            Return bolBootable
                        End Get
                    End Property

                    Public ReadOnly Property BootPartition() As Boolean
                        Get
                            Return bolBootPartition
                        End Get
                    End Property

                    Public ReadOnly Property Caption() As String
                        Get
                            If IsNothing(strCaption) = True Then
                                Return ""
                            Else
                                Return strCaption
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property ConfigManagerErrorCode() As Integer
                        Get
                            Return intConfigManagerErrorCode
                        End Get
                    End Property

                    Public ReadOnly Property ConfigManagerUserConfig() As Boolean
                        Get
                            Return bolConfigManagerUserConfig
                        End Get
                    End Property

                    Public ReadOnly Property CreationClassName() As String
                        Get
                            If IsNothing(strCreationClassName) = True Then
                                Return ""
                            Else
                                Return strCreationClassName
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property Description() As String
                        Get
                            If IsNothing(strDescription) = True Then
                                Return ""
                            Else
                                Return strDescription
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property DeviceID() As String
                        Get
                            If IsNothing(strDeviceID) = True Then
                                Return ""
                            Else
                                Return strDeviceID
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property DiskIndex() As UInteger
                        Get
                            Return intDiskIndex
                        End Get
                    End Property

                    Public ReadOnly Property DiskName() As String
                        Get
                            If IsNothing(strDiskName) = True Then
                                Return ""
                            Else
                                Return strDiskName
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property ErrorCleared() As Boolean
                        Get
                            Return bolErrorCleared
                        End Get
                    End Property

                    Public ReadOnly Property ErrorDescription() As String
                        Get
                            If IsNothing(strErrorDescription) = True Then
                                Return ""
                            Else
                                Return strErrorDescription
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property ErrorMethodology() As String
                        Get
                            If IsNothing(strErrorMethodology) = True Then
                                Return ""
                            Else
                                Return strErrorMethodology
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property HiddenSectors() As UInteger
                        Get
                            Return intHiddenSectors
                        End Get
                    End Property

                    Public ReadOnly Property InstallDate() As Date
                        Get
                            Return dtInstallDate
                        End Get
                    End Property

                    Public ReadOnly Property LastErrorCode() As UInteger
                        Get
                            Return intLastErrorCode
                        End Get
                    End Property

                    Public ReadOnly Property NumberOfBlocks() As ULong
                        Get
                            Return lngNumberOfBlocks
                        End Get
                    End Property

                    Public ReadOnly Property PartitionIndex() As UInteger
                        Get
                            Return intPartitionIndex
                        End Get
                    End Property

                    Public ReadOnly Property PNPDeviceID() As String
                        Get
                            If IsNothing(strPNPDeviceID) = True Then
                                Return ""
                            Else
                                Return strPNPDeviceID
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property PrimaryPartition() As Boolean
                        Get
                            Return bolPrimaryPartition
                        End Get
                    End Property

                    Public ReadOnly Property Purpose() As String
                        Get
                            If IsNothing(strPurpose) = True Then
                                Return ""
                            Else
                                Return strPurpose
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property RewritePartition() As Boolean
                        Get
                            Return bolRewritePartition
                        End Get
                    End Property

                    Public ReadOnly Property Size() As ULong
                        Get
                            Return lngSize
                        End Get
                    End Property

                    Public ReadOnly Property StartingOffset() As ULong
                        Get
                            Return lngStartingOffset
                        End Get
                    End Property

                    Public ReadOnly Property Status() As String
                        Get
                            If IsNothing(strStatus) = True Then
                                Return ""
                            Else
                                Return strStatus
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property SystemCreationClassName() As String
                        Get
                            If IsNothing(strSystemCreationClassName) = True Then
                                Return ""
                            Else
                                Return strSystemCreationClassName
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property SystemName() As String
                        Get
                            If IsNothing(strSystemName) = True Then
                                Return ""
                            Else
                                Return strSystemName
                            End If
                        End Get
                    End Property

                    Public ReadOnly Property Type() As String
                        Get
                            If IsNothing(strType) = True Then
                                Return ""
                            Else
                                Return strType
                            End If
                        End Get
                    End Property
#End Region

                End Class

            End Namespace
        End Namespace
    End Namespace
End Namespace