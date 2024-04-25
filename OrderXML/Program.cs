using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLDocCreator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();

            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(xmlDeclaration);

            XmlElement root = xmlDocument.CreateElement("Orders");
            xmlDocument.AppendChild(root);

            XmlElement order = xmlDocument.CreateElement("Order");
            XmlElement orderID = xmlDocument.CreateElement("OrderID");
            orderID.InnerText = "1";
            XmlElement orderDate = xmlDocument.CreateElement("OrderDate");
            orderDate.InnerText = "1/1/2021";
            XmlElement shippingPrice = xmlDocument.CreateElement("ShippingPrice");
            shippingPrice.InnerText = "12.99";
            order.AppendChild(orderID);
            order.AppendChild(orderDate);
            order.AppendChild(shippingPrice);

            XmlElement orderDetails = xmlDocument.CreateElement("OrderDetails");
            XmlElement orderDetail = xmlDocument.CreateElement("OrderDetail");
            XmlElement orderDetailID = xmlDocument.CreateElement("OrderDetailID");
            orderDetailID.InnerText = "i";
            XmlElement productID = xmlDocument.CreateElement("ProductID");
            productID.InnerText = "11";
            orderDetail.AppendChild(orderDetailID);
            orderDetail.AppendChild(orderID);
            orderDetail.AppendChild(productID);

            XmlElement options = xmlDocument.CreateElement("Options");
            XmlElement size = xmlDocument.CreateElement("Size");
            XmlElement optionValue = xmlDocument.CreateElement("OptionValue");
            optionValue.InnerText = "Small";
            size.AppendChild(optionValue);
            options.AppendChild(size);

            XmlElement color = xmlDocument.CreateElement("Color");
            optionValue.InnerText = "Blue";
            color.AppendChild(optionValue);
            options.AppendChild(color);
            orderDetail.AppendChild(options);

            XmlElement quantity = xmlDocument.CreateElement("Quantity");
            quantity.InnerText = "2";
            XmlElement price = xmlDocument.CreateElement("Price");
            price.InnerText = "9.99";
            // Products />
            orderDetail.AppendChild(quantity);
            orderDetail.AppendChild(price);

            orderDetails.AppendChild(orderDetail);

            orderDetailID.InnerText = "2";
            productID.InnerText = "12";
            orderDetail.AppendChild(orderDetailID);
            orderDetail.AppendChild(orderID);
            orderDetail.AppendChild(productID);

            optionValue.InnerText = "11";
            size.AppendChild(optionValue);
            options.AppendChild(size);

            optionValue.InnerText = "Black";
            color.AppendChild(optionValue);
            options.AppendChild(color);
            orderDetail.AppendChild(options);

            quantity.InnerText = "5";
            price.InnerText = "20.00";
            // Products />
            orderDetail.AppendChild(quantity);
            orderDetail.AppendChild(price);
            orderDetails.AppendChild(orderDetail);

            order.AppendChild(orderDetails);
            root.AppendChild(order);


            XmlElement customer = xmlDocument.CreateElement("Customer");
            XmlElement customerID = xmlDocument.CreateElement("CustomerID");
            customerID.InnerText = "1";
            XmlElement firstName = xmlDocument.CreateElement("FirstName");
            firstName.InnerText = "Jane";
            XmlElement lastName = xmlDocument.CreateElement("LastName");
            lastName.InnerText = "Doe";
            XmlElement shippingAddressID = xmlDocument.CreateElement("ShippingAddressID");
            shippingAddressID.InnerText = "1";
            XmlElement billingAddressID = xmlDocument.CreateElement("BillingAddressID");
            billingAddressID.InnerText = "2";
            XmlElement email = xmlDocument.CreateElement("Email");
            email.InnerText = "jane@doe.com";
            customer.AppendChild(customerID);
            customer.AppendChild(firstName);
            customer.AppendChild(lastName);
            customer.AppendChild(shippingAddressID);
            customer.AppendChild(billingAddressID);
            customer.AppendChild(email);

            XmlElement shippingAddress = xmlDocument.CreateElement("ShippingAddress");
            XmlElement addressID = xmlDocument.CreateElement("AddressID");
            addressID.InnerText = "1";
            XmlElement street1 = xmlDocument.CreateElement("Street1");
            street1.InnerText = "12 Main St";
            XmlElement street2 = xmlDocument.CreateElement("Street2");
            street2.InnerText = "Apt 111";
            XmlElement city = xmlDocument.CreateElement("City");
            city.InnerText = "Davie";
            XmlElement state = xmlDocument.CreateElement("State");
            state.InnerText = "FL";
            XmlElement zip = xmlDocument.CreateElement("Zip");
            zip.InnerText = "33314";
            shippingAddress.AppendChild(addressID);
            shippingAddress.AppendChild(street1);
            shippingAddress.AppendChild(street2);
            shippingAddress.AppendChild(city);
            shippingAddress.AppendChild(state);
            shippingAddress.AppendChild(zip);
            customer.AppendChild(shippingAddress);

            XmlElement billingAddress = xmlDocument.CreateElement("BillingAddress");
            addressID.InnerText = "2";
            street1.InnerText = "PO Box 123456";
            city.InnerText = "Davie";
            state.InnerText = "FL";
            zip.InnerText = "33329";
            billingAddress.AppendChild(addressID);
            billingAddress.AppendChild(street1);
            billingAddress.AppendChild(city);
            billingAddress.AppendChild(state);
            billingAddress.AppendChild(zip);
            customer.AppendChild(billingAddress);         
            
            order.AppendChild(customer);

            root.AppendChild(order);


            xmlDocument.Save("order.xml");

            Console.WriteLine("XML Created Successfully");
            Console.ReadKey();

            XmlDocument readXML = new XmlDocument();
            readXML.Load("order.xml");
            Console.WriteLine("Below are the contents of the XML");
            Console.WriteLine(readXML.OuterXml);
            Console.ReadKey();
        }
    }
}
