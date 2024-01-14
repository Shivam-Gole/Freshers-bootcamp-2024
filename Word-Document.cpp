// https://shorturl.at/kGRT7
#include<bits/stdc++.h>
using namespace std;

class ConvertorInterface {
public:
    virtual void convert(class Header* header) = 0;
    virtual void convert(class Paragraph* paragraph) = 0;
    virtual void convert(class Hyperlink* hyperlink) = 0;
    virtual void convert(class Footer* footer) = 0;
};

class DocumentPart {
public:
    string name;
    int position;

    virtual void paint() = 0;
    virtual void save() = 0;
    virtual void convert(ConvertorInterface* iConverter) = 0;
};

class WordDocument {
public:
    vector<DocumentPart*> parts;

    void open() {
        for (DocumentPart* docPart : parts) {
            docPart->paint();
        }
    }

    void save() {
        for (DocumentPart* docPart : parts) {
            docPart->save();
        }
    }

    void convert(ConvertorInterface* iConverter) {
        for (DocumentPart* docPart : parts) {
            docPart->convert(iConverter);
        }
    }
};



class Header : public DocumentPart {
public:
    string title;

    void paint(){
        cout << "This is header" << endl;
    }

    void save(){
        cout << "Save header" << endl;
    }

    void convert(ConvertorInterface* iConverter){
        iConverter->convert(this);
    }
};

class Footer : public DocumentPart {
public:
    string text;

    void paint() override {
        cout << "This is Footer"<<endl;
    }

    void save() override {
        cout << "Save Footer" <<endl;
    }

    void convert(ConvertorInterface* iConverter) override {
        iConverter->convert(this);
    }
};

class Hyperlink : public DocumentPart {
public:
    string url;
    string text;

    void paint() override {
        cout << "This is hyperlink" << endl;
    }

    void save() override {
       cout << "Save hyperlink" <<endl;
    }

    void convert(ConvertorInterface* iConverter) override {
        iConverter->convert(this);
    }
};

class Paragraph : public DocumentPart {
public:
    string content;

    void paint() override {
       cout << "This is paragraph" << endl;
    }

    void save() override {
        cout << "Save paragraph" <<endl;
    }

    void convert(ConvertorInterface* iConverter) override {
        iConverter->convert(this);
    }
};

class HTMLConvertor : public ConvertorInterface {
public:
    void convert(Header* header) override {
       cout << "<header> created" <<endl;
    }

    void convert(Paragraph* paragraph) override {
        cout << "<p> created" <<endl;
    }

    void convert(Hyperlink* hyperlink) override {
       cout << "<a> created" <<endl;
    }

    void convert(Footer* footer) override {
       cout << "<footer> created" << endl;
    }
};

int main() {
    WordDocument document;

    Header header;
    header.title = "Document Title";
    document.parts.push_back(&header);

    Paragraph para;
    para.content = "A paragraph.";
    document.parts.push_back(&para);

    Footer footer;
    footer.text = "Footer last";
    document.parts.push_back(&footer);

    Hyperlink hyperlink;
    hyperlink.url = "https://abcd.com";
    hyperlink.text = "Link";
    document.parts.push_back(&hyperlink);

    HTMLConvertor htmlImplementation;

    document.open();
    document.save();
    document.convert(&htmlImplementation);

    return 0;
}


/*
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
*/
