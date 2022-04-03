public string maior (int n1,int n2){
    
    string msg = "";

    if (n1>n2) {
        msg= "O número " + n1 + "é maior que " + n2;
    }

    else if (n1<n2) {
        msg= "O número " + n1 + " é menor que " + n2;
    }

    else{
        msg= "Os números são iguais";
    }

    return msg;
}

public void Main(){

    try{
        Console.WriteLine("Programa Maior Que ");

        Console.WriteLine("Digite o primeiro número: ");
        int a = Convert.ToInt32(ReadLine());

        Console.WriteLine("Digite o outro número");
        int b= Convert.ToInt32(ReadLine());

        string x = maior (a,b);

        Console.WriteLine(x);

    }
    catch (Exception ex) {
        Console.WriteLine("Algo deu errado");
        Console.WriteLine(ex.Message);
    }
}
Main();