/*
 * Created by SharpDevelop.
 * User: oscar hernandez
 * Date: 03/11/2014
 * Time: 08:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Ingresa la cantidad del Producto 1:");
				int product_1 = int.Parse( Console.ReadLine());
			Console.WriteLine("Ingresa la Descripcion del producto:");
				string descrip_1 = Console.ReadLine();
			Console.WriteLine("Ingresa el Precio Unitario del producto:");
				int  precio_1 = int.Parse( Console.ReadLine());
				
			//-------------------------------------------------------
			
			Console.WriteLine("Ingresa la cantidad del Producto 2:");
				int product_2 = int.Parse( Console.ReadLine());
			Console.WriteLine("Ingresa la Descripcion del producto:");
				string descrip_2 = Console.ReadLine();
			Console.WriteLine("Ingresa el Precio Unitario del producto:");
				int  precio_2 = int.Parse( Console.ReadLine());
				
			//-------------------------------------------------------
			
			Console.WriteLine("Ingresa la cantidad del Producto 3:");
				int product_3 = int.Parse( Console.ReadLine());
			Console.WriteLine("Ingresa la Descripcion del producto:");
				string descrip_3 = Console.ReadLine();
			Console.WriteLine("Ingresa el Precio Unitario del producto:");
				int  precio_3 = int.Parse( Console.ReadLine());
				
			//-------------------------------------------------------
			
				double result_1=(product_1*precio_1);
				double result_2=(product_2*precio_2);
				double result_3=(product_3*precio_3);
			
			Console.WriteLine(" " +product_1+ "  " +descrip_1+ "  " +result_1);
			Console.WriteLine(" " +product_2+ "  " +descrip_2+ "  " +result_2);
			Console.WriteLine(" " +product_3+ "  " +descrip_3+ "  " +result_3);
			
				double subtotal=(result_1+result_2+result_3);
				double iva=(0.16 * subtotal);
				double total=(subtotal + iva);
				
			Console.WriteLine("-------Venta--------");
			Console.WriteLine(" Subtotal ="+subtotal);
			Console.WriteLine(" Iva =" +iva);
			Console.WriteLine(" Total ="+total);
			Console.WriteLine("--------------------");
			Console.ReadKey(true);
		}
	}
}