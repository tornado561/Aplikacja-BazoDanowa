﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VP_10_Base_Project.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/pokazWszystko", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable pokazWszystko();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/pokazWszystko", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> pokazWszystkoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/szukajPrzedmiot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable szukajPrzedmiot(string kategoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/szukajPrzedmiot", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> szukajPrzedmiotAsync(string kategoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/szukajKategorie", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable szukajKategorie();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/szukajKategorie", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> szukajKategorieAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/szukajPrzedmiotPoNazwie", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable szukajPrzedmiotPoNazwie(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/szukajPrzedmiotPoNazwie", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> szukajPrzedmiotPoNazwieAsync(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/newRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int newRecord(string kategoria, string nazwa, string cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/newRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<int> newRecordAsync(string kategoria, string nazwa, string cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int updateRecord(int id, string kategoria, string nazwa, string cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<int> updateRecordAsync(int id, string kategoria, string nazwa, string cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int deleteRecord(int id, string kategoria, string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<int> deleteRecordAsync(int id, string kategoria, string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/newClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int newClient(string imie, string nazwisko, string opis);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/newClient", ReplyAction="*")]
        System.Threading.Tasks.Task<int> newClientAsync(string imie, string nazwisko, string opis);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int updateClient(int id, string imie, string nazwisko, string opis);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateClient", ReplyAction="*")]
        System.Threading.Tasks.Task<int> updateClientAsync(int id, string imie, string nazwisko, string opis);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int deleteClient(int id, string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteClient", ReplyAction="*")]
        System.Threading.Tasks.Task<int> deleteClientAsync(int id, string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/searchClient", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable searchClient(string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/searchClient", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> searchClientAsync(string imie, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int insertRecord(string dane, string data, string liczba);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<int> insertRecordAsync(string dane, string data, string liczba);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getData", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : VP_10_Base_Project.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<VP_10_Base_Project.ServiceReference1.WebServiceSoap>, VP_10_Base_Project.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable pokazWszystko() {
            return base.Channel.pokazWszystko();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> pokazWszystkoAsync() {
            return base.Channel.pokazWszystkoAsync();
        }
        
        public System.Data.DataTable szukajPrzedmiot(string kategoria) {
            return base.Channel.szukajPrzedmiot(kategoria);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> szukajPrzedmiotAsync(string kategoria) {
            return base.Channel.szukajPrzedmiotAsync(kategoria);
        }
        
        public System.Data.DataTable szukajKategorie() {
            return base.Channel.szukajKategorie();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> szukajKategorieAsync() {
            return base.Channel.szukajKategorieAsync();
        }
        
        public System.Data.DataTable szukajPrzedmiotPoNazwie(string nazwa) {
            return base.Channel.szukajPrzedmiotPoNazwie(nazwa);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> szukajPrzedmiotPoNazwieAsync(string nazwa) {
            return base.Channel.szukajPrzedmiotPoNazwieAsync(nazwa);
        }
        
        public int newRecord(string kategoria, string nazwa, string cena) {
            return base.Channel.newRecord(kategoria, nazwa, cena);
        }
        
        public System.Threading.Tasks.Task<int> newRecordAsync(string kategoria, string nazwa, string cena) {
            return base.Channel.newRecordAsync(kategoria, nazwa, cena);
        }
        
        public int updateRecord(int id, string kategoria, string nazwa, string cena) {
            return base.Channel.updateRecord(id, kategoria, nazwa, cena);
        }
        
        public System.Threading.Tasks.Task<int> updateRecordAsync(int id, string kategoria, string nazwa, string cena) {
            return base.Channel.updateRecordAsync(id, kategoria, nazwa, cena);
        }
        
        public int deleteRecord(int id, string kategoria, string nazwa) {
            return base.Channel.deleteRecord(id, kategoria, nazwa);
        }
        
        public System.Threading.Tasks.Task<int> deleteRecordAsync(int id, string kategoria, string nazwa) {
            return base.Channel.deleteRecordAsync(id, kategoria, nazwa);
        }
        
        public int newClient(string imie, string nazwisko, string opis) {
            return base.Channel.newClient(imie, nazwisko, opis);
        }
        
        public System.Threading.Tasks.Task<int> newClientAsync(string imie, string nazwisko, string opis) {
            return base.Channel.newClientAsync(imie, nazwisko, opis);
        }
        
        public int updateClient(int id, string imie, string nazwisko, string opis) {
            return base.Channel.updateClient(id, imie, nazwisko, opis);
        }
        
        public System.Threading.Tasks.Task<int> updateClientAsync(int id, string imie, string nazwisko, string opis) {
            return base.Channel.updateClientAsync(id, imie, nazwisko, opis);
        }
        
        public int deleteClient(int id, string imie, string nazwisko) {
            return base.Channel.deleteClient(id, imie, nazwisko);
        }
        
        public System.Threading.Tasks.Task<int> deleteClientAsync(int id, string imie, string nazwisko) {
            return base.Channel.deleteClientAsync(id, imie, nazwisko);
        }
        
        public System.Data.DataTable searchClient(string imie, string nazwisko) {
            return base.Channel.searchClient(imie, nazwisko);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> searchClientAsync(string imie, string nazwisko) {
            return base.Channel.searchClientAsync(imie, nazwisko);
        }
        
        public int insertRecord(string dane, string data, string liczba) {
            return base.Channel.insertRecord(dane, data, liczba);
        }
        
        public System.Threading.Tasks.Task<int> insertRecordAsync(string dane, string data, string liczba) {
            return base.Channel.insertRecordAsync(dane, data, liczba);
        }
        
        public string getData() {
            return base.Channel.getData();
        }
        
        public System.Threading.Tasks.Task<string> getDataAsync() {
            return base.Channel.getDataAsync();
        }
    }
}
