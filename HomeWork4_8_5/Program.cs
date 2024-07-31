using HomeWork4_8_5;
using System.Text;
using System.Xml.Serialization;

XmlSerializer serializer = new XmlSerializer(typeof(Car));


using (var ms = new MemoryStream()) {

    var car = new Car {
        Age = 12,
        Model = "Audi rs7"
    };

    serializer.Serialize(ms, car);

    var xml = Encoding.UTF8.GetString(ms.ToArray());
}