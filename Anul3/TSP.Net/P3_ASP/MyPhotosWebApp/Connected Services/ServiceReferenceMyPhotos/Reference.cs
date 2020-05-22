﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceMyPhotos
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Media", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosProject", IsReference=true)]
    public partial class Media : object
    {
        
        private int IdField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.PersonsMedia> PersonsMediasField;
        
        private System.DateTime dateField;
        
        private string descriptionField;
        
        private string eventField;
        
        private string locationField;
        
        private string nameField;
        
        private string pathField;
        
        private string typeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.PersonsMedia> PersonsMedias
        {
            get
            {
                return this.PersonsMediasField;
            }
            set
            {
                this.PersonsMediasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string @event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsMedia", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosProject", IsReference=true)]
    public partial class PersonsMedia : object
    {
        
        private int IdField;
        
        private ServiceReferenceMyPhotos.Media MediaField;
        
        private int MediaIdField;
        
        private ServiceReferenceMyPhotos.Persons PersonField;
        
        private int PersonsIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceMyPhotos.Media Media
        {
            get
            {
                return this.MediaField;
            }
            set
            {
                this.MediaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MediaId
        {
            get
            {
                return this.MediaIdField;
            }
            set
            {
                this.MediaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceMyPhotos.Persons Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonsId
        {
            get
            {
                return this.PersonsIdField;
            }
            set
            {
                this.PersonsIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosProject", IsReference=true)]
    public partial class Persons : object
    {
        
        private int IdField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.PersonsMedia> PersonsMediasField;
        
        private string personNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.PersonsMedia> PersonsMedias
        {
            get
            {
                return this.PersonsMediasField;
            }
            set
            {
                this.PersonsMediasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string personName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMyPhotos.IMyPhotosService")]
    public interface IMyPhotosService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/createMedia", ReplyAction="http://tempuri.org/interfaceMedia/createMediaResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Media> createMediaAsync(ServiceReferenceMyPhotos.Media m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getAllMedia", ReplyAction="http://tempuri.org/interfaceMedia/getAllMediaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Media>> getAllMediaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaByPersonName", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByPersonNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Media>> getMediaByPersonNameAsync(string personName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaByPath", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByPathResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Media>> getMediaByPathAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaById", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Media> getMediaByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/updateMedia", ReplyAction="http://tempuri.org/interfaceMedia/updateMediaResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Media> updateMediaAsync(ServiceReferenceMyPhotos.Media m, int mediaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/addPersonToMedia", ReplyAction="http://tempuri.org/interfaceMedia/addPersonToMediaResponse")]
        System.Threading.Tasks.Task addPersonToMediaAsync(ServiceReferenceMyPhotos.Persons p, int mediaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/removeMedia", ReplyAction="http://tempuri.org/interfaceMedia/removeMediaResponse")]
        System.Threading.Tasks.Task removeMediaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/removeMediaFromDb", ReplyAction="http://tempuri.org/interfaceMedia/removeMediaFromDbResponse")]
        System.Threading.Tasks.Task removeMediaFromDbAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/createPerson", ReplyAction="http://tempuri.org/interfacePerson/createPersonResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Persons> createPersonAsync(ServiceReferenceMyPhotos.Persons P);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/getPersonsByMediaName", ReplyAction="http://tempuri.org/interfacePerson/getPersonsByMediaNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons>> getPersonsByMediaNameAsync(string mediaName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/updatePerson", ReplyAction="http://tempuri.org/interfacePerson/updatePersonResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Persons> updatePersonAsync(ServiceReferenceMyPhotos.Persons p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/removePersonFromDb", ReplyAction="http://tempuri.org/interfacePerson/removePersonFromDbResponse")]
        System.Threading.Tasks.Task removePersonFromDbAsync(ServiceReferenceMyPhotos.Persons p);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMyPhotosServiceChannel : ServiceReferenceMyPhotos.IMyPhotosService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MyPhotosServiceClient : System.ServiceModel.ClientBase<ServiceReferenceMyPhotos.IMyPhotosService>, ServiceReferenceMyPhotos.IMyPhotosService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyPhotosServiceClient() : 
                base(MyPhotosServiceClient.GetDefaultBinding(), MyPhotosServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMyPhotosService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), MyPhotosServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyPhotosServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyPhotosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Media> createMediaAsync(ServiceReferenceMyPhotos.Media m)
        {
            return base.Channel.createMediaAsync(m);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Media>> getAllMediaAsync()
        {
            return base.Channel.getAllMediaAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Media>> getMediaByPersonNameAsync(string personName)
        {
            return base.Channel.getMediaByPersonNameAsync(personName);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Media>> getMediaByPathAsync(string path)
        {
            return base.Channel.getMediaByPathAsync(path);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Media> getMediaByIdAsync(int id)
        {
            return base.Channel.getMediaByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Media> updateMediaAsync(ServiceReferenceMyPhotos.Media m, int mediaId)
        {
            return base.Channel.updateMediaAsync(m, mediaId);
        }
        
        public System.Threading.Tasks.Task addPersonToMediaAsync(ServiceReferenceMyPhotos.Persons p, int mediaId)
        {
            return base.Channel.addPersonToMediaAsync(p, mediaId);
        }
        
        public System.Threading.Tasks.Task removeMediaAsync(int id)
        {
            return base.Channel.removeMediaAsync(id);
        }
        
        public System.Threading.Tasks.Task removeMediaFromDbAsync(int id)
        {
            return base.Channel.removeMediaFromDbAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Persons> createPersonAsync(ServiceReferenceMyPhotos.Persons P)
        {
            return base.Channel.createPersonAsync(P);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons>> getPersonsByMediaNameAsync(string mediaName)
        {
            return base.Channel.getPersonsByMediaNameAsync(mediaName);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Persons> updatePersonAsync(ServiceReferenceMyPhotos.Persons p)
        {
            return base.Channel.updatePersonAsync(p);
        }
        
        public System.Threading.Tasks.Task removePersonFromDbAsync(ServiceReferenceMyPhotos.Persons p)
        {
            return base.Channel.removePersonFromDbAsync(p);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotosService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMyPhotosService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyPhotosServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMyPhotosService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyPhotosServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMyPhotosService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMyPhotosService,
        }
    }
}
