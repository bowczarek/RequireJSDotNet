﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RequireJsNet.Models
{
    public class RequireDependency
    {
        [XmlAttribute("dependency")]
        public string Dependency { get; set; }
    }
}
