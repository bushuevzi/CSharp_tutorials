using System;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SimpleSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Serialization *****\n");
            //Make a James BondCar and set state
            JamesBondCar jbc = new JamesBondCar();
            jbc.canFly = true;
            jbc.canSubmerge = false;
            jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
            jbc.theRadio.hasTweeters = true;

            //Now save the car to a specific file in binary format
            SaveAsXmlFormat(jbc, "CarData.dat");

            //Now load the car from specific file to object
        }

        static void SaveAsXmlFormat(object objGraph, string fileName)
        {
            //Save object to a file named CarData.xml in XML format
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                xmlFormat.Serialize(fStream, objGraph);
            Console.WriteLine("=> Saved car in XML format!");
        }

        static void LoadFromXmlFile(string fileName)
        {
        }

        static void SaveAsSoapFormat(object objGraph, string fileName)
        {
            //Save object to a file named CarData.dat in binary
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                soapFormat.Serialize(fStream, objGraph);

            Console.WriteLine("=> Saved car in SOAP format!");
        }

        static void LoadFromSoapFile(string fileName)
        {
            SoapFormatter soapFormat = new SoapFormatter();
            //Read the JamesBondCar from the binary file
            using(Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk = (JamesBondCar)soapFormat.Deserialize(fStream);
                Console.WriteLine($"Can this car fly? : {carFromDisk.canFly}");
            }
        }
    }

    [Serializable]
    public class Radio
    {
        public bool hasTweeters;
        public bool hasSubwoofers;
        public double[] stationPresets;
        [NonSerialized]
        public string radioID = "XF-552RR6";
    }

    [Serializable]
    public class Car
    {
        public Radio theRadio = new Radio();
        public bool isHatchBack;
    }

    [Serializable]
    public class JamesBondCar : Car
    {
        [XmlAttribute]
        public bool canFly;
        [XmlAttribute]
        public bool canSubmerge;
    }
}
