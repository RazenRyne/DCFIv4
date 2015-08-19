﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSAR.RoomServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/eSARService")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BuildingCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CapacityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DeactivatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoomIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BuildingCode {
            get {
                return this.BuildingCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BuildingCodeField, value) != true)) {
                    this.BuildingCodeField = value;
                    this.RaisePropertyChanged("BuildingCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Capacity {
            get {
                return this.CapacityField;
            }
            set {
                if ((this.CapacityField.Equals(value) != true)) {
                    this.CapacityField = value;
                    this.RaisePropertyChanged("Capacity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deactivated {
            get {
                return this.DeactivatedField;
            }
            set {
                if ((this.DeactivatedField.Equals(value) != true)) {
                    this.DeactivatedField = value;
                    this.RaisePropertyChanged("Deactivated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomCode {
            get {
                return this.RoomCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomCodeField, value) != true)) {
                    this.RoomCodeField = value;
                    this.RaisePropertyChanged("RoomCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomId {
            get {
                return this.RoomIdField;
            }
            set {
                if ((this.RoomIdField.Equals(value) != true)) {
                    this.RoomIdField = value;
                    this.RaisePropertyChanged("RoomId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomNumber {
            get {
                return this.RoomNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomNumberField, value) != true)) {
                    this.RoomNumberField = value;
                    this.RaisePropertyChanged("RoomNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RoomServiceRef.IRoomService")]
    public interface IRoomService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/UpdateRoom", ReplyAction="http://tempuri.org/IRoomService/UpdateRoomResponse")]
        eSAR.RoomServiceRef.UpdateRoomResponse UpdateRoom(eSAR.RoomServiceRef.UpdateRoomRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/UpdateRoom", ReplyAction="http://tempuri.org/IRoomService/UpdateRoomResponse")]
        System.Threading.Tasks.Task<eSAR.RoomServiceRef.UpdateRoomResponse> UpdateRoomAsync(eSAR.RoomServiceRef.UpdateRoomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/CreateRoom", ReplyAction="http://tempuri.org/IRoomService/CreateRoomResponse")]
        eSAR.RoomServiceRef.CreateRoomResponse CreateRoom(eSAR.RoomServiceRef.CreateRoomRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/CreateRoom", ReplyAction="http://tempuri.org/IRoomService/CreateRoomResponse")]
        System.Threading.Tasks.Task<eSAR.RoomServiceRef.CreateRoomResponse> CreateRoomAsync(eSAR.RoomServiceRef.CreateRoomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/GetAllRooms", ReplyAction="http://tempuri.org/IRoomService/GetAllRoomsResponse")]
        eSAR.RoomServiceRef.Room[] GetAllRooms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoomService/GetAllRooms", ReplyAction="http://tempuri.org/IRoomService/GetAllRoomsResponse")]
        System.Threading.Tasks.Task<eSAR.RoomServiceRef.Room[]> GetAllRoomsAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateRoom", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateRoomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public eSAR.RoomServiceRef.Room room;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateRoomRequest() {
        }
        
        public UpdateRoomRequest(eSAR.RoomServiceRef.Room room, string message) {
            this.room = room;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateRoomResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateRoomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateRoomResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public eSAR.RoomServiceRef.Room room;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public UpdateRoomResponse() {
        }
        
        public UpdateRoomResponse(bool UpdateRoomResult, eSAR.RoomServiceRef.Room room, string message) {
            this.UpdateRoomResult = UpdateRoomResult;
            this.room = room;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateRoom", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateRoomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public eSAR.RoomServiceRef.Room room;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public CreateRoomRequest() {
        }
        
        public CreateRoomRequest(eSAR.RoomServiceRef.Room room, string message) {
            this.room = room;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateRoomResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateRoomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CreateRoomResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public eSAR.RoomServiceRef.Room room;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public CreateRoomResponse() {
        }
        
        public CreateRoomResponse(bool CreateRoomResult, eSAR.RoomServiceRef.Room room, string message) {
            this.CreateRoomResult = CreateRoomResult;
            this.room = room;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoomServiceChannel : eSAR.RoomServiceRef.IRoomService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoomServiceClient : System.ServiceModel.ClientBase<eSAR.RoomServiceRef.IRoomService>, eSAR.RoomServiceRef.IRoomService {
        
        public RoomServiceClient() {
        }
        
        public RoomServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoomServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoomServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSAR.RoomServiceRef.UpdateRoomResponse eSAR.RoomServiceRef.IRoomService.UpdateRoom(eSAR.RoomServiceRef.UpdateRoomRequest request) {
            return base.Channel.UpdateRoom(request);
        }
        
        public bool UpdateRoom(ref eSAR.RoomServiceRef.Room room, ref string message) {
            eSAR.RoomServiceRef.UpdateRoomRequest inValue = new eSAR.RoomServiceRef.UpdateRoomRequest();
            inValue.room = room;
            inValue.message = message;
            eSAR.RoomServiceRef.UpdateRoomResponse retVal = ((eSAR.RoomServiceRef.IRoomService)(this)).UpdateRoom(inValue);
            room = retVal.room;
            message = retVal.message;
            return retVal.UpdateRoomResult;
        }
        
        public System.Threading.Tasks.Task<eSAR.RoomServiceRef.UpdateRoomResponse> UpdateRoomAsync(eSAR.RoomServiceRef.UpdateRoomRequest request) {
            return base.Channel.UpdateRoomAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSAR.RoomServiceRef.CreateRoomResponse eSAR.RoomServiceRef.IRoomService.CreateRoom(eSAR.RoomServiceRef.CreateRoomRequest request) {
            return base.Channel.CreateRoom(request);
        }
        
        public bool CreateRoom(ref eSAR.RoomServiceRef.Room room, ref string message) {
            eSAR.RoomServiceRef.CreateRoomRequest inValue = new eSAR.RoomServiceRef.CreateRoomRequest();
            inValue.room = room;
            inValue.message = message;
            eSAR.RoomServiceRef.CreateRoomResponse retVal = ((eSAR.RoomServiceRef.IRoomService)(this)).CreateRoom(inValue);
            room = retVal.room;
            message = retVal.message;
            return retVal.CreateRoomResult;
        }
        
        public System.Threading.Tasks.Task<eSAR.RoomServiceRef.CreateRoomResponse> CreateRoomAsync(eSAR.RoomServiceRef.CreateRoomRequest request) {
            return base.Channel.CreateRoomAsync(request);
        }
        
        public eSAR.RoomServiceRef.Room[] GetAllRooms() {
            return base.Channel.GetAllRooms();
        }
        
        public System.Threading.Tasks.Task<eSAR.RoomServiceRef.Room[]> GetAllRoomsAsync() {
            return base.Channel.GetAllRoomsAsync();
        }
    }
}
