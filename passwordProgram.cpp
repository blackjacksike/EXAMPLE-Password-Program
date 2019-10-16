#include <iostream>
#include <string>
#include<cstdio>
using namespace std;

int main(){
	string password; //represents the password
	string passwordAttempt; //represents the attempt at guessing the password
	int numberofTriesLeft=3; //represents the number of tries
	cout<<"Create your password"<<endl;
	cin>>password;
	cout<<"Password created. Now, try to log in. You have "<<numberofTriesLeft<<" tries left."<<endl;
	cin>>passwordAttempt; //first try
	while(passwordAttempt!=password && numberofTriesLeft>0){
		--numberofTriesLeft;
		if(numberofTriesLeft==0){
			break;
		}
		cout<<"Acess denied. Please try again."<<endl;
		cout<<"You have "<<numberofTriesLeft<<" tries or try left."<<endl;
		cin>>passwordAttempt;
	}
	if(passwordAttempt==password){
		cout<<"Access granted."<<endl;
		std::getchar();
	}
	if(numberofTriesLeft==0){
		cout<<"Ah ah ah! You didn't say the magic word!"<<endl;
		std::getchar();
	}
	cout<<"Press Enter to exit."<<endl;
	std::getchar();
	return 0;
}