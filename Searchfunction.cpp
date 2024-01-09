#include <bits/stdc++.h>
using namespace std;

vector<int> filter(vector<int> &arr , function<bool(int)> criteria) {
    vector<int> answer;
    
    for(auto cont &element : arr){
        if(criteria(element))
        answer.push_back(element);
    }
    return element;
}

int main() {
    
    cout << "Hello !";
    return 0;
}
