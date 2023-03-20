using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Product
{
    int codice; 
    string name;
    string description;
    double price;
    double iva = 22;

    
    public Product( string name, string description, int price,  int codice = - 1)
    {
        if (codice == - 1)
        {
            this.codice = new Random().Next();
        }
        else
        {
            this.codice = codice;
        }
        this.name = name;
        this.description = description;
        this.price = price;
        
    }
    public int Codice {
        get { return this.codice; }
    }
    public string Name { 
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    public string Description { 
        get
        {
            return this.description;
        }
        set {
            this.description = value;
        }
    }

    public double Price { 
        get { 
            return this.price;  
        }
        set
        {
            this.price = value;
        }
    }

    public double Iva { 
        get { 
             return this.iva;
        }
        set => this.iva = value;
    }
            
            
    public string RefactoringCodeProduct()
    {
        string codeString = codice.ToString();
        int codeLenght = codeString.Length;
         if(codeLenght <= 8)
        {
            for(int i = codeLenght; i <= 8 ; i++)
            {
                codeString = $"0{codeString}"; 
            }
        }

        return codeString;
    }        
       
    public override string ToString()
    {
        string nl = Environment.NewLine;
        return "Prodotto" + nl
            + $"Codice: {codice}" + nl
            + $"Nome: {name}" + nl
            + $"Descrizione: {description}" + nl
            + $"Prezzo: {price}euro" + nl 
            + $"iva: {iva}%";
    }
    public string priceWithIva()
    {
        double productIva = (this.price / 100) * this.iva;
        double totalPrice = productIva + this.price;

        return $"il prezzo del prodotto senza iva {this.price} mentre il prodotto con iva e {totalPrice}";
    }
    public string fullProductName()
    {
        return $"{this.codice} {this.name}";
    }
}

