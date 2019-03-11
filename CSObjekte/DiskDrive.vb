Namespace Global
    Namespace CS
        Namespace System
            Namespace IO

                ''' <summary>
                ''' The DiskDrive class encapsulate the Win32_DiskDrive WMI class, that represents 
                ''' a physical disk drive as seen by a computer running the Windows operating system.
                ''' </summary>
                ''' <remarks>
                ''' Documentation Win32_DiskDrive WMI class: 
                ''' https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-diskdrive
                ''' </remarks>
                Public Class DiskDrive

#Region "PrivateVariables"
                    ' Private Variables to store Attributes of Win32_DiskDrive WMI Object
                    Private srtAvailability As UShort
                    Private intBytesPerSector As UInteger
                    Private srtCapabilities() As UShort
                    Private strCapabilityDescriptions() As String
                    Private strCaption As String
                    Private strCompressionMethod As String
                    Private intConfigManagerErrorCode As UInteger
                    Private bolConfigManagerUserConfig As Boolean
                    Private strCreationClassName As String
                    Private lngDefaultBlockSize As ULong
                    Private strDescription As String
                    Private strDeviceID As String
                    Private intDeviceIndex As UInteger ' Win32_DiskDrive Attributename = Index
                    Private strDeviceName As String ' Win32_DiskDrive Attributename = Name
                    Private bolErrorCleared As Boolean
                    Private strErrorDescription As String
                    Private strErrorMethodology As String
                    Private strFirmwareRevision As String
                    Private dtInstallDate As Date
                    Private strInterfaceType As String
                    Private intLastErrorCode As UInteger
                    Private strManufacturer As String
                    Private lngMaxBlockSize As ULong
                    Private lngMaxMediaSize As ULong
                    Private bolMediaLoaded As Boolean
                    Private strMediaType As String
                    Private lngMinBlockSize As ULong
                    Private strModel As String
                    Private bolNeedsCleaning As Boolean
                    Private intNumberOfMediaSupported As UInteger
                    Private intPartitions As UInteger
                    Private strPNPDeviceID As String
                    Private srtPowerManagementCapabilities() As UShort
                    Private bolPowerManagementSupported As Boolean
                    Private intSCSIBus As UInteger
                    Private srtSCSILogicalUnit As UShort
                    Private srtSCSIPort As UShort
                    Private srtSCSITargetId As UShort
                    Private intSectorsPerTrack As UInteger
                    Private strSerialNumber As String
                    Private intSignature As UInteger
                    Private lngSize As ULong
                    Private strStatus As String
                    Private srtStatusInfo As UShort
                    Private strSystemCreationClassName As String
                    Private strSystemName As String
                    Private lngTotalCylinders As ULong
                    Private intTotalHeads As UInteger
                    Private lngTotalSectors As ULong
                    Private lngTotalTracks As ULong
                    Private intTracksPerCylinder As UInteger
#End Region

                    Friend Sub New(SelectedDrive As Global.System.Management.ManagementObject)

                        srtAvailability = SelectedDrive("Availability")
                        intBytesPerSector = SelectedDrive("BytesPerSector")
                        srtCapabilities = SelectedDrive("Capabilities")
                        strCapabilityDescriptions = SelectedDrive("CapabilityDescriptions")
                        strCaption = SelectedDrive("Caption")
                        strCompressionMethod = SelectedDrive("CompressionMethod")
                        intConfigManagerErrorCode = SelectedDrive("ConfigManagerErrorCode")
                        bolConfigManagerUserConfig = SelectedDrive("ConfigManagerUserConfig")
                        strCreationClassName = SelectedDrive("CreationClassName")
                        lngDefaultBlockSize = SelectedDrive("DefaultBlockSize")
                        strDescription = SelectedDrive("Description")
                        strDeviceID = SelectedDrive("DeviceID")
                        intDeviceIndex = SelectedDrive("Index")
                        strDeviceName = SelectedDrive("Name")
                        bolErrorCleared = SelectedDrive("ErrorCleared")
                        strErrorDescription = SelectedDrive("ErrorDescription")
                        strErrorMethodology = SelectedDrive("ErrorMethodology")
                        strFirmwareRevision = SelectedDrive("FirmwareRevision")
                        dtInstallDate = SelectedDrive("InstallDate")
                        strInterfaceType = SelectedDrive("InterfaceType")
                        intLastErrorCode = SelectedDrive("LastErrorCode")
                        strManufacturer = SelectedDrive("Manufacturer")
                        lngMaxBlockSize = SelectedDrive("MaxBlockSize")
                        lngMaxMediaSize = SelectedDrive("MaxMediaSize")
                        bolMediaLoaded = SelectedDrive("MediaLoaded")
                        strMediaType = SelectedDrive("MediaType")
                        lngMinBlockSize = SelectedDrive("MinBlockSize")
                        strModel = SelectedDrive("Model")
                        bolNeedsCleaning = SelectedDrive("NeedsCleaning")
                        intNumberOfMediaSupported = SelectedDrive("NumberOfMediaSupported")
                        intPartitions = SelectedDrive("Partitions")
                        strPNPDeviceID = SelectedDrive("PNPDeviceID")
                        srtPowerManagementCapabilities = SelectedDrive("PowerManagementCapabilities")
                        bolPowerManagementSupported = SelectedDrive("PowerManagementSupported")
                        intSCSIBus = SelectedDrive("SCSIBus")
                        srtSCSILogicalUnit = SelectedDrive("SCSILogicalUnit")
                        srtSCSIPort = SelectedDrive("SCSIPort")
                        srtSCSITargetId = SelectedDrive("SCSITargetId")
                        intSectorsPerTrack = SelectedDrive("SectorsPerTrack")
                        strSerialNumber = SelectedDrive("SerialNumber")
                        intSignature = SelectedDrive("Signature")
                        lngSize = SelectedDrive("Size")
                        strStatus = SelectedDrive("Status")
                        srtStatusInfo = SelectedDrive("StatusInfo")
                        strSystemCreationClassName = SelectedDrive("SystemCreationClassName")
                        strSystemName = SelectedDrive("SystemName")
                        lngTotalCylinders = SelectedDrive("TotalCylinders")
                        intTotalHeads = SelectedDrive("TotalHeads")
                        lngTotalSectors = SelectedDrive("TotalSectors")
                        lngTotalTracks = SelectedDrive("TotalTracks")
                        intTracksPerCylinder = SelectedDrive("TracksPerCylinder")

                    End Sub

#Region "PublicProperties"
                    ''' <summary>
                    ''' Availability and status of the device.
                    ''' </summary>
                    ''' <returns>
                    ''' Other (1), Unknown (2), Running/Full Power (3), Warning (4),
                    ''' In Test (5), Not Applicable (6), Power Off(7), Off Line(8),
                    ''' Off Duty(9), Degraded (10), Not Installed (11),
                    ''' Install Error (12), Power Save - Unknown (13),
                    ''' Power Save - Low Power Mode (14), Power Save - Standby (15),
                    ''' Power Cycle(16), Power Save - Warning (17), Paused (18),
                    ''' Not Ready (19), Not Configured (20), Quiesced (21)
                    ''' </returns>
                    Public ReadOnly Property Availability() As UShort
                        Get
                            Return srtAvailability
                        End Get
                    End Property

                    ''' <summary>
                    ''' Number of bytes in each sector for the physical disk drive.
                    ''' </summary>
                    ''' <returns>Number of bytes</returns>
                    Public ReadOnly Property BytesPerSector() As UInteger
                        Get
                            Return intBytesPerSector
                        End Get
                    End Property

                    ''' <summary>
                    ''' Array of capabilities of the media access device. For example, 
                    ''' the device may support random access (3), removable media (7), 
                    ''' and automatic cleaning (9).
                    ''' </summary>
                    ''' <returns>
                    ''' Unknown (0), Other (1), Sequential Access (2), Random Access (3), 
                    ''' Supports Writing (4), Encryption (5), Compression (6), 
                    ''' Supports Removeable Media (7), Manual Cleaning (8), 
                    ''' Automatic Cleaning (9), SMART Notification (10), 
                    ''' Supports Dual Sided Media (11), Predismount Eject Not Required (12)
                    ''' </returns>
                    Public ReadOnly Property Capabilities() As UShort()
                        Get
                            Return srtCapabilities
                        End Get
                    End Property

                    ''' <summary>
                    ''' List of more detailed explanations for any of the access device features 
                    ''' indicated in the Capabilities array. Note, each entry of this array is 
                    ''' related to the entry in the Capabilities array that is located at the same index.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property CapabilityDescriptions() As String()
                        Get
                            Return strCapabilityDescriptions
                        End Get
                    End Property

                    ''' <summary>
                    ''' Short description of the object.
                    ''' </summary>
                    ''' <returns></returns>
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
                    ''' Algorithm or tool used by the device to support compression.
                    ''' </summary>
                    ''' <returns>
                    ''' The name of the compression algorithm or one of the following values: ("Unknown"), ("Compressed"), ("Not Compressed")
                    ''' </returns>
                    Public ReadOnly Property CompressionMethod() As String
                        Get
                            If IsNothing(strCompressionMethod) = True Then
                                Return ""
                            Else
                                Return strCompressionMethod
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Windows Configuration Manager error code.
                    ''' </summary>
                    ''' <returns>Have a look at the Win32_DiskDrive WMI class documentation</returns>
                    Public ReadOnly Property ConfigManagerErrorCode() As UInteger
                        Get
                            Return intConfigManagerErrorCode
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the device is using a user-defined configuration.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property ConfigManagerUserConfig() As Boolean
                        Get
                            Return bolConfigManagerUserConfig
                        End Get
                    End Property

                    ''' <summary>
                    ''' Name of the first concrete class to appear in the inheritance chain 
                    ''' used in the creation of an instance. When used with the other key 
                    ''' properties of the class, the property allows all instances of this 
                    ''' class and its subclasses to be uniquely identified.
                    ''' </summary>
                    ''' <returns></returns>
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
                    ''' Default block size, in bytes, for this device.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property DefaultBlockSize() As ULong
                        Get
                            Return lngDefaultBlockSize
                        End Get
                    End Property

                    ''' <summary>
                    ''' Description of the object.
                    ''' </summary>
                    ''' <returns></returns>
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
                    ''' Unique identifier of the disk drive with other devices on the system.
                    ''' </summary>
                    ''' <returns></returns>
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
                    ''' Physical drive number of the given drive. This property is filled by 
                    ''' the STORAGE_DEVICE_NUMBER structure returned from the IOCTL_STORAGE_GET_DEVICE_NUMBER 
                    ''' control code. A value of 0xffffffff indicates that the given drive does 
                    ''' not map to a physical drive. WMI attribute name: Index
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property DeviceIndex() As UInteger
                        Get
                            Return intDeviceIndex
                        End Get
                    End Property

                    ''' <summary>
                    ''' Label by which the object is known. When subclassed, the property can 
                    ''' be overridden to be a key property. WMI attribute name: Name
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property DeviceName() As String
                        Get
                            If IsNothing(strDeviceName) = True Then
                                Return ""
                            Else
                                Return strDeviceName
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the error reported in LastErrorCode is now cleared.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property ErrorCleared() As Boolean
                        Get
                            Return bolErrorCleared
                        End Get
                    End Property

                    ''' <summary>
                    ''' More information about the error recorded in LastErrorCode, and 
                    ''' information on any corrective actions that may be taken.
                    ''' </summary>
                    ''' <returns></returns>
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
                    ''' Type of error detection and correction supported by this device.
                    ''' </summary>
                    ''' <returns></returns>
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
                    ''' Revision for the disk drive firmware that is assigned by the manufacturer.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property FirmwareRevision() As String
                        Get
                            If IsNothing(strFirmwareRevision) = True Then
                                Return ""
                            Else
                                Return strFirmwareRevision
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Date and time the object was installed. This property does not need a 
                    ''' value to indicate that the object is installed.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property InstallDate() As Date
                        Get
                            Return dtInstallDate
                        End Get
                    End Property

                    ''' <summary>
                    ''' Interface type of physical disk drive.
                    ''' </summary>
                    ''' <returns>
                    ''' SCSI, HDC, IDE, USB or 1394
                    ''' </returns>
                    Public ReadOnly Property InterfaceType() As String
                        Get
                            If IsNothing(strInterfaceType) = True Then
                                Return ""
                            Else
                                Return strInterfaceType
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Last error code reported by the logical device.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property LastErrorCode() As UInteger
                        Get
                            Return intLastErrorCode
                        End Get
                    End Property

                    ''' <summary>
                    ''' Name of the disk drive manufacturer.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Manufacturer() As String
                        Get
                            If IsNothing(strManufacturer) = True Then
                                Return ""
                            Else
                                Return strManufacturer
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Maximum block size, in bytes, for media accessed by this device.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property MaxBlockSize() As ULong
                        Get
                            Return lngMaxBlockSize
                        End Get
                    End Property

                    ''' <summary>
                    ''' Maximum media size, in kilobytes, of media supported by this device.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property MaxMediaSize() As ULong
                        Get
                            Return lngMaxMediaSize
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the media for a disk drive is loaded, which means that the device 
                    ''' has a readable file system and is accessible. For fixed disk drives, this 
                    ''' property will always be TRUE.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property MediaLoaded() As Boolean
                        Get
                            Return bolMediaLoaded
                        End Get
                    End Property

                    ''' <summary>
                    ''' Type of media used or accessed by this device.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property MediaType() As String
                        Get
                            If IsNothing(strMediaType) = True Then
                                Return ""
                            Else
                                Return strMediaType
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Minimum block size, in bytes, for media accessed by this device.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property MinBlockSize() As ULong
                        Get
                            Return lngMinBlockSize
                        End Get
                    End Property

                    ''' <summary>
                    ''' Manufacturer's model number/name of the disk drive.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Model() As String
                        Get
                            If IsNothing(strModel) = True Then
                                Return ""
                            Else
                                Return strModel
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the media access device needs cleaning. Whether 
                    ''' manual or automatic cleaning is possible is indicated 
                    ''' in the Capabilities property.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property NeedsCleaning() As Boolean
                        Get
                            Return bolNeedsCleaning
                        End Get
                    End Property

                    ''' <summary>
                    ''' Maximum number of media which can be supported or inserted 
                    ''' (when the media access device supports multiple individual media).
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property NumberOfMediaSupported() As UInteger
                        Get
                            Return intNumberOfMediaSupported
                        End Get
                    End Property

                    ''' <summary>
                    ''' Number of partitions on this physical disk drive that are recognized by the operating system.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Partitions() As UInteger
                        Get
                            Return intPartitions
                        End Get
                    End Property

                    ''' <summary>
                    ''' Windows Plug and Play device identifier of the logical device.
                    ''' </summary>
                    ''' <returns></returns>
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
                    ''' Array of the specific power-related capabilities of a logical device.
                    ''' </summary>
                    ''' <returns>Have a look at the Win32_DiskDrive WMI class documentation</returns>
                    ''' <remarks>Could be Nothing, first check PowerManagementSupported property!</remarks>
                    Public ReadOnly Property PowerManagementCapabilities() As UShort()
                        Get
                            Return srtPowerManagementCapabilities
                        End Get
                    End Property

                    ''' <summary>
                    ''' If True, the device can be power-managed (can be put into suspend mode, and so on). 
                    ''' The property does not indicate that power management features are currently 
                    ''' enabled, only that the logical device is capable of power management.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property PowerManagementSupported() As Boolean
                        Get
                            Return bolPowerManagementSupported
                        End Get
                    End Property

                    ''' <summary>
                    ''' SCSI bus number of the disk drive.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property SCSIBus() As UInteger
                        Get
                            Return intSCSIBus
                        End Get
                    End Property

                    ''' <summary>
                    ''' SCSI logical unit number (LUN) of the disk drive.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property SCSILogicalUnit() As UShort
                        Get
                            Return srtSCSILogicalUnit
                        End Get
                    End Property

                    ''' <summary>
                    ''' SCSI port number of the disk drive.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property SCSIPort() As UShort
                        Get
                            Return srtSCSIPort
                        End Get
                    End Property

                    ''' <summary>
                    ''' SCSI identifier number of the disk drive.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property SCSITargetId() As UShort
                        Get
                            Return srtSCSITargetId
                        End Get
                    End Property

                    ''' <summary>
                    ''' Number of sectors in each track for this physical disk drive.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property SectorsPerTrack() As UInteger
                        Get
                            Return intSectorsPerTrack
                        End Get
                    End Property

                    ''' <summary>
                    ''' Number allocated by the manufacturer to identify the physical media.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property SerialNumber() As String
                        Get
                            If IsNothing(strSerialNumber) = True Then
                                Return ""
                            Else
                                Return strSerialNumber
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Disk identification. This property can be used to identify a shared resource.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Signature() As UInteger
                        Get
                            Return intSignature
                        End Get
                    End Property

                    ''' <summary>
                    ''' Size of the disk drive in bytes. It is calculated by multiplying the total 
                    ''' number of cylinders, tracks in each cylinder, sectors in each track, and 
                    ''' bytes in each sector.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Size() As ULong
                        Get
                            Return lngSize
                        End Get
                    End Property

                    ''' <summary>
                    ''' Current status of the object. Various operational and nonoperational statuses 
                    ''' can be defined. Operational statuses include: "OK", "Degraded", and "Pred Fail" 
                    ''' (an element, such as a SMART-enabled hard disk drive, may be functioning properly 
                    ''' but predicting a failure in the near future). Nonoperational statuses include: 
                    ''' "Error", "Starting", "Stopping", and "Service". The latter, "Service", could apply 
                    ''' during mirror-resilvering of a disk, reload of a user permissions list, or other 
                    ''' administrative work. Not all such work is online, yet the managed element is 
                    ''' neither "OK" nor in one of the other states.
                    ''' </summary>
                    ''' <returns>Have a look at the Win32_DiskDrive WMI class documentation</returns>
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
                    ''' State of the logical device. If this property does not apply to the logical 
                    ''' device, the value 5 (Not Applicable) should be used.
                    ''' </summary>
                    ''' <returns>Have a look at the Win32_DiskDrive WMI class documentation</returns>
                    Public ReadOnly Property StatusInfo() As UShort
                        Get
                            Return srtStatusInfo
                        End Get
                    End Property

                    ''' <summary>
                    ''' Value of the scoping computer's CreationClassName property.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property SystemCreationClassName As String
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
                    ''' <returns></returns>
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
                    ''' Total number of cylinders on the physical disk drive. Note: the value for 
                    ''' this property is obtained through extended functions of BIOS interrupt 13h. 
                    ''' The value may be inaccurate if the drive uses a translation scheme to support 
                    ''' high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property TotalCylinders() As ULong
                        Get
                            Return lngTotalCylinders
                        End Get
                    End Property

                    ''' <summary>
                    ''' Total number of heads on the disk drive. Note: the value for this property is 
                    ''' obtained through extended functions of BIOS interrupt 13h. The value may be 
                    ''' inaccurate if the drive uses a translation scheme to support high-capacity 
                    ''' disk sizes. Consult the manufacturer for accurate drive specifications.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property TotalHeads() As UInteger
                        Get
                            Return intTotalHeads
                        End Get
                    End Property

                    ''' <summary>
                    ''' Total number of sectors on the physical disk drive. Note: the value for this 
                    ''' property is obtained through extended functions of BIOS interrupt 13h. The 
                    ''' value may be inaccurate if the drive uses a translation scheme to support 
                    ''' high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property TotalSectors() As ULong
                        Get
                            Return lngTotalSectors
                        End Get
                    End Property

                    ''' <summary>
                    ''' Total number of tracks on the physical disk drive. Note: the value for this 
                    ''' property is obtained through extended functions of BIOS interrupt 13h. The 
                    ''' value may be inaccurate if the drive uses a translation scheme to support 
                    ''' high-capacity disk sizes. Consult the manufacturer for accurate drive specifications.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property TotalTracks() As ULong
                        Get
                            Return lngTotalTracks
                        End Get
                    End Property

                    ''' <summary>
                    ''' Number of tracks in each cylinder on the physical disk drive. Note: the 
                    ''' value for this property is obtained through extended functions of BIOS 
                    ''' interrupt 13h. The value may be inaccurate if the drive uses a translation 
                    ''' scheme to support high-capacity disk sizes. Consult the manufacturer for 
                    ''' accurate drive specifications.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property TracksPerCylinder() As UInteger
                        Get
                            Return intTracksPerCylinder
                        End Get
                    End Property
#End Region

                End Class

            End Namespace
        End Namespace
    End Namespace
End Namespace