using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AmazoomWeb
{
	public class Robot
	{
		int robotID = 0;
		int xLocation = 0;
		int yLocation = 0;
		static int weightCapacity = 0;
		static List<Item> ItemList = new List<Item>();

		public Robot(int IDValue)
		{
			robotID = IDValue;
		}

		public static void movement()
        {
        }

		public static void grabItem(Item ItemTaken)
        {
			if (weightCapacity + ItemTaken.weight > 3)
            {
				return;
            }
            else
            {
				ItemList.Add(ItemTaken);
				weightCapacity = weightCapacity + ItemTaken.weight;
            }

        }
		public static void loadItem()
        {

        }
	}
}