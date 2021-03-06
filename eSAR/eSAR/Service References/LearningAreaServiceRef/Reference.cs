﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSAR.LearningAreaServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LearningArea", Namespace="http://schemas.datacontract.org/2004/07/eSARService")]
    [System.SerializableAttribute()]
    public partial class LearningArea : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> AcademicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LearningAreaCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> RatePerUnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private eSAR.LearningAreaServiceRef.Subject[] SubjectsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> UnitsField;
        
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
        public System.Nullable<bool> Academic {
            get {
                return this.AcademicField;
            }
            set {
                if ((this.AcademicField.Equals(value) != true)) {
                    this.AcademicField = value;
                    this.RaisePropertyChanged("Academic");
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
        public string LearningAreaCode {
            get {
                return this.LearningAreaCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.LearningAreaCodeField, value) != true)) {
                    this.LearningAreaCodeField = value;
                    this.RaisePropertyChanged("LearningAreaCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> RatePerUnit {
            get {
                return this.RatePerUnitField;
            }
            set {
                if ((this.RatePerUnitField.Equals(value) != true)) {
                    this.RatePerUnitField = value;
                    this.RaisePropertyChanged("RatePerUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public eSAR.LearningAreaServiceRef.Subject[] Subjects {
            get {
                return this.SubjectsField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectsField, value) != true)) {
                    this.SubjectsField = value;
                    this.RaisePropertyChanged("Subjects");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Units {
            get {
                return this.UnitsField;
            }
            set {
                if ((this.UnitsField.Equals(value) != true)) {
                    this.UnitsField = value;
                    this.RaisePropertyChanged("Units");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Subject", Namespace="http://schemas.datacontract.org/2004/07/eSARService")]
    [System.SerializableAttribute()]
    public partial class Subject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradeLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private eSAR.LearningAreaServiceRef.LearningArea LAreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LearningAreaCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubjectIDField;
        
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
        public string GradeLevel {
            get {
                return this.GradeLevelField;
            }
            set {
                if ((object.ReferenceEquals(this.GradeLevelField, value) != true)) {
                    this.GradeLevelField = value;
                    this.RaisePropertyChanged("GradeLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public eSAR.LearningAreaServiceRef.LearningArea LArea {
            get {
                return this.LAreaField;
            }
            set {
                if ((object.ReferenceEquals(this.LAreaField, value) != true)) {
                    this.LAreaField = value;
                    this.RaisePropertyChanged("LArea");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LearningAreaCode {
            get {
                return this.LearningAreaCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.LearningAreaCodeField, value) != true)) {
                    this.LearningAreaCodeField = value;
                    this.RaisePropertyChanged("LearningAreaCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectCode {
            get {
                return this.SubjectCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectCodeField, value) != true)) {
                    this.SubjectCodeField = value;
                    this.RaisePropertyChanged("SubjectCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubjectID {
            get {
                return this.SubjectIDField;
            }
            set {
                if ((this.SubjectIDField.Equals(value) != true)) {
                    this.SubjectIDField = value;
                    this.RaisePropertyChanged("SubjectID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LearningAreaServiceRef.ILearningAreaService")]
    public interface ILearningAreaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/UpdateLearningArea", ReplyAction="http://tempuri.org/ILearningAreaService/UpdateLearningAreaResponse")]
        eSAR.LearningAreaServiceRef.UpdateLearningAreaResponse UpdateLearningArea(eSAR.LearningAreaServiceRef.UpdateLearningAreaRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/UpdateLearningArea", ReplyAction="http://tempuri.org/ILearningAreaService/UpdateLearningAreaResponse")]
        System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.UpdateLearningAreaResponse> UpdateLearningAreaAsync(eSAR.LearningAreaServiceRef.UpdateLearningAreaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/CreateLearningArea", ReplyAction="http://tempuri.org/ILearningAreaService/CreateLearningAreaResponse")]
        eSAR.LearningAreaServiceRef.CreateLearningAreaResponse CreateLearningArea(eSAR.LearningAreaServiceRef.CreateLearningAreaRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/CreateLearningArea", ReplyAction="http://tempuri.org/ILearningAreaService/CreateLearningAreaResponse")]
        System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.CreateLearningAreaResponse> CreateLearningAreaAsync(eSAR.LearningAreaServiceRef.CreateLearningAreaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/GetAllLearningAreas", ReplyAction="http://tempuri.org/ILearningAreaService/GetAllLearningAreasResponse")]
        eSAR.LearningAreaServiceRef.LearningArea[] GetAllLearningAreas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/GetAllLearningAreas", ReplyAction="http://tempuri.org/ILearningAreaService/GetAllLearningAreasResponse")]
        System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.LearningArea[]> GetAllLearningAreasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/GetAllSubjects", ReplyAction="http://tempuri.org/ILearningAreaService/GetAllSubjectsResponse")]
        eSAR.LearningAreaServiceRef.Subject[] GetAllSubjects(string learningAreaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/GetAllSubjects", ReplyAction="http://tempuri.org/ILearningAreaService/GetAllSubjectsResponse")]
        System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.Subject[]> GetAllSubjectsAsync(string learningAreaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/GetLearningArea", ReplyAction="http://tempuri.org/ILearningAreaService/GetLearningAreaResponse")]
        eSAR.LearningAreaServiceRef.LearningArea GetLearningArea(string learningAreaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILearningAreaService/GetLearningArea", ReplyAction="http://tempuri.org/ILearningAreaService/GetLearningAreaResponse")]
        System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.LearningArea> GetLearningAreaAsync(string learningAreaCode);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateLearningArea", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateLearningAreaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public eSAR.LearningAreaServiceRef.LearningArea learningArea;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateLearningAreaRequest() {
        }
        
        public UpdateLearningAreaRequest(eSAR.LearningAreaServiceRef.LearningArea learningArea, string message) {
            this.learningArea = learningArea;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateLearningAreaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateLearningAreaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateLearningAreaResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public eSAR.LearningAreaServiceRef.LearningArea learningArea;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public UpdateLearningAreaResponse() {
        }
        
        public UpdateLearningAreaResponse(bool UpdateLearningAreaResult, eSAR.LearningAreaServiceRef.LearningArea learningArea, string message) {
            this.UpdateLearningAreaResult = UpdateLearningAreaResult;
            this.learningArea = learningArea;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateLearningArea", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateLearningAreaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public eSAR.LearningAreaServiceRef.LearningArea learningArea;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public CreateLearningAreaRequest() {
        }
        
        public CreateLearningAreaRequest(eSAR.LearningAreaServiceRef.LearningArea learningArea, string message) {
            this.learningArea = learningArea;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateLearningAreaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreateLearningAreaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool CreateLearningAreaResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public eSAR.LearningAreaServiceRef.LearningArea learningArea;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public CreateLearningAreaResponse() {
        }
        
        public CreateLearningAreaResponse(bool CreateLearningAreaResult, eSAR.LearningAreaServiceRef.LearningArea learningArea, string message) {
            this.CreateLearningAreaResult = CreateLearningAreaResult;
            this.learningArea = learningArea;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILearningAreaServiceChannel : eSAR.LearningAreaServiceRef.ILearningAreaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LearningAreaServiceClient : System.ServiceModel.ClientBase<eSAR.LearningAreaServiceRef.ILearningAreaService>, eSAR.LearningAreaServiceRef.ILearningAreaService {
        
        public LearningAreaServiceClient() {
        }
        
        public LearningAreaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LearningAreaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LearningAreaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LearningAreaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSAR.LearningAreaServiceRef.UpdateLearningAreaResponse eSAR.LearningAreaServiceRef.ILearningAreaService.UpdateLearningArea(eSAR.LearningAreaServiceRef.UpdateLearningAreaRequest request) {
            return base.Channel.UpdateLearningArea(request);
        }
        
        public bool UpdateLearningArea(ref eSAR.LearningAreaServiceRef.LearningArea learningArea, ref string message) {
            eSAR.LearningAreaServiceRef.UpdateLearningAreaRequest inValue = new eSAR.LearningAreaServiceRef.UpdateLearningAreaRequest();
            inValue.learningArea = learningArea;
            inValue.message = message;
            eSAR.LearningAreaServiceRef.UpdateLearningAreaResponse retVal = ((eSAR.LearningAreaServiceRef.ILearningAreaService)(this)).UpdateLearningArea(inValue);
            learningArea = retVal.learningArea;
            message = retVal.message;
            return retVal.UpdateLearningAreaResult;
        }
        
        public System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.UpdateLearningAreaResponse> UpdateLearningAreaAsync(eSAR.LearningAreaServiceRef.UpdateLearningAreaRequest request) {
            return base.Channel.UpdateLearningAreaAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        eSAR.LearningAreaServiceRef.CreateLearningAreaResponse eSAR.LearningAreaServiceRef.ILearningAreaService.CreateLearningArea(eSAR.LearningAreaServiceRef.CreateLearningAreaRequest request) {
            return base.Channel.CreateLearningArea(request);
        }
        
        public bool CreateLearningArea(ref eSAR.LearningAreaServiceRef.LearningArea learningArea, ref string message) {
            eSAR.LearningAreaServiceRef.CreateLearningAreaRequest inValue = new eSAR.LearningAreaServiceRef.CreateLearningAreaRequest();
            inValue.learningArea = learningArea;
            inValue.message = message;
            eSAR.LearningAreaServiceRef.CreateLearningAreaResponse retVal = ((eSAR.LearningAreaServiceRef.ILearningAreaService)(this)).CreateLearningArea(inValue);
            learningArea = retVal.learningArea;
            message = retVal.message;
            return retVal.CreateLearningAreaResult;
        }
        
        public System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.CreateLearningAreaResponse> CreateLearningAreaAsync(eSAR.LearningAreaServiceRef.CreateLearningAreaRequest request) {
            return base.Channel.CreateLearningAreaAsync(request);
        }
        
        public eSAR.LearningAreaServiceRef.LearningArea[] GetAllLearningAreas() {
            return base.Channel.GetAllLearningAreas();
        }
        
        public System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.LearningArea[]> GetAllLearningAreasAsync() {
            return base.Channel.GetAllLearningAreasAsync();
        }
        
        public eSAR.LearningAreaServiceRef.Subject[] GetAllSubjects(string learningAreaCode) {
            return base.Channel.GetAllSubjects(learningAreaCode);
        }
        
        public System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.Subject[]> GetAllSubjectsAsync(string learningAreaCode) {
            return base.Channel.GetAllSubjectsAsync(learningAreaCode);
        }
        
        public eSAR.LearningAreaServiceRef.LearningArea GetLearningArea(string learningAreaCode) {
            return base.Channel.GetLearningArea(learningAreaCode);
        }
        
        public System.Threading.Tasks.Task<eSAR.LearningAreaServiceRef.LearningArea> GetLearningAreaAsync(string learningAreaCode) {
            return base.Channel.GetLearningAreaAsync(learningAreaCode);
        }
    }
}
