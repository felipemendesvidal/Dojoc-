//para usar o data time
using System;

//programa que mostra dados do jogador na tela
//proposta fazer em colaboração com outros devs em tempo real...
//feito por: felipe 
//baseado em: https://github.com/senai-desenvolvimento/1S1DM-Sprint4-POO/blob/master/Aula18Dojo1

namespace coding_dojo
{
    public class Jogador
    {
        public string nome {get; set;}
        public string  posicao {get; set;}
        public DateTime dataNascimento {get; set;}
        public string nacionalidade {get; set;}
        public float altura {get; set;}
        public float peso {get; set;}
        public int idade{get; set;}
        

        //imprime dados do hogador
        public string dadosJogador(){
            //mostrando os dados na tela, com todas as variaveis
            return $"Nome: {nome}\nPosição do Jogador: {posicao}\nData de nascimento : {dataNascimento}\nAltura : {altura}\nPeso: {peso}\nNacionalidade: {nacionalidade}";
        }

        //metodo que calcula idade
        public int calculaIdade(){
            //pesquisar to split de novo e o tostring
            int anoNasct = Int32.Parse(dataNascimento.ToString().Split('/' ,' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/' ,' ')[2]);

            idade = anoAtual - anoNasct;

            return idade;
        }

        //calculando a aposentaria
        public string aposentar(){
             //Atacante 35
            //Meio campo 38
            //Defesa 40

            //variavel criada para receber valores
            string aposenta = "";

            //pegando valores das outras variaveis
            if(posicao == "atacante" && idade >= 35){
                aposenta = " pode aposentar";

            }else if(posicao == "meio campo" && idade >= 38){
                aposenta = "pode aposentar";

            }else if(posicao == " defesa" && idade >= 40){
                aposenta = " pode aposentar ";

            }else{aposenta = "não pode aposentar, escravo";}
            return aposenta;
        }





    }
}