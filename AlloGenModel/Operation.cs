﻿// Copyright (c) 2022 SIL International
// This software is licensed under the LGPL, version 2.1 or later
// (http://www.gnu.org/licenses/lgpl-2.1.html)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIL.AlloGenModel
{
    public class Operation : AlloGenBase
    {
        public string Name { get; set; } = "new operation";
        public string Description { get; set; } = "";
        public Pattern Pattern { get; set; } = new Pattern();
        public Action Action { get; set; } = new Action();

        override public string ToString()
        {
            return Name;
        }
    }
}
