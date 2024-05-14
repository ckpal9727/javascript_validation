using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter var number");
		var number=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter var number"+number);
		for(var i=0;i<number;i++){
			for(var j=0;j<3;j++){
				if(i==0 || i==number-1 ){
					Console.Write(number+" ");
					continue;
				}
				if(j==1){
					continue;
				}
				Console.Write(number+"   ");
			}
			Console.WriteLine();
		}
		
		
		
	}
}