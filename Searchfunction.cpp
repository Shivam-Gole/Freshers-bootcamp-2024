#include <bits/stdc++.h>
using namespace std;

vector<int> filter(const vector<int> &arr , function<bool(int)> criteria) {
    vector<int> answer;
    
    for(auto cont &element : arr){
        if(criteria(element)) {
        answer.push_back(element);
        }    
    }
    return element;
}

int main() {
    vector<int> arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    auto is_even =  { return x % 2 == 0; };
    auto is_odd =  { return x % 2 != 0; };
    vector<function<bool(int)>> criteria_list = {is_even, is_odd};
    
    cout << "Hello !";
    return 0;
}
