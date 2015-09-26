using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class FunctionalExtensions
	{
		public static void ForEach<T>(this IEnumerable<T> items,
		                    Action<T> pAction)
							{
								foreach (T item in items)
								   pAction(item);
									
										
							}
	}	
	

}