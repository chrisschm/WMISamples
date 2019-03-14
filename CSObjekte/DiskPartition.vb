Namespace Global
    Namespace CS
        Namespace System
            Namespace IO

                ''' <summary>
                ''' The DiskPartition class encapsulate the Win32_DiskPartition WMI class, that 
                ''' represents the capabilities and management capacity of a partitioned area of 
                ''' a physical disk on a computer system running Windows. Example: Disk #0, Partition #1.
                ''' </summary>
                ''' <remarks>
                ''' Documentation Win32_DiskPartition WMI class: 
                ''' https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-diskpartition
                ''' </remarks>
                Public Class DiskPartition

#Region "PrivateVariables"
                    ' Private Variables to store Attributes of Win32_DiskPartition WMI Object
                    Private srtAccess As UShort
                    Private srtAvailability As UShort
                    Private lngBlockSize As ULong
                    Private bolBootable As Boolean
                    Private bolBootPartition As Boolean
                    Private strCaption As String
                    Private intConfigManagerErrorCode As UInteger
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
                    ''' <summary>
                    ''' Creates and returns a new DiskPartition object
                    ''' </summary>
                    ''' <param name="SelectedPartition">Required. One instance from WMI Win32_DiskPartition class as ManagementObject</param>
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
                    ''' <summary>
                    ''' Media access available.
                    ''' </summary>
                    ''' <returns>Unsigned Short. Have a look to the WMI Documentation</returns>
                    Public ReadOnly Property Access() As UShort
                        Get
                            If IsNothing(srtAccess) = True Then
                                Return 0
                            Else
                                Return srtAccess
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Availability and status of the device.
                    ''' </summary>
                    ''' <returns>Unsigned Short. Have a look to the WMI Documentation</returns>
                    Public ReadOnly Property Availability() As UShort
                        Get
                            If IsNothing(srtAvailability) = True Then
                                Return 0
                            Else
                                Return srtAvailability
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Size in bytes of the blocks which form this storage extent. If unknown or 
                    ''' if a block concept is not valid (for example, for aggregate extents, 
                    ''' memory or logical disks), enter a 1.
                    ''' </summary>
                    ''' <returns>Unsigned Long</returns>
                    Public ReadOnly Property BlockSize() As ULong
                        Get
                            If IsNothing(lngBlockSize) = True Then
                                Return 0
                            Else
                                Return lngBlockSize
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Indicates whether the computer can be booted from this partition.
                    ''' </summary>
                    ''' <returns>True if the computer can be booted from this partition, otherwise false.</returns>
                    Public ReadOnly Property Bootable() As Boolean
                        Get
                            If IsNothing(bolBootable) = True Then
                                Return False
                            Else
                                Return bolBootable
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Partition is the active partition. The operating system uses the 
                    ''' active partition when booting from a hard disk.
                    ''' </summary>
                    ''' <returns>True if the partition is the active partition, otherwise false.</returns>
                    Public ReadOnly Property BootPartition() As Boolean
                        Get
                            If IsNothing(bolBootPartition) = True Then
                                Return False
                            Else
                                Return bolBootPartition
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Short description of the object.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property Caption() As String
                        Get
                            If IsNothing(strCaption) = True Then
                                Return ""
                            Else
                                Return strCaption
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Windows Configuration Manager error code.
                    ''' </summary>
                    ''' <returns>Unsigned Integer. Have a look to the WMI Documentation</returns>
                    Public ReadOnly Property ConfigManagerErrorCode() As UInteger
                        Get
                            If IsNothing(intConfigManagerErrorCode) = True Then
                                Return 0
                            Else
                                Return intConfigManagerErrorCode
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the device is using a user-defined configuration.
                    ''' </summary>
                    ''' <returns>If the device is using a user-defined configuration true, otherwise false</returns>
                    Public ReadOnly Property ConfigManagerUserConfig() As Boolean
                        Get
                            If IsNothing(bolConfigManagerUserConfig) = True Then
                                Return False
                            Else
                                Return bolConfigManagerUserConfig
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Name of the first concrete class to appear in the inheritance chain used 
                    ''' in the creation of an instance. When used with the other key properties 
                    ''' of the class, the property allows all instances of this class and its 
                    ''' subclasses to be uniquely identified.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property CreationClassName() As String
                        Get
                            If IsNothing(strCreationClassName) = True Then
                                Return ""
                            Else
                                Return strCreationClassName
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Description of the object.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property Description() As String
                        Get
                            If IsNothing(strDescription) = True Then
                                Return ""
                            Else
                                Return strDescription
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Unique identifier of the disk drive and partition, from the rest of the system.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property DeviceID() As String
                        Get
                            If IsNothing(strDeviceID) = True Then
                                Return ""
                            Else
                                Return strDeviceID
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Index number of the disk containing this partition.
                    ''' </summary>
                    ''' <returns>Unsigned Integer</returns>
                    Public ReadOnly Property DiskIndex() As UInteger
                        Get
                            If IsNothing(intDiskIndex) = True Then
                                Return 0
                            Else
                                Return intDiskIndex
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Label by which the object is known. When subclassed, the property can be 
                    ''' overridden to be a key property.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property DiskName() As String
                        Get
                            If IsNothing(strDiskName) = True Then
                                Return ""
                            Else
                                Return strDiskName
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the error reported in LastErrorCode is now cleared.
                    ''' </summary>
                    ''' <returns>True if error reported in LastErrorCode is now cleared, otherwise false</returns>
                    Public ReadOnly Property ErrorCleared() As Boolean
                        Get
                            If IsNothing(bolErrorCleared) = True Then
                                Return True
                            Else
                                Return bolErrorCleared
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Information about the error recorded in LastErrorCode, and 
                    ''' information on any corrective actions that may be taken.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property ErrorDescription() As String
                        Get
                            If IsNothing(strErrorDescription) = True Then
                                Return ""
                            Else
                                Return strErrorDescription
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Type of error detection and correction supported by this storage extent.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property ErrorMethodology() As String
                        Get
                            If IsNothing(strErrorMethodology) = True Then
                                Return ""
                            Else
                                Return strErrorMethodology
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Number of hidden sectors in the partition.
                    ''' </summary>
                    ''' <returns>Unsigned Integer</returns>
                    Public ReadOnly Property HiddenSectors() As UInteger
                        Get
                            If IsNothing(intHiddenSectors) = True Then
                                Return 0
                            Else
                                Return intHiddenSectors
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Date the object was installed. This property does not need 
                    ''' a value to indicate that the object is installed.
                    ''' </summary>
                    ''' <returns>DateTime</returns>
                    Public ReadOnly Property InstallDate() As Date
                        Get
                            If IsNothing(dtInstallDate) = True Then
                                Return #01/01/0001#
                            Else
                                Return dtInstallDate
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Last error code reported by the logical device.
                    ''' </summary>
                    ''' <returns>Unsigned Integer</returns>
                    Public ReadOnly Property LastErrorCode() As UInteger
                        Get
                            If IsNothing(intLastErrorCode) = True Then
                                Return 0
                            Else
                                Return intLastErrorCode
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Total number of consecutive blocks, each block the size of the value 
                    ''' contained in the BlockSize property, which form this storage extent. 
                    ''' Total size of the storage extent can be calculated by multiplying the 
                    ''' value of the BlockSize property by the value of this property. If the 
                    ''' value of BlockSize is 1, this property is the total size of the storage extent.
                    ''' </summary>
                    ''' <returns>Unsigned Long</returns>
                    Public ReadOnly Property NumberOfBlocks() As ULong
                        Get
                            If IsNothing(lngNumberOfBlocks) = True Then
                                Return 0
                            Else
                                Return lngNumberOfBlocks
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Index number of the partition.
                    ''' </summary>
                    ''' <returns>Unsigned Integer</returns>
                    Public ReadOnly Property PartitionIndex() As UInteger
                        Get
                            If IsNothing(intPartitionIndex) = True Then
                                Return 0
                            Else
                                Return intPartitionIndex
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Windows Plug and Play device identifier of the logical device.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property PNPDeviceID() As String
                        Get
                            If IsNothing(strPNPDeviceID) = True Then
                                Return ""
                            Else
                                Return strPNPDeviceID
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, this is a primary partition.
                    ''' </summary>
                    ''' <returns>True if this is a primary partition, otherwise false.</returns>
                    Public ReadOnly Property PrimaryPartition() As Boolean
                        Get
                            If IsNothing(bolPrimaryPartition) = True Then
                                Return False
                            Else
                                Return bolPrimaryPartition
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Description of the media and its use.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property Purpose() As String
                        Get
                            If IsNothing(strPurpose) = True Then
                                Return ""
                            Else
                                Return strPurpose
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the partition information has changed and must be rewritten.
                    ''' </summary>
                    ''' <returns>True if the partition information has changed and must be rewritten, otherwise false.</returns>
                    Public ReadOnly Property RewritePartition() As Boolean
                        Get
                            If IsNothing(bolRewritePartition) = True Then
                                Return False
                            Else
                                Return bolRewritePartition
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Total size of the partition in bytes.
                    ''' </summary>
                    ''' <returns>Unsigned Long</returns>
                    Public ReadOnly Property Size() As ULong
                        Get
                            If IsNothing(lngSize) = True Then
                                Return 0
                            Else
                                Return lngSize
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Starting offset (in bytes) of the partition.
                    ''' </summary>
                    ''' <returns>Unsigned Long</returns>
                    Public ReadOnly Property StartingOffset() As ULong
                        Get
                            If IsNothing(lngStartingOffset) = True Then
                                Return 0
                            Else
                                Return lngStartingOffset
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Current status of the object. Various operational and nonoperational statuses can 
                    ''' be defined. Operational statuses include: "OK", "Degraded", and "Pred Fail" (an 
                    ''' element, such as a SMART-enabled hard disk drive, may be functioning properly but 
                    ''' predicting a failure in the near future). Nonoperational statuses include: "Error", 
                    ''' "Starting", "Stopping", and "Service". The latter, "Service", could apply during 
                    ''' mirror-resilvering of a disk, reload of a user permissions list, or other 
                    ''' administrative work. Not all such work is online, yet the managed element is 
                    ''' neither "OK" nor in one of the other states.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property Status() As String
                        Get
                            If IsNothing(strStatus) = True Then
                                Return ""
                            Else
                                Return strStatus
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Creation class name of the scoping system.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property SystemCreationClassName() As String
                        Get
                            If IsNothing(strSystemCreationClassName) = True Then
                                Return ""
                            Else
                                Return strSystemCreationClassName
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Name of the scoping system.
                    ''' </summary>
                    ''' <returns>String</returns>
                    Public ReadOnly Property SystemName() As String
                        Get
                            If IsNothing(strSystemName) = True Then
                                Return ""
                            Else
                                Return strSystemName
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Type of the partition.
                    ''' </summary>
                    ''' <returns>String</returns>
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