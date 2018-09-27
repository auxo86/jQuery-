using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace jQuery練習
{
    /// <summary>
    ///CustomerInfo 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
    [System.Web.Script.Services.ScriptService]
    public class CustomerInfo : System.Web.Services.WebService
    {

        //Webservice
        [WebMethod]
        public Customer GetCustomer(string id)
        {
            List<Customer> data = new List<Customer> {
               new Customer{CustomerId="123", Name="Mary"},
               new Customer{CustomerId="223", Name="Candy"},
               new Customer{CustomerId="323", Name="Lili"}
           };
            Customer customer = data.Find(c => c.CustomerId == id);

            return customer;
        }
    }
    public class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
    }

}
