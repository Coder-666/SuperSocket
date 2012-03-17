﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperSocket.Management.Client.Config
{
    [XmlType("Server")]
    public class ServerConfig
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("uri")]
        public string Uri { get; set; }

        [XmlAttribute("username")]
        public string UserName { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }
    }
}
