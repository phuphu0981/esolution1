﻿using esolution.data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esolution.data.Enitity
{
	public class Category
	{
			public int Id					{ set; get; }
			public int SortOders			{ set; get; }
			public bool IsShowOnHome			{ set; get; }
			public int ParentId				{ set; get; }
			public Status Status				{ set; get; }
	}
}
