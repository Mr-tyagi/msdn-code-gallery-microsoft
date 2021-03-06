﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IUnZipWcfService")>  _
    Public Interface IUnZipWcfService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IUnZipWcfService/UnZipFiles", ReplyAction:="http://tempuri.org/IUnZipWcfService/UnZipFilesResponse")>  _
        Function UnZipFiles(ByVal strPath As String, ByVal strContainerName As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IUnZipWcfService/UnZipFiles", ReplyAction:="http://tempuri.org/IUnZipWcfService/UnZipFilesResponse")>  _
        Function UnZipFilesAsync(ByVal strPath As String, ByVal strContainerName As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IUnZipWcfService/GetAllContainer", ReplyAction:="http://tempuri.org/IUnZipWcfService/GetAllContainerResponse")>  _
        Function GetAllContainer() As String()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IUnZipWcfService/GetAllContainer", ReplyAction:="http://tempuri.org/IUnZipWcfService/GetAllContainerResponse")>  _
        Function GetAllContainerAsync() As System.Threading.Tasks.Task(Of String())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IUnZipWcfService/GetAllBlob", ReplyAction:="http://tempuri.org/IUnZipWcfService/GetAllBlobResponse")>  _
        Function GetAllBlob(ByVal strContainerName As String) As String()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IUnZipWcfService/GetAllBlob", ReplyAction:="http://tempuri.org/IUnZipWcfService/GetAllBlobResponse")>  _
        Function GetAllBlobAsync(ByVal strContainerName As String) As System.Threading.Tasks.Task(Of String())
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IUnZipWcfServiceChannel
        Inherits ServiceReference1.IUnZipWcfService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class UnZipWcfServiceClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IUnZipWcfService)
        Implements ServiceReference1.IUnZipWcfService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function UnZipFiles(ByVal strPath As String, ByVal strContainerName As String) As Boolean Implements ServiceReference1.IUnZipWcfService.UnZipFiles
            Return MyBase.Channel.UnZipFiles(strPath, strContainerName)
        End Function
        
        Public Function UnZipFilesAsync(ByVal strPath As String, ByVal strContainerName As String) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IUnZipWcfService.UnZipFilesAsync
            Return MyBase.Channel.UnZipFilesAsync(strPath, strContainerName)
        End Function
        
        Public Function GetAllContainer() As String() Implements ServiceReference1.IUnZipWcfService.GetAllContainer
            Return MyBase.Channel.GetAllContainer
        End Function
        
        Public Function GetAllContainerAsync() As System.Threading.Tasks.Task(Of String()) Implements ServiceReference1.IUnZipWcfService.GetAllContainerAsync
            Return MyBase.Channel.GetAllContainerAsync
        End Function
        
        Public Function GetAllBlob(ByVal strContainerName As String) As String() Implements ServiceReference1.IUnZipWcfService.GetAllBlob
            Return MyBase.Channel.GetAllBlob(strContainerName)
        End Function
        
        Public Function GetAllBlobAsync(ByVal strContainerName As String) As System.Threading.Tasks.Task(Of String()) Implements ServiceReference1.IUnZipWcfService.GetAllBlobAsync
            Return MyBase.Channel.GetAllBlobAsync(strContainerName)
        End Function
    End Class
End Namespace
