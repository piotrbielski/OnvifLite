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

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace OnvifLite.CameraMediaService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", ConfigurationName="CameraMediaService.Media")]
    public interface Media : IDisposable
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetServiceCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Capabilities")]
        System.Threading.Tasks.Task<CameraMediaService.Capabilities> GetServiceCapabilitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetVideoSources/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoSourcesResponse> GetVideoSourcesAsync(CameraMediaService.GetVideoSourcesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioSources", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioSourcesResponse> GetAudioSourcesAsync(CameraMediaService.GetAudioSourcesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputs", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioOutputsResponse> GetAudioOutputsAsync(CameraMediaService.GetAudioOutputsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/CreateProfile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Profile")]
        System.Threading.Tasks.Task<CameraMediaService.Profile> CreateProfileAsync(string Name, string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetProfile/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Profile")]
        System.Threading.Tasks.Task<CameraMediaService.Profile> GetProfileAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetProfiles", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetProfilesResponse> GetProfilesAsync(CameraMediaService.GetProfilesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveVideoEncoderConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveVideoSourceConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioEncoderConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioSourceConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddPTZConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemovePTZConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemovePTZConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveMetadataConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioOutputConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioDecoderConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/DeleteProfile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task DeleteProfileAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoSourceConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync(CameraMediaService.GetVideoSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync(CameraMediaService.GetVideoEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetAudioSourceConfigurations/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync(CameraMediaService.GetAudioSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync(CameraMediaService.GetAudioEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoAnalyticsConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync(CameraMediaService.GetVideoAnalyticsConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetMetadataConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync(CameraMediaService.GetMetadataConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync(CameraMediaService.GetAudioOutputConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync(CameraMediaService.GetAudioDecoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<CameraMediaService.AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(CameraMediaService.GetCompatibleVideoEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoSourceConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(CameraMediaService.GetCompatibleVideoSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(CameraMediaService.GetCompatibleAudioEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioSourceConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(CameraMediaService.GetCompatibleAudioSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoAnalyticsConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(CameraMediaService.GetCompatibleVideoAnalyticsConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleMetadataConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(CameraMediaService.GetCompatibleMetadataConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioOutputConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(CameraMediaService.GetCompatibleAudioOutputConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioDecoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(CameraMediaService.GetCompatibleAudioDecoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetVideoSourceConfigurationAsync(CameraMediaService.VideoSourceConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetVideoEncoderConfigurationAsync(CameraMediaService.VideoEncoderConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioSourceConfigurationAsync(CameraMediaService.AudioSourceConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioEncoderConfigurationAsync(CameraMediaService.AudioEncoderConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetVideoAnalyticsConfigurationAsync(CameraMediaService.VideoAnalyticsConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetMetadataConfigurationAsync(CameraMediaService.MetadataConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioOutputConfigurationAsync(CameraMediaService.AudioOutputConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioDecoderConfigurationAsync(CameraMediaService.AudioDecoderConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetVideoSourceConfigurationOptions/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<CameraMediaService.VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<CameraMediaService.VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioSourceConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<CameraMediaService.AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<CameraMediaService.AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetMetadataConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<CameraMediaService.MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<CameraMediaService.AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<CameraMediaService.AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetGuaranteedNumberOfVideoEncoderInstances", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(CameraMediaService.GetGuaranteedNumberOfVideoEncoderInstancesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetStreamUri", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MediaUri")]
        System.Threading.Tasks.Task<CameraMediaService.MediaUri> GetStreamUriAsync(CameraMediaService.StreamSetup StreamSetup, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/StartMulticastStreaming", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task StartMulticastStreamingAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/StopMulticastStreaming", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task StopMulticastStreamingAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetSynchronizationPoint", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSynchronizationPointAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetSnapshotUri", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MediaUri")]
        System.Threading.Tasks.Task<CameraMediaService.MediaUri> GetSnapshotUriAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoSourceModes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoSourceModesResponse> GetVideoSourceModesAsync(CameraMediaService.GetVideoSourceModesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoSourceMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Reboot")]
        System.Threading.Tasks.Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetOSDs", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetOSDsResponse> GetOSDsAsync(CameraMediaService.GetOSDsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetOSDResponse> GetOSDAsync(CameraMediaService.GetOSDRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetOSDOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.GetOSDOptionsResponse> GetOSDOptionsAsync(CameraMediaService.GetOSDOptionsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.SetOSDResponse> SetOSDAsync(CameraMediaService.SetOSDRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/CreateOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.CreateOSDResponse> CreateOSDAsync(CameraMediaService.CreateOSDRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/DeleteOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<CameraMediaService.DeleteOSDResponse> DeleteOSDAsync(CameraMediaService.DeleteOSDRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl")]
    public partial class Capabilities
    {
        
        private ProfileCapabilities profileCapabilitiesField;
        
        private StreamingCapabilities streamingCapabilitiesField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private bool snapshotUriField;
        
        private bool snapshotUriFieldSpecified;
        
        private bool rotationField;
        
        private bool rotationFieldSpecified;
        
        private bool videoSourceModeField;
        
        private bool videoSourceModeFieldSpecified;
        
        private bool oSDField;
        
        private bool oSDFieldSpecified;
        
        private bool temporaryOSDTextField;
        
        private bool temporaryOSDTextFieldSpecified;
        
        private bool eXICompressionField;
        
        private bool eXICompressionFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public StreamingCapabilities StreamingCapabilities
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SnapshotUri
        {
            get
            {
                return this.snapshotUriField;
            }
            set
            {
                this.snapshotUriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SnapshotUriSpecified
        {
            get
            {
                return this.snapshotUriFieldSpecified;
            }
            set
            {
                this.snapshotUriFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RotationSpecified
        {
            get
            {
                return this.rotationFieldSpecified;
            }
            set
            {
                this.rotationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool VideoSourceMode
        {
            get
            {
                return this.videoSourceModeField;
            }
            set
            {
                this.videoSourceModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VideoSourceModeSpecified
        {
            get
            {
                return this.videoSourceModeFieldSpecified;
            }
            set
            {
                this.videoSourceModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OSD
        {
            get
            {
                return this.oSDField;
            }
            set
            {
                this.oSDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OSDSpecified
        {
            get
            {
                return this.oSDFieldSpecified;
            }
            set
            {
                this.oSDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TemporaryOSDText
        {
            get
            {
                return this.temporaryOSDTextField;
            }
            set
            {
                this.temporaryOSDTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TemporaryOSDTextSpecified
        {
            get
            {
                return this.temporaryOSDTextFieldSpecified;
            }
            set
            {
                this.temporaryOSDTextFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EXICompression
        {
            get
            {
                return this.eXICompressionField;
            }
            set
            {
                this.eXICompressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EXICompressionSpecified
        {
            get
            {
                return this.eXICompressionFieldSpecified;
            }
            set
            {
                this.eXICompressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl")]
    public partial class ProfileCapabilities
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private int maximumNumberOfProfilesField;
        
        private bool maximumNumberOfProfilesFieldSpecified;
        
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumNumberOfProfilesSpecified
        {
            get
            {
                return this.maximumNumberOfProfilesFieldSpecified;
            }
            set
            {
                this.maximumNumberOfProfilesFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDConfigurationOptionsExtension
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
    public partial class OSDImgOptionsExtension
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
    public partial class OSDImgOptions
    {
        
        private string[] imagePathField;
        
        private OSDImgOptionsExtension extensionField;
        
        private string[] formatsSupportedField;
        
        private int maxSizeField;
        
        private bool maxSizeFieldSpecified;
        
        private int maxWidthField;
        
        private bool maxWidthFieldSpecified;
        
        private int maxHeightField;
        
        private bool maxHeightFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImagePath", DataType="anyURI", Order=0)]
        public string[] ImagePath
        {
            get
            {
                return this.imagePathField;
            }
            set
            {
                this.imagePathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public OSDImgOptionsExtension Extension
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
        public string[] FormatsSupported
        {
            get
            {
                return this.formatsSupportedField;
            }
            set
            {
                this.formatsSupportedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxSize
        {
            get
            {
                return this.maxSizeField;
            }
            set
            {
                this.maxSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxSizeSpecified
        {
            get
            {
                return this.maxSizeFieldSpecified;
            }
            set
            {
                this.maxSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxWidth
        {
            get
            {
                return this.maxWidthField;
            }
            set
            {
                this.maxWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxWidthSpecified
        {
            get
            {
                return this.maxWidthFieldSpecified;
            }
            set
            {
                this.maxWidthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MaxHeight
        {
            get
            {
                return this.maxHeightField;
            }
            set
            {
                this.maxHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxHeightSpecified
        {
            get
            {
                return this.maxHeightFieldSpecified;
            }
            set
            {
                this.maxHeightFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDTextOptionsExtension
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
    public partial class OSDColorOptionsExtension
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
    public partial class ColorspaceRange
    {
        
        private FloatRange xField;
        
        private FloatRange yField;
        
        private FloatRange zField;
        
        private string colorspaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public FloatRange X
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public FloatRange Y
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public FloatRange Z
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=3)]
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
    public partial class ColorOptions
    {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ColorList", typeof(Color), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ColorspaceRange", typeof(ColorspaceRange), Order=0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
    public partial class OSDColorOptions
    {
        
        private ColorOptions colorField;
        
        private IntRange transparentField;
        
        private OSDColorOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ColorOptions Color
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IntRange Transparent
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public OSDColorOptionsExtension Extension
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
    public partial class IntRange
    {
        
        private int minField;
        
        private int maxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Min
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
        public int Max
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
    public partial class OSDTextOptions
    {
        
        private string[] typeField;
        
        private IntRange fontSizeRangeField;
        
        private string[] dateFormatField;
        
        private string[] timeFormatField;
        
        private OSDColorOptions fontColorField;
        
        private OSDColorOptions backgroundColorField;
        
        private OSDTextOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Type", Order=0)]
        public string[] Type
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
        public IntRange FontSizeRange
        {
            get
            {
                return this.fontSizeRangeField;
            }
            set
            {
                this.fontSizeRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DateFormat", Order=2)]
        public string[] DateFormat
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
        [System.Xml.Serialization.XmlElementAttribute("TimeFormat", Order=3)]
        public string[] TimeFormat
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public OSDColorOptions FontColor
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
        public OSDColorOptions BackgroundColor
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
        public OSDTextOptionsExtension Extension
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
    public partial class MaximumNumberOfOSDs
    {
        
        private int totalField;
        
        private int imageField;
        
        private bool imageFieldSpecified;
        
        private int plainTextField;
        
        private bool plainTextFieldSpecified;
        
        private int dateField;
        
        private bool dateFieldSpecified;
        
        private int timeField;
        
        private bool timeFieldSpecified;
        
        private int dateAndTimeField;
        
        private bool dateAndTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Image
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImageSpecified
        {
            get
            {
                return this.imageFieldSpecified;
            }
            set
            {
                this.imageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PlainText
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PlainTextSpecified
        {
            get
            {
                return this.plainTextFieldSpecified;
            }
            set
            {
                this.plainTextFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Date
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Time
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeSpecified
        {
            get
            {
                return this.timeFieldSpecified;
            }
            set
            {
                this.timeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DateAndTime
        {
            get
            {
                return this.dateAndTimeField;
            }
            set
            {
                this.dateAndTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateAndTimeSpecified
        {
            get
            {
                return this.dateAndTimeFieldSpecified;
            }
            set
            {
                this.dateAndTimeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class OSDConfigurationOptions
    {
        
        private MaximumNumberOfOSDs maximumNumberOfOSDsField;
        
        private OSDType[] typeField;
        
        private string[] positionOptionField;
        
        private OSDTextOptions textOptionField;
        
        private OSDImgOptions imageOptionField;
        
        private OSDConfigurationOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MaximumNumberOfOSDs MaximumNumberOfOSDs
        {
            get
            {
                return this.maximumNumberOfOSDsField;
            }
            set
            {
                this.maximumNumberOfOSDsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Type", Order=1)]
        public OSDType[] Type
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
        [System.Xml.Serialization.XmlElementAttribute("PositionOption", Order=2)]
        public string[] PositionOption
        {
            get
            {
                return this.positionOptionField;
            }
            set
            {
                this.positionOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public OSDTextOptions TextOption
        {
            get
            {
                return this.textOptionField;
            }
            set
            {
                this.textOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public OSDImgOptions ImageOption
        {
            get
            {
                return this.imageOptionField;
            }
            set
            {
                this.imageOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public OSDConfigurationOptionsExtension Extension
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl")]
    public partial class VideoSourceModeExtension
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl")]
    public partial class VideoSourceMode
    {
        
        private float maxFramerateField;
        
        private VideoResolution maxResolutionField;
        
        private string encodingsField;
        
        private bool rebootField;
        
        private string descriptionField;
        
        private VideoSourceModeExtension extensionField;
        
        private string tokenField;
        
        private bool enabledField;
        
        private bool enabledFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float MaxFramerate
        {
            get
            {
                return this.maxFramerateField;
            }
            set
            {
                this.maxFramerateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public VideoResolution MaxResolution
        {
            get
            {
                return this.maxResolutionField;
            }
            set
            {
                this.maxResolutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Encodings
        {
            get
            {
                return this.encodingsField;
            }
            set
            {
                this.encodingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool Reboot
        {
            get
            {
                return this.rebootField;
            }
            set
            {
                this.rebootField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public VideoSourceModeExtension Extension
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class MediaUri
    {
        
        private string uriField;
        
        private bool invalidAfterConnectField;
        
        private bool invalidAfterRebootField;
        
        private string timeoutField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool InvalidAfterConnect
        {
            get
            {
                return this.invalidAfterConnectField;
            }
            set
            {
                this.invalidAfterConnectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool InvalidAfterReboot
        {
            get
            {
                return this.invalidAfterRebootField;
            }
            set
            {
                this.invalidAfterRebootField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=3)]
        public string Timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
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
    public partial class Transport
    {
        
        private TransportProtocol protocolField;
        
        private Transport tunnelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TransportProtocol Protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Transport Tunnel
        {
            get
            {
                return this.tunnelField;
            }
            set
            {
                this.tunnelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum TransportProtocol
    {
        
        /// <remarks/>
        UDP,
        
        /// <remarks/>
        TCP,
        
        /// <remarks/>
        RTSP,
        
        /// <remarks/>
        HTTP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class StreamSetup
    {
        
        private StreamType streamField;
        
        private Transport transportField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StreamType Stream
        {
            get
            {
                return this.streamField;
            }
            set
            {
                this.streamField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Transport Transport
        {
            get
            {
                return this.transportField;
            }
            set
            {
                this.transportField = value;
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
    public enum StreamType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("RTP-Unicast")]
        RTPUnicast,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("RTP-Multicast")]
        RTPMulticast,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AudioDecoderConfigurationOptionsExtension
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
    public partial class G726DecOptions
    {
        
        private int[] bitrateField;
        
        private int[] sampleRateRangeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] Bitrate
        {
            get
            {
                return this.bitrateField;
            }
            set
            {
                this.bitrateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] SampleRateRange
        {
            get
            {
                return this.sampleRateRangeField;
            }
            set
            {
                this.sampleRateRangeField = value;
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
    public partial class G711DecOptions
    {
        
        private int[] bitrateField;
        
        private int[] sampleRateRangeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] Bitrate
        {
            get
            {
                return this.bitrateField;
            }
            set
            {
                this.bitrateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] SampleRateRange
        {
            get
            {
                return this.sampleRateRangeField;
            }
            set
            {
                this.sampleRateRangeField = value;
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
    public partial class AACDecOptions
    {
        
        private int[] bitrateField;
        
        private int[] sampleRateRangeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] Bitrate
        {
            get
            {
                return this.bitrateField;
            }
            set
            {
                this.bitrateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] SampleRateRange
        {
            get
            {
                return this.sampleRateRangeField;
            }
            set
            {
                this.sampleRateRangeField = value;
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
    public partial class AudioDecoderConfigurationOptions
    {
        
        private AACDecOptions aACDecOptionsField;
        
        private G711DecOptions g711DecOptionsField;
        
        private G726DecOptions g726DecOptionsField;
        
        private AudioDecoderConfigurationOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AACDecOptions AACDecOptions
        {
            get
            {
                return this.aACDecOptionsField;
            }
            set
            {
                this.aACDecOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public G711DecOptions G711DecOptions
        {
            get
            {
                return this.g711DecOptionsField;
            }
            set
            {
                this.g711DecOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public G726DecOptions G726DecOptions
        {
            get
            {
                return this.g726DecOptionsField;
            }
            set
            {
                this.g726DecOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public AudioDecoderConfigurationOptionsExtension Extension
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
    public partial class AudioOutputConfigurationOptions
    {
        
        private string[] outputTokensAvailableField;
        
        private string[] sendPrimacyOptionsField;
        
        private IntRange outputLevelRangeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutputTokensAvailable", Order=0)]
        public string[] OutputTokensAvailable
        {
            get
            {
                return this.outputTokensAvailableField;
            }
            set
            {
                this.outputTokensAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SendPrimacyOptions", DataType="anyURI", Order=1)]
        public string[] SendPrimacyOptions
        {
            get
            {
                return this.sendPrimacyOptionsField;
            }
            set
            {
                this.sendPrimacyOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public IntRange OutputLevelRange
        {
            get
            {
                return this.outputLevelRangeField;
            }
            set
            {
                this.outputLevelRangeField = value;
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
    public partial class MetadataConfigurationOptionsExtension2
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
    public partial class MetadataConfigurationOptionsExtension
    {
        
        private string[] compressionTypeField;
        
        private MetadataConfigurationOptionsExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompressionType", Order=0)]
        public string[] CompressionType
        {
            get
            {
                return this.compressionTypeField;
            }
            set
            {
                this.compressionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MetadataConfigurationOptionsExtension2 Extension
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
    public partial class PTZStatusFilterOptionsExtension
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
    public partial class PTZStatusFilterOptions
    {
        
        private bool panTiltStatusSupportedField;
        
        private bool zoomStatusSupportedField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private bool panTiltPositionSupportedField;
        
        private bool panTiltPositionSupportedFieldSpecified;
        
        private bool zoomPositionSupportedField;
        
        private bool zoomPositionSupportedFieldSpecified;
        
        private PTZStatusFilterOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool PanTiltStatusSupported
        {
            get
            {
                return this.panTiltStatusSupportedField;
            }
            set
            {
                this.panTiltStatusSupportedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool ZoomStatusSupported
        {
            get
            {
                return this.zoomStatusSupportedField;
            }
            set
            {
                this.zoomStatusSupportedField = value;
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
        public bool PanTiltPositionSupported
        {
            get
            {
                return this.panTiltPositionSupportedField;
            }
            set
            {
                this.panTiltPositionSupportedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PanTiltPositionSupportedSpecified
        {
            get
            {
                return this.panTiltPositionSupportedFieldSpecified;
            }
            set
            {
                this.panTiltPositionSupportedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool ZoomPositionSupported
        {
            get
            {
                return this.zoomPositionSupportedField;
            }
            set
            {
                this.zoomPositionSupportedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZoomPositionSupportedSpecified
        {
            get
            {
                return this.zoomPositionSupportedFieldSpecified;
            }
            set
            {
                this.zoomPositionSupportedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public PTZStatusFilterOptionsExtension Extension
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
    public partial class MetadataConfigurationOptions
    {
        
        private PTZStatusFilterOptions pTZStatusFilterOptionsField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private MetadataConfigurationOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PTZStatusFilterOptions PTZStatusFilterOptions
        {
            get
            {
                return this.pTZStatusFilterOptionsField;
            }
            set
            {
                this.pTZStatusFilterOptionsField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public MetadataConfigurationOptionsExtension Extension
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
    public partial class AudioEncoderConfigurationOption
    {
        
        private AudioEncoding encodingField;
        
        private int[] bitrateListField;
        
        private int[] sampleRateListField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AudioEncoding Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] BitrateList
        {
            get
            {
                return this.bitrateListField;
            }
            set
            {
                this.bitrateListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] SampleRateList
        {
            get
            {
                return this.sampleRateListField;
            }
            set
            {
                this.sampleRateListField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum AudioEncoding
    {
        
        /// <remarks/>
        G711,
        
        /// <remarks/>
        G726,
        
        /// <remarks/>
        AAC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AudioEncoderConfigurationOptions
    {
        
        private AudioEncoderConfigurationOption[] optionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Options", Order=0)]
        public AudioEncoderConfigurationOption[] Options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AudioSourceOptionsExtension
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
    public partial class AudioSourceConfigurationOptions
    {
        
        private string[] inputTokensAvailableField;
        
        private AudioSourceOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InputTokensAvailable", Order=0)]
        public string[] InputTokensAvailable
        {
            get
            {
                return this.inputTokensAvailableField;
            }
            set
            {
                this.inputTokensAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AudioSourceOptionsExtension Extension
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
    public partial class VideoEncoderOptionsExtension2
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
    public partial class VideoEncoderOptionsExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private JpegOptions2 jPEGField;
        
        private Mpeg4Options2 mPEG4Field;
        
        private H264Options2 h264Field;
        
        private VideoEncoderOptionsExtension2 extensionField;
        
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
        public JpegOptions2 JPEG
        {
            get
            {
                return this.jPEGField;
            }
            set
            {
                this.jPEGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Mpeg4Options2 MPEG4
        {
            get
            {
                return this.mPEG4Field;
            }
            set
            {
                this.mPEG4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public H264Options2 H264
        {
            get
            {
                return this.h264Field;
            }
            set
            {
                this.h264Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public VideoEncoderOptionsExtension2 Extension
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
    public partial class JpegOptions2 : JpegOptions
    {
        
        private IntRange bitrateRangeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IntRange BitrateRange
        {
            get
            {
                return this.bitrateRangeField;
            }
            set
            {
                this.bitrateRangeField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JpegOptions2))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class JpegOptions
    {
        
        private VideoResolution[] resolutionsAvailableField;
        
        private IntRange frameRateRangeField;
        
        private IntRange encodingIntervalRangeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResolutionsAvailable", Order=0)]
        public VideoResolution[] ResolutionsAvailable
        {
            get
            {
                return this.resolutionsAvailableField;
            }
            set
            {
                this.resolutionsAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IntRange FrameRateRange
        {
            get
            {
                return this.frameRateRangeField;
            }
            set
            {
                this.frameRateRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public IntRange EncodingIntervalRange
        {
            get
            {
                return this.encodingIntervalRangeField;
            }
            set
            {
                this.encodingIntervalRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Mpeg4Options2 : Mpeg4Options
    {
        
        private IntRange bitrateRangeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IntRange BitrateRange
        {
            get
            {
                return this.bitrateRangeField;
            }
            set
            {
                this.bitrateRangeField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Mpeg4Options2))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Mpeg4Options
    {
        
        private VideoResolution[] resolutionsAvailableField;
        
        private IntRange govLengthRangeField;
        
        private IntRange frameRateRangeField;
        
        private IntRange encodingIntervalRangeField;
        
        private Mpeg4Profile[] mpeg4ProfilesSupportedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResolutionsAvailable", Order=0)]
        public VideoResolution[] ResolutionsAvailable
        {
            get
            {
                return this.resolutionsAvailableField;
            }
            set
            {
                this.resolutionsAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IntRange GovLengthRange
        {
            get
            {
                return this.govLengthRangeField;
            }
            set
            {
                this.govLengthRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public IntRange FrameRateRange
        {
            get
            {
                return this.frameRateRangeField;
            }
            set
            {
                this.frameRateRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IntRange EncodingIntervalRange
        {
            get
            {
                return this.encodingIntervalRangeField;
            }
            set
            {
                this.encodingIntervalRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mpeg4ProfilesSupported", Order=4)]
        public Mpeg4Profile[] Mpeg4ProfilesSupported
        {
            get
            {
                return this.mpeg4ProfilesSupportedField;
            }
            set
            {
                this.mpeg4ProfilesSupportedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum Mpeg4Profile
    {
        
        /// <remarks/>
        SP,
        
        /// <remarks/>
        ASP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class H264Options2 : H264Options
    {
        
        private IntRange bitrateRangeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IntRange BitrateRange
        {
            get
            {
                return this.bitrateRangeField;
            }
            set
            {
                this.bitrateRangeField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(H264Options2))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class H264Options
    {
        
        private VideoResolution[] resolutionsAvailableField;
        
        private IntRange govLengthRangeField;
        
        private IntRange frameRateRangeField;
        
        private IntRange encodingIntervalRangeField;
        
        private H264Profile[] h264ProfilesSupportedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResolutionsAvailable", Order=0)]
        public VideoResolution[] ResolutionsAvailable
        {
            get
            {
                return this.resolutionsAvailableField;
            }
            set
            {
                this.resolutionsAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IntRange GovLengthRange
        {
            get
            {
                return this.govLengthRangeField;
            }
            set
            {
                this.govLengthRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public IntRange FrameRateRange
        {
            get
            {
                return this.frameRateRangeField;
            }
            set
            {
                this.frameRateRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IntRange EncodingIntervalRange
        {
            get
            {
                return this.encodingIntervalRangeField;
            }
            set
            {
                this.encodingIntervalRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("H264ProfilesSupported", Order=4)]
        public H264Profile[] H264ProfilesSupported
        {
            get
            {
                return this.h264ProfilesSupportedField;
            }
            set
            {
                this.h264ProfilesSupportedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum H264Profile
    {
        
        /// <remarks/>
        Baseline,
        
        /// <remarks/>
        Main,
        
        /// <remarks/>
        Extended,
        
        /// <remarks/>
        High,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoEncoderConfigurationOptions
    {
        
        private IntRange qualityRangeField;
        
        private JpegOptions jPEGField;
        
        private Mpeg4Options mPEG4Field;
        
        private H264Options h264Field;
        
        private VideoEncoderOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IntRange QualityRange
        {
            get
            {
                return this.qualityRangeField;
            }
            set
            {
                this.qualityRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public JpegOptions JPEG
        {
            get
            {
                return this.jPEGField;
            }
            set
            {
                this.jPEGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Mpeg4Options MPEG4
        {
            get
            {
                return this.mPEG4Field;
            }
            set
            {
                this.mPEG4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public H264Options H264
        {
            get
            {
                return this.h264Field;
            }
            set
            {
                this.h264Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public VideoEncoderOptionsExtension Extension
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
    public partial class VideoSourceConfigurationOptionsExtension2
    {
        
        private SceneOrientationMode[] sceneOrientationModeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SceneOrientationMode", Order=0)]
        public SceneOrientationMode[] SceneOrientationMode
        {
            get
            {
                return this.sceneOrientationModeField;
            }
            set
            {
                this.sceneOrientationModeField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum SceneOrientationMode
    {
        
        /// <remarks/>
        MANUAL,
        
        /// <remarks/>
        AUTO,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class RotateOptionsExtension
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
    public partial class RotateOptions
    {
        
        private RotateMode[] modeField;
        
        private int[] degreeListField;
        
        private RotateOptionsExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mode", Order=0)]
        public RotateMode[] Mode
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
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Items", IsNullable=false)]
        public int[] DegreeList
        {
            get
            {
                return this.degreeListField;
            }
            set
            {
                this.degreeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RotateOptionsExtension Extension
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
    public enum RotateMode
    {
        
        /// <remarks/>
        OFF,
        
        /// <remarks/>
        ON,
        
        /// <remarks/>
        AUTO,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoSourceConfigurationOptionsExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private RotateOptions rotateField;
        
        private VideoSourceConfigurationOptionsExtension2 extensionField;
        
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
        public RotateOptions Rotate
        {
            get
            {
                return this.rotateField;
            }
            set
            {
                this.rotateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public VideoSourceConfigurationOptionsExtension2 Extension
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
    public partial class IntRectangleRange
    {
        
        private IntRange xRangeField;
        
        private IntRange yRangeField;
        
        private IntRange widthRangeField;
        
        private IntRange heightRangeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IntRange XRange
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IntRange YRange
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public IntRange WidthRange
        {
            get
            {
                return this.widthRangeField;
            }
            set
            {
                this.widthRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public IntRange HeightRange
        {
            get
            {
                return this.heightRangeField;
            }
            set
            {
                this.heightRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoSourceConfigurationOptions
    {
        
        private IntRectangleRange boundsRangeField;
        
        private string[] videoSourceTokensAvailableField;
        
        private VideoSourceConfigurationOptionsExtension extensionField;
        
        private int maximumNumberOfProfilesField;
        
        private bool maximumNumberOfProfilesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IntRectangleRange BoundsRange
        {
            get
            {
                return this.boundsRangeField;
            }
            set
            {
                this.boundsRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VideoSourceTokensAvailable", Order=1)]
        public string[] VideoSourceTokensAvailable
        {
            get
            {
                return this.videoSourceTokensAvailableField;
            }
            set
            {
                this.videoSourceTokensAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public VideoSourceConfigurationOptionsExtension Extension
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumNumberOfProfilesSpecified
        {
            get
            {
                return this.maximumNumberOfProfilesFieldSpecified;
            }
            set
            {
                this.maximumNumberOfProfilesFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ProfileExtension2
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
    public partial class ProfileExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private AudioOutputConfiguration audioOutputConfigurationField;
        
        private AudioDecoderConfiguration audioDecoderConfigurationField;
        
        private ProfileExtension2 extensionField;
        
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
        public AudioOutputConfiguration AudioOutputConfiguration
        {
            get
            {
                return this.audioOutputConfigurationField;
            }
            set
            {
                this.audioOutputConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public AudioDecoderConfiguration AudioDecoderConfiguration
        {
            get
            {
                return this.audioDecoderConfigurationField;
            }
            set
            {
                this.audioDecoderConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ProfileExtension2 Extension
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
    public partial class AudioOutputConfiguration : ConfigurationEntity
    {
        
        private string outputTokenField;
        
        private string sendPrimacyField;
        
        private int outputLevelField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string OutputToken
        {
            get
            {
                return this.outputTokenField;
            }
            set
            {
                this.outputTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string SendPrimacy
        {
            get
            {
                return this.sendPrimacyField;
            }
            set
            {
                this.sendPrimacyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int OutputLevel
        {
            get
            {
                return this.outputLevelField;
            }
            set
            {
                this.outputLevelField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnalyticsEngineControl))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnalyticsEngineInput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnalyticsEngine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PTZConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioDecoderConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioOutputConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoOutputConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MetadataConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoAnalyticsConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioEncoder2Configuration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioEncoderConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioSourceConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoEncoder2Configuration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoEncoderConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoSourceConfiguration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ConfigurationEntity
    {
        
        private string nameField;
        
        private int useCountField;
        
        private string tokenField;
        
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
        public int UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }
        
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
    public partial class AnalyticsEngineControl : ConfigurationEntity
    {
        
        private string engineTokenField;
        
        private string engineConfigTokenField;
        
        private string[] inputTokenField;
        
        private string[] receiverTokenField;
        
        private MulticastConfiguration multicastField;
        
        private Config subscriptionField;
        
        private ModeOfOperation modeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string EngineToken
        {
            get
            {
                return this.engineTokenField;
            }
            set
            {
                this.engineTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string EngineConfigToken
        {
            get
            {
                return this.engineConfigTokenField;
            }
            set
            {
                this.engineConfigTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InputToken", Order=2)]
        public string[] InputToken
        {
            get
            {
                return this.inputTokenField;
            }
            set
            {
                this.inputTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiverToken", Order=3)]
        public string[] ReceiverToken
        {
            get
            {
                return this.receiverTokenField;
            }
            set
            {
                this.receiverTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public MulticastConfiguration Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public Config Subscription
        {
            get
            {
                return this.subscriptionField;
            }
            set
            {
                this.subscriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public ModeOfOperation Mode
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
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=7)]
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
    public partial class MulticastConfiguration
    {
        
        private IPAddress addressField;
        
        private int portField;
        
        private int tTLField;
        
        private bool autoStartField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IPAddress Address
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
        public int Port
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int TTL
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
        public bool AutoStart
        {
            get
            {
                return this.autoStartField;
            }
            set
            {
                this.autoStartField = value;
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
    public partial class Config
    {
        
        private ItemList parametersField;
        
        private string nameField;
        
        private System.Xml.XmlQualifiedName typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ItemList Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName Type
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ItemList
    {
        
        private ItemListSimpleItem[] simpleItemField;
        
        private ItemListElementItem[] elementItemField;
        
        private ItemListExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SimpleItem", Order=0)]
        public ItemListSimpleItem[] SimpleItem
        {
            get
            {
                return this.simpleItemField;
            }
            set
            {
                this.simpleItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElementItem", Order=1)]
        public ItemListElementItem[] ElementItem
        {
            get
            {
                return this.elementItemField;
            }
            set
            {
                this.elementItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ItemListExtension Extension
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ItemListSimpleItem
    {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ItemListElementItem
    {
        
        private System.Xml.Linq.XElement anyField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.Linq.XElement Any
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class ItemListExtension
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum ModeOfOperation
    {
        
        /// <remarks/>
        Idle,
        
        /// <remarks/>
        Active,
        
        /// <remarks/>
        Unknown,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class AnalyticsEngineInput : ConfigurationEntity
    {
        
        private SourceIdentification sourceIdentificationField;
        
        private VideoEncoderConfiguration videoInputField;
        
        private MetadataInput metadataInputField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SourceIdentification SourceIdentification
        {
            get
            {
                return this.sourceIdentificationField;
            }
            set
            {
                this.sourceIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public VideoEncoderConfiguration VideoInput
        {
            get
            {
                return this.videoInputField;
            }
            set
            {
                this.videoInputField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public MetadataInput MetadataInput
        {
            get
            {
                return this.metadataInputField;
            }
            set
            {
                this.metadataInputField = value;
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
    public partial class SourceIdentification
    {
        
        private string nameField;
        
        private string[] tokenField;
        
        private SourceIdentificationExtension extensionField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("Token", Order=1)]
        public string[] Token
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SourceIdentificationExtension Extension
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
    public partial class SourceIdentificationExtension
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
    public partial class VideoEncoderConfiguration : ConfigurationEntity
    {
        
        private VideoEncoding encodingField;
        
        private VideoResolution resolutionField;
        
        private float qualityField;
        
        private VideoRateControl rateControlField;
        
        private Mpeg4Configuration mPEG4Field;
        
        private H264Configuration h264Field;
        
        private MulticastConfiguration multicastField;
        
        private string sessionTimeoutField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public VideoEncoding Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
        public float Quality
        {
            get
            {
                return this.qualityField;
            }
            set
            {
                this.qualityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public VideoRateControl RateControl
        {
            get
            {
                return this.rateControlField;
            }
            set
            {
                this.rateControlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Mpeg4Configuration MPEG4
        {
            get
            {
                return this.mPEG4Field;
            }
            set
            {
                this.mPEG4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public H264Configuration H264
        {
            get
            {
                return this.h264Field;
            }
            set
            {
                this.h264Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public MulticastConfiguration Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=7)]
        public string SessionTimeout
        {
            get
            {
                return this.sessionTimeoutField;
            }
            set
            {
                this.sessionTimeoutField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum VideoEncoding
    {
        
        /// <remarks/>
        JPEG,
        
        /// <remarks/>
        MPEG4,
        
        /// <remarks/>
        H264,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoRateControl
    {
        
        private int frameRateLimitField;
        
        private int encodingIntervalField;
        
        private int bitrateLimitField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int FrameRateLimit
        {
            get
            {
                return this.frameRateLimitField;
            }
            set
            {
                this.frameRateLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int EncodingInterval
        {
            get
            {
                return this.encodingIntervalField;
            }
            set
            {
                this.encodingIntervalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int BitrateLimit
        {
            get
            {
                return this.bitrateLimitField;
            }
            set
            {
                this.bitrateLimitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Mpeg4Configuration
    {
        
        private int govLengthField;
        
        private Mpeg4Profile mpeg4ProfileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int GovLength
        {
            get
            {
                return this.govLengthField;
            }
            set
            {
                this.govLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Mpeg4Profile Mpeg4Profile
        {
            get
            {
                return this.mpeg4ProfileField;
            }
            set
            {
                this.mpeg4ProfileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class H264Configuration
    {
        
        private int govLengthField;
        
        private H264Profile h264ProfileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int GovLength
        {
            get
            {
                return this.govLengthField;
            }
            set
            {
                this.govLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public H264Profile H264Profile
        {
            get
            {
                return this.h264ProfileField;
            }
            set
            {
                this.h264ProfileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class MetadataInput
    {
        
        private Config[] metadataConfigField;
        
        private MetadataInputExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MetadataConfig", Order=0)]
        public Config[] MetadataConfig
        {
            get
            {
                return this.metadataConfigField;
            }
            set
            {
                this.metadataConfigField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MetadataInputExtension Extension
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
    public partial class MetadataInputExtension
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
    public partial class AnalyticsEngine : ConfigurationEntity
    {
        
        private AnalyticsDeviceEngineConfiguration analyticsEngineConfigurationField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AnalyticsDeviceEngineConfiguration AnalyticsEngineConfiguration
        {
            get
            {
                return this.analyticsEngineConfigurationField;
            }
            set
            {
                this.analyticsEngineConfigurationField = value;
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
    public partial class AnalyticsDeviceEngineConfiguration
    {
        
        private EngineConfiguration[] engineConfigurationField;
        
        private AnalyticsDeviceEngineConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EngineConfiguration", Order=0)]
        public EngineConfiguration[] EngineConfiguration
        {
            get
            {
                return this.engineConfigurationField;
            }
            set
            {
                this.engineConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AnalyticsDeviceEngineConfigurationExtension Extension
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
    public partial class EngineConfiguration
    {
        
        private VideoAnalyticsConfiguration videoAnalyticsConfigurationField;
        
        private AnalyticsEngineInputInfo analyticsEngineInputInfoField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public VideoAnalyticsConfiguration VideoAnalyticsConfiguration
        {
            get
            {
                return this.videoAnalyticsConfigurationField;
            }
            set
            {
                this.videoAnalyticsConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AnalyticsEngineInputInfo AnalyticsEngineInputInfo
        {
            get
            {
                return this.analyticsEngineInputInfoField;
            }
            set
            {
                this.analyticsEngineInputInfoField = value;
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
    public partial class VideoAnalyticsConfiguration : ConfigurationEntity
    {
        
        private AnalyticsEngineConfiguration analyticsEngineConfigurationField;
        
        private RuleEngineConfiguration ruleEngineConfigurationField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AnalyticsEngineConfiguration AnalyticsEngineConfiguration
        {
            get
            {
                return this.analyticsEngineConfigurationField;
            }
            set
            {
                this.analyticsEngineConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public RuleEngineConfiguration RuleEngineConfiguration
        {
            get
            {
                return this.ruleEngineConfigurationField;
            }
            set
            {
                this.ruleEngineConfigurationField = value;
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
    public partial class AnalyticsEngineConfiguration
    {
        
        private Config[] analyticsModuleField;
        
        private AnalyticsEngineConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnalyticsModule", Order=0)]
        public Config[] AnalyticsModule
        {
            get
            {
                return this.analyticsModuleField;
            }
            set
            {
                this.analyticsModuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AnalyticsEngineConfigurationExtension Extension
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
    public partial class AnalyticsEngineConfigurationExtension
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
    public partial class RuleEngineConfiguration
    {
        
        private Config[] ruleField;
        
        private RuleEngineConfigurationExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rule", Order=0)]
        public Config[] Rule
        {
            get
            {
                return this.ruleField;
            }
            set
            {
                this.ruleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public RuleEngineConfigurationExtension Extension
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
    public partial class RuleEngineConfigurationExtension
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
    public partial class AnalyticsEngineInputInfo
    {
        
        private Config inputInfoField;
        
        private AnalyticsEngineInputInfoExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Config InputInfo
        {
            get
            {
                return this.inputInfoField;
            }
            set
            {
                this.inputInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AnalyticsEngineInputInfoExtension Extension
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
    public partial class AnalyticsEngineInputInfoExtension
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
    public partial class AnalyticsDeviceEngineConfigurationExtension
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
    public partial class PTZConfiguration : ConfigurationEntity
    {
        
        private string nodeTokenField;
        
        private string defaultAbsolutePantTiltPositionSpaceField;
        
        private string defaultAbsoluteZoomPositionSpaceField;
        
        private string defaultRelativePanTiltTranslationSpaceField;
        
        private string defaultRelativeZoomTranslationSpaceField;
        
        private string defaultContinuousPanTiltVelocitySpaceField;
        
        private string defaultContinuousZoomVelocitySpaceField;
        
        private PTZSpeed defaultPTZSpeedField;
        
        private string defaultPTZTimeoutField;
        
        private PanTiltLimits panTiltLimitsField;
        
        private ZoomLimits zoomLimitsField;
        
        private PTZConfigurationExtension extensionField;
        
        private int moveRampField;
        
        private bool moveRampFieldSpecified;
        
        private int presetRampField;
        
        private bool presetRampFieldSpecified;
        
        private int presetTourRampField;
        
        private bool presetTourRampFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NodeToken
        {
            get
            {
                return this.nodeTokenField;
            }
            set
            {
                this.nodeTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string DefaultAbsolutePantTiltPositionSpace
        {
            get
            {
                return this.defaultAbsolutePantTiltPositionSpaceField;
            }
            set
            {
                this.defaultAbsolutePantTiltPositionSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=2)]
        public string DefaultAbsoluteZoomPositionSpace
        {
            get
            {
                return this.defaultAbsoluteZoomPositionSpaceField;
            }
            set
            {
                this.defaultAbsoluteZoomPositionSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=3)]
        public string DefaultRelativePanTiltTranslationSpace
        {
            get
            {
                return this.defaultRelativePanTiltTranslationSpaceField;
            }
            set
            {
                this.defaultRelativePanTiltTranslationSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=4)]
        public string DefaultRelativeZoomTranslationSpace
        {
            get
            {
                return this.defaultRelativeZoomTranslationSpaceField;
            }
            set
            {
                this.defaultRelativeZoomTranslationSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=5)]
        public string DefaultContinuousPanTiltVelocitySpace
        {
            get
            {
                return this.defaultContinuousPanTiltVelocitySpaceField;
            }
            set
            {
                this.defaultContinuousPanTiltVelocitySpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=6)]
        public string DefaultContinuousZoomVelocitySpace
        {
            get
            {
                return this.defaultContinuousZoomVelocitySpaceField;
            }
            set
            {
                this.defaultContinuousZoomVelocitySpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public PTZSpeed DefaultPTZSpeed
        {
            get
            {
                return this.defaultPTZSpeedField;
            }
            set
            {
                this.defaultPTZSpeedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=8)]
        public string DefaultPTZTimeout
        {
            get
            {
                return this.defaultPTZTimeoutField;
            }
            set
            {
                this.defaultPTZTimeoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public PanTiltLimits PanTiltLimits
        {
            get
            {
                return this.panTiltLimitsField;
            }
            set
            {
                this.panTiltLimitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public ZoomLimits ZoomLimits
        {
            get
            {
                return this.zoomLimitsField;
            }
            set
            {
                this.zoomLimitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public PTZConfigurationExtension Extension
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
        public int MoveRamp
        {
            get
            {
                return this.moveRampField;
            }
            set
            {
                this.moveRampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MoveRampSpecified
        {
            get
            {
                return this.moveRampFieldSpecified;
            }
            set
            {
                this.moveRampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PresetRamp
        {
            get
            {
                return this.presetRampField;
            }
            set
            {
                this.presetRampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PresetRampSpecified
        {
            get
            {
                return this.presetRampFieldSpecified;
            }
            set
            {
                this.presetRampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PresetTourRamp
        {
            get
            {
                return this.presetTourRampField;
            }
            set
            {
                this.presetTourRampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PresetTourRampSpecified
        {
            get
            {
                return this.presetTourRampFieldSpecified;
            }
            set
            {
                this.presetTourRampFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZSpeed
    {
        
        private Vector2D panTiltField;
        
        private Vector1D zoomField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Vector2D PanTilt
        {
            get
            {
                return this.panTiltField;
            }
            set
            {
                this.panTiltField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Vector1D Zoom
        {
            get
            {
                return this.zoomField;
            }
            set
            {
                this.zoomField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Vector2D
    {
        
        private float xField;
        
        private float yField;
        
        private string spaceField;
        
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Vector1D
    {
        
        private float xField;
        
        private string spaceField;
        
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PanTiltLimits
    {
        
        private Space2DDescription rangeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Space2DDescription Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
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
    public partial class ZoomLimits
    {
        
        private Space1DDescription rangeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Space1DDescription Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
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
    public partial class PTZConfigurationExtension
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private PTControlDirection pTControlDirectionField;
        
        private PTZConfigurationExtension2 extensionField;
        
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
        public PTControlDirection PTControlDirection
        {
            get
            {
                return this.pTControlDirectionField;
            }
            set
            {
                this.pTControlDirectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public PTZConfigurationExtension2 Extension
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
    public partial class PTControlDirection
    {
        
        private EFlip eFlipField;
        
        private Reverse reverseField;
        
        private PTControlDirectionExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EFlip EFlip
        {
            get
            {
                return this.eFlipField;
            }
            set
            {
                this.eFlipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Reverse Reverse
        {
            get
            {
                return this.reverseField;
            }
            set
            {
                this.reverseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public PTControlDirectionExtension Extension
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
    public partial class EFlip
    {
        
        private EFlipMode modeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EFlipMode Mode
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum EFlipMode
    {
        
        /// <remarks/>
        OFF,
        
        /// <remarks/>
        ON,
        
        /// <remarks/>
        Extended,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Reverse
    {
        
        private ReverseMode modeField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReverseMode Mode
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public enum ReverseMode
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
    public partial class PTControlDirectionExtension
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
    public partial class PTZConfigurationExtension2
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
    public partial class AudioDecoderConfiguration : ConfigurationEntity
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
    public partial class VideoOutputConfiguration : ConfigurationEntity
    {
        
        private string outputTokenField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string OutputToken
        {
            get
            {
                return this.outputTokenField;
            }
            set
            {
                this.outputTokenField = value;
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
    public partial class MetadataConfiguration : ConfigurationEntity
    {
        
        private PTZFilter pTZStatusField;
        
        private EventSubscription eventsField;
        
        private bool analyticsField;
        
        private bool analyticsFieldSpecified;
        
        private MulticastConfiguration multicastField;
        
        private string sessionTimeoutField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private AnalyticsEngineConfiguration analyticsEngineConfigurationField;
        
        private MetadataConfigurationExtension extensionField;
        
        private string compressionTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PTZFilter PTZStatus
        {
            get
            {
                return this.pTZStatusField;
            }
            set
            {
                this.pTZStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public EventSubscription Events
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool Analytics
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnalyticsSpecified
        {
            get
            {
                return this.analyticsFieldSpecified;
            }
            set
            {
                this.analyticsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MulticastConfiguration Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=4)]
        public string SessionTimeout
        {
            get
            {
                return this.sessionTimeoutField;
            }
            set
            {
                this.sessionTimeoutField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public AnalyticsEngineConfiguration AnalyticsEngineConfiguration
        {
            get
            {
                return this.analyticsEngineConfigurationField;
            }
            set
            {
                this.analyticsEngineConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public MetadataConfigurationExtension Extension
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
        public string CompressionType
        {
            get
            {
                return this.compressionTypeField;
            }
            set
            {
                this.compressionTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class PTZFilter
    {
        
        private bool statusField;
        
        private bool positionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool Position
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class EventSubscription
    {
        
        private FilterType filterField;
        
        private EventSubscriptionSubscriptionPolicy subscriptionPolicyField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public FilterType Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public EventSubscriptionSubscriptionPolicy SubscriptionPolicy
        {
            get
            {
                return this.subscriptionPolicyField;
            }
            set
            {
                this.subscriptionPolicyField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EventFilter))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/b-2")]
    public partial class FilterType
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
    public partial class EventFilter : FilterType
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.onvif.org/ver10/schema")]
    public partial class EventSubscriptionSubscriptionPolicy
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
    public partial class MetadataConfigurationExtension
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
    public partial class AudioEncoder2Configuration : ConfigurationEntity
    {
        
        private string encodingField;
        
        private MulticastConfiguration multicastField;
        
        private int bitrateField;
        
        private int sampleRateField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MulticastConfiguration Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Bitrate
        {
            get
            {
                return this.bitrateField;
            }
            set
            {
                this.bitrateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int SampleRate
        {
            get
            {
                return this.sampleRateField;
            }
            set
            {
                this.sampleRateField = value;
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
    public partial class AudioEncoderConfiguration : ConfigurationEntity
    {
        
        private AudioEncoding encodingField;
        
        private int bitrateField;
        
        private int sampleRateField;
        
        private MulticastConfiguration multicastField;
        
        private string sessionTimeoutField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AudioEncoding Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Bitrate
        {
            get
            {
                return this.bitrateField;
            }
            set
            {
                this.bitrateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int SampleRate
        {
            get
            {
                return this.sampleRateField;
            }
            set
            {
                this.sampleRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MulticastConfiguration Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=4)]
        public string SessionTimeout
        {
            get
            {
                return this.sessionTimeoutField;
            }
            set
            {
                this.sessionTimeoutField = value;
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
    public partial class AudioSourceConfiguration : ConfigurationEntity
    {
        
        private string sourceTokenField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SourceToken
        {
            get
            {
                return this.sourceTokenField;
            }
            set
            {
                this.sourceTokenField = value;
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
    public partial class VideoEncoder2Configuration : ConfigurationEntity
    {
        
        private string encodingField;
        
        private VideoResolution2 resolutionField;
        
        private VideoRateControl2 rateControlField;
        
        private MulticastConfiguration multicastField;
        
        private float qualityField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private int govLengthField;
        
        private bool govLengthFieldSpecified;
        
        private string profileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public VideoResolution2 Resolution
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
        public VideoRateControl2 RateControl
        {
            get
            {
                return this.rateControlField;
            }
            set
            {
                this.rateControlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MulticastConfiguration Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public float Quality
        {
            get
            {
                return this.qualityField;
            }
            set
            {
                this.qualityField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int GovLength
        {
            get
            {
                return this.govLengthField;
            }
            set
            {
                this.govLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GovLengthSpecified
        {
            get
            {
                return this.govLengthFieldSpecified;
            }
            set
            {
                this.govLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoResolution2
    {
        
        private int widthField;
        
        private int heightField;
        
        private System.Xml.Linq.XElement[] anyField;
        
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
    public partial class VideoRateControl2
    {
        
        private float frameRateLimitField;
        
        private int bitrateLimitField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private bool constantBitRateField;
        
        private bool constantBitRateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float FrameRateLimit
        {
            get
            {
                return this.frameRateLimitField;
            }
            set
            {
                this.frameRateLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int BitrateLimit
        {
            get
            {
                return this.bitrateLimitField;
            }
            set
            {
                this.bitrateLimitField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ConstantBitRate
        {
            get
            {
                return this.constantBitRateField;
            }
            set
            {
                this.constantBitRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConstantBitRateSpecified
        {
            get
            {
                return this.constantBitRateFieldSpecified;
            }
            set
            {
                this.constantBitRateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoSourceConfiguration : ConfigurationEntity
    {
        
        private string sourceTokenField;
        
        private IntRectangle boundsField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private VideoSourceConfigurationExtension extensionField;
        
        private string viewModeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SourceToken
        {
            get
            {
                return this.sourceTokenField;
            }
            set
            {
                this.sourceTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IntRectangle Bounds
        {
            get
            {
                return this.boundsField;
            }
            set
            {
                this.boundsField = value;
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
        public VideoSourceConfigurationExtension Extension
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
        public string ViewMode
        {
            get
            {
                return this.viewModeField;
            }
            set
            {
                this.viewModeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class IntRectangle
    {
        
        private int xField;
        
        private int yField;
        
        private int widthField;
        
        private int heightField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int x
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
        public int y
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
        public int width
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int height
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class VideoSourceConfigurationExtension
    {
        
        private Rotate rotateField;
        
        private VideoSourceConfigurationExtension2 extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Rotate Rotate
        {
            get
            {
                return this.rotateField;
            }
            set
            {
                this.rotateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public VideoSourceConfigurationExtension2 Extension
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
    public partial class Rotate
    {
        
        private RotateMode modeField;
        
        private int degreeField;
        
        private bool degreeFieldSpecified;
        
        private RotateExtension extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RotateMode Mode
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
        public int Degree
        {
            get
            {
                return this.degreeField;
            }
            set
            {
                this.degreeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DegreeSpecified
        {
            get
            {
                return this.degreeFieldSpecified;
            }
            set
            {
                this.degreeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RotateExtension Extension
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
    public partial class RotateExtension
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
    public partial class VideoSourceConfigurationExtension2
    {
        
        private LensDescription[] lensDescriptionField;
        
        private SceneOrientation sceneOrientationField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LensDescription", Order=0)]
        public LensDescription[] LensDescription
        {
            get
            {
                return this.lensDescriptionField;
            }
            set
            {
                this.lensDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SceneOrientation SceneOrientation
        {
            get
            {
                return this.sceneOrientationField;
            }
            set
            {
                this.sceneOrientationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.onvif.org/ver10/schema", Order=2)]
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
    public partial class LensDescription
    {
        
        private LensOffset offsetField;
        
        private LensProjection[] projectionField;
        
        private float xFactorField;
        
        private System.Xml.Linq.XElement[] anyField;
        
        private float focalLengthField;
        
        private bool focalLengthFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public LensOffset Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Projection", Order=1)]
        public LensProjection[] Projection
        {
            get
            {
                return this.projectionField;
            }
            set
            {
                this.projectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float XFactor
        {
            get
            {
                return this.xFactorField;
            }
            set
            {
                this.xFactorField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float FocalLength
        {
            get
            {
                return this.focalLengthField;
            }
            set
            {
                this.focalLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FocalLengthSpecified
        {
            get
            {
                return this.focalLengthFieldSpecified;
            }
            set
            {
                this.focalLengthFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class LensOffset
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
    public partial class LensProjection
    {
        
        private float angleField;
        
        private float radiusField;
        
        private float transmittanceField;
        
        private bool transmittanceFieldSpecified;
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float Angle
        {
            get
            {
                return this.angleField;
            }
            set
            {
                this.angleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public float Radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float Transmittance
        {
            get
            {
                return this.transmittanceField;
            }
            set
            {
                this.transmittanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransmittanceSpecified
        {
            get
            {
                return this.transmittanceFieldSpecified;
            }
            set
            {
                this.transmittanceFieldSpecified = value;
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
    public partial class SceneOrientation
    {
        
        private SceneOrientationMode modeField;
        
        private string orientationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SceneOrientationMode Mode
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
        public string Orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/schema")]
    public partial class Profile
    {
        
        private string nameField;
        
        private VideoSourceConfiguration videoSourceConfigurationField;
        
        private AudioSourceConfiguration audioSourceConfigurationField;
        
        private VideoEncoderConfiguration videoEncoderConfigurationField;
        
        private AudioEncoderConfiguration audioEncoderConfigurationField;
        
        private VideoAnalyticsConfiguration videoAnalyticsConfigurationField;
        
        private PTZConfiguration pTZConfigurationField;
        
        private MetadataConfiguration metadataConfigurationField;
        
        private ProfileExtension extensionField;
        
        private string tokenField;
        
        private bool fixedField;
        
        private bool fixedFieldSpecified;
        
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
        public VideoSourceConfiguration VideoSourceConfiguration
        {
            get
            {
                return this.videoSourceConfigurationField;
            }
            set
            {
                this.videoSourceConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public AudioSourceConfiguration AudioSourceConfiguration
        {
            get
            {
                return this.audioSourceConfigurationField;
            }
            set
            {
                this.audioSourceConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public VideoEncoderConfiguration VideoEncoderConfiguration
        {
            get
            {
                return this.videoEncoderConfigurationField;
            }
            set
            {
                this.videoEncoderConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public AudioEncoderConfiguration AudioEncoderConfiguration
        {
            get
            {
                return this.audioEncoderConfigurationField;
            }
            set
            {
                this.audioEncoderConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public VideoAnalyticsConfiguration VideoAnalyticsConfiguration
        {
            get
            {
                return this.videoAnalyticsConfigurationField;
            }
            set
            {
                this.videoAnalyticsConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public PTZConfiguration PTZConfiguration
        {
            get
            {
                return this.pTZConfigurationField;
            }
            set
            {
                this.pTZConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public MetadataConfiguration MetadataConfiguration
        {
            get
            {
                return this.metadataConfigurationField;
            }
            set
            {
                this.metadataConfigurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public ProfileExtension Extension
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @fixed
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
        public bool fixedSpecified
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OSDConfiguration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PTZNode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DigitalInput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelayOutput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioOutput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoOutput))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioSource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoSource))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl")]
    public partial class StreamingCapabilities
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private bool rTPMulticastField;
        
        private bool rTPMulticastFieldSpecified;
        
        private bool rTP_TCPField;
        
        private bool rTP_TCPFieldSpecified;
        
        private bool rTP_RTSP_TCPField;
        
        private bool rTP_RTSP_TCPFieldSpecified;
        
        private bool nonAggregateControlField;
        
        private bool nonAggregateControlFieldSpecified;
        
        private bool noRTSPStreamingField;
        
        private bool noRTSPStreamingFieldSpecified;
        
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonAggregateControl
        {
            get
            {
                return this.nonAggregateControlField;
            }
            set
            {
                this.nonAggregateControlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonAggregateControlSpecified
        {
            get
            {
                return this.nonAggregateControlFieldSpecified;
            }
            set
            {
                this.nonAggregateControlFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoRTSPStreaming
        {
            get
            {
                return this.noRTSPStreamingField;
            }
            set
            {
                this.noRTSPStreamingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoRTSPStreamingSpecified
        {
            get
            {
                return this.noRTSPStreamingFieldSpecified;
            }
            set
            {
                this.noRTSPStreamingFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSources", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourcesRequest
    {
        
        public GetVideoSourcesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourcesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourcesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("VideoSources")]
        public CameraMediaService.VideoSource[] VideoSources;
        
        public GetVideoSourcesResponse()
        {
        }
        
        public GetVideoSourcesResponse(CameraMediaService.VideoSource[] VideoSources)
        {
            this.VideoSources = VideoSources;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSources", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourcesRequest
    {
        
        public GetAudioSourcesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSourcesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourcesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AudioSources")]
        public CameraMediaService.AudioSource[] AudioSources;
        
        public GetAudioSourcesResponse()
        {
        }
        
        public GetAudioSourcesResponse(CameraMediaService.AudioSource[] AudioSources)
        {
            this.AudioSources = AudioSources;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputs", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputsRequest
    {
        
        public GetAudioOutputsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AudioOutputs")]
        public CameraMediaService.AudioOutput[] AudioOutputs;
        
        public GetAudioOutputsResponse()
        {
        }
        
        public GetAudioOutputsResponse(CameraMediaService.AudioOutput[] AudioOutputs)
        {
            this.AudioOutputs = AudioOutputs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProfiles", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetProfilesRequest
    {
        
        public GetProfilesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProfilesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetProfilesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Profiles")]
        public CameraMediaService.Profile[] Profiles;
        
        public GetProfilesResponse()
        {
        }
        
        public GetProfilesResponse(CameraMediaService.Profile[] Profiles)
        {
            this.Profiles = Profiles;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceConfigurationsRequest
    {
        
        public GetVideoSourceConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.VideoSourceConfiguration[] Configurations;
        
        public GetVideoSourceConfigurationsResponse()
        {
        }
        
        public GetVideoSourceConfigurationsResponse(CameraMediaService.VideoSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoEncoderConfigurationsRequest
    {
        
        public GetVideoEncoderConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.VideoEncoderConfiguration[] Configurations;
        
        public GetVideoEncoderConfigurationsResponse()
        {
        }
        
        public GetVideoEncoderConfigurationsResponse(CameraMediaService.VideoEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourceConfigurationsRequest
    {
        
        public GetAudioSourceConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioSourceConfiguration[] Configurations;
        
        public GetAudioSourceConfigurationsResponse()
        {
        }
        
        public GetAudioSourceConfigurationsResponse(CameraMediaService.AudioSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioEncoderConfigurationsRequest
    {
        
        public GetAudioEncoderConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioEncoderConfiguration[] Configurations;
        
        public GetAudioEncoderConfigurationsResponse()
        {
        }
        
        public GetAudioEncoderConfigurationsResponse(CameraMediaService.AudioEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoAnalyticsConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoAnalyticsConfigurationsRequest
    {
        
        public GetVideoAnalyticsConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoAnalyticsConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoAnalyticsConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.VideoAnalyticsConfiguration[] Configurations;
        
        public GetVideoAnalyticsConfigurationsResponse()
        {
        }
        
        public GetVideoAnalyticsConfigurationsResponse(CameraMediaService.VideoAnalyticsConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetadataConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetMetadataConfigurationsRequest
    {
        
        public GetMetadataConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetadataConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetMetadataConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.MetadataConfiguration[] Configurations;
        
        public GetMetadataConfigurationsResponse()
        {
        }
        
        public GetMetadataConfigurationsResponse(CameraMediaService.MetadataConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputConfigurationsRequest
    {
        
        public GetAudioOutputConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioOutputConfiguration[] Configurations;
        
        public GetAudioOutputConfigurationsResponse()
        {
        }
        
        public GetAudioOutputConfigurationsResponse(CameraMediaService.AudioOutputConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioDecoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioDecoderConfigurationsRequest
    {
        
        public GetAudioDecoderConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioDecoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioDecoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioDecoderConfiguration[] Configurations;
        
        public GetAudioDecoderConfigurationsResponse()
        {
        }
        
        public GetAudioDecoderConfigurationsResponse(CameraMediaService.AudioDecoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoEncoderConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleVideoEncoderConfigurationsRequest()
        {
        }
        
        public GetCompatibleVideoEncoderConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.VideoEncoderConfiguration[] Configurations;
        
        public GetCompatibleVideoEncoderConfigurationsResponse()
        {
        }
        
        public GetCompatibleVideoEncoderConfigurationsResponse(CameraMediaService.VideoEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoSourceConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleVideoSourceConfigurationsRequest()
        {
        }
        
        public GetCompatibleVideoSourceConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.VideoSourceConfiguration[] Configurations;
        
        public GetCompatibleVideoSourceConfigurationsResponse()
        {
        }
        
        public GetCompatibleVideoSourceConfigurationsResponse(CameraMediaService.VideoSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioEncoderConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioEncoderConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioEncoderConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioEncoderConfiguration[] Configurations;
        
        public GetCompatibleAudioEncoderConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioEncoderConfigurationsResponse(CameraMediaService.AudioEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioSourceConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioSourceConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioSourceConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioSourceConfiguration[] Configurations;
        
        public GetCompatibleAudioSourceConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioSourceConfigurationsResponse(CameraMediaService.AudioSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoAnalyticsConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoAnalyticsConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleVideoAnalyticsConfigurationsRequest()
        {
        }
        
        public GetCompatibleVideoAnalyticsConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoAnalyticsConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoAnalyticsConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.VideoAnalyticsConfiguration[] Configurations;
        
        public GetCompatibleVideoAnalyticsConfigurationsResponse()
        {
        }
        
        public GetCompatibleVideoAnalyticsConfigurationsResponse(CameraMediaService.VideoAnalyticsConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleMetadataConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleMetadataConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleMetadataConfigurationsRequest()
        {
        }
        
        public GetCompatibleMetadataConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleMetadataConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleMetadataConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.MetadataConfiguration[] Configurations;
        
        public GetCompatibleMetadataConfigurationsResponse()
        {
        }
        
        public GetCompatibleMetadataConfigurationsResponse(CameraMediaService.MetadataConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioOutputConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioOutputConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioOutputConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioOutputConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioOutputConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioOutputConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioOutputConfiguration[] Configurations;
        
        public GetCompatibleAudioOutputConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioOutputConfigurationsResponse(CameraMediaService.AudioOutputConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioDecoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioDecoderConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioDecoderConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioDecoderConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioDecoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioDecoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public CameraMediaService.AudioDecoderConfiguration[] Configurations;
        
        public GetCompatibleAudioDecoderConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioDecoderConfigurationsResponse(CameraMediaService.AudioDecoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGuaranteedNumberOfVideoEncoderInstances", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetGuaranteedNumberOfVideoEncoderInstancesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ConfigurationToken;
        
        public GetGuaranteedNumberOfVideoEncoderInstancesRequest()
        {
        }
        
        public GetGuaranteedNumberOfVideoEncoderInstancesRequest(string ConfigurationToken)
        {
            this.ConfigurationToken = ConfigurationToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGuaranteedNumberOfVideoEncoderInstancesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetGuaranteedNumberOfVideoEncoderInstancesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public int TotalNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=1)]
        public int JPEG;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=2)]
        public int H264;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=3)]
        public int MPEG4;
        
        public GetGuaranteedNumberOfVideoEncoderInstancesResponse()
        {
        }
        
        public GetGuaranteedNumberOfVideoEncoderInstancesResponse(int TotalNumber, int JPEG, int H264, int MPEG4)
        {
            this.TotalNumber = TotalNumber;
            this.JPEG = JPEG;
            this.H264 = H264;
            this.MPEG4 = MPEG4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceModes", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceModesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string VideoSourceToken;
        
        public GetVideoSourceModesRequest()
        {
        }
        
        public GetVideoSourceModesRequest(string VideoSourceToken)
        {
            this.VideoSourceToken = VideoSourceToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceModesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceModesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("VideoSourceModes")]
        public CameraMediaService.VideoSourceMode[] VideoSourceModes;
        
        public GetVideoSourceModesResponse()
        {
        }
        
        public GetVideoSourceModesResponse(CameraMediaService.VideoSourceMode[] VideoSourceModes)
        {
            this.VideoSourceModes = VideoSourceModes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDs", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ConfigurationToken;
        
        public GetOSDsRequest()
        {
        }
        
        public GetOSDsRequest(string ConfigurationToken)
        {
            this.ConfigurationToken = ConfigurationToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("OSDs")]
        public CameraMediaService.OSDConfiguration[] OSDs;
        
        public GetOSDsResponse()
        {
        }
        
        public GetOSDsResponse(CameraMediaService.OSDConfiguration[] OSDs)
        {
            this.OSDs = OSDs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string OSDToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDRequest()
        {
        }
        
        public GetOSDRequest(string OSDToken, System.Xml.Linq.XElement[] Any)
        {
            this.OSDToken = OSDToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public CameraMediaService.OSDConfiguration OSD;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDResponse()
        {
        }
        
        public GetOSDResponse(CameraMediaService.OSDConfiguration OSD, System.Xml.Linq.XElement[] Any)
        {
            this.OSD = OSD;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDOptions", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDOptionsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ConfigurationToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDOptionsRequest()
        {
        }
        
        public GetOSDOptionsRequest(string ConfigurationToken, System.Xml.Linq.XElement[] Any)
        {
            this.ConfigurationToken = ConfigurationToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDOptionsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDOptionsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public CameraMediaService.OSDConfigurationOptions OSDOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDOptionsResponse()
        {
        }
        
        public GetOSDOptionsResponse(CameraMediaService.OSDConfigurationOptions OSDOptions, System.Xml.Linq.XElement[] Any)
        {
            this.OSDOptions = OSDOptions;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class SetOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public CameraMediaService.OSDConfiguration OSD;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public SetOSDRequest()
        {
        }
        
        public SetOSDRequest(CameraMediaService.OSDConfiguration OSD, System.Xml.Linq.XElement[] Any)
        {
            this.OSD = OSD;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class SetOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public SetOSDResponse()
        {
        }
        
        public SetOSDResponse(System.Xml.Linq.XElement[] Any)
        {
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class CreateOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public CameraMediaService.OSDConfiguration OSD;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public CreateOSDRequest()
        {
        }
        
        public CreateOSDRequest(CameraMediaService.OSDConfiguration OSD, System.Xml.Linq.XElement[] Any)
        {
            this.OSD = OSD;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class CreateOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string OSDToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public CreateOSDResponse()
        {
        }
        
        public CreateOSDResponse(string OSDToken, System.Xml.Linq.XElement[] Any)
        {
            this.OSDToken = OSDToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class DeleteOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string OSDToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public DeleteOSDRequest()
        {
        }
        
        public DeleteOSDRequest(string OSDToken, System.Xml.Linq.XElement[] Any)
        {
            this.OSDToken = OSDToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class DeleteOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public DeleteOSDResponse()
        {
        }
        
        public DeleteOSDResponse(System.Xml.Linq.XElement[] Any)
        {
            this.Any = Any;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface MediaChannel : CameraMediaService.Media, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class MediaClient : System.ServiceModel.ClientBase<CameraMediaService.Media>, CameraMediaService.Media
    {
        
        public MediaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.Capabilities> GetServiceCapabilitiesAsync()
        {
            return base.Channel.GetServiceCapabilitiesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoSourcesResponse> CameraMediaService.Media.GetVideoSourcesAsync(CameraMediaService.GetVideoSourcesRequest request)
        {
            return base.Channel.GetVideoSourcesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetVideoSourcesResponse> GetVideoSourcesAsync()
        {
            CameraMediaService.GetVideoSourcesRequest inValue = new CameraMediaService.GetVideoSourcesRequest();
            return ((CameraMediaService.Media)(this)).GetVideoSourcesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioSourcesResponse> CameraMediaService.Media.GetAudioSourcesAsync(CameraMediaService.GetAudioSourcesRequest request)
        {
            return base.Channel.GetAudioSourcesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetAudioSourcesResponse> GetAudioSourcesAsync()
        {
            CameraMediaService.GetAudioSourcesRequest inValue = new CameraMediaService.GetAudioSourcesRequest();
            return ((CameraMediaService.Media)(this)).GetAudioSourcesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioOutputsResponse> CameraMediaService.Media.GetAudioOutputsAsync(CameraMediaService.GetAudioOutputsRequest request)
        {
            return base.Channel.GetAudioOutputsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetAudioOutputsResponse> GetAudioOutputsAsync()
        {
            CameraMediaService.GetAudioOutputsRequest inValue = new CameraMediaService.GetAudioOutputsRequest();
            return ((CameraMediaService.Media)(this)).GetAudioOutputsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.Profile> CreateProfileAsync(string Name, string Token)
        {
            return base.Channel.CreateProfileAsync(Name, Token);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.Profile> GetProfileAsync(string ProfileToken)
        {
            return base.Channel.GetProfileAsync(ProfileToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetProfilesResponse> CameraMediaService.Media.GetProfilesAsync(CameraMediaService.GetProfilesRequest request)
        {
            return base.Channel.GetProfilesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetProfilesResponse> GetProfilesAsync()
        {
            CameraMediaService.GetProfilesRequest inValue = new CameraMediaService.GetProfilesRequest();
            return ((CameraMediaService.Media)(this)).GetProfilesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddVideoEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveVideoEncoderConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveVideoEncoderConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddVideoSourceConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveVideoSourceConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveVideoSourceConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioEncoderConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioEncoderConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioSourceConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioSourceConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioSourceConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddPTZConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemovePTZConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemovePTZConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddVideoAnalyticsConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveVideoAnalyticsConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddMetadataConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveMetadataConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveMetadataConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioOutputConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioOutputConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioOutputConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioDecoderConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioDecoderConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioDecoderConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task DeleteProfileAsync(string ProfileToken)
        {
            return base.Channel.DeleteProfileAsync(ProfileToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoSourceConfigurationsResponse> CameraMediaService.Media.GetVideoSourceConfigurationsAsync(CameraMediaService.GetVideoSourceConfigurationsRequest request)
        {
            return base.Channel.GetVideoSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync()
        {
            CameraMediaService.GetVideoSourceConfigurationsRequest inValue = new CameraMediaService.GetVideoSourceConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetVideoSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoEncoderConfigurationsResponse> CameraMediaService.Media.GetVideoEncoderConfigurationsAsync(CameraMediaService.GetVideoEncoderConfigurationsRequest request)
        {
            return base.Channel.GetVideoEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync()
        {
            CameraMediaService.GetVideoEncoderConfigurationsRequest inValue = new CameraMediaService.GetVideoEncoderConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetVideoEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioSourceConfigurationsResponse> CameraMediaService.Media.GetAudioSourceConfigurationsAsync(CameraMediaService.GetAudioSourceConfigurationsRequest request)
        {
            return base.Channel.GetAudioSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync()
        {
            CameraMediaService.GetAudioSourceConfigurationsRequest inValue = new CameraMediaService.GetAudioSourceConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetAudioSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioEncoderConfigurationsResponse> CameraMediaService.Media.GetAudioEncoderConfigurationsAsync(CameraMediaService.GetAudioEncoderConfigurationsRequest request)
        {
            return base.Channel.GetAudioEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync()
        {
            CameraMediaService.GetAudioEncoderConfigurationsRequest inValue = new CameraMediaService.GetAudioEncoderConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetAudioEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoAnalyticsConfigurationsResponse> CameraMediaService.Media.GetVideoAnalyticsConfigurationsAsync(CameraMediaService.GetVideoAnalyticsConfigurationsRequest request)
        {
            return base.Channel.GetVideoAnalyticsConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync()
        {
            CameraMediaService.GetVideoAnalyticsConfigurationsRequest inValue = new CameraMediaService.GetVideoAnalyticsConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetVideoAnalyticsConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetMetadataConfigurationsResponse> CameraMediaService.Media.GetMetadataConfigurationsAsync(CameraMediaService.GetMetadataConfigurationsRequest request)
        {
            return base.Channel.GetMetadataConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync()
        {
            CameraMediaService.GetMetadataConfigurationsRequest inValue = new CameraMediaService.GetMetadataConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetMetadataConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioOutputConfigurationsResponse> CameraMediaService.Media.GetAudioOutputConfigurationsAsync(CameraMediaService.GetAudioOutputConfigurationsRequest request)
        {
            return base.Channel.GetAudioOutputConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync()
        {
            CameraMediaService.GetAudioOutputConfigurationsRequest inValue = new CameraMediaService.GetAudioOutputConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetAudioOutputConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetAudioDecoderConfigurationsResponse> CameraMediaService.Media.GetAudioDecoderConfigurationsAsync(CameraMediaService.GetAudioDecoderConfigurationsRequest request)
        {
            return base.Channel.GetAudioDecoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync()
        {
            CameraMediaService.GetAudioDecoderConfigurationsRequest inValue = new CameraMediaService.GetAudioDecoderConfigurationsRequest();
            return ((CameraMediaService.Media)(this)).GetAudioDecoderConfigurationsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetVideoSourceConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetVideoEncoderConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioSourceConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioEncoderConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetVideoAnalyticsConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetMetadataConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioOutputConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioDecoderConfigurationAsync(ConfigurationToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoEncoderConfigurationsResponse> CameraMediaService.Media.GetCompatibleVideoEncoderConfigurationsAsync(CameraMediaService.GetCompatibleVideoEncoderConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleVideoEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleVideoEncoderConfigurationsRequest inValue = new CameraMediaService.GetCompatibleVideoEncoderConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleVideoEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoSourceConfigurationsResponse> CameraMediaService.Media.GetCompatibleVideoSourceConfigurationsAsync(CameraMediaService.GetCompatibleVideoSourceConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleVideoSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleVideoSourceConfigurationsRequest inValue = new CameraMediaService.GetCompatibleVideoSourceConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleVideoSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioEncoderConfigurationsResponse> CameraMediaService.Media.GetCompatibleAudioEncoderConfigurationsAsync(CameraMediaService.GetCompatibleAudioEncoderConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleAudioEncoderConfigurationsRequest inValue = new CameraMediaService.GetCompatibleAudioEncoderConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleAudioEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioSourceConfigurationsResponse> CameraMediaService.Media.GetCompatibleAudioSourceConfigurationsAsync(CameraMediaService.GetCompatibleAudioSourceConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleAudioSourceConfigurationsRequest inValue = new CameraMediaService.GetCompatibleAudioSourceConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleAudioSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoAnalyticsConfigurationsResponse> CameraMediaService.Media.GetCompatibleVideoAnalyticsConfigurationsAsync(CameraMediaService.GetCompatibleVideoAnalyticsConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleVideoAnalyticsConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleVideoAnalyticsConfigurationsRequest inValue = new CameraMediaService.GetCompatibleVideoAnalyticsConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleVideoAnalyticsConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleMetadataConfigurationsResponse> CameraMediaService.Media.GetCompatibleMetadataConfigurationsAsync(CameraMediaService.GetCompatibleMetadataConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleMetadataConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleMetadataConfigurationsRequest inValue = new CameraMediaService.GetCompatibleMetadataConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleMetadataConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioOutputConfigurationsResponse> CameraMediaService.Media.GetCompatibleAudioOutputConfigurationsAsync(CameraMediaService.GetCompatibleAudioOutputConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioOutputConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleAudioOutputConfigurationsRequest inValue = new CameraMediaService.GetCompatibleAudioOutputConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleAudioOutputConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioDecoderConfigurationsResponse> CameraMediaService.Media.GetCompatibleAudioDecoderConfigurationsAsync(CameraMediaService.GetCompatibleAudioDecoderConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioDecoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(string ProfileToken)
        {
            CameraMediaService.GetCompatibleAudioDecoderConfigurationsRequest inValue = new CameraMediaService.GetCompatibleAudioDecoderConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((CameraMediaService.Media)(this)).GetCompatibleAudioDecoderConfigurationsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task SetVideoSourceConfigurationAsync(CameraMediaService.VideoSourceConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetVideoSourceConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetVideoEncoderConfigurationAsync(CameraMediaService.VideoEncoderConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetVideoEncoderConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioSourceConfigurationAsync(CameraMediaService.AudioSourceConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioSourceConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioEncoderConfigurationAsync(CameraMediaService.AudioEncoderConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioEncoderConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetVideoAnalyticsConfigurationAsync(CameraMediaService.VideoAnalyticsConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetVideoAnalyticsConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetMetadataConfigurationAsync(CameraMediaService.MetadataConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetMetadataConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioOutputConfigurationAsync(CameraMediaService.AudioOutputConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioOutputConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioDecoderConfigurationAsync(CameraMediaService.AudioDecoderConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioDecoderConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetVideoSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetVideoEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetMetadataConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioOutputConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioDecoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(CameraMediaService.GetGuaranteedNumberOfVideoEncoderInstancesRequest request)
        {
            return base.Channel.GetGuaranteedNumberOfVideoEncoderInstancesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.MediaUri> GetStreamUriAsync(CameraMediaService.StreamSetup StreamSetup, string ProfileToken)
        {
            return base.Channel.GetStreamUriAsync(StreamSetup, ProfileToken);
        }
        
        public System.Threading.Tasks.Task StartMulticastStreamingAsync(string ProfileToken)
        {
            return base.Channel.StartMulticastStreamingAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task StopMulticastStreamingAsync(string ProfileToken)
        {
            return base.Channel.StopMulticastStreamingAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task SetSynchronizationPointAsync(string ProfileToken)
        {
            return base.Channel.SetSynchronizationPointAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.MediaUri> GetSnapshotUriAsync(string ProfileToken)
        {
            return base.Channel.GetSnapshotUriAsync(ProfileToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetVideoSourceModesResponse> CameraMediaService.Media.GetVideoSourceModesAsync(CameraMediaService.GetVideoSourceModesRequest request)
        {
            return base.Channel.GetVideoSourceModesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetVideoSourceModesResponse> GetVideoSourceModesAsync(string VideoSourceToken)
        {
            CameraMediaService.GetVideoSourceModesRequest inValue = new CameraMediaService.GetVideoSourceModesRequest();
            inValue.VideoSourceToken = VideoSourceToken;
            return ((CameraMediaService.Media)(this)).GetVideoSourceModesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken)
        {
            return base.Channel.SetVideoSourceModeAsync(VideoSourceToken, VideoSourceModeToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CameraMediaService.GetOSDsResponse> CameraMediaService.Media.GetOSDsAsync(CameraMediaService.GetOSDsRequest request)
        {
            return base.Channel.GetOSDsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetOSDsResponse> GetOSDsAsync(string ConfigurationToken)
        {
            CameraMediaService.GetOSDsRequest inValue = new CameraMediaService.GetOSDsRequest();
            inValue.ConfigurationToken = ConfigurationToken;
            return ((CameraMediaService.Media)(this)).GetOSDsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetOSDResponse> GetOSDAsync(CameraMediaService.GetOSDRequest request)
        {
            return base.Channel.GetOSDAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.GetOSDOptionsResponse> GetOSDOptionsAsync(CameraMediaService.GetOSDOptionsRequest request)
        {
            return base.Channel.GetOSDOptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.SetOSDResponse> SetOSDAsync(CameraMediaService.SetOSDRequest request)
        {
            return base.Channel.SetOSDAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.CreateOSDResponse> CreateOSDAsync(CameraMediaService.CreateOSDRequest request)
        {
            return base.Channel.CreateOSDAsync(request);
        }
        
        public System.Threading.Tasks.Task<CameraMediaService.DeleteOSDResponse> DeleteOSDAsync(CameraMediaService.DeleteOSDRequest request)
        {
            return base.Channel.DeleteOSDAsync(request);
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
