#include <bits/stdc++.h>
using namespace std;

class Filter {
    public:
        vector<string> filterVectorOfStrings(const vector<string> &words, function<bool(string)> criteria) {
            vector<string> result;
            for(auto const &word: words){
                if(criteria(word)){
                    result.push_back(word);
                }
            }
            return result;
        }
        
        void printVectorToConsole(vector<string> vec){
            for(auto const &item: vec) {
                cout << item << ", ";
            }
        }
};

class StringPredicate {
    public:
        function<bool(string)> checkStringStartWithAny(string startString){
            function<bool(string)> predicateFunObj = & { return stringItem.starts_with(startString); };
            return predicateFunObj;
        }
};

int main()
{
    vector<string> words = {"Rohit" , "Rahul" , "Virat" , "Jadeja" , "JonSnow"};
    
    Filter filter;
    StringPredicate stringPredicate;
  
return 0;
}
