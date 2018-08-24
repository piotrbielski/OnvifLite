﻿//------------------------------------------------------------------------------
// <generowane automatycznie>
//     Ten kod został wygenerowany przez narzędzie.
//     //
//     Zmiany w tym pliku mogą spowodować niewłaściwe zachowanie i zostaną utracone
//     w przypadku ponownego wygenerowania kodu.
// </generowane automatycznie>
//------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
                                                                   
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99" +
                                                                  "c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654" +
                                                                  "753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46" +
                                                                  "ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484c" +
                                                                  "f7045cc7")]

namespace OnvifLite.CameraManagementService
{      
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", ConfigurationName="CameraManagementService.Device")]
    internal interface Device : IDisposable
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetServices", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetServicesResponse> GetServicesAsync(CameraManagementService.GetServicesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetServiceCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Capabilities")]
        System.Threading.Tasks.Task<CameraManagementService.DeviceServiceCapabilities> GetServiceCapabilitiesAsync();
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDeviceInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetDeviceInformationResponse> GetDeviceInformationAsync(CameraManagementService.GetDeviceInformationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetSystemDateAndTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSystemDateAndTimeAsync(CameraManagementService.SetDateTimeType DateTimeType, bool DaylightSavings, CameraManagementService.TimeZone TimeZone, CameraManagementService.DateTime UTCDateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemDateAndTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SystemDateAndTime")]
        System.Threading.Tasks.Task<CameraManagementService.SystemDateTime> GetSystemDateAndTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetSystemFactoryDefault", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSystemFactoryDefaultAsync(CameraManagementService.FactoryDefaultType FactoryDefault);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/UpgradeSystemFirmware", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Message")]
        System.Threading.Tasks.Task<string> UpgradeSystemFirmwareAsync(CameraManagementService.AttachmentData Firmware);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SystemReboot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Message")]
        System.Threading.Tasks.Task<string> SystemRebootAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/RestoreSystem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.RestoreSystemResponse> RestoreSystemAsync(CameraManagementService.RestoreSystemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemBackup", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetSystemBackupResponse> GetSystemBackupAsync(CameraManagementService.GetSystemBackupRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemLog", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SystemLog")]
        System.Threading.Tasks.Task<CameraManagementService.SystemLog> GetSystemLogAsync(CameraManagementService.SystemLogType LogType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemSupportInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SupportInformation")]
        System.Threading.Tasks.Task<CameraManagementService.SupportInformation> GetSystemSupportInformationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetScopesResponse> GetScopesAsync(CameraManagementService.GetScopesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetScopesResponse> SetScopesAsync(CameraManagementService.SetScopesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/AddScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.AddScopesResponse> AddScopesAsync(CameraManagementService.AddScopesRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/RemoveScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.RemoveScopesResponse> RemoveScopesAsync(CameraManagementService.RemoveScopesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DiscoveryMode")]
        System.Threading.Tasks.Task<CameraManagementService.DiscoveryMode> GetDiscoveryModeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetDiscoveryModeAsync(CameraManagementService.DiscoveryMode DiscoveryMode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetRemoteDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RemoteDiscoveryMode")]
        System.Threading.Tasks.Task<CameraManagementService.DiscoveryMode> GetRemoteDiscoveryModeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRemoteDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRemoteDiscoveryModeAsync(CameraManagementService.DiscoveryMode RemoteDiscoveryMode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDPAddresses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetDPAddressesResponse> GetDPAddressesAsync(CameraManagementService.GetDPAddressesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDPAddresses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetDPAddressesResponse> SetDPAddressesAsync(CameraManagementService.SetDPAddressesRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetEndpointReference", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetEndpointReferenceResponse> GetEndpointReferenceAsync(CameraManagementService.GetEndpointReferenceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetRemoteUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RemoteUser")]
        System.Threading.Tasks.Task<CameraManagementService.RemoteUser> GetRemoteUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRemoteUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRemoteUserAsync(CameraManagementService.RemoteUser RemoteUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetUsersResponse> GetUsersAsync(CameraManagementService.GetUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.CreateUsersResponse> CreateUsersAsync(CameraManagementService.CreateUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.DeleteUsersResponse> DeleteUsersAsync(CameraManagementService.DeleteUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetUserResponse> SetUserAsync(CameraManagementService.SetUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetWsdlUrl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetWsdlUrlResponse> GetWsdlUrlAsync(CameraManagementService.GetWsdlUrlRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetCapabilitiesResponse> GetCapabilitiesAsync(CameraManagementService.GetCapabilitiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetHostname", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="HostnameInformation")]
        System.Threading.Tasks.Task<CameraManagementService.HostnameInformation> GetHostnameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetHostname", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetHostnameResponse> SetHostnameAsync(CameraManagementService.SetHostnameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetHostnameFromDHCP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RebootNeeded")]
        System.Threading.Tasks.Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DNSInformation")]
        System.Threading.Tasks.Task<CameraManagementService.DNSInformation> GetDNSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetDNSResponse> SetDNSAsync(CameraManagementService.SetDNSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNTP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="NTPInformation")]
        System.Threading.Tasks.Task<CameraManagementService.NTPInformation> GetNTPAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNTP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetNTPResponse> SetNTPAsync(CameraManagementService.SetNTPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDynamicDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DynamicDNSInformation")]
        System.Threading.Tasks.Task<CameraManagementService.DynamicDNSInformation> GetDynamicDNSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDynamicDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetDynamicDNSResponse> SetDynamicDNSAsync(CameraManagementService.SetDynamicDNSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNetworkInterfaces", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetNetworkInterfacesResponse> GetNetworkInterfacesAsync(CameraManagementService.GetNetworkInterfacesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNetworkInterfaces", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RebootNeeded")]
        System.Threading.Tasks.Task<bool> SetNetworkInterfacesAsync(string InterfaceToken, CameraManagementService.NetworkInterfaceSetConfiguration NetworkInterface);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNetworkProtocols", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetNetworkProtocolsResponse> GetNetworkProtocolsAsync(CameraManagementService.GetNetworkProtocolsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNetworkProtocols", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetNetworkProtocolsResponse> SetNetworkProtocolsAsync(CameraManagementService.SetNetworkProtocolsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNetworkDefaultGateway", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="NetworkGateway")]
        System.Threading.Tasks.Task<CameraManagementService.NetworkGateway> GetNetworkDefaultGatewayAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNetworkDefaultGateway", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetNetworkDefaultGatewayResponse> SetNetworkDefaultGatewayAsync(CameraManagementService.SetNetworkDefaultGatewayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetZeroConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ZeroConfiguration")]
        System.Threading.Tasks.Task<CameraManagementService.NetworkZeroConfiguration> GetZeroConfigurationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetZeroConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="IPAddressFilter")]
        System.Threading.Tasks.Task<CameraManagementService.IPAddressFilter> GetIPAddressFilterAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetIPAddressFilterAsync(CameraManagementService.IPAddressFilter IPAddressFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/AddIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddIPAddressFilterAsync(CameraManagementService.IPAddressFilter IPAddressFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/RemoveIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveIPAddressFilterAsync(CameraManagementService.IPAddressFilter IPAddressFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetAccessPolicy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PolicyFile")]
        System.Threading.Tasks.Task<CameraManagementService.BinaryData> GetAccessPolicyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetAccessPolicy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAccessPolicyAsync(CameraManagementService.BinaryData PolicyFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateCertificate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.CreateCertificateResponse> CreateCertificateAsync(CameraManagementService.CreateCertificateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetCertificatesResponse> GetCertificatesAsync(CameraManagementService.GetCertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCertificatesStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetCertificatesStatusResponse> GetCertificatesStatusAsync(CameraManagementService.GetCertificatesStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetCertificatesStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetCertificatesStatusResponse> SetCertificatesStatusAsync(CameraManagementService.SetCertificatesStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteCertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.DeleteCertificatesResponse> DeleteCertificatesAsync(CameraManagementService.DeleteCertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetPkcs10Request", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetPkcs10RequestResponse> GetPkcs10RequestAsync(CameraManagementService.GetPkcs10RequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/LoadCertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.LoadCertificatesResponse> LoadCertificatesAsync(CameraManagementService.LoadCertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetClientCertificateMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Enabled")]
        System.Threading.Tasks.Task<bool> GetClientCertificateModeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetClientCertificateMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetClientCertificateModeAsync(bool Enabled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetRelayOutputs", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetRelayOutputsResponse> GetRelayOutputsAsync(CameraManagementService.GetRelayOutputsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRelayOutputSettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRelayOutputSettingsAsync(string RelayOutputToken, CameraManagementService.RelayOutputSettings Properties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRelayOutputState", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRelayOutputStateAsync(string RelayOutputToken, CameraManagementService.RelayLogicalState LogicalState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SendAuxiliaryCommand", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="AuxiliaryCommandResponse")]
        System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCACertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetCACertificatesResponse> GetCACertificatesAsync(CameraManagementService.GetCACertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/LoadCertificateWithPrivateKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKeyAsync(CameraManagementService.LoadCertificateWithPrivateKeyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCertificateInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetCertificateInformationResponse> GetCertificateInformationAsync(CameraManagementService.GetCertificateInformationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/LoadCACertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.LoadCACertificatesResponse> LoadCACertificatesAsync(CameraManagementService.LoadCACertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task CreateDot1XConfigurationAsync(CameraManagementService.Dot1XConfiguration Dot1XConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetDot1XConfigurationAsync(CameraManagementService.Dot1XConfiguration Dot1XConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Dot1XConfiguration")]
        System.Threading.Tasks.Task<CameraManagementService.Dot1XConfiguration> GetDot1XConfigurationAsync(string Dot1XConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot1XConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetDot1XConfigurationsResponse> GetDot1XConfigurationsAsync(CameraManagementService.GetDot1XConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.DeleteDot1XConfigurationResponse> DeleteDot1XConfigurationAsync(CameraManagementService.DeleteDot1XConfigurationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot11Capabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetDot11CapabilitiesResponse> GetDot11CapabilitiesAsync(CameraManagementService.GetDot11CapabilitiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot11Status", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Status")]
        System.Threading.Tasks.Task<CameraManagementService.Dot11Status> GetDot11StatusAsync(string InterfaceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/ScanAvailableDot11Networks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.ScanAvailableDot11NetworksResponse> ScanAvailableDot11NetworksAsync(CameraManagementService.ScanAvailableDot11NetworksRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemUris", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetSystemUrisResponse> GetSystemUrisAsync(CameraManagementService.GetSystemUrisRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/StartFirmwareUpgrade", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.StartFirmwareUpgradeResponse> StartFirmwareUpgradeAsync(CameraManagementService.StartFirmwareUpgradeRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/StartSystemRestore", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.StartSystemRestoreResponse> StartSystemRestoreAsync(CameraManagementService.StartSystemRestoreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetStorageConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetStorageConfigurationsResponse> GetStorageConfigurationsAsync(CameraManagementService.GetStorageConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Token")]
        System.Threading.Tasks.Task<string> CreateStorageConfigurationAsync(CameraManagementService.StorageConfigurationData StorageConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="StorageConfiguration")]
        System.Threading.Tasks.Task<CameraManagementService.StorageConfiguration> GetStorageConfigurationAsync(string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetStorageConfigurationAsync(CameraManagementService.StorageConfiguration StorageConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task DeleteStorageConfigurationAsync(string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetGeoLocation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.GetGeoLocationResponse> GetGeoLocationAsync(CameraManagementService.GetGeoLocationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetGeoLocation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.SetGeoLocationResponse> SetGeoLocationAsync(CameraManagementService.SetGeoLocationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteGeoLocation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraManagementService.DeleteGeoLocationResponse> DeleteGeoLocationAsync(CameraManagementService.DeleteGeoLocationRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class Service
    {
        
        private string namespaceField;
        
        private string xAddrField;
        
        private System.Xml.Linq.XElement capabilitiesField;
        
        private OnvifVersion versionField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Xml.Linq.XElement Capabilities
        {
            get
            {
                return this.capabilitiesField;
            }
            set
            {
                this.capabilitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public OnvifVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=4)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OnvifVersion
    {
        
        private int majorField;
        
        private int minorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Major
        {
            get
            {
                return this.majorField;
            }
            set
            {
                this.majorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Minor
        {
            get
            {
                return this.minorField;
            }
            set
            {
                this.minorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class LocalOrientation
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private float panField;
        
        private bool panFieldSpecified;
        
        private float tiltField;
        
        private bool tiltFieldSpecified;
        
        private float rollField;
        
        private bool rollFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float pan
        {
            get
            {
                return this.panField;
            }
            set
            {
                this.panField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool panSpecified
        {
            get
            {
                return this.panFieldSpecified;
            }
            set
            {
                this.panFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float tilt
        {
            get
            {
                return this.tiltField;
            }
            set
            {
                this.tiltField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tiltSpecified
        {
            get
            {
                return this.tiltFieldSpecified;
            }
            set
            {
                this.tiltFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float roll
        {
            get
            {
                return this.rollField;
            }
            set
            {
                this.rollField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rollSpecified
        {
            get
            {
                return this.rollFieldSpecified;
            }
            set
            {
                this.rollFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class LocalLocation
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private float xField;
        
        private bool xFieldSpecified;
        
        private float yField;
        
        private bool yFieldSpecified;
        
        private float zField;
        
        private bool zFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ySpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool zSpecified
        {
            get
            {
                return this.zFieldSpecified;
            }
            set
            {
                this.zFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class GeoOrientation
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private float rollField;
        
        private bool rollFieldSpecified;
        
        private float pitchField;
        
        private bool pitchFieldSpecified;
        
        private float yawField;
        
        private bool yawFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float roll
        {
            get
            {
                return this.rollField;
            }
            set
            {
                this.rollField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rollSpecified
        {
            get
            {
                return this.rollFieldSpecified;
            }
            set
            {
                this.rollFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float pitch
        {
            get
            {
                return this.pitchField;
            }
            set
            {
                this.pitchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pitchSpecified
        {
            get
            {
                return this.pitchFieldSpecified;
            }
            set
            {
                this.pitchFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float yaw
        {
            get
            {
                return this.yawField;
            }
            set
            {
                this.yawField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yawSpecified
        {
            get
            {
                return this.yawFieldSpecified;
            }
            set
            {
                this.yawFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class GeoLocation
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private double lonField;
        
        private bool lonFieldSpecified;
        
        private double latField;
        
        private bool latFieldSpecified;
        
        private float elevationField;
        
        private bool elevationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double lon
        {
            get
            {
                return this.lonField;
            }
            set
            {
                this.lonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lonSpecified
        {
            get
            {
                return this.lonFieldSpecified;
            }
            set
            {
                this.lonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool latSpecified
        {
            get
            {
                return this.latFieldSpecified;
            }
            set
            {
                this.latFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float elevation
        {
            get
            {
                return this.elevationField;
            }
            set
            {
                this.elevationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool elevationSpecified
        {
            get
            {
                return this.elevationFieldSpecified;
            }
            set
            {
                this.elevationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class LocationEntity
    {
        
        private GeoLocation geoLocationField;
        
        private GeoOrientation geoOrientationField;
        
        private LocalLocation localLocationField;
        
        private LocalOrientation localOrientationField;
        
        private string entityField;
        
        private string tokenField;
        
        private bool fixedField;
        
        private bool fixedFieldSpecified;
        
        private string geoSourceField;
        
        private bool autoGeoField;
        
        private bool autoGeoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public GeoLocation GeoLocation
        {
            get
            {
                return this.geoLocationField;
            }
            set
            {
                this.geoLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public GeoOrientation GeoOrientation
        {
            get
            {
                return this.geoOrientationField;
            }
            set
            {
                this.geoOrientationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public LocalLocation LocalLocation
        {
            get
            {
                return this.localLocationField;
            }
            set
            {
                this.localLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public LocalOrientation LocalOrientation
        {
            get
            {
                return this.localOrientationField;
            }
            set
            {
                this.localOrientationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Entity
        {
            get
            {
                return this.entityField;
            }
            set
            {
                this.entityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fixed
        {
            get
            {
                return this.fixedField;
            }
            set
            {
                this.fixedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedSpecified
        {
            get
            {
                return this.fixedFieldSpecified;
            }
            set
            {
                this.fixedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string GeoSource
        {
            get
            {
                return this.geoSourceField;
            }
            set
            {
                this.geoSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AutoGeo
        {
            get
            {
                return this.autoGeoField;
            }
            set
            {
                this.autoGeoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoGeoSpecified
        {
            get
            {
                return this.autoGeoFieldSpecified;
            }
            set
            {
                this.autoGeoFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SystemLogUri
    {
        
        private SystemLogType typeField;
        
        private string uriField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SystemLogType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string Uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum SystemLogType
    {
        
        /// <remarks/>
        System,
        
        /// <remarks/>
        Access,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11AvailableNetworksExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11AvailableNetworks
    {
        
        private byte[] sSIDField;
        
        private string bSSIDField;
        
        private Dot11AuthAndMangementSuite[] authAndMangementSuiteField;
        
        private Dot11Cipher[] pairCipherField;
        
        private Dot11Cipher[] groupCipherField;
        
        private Dot11SignalStrength signalStrengthField;
        
        private bool signalStrengthFieldSpecified;
        
        private Dot11AvailableNetworksExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary", Order=0)]
        public byte[] SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string BSSID
        {
            get
            {
                return this.bSSIDField;
            }
            set
            {
                this.bSSIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuthAndMangementSuite", Order=2)]
        public Dot11AuthAndMangementSuite[] AuthAndMangementSuite
        {
            get
            {
                return this.authAndMangementSuiteField;
            }
            set
            {
                this.authAndMangementSuiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PairCipher", Order=3)]
        public Dot11Cipher[] PairCipher
        {
            get
            {
                return this.pairCipherField;
            }
            set
            {
                this.pairCipherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GroupCipher", Order=4)]
        public Dot11Cipher[] GroupCipher
        {
            get
            {
                return this.groupCipherField;
            }
            set
            {
                this.groupCipherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public Dot11SignalStrength SignalStrength
        {
            get
            {
                return this.signalStrengthField;
            }
            set
            {
                this.signalStrengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SignalStrengthSpecified
        {
            get
            {
                return this.signalStrengthFieldSpecified;
            }
            set
            {
                this.signalStrengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public Dot11AvailableNetworksExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum Dot11AuthAndMangementSuite
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Dot1X,
        
        /// <remarks/>
        PSK,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum Dot11Cipher
    {
        
        /// <remarks/>
        CCMP,
        
        /// <remarks/>
        TKIP,
        
        /// <remarks/>
        Any,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum Dot11SignalStrength
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Very Bad")]
        VeryBad,
        
        /// <remarks/>
        Bad,
        
        /// <remarks/>
        Good,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Very Good")]
        VeryGood,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11Status
    {
        
        private byte[] sSIDField;
        
        private string bSSIDField;
        
        private Dot11Cipher pairCipherField;
        
        private bool pairCipherFieldSpecified;
        
        private Dot11Cipher groupCipherField;
        
        private bool groupCipherFieldSpecified;
        
        private Dot11SignalStrength signalStrengthField;
        
        private bool signalStrengthFieldSpecified;
        
        private string activeConfigAliasField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary", Order=0)]
        public byte[] SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string BSSID
        {
            get
            {
                return this.bSSIDField;
            }
            set
            {
                this.bSSIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Dot11Cipher PairCipher
        {
            get
            {
                return this.pairCipherField;
            }
            set
            {
                this.pairCipherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PairCipherSpecified
        {
            get
            {
                return this.pairCipherFieldSpecified;
            }
            set
            {
                this.pairCipherFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Dot11Cipher GroupCipher
        {
            get
            {
                return this.groupCipherField;
            }
            set
            {
                this.groupCipherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroupCipherSpecified
        {
            get
            {
                return this.groupCipherFieldSpecified;
            }
            set
            {
                this.groupCipherFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Dot11SignalStrength SignalStrength
        {
            get
            {
                return this.signalStrengthField;
            }
            set
            {
                this.signalStrengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SignalStrengthSpecified
        {
            get
            {
                return this.signalStrengthFieldSpecified;
            }
            set
            {
                this.signalStrengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ActiveConfigAlias
        {
            get
            {
                return this.activeConfigAliasField;
            }
            set
            {
                this.activeConfigAliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=6)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11Capabilities
    {
        
        private bool tKIPField;
        
        private bool scanAvailableNetworksField;
        
        private bool multipleConfigurationField;
        
        private bool adHocStationModeField;
        
        private bool wEPField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool TKIP
        {
            get
            {
                return this.tKIPField;
            }
            set
            {
                this.tKIPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool ScanAvailableNetworks
        {
            get
            {
                return this.scanAvailableNetworksField;
            }
            set
            {
                this.scanAvailableNetworksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool MultipleConfiguration
        {
            get
            {
                return this.multipleConfigurationField;
            }
            set
            {
                this.multipleConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool AdHocStationMode
        {
            get
            {
                return this.adHocStationModeField;
            }
            set
            {
                this.adHocStationModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool WEP
        {
            get
            {
                return this.wEPField;
            }
            set
            {
                this.wEPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=5)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot1XConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class EapMethodExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class TLSConfiguration
    {
        
        private string certificateIDField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string CertificateID
        {
            get
            {
                return this.certificateIDField;
            }
            set
            {
                this.certificateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class EAPMethodConfiguration
    {
        
        private TLSConfiguration tLSConfigurationField;
        
        private string passwordField;
        
        private EapMethodExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TLSConfiguration TLSConfiguration
        {
            get
            {
                return this.tLSConfigurationField;
            }
            set
            {
                this.tLSConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public EapMethodExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot1XConfiguration
    {
        
        private string dot1XConfigurationTokenField;
        
        private string identityField;
        
        private string anonymousIDField;
        
        private int eAPMethodField;
        
        private string[] cACertificateIDField;
        
        private EAPMethodConfiguration eAPMethodConfigurationField;
        
        private Dot1XConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Dot1XConfigurationToken
        {
            get
            {
                return this.dot1XConfigurationTokenField;
            }
            set
            {
                this.dot1XConfigurationTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Identity
        {
            get
            {
                return this.identityField;
            }
            set
            {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string AnonymousID
        {
            get
            {
                return this.anonymousIDField;
            }
            set
            {
                this.anonymousIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int EAPMethod
        {
            get
            {
                return this.eAPMethodField;
            }
            set
            {
                this.eAPMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CACertificateID", DataType="token", Order=4)]
        public string[] CACertificateID
        {
            get
            {
                return this.cACertificateIDField;
            }
            set
            {
                this.cACertificateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public EAPMethodConfiguration EAPMethodConfiguration
        {
            get
            {
                return this.eAPMethodConfigurationField;
            }
            set
            {
                this.eAPMethodConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public Dot1XConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class CertificateInformationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DateTimeRange
    {
        
        private System.DateTime fromField;
        
        private System.DateTime untilField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Until
        {
            get
            {
                return this.untilField;
            }
            set
            {
                this.untilField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class CertificateUsage
    {
        
        private bool criticalField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Critical
        {
            get
            {
                return this.criticalField;
            }
            set
            {
                this.criticalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class CertificateInformation
    {
        
        private string certificateIDField;
        
        private string issuerDNField;
        
        private string subjectDNField;
        
        private CertificateUsage keyUsageField;
        
        private CertificateUsage extendedKeyUsageField;
        
        private int keyLengthField;
        
        private bool keyLengthFieldSpecified;
        
        private string versionField;
        
        private string serialNumField;
        
        private string signatureAlgorithmField;
        
        private DateTimeRange validityField;
        
        private CertificateInformationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string CertificateID
        {
            get
            {
                return this.certificateIDField;
            }
            set
            {
                this.certificateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string IssuerDN
        {
            get
            {
                return this.issuerDNField;
            }
            set
            {
                this.issuerDNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SubjectDN
        {
            get
            {
                return this.subjectDNField;
            }
            set
            {
                this.subjectDNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public CertificateUsage KeyUsage
        {
            get
            {
                return this.keyUsageField;
            }
            set
            {
                this.keyUsageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public CertificateUsage ExtendedKeyUsage
        {
            get
            {
                return this.extendedKeyUsageField;
            }
            set
            {
                this.extendedKeyUsageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int KeyLength
        {
            get
            {
                return this.keyLengthField;
            }
            set
            {
                this.keyLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KeyLengthSpecified
        {
            get
            {
                return this.keyLengthFieldSpecified;
            }
            set
            {
                this.keyLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string SerialNum
        {
            get
            {
                return this.serialNumField;
            }
            set
            {
                this.serialNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string SignatureAlgorithm
        {
            get
            {
                return this.signatureAlgorithmField;
            }
            set
            {
                this.signatureAlgorithmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public DateTimeRange Validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public CertificateInformationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class CertificateWithPrivateKey
    {
        
        private string certificateIDField;
        
        private BinaryData certificateField;
        
        private BinaryData privateKeyField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string CertificateID
        {
            get
            {
                return this.certificateIDField;
            }
            set
            {
                this.certificateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public BinaryData Certificate
        {
            get
            {
                return this.certificateField;
            }
            set
            {
                this.certificateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public BinaryData PrivateKey
        {
            get
            {
                return this.privateKeyField;
            }
            set
            {
                this.privateKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=3)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class BinaryData
    {
        
        private byte[] dataField;
        
        private string contentTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=0)]
        public byte[] Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/2005/05/xmlmime")]
        public string contentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class CertificateStatus
    {
        
        private string certificateIDField;
        
        private bool statusField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string CertificateID
        {
            get
            {
                return this.certificateIDField;
            }
            set
            {
                this.certificateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Certificate
    {
        
        private string certificateIDField;
        
        private BinaryData certificate1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string CertificateID
        {
            get
            {
                return this.certificateIDField;
            }
            set
            {
                this.certificateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Certificate", Order=1)]
        public BinaryData Certificate1
        {
            get
            {
                return this.certificate1Field;
            }
            set
            {
                this.certificate1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPAddressFilterExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPAddressFilter
    {
        
        private IPAddressFilterType typeField;
        
        private PrefixedIPv4Address[] iPv4AddressField;
        
        private PrefixedIPv6Address[] iPv6AddressField;
        
        private IPAddressFilterExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IPAddressFilterType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IPv4Address", Order=1)]
        public PrefixedIPv4Address[] IPv4Address
        {
            get
            {
                return this.iPv4AddressField;
            }
            set
            {
                this.iPv4AddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IPv6Address", Order=2)]
        public PrefixedIPv6Address[] IPv6Address
        {
            get
            {
                return this.iPv6AddressField;
            }
            set
            {
                this.iPv6AddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IPAddressFilterExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum IPAddressFilterType
    {
        
        /// <remarks/>
        Allow,
        
        /// <remarks/>
        Deny,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PrefixedIPv4Address
    {
        
        private string addressField;
        
        private int prefixLengthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int PrefixLength
        {
            get
            {
                return this.prefixLengthField;
            }
            set
            {
                this.prefixLengthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PrefixedIPv6Address
    {
        
        private string addressField;
        
        private int prefixLengthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int PrefixLength
        {
            get
            {
                return this.prefixLengthField;
            }
            set
            {
                this.prefixLengthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkZeroConfigurationExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkZeroConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private NetworkZeroConfiguration[] additionalField;
        
        private NetworkZeroConfigurationExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Additional", Order=1)]
        public NetworkZeroConfiguration[] Additional
        {
            get
            {
                return this.additionalField;
            }
            set
            {
                this.additionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public NetworkZeroConfigurationExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkZeroConfiguration
    {
        
        private string interfaceTokenField;
        
        private bool enabledField;
        
        private string[] addressesField;
        
        private NetworkZeroConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string InterfaceToken
        {
            get
            {
                return this.interfaceTokenField;
            }
            set
            {
                this.interfaceTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Addresses", DataType="token", Order=2)]
        public string[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public NetworkZeroConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkGateway
    {
        
        private string[] iPv4AddressField;
        
        private string[] iPv6AddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IPv4Address", DataType="token", Order=0)]
        public string[] IPv4Address
        {
            get
            {
                return this.iPv4AddressField;
            }
            set
            {
                this.iPv4AddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IPv6Address", DataType="token", Order=1)]
        public string[] IPv6Address
        {
            get
            {
                return this.iPv6AddressField;
            }
            set
            {
                this.iPv6AddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkProtocolExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkProtocol
    {
        
        private NetworkProtocolType nameField;
        
        private bool enabledField;
        
        private int[] portField;
        
        private NetworkProtocolExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NetworkProtocolType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Port", Order=2)]
        public int[] Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public NetworkProtocolExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum NetworkProtocolType
    {
        
        /// <remarks/>
        HTTP,
        
        /// <remarks/>
        HTTPS,
        
        /// <remarks/>
        RTSP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceSetConfigurationExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceSetConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private Dot3Configuration[] dot3Field;
        
        private Dot11Configuration[] dot11Field;
        
        private NetworkInterfaceSetConfigurationExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dot3", Order=1)]
        public Dot3Configuration[] Dot3
        {
            get
            {
                return this.dot3Field;
            }
            set
            {
                this.dot3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dot11", Order=2)]
        public Dot11Configuration[] Dot11
        {
            get
            {
                return this.dot11Field;
            }
            set
            {
                this.dot11Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public NetworkInterfaceSetConfigurationExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot3Configuration
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11Configuration
    {
        
        private byte[] sSIDField;
        
        private Dot11StationMode modeField;
        
        private string aliasField;
        
        private string priorityField;
        
        private Dot11SecurityConfiguration securityField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary", Order=0)]
        public byte[] SSID
        {
            get
            {
                return this.sSIDField;
            }
            set
            {
                this.sSIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Dot11StationMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
        public string Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Dot11SecurityConfiguration Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=5)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum Dot11StationMode
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ad-hoc")]
        Adhoc,
        
        /// <remarks/>
        Infrastructure,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11SecurityConfiguration
    {
        
        private Dot11SecurityMode modeField;
        
        private Dot11Cipher algorithmField;
        
        private bool algorithmFieldSpecified;
        
        private Dot11PSKSet pSKField;
        
        private string dot1XField;
        
        private Dot11SecurityConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Dot11SecurityMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Dot11Cipher Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlgorithmSpecified
        {
            get
            {
                return this.algorithmFieldSpecified;
            }
            set
            {
                this.algorithmFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Dot11PSKSet PSK
        {
            get
            {
                return this.pSKField;
            }
            set
            {
                this.pSKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Dot1X
        {
            get
            {
                return this.dot1XField;
            }
            set
            {
                this.dot1XField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Dot11SecurityConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum Dot11SecurityMode
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        WEP,
        
        /// <remarks/>
        PSK,
        
        /// <remarks/>
        Dot1X,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11PSKSet
    {
        
        private byte[] keyField;
        
        private string passphraseField;
        
        private Dot11PSKSetExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary", Order=0)]
        public byte[] Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Passphrase
        {
            get
            {
                return this.passphraseField;
            }
            set
            {
                this.passphraseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Dot11PSKSetExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11PSKSetExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Dot11SecurityConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPv6NetworkInterfaceSetConfiguration
    {
        
        private bool enabledField;
        
        private bool enabledFieldSpecified;
        
        private bool acceptRouterAdvertField;
        
        private bool acceptRouterAdvertFieldSpecified;
        
        private PrefixedIPv6Address[] manualField;
        
        private IPv6DHCPConfiguration dHCPField;
        
        private bool dHCPFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }
            set
            {
                this.enabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool AcceptRouterAdvert
        {
            get
            {
                return this.acceptRouterAdvertField;
            }
            set
            {
                this.acceptRouterAdvertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcceptRouterAdvertSpecified
        {
            get
            {
                return this.acceptRouterAdvertFieldSpecified;
            }
            set
            {
                this.acceptRouterAdvertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Manual", Order=2)]
        public PrefixedIPv6Address[] Manual
        {
            get
            {
                return this.manualField;
            }
            set
            {
                this.manualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IPv6DHCPConfiguration DHCP
        {
            get
            {
                return this.dHCPField;
            }
            set
            {
                this.dHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DHCPSpecified
        {
            get
            {
                return this.dHCPFieldSpecified;
            }
            set
            {
                this.dHCPFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum IPv6DHCPConfiguration
    {
        
        /// <remarks/>
        Auto,
        
        /// <remarks/>
        Stateful,
        
        /// <remarks/>
        Stateless,
        
        /// <remarks/>
        Off,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPv4NetworkInterfaceSetConfiguration
    {
        
        private bool enabledField;
        
        private bool enabledFieldSpecified;
        
        private PrefixedIPv4Address[] manualField;
        
        private bool dHCPField;
        
        private bool dHCPFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }
            set
            {
                this.enabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Manual", Order=1)]
        public PrefixedIPv4Address[] Manual
        {
            get
            {
                return this.manualField;
            }
            set
            {
                this.manualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool DHCP
        {
            get
            {
                return this.dHCPField;
            }
            set
            {
                this.dHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DHCPSpecified
        {
            get
            {
                return this.dHCPFieldSpecified;
            }
            set
            {
                this.dHCPFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceSetConfiguration
    {
        
        private bool enabledField;
        
        private bool enabledFieldSpecified;
        
        private NetworkInterfaceConnectionSetting linkField;
        
        private int mTUField;
        
        private bool mTUFieldSpecified;
        
        private IPv4NetworkInterfaceSetConfiguration iPv4Field;
        
        private IPv6NetworkInterfaceSetConfiguration iPv6Field;
        
        private NetworkInterfaceSetConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }
            set
            {
                this.enabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public NetworkInterfaceConnectionSetting Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int MTU
        {
            get
            {
                return this.mTUField;
            }
            set
            {
                this.mTUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MTUSpecified
        {
            get
            {
                return this.mTUFieldSpecified;
            }
            set
            {
                this.mTUFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IPv4NetworkInterfaceSetConfiguration IPv4
        {
            get
            {
                return this.iPv4Field;
            }
            set
            {
                this.iPv4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public IPv6NetworkInterfaceSetConfiguration IPv6
        {
            get
            {
                return this.iPv6Field;
            }
            set
            {
                this.iPv6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public NetworkInterfaceSetConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceConnectionSetting
    {
        
        private bool autoNegotiationField;
        
        private int speedField;
        
        private Duplex duplexField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool AutoNegotiation
        {
            get
            {
                return this.autoNegotiationField;
            }
            set
            {
                this.autoNegotiationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Duplex Duplex
        {
            get
            {
                return this.duplexField;
            }
            set
            {
                this.duplexField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum Duplex
    {
        
        /// <remarks/>
        Full,
        
        /// <remarks/>
        Half,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDImgConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDImgConfiguration
    {
        
        private string imgPathField;
        
        private OSDImgConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string ImgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public OSDImgConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDTextConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Color
    {
        
        private float xField;
        
        private float yField;
        
        private float zField;
        
        private string colorspaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Colorspace
        {
            get
            {
                return this.colorspaceField;
            }
            set
            {
                this.colorspaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDColor
    {
        
        private Color colorField;
        
        private int transparentField;
        
        private bool transparentFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Color Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Transparent
        {
            get
            {
                return this.transparentField;
            }
            set
            {
                this.transparentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransparentSpecified
        {
            get
            {
                return this.transparentFieldSpecified;
            }
            set
            {
                this.transparentFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDTextConfiguration
    {
        
        private string typeField;
        
        private string dateFormatField;
        
        private string timeFormatField;
        
        private int fontSizeField;
        
        private bool fontSizeFieldSpecified;
        
        private OSDColor fontColorField;
        
        private OSDColor backgroundColorField;
        
        private string plainTextField;
        
        private OSDTextConfigurationExtension extensionField;
        
        private bool isPersistentTextField;
        
        private bool isPersistentTextFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DateFormat
        {
            get
            {
                return this.dateFormatField;
            }
            set
            {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string TimeFormat
        {
            get
            {
                return this.timeFormatField;
            }
            set
            {
                this.timeFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int FontSize
        {
            get
            {
                return this.fontSizeField;
            }
            set
            {
                this.fontSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FontSizeSpecified
        {
            get
            {
                return this.fontSizeFieldSpecified;
            }
            set
            {
                this.fontSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public OSDColor FontColor
        {
            get
            {
                return this.fontColorField;
            }
            set
            {
                this.fontColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public OSDColor BackgroundColor
        {
            get
            {
                return this.backgroundColorField;
            }
            set
            {
                this.backgroundColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string PlainText
        {
            get
            {
                return this.plainTextField;
            }
            set
            {
                this.plainTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public OSDTextConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsPersistentText
        {
            get
            {
                return this.isPersistentTextField;
            }
            set
            {
                this.isPersistentTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPersistentTextSpecified
        {
            get
            {
                return this.isPersistentTextFieldSpecified;
            }
            set
            {
                this.isPersistentTextFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDPosConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Vector
    {
        
        private float xField;
        
        private bool xFieldSpecified;
        
        private float yField;
        
        private bool yFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ySpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDPosConfiguration
    {
        
        private string typeField;
        
        private Vector posField;
        
        private OSDPosConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Vector Pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public OSDPosConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDReference
    {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZNodeExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZPresetTourSupportedExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZPresetTourSupported
    {
        
        private int maximumNumberOfPresetToursField;
        
        private PTZPresetTourOperation[] pTZPresetTourOperationField;
        
        private PTZPresetTourSupportedExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int MaximumNumberOfPresetTours
        {
            get
            {
                return this.maximumNumberOfPresetToursField;
            }
            set
            {
                this.maximumNumberOfPresetToursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PTZPresetTourOperation", Order=1)]
        public PTZPresetTourOperation[] PTZPresetTourOperation
        {
            get
            {
                return this.pTZPresetTourOperationField;
            }
            set
            {
                this.pTZPresetTourOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public PTZPresetTourSupportedExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum PTZPresetTourOperation
    {
        
        /// <remarks/>
        Start,
        
        /// <remarks/>
        Stop,
        
        /// <remarks/>
        Pause,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZNodeExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private PTZPresetTourSupported supportedPresetTourField;
        
        private PTZNodeExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public PTZPresetTourSupported SupportedPresetTour
        {
            get
            {
                return this.supportedPresetTourField;
            }
            set
            {
                this.supportedPresetTourField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public PTZNodeExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZSpacesExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Space1DDescription
    {
        
        private string uRIField;
        
        private FloatRange xRangeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public FloatRange XRange
        {
            get
            {
                return this.xRangeField;
            }
            set
            {
                this.xRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class FloatRange
    {
        
        private float minField;
        
        private float maxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Space2DDescription
    {
        
        private string uRIField;
        
        private FloatRange xRangeField;
        
        private FloatRange yRangeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public FloatRange XRange
        {
            get
            {
                return this.xRangeField;
            }
            set
            {
                this.xRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public FloatRange YRange
        {
            get
            {
                return this.yRangeField;
            }
            set
            {
                this.yRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZSpaces
    {
        
        private Space2DDescription[] absolutePanTiltPositionSpaceField;
        
        private Space1DDescription[] absoluteZoomPositionSpaceField;
        
        private Space2DDescription[] relativePanTiltTranslationSpaceField;
        
        private Space1DDescription[] relativeZoomTranslationSpaceField;
        
        private Space2DDescription[] continuousPanTiltVelocitySpaceField;
        
        private Space1DDescription[] continuousZoomVelocitySpaceField;
        
        private Space1DDescription[] panTiltSpeedSpaceField;
        
        private Space1DDescription[] zoomSpeedSpaceField;
        
        private PTZSpacesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbsolutePanTiltPositionSpace", Order=0)]
        public Space2DDescription[] AbsolutePanTiltPositionSpace
        {
            get
            {
                return this.absolutePanTiltPositionSpaceField;
            }
            set
            {
                this.absolutePanTiltPositionSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbsoluteZoomPositionSpace", Order=1)]
        public Space1DDescription[] AbsoluteZoomPositionSpace
        {
            get
            {
                return this.absoluteZoomPositionSpaceField;
            }
            set
            {
                this.absoluteZoomPositionSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelativePanTiltTranslationSpace", Order=2)]
        public Space2DDescription[] RelativePanTiltTranslationSpace
        {
            get
            {
                return this.relativePanTiltTranslationSpaceField;
            }
            set
            {
                this.relativePanTiltTranslationSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelativeZoomTranslationSpace", Order=3)]
        public Space1DDescription[] RelativeZoomTranslationSpace
        {
            get
            {
                return this.relativeZoomTranslationSpaceField;
            }
            set
            {
                this.relativeZoomTranslationSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContinuousPanTiltVelocitySpace", Order=4)]
        public Space2DDescription[] ContinuousPanTiltVelocitySpace
        {
            get
            {
                return this.continuousPanTiltVelocitySpaceField;
            }
            set
            {
                this.continuousPanTiltVelocitySpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContinuousZoomVelocitySpace", Order=5)]
        public Space1DDescription[] ContinuousZoomVelocitySpace
        {
            get
            {
                return this.continuousZoomVelocitySpaceField;
            }
            set
            {
                this.continuousZoomVelocitySpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PanTiltSpeedSpace", Order=6)]
        public Space1DDescription[] PanTiltSpeedSpace
        {
            get
            {
                return this.panTiltSpeedSpaceField;
            }
            set
            {
                this.panTiltSpeedSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ZoomSpeedSpace", Order=7)]
        public Space1DDescription[] ZoomSpeedSpace
        {
            get
            {
                return this.zoomSpeedSpaceField;
            }
            set
            {
                this.zoomSpeedSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public PTZSpacesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class RelayOutputSettings
    {
        
        private RelayMode modeField;
        
        private string delayTimeField;
        
        private RelayIdleState idleStateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RelayMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=1)]
        public string DelayTime
        {
            get
            {
                return this.delayTimeField;
            }
            set
            {
                this.delayTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RelayIdleState IdleState
        {
            get
            {
                return this.idleStateField;
            }
            set
            {
                this.idleStateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum RelayMode
    {
        
        /// <remarks/>
        Monostable,
        
        /// <remarks/>
        Bistable,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum RelayIdleState
    {
        
        /// <remarks/>
        closed,
        
        /// <remarks/>
        open,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private int interfaceTypeField;
        
        private Dot3Configuration[] dot3Field;
        
        private Dot11Configuration[] dot11Field;
        
        private NetworkInterfaceExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int InterfaceType
        {
            get
            {
                return this.interfaceTypeField;
            }
            set
            {
                this.interfaceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dot3", Order=2)]
        public Dot3Configuration[] Dot3
        {
            get
            {
                return this.dot3Field;
            }
            set
            {
                this.dot3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dot11", Order=3)]
        public Dot11Configuration[] Dot11
        {
            get
            {
                return this.dot11Field;
            }
            set
            {
                this.dot11Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public NetworkInterfaceExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPv6ConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPv6Configuration
    {
        
        private bool acceptRouterAdvertField;
        
        private bool acceptRouterAdvertFieldSpecified;
        
        private IPv6DHCPConfiguration dHCPField;
        
        private PrefixedIPv6Address[] manualField;
        
        private PrefixedIPv6Address[] linkLocalField;
        
        private PrefixedIPv6Address[] fromDHCPField;
        
        private PrefixedIPv6Address[] fromRAField;
        
        private IPv6ConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool AcceptRouterAdvert
        {
            get
            {
                return this.acceptRouterAdvertField;
            }
            set
            {
                this.acceptRouterAdvertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcceptRouterAdvertSpecified
        {
            get
            {
                return this.acceptRouterAdvertFieldSpecified;
            }
            set
            {
                this.acceptRouterAdvertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IPv6DHCPConfiguration DHCP
        {
            get
            {
                return this.dHCPField;
            }
            set
            {
                this.dHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Manual", Order=2)]
        public PrefixedIPv6Address[] Manual
        {
            get
            {
                return this.manualField;
            }
            set
            {
                this.manualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinkLocal", Order=3)]
        public PrefixedIPv6Address[] LinkLocal
        {
            get
            {
                return this.linkLocalField;
            }
            set
            {
                this.linkLocalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromDHCP", Order=4)]
        public PrefixedIPv6Address[] FromDHCP
        {
            get
            {
                return this.fromDHCPField;
            }
            set
            {
                this.fromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromRA", Order=5)]
        public PrefixedIPv6Address[] FromRA
        {
            get
            {
                return this.fromRAField;
            }
            set
            {
                this.fromRAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public IPv6ConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPv6NetworkInterface
    {
        
        private bool enabledField;
        
        private IPv6Configuration configField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IPv6Configuration Config
        {
            get
            {
                return this.configField;
            }
            set
            {
                this.configField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPv4Configuration
    {
        
        private PrefixedIPv4Address[] manualField;
        
        private PrefixedIPv4Address linkLocalField;
        
        private PrefixedIPv4Address fromDHCPField;
        
        private bool dHCPField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Manual", Order=0)]
        public PrefixedIPv4Address[] Manual
        {
            get
            {
                return this.manualField;
            }
            set
            {
                this.manualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public PrefixedIPv4Address LinkLocal
        {
            get
            {
                return this.linkLocalField;
            }
            set
            {
                this.linkLocalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public PrefixedIPv4Address FromDHCP
        {
            get
            {
                return this.fromDHCPField;
            }
            set
            {
                this.fromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool DHCP
        {
            get
            {
                return this.dHCPField;
            }
            set
            {
                this.dHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=4)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPv4NetworkInterface
    {
        
        private bool enabledField;
        
        private IPv4Configuration configField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IPv4Configuration Config
        {
            get
            {
                return this.configField;
            }
            set
            {
                this.configField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceLink
    {
        
        private NetworkInterfaceConnectionSetting adminSettingsField;
        
        private NetworkInterfaceConnectionSetting operSettingsField;
        
        private int interfaceTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NetworkInterfaceConnectionSetting AdminSettings
        {
            get
            {
                return this.adminSettingsField;
            }
            set
            {
                this.adminSettingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public NetworkInterfaceConnectionSetting OperSettings
        {
            get
            {
                return this.operSettingsField;
            }
            set
            {
                this.operSettingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int InterfaceType
        {
            get
            {
                return this.interfaceTypeField;
            }
            set
            {
                this.interfaceTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterfaceInfo
    {
        
        private string nameField;
        
        private string hwAddressField;
        
        private int mTUField;
        
        private bool mTUFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string HwAddress
        {
            get
            {
                return this.hwAddressField;
            }
            set
            {
                this.hwAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int MTU
        {
            get
            {
                return this.mTUField;
            }
            set
            {
                this.mTUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MTUSpecified
        {
            get
            {
                return this.mTUFieldSpecified;
            }
            set
            {
                this.mTUFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoOutputExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class LayoutExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PaneLayout
    {
        
        private string paneField;
        
        private Rectangle areaField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Pane
        {
            get
            {
                return this.paneField;
            }
            set
            {
                this.paneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Rectangle Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Rectangle
    {
        
        private float bottomField;
        
        private bool bottomFieldSpecified;
        
        private float topField;
        
        private bool topFieldSpecified;
        
        private float rightField;
        
        private bool rightFieldSpecified;
        
        private float leftField;
        
        private bool leftFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float bottom
        {
            get
            {
                return this.bottomField;
            }
            set
            {
                this.bottomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bottomSpecified
        {
            get
            {
                return this.bottomFieldSpecified;
            }
            set
            {
                this.bottomFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float top
        {
            get
            {
                return this.topField;
            }
            set
            {
                this.topField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topSpecified
        {
            get
            {
                return this.topFieldSpecified;
            }
            set
            {
                this.topFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float right
        {
            get
            {
                return this.rightField;
            }
            set
            {
                this.rightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rightSpecified
        {
            get
            {
                return this.rightFieldSpecified;
            }
            set
            {
                this.rightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float left
        {
            get
            {
                return this.leftField;
            }
            set
            {
                this.leftField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool leftSpecified
        {
            get
            {
                return this.leftFieldSpecified;
            }
            set
            {
                this.leftFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Layout
    {
        
        private PaneLayout[] paneLayoutField;
        
        private LayoutExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaneLayout", Order=0)]
        public PaneLayout[] PaneLayout
        {
            get
            {
                return this.paneLayoutField;
            }
            set
            {
                this.paneLayoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public LayoutExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoSourceExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingSettingsExtension204
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NoiseReduction
    {
        
        private float levelField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DefoggingExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Defogging
    {
        
        private string modeField;
        
        private float levelField;
        
        private bool levelFieldSpecified;
        
        private DefoggingExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DefoggingExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ToneCompensationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ToneCompensation
    {
        
        private string modeField;
        
        private float levelField;
        
        private bool levelFieldSpecified;
        
        private ToneCompensationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ToneCompensationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingSettingsExtension203
    {
        
        private ToneCompensation toneCompensationField;
        
        private Defogging defoggingField;
        
        private NoiseReduction noiseReductionField;
        
        private ImagingSettingsExtension204 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ToneCompensation ToneCompensation
        {
            get
            {
                return this.toneCompensationField;
            }
            set
            {
                this.toneCompensationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Defogging Defogging
        {
            get
            {
                return this.defoggingField;
            }
            set
            {
                this.defoggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public NoiseReduction NoiseReduction
        {
            get
            {
                return this.noiseReductionField;
            }
            set
            {
                this.noiseReductionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ImagingSettingsExtension204 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IrCutFilterAutoAdjustmentExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IrCutFilterAutoAdjustment
    {
        
        private string boundaryTypeField;
        
        private float boundaryOffsetField;
        
        private bool boundaryOffsetFieldSpecified;
        
        private string responseTimeField;
        
        private IrCutFilterAutoAdjustmentExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string BoundaryType
        {
            get
            {
                return this.boundaryTypeField;
            }
            set
            {
                this.boundaryTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float BoundaryOffset
        {
            get
            {
                return this.boundaryOffsetField;
            }
            set
            {
                this.boundaryOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoundaryOffsetSpecified
        {
            get
            {
                return this.boundaryOffsetFieldSpecified;
            }
            set
            {
                this.boundaryOffsetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=2)]
        public string ResponseTime
        {
            get
            {
                return this.responseTimeField;
            }
            set
            {
                this.responseTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IrCutFilterAutoAdjustmentExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingSettingsExtension202
    {
        
        private IrCutFilterAutoAdjustment[] irCutFilterAutoAdjustmentField;
        
        private ImagingSettingsExtension203 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IrCutFilterAutoAdjustment", Order=0)]
        public IrCutFilterAutoAdjustment[] IrCutFilterAutoAdjustment
        {
            get
            {
                return this.irCutFilterAutoAdjustmentField;
            }
            set
            {
                this.irCutFilterAutoAdjustmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ImagingSettingsExtension203 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImageStabilizationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImageStabilization
    {
        
        private ImageStabilizationMode modeField;
        
        private float levelField;
        
        private bool levelFieldSpecified;
        
        private ImageStabilizationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ImageStabilizationMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ImageStabilizationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum ImageStabilizationMode
    {
        
        /// <remarks/>
        OFF,
        
        /// <remarks/>
        ON,
        
        /// <remarks/>
        AUTO,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingSettingsExtension20
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private ImageStabilization imageStabilizationField;
        
        private ImagingSettingsExtension202 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ImageStabilization ImageStabilization
        {
            get
            {
                return this.imageStabilizationField;
            }
            set
            {
                this.imageStabilizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ImagingSettingsExtension202 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class WhiteBalance20Extension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class WhiteBalance20
    {
        
        private WhiteBalanceMode modeField;
        
        private float crGainField;
        
        private bool crGainFieldSpecified;
        
        private float cbGainField;
        
        private bool cbGainFieldSpecified;
        
        private WhiteBalance20Extension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public WhiteBalanceMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float CrGain
        {
            get
            {
                return this.crGainField;
            }
            set
            {
                this.crGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CrGainSpecified
        {
            get
            {
                return this.crGainFieldSpecified;
            }
            set
            {
                this.crGainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float CbGain
        {
            get
            {
                return this.cbGainField;
            }
            set
            {
                this.cbGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CbGainSpecified
        {
            get
            {
                return this.cbGainFieldSpecified;
            }
            set
            {
                this.cbGainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public WhiteBalance20Extension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum WhiteBalanceMode
    {
        
        /// <remarks/>
        AUTO,
        
        /// <remarks/>
        MANUAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class WideDynamicRange20
    {
        
        private WideDynamicMode modeField;
        
        private float levelField;
        
        private bool levelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public WideDynamicMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum WideDynamicMode
    {
        
        /// <remarks/>
        OFF,
        
        /// <remarks/>
        ON,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class FocusConfiguration20Extension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class FocusConfiguration20
    {
        
        private AutoFocusMode autoFocusModeField;
        
        private float defaultSpeedField;
        
        private bool defaultSpeedFieldSpecified;
        
        private float nearLimitField;
        
        private bool nearLimitFieldSpecified;
        
        private float farLimitField;
        
        private bool farLimitFieldSpecified;
        
        private FocusConfiguration20Extension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AutoFocusMode AutoFocusMode
        {
            get
            {
                return this.autoFocusModeField;
            }
            set
            {
                this.autoFocusModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float DefaultSpeed
        {
            get
            {
                return this.defaultSpeedField;
            }
            set
            {
                this.defaultSpeedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultSpeedSpecified
        {
            get
            {
                return this.defaultSpeedFieldSpecified;
            }
            set
            {
                this.defaultSpeedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float NearLimit
        {
            get
            {
                return this.nearLimitField;
            }
            set
            {
                this.nearLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NearLimitSpecified
        {
            get
            {
                return this.nearLimitFieldSpecified;
            }
            set
            {
                this.nearLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float FarLimit
        {
            get
            {
                return this.farLimitField;
            }
            set
            {
                this.farLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FarLimitSpecified
        {
            get
            {
                return this.farLimitFieldSpecified;
            }
            set
            {
                this.farLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public FocusConfiguration20Extension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum AutoFocusMode
    {
        
        /// <remarks/>
        AUTO,
        
        /// <remarks/>
        MANUAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Exposure20
    {
        
        private ExposureMode modeField;
        
        private ExposurePriority priorityField;
        
        private bool priorityFieldSpecified;
        
        private Rectangle windowField;
        
        private float minExposureTimeField;
        
        private bool minExposureTimeFieldSpecified;
        
        private float maxExposureTimeField;
        
        private bool maxExposureTimeFieldSpecified;
        
        private float minGainField;
        
        private bool minGainFieldSpecified;
        
        private float maxGainField;
        
        private bool maxGainFieldSpecified;
        
        private float minIrisField;
        
        private bool minIrisFieldSpecified;
        
        private float maxIrisField;
        
        private bool maxIrisFieldSpecified;
        
        private float exposureTimeField;
        
        private bool exposureTimeFieldSpecified;
        
        private float gainField;
        
        private bool gainFieldSpecified;
        
        private float irisField;
        
        private bool irisFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ExposureMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ExposurePriority Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrioritySpecified
        {
            get
            {
                return this.priorityFieldSpecified;
            }
            set
            {
                this.priorityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Rectangle Window
        {
            get
            {
                return this.windowField;
            }
            set
            {
                this.windowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float MinExposureTime
        {
            get
            {
                return this.minExposureTimeField;
            }
            set
            {
                this.minExposureTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinExposureTimeSpecified
        {
            get
            {
                return this.minExposureTimeFieldSpecified;
            }
            set
            {
                this.minExposureTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public float MaxExposureTime
        {
            get
            {
                return this.maxExposureTimeField;
            }
            set
            {
                this.maxExposureTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxExposureTimeSpecified
        {
            get
            {
                return this.maxExposureTimeFieldSpecified;
            }
            set
            {
                this.maxExposureTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public float MinGain
        {
            get
            {
                return this.minGainField;
            }
            set
            {
                this.minGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinGainSpecified
        {
            get
            {
                return this.minGainFieldSpecified;
            }
            set
            {
                this.minGainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public float MaxGain
        {
            get
            {
                return this.maxGainField;
            }
            set
            {
                this.maxGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxGainSpecified
        {
            get
            {
                return this.maxGainFieldSpecified;
            }
            set
            {
                this.maxGainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public float MinIris
        {
            get
            {
                return this.minIrisField;
            }
            set
            {
                this.minIrisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinIrisSpecified
        {
            get
            {
                return this.minIrisFieldSpecified;
            }
            set
            {
                this.minIrisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public float MaxIris
        {
            get
            {
                return this.maxIrisField;
            }
            set
            {
                this.maxIrisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxIrisSpecified
        {
            get
            {
                return this.maxIrisFieldSpecified;
            }
            set
            {
                this.maxIrisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public float ExposureTime
        {
            get
            {
                return this.exposureTimeField;
            }
            set
            {
                this.exposureTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExposureTimeSpecified
        {
            get
            {
                return this.exposureTimeFieldSpecified;
            }
            set
            {
                this.exposureTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public float Gain
        {
            get
            {
                return this.gainField;
            }
            set
            {
                this.gainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GainSpecified
        {
            get
            {
                return this.gainFieldSpecified;
            }
            set
            {
                this.gainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public float Iris
        {
            get
            {
                return this.irisField;
            }
            set
            {
                this.irisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IrisSpecified
        {
            get
            {
                return this.irisFieldSpecified;
            }
            set
            {
                this.irisFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum ExposureMode
    {
        
        /// <remarks/>
        AUTO,
        
        /// <remarks/>
        MANUAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum ExposurePriority
    {
        
        /// <remarks/>
        LowNoise,
        
        /// <remarks/>
        FrameRate,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class BacklightCompensation20
    {
        
        private BacklightCompensationMode modeField;
        
        private float levelField;
        
        private bool levelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public BacklightCompensationMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum BacklightCompensationMode
    {
        
        /// <remarks/>
        OFF,
        
        /// <remarks/>
        ON,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingSettings20
    {
        
        private BacklightCompensation20 backlightCompensationField;
        
        private float brightnessField;
        
        private bool brightnessFieldSpecified;
        
        private float colorSaturationField;
        
        private bool colorSaturationFieldSpecified;
        
        private float contrastField;
        
        private bool contrastFieldSpecified;
        
        private Exposure20 exposureField;
        
        private FocusConfiguration20 focusField;
        
        private IrCutFilterMode irCutFilterField;
        
        private bool irCutFilterFieldSpecified;
        
        private float sharpnessField;
        
        private bool sharpnessFieldSpecified;
        
        private WideDynamicRange20 wideDynamicRangeField;
        
        private WhiteBalance20 whiteBalanceField;
        
        private ImagingSettingsExtension20 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public BacklightCompensation20 BacklightCompensation
        {
            get
            {
                return this.backlightCompensationField;
            }
            set
            {
                this.backlightCompensationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrightnessSpecified
        {
            get
            {
                return this.brightnessFieldSpecified;
            }
            set
            {
                this.brightnessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float ColorSaturation
        {
            get
            {
                return this.colorSaturationField;
            }
            set
            {
                this.colorSaturationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColorSaturationSpecified
        {
            get
            {
                return this.colorSaturationFieldSpecified;
            }
            set
            {
                this.colorSaturationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float Contrast
        {
            get
            {
                return this.contrastField;
            }
            set
            {
                this.contrastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContrastSpecified
        {
            get
            {
                return this.contrastFieldSpecified;
            }
            set
            {
                this.contrastFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Exposure20 Exposure
        {
            get
            {
                return this.exposureField;
            }
            set
            {
                this.exposureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public FocusConfiguration20 Focus
        {
            get
            {
                return this.focusField;
            }
            set
            {
                this.focusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public IrCutFilterMode IrCutFilter
        {
            get
            {
                return this.irCutFilterField;
            }
            set
            {
                this.irCutFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IrCutFilterSpecified
        {
            get
            {
                return this.irCutFilterFieldSpecified;
            }
            set
            {
                this.irCutFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public float Sharpness
        {
            get
            {
                return this.sharpnessField;
            }
            set
            {
                this.sharpnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SharpnessSpecified
        {
            get
            {
                return this.sharpnessFieldSpecified;
            }
            set
            {
                this.sharpnessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public WideDynamicRange20 WideDynamicRange
        {
            get
            {
                return this.wideDynamicRangeField;
            }
            set
            {
                this.wideDynamicRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public WhiteBalance20 WhiteBalance
        {
            get
            {
                return this.whiteBalanceField;
            }
            set
            {
                this.whiteBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public ImagingSettingsExtension20 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum IrCutFilterMode
    {
        
        /// <remarks/>
        ON,
        
        /// <remarks/>
        OFF,
        
        /// <remarks/>
        AUTO,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoSourceExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private ImagingSettings20 imagingField;
        
        private VideoSourceExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ImagingSettings20 Imaging
        {
            get
            {
                return this.imagingField;
            }
            set
            {
                this.imagingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public VideoSourceExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingSettingsExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class WhiteBalance
    {
        
        private WhiteBalanceMode modeField;
        
        private float crGainField;
        
        private float cbGainField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public WhiteBalanceMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float CrGain
        {
            get
            {
                return this.crGainField;
            }
            set
            {
                this.crGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float CbGain
        {
            get
            {
                return this.cbGainField;
            }
            set
            {
                this.cbGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=3)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class WideDynamicRange
    {
        
        private WideDynamicMode modeField;
        
        private float levelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public WideDynamicMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class FocusConfiguration
    {
        
        private AutoFocusMode autoFocusModeField;
        
        private float defaultSpeedField;
        
        private float nearLimitField;
        
        private float farLimitField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AutoFocusMode AutoFocusMode
        {
            get
            {
                return this.autoFocusModeField;
            }
            set
            {
                this.autoFocusModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float DefaultSpeed
        {
            get
            {
                return this.defaultSpeedField;
            }
            set
            {
                this.defaultSpeedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float NearLimit
        {
            get
            {
                return this.nearLimitField;
            }
            set
            {
                this.nearLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float FarLimit
        {
            get
            {
                return this.farLimitField;
            }
            set
            {
                this.farLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=4)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Exposure
    {
        
        private ExposureMode modeField;
        
        private ExposurePriority priorityField;
        
        private Rectangle windowField;
        
        private float minExposureTimeField;
        
        private float maxExposureTimeField;
        
        private float minGainField;
        
        private float maxGainField;
        
        private float minIrisField;
        
        private float maxIrisField;
        
        private float exposureTimeField;
        
        private float gainField;
        
        private float irisField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ExposureMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ExposurePriority Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Rectangle Window
        {
            get
            {
                return this.windowField;
            }
            set
            {
                this.windowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float MinExposureTime
        {
            get
            {
                return this.minExposureTimeField;
            }
            set
            {
                this.minExposureTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public float MaxExposureTime
        {
            get
            {
                return this.maxExposureTimeField;
            }
            set
            {
                this.maxExposureTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public float MinGain
        {
            get
            {
                return this.minGainField;
            }
            set
            {
                this.minGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public float MaxGain
        {
            get
            {
                return this.maxGainField;
            }
            set
            {
                this.maxGainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public float MinIris
        {
            get
            {
                return this.minIrisField;
            }
            set
            {
                this.minIrisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public float MaxIris
        {
            get
            {
                return this.maxIrisField;
            }
            set
            {
                this.maxIrisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public float ExposureTime
        {
            get
            {
                return this.exposureTimeField;
            }
            set
            {
                this.exposureTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public float Gain
        {
            get
            {
                return this.gainField;
            }
            set
            {
                this.gainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public float Iris
        {
            get
            {
                return this.irisField;
            }
            set
            {
                this.irisField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class BacklightCompensation
    {
        
        private BacklightCompensationMode modeField;
        
        private float levelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public BacklightCompensationMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingSettings
    {
        
        private BacklightCompensation backlightCompensationField;
        
        private float brightnessField;
        
        private bool brightnessFieldSpecified;
        
        private float colorSaturationField;
        
        private bool colorSaturationFieldSpecified;
        
        private float contrastField;
        
        private bool contrastFieldSpecified;
        
        private Exposure exposureField;
        
        private FocusConfiguration focusField;
        
        private IrCutFilterMode irCutFilterField;
        
        private bool irCutFilterFieldSpecified;
        
        private float sharpnessField;
        
        private bool sharpnessFieldSpecified;
        
        private WideDynamicRange wideDynamicRangeField;
        
        private WhiteBalance whiteBalanceField;
        
        private ImagingSettingsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public BacklightCompensation BacklightCompensation
        {
            get
            {
                return this.backlightCompensationField;
            }
            set
            {
                this.backlightCompensationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrightnessSpecified
        {
            get
            {
                return this.brightnessFieldSpecified;
            }
            set
            {
                this.brightnessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float ColorSaturation
        {
            get
            {
                return this.colorSaturationField;
            }
            set
            {
                this.colorSaturationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColorSaturationSpecified
        {
            get
            {
                return this.colorSaturationFieldSpecified;
            }
            set
            {
                this.colorSaturationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float Contrast
        {
            get
            {
                return this.contrastField;
            }
            set
            {
                this.contrastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContrastSpecified
        {
            get
            {
                return this.contrastFieldSpecified;
            }
            set
            {
                this.contrastFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Exposure Exposure
        {
            get
            {
                return this.exposureField;
            }
            set
            {
                this.exposureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public FocusConfiguration Focus
        {
            get
            {
                return this.focusField;
            }
            set
            {
                this.focusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public IrCutFilterMode IrCutFilter
        {
            get
            {
                return this.irCutFilterField;
            }
            set
            {
                this.irCutFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IrCutFilterSpecified
        {
            get
            {
                return this.irCutFilterFieldSpecified;
            }
            set
            {
                this.irCutFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public float Sharpness
        {
            get
            {
                return this.sharpnessField;
            }
            set
            {
                this.sharpnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SharpnessSpecified
        {
            get
            {
                return this.sharpnessFieldSpecified;
            }
            set
            {
                this.sharpnessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public WideDynamicRange WideDynamicRange
        {
            get
            {
                return this.wideDynamicRangeField;
            }
            set
            {
                this.wideDynamicRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public WhiteBalance WhiteBalance
        {
            get
            {
                return this.whiteBalanceField;
            }
            set
            {
                this.whiteBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public ImagingSettingsExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoResolution
    {
        
        private int widthField;
        
        private int heightField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class UserCredential
    {
        
        private string userNameField;
        
        private string passwordField;
        
        private UserCredentialExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public UserCredentialExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class UserCredentialExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class StorageConfigurationData
    {
        
        private string localPathField;
        
        private string storageUriField;
        
        private UserCredential userField;
        
        private StorageConfigurationDataExtension extensionField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string LocalPath
        {
            get
            {
                return this.localPathField;
            }
            set
            {
                this.localPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string StorageUri
        {
            get
            {
                return this.storageUriField;
            }
            set
            {
                this.storageUriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public UserCredential User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public StorageConfigurationDataExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class StorageConfigurationDataExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OSDConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PTZNode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DigitalInput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelayOutput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioOutput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoOutput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioSource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoSource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StorageConfiguration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DeviceEntity
    {
        
        private string tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDConfiguration : DeviceEntity
    {
        
        private OSDReference videoSourceConfigurationTokenField;
        
        private OSDType typeField;
        
        private OSDPosConfiguration positionField;
        
        private OSDTextConfiguration textStringField;
        
        private OSDImgConfiguration imageField;
        
        private OSDConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public OSDReference VideoSourceConfigurationToken
        {
            get
            {
                return this.videoSourceConfigurationTokenField;
            }
            set
            {
                this.videoSourceConfigurationTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public OSDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public OSDPosConfiguration Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public OSDTextConfiguration TextString
        {
            get
            {
                return this.textStringField;
            }
            set
            {
                this.textStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public OSDImgConfiguration Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public OSDConfigurationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum OSDType
    {
        
        /// <remarks/>
        Text,
        
        /// <remarks/>
        Image,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZNode : DeviceEntity
    {
        
        private string nameField;
        
        private PTZSpaces supportedPTZSpacesField;
        
        private int maximumNumberOfPresetsField;
        
        private bool homeSupportedField;
        
        private string[] auxiliaryCommandsField;
        
        private PTZNodeExtension extensionField;
        
        private bool fixedHomePositionField;
        
        private bool fixedHomePositionFieldSpecified;
        
        private bool geoMoveField;
        
        private bool geoMoveFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public PTZSpaces SupportedPTZSpaces
        {
            get
            {
                return this.supportedPTZSpacesField;
            }
            set
            {
                this.supportedPTZSpacesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int MaximumNumberOfPresets
        {
            get
            {
                return this.maximumNumberOfPresetsField;
            }
            set
            {
                this.maximumNumberOfPresetsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool HomeSupported
        {
            get
            {
                return this.homeSupportedField;
            }
            set
            {
                this.homeSupportedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuxiliaryCommands", Order=4)]
        public string[] AuxiliaryCommands
        {
            get
            {
                return this.auxiliaryCommandsField;
            }
            set
            {
                this.auxiliaryCommandsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public PTZNodeExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FixedHomePosition
        {
            get
            {
                return this.fixedHomePositionField;
            }
            set
            {
                this.fixedHomePositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedHomePositionSpecified
        {
            get
            {
                return this.fixedHomePositionFieldSpecified;
            }
            set
            {
                this.fixedHomePositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GeoMove
        {
            get
            {
                return this.geoMoveField;
            }
            set
            {
                this.geoMoveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GeoMoveSpecified
        {
            get
            {
                return this.geoMoveFieldSpecified;
            }
            set
            {
                this.geoMoveFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DigitalInput : DeviceEntity
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private DigitalIdleState idleStateField;
        
        private bool idleStateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DigitalIdleState IdleState
        {
            get
            {
                return this.idleStateField;
            }
            set
            {
                this.idleStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdleStateSpecified
        {
            get
            {
                return this.idleStateFieldSpecified;
            }
            set
            {
                this.idleStateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum DigitalIdleState
    {
        
        /// <remarks/>
        closed,
        
        /// <remarks/>
        open,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class RelayOutput : DeviceEntity
    {
        
        private RelayOutputSettings propertiesField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RelayOutputSettings Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkInterface : DeviceEntity
    {
        
        private bool enabledField;
        
        private NetworkInterfaceInfo infoField;
        
        private NetworkInterfaceLink linkField;
        
        private IPv4NetworkInterface iPv4Field;
        
        private IPv6NetworkInterface iPv6Field;
        
        private NetworkInterfaceExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public NetworkInterfaceInfo Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public NetworkInterfaceLink Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IPv4NetworkInterface IPv4
        {
            get
            {
                return this.iPv4Field;
            }
            set
            {
                this.iPv4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public IPv6NetworkInterface IPv6
        {
            get
            {
                return this.iPv6Field;
            }
            set
            {
                this.iPv6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public NetworkInterfaceExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AudioOutput : DeviceEntity
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoOutput : DeviceEntity
    {
        
        private Layout layoutField;
        
        private VideoResolution resolutionField;
        
        private float refreshRateField;
        
        private bool refreshRateFieldSpecified;
        
        private float aspectRatioField;
        
        private bool aspectRatioFieldSpecified;
        
        private VideoOutputExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Layout Layout
        {
            get
            {
                return this.layoutField;
            }
            set
            {
                this.layoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public VideoResolution Resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float RefreshRate
        {
            get
            {
                return this.refreshRateField;
            }
            set
            {
                this.refreshRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefreshRateSpecified
        {
            get
            {
                return this.refreshRateFieldSpecified;
            }
            set
            {
                this.refreshRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public float AspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AspectRatioSpecified
        {
            get
            {
                return this.aspectRatioFieldSpecified;
            }
            set
            {
                this.aspectRatioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public VideoOutputExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AudioSource : DeviceEntity
    {
        
        private int channelsField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Channels
        {
            get
            {
                return this.channelsField;
            }
            set
            {
                this.channelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoSource : DeviceEntity
    {
        
        private float framerateField;
        
        private VideoResolution resolutionField;
        
        private ImagingSettings imagingField;
        
        private VideoSourceExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float Framerate
        {
            get
            {
                return this.framerateField;
            }
            set
            {
                this.framerateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public VideoResolution Resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ImagingSettings Imaging
        {
            get
            {
                return this.imagingField;
            }
            set
            {
                this.imagingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public VideoSourceExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class StorageConfiguration : DeviceEntity
    {
        
        private StorageConfigurationData dataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StorageConfigurationData Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DynamicDNSInformationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DynamicDNSInformation
    {
        
        private DynamicDNSType typeField;
        
        private string nameField;
        
        private string tTLField;
        
        private DynamicDNSInformationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DynamicDNSType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=2)]
        public string TTL
        {
            get
            {
                return this.tTLField;
            }
            set
            {
                this.tTLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public DynamicDNSInformationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum DynamicDNSType
    {
        
        /// <remarks/>
        NoUpdate,
        
        /// <remarks/>
        ClientUpdates,
        
        /// <remarks/>
        ServerUpdates,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NTPInformationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NTPInformation
    {
        
        private bool fromDHCPField;
        
        private NetworkHost[] nTPFromDHCPField;
        
        private NetworkHost[] nTPManualField;
        
        private NTPInformationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool FromDHCP
        {
            get
            {
                return this.fromDHCPField;
            }
            set
            {
                this.fromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NTPFromDHCP", Order=1)]
        public NetworkHost[] NTPFromDHCP
        {
            get
            {
                return this.nTPFromDHCPField;
            }
            set
            {
                this.nTPFromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NTPManual", Order=2)]
        public NetworkHost[] NTPManual
        {
            get
            {
                return this.nTPManualField;
            }
            set
            {
                this.nTPManualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public NTPInformationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkHost
    {
        
        private NetworkHostType typeField;
        
        private string iPv4AddressField;
        
        private string iPv6AddressField;
        
        private string dNSnameField;
        
        private NetworkHostExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NetworkHostType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string IPv4Address
        {
            get
            {
                return this.iPv4AddressField;
            }
            set
            {
                this.iPv4AddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string IPv6Address
        {
            get
            {
                return this.iPv6AddressField;
            }
            set
            {
                this.iPv6AddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string DNSname
        {
            get
            {
                return this.dNSnameField;
            }
            set
            {
                this.dNSnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public NetworkHostExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum NetworkHostType
    {
        
        /// <remarks/>
        IPv4,
        
        /// <remarks/>
        IPv6,
        
        /// <remarks/>
        DNS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkHostExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DNSInformationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IPAddress
    {
        
        private IPType typeField;
        
        private string iPv4AddressField;
        
        private string iPv6AddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IPType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string IPv4Address
        {
            get
            {
                return this.iPv4AddressField;
            }
            set
            {
                this.iPv4AddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string IPv6Address
        {
            get
            {
                return this.iPv6AddressField;
            }
            set
            {
                this.iPv6AddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum IPType
    {
        
        /// <remarks/>
        IPv4,
        
        /// <remarks/>
        IPv6,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DNSInformation
    {
        
        private bool fromDHCPField;
        
        private string[] searchDomainField;
        
        private IPAddress[] dNSFromDHCPField;
        
        private IPAddress[] dNSManualField;
        
        private DNSInformationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool FromDHCP
        {
            get
            {
                return this.fromDHCPField;
            }
            set
            {
                this.fromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchDomain", DataType="token", Order=1)]
        public string[] SearchDomain
        {
            get
            {
                return this.searchDomainField;
            }
            set
            {
                this.searchDomainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DNSFromDHCP", Order=2)]
        public IPAddress[] DNSFromDHCP
        {
            get
            {
                return this.dNSFromDHCPField;
            }
            set
            {
                this.dNSFromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DNSManual", Order=3)]
        public IPAddress[] DNSManual
        {
            get
            {
                return this.dNSManualField;
            }
            set
            {
                this.dNSManualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public DNSInformationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class HostnameInformationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class HostnameInformation
    {
        
        private bool fromDHCPField;
        
        private string nameField;
        
        private HostnameInformationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool FromDHCP
        {
            get
            {
                return this.fromDHCPField;
            }
            set
            {
                this.fromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public HostnameInformationExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class CapabilitiesExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AnalyticsDeviceExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AnalyticsDeviceCapabilities
    {
        
        private string xAddrField;
        
        private bool ruleSupportField;
        
        private bool ruleSupportFieldSpecified;
        
        private AnalyticsDeviceExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool RuleSupport
        {
            get
            {
                return this.ruleSupportField;
            }
            set
            {
                this.ruleSupportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuleSupportSpecified
        {
            get
            {
                return this.ruleSupportFieldSpecified;
            }
            set
            {
                this.ruleSupportFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public AnalyticsDeviceExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ReceiverCapabilities
    {
        
        private string xAddrField;
        
        private bool rTP_MulticastField;
        
        private bool rTP_TCPField;
        
        private bool rTP_RTSP_TCPField;
        
        private int supportedReceiversField;
        
        private int maximumRTSPURILengthField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool RTP_Multicast
        {
            get
            {
                return this.rTP_MulticastField;
            }
            set
            {
                this.rTP_MulticastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool RTP_TCP
        {
            get
            {
                return this.rTP_TCPField;
            }
            set
            {
                this.rTP_TCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool RTP_RTSP_TCP
        {
            get
            {
                return this.rTP_RTSP_TCPField;
            }
            set
            {
                this.rTP_RTSP_TCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int SupportedReceivers
        {
            get
            {
                return this.supportedReceiversField;
            }
            set
            {
                this.supportedReceiversField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int MaximumRTSPURILength
        {
            get
            {
                return this.maximumRTSPURILengthField;
            }
            set
            {
                this.maximumRTSPURILengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=6)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ReplayCapabilities
    {
        
        private string xAddrField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SearchCapabilities
    {
        
        private string xAddrField;
        
        private bool metadataSearchField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool MetadataSearch
        {
            get
            {
                return this.metadataSearchField;
            }
            set
            {
                this.metadataSearchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class RecordingCapabilities
    {
        
        private string xAddrField;
        
        private bool receiverSourceField;
        
        private bool mediaProfileSourceField;
        
        private bool dynamicRecordingsField;
        
        private bool dynamicTracksField;
        
        private int maxStringLengthField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool ReceiverSource
        {
            get
            {
                return this.receiverSourceField;
            }
            set
            {
                this.receiverSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool MediaProfileSource
        {
            get
            {
                return this.mediaProfileSourceField;
            }
            set
            {
                this.mediaProfileSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool DynamicRecordings
        {
            get
            {
                return this.dynamicRecordingsField;
            }
            set
            {
                this.dynamicRecordingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool DynamicTracks
        {
            get
            {
                return this.dynamicTracksField;
            }
            set
            {
                this.dynamicTracksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int MaxStringLength
        {
            get
            {
                return this.maxStringLengthField;
            }
            set
            {
                this.maxStringLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=6)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DisplayCapabilities
    {
        
        private string xAddrField;
        
        private bool fixedLayoutField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool FixedLayout
        {
            get
            {
                return this.fixedLayoutField;
            }
            set
            {
                this.fixedLayoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DeviceIOCapabilities
    {
        
        private string xAddrField;
        
        private int videoSourcesField;
        
        private int videoOutputsField;
        
        private int audioSourcesField;
        
        private int audioOutputsField;
        
        private int relayOutputsField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int VideoSources
        {
            get
            {
                return this.videoSourcesField;
            }
            set
            {
                this.videoSourcesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int VideoOutputs
        {
            get
            {
                return this.videoOutputsField;
            }
            set
            {
                this.videoOutputsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int AudioSources
        {
            get
            {
                return this.audioSourcesField;
            }
            set
            {
                this.audioSourcesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int AudioOutputs
        {
            get
            {
                return this.audioOutputsField;
            }
            set
            {
                this.audioOutputsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int RelayOutputs
        {
            get
            {
                return this.relayOutputsField;
            }
            set
            {
                this.relayOutputsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=6)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class CapabilitiesExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private DeviceIOCapabilities deviceIOField;
        
        private DisplayCapabilities displayField;
        
        private RecordingCapabilities recordingField;
        
        private SearchCapabilities searchField;
        
        private ReplayCapabilities replayField;
        
        private ReceiverCapabilities receiverField;
        
        private AnalyticsDeviceCapabilities analyticsDeviceField;
        
        private CapabilitiesExtension2 extensionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DeviceIOCapabilities DeviceIO
        {
            get
            {
                return this.deviceIOField;
            }
            set
            {
                this.deviceIOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DisplayCapabilities Display
        {
            get
            {
                return this.displayField;
            }
            set
            {
                this.displayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public RecordingCapabilities Recording
        {
            get
            {
                return this.recordingField;
            }
            set
            {
                this.recordingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public SearchCapabilities Search
        {
            get
            {
                return this.searchField;
            }
            set
            {
                this.searchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ReplayCapabilities Replay
        {
            get
            {
                return this.replayField;
            }
            set
            {
                this.replayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public ReceiverCapabilities Receiver
        {
            get
            {
                return this.receiverField;
            }
            set
            {
                this.receiverField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public AnalyticsDeviceCapabilities AnalyticsDevice
        {
            get
            {
                return this.analyticsDeviceField;
            }
            set
            {
                this.analyticsDeviceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public CapabilitiesExtension2 Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZCapabilities
    {
        
        private string xAddrField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ProfileCapabilities
    {
        
        private int maximumNumberOfProfilesField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int MaximumNumberOfProfiles
        {
            get
            {
                return this.maximumNumberOfProfilesField;
            }
            set
            {
                this.maximumNumberOfProfilesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class MediaCapabilitiesExtension
    {
        
        private ProfileCapabilities profileCapabilitiesField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ProfileCapabilities ProfileCapabilities
        {
            get
            {
                return this.profileCapabilitiesField;
            }
            set
            {
                this.profileCapabilitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=1)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class RealTimeStreamingCapabilitiesExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class RealTimeStreamingCapabilities
    {
        
        private bool rTPMulticastField;
        
        private bool rTPMulticastFieldSpecified;
        
        private bool rTP_TCPField;
        
        private bool rTP_TCPFieldSpecified;
        
        private bool rTP_RTSP_TCPField;
        
        private bool rTP_RTSP_TCPFieldSpecified;
        
        private RealTimeStreamingCapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool RTPMulticast
        {
            get
            {
                return this.rTPMulticastField;
            }
            set
            {
                this.rTPMulticastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RTPMulticastSpecified
        {
            get
            {
                return this.rTPMulticastFieldSpecified;
            }
            set
            {
                this.rTPMulticastFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool RTP_TCP
        {
            get
            {
                return this.rTP_TCPField;
            }
            set
            {
                this.rTP_TCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RTP_TCPSpecified
        {
            get
            {
                return this.rTP_TCPFieldSpecified;
            }
            set
            {
                this.rTP_TCPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool RTP_RTSP_TCP
        {
            get
            {
                return this.rTP_RTSP_TCPField;
            }
            set
            {
                this.rTP_RTSP_TCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RTP_RTSP_TCPSpecified
        {
            get
            {
                return this.rTP_RTSP_TCPFieldSpecified;
            }
            set
            {
                this.rTP_RTSP_TCPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public RealTimeStreamingCapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class MediaCapabilities
    {
        
        private string xAddrField;
        
        private RealTimeStreamingCapabilities streamingCapabilitiesField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private MediaCapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public RealTimeStreamingCapabilities StreamingCapabilities
        {
            get
            {
                return this.streamingCapabilitiesField;
            }
            set
            {
                this.streamingCapabilitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=2)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MediaCapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ImagingCapabilities
    {
        
        private string xAddrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class EventCapabilities
    {
        
        private string xAddrField;
        
        private bool wSSubscriptionPolicySupportField;
        
        private bool wSPullPointSupportField;
        
        private bool wSPausableSubscriptionManagerInterfaceSupportField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool WSSubscriptionPolicySupport
        {
            get
            {
                return this.wSSubscriptionPolicySupportField;
            }
            set
            {
                this.wSSubscriptionPolicySupportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool WSPullPointSupport
        {
            get
            {
                return this.wSPullPointSupportField;
            }
            set
            {
                this.wSPullPointSupportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool WSPausableSubscriptionManagerInterfaceSupport
        {
            get
            {
                return this.wSPausableSubscriptionManagerInterfaceSupportField;
            }
            set
            {
                this.wSPausableSubscriptionManagerInterfaceSupportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=4)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DeviceCapabilitiesExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SecurityCapabilitiesExtension2
    {
        
        private bool dot1XField;
        
        private int[] supportedEAPMethodField;
        
        private bool remoteUserHandlingField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Dot1X
        {
            get
            {
                return this.dot1XField;
            }
            set
            {
                this.dot1XField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedEAPMethod", Order=1)]
        public int[] SupportedEAPMethod
        {
            get
            {
                return this.supportedEAPMethodField;
            }
            set
            {
                this.supportedEAPMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool RemoteUserHandling
        {
            get
            {
                return this.remoteUserHandlingField;
            }
            set
            {
                this.remoteUserHandlingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=3)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SecurityCapabilitiesExtension
    {
        
        private bool tLS10Field;
        
        private SecurityCapabilitiesExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TLS1.0", Order=0)]
        public bool TLS10
        {
            get
            {
                return this.tLS10Field;
            }
            set
            {
                this.tLS10Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SecurityCapabilitiesExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="SecurityCapabilities", Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SecurityCapabilities1
    {
        
        private bool tLS11Field;
        
        private bool tLS12Field;
        
        private bool onboardKeyGenerationField;
        
        private bool accessPolicyConfigField;
        
        private bool x509TokenField;
        
        private bool sAMLTokenField;
        
        private bool kerberosTokenField;
        
        private bool rELTokenField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private SecurityCapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TLS1.1", Order=0)]
        public bool TLS11
        {
            get
            {
                return this.tLS11Field;
            }
            set
            {
                this.tLS11Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TLS1.2", Order=1)]
        public bool TLS12
        {
            get
            {
                return this.tLS12Field;
            }
            set
            {
                this.tLS12Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool OnboardKeyGeneration
        {
            get
            {
                return this.onboardKeyGenerationField;
            }
            set
            {
                this.onboardKeyGenerationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool AccessPolicyConfig
        {
            get
            {
                return this.accessPolicyConfigField;
            }
            set
            {
                this.accessPolicyConfigField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("X.509Token", Order=4)]
        public bool X509Token
        {
            get
            {
                return this.x509TokenField;
            }
            set
            {
                this.x509TokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool SAMLToken
        {
            get
            {
                return this.sAMLTokenField;
            }
            set
            {
                this.sAMLTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool KerberosToken
        {
            get
            {
                return this.kerberosTokenField;
            }
            set
            {
                this.kerberosTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool RELToken
        {
            get
            {
                return this.rELTokenField;
            }
            set
            {
                this.rELTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=8)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public SecurityCapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IOCapabilitiesExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IOCapabilitiesExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private bool auxiliaryField;
        
        private bool auxiliaryFieldSpecified;
        
        private string[] auxiliaryCommandsField;
        
        private IOCapabilitiesExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool Auxiliary
        {
            get
            {
                return this.auxiliaryField;
            }
            set
            {
                this.auxiliaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AuxiliarySpecified
        {
            get
            {
                return this.auxiliaryFieldSpecified;
            }
            set
            {
                this.auxiliaryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuxiliaryCommands", Order=2)]
        public string[] AuxiliaryCommands
        {
            get
            {
                return this.auxiliaryCommandsField;
            }
            set
            {
                this.auxiliaryCommandsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IOCapabilitiesExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IOCapabilities
    {
        
        private int inputConnectorsField;
        
        private bool inputConnectorsFieldSpecified;
        
        private int relayOutputsField;
        
        private bool relayOutputsFieldSpecified;
        
        private IOCapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int InputConnectors
        {
            get
            {
                return this.inputConnectorsField;
            }
            set
            {
                this.inputConnectorsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InputConnectorsSpecified
        {
            get
            {
                return this.inputConnectorsFieldSpecified;
            }
            set
            {
                this.inputConnectorsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int RelayOutputs
        {
            get
            {
                return this.relayOutputsField;
            }
            set
            {
                this.relayOutputsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelayOutputsSpecified
        {
            get
            {
                return this.relayOutputsFieldSpecified;
            }
            set
            {
                this.relayOutputsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public IOCapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SystemCapabilitiesExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SystemCapabilitiesExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private bool httpFirmwareUpgradeField;
        
        private bool httpFirmwareUpgradeFieldSpecified;
        
        private bool httpSystemBackupField;
        
        private bool httpSystemBackupFieldSpecified;
        
        private bool httpSystemLoggingField;
        
        private bool httpSystemLoggingFieldSpecified;
        
        private bool httpSupportInformationField;
        
        private bool httpSupportInformationFieldSpecified;
        
        private SystemCapabilitiesExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool HttpFirmwareUpgrade
        {
            get
            {
                return this.httpFirmwareUpgradeField;
            }
            set
            {
                this.httpFirmwareUpgradeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpFirmwareUpgradeSpecified
        {
            get
            {
                return this.httpFirmwareUpgradeFieldSpecified;
            }
            set
            {
                this.httpFirmwareUpgradeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool HttpSystemBackup
        {
            get
            {
                return this.httpSystemBackupField;
            }
            set
            {
                this.httpSystemBackupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpSystemBackupSpecified
        {
            get
            {
                return this.httpSystemBackupFieldSpecified;
            }
            set
            {
                this.httpSystemBackupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool HttpSystemLogging
        {
            get
            {
                return this.httpSystemLoggingField;
            }
            set
            {
                this.httpSystemLoggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpSystemLoggingSpecified
        {
            get
            {
                return this.httpSystemLoggingFieldSpecified;
            }
            set
            {
                this.httpSystemLoggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool HttpSupportInformation
        {
            get
            {
                return this.httpSupportInformationField;
            }
            set
            {
                this.httpSupportInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpSupportInformationSpecified
        {
            get
            {
                return this.httpSupportInformationFieldSpecified;
            }
            set
            {
                this.httpSupportInformationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public SystemCapabilitiesExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="SystemCapabilities", Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SystemCapabilities1
    {
        
        private bool discoveryResolveField;
        
        private bool discoveryByeField;
        
        private bool remoteDiscoveryField;
        
        private bool systemBackupField;
        
        private bool systemLoggingField;
        
        private bool firmwareUpgradeField;
        
        private OnvifVersion[] supportedVersionsField;
        
        private SystemCapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool DiscoveryResolve
        {
            get
            {
                return this.discoveryResolveField;
            }
            set
            {
                this.discoveryResolveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool DiscoveryBye
        {
            get
            {
                return this.discoveryByeField;
            }
            set
            {
                this.discoveryByeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool RemoteDiscovery
        {
            get
            {
                return this.remoteDiscoveryField;
            }
            set
            {
                this.remoteDiscoveryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool SystemBackup
        {
            get
            {
                return this.systemBackupField;
            }
            set
            {
                this.systemBackupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool SystemLogging
        {
            get
            {
                return this.systemLoggingField;
            }
            set
            {
                this.systemLoggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool FirmwareUpgrade
        {
            get
            {
                return this.firmwareUpgradeField;
            }
            set
            {
                this.firmwareUpgradeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedVersions", Order=6)]
        public OnvifVersion[] SupportedVersions
        {
            get
            {
                return this.supportedVersionsField;
            }
            set
            {
                this.supportedVersionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public SystemCapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkCapabilitiesExtension2
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkCapabilitiesExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private bool dot11ConfigurationField;
        
        private bool dot11ConfigurationFieldSpecified;
        
        private NetworkCapabilitiesExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool Dot11Configuration
        {
            get
            {
                return this.dot11ConfigurationField;
            }
            set
            {
                this.dot11ConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Dot11ConfigurationSpecified
        {
            get
            {
                return this.dot11ConfigurationFieldSpecified;
            }
            set
            {
                this.dot11ConfigurationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public NetworkCapabilitiesExtension2 Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="NetworkCapabilities", Namespace="http://www.onvif.org/ver10/schema")]
    public partial class NetworkCapabilities1
    {
        
        private bool iPFilterField;
        
        private bool iPFilterFieldSpecified;
        
        private bool zeroConfigurationField;
        
        private bool zeroConfigurationFieldSpecified;
        
        private bool iPVersion6Field;
        
        private bool iPVersion6FieldSpecified;
        
        private bool dynDNSField;
        
        private bool dynDNSFieldSpecified;
        
        private NetworkCapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool IPFilter
        {
            get
            {
                return this.iPFilterField;
            }
            set
            {
                this.iPFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IPFilterSpecified
        {
            get
            {
                return this.iPFilterFieldSpecified;
            }
            set
            {
                this.iPFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool ZeroConfiguration
        {
            get
            {
                return this.zeroConfigurationField;
            }
            set
            {
                this.zeroConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZeroConfigurationSpecified
        {
            get
            {
                return this.zeroConfigurationFieldSpecified;
            }
            set
            {
                this.zeroConfigurationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IPVersion6
        {
            get
            {
                return this.iPVersion6Field;
            }
            set
            {
                this.iPVersion6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IPVersion6Specified
        {
            get
            {
                return this.iPVersion6FieldSpecified;
            }
            set
            {
                this.iPVersion6FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool DynDNS
        {
            get
            {
                return this.dynDNSField;
            }
            set
            {
                this.dynDNSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DynDNSSpecified
        {
            get
            {
                return this.dynDNSFieldSpecified;
            }
            set
            {
                this.dynDNSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public NetworkCapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DeviceCapabilities
    {
        
        private string xAddrField;
        
        private NetworkCapabilities1 networkField;
        
        private SystemCapabilities1 systemField;
        
        private IOCapabilities ioField;
        
        private SecurityCapabilities1 securityField;
        
        private DeviceCapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public NetworkCapabilities1 Network
        {
            get
            {
                return this.networkField;
            }
            set
            {
                this.networkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SystemCapabilities1 System
        {
            get
            {
                return this.systemField;
            }
            set
            {
                this.systemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IOCapabilities IO
        {
            get
            {
                return this.ioField;
            }
            set
            {
                this.ioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public SecurityCapabilities1 Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public DeviceCapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AnalyticsCapabilities
    {
        
        private string xAddrField;
        
        private bool ruleSupportField;
        
        private bool analyticsModuleSupportField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool RuleSupport
        {
            get
            {
                return this.ruleSupportField;
            }
            set
            {
                this.ruleSupportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool AnalyticsModuleSupport
        {
            get
            {
                return this.analyticsModuleSupportField;
            }
            set
            {
                this.analyticsModuleSupportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=3)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Capabilities
    {
        
        private AnalyticsCapabilities analyticsField;
        
        private DeviceCapabilities deviceField;
        
        private EventCapabilities eventsField;
        
        private ImagingCapabilities imagingField;
        
        private MediaCapabilities mediaField;
        
        private PTZCapabilities pTZField;
        
        private CapabilitiesExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AnalyticsCapabilities Analytics
        {
            get
            {
                return this.analyticsField;
            }
            set
            {
                this.analyticsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DeviceCapabilities Device
        {
            get
            {
                return this.deviceField;
            }
            set
            {
                this.deviceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public EventCapabilities Events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ImagingCapabilities Imaging
        {
            get
            {
                return this.imagingField;
            }
            set
            {
                this.imagingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public MediaCapabilities Media
        {
            get
            {
                return this.mediaField;
            }
            set
            {
                this.mediaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public PTZCapabilities PTZ
        {
            get
            {
                return this.pTZField;
            }
            set
            {
                this.pTZField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public CapabilitiesExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class UserExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class User
    {
        
        private string usernameField;
        
        private string passwordField;
        
        private UserLevel userLevelField;
        
        private UserExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public UserLevel UserLevel
        {
            get
            {
                return this.userLevelField;
            }
            set
            {
                this.userLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public UserExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum UserLevel
    {
        
        /// <remarks/>
        Administrator,
        
        /// <remarks/>
        Operator,
        
        /// <remarks/>
        User,
        
        /// <remarks/>
        Anonymous,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class RemoteUser
    {
        
        private string usernameField;
        
        private string passwordField;
        
        private bool useDerivedPasswordField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool UseDerivedPassword
        {
            get
            {
                return this.useDerivedPasswordField;
            }
            set
            {
                this.useDerivedPasswordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=3)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Scope
    {
        
        private ScopeDefinition scopeDefField;
        
        private string scopeItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ScopeDefinition ScopeDef
        {
            get
            {
                return this.scopeDefField;
            }
            set
            {
                this.scopeDefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string ScopeItem
        {
            get
            {
                return this.scopeItemField;
            }
            set
            {
                this.scopeItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum ScopeDefinition
    {
        
        /// <remarks/>
        Fixed,
        
        /// <remarks/>
        Configurable,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SupportInformation
    {
        
        private AttachmentData binaryField;
        
        private string stringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AttachmentData Binary
        {
            get
            {
                return this.binaryField;
            }
            set
            {
                this.binaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string String
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AttachmentData
    {
        
        private Include includeField;
        
        private string contentTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2004/08/xop/include", Order=0)]
        public Include Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/2005/05/xmlmime")]
        public string contentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2004/08/xop/include")]
    public partial class Include
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private string hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SystemLog
    {
        
        private AttachmentData binaryField;
        
        private string stringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AttachmentData Binary
        {
            get
            {
                return this.binaryField;
            }
            set
            {
                this.binaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string String
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class BackupFile
    {
        
        private string nameField;
        
        private AttachmentData dataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AttachmentData Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SystemDateTimeExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class SystemDateTime
    {
        
        private SetDateTimeType dateTimeTypeField;
        
        private bool daylightSavingsField;
        
        private TimeZone timeZoneField;
        
        private DateTime uTCDateTimeField;
        
        private DateTime localDateTimeField;
        
        private SystemDateTimeExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SetDateTimeType DateTimeType
        {
            get
            {
                return this.dateTimeTypeField;
            }
            set
            {
                this.dateTimeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool DaylightSavings
        {
            get
            {
                return this.daylightSavingsField;
            }
            set
            {
                this.daylightSavingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public TimeZone TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public DateTime UTCDateTime
        {
            get
            {
                return this.uTCDateTimeField;
            }
            set
            {
                this.uTCDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public DateTime LocalDateTime
        {
            get
            {
                return this.localDateTimeField;
            }
            set
            {
                this.localDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public SystemDateTimeExtension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum SetDateTimeType
    {
        
        /// <remarks/>
        Manual,
        
        /// <remarks/>
        NTP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class TimeZone
    {
        
        private string tzField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string TZ
        {
            get
            {
                return this.tzField;
            }
            set
            {
                this.tzField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class DateTime
    {
        
        private Time timeField;
        
        private Date dateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Time Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Date Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Time
    {
        
        private int hourField;
        
        private int minuteField;
        
        private int secondField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Date
    {
        
        private int yearField;
        
        private int monthField;
        
        private int dayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class MiscCapabilities
    {
        
        private string[] auxiliaryCommandsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] AuxiliaryCommands
        {
            get
            {
                return this.auxiliaryCommandsField;
            }
            set
            {
                this.auxiliaryCommandsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class SystemCapabilities
    {
        
        private bool discoveryResolveField;
        
        private bool discoveryResolveFieldSpecified;
        
        private bool discoveryByeField;
        
        private bool discoveryByeFieldSpecified;
        
        private bool remoteDiscoveryField;
        
        private bool remoteDiscoveryFieldSpecified;
        
        private bool systemBackupField;
        
        private bool systemBackupFieldSpecified;
        
        private bool systemLoggingField;
        
        private bool systemLoggingFieldSpecified;
        
        private bool firmwareUpgradeField;
        
        private bool firmwareUpgradeFieldSpecified;
        
        private bool httpFirmwareUpgradeField;
        
        private bool httpFirmwareUpgradeFieldSpecified;
        
        private bool httpSystemBackupField;
        
        private bool httpSystemBackupFieldSpecified;
        
        private bool httpSystemLoggingField;
        
        private bool httpSystemLoggingFieldSpecified;
        
        private bool httpSupportInformationField;
        
        private bool httpSupportInformationFieldSpecified;
        
        private bool storageConfigurationField;
        
        private bool storageConfigurationFieldSpecified;
        
        private int maxStorageConfigurationsField;
        
        private bool maxStorageConfigurationsFieldSpecified;
        
        private int geoLocationEntriesField;
        
        private bool geoLocationEntriesFieldSpecified;
        
        private string[] autoGeoField;
        
        private string[] storageTypesSupportedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DiscoveryResolve
        {
            get
            {
                return this.discoveryResolveField;
            }
            set
            {
                this.discoveryResolveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscoveryResolveSpecified
        {
            get
            {
                return this.discoveryResolveFieldSpecified;
            }
            set
            {
                this.discoveryResolveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DiscoveryBye
        {
            get
            {
                return this.discoveryByeField;
            }
            set
            {
                this.discoveryByeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscoveryByeSpecified
        {
            get
            {
                return this.discoveryByeFieldSpecified;
            }
            set
            {
                this.discoveryByeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RemoteDiscovery
        {
            get
            {
                return this.remoteDiscoveryField;
            }
            set
            {
                this.remoteDiscoveryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemoteDiscoverySpecified
        {
            get
            {
                return this.remoteDiscoveryFieldSpecified;
            }
            set
            {
                this.remoteDiscoveryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SystemBackup
        {
            get
            {
                return this.systemBackupField;
            }
            set
            {
                this.systemBackupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SystemBackupSpecified
        {
            get
            {
                return this.systemBackupFieldSpecified;
            }
            set
            {
                this.systemBackupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SystemLogging
        {
            get
            {
                return this.systemLoggingField;
            }
            set
            {
                this.systemLoggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SystemLoggingSpecified
        {
            get
            {
                return this.systemLoggingFieldSpecified;
            }
            set
            {
                this.systemLoggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FirmwareUpgrade
        {
            get
            {
                return this.firmwareUpgradeField;
            }
            set
            {
                this.firmwareUpgradeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FirmwareUpgradeSpecified
        {
            get
            {
                return this.firmwareUpgradeFieldSpecified;
            }
            set
            {
                this.firmwareUpgradeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HttpFirmwareUpgrade
        {
            get
            {
                return this.httpFirmwareUpgradeField;
            }
            set
            {
                this.httpFirmwareUpgradeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpFirmwareUpgradeSpecified
        {
            get
            {
                return this.httpFirmwareUpgradeFieldSpecified;
            }
            set
            {
                this.httpFirmwareUpgradeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HttpSystemBackup
        {
            get
            {
                return this.httpSystemBackupField;
            }
            set
            {
                this.httpSystemBackupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpSystemBackupSpecified
        {
            get
            {
                return this.httpSystemBackupFieldSpecified;
            }
            set
            {
                this.httpSystemBackupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HttpSystemLogging
        {
            get
            {
                return this.httpSystemLoggingField;
            }
            set
            {
                this.httpSystemLoggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpSystemLoggingSpecified
        {
            get
            {
                return this.httpSystemLoggingFieldSpecified;
            }
            set
            {
                this.httpSystemLoggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HttpSupportInformation
        {
            get
            {
                return this.httpSupportInformationField;
            }
            set
            {
                this.httpSupportInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpSupportInformationSpecified
        {
            get
            {
                return this.httpSupportInformationFieldSpecified;
            }
            set
            {
                this.httpSupportInformationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool StorageConfiguration
        {
            get
            {
                return this.storageConfigurationField;
            }
            set
            {
                this.storageConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StorageConfigurationSpecified
        {
            get
            {
                return this.storageConfigurationFieldSpecified;
            }
            set
            {
                this.storageConfigurationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxStorageConfigurations
        {
            get
            {
                return this.maxStorageConfigurationsField;
            }
            set
            {
                this.maxStorageConfigurationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxStorageConfigurationsSpecified
        {
            get
            {
                return this.maxStorageConfigurationsFieldSpecified;
            }
            set
            {
                this.maxStorageConfigurationsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int GeoLocationEntries
        {
            get
            {
                return this.geoLocationEntriesField;
            }
            set
            {
                this.geoLocationEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GeoLocationEntriesSpecified
        {
            get
            {
                return this.geoLocationEntriesFieldSpecified;
            }
            set
            {
                this.geoLocationEntriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] AutoGeo
        {
            get
            {
                return this.autoGeoField;
            }
            set
            {
                this.autoGeoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] StorageTypesSupported
        {
            get
            {
                return this.storageTypesSupportedField;
            }
            set
            {
                this.storageTypesSupportedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class SecurityCapabilities
    {
        
        private bool tLS10Field;
        
        private bool tLS10FieldSpecified;
        
        private bool tLS11Field;
        
        private bool tLS11FieldSpecified;
        
        private bool tLS12Field;
        
        private bool tLS12FieldSpecified;
        
        private bool onboardKeyGenerationField;
        
        private bool onboardKeyGenerationFieldSpecified;
        
        private bool accessPolicyConfigField;
        
        private bool accessPolicyConfigFieldSpecified;
        
        private bool defaultAccessPolicyField;
        
        private bool defaultAccessPolicyFieldSpecified;
        
        private bool dot1XField;
        
        private bool dot1XFieldSpecified;
        
        private bool remoteUserHandlingField;
        
        private bool remoteUserHandlingFieldSpecified;
        
        private bool x509TokenField;
        
        private bool x509TokenFieldSpecified;
        
        private bool sAMLTokenField;
        
        private bool sAMLTokenFieldSpecified;
        
        private bool kerberosTokenField;
        
        private bool kerberosTokenFieldSpecified;
        
        private bool usernameTokenField;
        
        private bool usernameTokenFieldSpecified;
        
        private bool httpDigestField;
        
        private bool httpDigestFieldSpecified;
        
        private bool rELTokenField;
        
        private bool rELTokenFieldSpecified;
        
        private int[] supportedEAPMethodsField;
        
        private int maxUsersField;
        
        private bool maxUsersFieldSpecified;
        
        private int maxUserNameLengthField;
        
        private bool maxUserNameLengthFieldSpecified;
        
        private int maxPasswordLengthField;
        
        private bool maxPasswordLengthFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("TLS1.0")]
        public bool TLS10
        {
            get
            {
                return this.tLS10Field;
            }
            set
            {
                this.tLS10Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TLS10Specified
        {
            get
            {
                return this.tLS10FieldSpecified;
            }
            set
            {
                this.tLS10FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("TLS1.1")]
        public bool TLS11
        {
            get
            {
                return this.tLS11Field;
            }
            set
            {
                this.tLS11Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TLS11Specified
        {
            get
            {
                return this.tLS11FieldSpecified;
            }
            set
            {
                this.tLS11FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("TLS1.2")]
        public bool TLS12
        {
            get
            {
                return this.tLS12Field;
            }
            set
            {
                this.tLS12Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TLS12Specified
        {
            get
            {
                return this.tLS12FieldSpecified;
            }
            set
            {
                this.tLS12FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OnboardKeyGeneration
        {
            get
            {
                return this.onboardKeyGenerationField;
            }
            set
            {
                this.onboardKeyGenerationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnboardKeyGenerationSpecified
        {
            get
            {
                return this.onboardKeyGenerationFieldSpecified;
            }
            set
            {
                this.onboardKeyGenerationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AccessPolicyConfig
        {
            get
            {
                return this.accessPolicyConfigField;
            }
            set
            {
                this.accessPolicyConfigField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessPolicyConfigSpecified
        {
            get
            {
                return this.accessPolicyConfigFieldSpecified;
            }
            set
            {
                this.accessPolicyConfigFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DefaultAccessPolicy
        {
            get
            {
                return this.defaultAccessPolicyField;
            }
            set
            {
                this.defaultAccessPolicyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultAccessPolicySpecified
        {
            get
            {
                return this.defaultAccessPolicyFieldSpecified;
            }
            set
            {
                this.defaultAccessPolicyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Dot1X
        {
            get
            {
                return this.dot1XField;
            }
            set
            {
                this.dot1XField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Dot1XSpecified
        {
            get
            {
                return this.dot1XFieldSpecified;
            }
            set
            {
                this.dot1XFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RemoteUserHandling
        {
            get
            {
                return this.remoteUserHandlingField;
            }
            set
            {
                this.remoteUserHandlingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemoteUserHandlingSpecified
        {
            get
            {
                return this.remoteUserHandlingFieldSpecified;
            }
            set
            {
                this.remoteUserHandlingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("X.509Token")]
        public bool X509Token
        {
            get
            {
                return this.x509TokenField;
            }
            set
            {
                this.x509TokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool X509TokenSpecified
        {
            get
            {
                return this.x509TokenFieldSpecified;
            }
            set
            {
                this.x509TokenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SAMLToken
        {
            get
            {
                return this.sAMLTokenField;
            }
            set
            {
                this.sAMLTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SAMLTokenSpecified
        {
            get
            {
                return this.sAMLTokenFieldSpecified;
            }
            set
            {
                this.sAMLTokenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool KerberosToken
        {
            get
            {
                return this.kerberosTokenField;
            }
            set
            {
                this.kerberosTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KerberosTokenSpecified
        {
            get
            {
                return this.kerberosTokenFieldSpecified;
            }
            set
            {
                this.kerberosTokenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool UsernameToken
        {
            get
            {
                return this.usernameTokenField;
            }
            set
            {
                this.usernameTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UsernameTokenSpecified
        {
            get
            {
                return this.usernameTokenFieldSpecified;
            }
            set
            {
                this.usernameTokenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HttpDigest
        {
            get
            {
                return this.httpDigestField;
            }
            set
            {
                this.httpDigestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HttpDigestSpecified
        {
            get
            {
                return this.httpDigestFieldSpecified;
            }
            set
            {
                this.httpDigestFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RELToken
        {
            get
            {
                return this.rELTokenField;
            }
            set
            {
                this.rELTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RELTokenSpecified
        {
            get
            {
                return this.rELTokenFieldSpecified;
            }
            set
            {
                this.rELTokenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int[] SupportedEAPMethods
        {
            get
            {
                return this.supportedEAPMethodsField;
            }
            set
            {
                this.supportedEAPMethodsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxUsers
        {
            get
            {
                return this.maxUsersField;
            }
            set
            {
                this.maxUsersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxUsersSpecified
        {
            get
            {
                return this.maxUsersFieldSpecified;
            }
            set
            {
                this.maxUsersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxUserNameLength
        {
            get
            {
                return this.maxUserNameLengthField;
            }
            set
            {
                this.maxUserNameLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxUserNameLengthSpecified
        {
            get
            {
                return this.maxUserNameLengthFieldSpecified;
            }
            set
            {
                this.maxUserNameLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxPasswordLength
        {
            get
            {
                return this.maxPasswordLengthField;
            }
            set
            {
                this.maxPasswordLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxPasswordLengthSpecified
        {
            get
            {
                return this.maxPasswordLengthFieldSpecified;
            }
            set
            {
                this.maxPasswordLengthFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class NetworkCapabilities
    {
        
        private bool iPFilterField;
        
        private bool iPFilterFieldSpecified;
        
        private bool zeroConfigurationField;
        
        private bool zeroConfigurationFieldSpecified;
        
        private bool iPVersion6Field;
        
        private bool iPVersion6FieldSpecified;
        
        private bool dynDNSField;
        
        private bool dynDNSFieldSpecified;
        
        private bool dot11ConfigurationField;
        
        private bool dot11ConfigurationFieldSpecified;
        
        private int dot1XConfigurationsField;
        
        private bool dot1XConfigurationsFieldSpecified;
        
        private bool hostnameFromDHCPField;
        
        private bool hostnameFromDHCPFieldSpecified;
        
        private int nTPField;
        
        private bool nTPFieldSpecified;
        
        private bool dHCPv6Field;
        
        private bool dHCPv6FieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IPFilter
        {
            get
            {
                return this.iPFilterField;
            }
            set
            {
                this.iPFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IPFilterSpecified
        {
            get
            {
                return this.iPFilterFieldSpecified;
            }
            set
            {
                this.iPFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ZeroConfiguration
        {
            get
            {
                return this.zeroConfigurationField;
            }
            set
            {
                this.zeroConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZeroConfigurationSpecified
        {
            get
            {
                return this.zeroConfigurationFieldSpecified;
            }
            set
            {
                this.zeroConfigurationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IPVersion6
        {
            get
            {
                return this.iPVersion6Field;
            }
            set
            {
                this.iPVersion6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IPVersion6Specified
        {
            get
            {
                return this.iPVersion6FieldSpecified;
            }
            set
            {
                this.iPVersion6FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DynDNS
        {
            get
            {
                return this.dynDNSField;
            }
            set
            {
                this.dynDNSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DynDNSSpecified
        {
            get
            {
                return this.dynDNSFieldSpecified;
            }
            set
            {
                this.dynDNSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Dot11Configuration
        {
            get
            {
                return this.dot11ConfigurationField;
            }
            set
            {
                this.dot11ConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Dot11ConfigurationSpecified
        {
            get
            {
                return this.dot11ConfigurationFieldSpecified;
            }
            set
            {
                this.dot11ConfigurationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Dot1XConfigurations
        {
            get
            {
                return this.dot1XConfigurationsField;
            }
            set
            {
                this.dot1XConfigurationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Dot1XConfigurationsSpecified
        {
            get
            {
                return this.dot1XConfigurationsFieldSpecified;
            }
            set
            {
                this.dot1XConfigurationsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HostnameFromDHCP
        {
            get
            {
                return this.hostnameFromDHCPField;
            }
            set
            {
                this.hostnameFromDHCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HostnameFromDHCPSpecified
        {
            get
            {
                return this.hostnameFromDHCPFieldSpecified;
            }
            set
            {
                this.hostnameFromDHCPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NTP
        {
            get
            {
                return this.nTPField;
            }
            set
            {
                this.nTPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NTPSpecified
        {
            get
            {
                return this.nTPFieldSpecified;
            }
            set
            {
                this.nTPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DHCPv6
        {
            get
            {
                return this.dHCPv6Field;
            }
            set
            {
                this.dHCPv6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DHCPv6Specified
        {
            get
            {
                return this.dHCPv6FieldSpecified;
            }
            set
            {
                this.dHCPv6FieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class DeviceServiceCapabilities
    {
        
        private NetworkCapabilities networkField;
        
        private SecurityCapabilities securityField;
        
        private SystemCapabilities systemField;
        
        private MiscCapabilities miscField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NetworkCapabilities Network
        {
            get
            {
                return this.networkField;
            }
            set
            {
                this.networkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SecurityCapabilities Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SystemCapabilities System
        {
            get
            {
                return this.systemField;
            }
            set
            {
                this.systemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MiscCapabilities Misc
        {
            get
            {
                return this.miscField;
            }
            set
            {
                this.miscField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetServices", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetServicesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public bool IncludeCapability;
        
        public GetServicesRequest()
        {
        }
        
        public GetServicesRequest(bool IncludeCapability)
        {
            this.IncludeCapability = IncludeCapability;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetServicesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetServicesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Service")]
        public CameraManagementService.Service[] Service;
        
        public GetServicesResponse()
        {
        }
        
        public GetServicesResponse(CameraManagementService.Service[] Service)
        {
            this.Service = Service;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDeviceInformation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDeviceInformationRequest
    {
        
        public GetDeviceInformationRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDeviceInformationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDeviceInformationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public string Manufacturer;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        public string FirmwareVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=3)]
        public string SerialNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=4)]
        public string HardwareId;
        
        public GetDeviceInformationResponse()
        {
        }
        
        public GetDeviceInformationResponse(string Manufacturer, string Model, string FirmwareVersion, string SerialNumber, string HardwareId)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.FirmwareVersion = FirmwareVersion;
            this.SerialNumber = SerialNumber;
            this.HardwareId = HardwareId;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum FactoryDefaultType
    {
        
        /// <remarks/>
        Hard,
        
        /// <remarks/>
        Soft,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RestoreSystem", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RestoreSystemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("BackupFiles")]
        public CameraManagementService.BackupFile[] BackupFiles;
        
        public RestoreSystemRequest()
        {
        }
        
        public RestoreSystemRequest(CameraManagementService.BackupFile[] BackupFiles)
        {
            this.BackupFiles = BackupFiles;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RestoreSystemResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RestoreSystemResponse
    {
        
        public RestoreSystemResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemBackup", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemBackupRequest
    {
        
        public GetSystemBackupRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemBackupResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemBackupResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("BackupFiles")]
        public CameraManagementService.BackupFile[] BackupFiles;
        
        public GetSystemBackupResponse()
        {
        }
        
        public GetSystemBackupResponse(CameraManagementService.BackupFile[] BackupFiles)
        {
            this.BackupFiles = BackupFiles;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetScopesRequest
    {
        
        public GetScopesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetScopesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Scopes")]
        public CameraManagementService.Scope[] Scopes;
        
        public GetScopesResponse()
        {
        }
        
        public GetScopesResponse(CameraManagementService.Scope[] Scopes)
        {
            this.Scopes = Scopes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetScopesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Scopes", DataType="anyURI")]
        public string[] Scopes;
        
        public SetScopesRequest()
        {
        }
        
        public SetScopesRequest(string[] Scopes)
        {
            this.Scopes = Scopes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetScopesResponse
    {
        
        public SetScopesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class AddScopesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType="anyURI")]
        public string[] ScopeItem;
        
        public AddScopesRequest()
        {
        }
        
        public AddScopesRequest(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class AddScopesResponse
    {
        
        public AddScopesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoveScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RemoveScopesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType="anyURI")]
        public string[] ScopeItem;
        
        public RemoveScopesRequest()
        {
        }
        
        public RemoveScopesRequest(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoveScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RemoveScopesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType="anyURI")]
        public string[] ScopeItem;
        
        public RemoveScopesResponse()
        {
        }
        
        public RemoveScopesResponse(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum DiscoveryMode
    {
        
        /// <remarks/>
        Discoverable,
        
        /// <remarks/>
        NonDiscoverable,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDPAddresses", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDPAddressesRequest
    {
        
        public GetDPAddressesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDPAddressesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDPAddressesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DPAddress")]
        public CameraManagementService.NetworkHost[] DPAddress;
        
        public GetDPAddressesResponse()
        {
        }
        
        public GetDPAddressesResponse(CameraManagementService.NetworkHost[] DPAddress)
        {
            this.DPAddress = DPAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDPAddresses", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDPAddressesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DPAddress")]
        public CameraManagementService.NetworkHost[] DPAddress;
        
        public SetDPAddressesRequest()
        {
        }
        
        public SetDPAddressesRequest(CameraManagementService.NetworkHost[] DPAddress)
        {
            this.DPAddress = DPAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDPAddressesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDPAddressesResponse
    {
        
        public SetDPAddressesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEndpointReference", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetEndpointReferenceRequest
    {
        
        public GetEndpointReferenceRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEndpointReferenceResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetEndpointReferenceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public string GUID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetEndpointReferenceResponse()
        {
        }
        
        public GetEndpointReferenceResponse(string GUID, System.Xml.Linq.XElement[] Any)
        {
            this.GUID = GUID;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsers", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetUsersRequest
    {
        
        public GetUsersRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsersResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetUsersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public CameraManagementService.User[] User;
        
        public GetUsersResponse()
        {
        }
        
        public GetUsersResponse(CameraManagementService.User[] User)
        {
            this.User = User;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUsers", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateUsersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public CameraManagementService.User[] User;
        
        public CreateUsersRequest()
        {
        }
        
        public CreateUsersRequest(CameraManagementService.User[] User)
        {
            this.User = User;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUsersResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateUsersResponse
    {
        
        public CreateUsersResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteUsers", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteUsersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Username")]
        public string[] Username;
        
        public DeleteUsersRequest()
        {
        }
        
        public DeleteUsersRequest(string[] Username)
        {
            this.Username = Username;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteUsersResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteUsersResponse
    {
        
        public DeleteUsersResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetUser", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public CameraManagementService.User[] User;
        
        public SetUserRequest()
        {
        }
        
        public SetUserRequest(CameraManagementService.User[] User)
        {
            this.User = User;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetUserResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetUserResponse
    {
        
        public SetUserResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWsdlUrl", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetWsdlUrlRequest
    {
        
        public GetWsdlUrlRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWsdlUrlResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetWsdlUrlResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string WsdlUrl;
        
        public GetWsdlUrlResponse()
        {
        }
        
        public GetWsdlUrlResponse(string WsdlUrl)
        {
            this.WsdlUrl = WsdlUrl;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum CapabilityCategory
    {
        
        /// <remarks/>
        All,
        
        /// <remarks/>
        Analytics,
        
        /// <remarks/>
        Device,
        
        /// <remarks/>
        Events,
        
        /// <remarks/>
        Imaging,
        
        /// <remarks/>
        Media,
        
        /// <remarks/>
        PTZ,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCapabilities", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCapabilitiesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public CameraManagementService.CapabilityCategory[] Category;
        
        public GetCapabilitiesRequest()
        {
        }
        
        public GetCapabilitiesRequest(CameraManagementService.CapabilityCategory[] Category)
        {
            this.Category = Category;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCapabilitiesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCapabilitiesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public CameraManagementService.Capabilities Capabilities;
        
        public GetCapabilitiesResponse()
        {
        }
        
        public GetCapabilitiesResponse(CameraManagementService.Capabilities Capabilities)
        {
            this.Capabilities = Capabilities;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetHostname", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetHostnameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string Name;
        
        public SetHostnameRequest()
        {
        }
        
        public SetHostnameRequest(string Name)
        {
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetHostnameResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetHostnameResponse
    {
        
        public SetHostnameResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDNS", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDNSRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public bool FromDHCP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("SearchDomain", DataType="token")]
        public string[] SearchDomain;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("DNSManual")]
        public CameraManagementService.IPAddress[] DNSManual;
        
        public SetDNSRequest()
        {
        }
        
        public SetDNSRequest(bool FromDHCP, string[] SearchDomain, CameraManagementService.IPAddress[] DNSManual)
        {
            this.FromDHCP = FromDHCP;
            this.SearchDomain = SearchDomain;
            this.DNSManual = DNSManual;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDNSResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDNSResponse
    {
        
        public SetDNSResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNTP", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNTPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public bool FromDHCP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("NTPManual")]
        public CameraManagementService.NetworkHost[] NTPManual;
        
        public SetNTPRequest()
        {
        }
        
        public SetNTPRequest(bool FromDHCP, CameraManagementService.NetworkHost[] NTPManual)
        {
            this.FromDHCP = FromDHCP;
            this.NTPManual = NTPManual;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNTPResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNTPResponse
    {
        
        public SetNTPResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDynamicDNS", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDynamicDNSRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public CameraManagementService.DynamicDNSType Type;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string TTL;
        
        public SetDynamicDNSRequest()
        {
        }
        
        public SetDynamicDNSRequest(CameraManagementService.DynamicDNSType Type, string Name, string TTL)
        {
            this.Type = Type;
            this.Name = Name;
            this.TTL = TTL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDynamicDNSResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDynamicDNSResponse
    {
        
        public SetDynamicDNSResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkInterfaces", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkInterfacesRequest
    {
        
        public GetNetworkInterfacesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkInterfacesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkInterfacesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NetworkInterfaces")]
        public CameraManagementService.NetworkInterface[] NetworkInterfaces;
        
        public GetNetworkInterfacesResponse()
        {
        }
        
        public GetNetworkInterfacesResponse(CameraManagementService.NetworkInterface[] NetworkInterfaces)
        {
            this.NetworkInterfaces = NetworkInterfaces;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkProtocols", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkProtocolsRequest
    {
        
        public GetNetworkProtocolsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkProtocolsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkProtocolsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NetworkProtocols")]
        public CameraManagementService.NetworkProtocol[] NetworkProtocols;
        
        public GetNetworkProtocolsResponse()
        {
        }
        
        public GetNetworkProtocolsResponse(CameraManagementService.NetworkProtocol[] NetworkProtocols)
        {
            this.NetworkProtocols = NetworkProtocols;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkProtocols", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkProtocolsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NetworkProtocols")]
        public CameraManagementService.NetworkProtocol[] NetworkProtocols;
        
        public SetNetworkProtocolsRequest()
        {
        }
        
        public SetNetworkProtocolsRequest(CameraManagementService.NetworkProtocol[] NetworkProtocols)
        {
            this.NetworkProtocols = NetworkProtocols;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkProtocolsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkProtocolsResponse
    {
        
        public SetNetworkProtocolsResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkDefaultGateway", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkDefaultGatewayRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("IPv4Address", DataType="token")]
        public string[] IPv4Address;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("IPv6Address", DataType="token")]
        public string[] IPv6Address;
        
        public SetNetworkDefaultGatewayRequest()
        {
        }
        
        public SetNetworkDefaultGatewayRequest(string[] IPv4Address, string[] IPv6Address)
        {
            this.IPv4Address = IPv4Address;
            this.IPv6Address = IPv6Address;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkDefaultGatewayResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkDefaultGatewayResponse
    {
        
        public SetNetworkDefaultGatewayResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCertificate", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateCertificateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string CertificateID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        public string Subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        public System.DateTime ValidNotBefore;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=3)]
        public System.DateTime ValidNotAfter;
        
        public CreateCertificateRequest()
        {
        }
        
        public CreateCertificateRequest(string CertificateID, string Subject, System.DateTime ValidNotBefore, System.DateTime ValidNotAfter)
        {
            this.CertificateID = CertificateID;
            this.Subject = Subject;
            this.ValidNotBefore = ValidNotBefore;
            this.ValidNotAfter = ValidNotAfter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCertificateResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateCertificateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public CameraManagementService.Certificate NvtCertificate;
        
        public CreateCertificateResponse()
        {
        }
        
        public CreateCertificateResponse(CameraManagementService.Certificate NvtCertificate)
        {
            this.NvtCertificate = NvtCertificate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesRequest
    {
        
        public GetCertificatesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NvtCertificate")]
        public CameraManagementService.Certificate[] NvtCertificate;
        
        public GetCertificatesResponse()
        {
        }
        
        public GetCertificatesResponse(CameraManagementService.Certificate[] NvtCertificate)
        {
            this.NvtCertificate = NvtCertificate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificatesStatus", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesStatusRequest
    {
        
        public GetCertificatesStatusRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificatesStatusResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesStatusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateStatus")]
        public CameraManagementService.CertificateStatus[] CertificateStatus;
        
        public GetCertificatesStatusResponse()
        {
        }
        
        public GetCertificatesStatusResponse(CameraManagementService.CertificateStatus[] CertificateStatus)
        {
            this.CertificateStatus = CertificateStatus;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCertificatesStatus", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetCertificatesStatusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateStatus")]
        public CameraManagementService.CertificateStatus[] CertificateStatus;
        
        public SetCertificatesStatusRequest()
        {
        }
        
        public SetCertificatesStatusRequest(CameraManagementService.CertificateStatus[] CertificateStatus)
        {
            this.CertificateStatus = CertificateStatus;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCertificatesStatusResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetCertificatesStatusResponse
    {
        
        public SetCertificatesStatusResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteCertificatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateID", DataType="token")]
        public string[] CertificateID;
        
        public DeleteCertificatesRequest()
        {
        }
        
        public DeleteCertificatesRequest(string[] CertificateID)
        {
            this.CertificateID = CertificateID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteCertificatesResponse
    {
        
        public DeleteCertificatesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPkcs10Request", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetPkcs10RequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string CertificateID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        public string Subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        public CameraManagementService.BinaryData Attributes;
        
        public GetPkcs10RequestRequest()
        {
        }
        
        public GetPkcs10RequestRequest(string CertificateID, string Subject, CameraManagementService.BinaryData Attributes)
        {
            this.CertificateID = CertificateID;
            this.Subject = Subject;
            this.Attributes = Attributes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPkcs10RequestResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetPkcs10RequestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public CameraManagementService.BinaryData Pkcs10Request;
        
        public GetPkcs10RequestResponse()
        {
        }
        
        public GetPkcs10RequestResponse(CameraManagementService.BinaryData Pkcs10Request)
        {
            this.Pkcs10Request = Pkcs10Request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NVTCertificate")]
        public CameraManagementService.Certificate[] NVTCertificate;
        
        public LoadCertificatesRequest()
        {
        }
        
        public LoadCertificatesRequest(CameraManagementService.Certificate[] NVTCertificate)
        {
            this.NVTCertificate = NVTCertificate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificatesResponse
    {
        
        public LoadCertificatesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRelayOutputs", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetRelayOutputsRequest
    {
        
        public GetRelayOutputsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRelayOutputsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetRelayOutputsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("RelayOutputs")]
        public CameraManagementService.RelayOutput[] RelayOutputs;
        
        public GetRelayOutputsResponse()
        {
        }
        
        public GetRelayOutputsResponse(CameraManagementService.RelayOutput[] RelayOutputs)
        {
            this.RelayOutputs = RelayOutputs;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum RelayLogicalState
    {
        
        /// <remarks/>
        active,
        
        /// <remarks/>
        inactive,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCACertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCACertificatesRequest
    {
        
        public GetCACertificatesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCACertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCACertificatesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("CACertificate")]
        public CameraManagementService.Certificate[] CACertificate;
        
        public GetCACertificatesResponse()
        {
        }
        
        public GetCACertificatesResponse(CameraManagementService.Certificate[] CACertificate)
        {
            this.CACertificate = CACertificate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificateWithPrivateKey", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificateWithPrivateKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateWithPrivateKey")]
        public CameraManagementService.CertificateWithPrivateKey[] CertificateWithPrivateKey;
        
        public LoadCertificateWithPrivateKeyRequest()
        {
        }
        
        public LoadCertificateWithPrivateKeyRequest(CameraManagementService.CertificateWithPrivateKey[] CertificateWithPrivateKey)
        {
            this.CertificateWithPrivateKey = CertificateWithPrivateKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificateWithPrivateKeyResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificateWithPrivateKeyResponse
    {
        
        public LoadCertificateWithPrivateKeyResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificateInformation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificateInformationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string CertificateID;
        
        public GetCertificateInformationRequest()
        {
        }
        
        public GetCertificateInformationRequest(string CertificateID)
        {
            this.CertificateID = CertificateID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificateInformationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificateInformationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public CameraManagementService.CertificateInformation CertificateInformation;
        
        public GetCertificateInformationResponse()
        {
        }
        
        public GetCertificateInformationResponse(CameraManagementService.CertificateInformation CertificateInformation)
        {
            this.CertificateInformation = CertificateInformation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCACertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCACertificatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("CACertificate")]
        public CameraManagementService.Certificate[] CACertificate;
        
        public LoadCACertificatesRequest()
        {
        }
        
        public LoadCACertificatesRequest(CameraManagementService.Certificate[] CACertificate)
        {
            this.CACertificate = CACertificate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCACertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCACertificatesResponse
    {
        
        public LoadCACertificatesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot1XConfigurations", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot1XConfigurationsRequest
    {
        
        public GetDot1XConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot1XConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot1XConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Dot1XConfiguration")]
        public CameraManagementService.Dot1XConfiguration[] Dot1XConfiguration;
        
        public GetDot1XConfigurationsResponse()
        {
        }
        
        public GetDot1XConfigurationsResponse(CameraManagementService.Dot1XConfiguration[] Dot1XConfiguration)
        {
            this.Dot1XConfiguration = Dot1XConfiguration;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteDot1XConfiguration", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteDot1XConfigurationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Dot1XConfigurationToken")]
        public string[] Dot1XConfigurationToken;
        
        public DeleteDot1XConfigurationRequest()
        {
        }
        
        public DeleteDot1XConfigurationRequest(string[] Dot1XConfigurationToken)
        {
            this.Dot1XConfigurationToken = Dot1XConfigurationToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteDot1XConfigurationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteDot1XConfigurationResponse
    {
        
        public DeleteDot1XConfigurationResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot11Capabilities", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot11CapabilitiesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetDot11CapabilitiesRequest()
        {
        }
        
        public GetDot11CapabilitiesRequest(System.Xml.Linq.XElement[] Any)
        {
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot11CapabilitiesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot11CapabilitiesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public CameraManagementService.Dot11Capabilities Capabilities;
        
        public GetDot11CapabilitiesResponse()
        {
        }
        
        public GetDot11CapabilitiesResponse(CameraManagementService.Dot11Capabilities Capabilities)
        {
            this.Capabilities = Capabilities;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ScanAvailableDot11Networks", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class ScanAvailableDot11NetworksRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public string InterfaceToken;
        
        public ScanAvailableDot11NetworksRequest()
        {
        }
        
        public ScanAvailableDot11NetworksRequest(string InterfaceToken)
        {
            this.InterfaceToken = InterfaceToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ScanAvailableDot11NetworksResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class ScanAvailableDot11NetworksResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Networks")]
        public CameraManagementService.Dot11AvailableNetworks[] Networks;
        
        public ScanAvailableDot11NetworksResponse()
        {
        }
        
        public ScanAvailableDot11NetworksResponse(CameraManagementService.Dot11AvailableNetworks[] Networks)
        {
            this.Networks = Networks;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.onvif.org/ver10/device/wsdl")]
    public partial class GetSystemUrisResponseExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemUris", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemUrisRequest
    {
        
        public GetSystemUrisRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemUrisResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemUrisResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SystemLog", Namespace="http://www.onvif.org/ver10/schema", IsNullable=false)]
        public CameraManagementService.SystemLogUri[] SystemLogUris;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string SupportInfoUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string SystemBackupUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=3)]
        public CameraManagementService.GetSystemUrisResponseExtension Extension;
        
        public GetSystemUrisResponse()
        {
        }
        
        public GetSystemUrisResponse(CameraManagementService.SystemLogUri[] SystemLogUris, string SupportInfoUri, string SystemBackupUri, CameraManagementService.GetSystemUrisResponseExtension Extension)
        {
            this.SystemLogUris = SystemLogUris;
            this.SupportInfoUri = SupportInfoUri;
            this.SystemBackupUri = SystemBackupUri;
            this.Extension = Extension;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartFirmwareUpgrade", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartFirmwareUpgradeRequest
    {
        
        public StartFirmwareUpgradeRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartFirmwareUpgradeResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartFirmwareUpgradeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string UploadUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string UploadDelay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string ExpectedDownTime;
        
        public StartFirmwareUpgradeResponse()
        {
        }
        
        public StartFirmwareUpgradeResponse(string UploadUri, string UploadDelay, string ExpectedDownTime)
        {
            this.UploadUri = UploadUri;
            this.UploadDelay = UploadDelay;
            this.ExpectedDownTime = ExpectedDownTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartSystemRestore", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartSystemRestoreRequest
    {
        
        public StartSystemRestoreRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartSystemRestoreResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartSystemRestoreResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string UploadUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string ExpectedDownTime;
        
        public StartSystemRestoreResponse()
        {
        }
        
        public StartSystemRestoreResponse(string UploadUri, string ExpectedDownTime)
        {
            this.UploadUri = UploadUri;
            this.ExpectedDownTime = ExpectedDownTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetStorageConfigurations", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetStorageConfigurationsRequest
    {
        
        public GetStorageConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetStorageConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetStorageConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("StorageConfigurations")]
        public CameraManagementService.StorageConfiguration[] StorageConfigurations;
        
        public GetStorageConfigurationsResponse()
        {
        }
        
        public GetStorageConfigurationsResponse(CameraManagementService.StorageConfiguration[] StorageConfigurations)
        {
            this.StorageConfigurations = StorageConfigurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGeoLocation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetGeoLocationRequest
    {
        
        public GetGeoLocationRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGeoLocationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetGeoLocationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public CameraManagementService.LocationEntity[] Location;
        
        public GetGeoLocationResponse()
        {
        }
        
        public GetGeoLocationResponse(CameraManagementService.LocationEntity[] Location)
        {
            this.Location = Location;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetGeoLocation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetGeoLocationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public CameraManagementService.LocationEntity[] Location;
        
        public SetGeoLocationRequest()
        {
        }
        
        public SetGeoLocationRequest(CameraManagementService.LocationEntity[] Location)
        {
            this.Location = Location;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetGeoLocationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetGeoLocationResponse
    {
        
        public SetGeoLocationResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteGeoLocation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteGeoLocationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public CameraManagementService.LocationEntity[] Location;
        
        public DeleteGeoLocationRequest()
        {
        }
        
        public DeleteGeoLocationRequest(CameraManagementService.LocationEntity[] Location)
        {
            this.Location = Location;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteGeoLocationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteGeoLocationResponse
    {
        
        public DeleteGeoLocationResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal interface DeviceChannel : CameraManagementService.Device, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal partial class DeviceClient : System.ServiceModel.ClientBase<CameraManagementService.Device>, CameraManagementService.Device
    {
        
        public DeviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetServicesResponse> CameraManagementService.Device.GetServicesAsync(CameraManagementService.GetServicesRequest request)
        {
            return base.Channel.GetServicesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetServicesResponse> GetServicesAsync(bool IncludeCapability)
        {
            CameraManagementService.GetServicesRequest inValue = new CameraManagementService.GetServicesRequest();
            inValue.IncludeCapability = IncludeCapability;
            return ((CameraManagementService.Device)(this)).GetServicesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DeviceServiceCapabilities> GetServiceCapabilitiesAsync()
        {
            return base.Channel.GetServiceCapabilitiesAsync();
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetDeviceInformationResponse> GetDeviceInformationAsync(CameraManagementService.GetDeviceInformationRequest request)
        {
            return base.Channel.GetDeviceInformationAsync(request);
        }
        
        public System.Threading.Tasks.Task SetSystemDateAndTimeAsync(CameraManagementService.SetDateTimeType DateTimeType, bool DaylightSavings, CameraManagementService.TimeZone TimeZone, CameraManagementService.DateTime UTCDateTime)
        {
            return base.Channel.SetSystemDateAndTimeAsync(DateTimeType, DaylightSavings, TimeZone, UTCDateTime);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SystemDateTime> GetSystemDateAndTimeAsync()
        {
            return base.Channel.GetSystemDateAndTimeAsync();
        }
        
        public System.Threading.Tasks.Task SetSystemFactoryDefaultAsync(CameraManagementService.FactoryDefaultType FactoryDefault)
        {
            return base.Channel.SetSystemFactoryDefaultAsync(FactoryDefault);
        }
        
        public System.Threading.Tasks.Task<string> UpgradeSystemFirmwareAsync(CameraManagementService.AttachmentData Firmware)
        {
            return base.Channel.UpgradeSystemFirmwareAsync(Firmware);
        }
        
        public System.Threading.Tasks.Task<string> SystemRebootAsync()
        {
            return base.Channel.SystemRebootAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.RestoreSystemResponse> CameraManagementService.Device.RestoreSystemAsync(CameraManagementService.RestoreSystemRequest request)
        {
            return base.Channel.RestoreSystemAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.RestoreSystemResponse> RestoreSystemAsync(CameraManagementService.BackupFile[] BackupFiles)
        {
            CameraManagementService.RestoreSystemRequest inValue = new CameraManagementService.RestoreSystemRequest();
            inValue.BackupFiles = BackupFiles;
            return ((CameraManagementService.Device)(this)).RestoreSystemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetSystemBackupResponse> CameraManagementService.Device.GetSystemBackupAsync(CameraManagementService.GetSystemBackupRequest request)
        {
            return base.Channel.GetSystemBackupAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetSystemBackupResponse> GetSystemBackupAsync()
        {
            CameraManagementService.GetSystemBackupRequest inValue = new CameraManagementService.GetSystemBackupRequest();
            return ((CameraManagementService.Device)(this)).GetSystemBackupAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SystemLog> GetSystemLogAsync(CameraManagementService.SystemLogType LogType)
        {
            return base.Channel.GetSystemLogAsync(LogType);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SupportInformation> GetSystemSupportInformationAsync()
        {
            return base.Channel.GetSystemSupportInformationAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetScopesResponse> CameraManagementService.Device.GetScopesAsync(CameraManagementService.GetScopesRequest request)
        {
            return base.Channel.GetScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetScopesResponse> GetScopesAsync()
        {
            CameraManagementService.GetScopesRequest inValue = new CameraManagementService.GetScopesRequest();
            return ((CameraManagementService.Device)(this)).GetScopesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetScopesResponse> CameraManagementService.Device.SetScopesAsync(CameraManagementService.SetScopesRequest request)
        {
            return base.Channel.SetScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetScopesResponse> SetScopesAsync(string[] Scopes)
        {
            CameraManagementService.SetScopesRequest inValue = new CameraManagementService.SetScopesRequest();
            inValue.Scopes = Scopes;
            return ((CameraManagementService.Device)(this)).SetScopesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.AddScopesResponse> CameraManagementService.Device.AddScopesAsync(CameraManagementService.AddScopesRequest request)
        {
            return base.Channel.AddScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.AddScopesResponse> AddScopesAsync(string[] ScopeItem)
        {
            CameraManagementService.AddScopesRequest inValue = new CameraManagementService.AddScopesRequest();
            inValue.ScopeItem = ScopeItem;
            return ((CameraManagementService.Device)(this)).AddScopesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.RemoveScopesResponse> RemoveScopesAsync(CameraManagementService.RemoveScopesRequest request)
        {
            return base.Channel.RemoveScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DiscoveryMode> GetDiscoveryModeAsync()
        {
            return base.Channel.GetDiscoveryModeAsync();
        }
        
        public System.Threading.Tasks.Task SetDiscoveryModeAsync(CameraManagementService.DiscoveryMode DiscoveryMode)
        {
            return base.Channel.SetDiscoveryModeAsync(DiscoveryMode);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DiscoveryMode> GetRemoteDiscoveryModeAsync()
        {
            return base.Channel.GetRemoteDiscoveryModeAsync();
        }
        
        public System.Threading.Tasks.Task SetRemoteDiscoveryModeAsync(CameraManagementService.DiscoveryMode RemoteDiscoveryMode)
        {
            return base.Channel.SetRemoteDiscoveryModeAsync(RemoteDiscoveryMode);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetDPAddressesResponse> CameraManagementService.Device.GetDPAddressesAsync(CameraManagementService.GetDPAddressesRequest request)
        {
            return base.Channel.GetDPAddressesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetDPAddressesResponse> GetDPAddressesAsync()
        {
            CameraManagementService.GetDPAddressesRequest inValue = new CameraManagementService.GetDPAddressesRequest();
            return ((CameraManagementService.Device)(this)).GetDPAddressesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetDPAddressesResponse> CameraManagementService.Device.SetDPAddressesAsync(CameraManagementService.SetDPAddressesRequest request)
        {
            return base.Channel.SetDPAddressesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetDPAddressesResponse> SetDPAddressesAsync(CameraManagementService.NetworkHost[] DPAddress)
        {
            CameraManagementService.SetDPAddressesRequest inValue = new CameraManagementService.SetDPAddressesRequest();
            inValue.DPAddress = DPAddress;
            return ((CameraManagementService.Device)(this)).SetDPAddressesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetEndpointReferenceResponse> GetEndpointReferenceAsync(CameraManagementService.GetEndpointReferenceRequest request)
        {
            return base.Channel.GetEndpointReferenceAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.RemoteUser> GetRemoteUserAsync()
        {
            return base.Channel.GetRemoteUserAsync();
        }
        
        public System.Threading.Tasks.Task SetRemoteUserAsync(CameraManagementService.RemoteUser RemoteUser)
        {
            return base.Channel.SetRemoteUserAsync(RemoteUser);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetUsersResponse> CameraManagementService.Device.GetUsersAsync(CameraManagementService.GetUsersRequest request)
        {
            return base.Channel.GetUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetUsersResponse> GetUsersAsync()
        {
            CameraManagementService.GetUsersRequest inValue = new CameraManagementService.GetUsersRequest();
            return ((CameraManagementService.Device)(this)).GetUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.CreateUsersResponse> CameraManagementService.Device.CreateUsersAsync(CameraManagementService.CreateUsersRequest request)
        {
            return base.Channel.CreateUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.CreateUsersResponse> CreateUsersAsync(CameraManagementService.User[] User)
        {
            CameraManagementService.CreateUsersRequest inValue = new CameraManagementService.CreateUsersRequest();
            inValue.User = User;
            return ((CameraManagementService.Device)(this)).CreateUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.DeleteUsersResponse> CameraManagementService.Device.DeleteUsersAsync(CameraManagementService.DeleteUsersRequest request)
        {
            return base.Channel.DeleteUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DeleteUsersResponse> DeleteUsersAsync(string[] Username)
        {
            CameraManagementService.DeleteUsersRequest inValue = new CameraManagementService.DeleteUsersRequest();
            inValue.Username = Username;
            return ((CameraManagementService.Device)(this)).DeleteUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetUserResponse> CameraManagementService.Device.SetUserAsync(CameraManagementService.SetUserRequest request)
        {
            return base.Channel.SetUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetUserResponse> SetUserAsync(CameraManagementService.User[] User)
        {
            CameraManagementService.SetUserRequest inValue = new CameraManagementService.SetUserRequest();
            inValue.User = User;
            return ((CameraManagementService.Device)(this)).SetUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetWsdlUrlResponse> CameraManagementService.Device.GetWsdlUrlAsync(CameraManagementService.GetWsdlUrlRequest request)
        {
            return base.Channel.GetWsdlUrlAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetWsdlUrlResponse> GetWsdlUrlAsync()
        {
            CameraManagementService.GetWsdlUrlRequest inValue = new CameraManagementService.GetWsdlUrlRequest();
            return ((CameraManagementService.Device)(this)).GetWsdlUrlAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetCapabilitiesResponse> CameraManagementService.Device.GetCapabilitiesAsync(CameraManagementService.GetCapabilitiesRequest request)
        {
            return base.Channel.GetCapabilitiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetCapabilitiesResponse> GetCapabilitiesAsync(CameraManagementService.CapabilityCategory[] Category)
        {
            CameraManagementService.GetCapabilitiesRequest inValue = new CameraManagementService.GetCapabilitiesRequest();
            inValue.Category = Category;
            return ((CameraManagementService.Device)(this)).GetCapabilitiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.HostnameInformation> GetHostnameAsync()
        {
            return base.Channel.GetHostnameAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetHostnameResponse> CameraManagementService.Device.SetHostnameAsync(CameraManagementService.SetHostnameRequest request)
        {
            return base.Channel.SetHostnameAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetHostnameResponse> SetHostnameAsync(string Name)
        {
            CameraManagementService.SetHostnameRequest inValue = new CameraManagementService.SetHostnameRequest();
            inValue.Name = Name;
            return ((CameraManagementService.Device)(this)).SetHostnameAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP)
        {
            return base.Channel.SetHostnameFromDHCPAsync(FromDHCP);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DNSInformation> GetDNSAsync()
        {
            return base.Channel.GetDNSAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetDNSResponse> CameraManagementService.Device.SetDNSAsync(CameraManagementService.SetDNSRequest request)
        {
            return base.Channel.SetDNSAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetDNSResponse> SetDNSAsync(bool FromDHCP, string[] SearchDomain, CameraManagementService.IPAddress[] DNSManual)
        {
            CameraManagementService.SetDNSRequest inValue = new CameraManagementService.SetDNSRequest();
            inValue.FromDHCP = FromDHCP;
            inValue.SearchDomain = SearchDomain;
            inValue.DNSManual = DNSManual;
            return ((CameraManagementService.Device)(this)).SetDNSAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.NTPInformation> GetNTPAsync()
        {
            return base.Channel.GetNTPAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetNTPResponse> CameraManagementService.Device.SetNTPAsync(CameraManagementService.SetNTPRequest request)
        {
            return base.Channel.SetNTPAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetNTPResponse> SetNTPAsync(bool FromDHCP, CameraManagementService.NetworkHost[] NTPManual)
        {
            CameraManagementService.SetNTPRequest inValue = new CameraManagementService.SetNTPRequest();
            inValue.FromDHCP = FromDHCP;
            inValue.NTPManual = NTPManual;
            return ((CameraManagementService.Device)(this)).SetNTPAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DynamicDNSInformation> GetDynamicDNSAsync()
        {
            return base.Channel.GetDynamicDNSAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetDynamicDNSResponse> CameraManagementService.Device.SetDynamicDNSAsync(CameraManagementService.SetDynamicDNSRequest request)
        {
            return base.Channel.SetDynamicDNSAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetDynamicDNSResponse> SetDynamicDNSAsync(CameraManagementService.DynamicDNSType Type, string Name, string TTL)
        {
            CameraManagementService.SetDynamicDNSRequest inValue = new CameraManagementService.SetDynamicDNSRequest();
            inValue.Type = Type;
            inValue.Name = Name;
            inValue.TTL = TTL;
            return ((CameraManagementService.Device)(this)).SetDynamicDNSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetNetworkInterfacesResponse> CameraManagementService.Device.GetNetworkInterfacesAsync(CameraManagementService.GetNetworkInterfacesRequest request)
        {
            return base.Channel.GetNetworkInterfacesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetNetworkInterfacesResponse> GetNetworkInterfacesAsync()
        {
            CameraManagementService.GetNetworkInterfacesRequest inValue = new CameraManagementService.GetNetworkInterfacesRequest();
            return ((CameraManagementService.Device)(this)).GetNetworkInterfacesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> SetNetworkInterfacesAsync(string InterfaceToken, CameraManagementService.NetworkInterfaceSetConfiguration NetworkInterface)
        {
            return base.Channel.SetNetworkInterfacesAsync(InterfaceToken, NetworkInterface);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetNetworkProtocolsResponse> CameraManagementService.Device.GetNetworkProtocolsAsync(CameraManagementService.GetNetworkProtocolsRequest request)
        {
            return base.Channel.GetNetworkProtocolsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetNetworkProtocolsResponse> GetNetworkProtocolsAsync()
        {
            CameraManagementService.GetNetworkProtocolsRequest inValue = new CameraManagementService.GetNetworkProtocolsRequest();
            return ((CameraManagementService.Device)(this)).GetNetworkProtocolsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetNetworkProtocolsResponse> CameraManagementService.Device.SetNetworkProtocolsAsync(CameraManagementService.SetNetworkProtocolsRequest request)
        {
            return base.Channel.SetNetworkProtocolsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetNetworkProtocolsResponse> SetNetworkProtocolsAsync(CameraManagementService.NetworkProtocol[] NetworkProtocols)
        {
            CameraManagementService.SetNetworkProtocolsRequest inValue = new CameraManagementService.SetNetworkProtocolsRequest();
            inValue.NetworkProtocols = NetworkProtocols;
            return ((CameraManagementService.Device)(this)).SetNetworkProtocolsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.NetworkGateway> GetNetworkDefaultGatewayAsync()
        {
            return base.Channel.GetNetworkDefaultGatewayAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetNetworkDefaultGatewayResponse> CameraManagementService.Device.SetNetworkDefaultGatewayAsync(CameraManagementService.SetNetworkDefaultGatewayRequest request)
        {
            return base.Channel.SetNetworkDefaultGatewayAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetNetworkDefaultGatewayResponse> SetNetworkDefaultGatewayAsync(string[] IPv4Address, string[] IPv6Address)
        {
            CameraManagementService.SetNetworkDefaultGatewayRequest inValue = new CameraManagementService.SetNetworkDefaultGatewayRequest();
            inValue.IPv4Address = IPv4Address;
            inValue.IPv6Address = IPv6Address;
            return ((CameraManagementService.Device)(this)).SetNetworkDefaultGatewayAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.NetworkZeroConfiguration> GetZeroConfigurationAsync()
        {
            return base.Channel.GetZeroConfigurationAsync();
        }
        
        public System.Threading.Tasks.Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled)
        {
            return base.Channel.SetZeroConfigurationAsync(InterfaceToken, Enabled);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.IPAddressFilter> GetIPAddressFilterAsync()
        {
            return base.Channel.GetIPAddressFilterAsync();
        }
        
        public System.Threading.Tasks.Task SetIPAddressFilterAsync(CameraManagementService.IPAddressFilter IPAddressFilter)
        {
            return base.Channel.SetIPAddressFilterAsync(IPAddressFilter);
        }
        
        public System.Threading.Tasks.Task AddIPAddressFilterAsync(CameraManagementService.IPAddressFilter IPAddressFilter)
        {
            return base.Channel.AddIPAddressFilterAsync(IPAddressFilter);
        }
        
        public System.Threading.Tasks.Task RemoveIPAddressFilterAsync(CameraManagementService.IPAddressFilter IPAddressFilter)
        {
            return base.Channel.RemoveIPAddressFilterAsync(IPAddressFilter);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.BinaryData> GetAccessPolicyAsync()
        {
            return base.Channel.GetAccessPolicyAsync();
        }
        
        public System.Threading.Tasks.Task SetAccessPolicyAsync(CameraManagementService.BinaryData PolicyFile)
        {
            return base.Channel.SetAccessPolicyAsync(PolicyFile);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.CreateCertificateResponse> CameraManagementService.Device.CreateCertificateAsync(CameraManagementService.CreateCertificateRequest request)
        {
            return base.Channel.CreateCertificateAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.CreateCertificateResponse> CreateCertificateAsync(string CertificateID, string Subject, System.DateTime ValidNotBefore, System.DateTime ValidNotAfter)
        {
            CameraManagementService.CreateCertificateRequest inValue = new CameraManagementService.CreateCertificateRequest();
            inValue.CertificateID = CertificateID;
            inValue.Subject = Subject;
            inValue.ValidNotBefore = ValidNotBefore;
            inValue.ValidNotAfter = ValidNotAfter;
            return ((CameraManagementService.Device)(this)).CreateCertificateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetCertificatesResponse> CameraManagementService.Device.GetCertificatesAsync(CameraManagementService.GetCertificatesRequest request)
        {
            return base.Channel.GetCertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetCertificatesResponse> GetCertificatesAsync()
        {
            CameraManagementService.GetCertificatesRequest inValue = new CameraManagementService.GetCertificatesRequest();
            return ((CameraManagementService.Device)(this)).GetCertificatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetCertificatesStatusResponse> CameraManagementService.Device.GetCertificatesStatusAsync(CameraManagementService.GetCertificatesStatusRequest request)
        {
            return base.Channel.GetCertificatesStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetCertificatesStatusResponse> GetCertificatesStatusAsync()
        {
            CameraManagementService.GetCertificatesStatusRequest inValue = new CameraManagementService.GetCertificatesStatusRequest();
            return ((CameraManagementService.Device)(this)).GetCertificatesStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetCertificatesStatusResponse> CameraManagementService.Device.SetCertificatesStatusAsync(CameraManagementService.SetCertificatesStatusRequest request)
        {
            return base.Channel.SetCertificatesStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetCertificatesStatusResponse> SetCertificatesStatusAsync(CameraManagementService.CertificateStatus[] CertificateStatus)
        {
            CameraManagementService.SetCertificatesStatusRequest inValue = new CameraManagementService.SetCertificatesStatusRequest();
            inValue.CertificateStatus = CertificateStatus;
            return ((CameraManagementService.Device)(this)).SetCertificatesStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.DeleteCertificatesResponse> CameraManagementService.Device.DeleteCertificatesAsync(CameraManagementService.DeleteCertificatesRequest request)
        {
            return base.Channel.DeleteCertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DeleteCertificatesResponse> DeleteCertificatesAsync(string[] CertificateID)
        {
            CameraManagementService.DeleteCertificatesRequest inValue = new CameraManagementService.DeleteCertificatesRequest();
            inValue.CertificateID = CertificateID;
            return ((CameraManagementService.Device)(this)).DeleteCertificatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetPkcs10RequestResponse> CameraManagementService.Device.GetPkcs10RequestAsync(CameraManagementService.GetPkcs10RequestRequest request)
        {
            return base.Channel.GetPkcs10RequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetPkcs10RequestResponse> GetPkcs10RequestAsync(string CertificateID, string Subject, CameraManagementService.BinaryData Attributes)
        {
            CameraManagementService.GetPkcs10RequestRequest inValue = new CameraManagementService.GetPkcs10RequestRequest();
            inValue.CertificateID = CertificateID;
            inValue.Subject = Subject;
            inValue.Attributes = Attributes;
            return ((CameraManagementService.Device)(this)).GetPkcs10RequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.LoadCertificatesResponse> CameraManagementService.Device.LoadCertificatesAsync(CameraManagementService.LoadCertificatesRequest request)
        {
            return base.Channel.LoadCertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.LoadCertificatesResponse> LoadCertificatesAsync(CameraManagementService.Certificate[] NVTCertificate)
        {
            CameraManagementService.LoadCertificatesRequest inValue = new CameraManagementService.LoadCertificatesRequest();
            inValue.NVTCertificate = NVTCertificate;
            return ((CameraManagementService.Device)(this)).LoadCertificatesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> GetClientCertificateModeAsync()
        {
            return base.Channel.GetClientCertificateModeAsync();
        }
        
        public System.Threading.Tasks.Task SetClientCertificateModeAsync(bool Enabled)
        {
            return base.Channel.SetClientCertificateModeAsync(Enabled);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetRelayOutputsResponse> CameraManagementService.Device.GetRelayOutputsAsync(CameraManagementService.GetRelayOutputsRequest request)
        {
            return base.Channel.GetRelayOutputsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetRelayOutputsResponse> GetRelayOutputsAsync()
        {
            CameraManagementService.GetRelayOutputsRequest inValue = new CameraManagementService.GetRelayOutputsRequest();
            return ((CameraManagementService.Device)(this)).GetRelayOutputsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task SetRelayOutputSettingsAsync(string RelayOutputToken, CameraManagementService.RelayOutputSettings Properties)
        {
            return base.Channel.SetRelayOutputSettingsAsync(RelayOutputToken, Properties);
        }
        
        public System.Threading.Tasks.Task SetRelayOutputStateAsync(string RelayOutputToken, CameraManagementService.RelayLogicalState LogicalState)
        {
            return base.Channel.SetRelayOutputStateAsync(RelayOutputToken, LogicalState);
        }
        
        public System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand)
        {
            return base.Channel.SendAuxiliaryCommandAsync(AuxiliaryCommand);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetCACertificatesResponse> CameraManagementService.Device.GetCACertificatesAsync(CameraManagementService.GetCACertificatesRequest request)
        {
            return base.Channel.GetCACertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetCACertificatesResponse> GetCACertificatesAsync()
        {
            CameraManagementService.GetCACertificatesRequest inValue = new CameraManagementService.GetCACertificatesRequest();
            return ((CameraManagementService.Device)(this)).GetCACertificatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.LoadCertificateWithPrivateKeyResponse> CameraManagementService.Device.LoadCertificateWithPrivateKeyAsync(CameraManagementService.LoadCertificateWithPrivateKeyRequest request)
        {
            return base.Channel.LoadCertificateWithPrivateKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKeyAsync(CameraManagementService.CertificateWithPrivateKey[] CertificateWithPrivateKey)
        {
            CameraManagementService.LoadCertificateWithPrivateKeyRequest inValue = new CameraManagementService.LoadCertificateWithPrivateKeyRequest();
            inValue.CertificateWithPrivateKey = CertificateWithPrivateKey;
            return ((CameraManagementService.Device)(this)).LoadCertificateWithPrivateKeyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetCertificateInformationResponse> CameraManagementService.Device.GetCertificateInformationAsync(CameraManagementService.GetCertificateInformationRequest request)
        {
            return base.Channel.GetCertificateInformationAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetCertificateInformationResponse> GetCertificateInformationAsync(string CertificateID)
        {
            CameraManagementService.GetCertificateInformationRequest inValue = new CameraManagementService.GetCertificateInformationRequest();
            inValue.CertificateID = CertificateID;
            return ((CameraManagementService.Device)(this)).GetCertificateInformationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.LoadCACertificatesResponse> CameraManagementService.Device.LoadCACertificatesAsync(CameraManagementService.LoadCACertificatesRequest request)
        {
            return base.Channel.LoadCACertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.LoadCACertificatesResponse> LoadCACertificatesAsync(CameraManagementService.Certificate[] CACertificate)
        {
            CameraManagementService.LoadCACertificatesRequest inValue = new CameraManagementService.LoadCACertificatesRequest();
            inValue.CACertificate = CACertificate;
            return ((CameraManagementService.Device)(this)).LoadCACertificatesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task CreateDot1XConfigurationAsync(CameraManagementService.Dot1XConfiguration Dot1XConfiguration)
        {
            return base.Channel.CreateDot1XConfigurationAsync(Dot1XConfiguration);
        }
        
        public System.Threading.Tasks.Task SetDot1XConfigurationAsync(CameraManagementService.Dot1XConfiguration Dot1XConfiguration)
        {
            return base.Channel.SetDot1XConfigurationAsync(Dot1XConfiguration);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.Dot1XConfiguration> GetDot1XConfigurationAsync(string Dot1XConfigurationToken)
        {
            return base.Channel.GetDot1XConfigurationAsync(Dot1XConfigurationToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetDot1XConfigurationsResponse> CameraManagementService.Device.GetDot1XConfigurationsAsync(CameraManagementService.GetDot1XConfigurationsRequest request)
        {
            return base.Channel.GetDot1XConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetDot1XConfigurationsResponse> GetDot1XConfigurationsAsync()
        {
            CameraManagementService.GetDot1XConfigurationsRequest inValue = new CameraManagementService.GetDot1XConfigurationsRequest();
            return ((CameraManagementService.Device)(this)).GetDot1XConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.DeleteDot1XConfigurationResponse> CameraManagementService.Device.DeleteDot1XConfigurationAsync(CameraManagementService.DeleteDot1XConfigurationRequest request)
        {
            return base.Channel.DeleteDot1XConfigurationAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DeleteDot1XConfigurationResponse> DeleteDot1XConfigurationAsync(string[] Dot1XConfigurationToken)
        {
            CameraManagementService.DeleteDot1XConfigurationRequest inValue = new CameraManagementService.DeleteDot1XConfigurationRequest();
            inValue.Dot1XConfigurationToken = Dot1XConfigurationToken;
            return ((CameraManagementService.Device)(this)).DeleteDot1XConfigurationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetDot11CapabilitiesResponse> CameraManagementService.Device.GetDot11CapabilitiesAsync(CameraManagementService.GetDot11CapabilitiesRequest request)
        {
            return base.Channel.GetDot11CapabilitiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetDot11CapabilitiesResponse> GetDot11CapabilitiesAsync(System.Xml.Linq.XElement[] Any)
        {
            CameraManagementService.GetDot11CapabilitiesRequest inValue = new CameraManagementService.GetDot11CapabilitiesRequest();
            inValue.Any = Any;
            return ((CameraManagementService.Device)(this)).GetDot11CapabilitiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.Dot11Status> GetDot11StatusAsync(string InterfaceToken)
        {
            return base.Channel.GetDot11StatusAsync(InterfaceToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.ScanAvailableDot11NetworksResponse> CameraManagementService.Device.ScanAvailableDot11NetworksAsync(CameraManagementService.ScanAvailableDot11NetworksRequest request)
        {
            return base.Channel.ScanAvailableDot11NetworksAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.ScanAvailableDot11NetworksResponse> ScanAvailableDot11NetworksAsync(string InterfaceToken)
        {
            CameraManagementService.ScanAvailableDot11NetworksRequest inValue = new CameraManagementService.ScanAvailableDot11NetworksRequest();
            inValue.InterfaceToken = InterfaceToken;
            return ((CameraManagementService.Device)(this)).ScanAvailableDot11NetworksAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetSystemUrisResponse> GetSystemUrisAsync(CameraManagementService.GetSystemUrisRequest request)
        {
            return base.Channel.GetSystemUrisAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.StartFirmwareUpgradeResponse> StartFirmwareUpgradeAsync(CameraManagementService.StartFirmwareUpgradeRequest request)
        {
            return base.Channel.StartFirmwareUpgradeAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.StartSystemRestoreResponse> StartSystemRestoreAsync(CameraManagementService.StartSystemRestoreRequest request)
        {
            return base.Channel.StartSystemRestoreAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetStorageConfigurationsResponse> CameraManagementService.Device.GetStorageConfigurationsAsync(CameraManagementService.GetStorageConfigurationsRequest request)
        {
            return base.Channel.GetStorageConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetStorageConfigurationsResponse> GetStorageConfigurationsAsync()
        {
            CameraManagementService.GetStorageConfigurationsRequest inValue = new CameraManagementService.GetStorageConfigurationsRequest();
            return ((CameraManagementService.Device)(this)).GetStorageConfigurationsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<string> CreateStorageConfigurationAsync(CameraManagementService.StorageConfigurationData StorageConfiguration)
        {
            return base.Channel.CreateStorageConfigurationAsync(StorageConfiguration);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.StorageConfiguration> GetStorageConfigurationAsync(string Token)
        {
            return base.Channel.GetStorageConfigurationAsync(Token);
        }
        
        public System.Threading.Tasks.Task SetStorageConfigurationAsync(CameraManagementService.StorageConfiguration StorageConfiguration)
        {
            return base.Channel.SetStorageConfigurationAsync(StorageConfiguration);
        }
        
        public System.Threading.Tasks.Task DeleteStorageConfigurationAsync(string Token)
        {
            return base.Channel.DeleteStorageConfigurationAsync(Token);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.GetGeoLocationResponse> CameraManagementService.Device.GetGeoLocationAsync(CameraManagementService.GetGeoLocationRequest request)
        {
            return base.Channel.GetGeoLocationAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.GetGeoLocationResponse> GetGeoLocationAsync()
        {
            CameraManagementService.GetGeoLocationRequest inValue = new CameraManagementService.GetGeoLocationRequest();
            return ((CameraManagementService.Device)(this)).GetGeoLocationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.SetGeoLocationResponse> CameraManagementService.Device.SetGeoLocationAsync(CameraManagementService.SetGeoLocationRequest request)
        {
            return base.Channel.SetGeoLocationAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.SetGeoLocationResponse> SetGeoLocationAsync(CameraManagementService.LocationEntity[] Location)
        {
            CameraManagementService.SetGeoLocationRequest inValue = new CameraManagementService.SetGeoLocationRequest();
            inValue.Location = Location;
            return ((CameraManagementService.Device)(this)).SetGeoLocationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraManagementService.DeleteGeoLocationResponse> CameraManagementService.Device.DeleteGeoLocationAsync(CameraManagementService.DeleteGeoLocationRequest request)
        {
            return base.Channel.DeleteGeoLocationAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraManagementService.DeleteGeoLocationResponse> DeleteGeoLocationAsync(CameraManagementService.LocationEntity[] Location)
        {
            CameraManagementService.DeleteGeoLocationRequest inValue = new CameraManagementService.DeleteGeoLocationRequest();
            inValue.Location = Location;
            return ((CameraManagementService.Device)(this)).DeleteGeoLocationAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
