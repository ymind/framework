﻿//      )                             *     
//   ( /(        *   )       (      (  `    
//   )\()) (   ` )  /( (     )\     )\))(   
//  ((_)\  )\   ( )(_)))\ ((((_)(  ((_)()\  
// __ ((_)((_) (_(_())((_) )\ _ )\ (_()((_) 
// \ \ / / (_) |_   _|| __|(_)_\(_)|  \/  | 
//  \ V /  | | _ | |  | _|  / _ \  | |\/| | 
//   |_|   |_|(_)|_|  |___|/_/ \_\ |_|  |_| 
// 
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
// 
// Copyright © Yi.TEAM. All rights reserved.
// -------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Yisoft.Framework.Extensions
{
	// ReSharper disable once InconsistentNaming
	public static class IEnumerableExtensions
	{
		[DebuggerStepThrough]
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
		{
			return list == null || !list.Any();
		}

		public static bool IsNullOrEmptyOrHas<T>(this IEnumerable<T> list, T value = default(T))
		{
			// ReSharper disable PossibleMultipleEnumeration
			return list == null || !list.Any() || list.Contains(value);
			// ReSharper restore PossibleMultipleEnumeration
		}

		public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
		{
			foreach (var item in list)
			{
				action?.Invoke(item);
			}
		}
	}
}
