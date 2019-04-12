﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantReviewService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RestaurantInfo", Namespace="http://schemas.datacontract.org/2004/07/AlgonquinCollege.OnlineService.Restaurant" +
        "Review")]
    public partial class RestaurantInfo : object
    {
        
        private RestaurantReviewService.Address LocationField;
        
        private string NameField;
        
        private string RatingField;
        
        private string SummaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RestaurantReviewService.Address Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rating
        {
            get
            {
                return this.RatingField;
            }
            set
            {
                this.RatingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary
        {
            get
            {
                return this.SummaryField;
            }
            set
            {
                this.SummaryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/AlgonquinCollege.OnlineService.Restaurant" +
        "Review")]
    public partial class Address : object
    {
        
        private string CityField;
        
        private string PostalCodeField;
        
        private string ProvinceField;
        
        private string StreetField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode
        {
            get
            {
                return this.PostalCodeField;
            }
            set
            {
                this.PostalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Province
        {
            get
            {
                return this.ProvinceField;
            }
            set
            {
                this.ProvinceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street
        {
            get
            {
                return this.StreetField;
            }
            set
            {
                this.StreetField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RestaurantReviewService.IRestaurantService")]
    public interface IRestaurantService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/GetRestaurantNames", ReplyAction="http://tempuri.org/IRestaurantService/GetRestaurantNamesResponse")]
        System.Threading.Tasks.Task<string[]> GetRestaurantNamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/GetRestaurantByName", ReplyAction="http://tempuri.org/IRestaurantService/GetRestaurantByNameResponse")]
        System.Threading.Tasks.Task<RestaurantReviewService.RestaurantInfo> GetRestaurantByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/GetRestaurantsByRating", ReplyAction="http://tempuri.org/IRestaurantService/GetRestaurantsByRatingResponse")]
        System.Threading.Tasks.Task<RestaurantReviewService.RestaurantInfo[]> GetRestaurantsByRatingAsync(int rating);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/SaveRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/SaveRestaurantResponse")]
        System.Threading.Tasks.Task<bool> SaveRestaurantAsync(RestaurantReviewService.RestaurantInfo restInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IRestaurantServiceChannel : RestaurantReviewService.IRestaurantService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class RestaurantServiceClient : System.ServiceModel.ClientBase<RestaurantReviewService.IRestaurantService>, RestaurantReviewService.IRestaurantService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public RestaurantServiceClient() : 
                base(RestaurantServiceClient.GetDefaultBinding(), RestaurantServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IRestaurantService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RestaurantServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(RestaurantServiceClient.GetBindingForEndpoint(endpointConfiguration), RestaurantServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RestaurantServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(RestaurantServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RestaurantServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(RestaurantServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RestaurantServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string[]> GetRestaurantNamesAsync()
        {
            return base.Channel.GetRestaurantNamesAsync();
        }
        
        public System.Threading.Tasks.Task<RestaurantReviewService.RestaurantInfo> GetRestaurantByNameAsync(string name)
        {
            return base.Channel.GetRestaurantByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<RestaurantReviewService.RestaurantInfo[]> GetRestaurantsByRatingAsync(int rating)
        {
            return base.Channel.GetRestaurantsByRatingAsync(rating);
        }
        
        public System.Threading.Tasks.Task<bool> SaveRestaurantAsync(RestaurantReviewService.RestaurantInfo restInfo)
        {
            return base.Channel.SaveRestaurantAsync(restInfo);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IRestaurantService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IRestaurantService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:56850/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return RestaurantServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IRestaurantService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return RestaurantServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IRestaurantService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IRestaurantService,
        }
    }
}
