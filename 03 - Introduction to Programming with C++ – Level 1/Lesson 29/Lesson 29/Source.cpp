#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

enum enColor {Red, Blue, Yellow, Brown, Green };
enum enGender {Male, Female};
enum enMaterialStatus {Sinale, Married};

struct stAddress
{
	string StreetName;
	string BuildingNo;
	string PoBox;
	string ZipCode;
};

struct stContactInfo
{
	string Email;
	string Phone;
	stAddress Address;
};

struct stPerson
{
	string FirstName;
	string LastName;

	stContactInfo ContactInfo;

	enColor FavourateColor;
	enGender Gender;
	enMaterialStatus Stutas;

};
int main()
{
	stPerson Person1;

	Person1.FirstName = "Saddam";
	Person1.LastName = "Al-zekri";

	Person1.ContactInfo.Email = "Saddamalzekri33S@gmail.com";
	Person1.ContactInfo.Phone = "712126932";

	Person1.ContactInfo.Address.PoBox = "7777";
	Person1.ContactInfo.Address.BuildingNo = "77";
	Person1.ContactInfo.Address.StreetName = "Gaza";
	Person1.ContactInfo.Address.ZipCode = "7987";

	Person1.FavourateColor = enColor::Blue;
	Person1.Stutas = enMaterialStatus::Sinale;
	Person1.Gender = enGender::Male;

	cout << Person1.FirstName<<endl<<Person1.Gender<<endl<<Person1.ContactInfo.Address.PoBox;
	_getch();

	return 0;
}
