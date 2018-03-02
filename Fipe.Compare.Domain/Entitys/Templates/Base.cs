using System;
using System.Collections.Generic;
using System.Text;

namespace Fipe.Compare.Domain.Entitys.Templates
{
    public abstract class Base
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
