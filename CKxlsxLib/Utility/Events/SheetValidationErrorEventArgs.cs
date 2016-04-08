﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qXlsxLib.Utility.Events
{
    public class SheetValidationErrorEventArgs : EventArgs
    {
        #region Constructor
        //=================================================
        public SheetValidationErrorEventArgs(IEnumerable<string> args)
        {
            MissingFields = new List<string>();
            MissingFields.AddRange(args);
        }
        //=================================================
        #endregion

        #region Properties
        //=================================================
        public List<string> MissingFields { get; set; }
        //=================================================
        #endregion
    }
}