﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentationElement
{
    public string iduser { get; set; }
    public string idpresentation { get; set; }
    public string filepath { get; set; }
    public object timeofcreation { get; set; }
    public string name { get; set; }
    public long? lastchange { get; set; }
}

public class ListResponse
{
    public List<PresentationElement> presentations { get; set; }
}
