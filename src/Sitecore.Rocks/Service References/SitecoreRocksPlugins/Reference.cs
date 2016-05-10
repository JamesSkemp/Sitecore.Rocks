﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Rocks.SitecoreRocksPlugins {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sitecore.net/rocks/plugins", ConfigurationName="SitecoreRocksPlugins.SitecoreRocksPluginsSoap")]
    public interface SitecoreRocksPluginsSoap {
        
        // CODEGEN: Generating message contract since element name ListResult from namespace http://sitecore.net/rocks/plugins is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/rocks/plugins/List", ReplyAction="*")]
        Sitecore.Rocks.SitecoreRocksPlugins.ListResponse List(Sitecore.Rocks.SitecoreRocksPlugins.ListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://sitecore.net/rocks/plugins/List", ReplyAction="*")]
        System.IAsyncResult BeginList(Sitecore.Rocks.SitecoreRocksPlugins.ListRequest request, System.AsyncCallback callback, object asyncState);
        
        Sitecore.Rocks.SitecoreRocksPlugins.ListResponse EndList(System.IAsyncResult result);
        
        // CODEGEN: Generating message contract since element name name from namespace http://sitecore.net/rocks/plugins is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/rocks/plugins/Upload", ReplyAction="*")]
        Sitecore.Rocks.SitecoreRocksPlugins.UploadResponse Upload(Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://sitecore.net/rocks/plugins/Upload", ReplyAction="*")]
        System.IAsyncResult BeginUpload(Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest request, System.AsyncCallback callback, object asyncState);
        
        Sitecore.Rocks.SitecoreRocksPlugins.UploadResponse EndUpload(System.IAsyncResult result);
        
        // CODEGEN: Generating message contract since element name name from namespace http://sitecore.net/rocks/plugins is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/rocks/plugins/Download", ReplyAction="*")]
        Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponse Download(Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://sitecore.net/rocks/plugins/Download", ReplyAction="*")]
        System.IAsyncResult BeginDownload(Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest request, System.AsyncCallback callback, object asyncState);
        
        Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponse EndDownload(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="List", Namespace="http://sitecore.net/rocks/plugins", Order=0)]
        public Sitecore.Rocks.SitecoreRocksPlugins.ListRequestBody Body;
        
        public ListRequest() {
        }
        
        public ListRequest(Sitecore.Rocks.SitecoreRocksPlugins.ListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListRequestBody {
        
        public ListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListResponse", Namespace="http://sitecore.net/rocks/plugins", Order=0)]
        public Sitecore.Rocks.SitecoreRocksPlugins.ListResponseBody Body;
        
        public ListResponse() {
        }
        
        public ListResponse(Sitecore.Rocks.SitecoreRocksPlugins.ListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/rocks/plugins")]
    public partial class ListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ListResult;
        
        public ListResponseBody() {
        }
        
        public ListResponseBody(string ListResult) {
            this.ListResult = ListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Upload", Namespace="http://sitecore.net/rocks/plugins", Order=0)]
        public Sitecore.Rocks.SitecoreRocksPlugins.UploadRequestBody Body;
        
        public UploadRequest() {
        }
        
        public UploadRequest(Sitecore.Rocks.SitecoreRocksPlugins.UploadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/rocks/plugins")]
    public partial class UploadRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string author;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string pluginVersion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string requiredVersion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string description;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string categories;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string previewFormat;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public byte[] file;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public byte[] source;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public byte[] preview;
        
        public UploadRequestBody() {
        }
        
        public UploadRequestBody(string name, string author, string pluginVersion, string requiredVersion, string description, string categories, string previewFormat, byte[] file, byte[] source, byte[] preview) {
            this.name = name;
            this.author = author;
            this.pluginVersion = pluginVersion;
            this.requiredVersion = requiredVersion;
            this.description = description;
            this.categories = categories;
            this.previewFormat = previewFormat;
            this.file = file;
            this.source = source;
            this.preview = preview;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadResponse", Namespace="http://sitecore.net/rocks/plugins", Order=0)]
        public Sitecore.Rocks.SitecoreRocksPlugins.UploadResponseBody Body;
        
        public UploadResponse() {
        }
        
        public UploadResponse(Sitecore.Rocks.SitecoreRocksPlugins.UploadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/rocks/plugins")]
    public partial class UploadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UploadResult;
        
        public UploadResponseBody() {
        }
        
        public UploadResponseBody(string UploadResult) {
            this.UploadResult = UploadResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DownloadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Download", Namespace="http://sitecore.net/rocks/plugins", Order=0)]
        public Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequestBody Body;
        
        public DownloadRequest() {
        }
        
        public DownloadRequest(Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/rocks/plugins")]
    public partial class DownloadRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public DownloadRequestBody() {
        }
        
        public DownloadRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DownloadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DownloadResponse", Namespace="http://sitecore.net/rocks/plugins", Order=0)]
        public Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponseBody Body;
        
        public DownloadResponse() {
        }
        
        public DownloadResponse(Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/rocks/plugins")]
    public partial class DownloadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DownloadResult;
        
        public DownloadResponseBody() {
        }
        
        public DownloadResponseBody(string DownloadResult) {
            this.DownloadResult = DownloadResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SitecoreRocksPluginsSoapChannel : Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UploadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UploadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DownloadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DownloadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SitecoreRocksPluginsSoapClient : System.ServiceModel.ClientBase<Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap>, Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap {
        
        private BeginOperationDelegate onBeginListDelegate;
        
        private EndOperationDelegate onEndListDelegate;
        
        private System.Threading.SendOrPostCallback onListCompletedDelegate;
        
        private BeginOperationDelegate onBeginUploadDelegate;
        
        private EndOperationDelegate onEndUploadDelegate;
        
        private System.Threading.SendOrPostCallback onUploadCompletedDelegate;
        
        private BeginOperationDelegate onBeginDownloadDelegate;
        
        private EndOperationDelegate onEndDownloadDelegate;
        
        private System.Threading.SendOrPostCallback onDownloadCompletedDelegate;
        
        public SitecoreRocksPluginsSoapClient() {
        }
        
        public SitecoreRocksPluginsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SitecoreRocksPluginsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SitecoreRocksPluginsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SitecoreRocksPluginsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<ListCompletedEventArgs> ListCompleted;
        
        public event System.EventHandler<UploadCompletedEventArgs> UploadCompleted;
        
        public event System.EventHandler<DownloadCompletedEventArgs> DownloadCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Rocks.SitecoreRocksPlugins.ListResponse Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.List(Sitecore.Rocks.SitecoreRocksPlugins.ListRequest request) {
            return base.Channel.List(request);
        }
        
        public string List() {
            Sitecore.Rocks.SitecoreRocksPlugins.ListRequest inValue = new Sitecore.Rocks.SitecoreRocksPlugins.ListRequest();
            inValue.Body = new Sitecore.Rocks.SitecoreRocksPlugins.ListRequestBody();
            Sitecore.Rocks.SitecoreRocksPlugins.ListResponse retVal = ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).List(inValue);
            return retVal.Body.ListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.BeginList(Sitecore.Rocks.SitecoreRocksPlugins.ListRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginList(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginList(System.AsyncCallback callback, object asyncState) {
            Sitecore.Rocks.SitecoreRocksPlugins.ListRequest inValue = new Sitecore.Rocks.SitecoreRocksPlugins.ListRequest();
            inValue.Body = new Sitecore.Rocks.SitecoreRocksPlugins.ListRequestBody();
            return ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).BeginList(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Rocks.SitecoreRocksPlugins.ListResponse Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.EndList(System.IAsyncResult result) {
            return base.Channel.EndList(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndList(System.IAsyncResult result) {
            Sitecore.Rocks.SitecoreRocksPlugins.ListResponse retVal = ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).EndList(result);
            return retVal.Body.ListResult;
        }
        
        private System.IAsyncResult OnBeginList(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginList(callback, asyncState);
        }
        
        private object[] OnEndList(System.IAsyncResult result) {
            string retVal = this.EndList(result);
            return new object[] {
                    retVal};
        }
        
        private void OnListCompleted(object state) {
            if ((this.ListCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ListCompleted(this, new ListCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ListAsync() {
            this.ListAsync(null);
        }
        
        public void ListAsync(object userState) {
            if ((this.onBeginListDelegate == null)) {
                this.onBeginListDelegate = new BeginOperationDelegate(this.OnBeginList);
            }
            if ((this.onEndListDelegate == null)) {
                this.onEndListDelegate = new EndOperationDelegate(this.OnEndList);
            }
            if ((this.onListCompletedDelegate == null)) {
                this.onListCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnListCompleted);
            }
            base.InvokeAsync(this.onBeginListDelegate, null, this.onEndListDelegate, this.onListCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Rocks.SitecoreRocksPlugins.UploadResponse Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.Upload(Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest request) {
            return base.Channel.Upload(request);
        }
        
        public string Upload(string name, string author, string pluginVersion, string requiredVersion, string description, string categories, string previewFormat, byte[] file, byte[] source, byte[] preview) {
            Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest inValue = new Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest();
            inValue.Body = new Sitecore.Rocks.SitecoreRocksPlugins.UploadRequestBody();
            inValue.Body.name = name;
            inValue.Body.author = author;
            inValue.Body.pluginVersion = pluginVersion;
            inValue.Body.requiredVersion = requiredVersion;
            inValue.Body.description = description;
            inValue.Body.categories = categories;
            inValue.Body.previewFormat = previewFormat;
            inValue.Body.file = file;
            inValue.Body.source = source;
            inValue.Body.preview = preview;
            Sitecore.Rocks.SitecoreRocksPlugins.UploadResponse retVal = ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).Upload(inValue);
            return retVal.Body.UploadResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.BeginUpload(Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpload(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUpload(string name, string author, string pluginVersion, string requiredVersion, string description, string categories, string previewFormat, byte[] file, byte[] source, byte[] preview, System.AsyncCallback callback, object asyncState) {
            Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest inValue = new Sitecore.Rocks.SitecoreRocksPlugins.UploadRequest();
            inValue.Body = new Sitecore.Rocks.SitecoreRocksPlugins.UploadRequestBody();
            inValue.Body.name = name;
            inValue.Body.author = author;
            inValue.Body.pluginVersion = pluginVersion;
            inValue.Body.requiredVersion = requiredVersion;
            inValue.Body.description = description;
            inValue.Body.categories = categories;
            inValue.Body.previewFormat = previewFormat;
            inValue.Body.file = file;
            inValue.Body.source = source;
            inValue.Body.preview = preview;
            return ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).BeginUpload(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Rocks.SitecoreRocksPlugins.UploadResponse Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.EndUpload(System.IAsyncResult result) {
            return base.Channel.EndUpload(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndUpload(System.IAsyncResult result) {
            Sitecore.Rocks.SitecoreRocksPlugins.UploadResponse retVal = ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).EndUpload(result);
            return retVal.Body.UploadResult;
        }
        
        private System.IAsyncResult OnBeginUpload(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string name = ((string)(inValues[0]));
            string author = ((string)(inValues[1]));
            string pluginVersion = ((string)(inValues[2]));
            string requiredVersion = ((string)(inValues[3]));
            string description = ((string)(inValues[4]));
            string categories = ((string)(inValues[5]));
            string previewFormat = ((string)(inValues[6]));
            byte[] file = ((byte[])(inValues[7]));
            byte[] source = ((byte[])(inValues[8]));
            byte[] preview = ((byte[])(inValues[9]));
            return this.BeginUpload(name, author, pluginVersion, requiredVersion, description, categories, previewFormat, file, source, preview, callback, asyncState);
        }
        
        private object[] OnEndUpload(System.IAsyncResult result) {
            string retVal = this.EndUpload(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUploadCompleted(object state) {
            if ((this.UploadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UploadCompleted(this, new UploadCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UploadAsync(string name, string author, string pluginVersion, string requiredVersion, string description, string categories, string previewFormat, byte[] file, byte[] source, byte[] preview) {
            this.UploadAsync(name, author, pluginVersion, requiredVersion, description, categories, previewFormat, file, source, preview, null);
        }
        
        public void UploadAsync(string name, string author, string pluginVersion, string requiredVersion, string description, string categories, string previewFormat, byte[] file, byte[] source, byte[] preview, object userState) {
            if ((this.onBeginUploadDelegate == null)) {
                this.onBeginUploadDelegate = new BeginOperationDelegate(this.OnBeginUpload);
            }
            if ((this.onEndUploadDelegate == null)) {
                this.onEndUploadDelegate = new EndOperationDelegate(this.OnEndUpload);
            }
            if ((this.onUploadCompletedDelegate == null)) {
                this.onUploadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUploadCompleted);
            }
            base.InvokeAsync(this.onBeginUploadDelegate, new object[] {
                        name,
                        author,
                        pluginVersion,
                        requiredVersion,
                        description,
                        categories,
                        previewFormat,
                        file,
                        source,
                        preview}, this.onEndUploadDelegate, this.onUploadCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponse Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.Download(Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest request) {
            return base.Channel.Download(request);
        }
        
        public string Download(string name) {
            Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest inValue = new Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest();
            inValue.Body = new Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequestBody();
            inValue.Body.name = name;
            Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponse retVal = ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).Download(inValue);
            return retVal.Body.DownloadResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.BeginDownload(Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDownload(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDownload(string name, System.AsyncCallback callback, object asyncState) {
            Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest inValue = new Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequest();
            inValue.Body = new Sitecore.Rocks.SitecoreRocksPlugins.DownloadRequestBody();
            inValue.Body.name = name;
            return ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).BeginDownload(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponse Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap.EndDownload(System.IAsyncResult result) {
            return base.Channel.EndDownload(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndDownload(System.IAsyncResult result) {
            Sitecore.Rocks.SitecoreRocksPlugins.DownloadResponse retVal = ((Sitecore.Rocks.SitecoreRocksPlugins.SitecoreRocksPluginsSoap)(this)).EndDownload(result);
            return retVal.Body.DownloadResult;
        }
        
        private System.IAsyncResult OnBeginDownload(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string name = ((string)(inValues[0]));
            return this.BeginDownload(name, callback, asyncState);
        }
        
        private object[] OnEndDownload(System.IAsyncResult result) {
            string retVal = this.EndDownload(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDownloadCompleted(object state) {
            if ((this.DownloadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DownloadCompleted(this, new DownloadCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DownloadAsync(string name) {
            this.DownloadAsync(name, null);
        }
        
        public void DownloadAsync(string name, object userState) {
            if ((this.onBeginDownloadDelegate == null)) {
                this.onBeginDownloadDelegate = new BeginOperationDelegate(this.OnBeginDownload);
            }
            if ((this.onEndDownloadDelegate == null)) {
                this.onEndDownloadDelegate = new EndOperationDelegate(this.OnEndDownload);
            }
            if ((this.onDownloadCompletedDelegate == null)) {
                this.onDownloadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDownloadCompleted);
            }
            base.InvokeAsync(this.onBeginDownloadDelegate, new object[] {
                        name}, this.onEndDownloadDelegate, this.onDownloadCompletedDelegate, userState);
        }
    }
}
