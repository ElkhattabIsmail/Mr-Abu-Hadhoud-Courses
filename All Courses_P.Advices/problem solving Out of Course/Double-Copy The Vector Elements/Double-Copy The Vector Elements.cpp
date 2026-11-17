
#include <iostream>
#include <vector>
using namespace std;

vector <int> DoubleVector(vector<int> & nums)
{
	vector <int> ans(nums.size() * 2);

	for (int i = 0; i < nums.size(); i++)
	{
		ans[i] = nums[i];
		ans[i + nums.size()] = nums[i];
	}
	return ans;

}
vector <int> TripleVector(vector<int>& nums)
{
	vector <int> ans(nums.size() * 3);

	for (int i = 0; i < nums.size(); i++)
	{
		ans [i] = nums[i];
		ans [ i + nums.size()] = nums[i];

		int Val = ans[i + nums.size() * 2];
		ans[i + nums.size() * 2] = nums[i];
	}
	return ans;

}
//vector <int> MultipleVector( vector<int> & nums , int Times)
//{
//	if (Times <= 1)
//		return nums;
//	vector <int> ans(nums.size() * Times);
//
//	for (int i = 0; i < nums.size(); i++)
//	{
//		ans[i] = nums[i];
//		ans[i + nums.size()] = nums[i];
//
//		int Val = ans[i + nums.size() * 2];
//		ans[i + nums.size() * 2] = nums[i];
//	}
//	return ans;
//
//}
int main()
{
	//// Double The Vector in Order
	//vector <int> Numbers = { 1,2,3 }; int Times = 3;

	//vector <int> DoubleVectorInOrder = MultipleVector(Numbers, Times);
	//cout << "\nDouble Vector Elements " << Times << " Times.\n";
	//for (int i = 0; i < DoubleVectorInOrder.size(); i++)
	//{
	//	cout << DoubleVectorInOrder.at(i) << " ";
	//}

	//system("pause > 0");








	//vector <int> Nums = { 1,2,3 };
	//vector <int> Nums2 = { 1,2,3 };

	//vector <int> DoubleOfVector = DoubleVector(Nums);
	//vector <int> DoubleOfVector2 = TripleVector(Nums2);

	//cout << "\nFirst Vector Double Elements :\n";
	//for (int i = 0; i < DoubleOfVector.size(); i++)
	//{
	//	cout << DoubleOfVector.at(i) <<  " ";
	//}
	//cout << "\nSecond Vector Triple of Elements :\n";
	//for (int i = 0; i < DoubleOfVector2.size(); i++)
	//{
	//	cout << DoubleOfVector2.at(i) << " ";
	//}
}

