﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidCP.Providers.OS;

namespace SolidCP.Providers
{
    public class Sh : Shell
	{
		public override string ShellExe => "sh";
	}
}