﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSAR.SubjectServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
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
        private eSAR.SubjectServiceRef.LearningArea LAreaField;
        
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
        public eSAR.SubjectServiceRef.LearningArea LArea {
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
        private eSAR.SubjectServiceRef.Subject[] SubjectsField;
        
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
        public eSAR.SubjectServiceRef.Subject[] Subjects {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SubjectServiceRef.ISubjectService")]
    public interface ISubjectService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetAllSubjects", ReplyAction="http://tempuri.org/ISubjectService/GetAllSubjectsResponse")]
        eSAR.SubjectServiceRef.Subject[] GetAllSubjects();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetAllSubjects", ReplyAction="http://tempuri.org/ISubjectService/GetAllSubjectsResponse")]
        System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject[]> GetAllSubjectsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetAllSubjectsOfLearningArea", ReplyAction="http://tempuri.org/ISubjectService/GetAllSubjectsOfLearningAreaResponse")]
        eSAR.SubjectServiceRef.Subject[] GetAllSubjectsOfLearningArea(string learningAreaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetAllSubjectsOfLearningArea", ReplyAction="http://tempuri.org/ISubjectService/GetAllSubjectsOfLearningAreaResponse")]
        System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject[]> GetAllSubjectsOfLearningAreaAsync(string learningAreaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetAllSubjectsOfGradeLevel", ReplyAction="http://tempuri.org/ISubjectService/GetAllSubjectsOfGradeLevelResponse")]
        eSAR.SubjectServiceRef.Subject[] GetAllSubjectsOfGradeLevel(string gradeLevel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetAllSubjectsOfGradeLevel", ReplyAction="http://tempuri.org/ISubjectService/GetAllSubjectsOfGradeLevelResponse")]
        System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject[]> GetAllSubjectsOfGradeLevelAsync(string gradeLevel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetSubject", ReplyAction="http://tempuri.org/ISubjectService/GetSubjectResponse")]
        eSAR.SubjectServiceRef.Subject GetSubject(string subjectCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubjectService/GetSubject", ReplyAction="http://tempuri.org/ISubjectService/GetSubjectResponse")]
        System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject> GetSubjectAsync(string subjectCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubjectServiceChannel : eSAR.SubjectServiceRef.ISubjectService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubjectServiceClient : System.ServiceModel.ClientBase<eSAR.SubjectServiceRef.ISubjectService>, eSAR.SubjectServiceRef.ISubjectService {
        
        public SubjectServiceClient() {
        }
        
        public SubjectServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubjectServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubjectServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubjectServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public eSAR.SubjectServiceRef.Subject[] GetAllSubjects() {
            return base.Channel.GetAllSubjects();
        }
        
        public System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject[]> GetAllSubjectsAsync() {
            return base.Channel.GetAllSubjectsAsync();
        }
        
        public eSAR.SubjectServiceRef.Subject[] GetAllSubjectsOfLearningArea(string learningAreaCode) {
            return base.Channel.GetAllSubjectsOfLearningArea(learningAreaCode);
        }
        
        public System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject[]> GetAllSubjectsOfLearningAreaAsync(string learningAreaCode) {
            return base.Channel.GetAllSubjectsOfLearningAreaAsync(learningAreaCode);
        }
        
        public eSAR.SubjectServiceRef.Subject[] GetAllSubjectsOfGradeLevel(string gradeLevel) {
            return base.Channel.GetAllSubjectsOfGradeLevel(gradeLevel);
        }
        
        public System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject[]> GetAllSubjectsOfGradeLevelAsync(string gradeLevel) {
            return base.Channel.GetAllSubjectsOfGradeLevelAsync(gradeLevel);
        }
        
        public eSAR.SubjectServiceRef.Subject GetSubject(string subjectCode) {
            return base.Channel.GetSubject(subjectCode);
        }
        
        public System.Threading.Tasks.Task<eSAR.SubjectServiceRef.Subject> GetSubjectAsync(string subjectCode) {
            return base.Channel.GetSubjectAsync(subjectCode);
        }
    }
}