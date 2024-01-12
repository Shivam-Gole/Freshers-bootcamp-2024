// Online C++ compiler to run C++ program online
#include <iostream>
using namespace std;

class DocumentPart{
    private:
    string name;
    int position;
    
    public:
    virtual void paint() = 0;
    virtual void save() = 0;
    
};

class WordDocument{
    private:
    vector<DocumentPart*> partList;
    
    public:
    void open(){
        
    }
    void save(){
        
    }
};

class Header : public DocumentPart{
    public: 
    string title;
    
    void paint(){
        
    }
    void save(){
        
    }
};

class Paragraph : public DocumentPart{
    public: 
    string title;
    
    void paint(){
        
    }
    void save(){
        
    }
};

class Hypertext : public DocumentPart{
    public: 
    string title;
    
    void paint(){
        
    }
    void save(){
        
    }
};

class Footer : public DocumentPart{
    public: 
    string text;
    
    void paint(){
        
    }
    void save(){
        
    }
};

int main() {
    

    return 0;
}
