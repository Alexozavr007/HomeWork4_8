using System.IO;
using System;
using System.Xml.Serialization;
using System.Text;

namespace HomeWork4_8_2 {

    public partial class Form1 : Form {

        private XmlSerializer serializer;

        public Form1() {
            InitializeComponent();
            InitializeObjectToSerialization();
        }

        private void btn1_Click(object sender, EventArgs e) {
            using (var ms = new MemoryStream()) {
                var person = (IPerson)propertyGrid1.SelectedObject;
                serializer.Serialize(ms, person);

                var xml = Encoding.UTF8.GetString(ms.ToArray());
                txtXml.Text = xml;
            }
        }

        private void SerializationModeChanged(object sender, EventArgs e) {
            InitializeObjectToSerialization();
        }

        private void InitializeObjectToSerialization() {
            IPerson person;
            if (rbSerializeDefault.Checked) {
                person = new Person {
                    Name = "Alex",
                    Age = 16,
                    Height = 182,
                    Weight = 72
                };
                serializer = new XmlSerializer(typeof(Person));
            } else {
                person = new PersonModified {
                    Name = "Alex",
                    Age = 16,
                    Height = 182,
                    Weight = 72
                };
                serializer = new XmlSerializer(typeof(PersonModified));
            }
            propertyGrid1.SelectedObject = person;
        }

        private void btn2_Click(object sender, EventArgs e) {
            using (var ms = new MemoryStream()) {
                var writer = new StreamWriter(ms);
                writer.AutoFlush = true;
                writer.Write(txtXml.Text);
                ms.Position = 0;

                var person = serializer.Deserialize(ms) as IPerson;
                propertyGrid2.SelectedObject = person;
            }
        }

    }
}
