using System;

namespace passwordProgram{

	class Password{
	
		static void Main(string[] args){
	
			int numberofTriesLeft = 3; //represents the number of tries
	
			Console.WriteLine("Create your password");
			string password = Console.ReadLine(); //Creates the password
			
			Console.WriteLine("Password created. Now, try to log in. You have " + Convert.ToString(numberofTriesLeft) + " tries left.");
			string passwordAttempt = Console.ReadLine(); //represents the attempt at guessing the password
	
			while(passwordAttempt!=password && numberofTriesLeft>0){
				
				--numberofTriesLeft;
				if(numberofTriesLeft==0){
					break;
				}
				
				Console.WriteLine("Acess denied. Please try again.");
				Console.WriteLine("You have " + Convert.ToString(numberofTriesLeft) + " tries or try left.");
				passwordAttempt = Console.ReadLine();
				
			}
	
			
			if(passwordAttempt==password){
				Console.WriteLine("Access granted.");
			}
	
			if(numberofTriesLeft==0){
				Console.WriteLine("Ah ah ah! You didn't say the magic word!");
			}
	
			Console.WriteLine("Press Enter to exit.");
			Console.ReadKey();
	
		}
	}
}