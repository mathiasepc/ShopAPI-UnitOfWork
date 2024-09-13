﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain;

public class BaseModel
{
    private Guid _id;
    public Guid Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name { get; set; }

    public BaseModel()
    {
        _id = Guid.NewGuid();
    }
}
