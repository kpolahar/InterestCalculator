﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace InterestCalculator.Data
{
    public class InterestData
    {
        public DataSet dataSet { get; set; }

        public InterestData()
        {
            // Try/Catch
            try
            {
                string xml = File.ReadAllText("/Users/kpolahar/Docs/Dev/Freelance/Clearent/InterestCalculator/InterestCalculator/Data/InterestData.xml");
                XmlSerializer xmlData = new XmlSerializer(typeof(DataSet));
                XmlTextReader xmlReader = new XmlTextReader(new StringReader(xml));

                this.dataSet = xmlData.Deserialize(xmlReader) as DataSet;

                if ((this.dataSet == null) || (this.dataSet.CardTypes == null) || (this.dataSet.CardTypes.Count == 0))
                    throw new Exception("An error occurred while deserializing card type data.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Serializable, XmlRoot(ElementName = "DataSet")]
        public class DataSet
        {
            [XmlArray("CardTypes")]
            [XmlArrayItem("CardType", typeof(CardType))]
            public List<CardType> CardTypes { get; set; }
        }

        [Serializable, XmlRoot(ElementName = "CardType")]
        public class CardType
        {
            public string Name { get; set; }
            public string InterestRate { get; set; }
        }
    }
}