﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OpenQbit.Masterdb.Common.Model
{
     public class Resorce
    {
        public int ID { get; set; }
        //get the resource id key
        public int ResourceTypeID { get; set; }

        public virtual ResourceType Type { get; set; }

        [Column(TypeName = "xml")]
        public string DetailsXml { get; set; }

        [NotMapped]
        public XDocument DetailsElement
        {
            get { return DetailsXml != null ? XDocument.Parse(DetailsXml) : null; }
            set { DetailsXml = value.ToString(); }
        }
    }
}
