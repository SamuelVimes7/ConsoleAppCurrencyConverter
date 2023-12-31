﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Converter.FxRatesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.lb.lt/WebServices/FxRates", ConfigurationName="FxRatesService.FxRatesSoap")]
    public interface FxRatesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getCurrencyList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCurrencyList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getCurrencyList", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCurrencyListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getCurrentFxRates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCurrentFxRates(string tp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getCurrentFxRates", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCurrentFxRatesAsync(string tp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getFxRates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getFxRates(string tp, string dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getFxRates", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getFxRatesAsync(string tp, string dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getFxRatesForCurrency", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getFxRatesForCurrency(string tp, string ccy, string dtFrom, string dtTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.lb.lt/WebServices/FxRates/getFxRatesForCurrency", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getFxRatesForCurrencyAsync(string tp, string ccy, string dtFrom, string dtTo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FxRatesSoapChannel : Converter.FxRatesService.FxRatesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FxRatesSoapClient : System.ServiceModel.ClientBase<Converter.FxRatesService.FxRatesSoap>, Converter.FxRatesService.FxRatesSoap {
        
        public FxRatesSoapClient() {
        }
        
        public FxRatesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FxRatesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FxRatesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FxRatesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Xml.XmlNode getCurrencyList() {
            return base.Channel.getCurrencyList();
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCurrencyListAsync() {
            return base.Channel.getCurrencyListAsync();
        }
        
        public System.Xml.XmlNode getCurrentFxRates(string tp) {
            return base.Channel.getCurrentFxRates(tp);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCurrentFxRatesAsync(string tp) {
            return base.Channel.getCurrentFxRatesAsync(tp);
        }
        
        public System.Xml.XmlNode getFxRates(string tp, string dt) {
            return base.Channel.getFxRates(tp, dt);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getFxRatesAsync(string tp, string dt) {
            return base.Channel.getFxRatesAsync(tp, dt);
        }
        
        public System.Xml.XmlNode getFxRatesForCurrency(string tp, string ccy, string dtFrom, string dtTo) {
            return base.Channel.getFxRatesForCurrency(tp, ccy, dtFrom, dtTo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getFxRatesForCurrencyAsync(string tp, string ccy, string dtFrom, string dtTo) {
            return base.Channel.getFxRatesForCurrencyAsync(tp, ccy, dtFrom, dtTo);
        }
    }
}
