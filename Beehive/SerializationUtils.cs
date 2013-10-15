using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;


class SerializationUtils
{

    //string s = SerializationUtils.SerializeObject(g);
    //BeehiveGame a = (BeehiveGame)SerializationUtils.DeserializeObject(s, typeof(BeehiveGame));
    public static string SerializeObject(object o)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
        StringWriter textWriter = new StringWriter();
        xmlSerializer.Serialize(textWriter, o);
        return textWriter.ToString();
    }

    public static object DeserializeObject(string s, Type t)
    {
        XmlSerializer mySerializer = new XmlSerializer(t);
        StringReader reader = new StringReader(s);
        return mySerializer.Deserialize(reader);
    }
}

