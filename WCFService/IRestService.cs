using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestService" in both code and config file together.
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebInvoke(Method="GET",UriTemplate="/add/{a}/{b}",RequestFormat=WebMessageFormat.Json,ResponseFormat=WebMessageFormat.Json,BodyStyle=WebMessageBodyStyle.Wrapped)]
        string getAddition(string a,string b);
    }
}
