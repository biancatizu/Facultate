﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotosProject
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Media", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosProject", IsReference=true)]
    public partial class Media : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private MyPhotosProject.PersonsMedia[] PersonsMediasField;
        
        private System.DateTime dateField;
        
        private string descriptionField;
        
        private string eventField;
        
        private string locationField;
        
        private string nameField;
        
        private string pathField;
        
        private string typeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public MyPhotosProject.PersonsMedia[] PersonsMedias
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonsMedia", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosProject", IsReference=true)]
    public partial class PersonsMedia : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private MyPhotosProject.Media MediaField;
        
        private int MediaIdField;
        
        private MyPhotosProject.Persons PersonField;
        
        private int PersonsIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public MyPhotosProject.Media Media
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
        public MyPhotosProject.Persons Person
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons", Namespace="http://schemas.datacontract.org/2004/07/MyPhotosProject", IsReference=true)]
    public partial class Persons : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private MyPhotosProject.PersonsMedia[] PersonsMediasField;
        
        private string personNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
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
        public MyPhotosProject.PersonsMedia[] PersonsMedias
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
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMyPhotosService")]
public interface IMyPhotosService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/createMedia", ReplyAction="http://tempuri.org/interfaceMedia/createMediaResponse")]
    MyPhotosProject.Media createMedia(MyPhotosProject.Media m);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/createMedia", ReplyAction="http://tempuri.org/interfaceMedia/createMediaResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Media> createMediaAsync(MyPhotosProject.Media m);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getAllMedia", ReplyAction="http://tempuri.org/interfaceMedia/getAllMediaResponse")]
    MyPhotosProject.Media[] getAllMedia();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getAllMedia", ReplyAction="http://tempuri.org/interfaceMedia/getAllMediaResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Media[]> getAllMediaAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaByPersonName", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByPersonNameResponse")]
    MyPhotosProject.Media[] getMediaByPersonName(string personName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaByPersonName", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByPersonNameResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Media[]> getMediaByPersonNameAsync(string personName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaByPath", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByPathResponse")]
    MyPhotosProject.Media[] getMediaByPath(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaByPath", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByPathResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Media[]> getMediaByPathAsync(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaById", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByIdResponse")]
    MyPhotosProject.Media getMediaById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/getMediaById", ReplyAction="http://tempuri.org/interfaceMedia/getMediaByIdResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Media> getMediaByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/updateMedia", ReplyAction="http://tempuri.org/interfaceMedia/updateMediaResponse")]
    MyPhotosProject.Media updateMedia(MyPhotosProject.Media m, int mediaId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/updateMedia", ReplyAction="http://tempuri.org/interfaceMedia/updateMediaResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Media> updateMediaAsync(MyPhotosProject.Media m, int mediaId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/addPersonToMedia", ReplyAction="http://tempuri.org/interfaceMedia/addPersonToMediaResponse")]
    void addPersonToMedia(MyPhotosProject.Persons p, int mediaId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/addPersonToMedia", ReplyAction="http://tempuri.org/interfaceMedia/addPersonToMediaResponse")]
    System.Threading.Tasks.Task addPersonToMediaAsync(MyPhotosProject.Persons p, int mediaId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/removeMedia", ReplyAction="http://tempuri.org/interfaceMedia/removeMediaResponse")]
    void removeMedia(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/removeMedia", ReplyAction="http://tempuri.org/interfaceMedia/removeMediaResponse")]
    System.Threading.Tasks.Task removeMediaAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/removeMediaFromDb", ReplyAction="http://tempuri.org/interfaceMedia/removeMediaFromDbResponse")]
    void removeMediaFromDb(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceMedia/removeMediaFromDb", ReplyAction="http://tempuri.org/interfaceMedia/removeMediaFromDbResponse")]
    System.Threading.Tasks.Task removeMediaFromDbAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/createPerson", ReplyAction="http://tempuri.org/interfacePerson/createPersonResponse")]
    MyPhotosProject.Persons createPerson(MyPhotosProject.Persons P);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/createPerson", ReplyAction="http://tempuri.org/interfacePerson/createPersonResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Persons> createPersonAsync(MyPhotosProject.Persons P);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/getPersonsByMediaName", ReplyAction="http://tempuri.org/interfacePerson/getPersonsByMediaNameResponse")]
    MyPhotosProject.Persons[] getPersonsByMediaName(string mediaName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/getPersonsByMediaName", ReplyAction="http://tempuri.org/interfacePerson/getPersonsByMediaNameResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Persons[]> getPersonsByMediaNameAsync(string mediaName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/updatePerson", ReplyAction="http://tempuri.org/interfacePerson/updatePersonResponse")]
    MyPhotosProject.Persons updatePerson(MyPhotosProject.Persons p);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/updatePerson", ReplyAction="http://tempuri.org/interfacePerson/updatePersonResponse")]
    System.Threading.Tasks.Task<MyPhotosProject.Persons> updatePersonAsync(MyPhotosProject.Persons p);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/removePersonFromDb", ReplyAction="http://tempuri.org/interfacePerson/removePersonFromDbResponse")]
    void removePersonFromDb(MyPhotosProject.Persons p);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfacePerson/removePersonFromDb", ReplyAction="http://tempuri.org/interfacePerson/removePersonFromDbResponse")]
    System.Threading.Tasks.Task removePersonFromDbAsync(MyPhotosProject.Persons p);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMyPhotosServiceChannel : IMyPhotosService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyPhotosServiceClient : System.ServiceModel.ClientBase<IMyPhotosService>, IMyPhotosService
{
    
    public MyPhotosServiceClient()
    {
    }
    
    public MyPhotosServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MyPhotosServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyPhotosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyPhotosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public MyPhotosProject.Media createMedia(MyPhotosProject.Media m)
    {
        return base.Channel.createMedia(m);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Media> createMediaAsync(MyPhotosProject.Media m)
    {
        return base.Channel.createMediaAsync(m);
    }
    
    public MyPhotosProject.Media[] getAllMedia()
    {
        return base.Channel.getAllMedia();
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Media[]> getAllMediaAsync()
    {
        return base.Channel.getAllMediaAsync();
    }
    
    public MyPhotosProject.Media[] getMediaByPersonName(string personName)
    {
        return base.Channel.getMediaByPersonName(personName);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Media[]> getMediaByPersonNameAsync(string personName)
    {
        return base.Channel.getMediaByPersonNameAsync(personName);
    }
    
    public MyPhotosProject.Media[] getMediaByPath(string path)
    {
        return base.Channel.getMediaByPath(path);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Media[]> getMediaByPathAsync(string path)
    {
        return base.Channel.getMediaByPathAsync(path);
    }
    
    public MyPhotosProject.Media getMediaById(int id)
    {
        return base.Channel.getMediaById(id);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Media> getMediaByIdAsync(int id)
    {
        return base.Channel.getMediaByIdAsync(id);
    }
    
    public MyPhotosProject.Media updateMedia(MyPhotosProject.Media m, int mediaId)
    {
        return base.Channel.updateMedia(m, mediaId);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Media> updateMediaAsync(MyPhotosProject.Media m, int mediaId)
    {
        return base.Channel.updateMediaAsync(m, mediaId);
    }
    
    public void addPersonToMedia(MyPhotosProject.Persons p, int mediaId)
    {
        base.Channel.addPersonToMedia(p, mediaId);
    }
    
    public System.Threading.Tasks.Task addPersonToMediaAsync(MyPhotosProject.Persons p, int mediaId)
    {
        return base.Channel.addPersonToMediaAsync(p, mediaId);
    }
    
    public void removeMedia(int id)
    {
        base.Channel.removeMedia(id);
    }
    
    public System.Threading.Tasks.Task removeMediaAsync(int id)
    {
        return base.Channel.removeMediaAsync(id);
    }
    
    public void removeMediaFromDb(int id)
    {
        base.Channel.removeMediaFromDb(id);
    }
    
    public System.Threading.Tasks.Task removeMediaFromDbAsync(int id)
    {
        return base.Channel.removeMediaFromDbAsync(id);
    }
    
    public MyPhotosProject.Persons createPerson(MyPhotosProject.Persons P)
    {
        return base.Channel.createPerson(P);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Persons> createPersonAsync(MyPhotosProject.Persons P)
    {
        return base.Channel.createPersonAsync(P);
    }
    
    public MyPhotosProject.Persons[] getPersonsByMediaName(string mediaName)
    {
        return base.Channel.getPersonsByMediaName(mediaName);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Persons[]> getPersonsByMediaNameAsync(string mediaName)
    {
        return base.Channel.getPersonsByMediaNameAsync(mediaName);
    }
    
    public MyPhotosProject.Persons updatePerson(MyPhotosProject.Persons p)
    {
        return base.Channel.updatePerson(p);
    }
    
    public System.Threading.Tasks.Task<MyPhotosProject.Persons> updatePersonAsync(MyPhotosProject.Persons p)
    {
        return base.Channel.updatePersonAsync(p);
    }
    
    public void removePersonFromDb(MyPhotosProject.Persons p)
    {
        base.Channel.removePersonFromDb(p);
    }
    
    public System.Threading.Tasks.Task removePersonFromDbAsync(MyPhotosProject.Persons p)
    {
        return base.Channel.removePersonFromDbAsync(p);
    }
}
