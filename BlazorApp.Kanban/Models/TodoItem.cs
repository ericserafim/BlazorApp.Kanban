﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Kanban.Models
{
	public class TodoItem
	{
		public string Title { get; set; }

		public bool IsDone { get; set; }
	}
}
