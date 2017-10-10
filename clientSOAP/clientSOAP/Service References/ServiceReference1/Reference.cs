﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientSOAP.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="ServiceReference1.BanqueService")]
    public interface BanqueService {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/ConversionEuroToDhRequest", ReplyAction="http://ws/BanqueService/ConversionEuroToDhResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        clientSOAP.ServiceReference1.ConversionEuroToDhResponse ConversionEuroToDh(clientSOAP.ServiceReference1.ConversionEuroToDhRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getCompteRequest", ReplyAction="http://ws/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        clientSOAP.ServiceReference1.getCompteResponse getCompte(clientSOAP.ServiceReference1.getCompteRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getComptesRequest", ReplyAction="http://ws/BanqueService/getComptesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        clientSOAP.ServiceReference1.getComptesResponse getComptes(clientSOAP.ServiceReference1.getComptesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDh", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDhRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double montant;
        
        public ConversionEuroToDhRequest() {
        }
        
        public ConversionEuroToDhRequest(double montant) {
            this.montant = montant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDhResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDhResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConversionEuroToDhResponse() {
        }
        
        public ConversionEuroToDhResponse(double @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws/")]
    public partial class compte : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int codeField;
        
        private double soldeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double solde {
            get {
                return this.soldeField;
            }
            set {
                this.soldeField = value;
                this.RaisePropertyChanged("solde");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int code;
        
        public getCompteRequest() {
        }
        
        public getCompteRequest(int code) {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public clientSOAP.ServiceReference1.compte @return;
        
        public getCompteResponse() {
        }
        
        public getCompteResponse(clientSOAP.ServiceReference1.compte @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getComptes", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getComptesRequest {
        
        public getComptesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getComptesResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getComptesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public clientSOAP.ServiceReference1.compte[] @return;
        
        public getComptesResponse() {
        }
        
        public getComptesResponse(clientSOAP.ServiceReference1.compte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BanqueServiceChannel : clientSOAP.ServiceReference1.BanqueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<clientSOAP.ServiceReference1.BanqueService>, clientSOAP.ServiceReference1.BanqueService {
        
        public BanqueServiceClient() {
        }
        
        public BanqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientSOAP.ServiceReference1.ConversionEuroToDhResponse clientSOAP.ServiceReference1.BanqueService.ConversionEuroToDh(clientSOAP.ServiceReference1.ConversionEuroToDhRequest request) {
            return base.Channel.ConversionEuroToDh(request);
        }
        
        public double ConversionEuroToDh(double montant) {
            clientSOAP.ServiceReference1.ConversionEuroToDhRequest inValue = new clientSOAP.ServiceReference1.ConversionEuroToDhRequest();
            inValue.montant = montant;
            clientSOAP.ServiceReference1.ConversionEuroToDhResponse retVal = ((clientSOAP.ServiceReference1.BanqueService)(this)).ConversionEuroToDh(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientSOAP.ServiceReference1.getCompteResponse clientSOAP.ServiceReference1.BanqueService.getCompte(clientSOAP.ServiceReference1.getCompteRequest request) {
            return base.Channel.getCompte(request);
        }
        
        public clientSOAP.ServiceReference1.compte getCompte(int code) {
            clientSOAP.ServiceReference1.getCompteRequest inValue = new clientSOAP.ServiceReference1.getCompteRequest();
            inValue.code = code;
            clientSOAP.ServiceReference1.getCompteResponse retVal = ((clientSOAP.ServiceReference1.BanqueService)(this)).getCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientSOAP.ServiceReference1.getComptesResponse clientSOAP.ServiceReference1.BanqueService.getComptes(clientSOAP.ServiceReference1.getComptesRequest request) {
            return base.Channel.getComptes(request);
        }
        
        public clientSOAP.ServiceReference1.compte[] getComptes() {
            clientSOAP.ServiceReference1.getComptesRequest inValue = new clientSOAP.ServiceReference1.getComptesRequest();
            clientSOAP.ServiceReference1.getComptesResponse retVal = ((clientSOAP.ServiceReference1.BanqueService)(this)).getComptes(inValue);
            return retVal.@return;
        }
    }
}
