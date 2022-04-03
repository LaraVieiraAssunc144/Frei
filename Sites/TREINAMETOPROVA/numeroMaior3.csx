public string maiorde3 (int n1,int n2,int n3){
    string msg="";

    if (n1 < n2 & n3){
        msg= "O número " +n1 + "é maior que " +n2 + n3;
    }
}
public async void Main(){

    try{
        Console.WriteLine("Programa Maior Que ");

        Console.WriteLine("Digite o primeiro número: ");
        int a = Convert.ToInt32(ReadLine());

        Console.WriteLine("Digite o segundo número");
        int b= Convert.ToInt32(ReadLine());

        Console.WriteLine("Digite o terceiro número");
        int c= Convert.ToInt32(ReadLine());


        string x = maiorde3 (a,b,c);

        Console.WriteLine(x);

    }
    catch (Exception ex) {
        Console.WriteLine("Algo deu errado");
        Console.WriteLine(ex.Message);
    }
}