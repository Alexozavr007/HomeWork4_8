using System.Xml.Serialization;

namespace HomeWork4_8_2;

[XmlRoot("Person")]
public class PersonModified : IPerson {

    [XmlAttribute("Age")]
    public int Age { get; set; }

    [XmlAttribute("Name")]
    public string Name { get; set; }

    [XmlAttribute("Height")]
    public float Height { get; set; }

    [XmlAttribute("Weight")]
    public float Weight { get; set; }

}