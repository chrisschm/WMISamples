Imports CS.System
Imports CS.System.IO

Public Class Form1

    Private dds As DiskDrives
    Private dps As DiskPartitions



    Private Sub cmdRead_Click(sender As Object, e As EventArgs) Handles cmdRead.Click

        dds = New DiskDrives

        CBModel.Items.Clear()

        For Each dd As DiskDrive In dds
            CBModel.Items.Add(dd.Model & " (" & dd.SerialNumber & ")")
        Next

        CBModel.SelectedIndex = 0

    End Sub

    Private Sub cmdPRead_Click(sender As Object, e As EventArgs) Handles cmdPRead.Click

        dps = New DiskPartitions

        CMPName.Items.Clear()

        For Each dp As DiskPartition In dps
            CMPName.Items.Add(dp.DeviceID.ToString)
        Next

        CMPName.SelectedIndex = 0

    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged

        Dim serial As String
        Dim l As Long
        Dim lstvItem As ListViewItem

        If dds.Count = 0 Then Exit Sub

        serial = CBModel.Text
        l = InStr(serial, "(")
        serial = Mid(serial, l + 1, serial.Length - l - 1)

        lstDrive.Items.Clear()

        For Each dd As DiskDrive In dds

            If dd.SerialNumber = serial Then
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Availability"
                lstvItem.SubItems.Add(dd.Availability.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "BytesPerSector"
                lstvItem.SubItems.Add(dd.BytesPerSector.ToString)
                For l = 1 To dd.Capabilities.Count
                    lstvItem = lstDrive.Items.Add(New ListViewItem)
                    lstvItem.SubItems(0).Text = "Capabilities #" & l.ToString
                    lstvItem.SubItems.Add(dd.Capabilities(l - 1).ToString)
                Next
                For l = 1 To dd.CapabilityDescriptions.Count
                    lstvItem = lstDrive.Items.Add(New ListViewItem)
                    lstvItem.SubItems(0).Text = "CapabilityDescriptions #" & l.ToString
                    lstvItem.SubItems.Add(dd.CapabilityDescriptions(l - 1).ToString)
                Next
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Caption"
                lstvItem.SubItems.Add(dd.Caption.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CompressionMethod"
                lstvItem.SubItems.Add(dd.CompressionMethod.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerErrorCode"
                lstvItem.SubItems.Add(dd.ConfigManagerErrorCode.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerUserConfig"
                lstvItem.SubItems.Add(dd.ConfigManagerUserConfig.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CreationClassName"
                lstvItem.SubItems.Add(dd.CreationClassName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DefaultBlockSize"
                lstvItem.SubItems.Add(dd.DefaultBlockSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Description"
                lstvItem.SubItems.Add(dd.Description.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceID"
                lstvItem.SubItems.Add(dd.DeviceID.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceIndex"
                lstvItem.SubItems.Add(dd.DeviceIndex.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceName"
                lstvItem.SubItems.Add(dd.DeviceName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorCleared"
                lstvItem.SubItems.Add(dd.ErrorCleared.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorDescription"
                lstvItem.SubItems.Add(dd.ErrorDescription.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorMethodology"
                lstvItem.SubItems.Add(dd.ErrorMethodology.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "FirmwareRevision"
                lstvItem.SubItems.Add(dd.FirmwareRevision.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InstallDate"
                lstvItem.SubItems.Add(dd.InstallDate.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InterfaceType"
                lstvItem.SubItems.Add(dd.InterfaceType.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "LastErrorCode"
                lstvItem.SubItems.Add(dd.LastErrorCode.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Manufacturer"
                lstvItem.SubItems.Add(dd.Manufacturer.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MaxBlockSize"
                lstvItem.SubItems.Add(dd.MaxBlockSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MaxMediaSize"
                lstvItem.SubItems.Add(dd.MaxMediaSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MediaLoaded"
                lstvItem.SubItems.Add(dd.MediaLoaded.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MediaType"
                lstvItem.SubItems.Add(dd.MediaType.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MinBlockSize"
                lstvItem.SubItems.Add(dd.MinBlockSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Model"
                lstvItem.SubItems.Add(dd.Model.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "NeedsCleaning"
                lstvItem.SubItems.Add(dd.NeedsCleaning.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "NumberOfMediaSupported"
                lstvItem.SubItems.Add(dd.NumberOfMediaSupported.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Partitions"
                lstvItem.SubItems.Add(dd.Partitions.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PNPDeviceID"
                lstvItem.SubItems.Add(dd.PNPDeviceID.ToString)
                If dd.PowerManagementSupported = True Then
                    For l = 1 To dd.PowerManagementCapabilities.Count
                        lstvItem = lstDrive.Items.Add(New ListViewItem)
                        lstvItem.SubItems(0).Text = "PowerManagementCapabilities #" & l.ToString
                        lstvItem.SubItems.Add(dd.PowerManagementCapabilities(l - 1).ToString)
                    Next
                End If
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PowerManagementSupported"
                lstvItem.SubItems.Add(dd.PowerManagementSupported.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSIBus"
                lstvItem.SubItems.Add(dd.SCSIBus.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSILogicalUnit"
                lstvItem.SubItems.Add(dd.SCSILogicalUnit.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSIPort"
                lstvItem.SubItems.Add(dd.SCSIPort.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSITargetId"
                lstvItem.SubItems.Add(dd.SCSITargetId.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SectorsPerTrack"
                lstvItem.SubItems.Add(dd.SectorsPerTrack.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SerialNumber"
                lstvItem.SubItems.Add(dd.SerialNumber.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Signature"
                lstvItem.SubItems.Add(dd.Signature.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Size"
                lstvItem.SubItems.Add(dd.Size.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Status"
                lstvItem.SubItems.Add(dd.Status.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "StatusInfo"
                lstvItem.SubItems.Add(dd.StatusInfo.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemCreationClassName"
                lstvItem.SubItems.Add(dd.SystemCreationClassName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemName"
                lstvItem.SubItems.Add(dd.SystemName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalCylinders"
                lstvItem.SubItems.Add(dd.TotalCylinders.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalHeads"
                lstvItem.SubItems.Add(dd.TotalHeads.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalSectors"
                lstvItem.SubItems.Add(dd.TotalSectors.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalTracks"
                lstvItem.SubItems.Add(dd.TotalTracks.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TracksPerCylinder"
                lstvItem.SubItems.Add(dd.TracksPerCylinder.ToString)
                Exit For
            End If

        Next

    End Sub

    Private Sub CMPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMPName.SelectedIndexChanged

        Dim lstvItem As ListViewItem

        lstPartition.Items.Clear()

        For Each dp As DiskPartition In dps
            If dp.DeviceID.ToString = CMPName.Text Then
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Access"
                lstvItem.SubItems.Add(dp.Access.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Availability"
                lstvItem.SubItems.Add(dp.Availability.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "BlockSize"
                lstvItem.SubItems.Add(dp.BlockSize.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Bootable"
                lstvItem.SubItems.Add(dp.Bootable.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "BootPartition"
                lstvItem.SubItems.Add(dp.BootPartition.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Caption"
                lstvItem.SubItems.Add(dp.Caption.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerErrorCode"
                lstvItem.SubItems.Add(dp.ConfigManagerErrorCode.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerUserConfig"
                lstvItem.SubItems.Add(dp.ConfigManagerUserConfig.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CreationClassName"
                lstvItem.SubItems.Add(dp.CreationClassName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Description"
                lstvItem.SubItems.Add(dp.Description.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceID"
                lstvItem.SubItems.Add(dp.DeviceID.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DiskIndex"
                lstvItem.SubItems.Add(dp.DiskIndex.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DiskName"
                lstvItem.SubItems.Add(dp.DiskName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorCleared"
                lstvItem.SubItems.Add(dp.ErrorCleared.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorDescription"
                lstvItem.SubItems.Add(dp.ErrorDescription.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorMethodology"
                lstvItem.SubItems.Add(dp.ErrorMethodology.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "HiddenSectors"
                lstvItem.SubItems.Add(dp.HiddenSectors.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InstallDate"
                lstvItem.SubItems.Add(dp.InstallDate.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "LastErrorCode"
                lstvItem.SubItems.Add(dp.LastErrorCode.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "NumberOfBlocks"
                lstvItem.SubItems.Add(dp.NumberOfBlocks.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PartitionIndex"
                lstvItem.SubItems.Add(dp.PartitionIndex.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PNPDeviceID"
                lstvItem.SubItems.Add(dp.PNPDeviceID.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PrimaryPartition"
                lstvItem.SubItems.Add(dp.PrimaryPartition.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Purpose"
                lstvItem.SubItems.Add(dp.Purpose.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "RewritePartition"
                lstvItem.SubItems.Add(dp.RewritePartition.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Size"
                lstvItem.SubItems.Add(dp.Size.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "StartingOffset"
                lstvItem.SubItems.Add(dp.StartingOffset.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Status"
                lstvItem.SubItems.Add(dp.Status.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemCreationClassName"
                lstvItem.SubItems.Add(dp.SystemCreationClassName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemName"
                lstvItem.SubItems.Add(dp.SystemName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Type"
                lstvItem.SubItems.Add(dp.Type.ToString)
                Exit For
            End If
        Next

    End Sub


    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter

        Dim cBIOS As New BIOS
        Dim lstBIOSItem As ListViewItem
        Dim l As Long

        lstBIOS.Items.Clear()

        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "BiosName"
        lstBIOSItem.SubItems.Add(cBIOS.BiosName.ToString)
        For l = 1 To cBIOS.BIOSVersion.Count
            lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
            lstBIOSItem.SubItems(0).Text = "BIOSVersion #" & l.ToString
            lstBIOSItem.SubItems.Add(cBIOS.BIOSVersion(l - 1).ToString)
        Next
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "BuildNumber"
        lstBIOSItem.SubItems.Add(cBIOS.BuildNumber.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Caption"
        lstBIOSItem.SubItems.Add(cBIOS.Caption.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "CodeSet"
        lstBIOSItem.SubItems.Add(cBIOS.CodeSet.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "CurrentLanguage"
        lstBIOSItem.SubItems.Add(cBIOS.CurrentLanguage.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Description"
        lstBIOSItem.SubItems.Add(cBIOS.Description.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "EmbeddedControllerMajorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.EmbeddedControllerMajorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "EmbeddedControllerMinorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.EmbeddedControllerMinorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "IdentificationCode"
        lstBIOSItem.SubItems.Add(cBIOS.IdentificationCode.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "InstallableLanguages"
        lstBIOSItem.SubItems.Add(cBIOS.InstallableLanguages.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "InstallDate"
        lstBIOSItem.SubItems.Add(cBIOS.InstallDate.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "LanguageEdition"
        lstBIOSItem.SubItems.Add(cBIOS.LanguageEdition.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Manufacturer"
        lstBIOSItem.SubItems.Add(cBIOS.Manufacturer.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "OtherTargetOS"
        lstBIOSItem.SubItems.Add(cBIOS.OtherTargetOS.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "PrimaryBIOS"
        lstBIOSItem.SubItems.Add(cBIOS.PrimaryBIOS.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "ReleaseDate"
        lstBIOSItem.SubItems.Add(cBIOS.ReleaseDate.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SerialNumber"
        lstBIOSItem.SubItems.Add(cBIOS.SerialNumber.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSBIOSVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSBIOSVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSMajorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSMajorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSMinorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSMinorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSPresent"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSPresent.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SoftwareElementID"
        lstBIOSItem.SubItems.Add(cBIOS.SoftwareElementID.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SoftwareElementState"
        lstBIOSItem.SubItems.Add(cBIOS.SoftwareElementState.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Status"
        lstBIOSItem.SubItems.Add(cBIOS.Status.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SystemBiosMajorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SystemBiosMajorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SystemBiosMinorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SystemBiosMinorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "TargetOperatingSystem"
        lstBIOSItem.SubItems.Add(cBIOS.TargetOperatingSystem.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Version"
        lstBIOSItem.SubItems.Add(cBIOS.Version.ToString)
    End Sub

End Class
