﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fias.Update.Lib.FiasServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DownloadFileInfo", Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx")]
    [System.SerializableAttribute()]
    public partial class DownloadFileInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int VersionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FiasCompleteDbfUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FiasCompleteXmlUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FiasDeltaDbfUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FiasDeltaXmlUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Kladr4ArjUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Kladr47ZUrlField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int VersionId {
            get {
                return this.VersionIdField;
            }
            set {
                if ((this.VersionIdField.Equals(value) != true)) {
                    this.VersionIdField = value;
                    this.RaisePropertyChanged("VersionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string TextVersion {
            get {
                return this.TextVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.TextVersionField, value) != true)) {
                    this.TextVersionField = value;
                    this.RaisePropertyChanged("TextVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string FiasCompleteDbfUrl {
            get {
                return this.FiasCompleteDbfUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.FiasCompleteDbfUrlField, value) != true)) {
                    this.FiasCompleteDbfUrlField = value;
                    this.RaisePropertyChanged("FiasCompleteDbfUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string FiasCompleteXmlUrl {
            get {
                return this.FiasCompleteXmlUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.FiasCompleteXmlUrlField, value) != true)) {
                    this.FiasCompleteXmlUrlField = value;
                    this.RaisePropertyChanged("FiasCompleteXmlUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string FiasDeltaDbfUrl {
            get {
                return this.FiasDeltaDbfUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.FiasDeltaDbfUrlField, value) != true)) {
                    this.FiasDeltaDbfUrlField = value;
                    this.RaisePropertyChanged("FiasDeltaDbfUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string FiasDeltaXmlUrl {
            get {
                return this.FiasDeltaXmlUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.FiasDeltaXmlUrlField, value) != true)) {
                    this.FiasDeltaXmlUrlField = value;
                    this.RaisePropertyChanged("FiasDeltaXmlUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Kladr4ArjUrl {
            get {
                return this.Kladr4ArjUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.Kladr4ArjUrlField, value) != true)) {
                    this.Kladr4ArjUrlField = value;
                    this.RaisePropertyChanged("Kladr4ArjUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Kladr47ZUrl {
            get {
                return this.Kladr47ZUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.Kladr47ZUrlField, value) != true)) {
                    this.Kladr47ZUrlField = value;
                    this.RaisePropertyChanged("Kladr47ZUrl");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx", ConfigurationName="FiasServiceReference.DownloadServiceSoap")]
    public interface DownloadServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetLastDownloadFileInfoResult from namespace http://fias.nalog.ru/WebServices/Public/DownloadService.asmx is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx/GetLastDownloadFileI" +
            "nfo", ReplyAction="*")]
        Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoResponse GetLastDownloadFileInfo(Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllDownloadFileInfoResult from namespace http://fias.nalog.ru/WebServices/Public/DownloadService.asmx is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx/GetAllDownloadFileIn" +
            "fo", ReplyAction="*")]
        Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoResponse GetAllDownloadFileInfo(Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLastDownloadFileInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLastDownloadFileInfo", Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx", Order=0)]
        public Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoRequestBody Body;
        
        public GetLastDownloadFileInfoRequest() {
        }
        
        public GetLastDownloadFileInfoRequest(Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetLastDownloadFileInfoRequestBody {
        
        public GetLastDownloadFileInfoRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLastDownloadFileInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLastDownloadFileInfoResponse", Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx", Order=0)]
        public Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoResponseBody Body;
        
        public GetLastDownloadFileInfoResponse() {
        }
        
        public GetLastDownloadFileInfoResponse(Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx")]
    public partial class GetLastDownloadFileInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Fias.Update.Lib.FiasServiceReference.DownloadFileInfo GetLastDownloadFileInfoResult;
        
        public GetLastDownloadFileInfoResponseBody() {
        }
        
        public GetLastDownloadFileInfoResponseBody(Fias.Update.Lib.FiasServiceReference.DownloadFileInfo GetLastDownloadFileInfoResult) {
            this.GetLastDownloadFileInfoResult = GetLastDownloadFileInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllDownloadFileInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllDownloadFileInfo", Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx", Order=0)]
        public Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoRequestBody Body;
        
        public GetAllDownloadFileInfoRequest() {
        }
        
        public GetAllDownloadFileInfoRequest(Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllDownloadFileInfoRequestBody {
        
        public GetAllDownloadFileInfoRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllDownloadFileInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllDownloadFileInfoResponse", Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx", Order=0)]
        public Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoResponseBody Body;
        
        public GetAllDownloadFileInfoResponse() {
        }
        
        public GetAllDownloadFileInfoResponse(Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://fias.nalog.ru/WebServices/Public/DownloadService.asmx")]
    public partial class GetAllDownloadFileInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Fias.Update.Lib.FiasServiceReference.DownloadFileInfo[] GetAllDownloadFileInfoResult;
        
        public GetAllDownloadFileInfoResponseBody() {
        }
        
        public GetAllDownloadFileInfoResponseBody(Fias.Update.Lib.FiasServiceReference.DownloadFileInfo[] GetAllDownloadFileInfoResult) {
            this.GetAllDownloadFileInfoResult = GetAllDownloadFileInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DownloadServiceSoapChannel : Fias.Update.Lib.FiasServiceReference.DownloadServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DownloadServiceSoapClient : System.ServiceModel.ClientBase<Fias.Update.Lib.FiasServiceReference.DownloadServiceSoap>, Fias.Update.Lib.FiasServiceReference.DownloadServiceSoap {
        
        public DownloadServiceSoapClient() {
        }
        
        public DownloadServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DownloadServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DownloadServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DownloadServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoResponse Fias.Update.Lib.FiasServiceReference.DownloadServiceSoap.GetLastDownloadFileInfo(Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoRequest request) {
            return base.Channel.GetLastDownloadFileInfo(request);
        }
        
        public Fias.Update.Lib.FiasServiceReference.DownloadFileInfo GetLastDownloadFileInfo() {
            Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoRequest inValue = new Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoRequest();
            inValue.Body = new Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoRequestBody();
            Fias.Update.Lib.FiasServiceReference.GetLastDownloadFileInfoResponse retVal = ((Fias.Update.Lib.FiasServiceReference.DownloadServiceSoap)(this)).GetLastDownloadFileInfo(inValue);
            return retVal.Body.GetLastDownloadFileInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoResponse Fias.Update.Lib.FiasServiceReference.DownloadServiceSoap.GetAllDownloadFileInfo(Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoRequest request) {
            return base.Channel.GetAllDownloadFileInfo(request);
        }
        
        public Fias.Update.Lib.FiasServiceReference.DownloadFileInfo[] GetAllDownloadFileInfo() {
            Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoRequest inValue = new Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoRequest();
            inValue.Body = new Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoRequestBody();
            Fias.Update.Lib.FiasServiceReference.GetAllDownloadFileInfoResponse retVal = ((Fias.Update.Lib.FiasServiceReference.DownloadServiceSoap)(this)).GetAllDownloadFileInfo(inValue);
            return retVal.Body.GetAllDownloadFileInfoResult;
        }
    }
}
