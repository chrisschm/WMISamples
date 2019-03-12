Namespace Global
    Namespace CS
        Namespace System

            Public Class BIOS

#Region "PrivateVariables"
                ' Private Variables to store Attributes of Win32_BIOS WMI Object
                ' Documentation: https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-bios

                Private srtBiosCharacteristics As UShort()
                Private strBiosName As String
                Private strBIOSVersion As String()
                Private strBuildNumber As String
                Private strCaption As String
                Private strCodeSet As String
                Private strCurrentLanguage As String
                Private strDescription As String
                Private bytEmbeddedControllerMajorVersion As Byte ' UInt8
                Private bytEmbeddedControllerMinorVersion As Byte ' UInt8
                Private strIdentificationCode As String
                Private srtInstallableLanguages As UShort
                Private dtInstallDate As Date
                Private strLanguageEdition As String
                Private strManufacturer As String
                Private strOtherTargetOS As String
                Private bolPrimaryBIOS As Boolean
                Private strReleaseDate As String
                Private strSerialNumber As String
                Private strSMBIOSBIOSVersion As String
                Private srtSMBIOSMajorVersion As UShort
                Private srtSMBIOSMinorVersion As UShort
                Private bolSMBIOSPresent As Boolean
                Private strSoftwareElementID As String
                Private srtSoftwareElementState As UShort
                Private strStatus As String
                Private bytSystemBiosMajorVersion As Byte ' UInt8
                Private bytSystemBiosMinorVersion As Byte ' UInt8
                Private srtTargetOperatingSystem As UShort
                Private strVersion As String

                ' Other private variables
                Private bolSingleInstance As Boolean = True

#End Region

                Public Sub New()

                    Dim i As Integer
                    Dim mosBs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_BIOS")

                    i = mosBs.Get.Count
                    Select Case i
                        Case 0
                            bolSingleInstance = False
                            Throw New Exception("No Result in WMI Query")
                        Case 1
                            Dim mosB As Global.System.Management.ManagementObject = mosBs.[Get](0)

                            srtBiosCharacteristics = mosB("BiosCharacteristics")
                            strBiosName = mosB("Name")
                            strBIOSVersion = mosB("BIOSVersion")
                            strBuildNumber = mosB("BuildNumber")
                            strCaption = mosB("Caption")
                            strCodeSet = mosB("CodeSet")
                            strCurrentLanguage = mosB("CurrentLanguage")
                            strDescription = mosB("Description")
                            bytEmbeddedControllerMajorVersion = mosB("EmbeddedControllerMajorVersion")
                            bytEmbeddedControllerMinorVersion = mosB("EmbeddedControllerMinorVersion")
                            strIdentificationCode = mosB("IdentificationCode")
                            srtInstallableLanguages = mosB("InstallableLanguages")
                            dtInstallDate = mosB("InstallDate")
                            strLanguageEdition = mosB("LanguageEdition")
                            strManufacturer = mosB("Manufacturer")
                            strOtherTargetOS = mosB("OtherTargetOS")
                            bolPrimaryBIOS = mosB("PrimaryBIOS")
                            strReleaseDate = mosB("ReleaseDate") ' ISSUE: should be DATE but does not work
                            strSerialNumber = mosB("SerialNumber")
                            strSMBIOSBIOSVersion = mosB("SMBIOSBIOSVersion")
                            srtSMBIOSMajorVersion = mosB("SMBIOSMajorVersion")
                            srtSMBIOSMinorVersion = mosB("SMBIOSMinorVersion")
                            bolSMBIOSPresent = mosB("SMBIOSPresent")
                            strSoftwareElementID = mosB("SoftwareElementID")
                            srtSoftwareElementState = mosB("SoftwareElementState")
                            strStatus = mosB("Status")
                            bytSystemBiosMajorVersion = mosB("SystemBiosMajorVersion")
                            bytSystemBiosMinorVersion = mosB("SystemBiosMinorVersion")
                            srtTargetOperatingSystem = mosB("TargetOperatingSystem")
                            strVersion = mosB("Version")
                        Case Else
                            bolSingleInstance = False
                    End Select

                End Sub

#Region "PublicProperties"

                Public ReadOnly Property BiosCharacteristics() As UShort()
                    Get
                        Return srtBiosCharacteristics
                    End Get
                End Property

                Public ReadOnly Property BiosName() As String
                    Get
                        If IsNothing(strBiosName) = True Then
                            Return ""
                        Else
                            Return strBiosName
                        End If
                    End Get
                End Property

                Public ReadOnly Property BIOSVersion() As String()
                    Get
                        Return strBIOSVersion
                    End Get
                End Property

                Public ReadOnly Property BuildNumber() As String
                    Get
                        If IsNothing(strBuildNumber) = True Then
                            Return ""
                        Else
                            Return strBuildNumber
                        End If
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

                Public ReadOnly Property CodeSet() As String
                    Get
                        If IsNothing(strCodeSet) = True Then
                            Return ""
                        Else
                            Return strCodeSet
                        End If
                    End Get
                End Property

                Public ReadOnly Property CurrentLanguage() As String
                    Get
                        If IsNothing(strCurrentLanguage) = True Then
                            Return ""
                        Else
                            Return strCurrentLanguage
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

                Public ReadOnly Property EmbeddedControllerMajorVersion() As Byte
                    Get
                        Return bytEmbeddedControllerMajorVersion
                    End Get
                End Property

                Public ReadOnly Property EmbeddedControllerMinorVersion() As Byte
                    Get
                        Return bytEmbeddedControllerMinorVersion
                    End Get
                End Property

                Public ReadOnly Property IdentificationCode() As String
                    Get
                        If IsNothing(strIdentificationCode) = True Then
                            Return ""
                        Else
                            Return strIdentificationCode
                        End If
                    End Get
                End Property

                Public ReadOnly Property InstallableLanguages() As UShort
                    Get
                        Return srtInstallableLanguages
                    End Get
                End Property

                Public ReadOnly Property InstallDate() As Date
                    Get
                        Return dtInstallDate
                    End Get
                End Property

                Public ReadOnly Property LanguageEdition() As String
                    Get
                        If IsNothing(strLanguageEdition) = True Then
                            Return ""
                        Else
                            Return strLanguageEdition
                        End If
                    End Get
                End Property

                Public ReadOnly Property Manufacturer() As String
                    Get
                        If IsNothing(strManufacturer) = True Then
                            Return ""
                        Else
                            Return strManufacturer
                        End If
                    End Get
                End Property

                Public ReadOnly Property OtherTargetOS() As String
                    Get
                        If IsNothing(strOtherTargetOS) = True Then
                            Return ""
                        Else
                            Return strOtherTargetOS
                        End If
                    End Get
                End Property

                Public ReadOnly Property PrimaryBIOS() As Boolean
                    Get
                        Return bolPrimaryBIOS
                    End Get
                End Property

                Public ReadOnly Property ReleaseDate() As String
                    Get
                        Return strReleaseDate
                    End Get
                End Property

                Public ReadOnly Property SerialNumber() As String
                    Get
                        If IsNothing(strSerialNumber) = True Then
                            Return ""
                        Else
                            Return strSerialNumber
                        End If
                    End Get
                End Property

                Public ReadOnly Property SMBIOSBIOSVersion() As String
                    Get
                        If IsNothing(strSMBIOSBIOSVersion) = True Then
                            Return ""
                        Else
                            Return strSMBIOSBIOSVersion
                        End If
                    End Get
                End Property

                Public ReadOnly Property SMBIOSMajorVersion() As UShort
                    Get
                        Return srtSMBIOSMajorVersion
                    End Get
                End Property

                Public ReadOnly Property SMBIOSMinorVersion() As UShort
                    Get
                        Return srtSMBIOSMinorVersion
                    End Get
                End Property

                Public ReadOnly Property SMBIOSPresent() As Boolean
                    Get
                        Return bolSMBIOSPresent
                    End Get
                End Property

                Public ReadOnly Property SoftwareElementID() As String
                    Get
                        If IsNothing(strSoftwareElementID) = True Then
                            Return ""
                        Else
                            Return strSoftwareElementID
                        End If
                    End Get
                End Property

                Public ReadOnly Property SoftwareElementState() As UShort
                    Get
                        Return srtSoftwareElementState
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

                Public ReadOnly Property SystemBiosMajorVersion() As Byte
                    Get
                        Return bytSystemBiosMajorVersion
                    End Get
                End Property

                Public ReadOnly Property SystemBiosMinorVersion() As Byte
                    Get
                        Return bytSystemBiosMinorVersion
                    End Get
                End Property

                Public ReadOnly Property TargetOperatingSystem() As UShort
                    Get
                        Return srtTargetOperatingSystem
                    End Get
                End Property

                Public ReadOnly Property Version() As String
                    Get
                        If IsNothing(strVersion) = True Then
                            Return ""
                        Else
                            Return strVersion
                        End If
                    End Get
                End Property
#End Region



            End Class

        End Namespace
    End Namespace
End Namespace