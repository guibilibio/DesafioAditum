# DesafioAditum
DesafioAditum C# .Net

O projeto funciona da seguinte forma:

- Ao ser iniciado, apresenta um menu ao usuário com duas opções.
- Escolhendo a opção 1, é solicitado o horário desejado pelo usuário.
- A partir do horário informado, é feito a busca nos restaurantes, e listado os mesmos, 
conforme o horário informado, caso não tenham restaurantes abertos, é informado ao cliente que não a restaurantes abertos.
- Escolhendo a opção 0 do menu no sistema, o mesmo se encerra.
- A camada Model contém a regra de negócio projeto, no caso os atributos que o objeto Restaurante possui, 
a View é responsável por apresentar e receber as informações do usuário (listando e trazendo os restaurantes, conforme o horário informado), 
e a camada Controller por sua vez é responsável por intermediar e controlar a comunicação entre essas camadas, a mesma sendo chamada na classe do programa (Program.cs).

Escolhas realizadas:

- Arquitetura MVC: escolhida por utilizar a orientação a objetos, e ter como principais pontos a fácil manutenção, melhor desempenho e um alto acoplamento.
- Utilizado o xUnit para realização de testee de unidade, aonde foi testado os métodos responsáveis pela entrada de dados do cliente.
