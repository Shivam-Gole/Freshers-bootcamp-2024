
#include <bits/stdc++.h>
using namespace std;


class IObserver(){
public:
  virtual ~IObserver(){};
  virtual void Update(const string &message_from_subject) = 0;
};

class ConcreteObserver : public IObserver{
    public:
    void update(string state){
        
    }
};

class Thread {
    private: 
    int id;
    string state;
    string priority;
    string culture;
    
    void notify(){
        
    }
    
    public:
    void Thread(){
        state = "start";
        this->notify();
    }
    void start(){
        this->state = "running";
        this->notify();
    }
    void abort(){
        this->state = "aborted";
        this->notify();
    }
    void sleep(){
        this->state = "sleep";
        this->notify();
    }
    void wait(){
        this->state = "waiting";
        this->notify();
    }
    void suspended(){
        this->state = "suspended";
        this->notify();
    }
    
    void subscribe(){
        
    }
    
    void unsubsribe(){
        
    }
};

int main() {
    Thread obj;
   

    return 0;
}
