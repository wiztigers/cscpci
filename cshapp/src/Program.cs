namespace cshapp {

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

public class Program {

	public static int f(int x, int y) {
		return x+y;
	}

	static void Main(string[] args) {
		System.Console.WriteLine("Hello, world");
		foreach(var arg in args) System.Console.WriteLine("arg: "+arg);
	}
}

}
