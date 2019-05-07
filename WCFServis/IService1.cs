using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServis
{
    //1-Web servisleri mutlaka bir IIS server üzerinde POST edilmelidir yoksa çalışmaz.
    //1-1- WCF servislerinin IIs serverda da POST edilebilir. Bir pcde de host edilebilir.
    /*2- Web servislerinde gidip/gelen bütün nesneler serileştirilmelidir
     * 2-1- WCF servislerinde Client ile Servis arasında gidip gelen servisler arasındaki veri
     * XML de olabilir, JSON da olabilir, başka herhangi bir nesne de olabilir.
     3- Web servislerini kullanan sistemlerde C# kodu yazmak gerekir.
      3-1 - Gidip gelen nesnenşn JSON olduğu belirtildiği zaman C# kodu yazmadan,
      WCF servisine bağlanılabilir ve jquery kodları ile servisten verş çkilip, gönderilebilir.
         * */
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    //IService1'den türeyen Service1.svc servisi, bu sözleşme ile kullanıma açılmıştır.
    //WCF'te bütün servislerin arka planında bir Interface vardır. Ve bütün servis sınıfları
    //Interface den türetilir.
    public interface IService1
    {

        [OperationContract]
        //Client tarafından ulaşılabilmesini sağlayan annotation
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
