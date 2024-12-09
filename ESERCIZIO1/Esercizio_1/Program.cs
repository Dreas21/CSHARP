using System;
using System.Collections.Generic;

List<int> listanumeri = new List<int>();

Boolean continua = true;
while(continua == true){
    Console.Write("Inserisci il numero: ");
    string input_num = Console.ReadLine();
    int num;
    if(int.TryParse(input_num, out num)){
        if (num % 2 == 0){
            Console.WriteLine($"Il {num} che hai fornito è pari");
            listanumeri.Add(num);
        } 
        else{
            Console.WriteLine($"Il {num} che hai fornito è dispari");
            listanumeri.Add(num);
        }
    }
    else{
    Console.WriteLine($"{input_num} non è valido");
    }
    Console.WriteLine("Vuoi continuare ad inserire numeri?");
    Console.WriteLine("[1] --> si");
    Console.WriteLine("[2] --> no \n");
    string nuovonum = Console.ReadLine();
    int nm;
    int.TryParse(nuovonum, out nm);
    if(nm == 2){
        continua = false;
    }
}
Console.WriteLine("");
Console.WriteLine("Che numeri vuoi visualizzare?");
Console.WriteLine("[1] --> pari");
Console.WriteLine("[2] --> dispari");
string scelta = Console.ReadLine();
int s;
int.TryParse(scelta, out s);
Console.WriteLine("");
for (int i=0; i<listanumeri.Count(); i++){
    if(s==1){
        if(listanumeri[i]%2 == 0){
            Console.WriteLine($"{listanumeri[i]}");
        }
    }
    if(s==2){
        if(listanumeri[i]%2 != 0){
            Console.WriteLine($"{listanumeri[i]}");
        }
    }
}