﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Interview.Interfaces
{
    public interface IEntityBase
    {
        Guid Id { get; set; }
        bool IsDeleted { get; set; }
        Guid InsertedBy { get; set; }
        DateTime InsertedAt { get; set; }
        Guid UpdatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
