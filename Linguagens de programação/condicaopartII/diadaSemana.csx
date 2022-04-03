public string diadaSemana (int n)
{
    string msg= "";

    if(n == 0){
        msg= "o dia da semana é domingo";
    }

    if(n == 1){
        msg= "o dia da semana é segunda";
    }

    if(n == 2){
        msg= "o dia da semana é terça";
    }

    if(n == 3){
        msg= "o dia da semana é quarta";
    }

    if(n == 4){
        msg= "o dia da semana é quinta";
    }

    if(n == 5){
        msg= "o dia da semana é sexta";
    }

    if(n == 6){
        msg= "o dia da semana é sábado";
    }

    return msg;
}

public void Main(){

    try{
        Console.WriteLine("Dia da semana");

        Console.WriteLine("informe o dia: ");
        int a = Convert.ToInt32(ReadLine());

        string x = diadaSemana(a);

        Console.WriteLine(x);

    }

    catch (Exception ex)
    {
        Console.WriteLine("Dia da semana inválido");
        Console.WriteLine(ex.Message);
    }
} 

Main();