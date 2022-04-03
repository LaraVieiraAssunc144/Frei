public string calculadorar (int n1,int n2){

    string msg= "";
    
    if{
        msg= "A soma dos números é"+(n1+n2); 
    }

    if{
        msg= "A subtração dos números é de"+(n1-n2);
    }

    if{
        msg= "A multiplicação dos números é de"+(n1*n2);
    }

    if{
        msg= "A divisão dos números é de:" + (n1 /n2);
    }

    if{
        msg= "A potencia do número é de" + (n1*n2);
    }

    return msg;
}
 public async void Main(){

     try{
         Console.WriteLine("CALCULADORA DA LARA");
        
         Console.WriteLine("Digite um número");
         int a = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Digite o outro número");
         int b = Convert.ToInt32(Console.ReadLine());

         string x = calculadorar (a,b);

         Console.WriteLine(x);
     }
     catch (Exception ex) {
         Console.WriteLine("Algo deu errado...");
         Console.WriteLine(ex.Message);
     }
 }

 Main();