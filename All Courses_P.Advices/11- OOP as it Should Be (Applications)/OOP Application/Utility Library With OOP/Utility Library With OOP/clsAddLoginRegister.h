#pragma once
#include <iostream>
#include "clsUser.h"

class clsAddLoginRegister : public clsUser
{
private:
	string _LoginTime;
public:
	clsAddLoginRegister(string UserName , string Password , int Permissions ,string LoginTime ) : clsUser (  UserName,
	Password, Permissions )
	{
		_LoginTime = LoginTime;

	}
};

