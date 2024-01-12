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

class Iconvertor{
    public:
    virtual void Convert(Header header) = 0;        
    virtual void Convert(Hyperlink hyperlink) = 0;
    virtual void Convert(Paragraph para)  = 0;
    virtual void Convert(Footer foot) = 0;
};

class HTMLConvertor : public IConvertor{
 
    public:
    void Convert(Header header) {
        return ;
    }
    void Convert(Paragraph para) {
        return ;
    }
    void Convert(Hyperlink hyperlink) {
        return ;
    }
    void Convert(Footer footer) {
        return ;
    }
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
    HtmlConvert htmlConvert;
    string header;
    
    void paint(){
        
    }
    void save(){
        
    }
    void Convert(){
        HtmlConvertor::covert(this);
        return ;
    }
};

class Paragraph : public DocumentPart{
    public: 
    HtmlConvert htmlConvert;
    string title;
    
    void paint(){
        
    }
    void save(){
        
    }
    void Convert(){
        HtmlConvertor::covert(this);
        return ;
    }
};

class Hyperlink : public DocumentPart{
    public: 
    HtmlConvert htmlConvert;
    string title;
    
    void paint(){
        
    }
    void save(){
        
    }
    void Convert(){
        HtmlConvertor::covert(this);
        return ;
    }
};

class Footer : public DocumentPart{
    public: 
    HtmlConvert htmlConvert;
    string text;
    
    void paint(){
        
    }
    void save(){
        
    }
    void Convert(){
        HtmlConvertor::covert(this);
        return ;
    }
};

int main() {
    
    
    
    return 0;
}
