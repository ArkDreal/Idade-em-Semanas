using System;

namespace ExercícioIdade
{
    class Program
    {
        static void Main(string[] args)
        {
             Console . WriteLine ( " Em que ano você nasceu? " );
            int  anoNasceu  =  int . Parse ( Console . ReadLine ());

            Console . WriteLine ( " Qual é o ano atual? " );
            int  anoAtual  =  int . Parse ( Console . ReadLine ());

            int  idadePessoa  =  anoAtual  -  anoNasceu ;
            int  idadeDia  =  idadePessoa  *  365 ;
            float  idadeSemana  =  idadeDia  /  7 ;

            Console . WriteLine ( " A sua idade é de: "  +  idadePessoa );
            Console . WriteLine ( " A sua idade em semanas é: "  +  idadeSemana );
        }
    }
}
