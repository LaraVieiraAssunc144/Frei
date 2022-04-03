public string Maior3 (double n1,double n2,double n3){
    string msg = "";

    if(n1 > n2&&n1 >n3 ) {
        msg="O" +n1 +"é maior que " + n2 +n3;
    }

    if(n2>n1&&n2>n3){
        msg= "O" +n2 + "é maior que"+ n1 + n3;
    }

    if (n3>n2 &&n3>n1){
        msg= "O" + n1 + " é maior que" + n2 +n3;
    }

    return msg;
}

public void Main()
{
    try{
        Console.WriteLine("Números iguais");

        Console.WriteLine("Digite um número");
        double a= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        double b =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número");
        double c=Convert.ToInt32 (Console.ReadLine());

        string x= Maior3 (a,b,c);
        Console.WriteLine (x);
    }

    catch(Exception ex) {
        Console.WriteLine("Algo deu errado...");
        Console.WriteLine(ex.Message);
    }
}

Main();