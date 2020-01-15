# CapsuleCorpCoffee
## O que é?

Projeto proposto como teste para a oportunidade de Desenvolvedor Pleno na empresa DeMaria.
Esse projeto tem como objetivo o controle de cápsulas de café e de receitas utilizando essas cápsulas. 

O desenvolvimento foi inteiramente feito em C# utilizando a técnologia WinForms para a interface. Caso pretenda executar dentro do Visual Studio através do código fonte, para a utilização dos testes no projeto *CapsuleCorpCoffee.Tests*, é necessária a instalação do _**xunit**_ e do _**xunit.runner.visualstudio**_ através do **NuGet Package Manager**.

O banco de dados utilizado é o **PostgreSQL**, para sua utilização é necessário ter o mesmo instalado na máquina e a utilização o _**Npgsql**_ instalado via **NuGet Package Manager** no projeto *CapsuleCorpCoffeeDAO*.

Abaixo podemos ver qual a *cara do programa*:

![CapsuleCorpCoffee_3W4YRnQnAJ](https://user-images.githubusercontent.com/10116449/72399718-b8aec300-3725-11ea-9715-5cb9f0aad494.png)

## Funcionalidades
* É possível cadastrar e alterar uma cápsula, a qual possui uma descrição e um nível de força da bebida.

* Também é possível incluir um ou mais itens no estoque, desde que a data de validade seja igual ou superior a data atual. Podemos alterar este item para corrigir informações incorretas ou até mesmo para aumentar a quantidade em estoque.

* Podemos cadastrar uma receita de bebida, selecionando as cápsulas que poderão ser utilizados para compor essa receita e a quantidade de cada uma.

* É possível preparar a receita selecionando a mesma e quantas xícaras deseja fazer. O sistema irá checar o estoque e retornar se será possível ou não fazer a receita.

* Após fazer uma receita, o usuário deverá avaliar a receita que foi feita informando a nota e um comentário, se desejar.

## Instalação

### Banco de Dados
Para a instalação do banco de dados existem 2 formas.

1. Restaurar o banco, que se encontra na pasta Scripts na raiz do projeto, arquivo **capsulecorpcoffeeBD**
1. Efetuar a criação manual do banco da seguinte forma:
    1. Criar o banco de dados chamado *capsulecorpcoffeeDB*. **Atenção: o banco tem que ser criado com o nome exatamente igual este, considerando as letras maiúsculas e minúsculas.**
    1. Rodar todo o script que está na pasta Script na rais do projeto, o nome do arquivo para rodar é **capsulecorpcoffeeBD.sql**.

### Programa
Para a utilização do programa, basta executar no Visual Studio após ter preparado o banco de dados conforme o passo anterior.

Caso não deseje utilizar o Visual Studio ou outra IDE para abrir via código, basta abrir o arquivo que estará no seguinte caminho: */CapsuleCorpCoffeeBD/bin/Release/CapsuleCorpCoffee.exe*.

## Informações Adicionais

### Imagens
* As imagens utilizadas para os botões da tela inicial foram obtidos em https://icons8.com.br/ de forma gratuita e não foram alterados, conforme termos da Icons8.

* O ícone utilizado no sistema foi especialmente feito por Kevin H. Ribeiro, designer gráfico, modelador 3D e artista. Portfólio em https://gentlemankevs.artstation.com.

### Todos os direitos reservados.
