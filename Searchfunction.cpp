#include <bits/stdc++.h>
using namespace std;

vector<int> filter(const vector<string> &arr , function<bool(string)> criteria) {
    vector<string> answer;
    
    for(auto const &element : arr){
        if(criteria(element)) {
        answer.push_back(element);
        }    
    }
    return element;
}

int main() {
     cout<< " Hello"<<endl;
    return 0;
}
