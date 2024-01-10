#include <bits/stdc++.h>
using namespace std;

class ConsoleDisplayController {
    private:
    string content;
    public:
    void setContent(String word){
        this->content = word;
    }
    void display(){
        cout<<this->content;
    }
};

class StringListFilterController{
    public:
    StartsWithStrategies condition;
    vector<string>filter(vector<string>&arr){
        vector<string>answer;
        condition.setStartWith('A');
        
        for(auto : element:arr){
            if(condition.invoke(element)){
                answer.push_back(element);
            }
        }
        return result;
    }
};

class StartsWithStrategies {
    private: 
    char startsWith;
    
    public:
    void setStartsWith(string key){
        this->startsWith = key;
    }
    bool invoke(string item){
        return item.find(this->startsWith) == 0;
    }
    
};

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
