﻿using System.Collections.Generic;

namespace ExcelCombinator.Models.Interfaces
{
    public interface IParser
    {
        IEnumerable<IRelation> Columns { get; set; }
        IEnumerable<IRelation> KeysColumns { get; set; }
        string SheetName { get; set; }
    }
}