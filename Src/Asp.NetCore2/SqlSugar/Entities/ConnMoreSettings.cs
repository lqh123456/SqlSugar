﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugar
{
    public class ConnMoreSettings
    {
        public bool IsAutoRemoveDataCache { get; set; }
        public bool IsWithNoLockQuery { get; set; }
       
        public bool DisableNvarchar { get; set; }
        public bool DisableMillisecond { get; set; }
        public bool PgSqlIsAutoToLower = true;
        public int DefaultCacheDurationInSeconds { get; set; }
        public bool? TableEnumIsString { get; set; } 
    }
}
