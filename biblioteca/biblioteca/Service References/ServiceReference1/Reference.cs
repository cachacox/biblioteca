﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace biblioteca.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WSSoap")]
    public interface WSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultalibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet consultalibro(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultalibro", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> consultalibroAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultasocio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet consultasocio(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/consultasocio", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> consultasocioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarsocio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertarsocio(string nombre, string direccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertarsocio", ReplyAction="*")]
        System.Threading.Tasks.Task insertarsocioAsync(string nombre, string direccion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarsocio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarsocio(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarsocio", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarsocioAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSSoapChannel : biblioteca.ServiceReference1.WSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSSoapClient : System.ServiceModel.ClientBase<biblioteca.ServiceReference1.WSSoap>, biblioteca.ServiceReference1.WSSoap {
        
        public WSSoapClient() {
        }
        
        public WSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet consultalibro(int id) {
            return base.Channel.consultalibro(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> consultalibroAsync(int id) {
            return base.Channel.consultalibroAsync(id);
        }
        
        public System.Data.DataSet consultasocio(int id) {
            return base.Channel.consultasocio(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> consultasocioAsync(int id) {
            return base.Channel.consultasocioAsync(id);
        }
        
        public void insertarsocio(string nombre, string direccion) {
            base.Channel.insertarsocio(nombre, direccion);
        }
        
        public System.Threading.Tasks.Task insertarsocioAsync(string nombre, string direccion) {
            return base.Channel.insertarsocioAsync(nombre, direccion);
        }
        
        public void eliminarsocio(int id) {
            base.Channel.eliminarsocio(id);
        }
        
        public System.Threading.Tasks.Task eliminarsocioAsync(int id) {
            return base.Channel.eliminarsocioAsync(id);
        }
    }
}