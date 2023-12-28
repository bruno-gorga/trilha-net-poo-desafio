# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.


# Minha Solução
Minha proposta para resolver esse desafio é simular uma loja de celulares, na qual o cliente poderá comprar um celular Nokia ou iPhone e, após a compra, testar o celular e suas funcionalidades (Ligar, Receber Ligação, Instalar um Aplicativo).

## 1. Apresentação
O programa faz uso de um menu que simula uma loja de celulares. Nele, o usuário poderá utilizar uma das opções para comprar um celular, acessar um celular comprado e, caso queira, encerrar a aplicação.

![Menu Inicial](https://imgur.com/HiPCuxq.png)

## 2. Usando a aplicação e navegando pelo menu
### 2.1 Criando um novo celular
Para criar um novo celular, basta digitar a opção 1 no menu.
![](https://imgur.com/D9tkmp7.png)

Após isso, será solicitado que o usuário o fabricante do celular que deseja comprar: Nokia ou iPhone.
![](https://imgur.com/L7ADZcC.png)
Após isso, o usuário precisará digitar o estado em que reside, para que a loja possa fornecer uma linha telefônica disponível.
![](https://imgur.com/ojha5Rl.png)
Assim como na vida real, dependendo do estado que o usuário digitar, seu número telefônico terá um DDD diferente, como por ex. (11) para São Paulo, (21) para Rio de Janeiro, etc.

Em seguida, a aplicação irá pedir para que o usuário escolha a memória RAM que o celular possui, assim como na vida real, o aparelho pode ter uma memória de 4 GB, 8 GB ou 16 GB.
![](https://imgur.com/vBsfHUL.png)

A aplicação então fornecerá um telefône para o usuário, que será sua linha, irá gerar o número IMEI do telefone e, ao fim, imprimirá na tela a nota fiscal da compra com a data da compra e as informações sobre o aparelho.

![](https://imgur.com/UIjqFJi.png)

Mais exemplos de criação de aparelhos:
![](https://imgur.com/ZSYmYVA.png)

![](https://imgur.com/DqqXJIt.png)
![](https://imgur.com/gPmTUhl.png)
![](https://imgur.com/DhHcLqL.png)


### 2.2 Usando um celular
Após os celulares serem criados, ficará disponível para o usuário digitar a opção 2 no menu inicial, acessando o aparelho e suas funcionalidades.
![](https://imgur.com/NkSU20B.png)

![](https://imgur.com/E2yVvxS.png)

Como exemplo, vamos selecionar nosso celular Nokia.
![](https://imgur.com/hCrnPHC.png)

Realizando uma ligação com o celular:
![](https://imgur.com/KbmaOGh.png)
Recebendo uma ligação:
![](https://imgur.com/0odQcJ4.png)

Instalando o aplicativo Waze, aqui, no celular Nokia, a instalação é feita com um contador de tempo até o aplicativo ser instalado.
![](https://imgur.com/3i0tpl6.png)
O contador começa em 60 segundos e vai reduzindo até 0, quando a instalação é concluída.

![](https://imgur.com/IqaeK5a.png)
![](https://imgur.com/B3WpJwm.png)

Na versão iPhone do aparelho, as funcionalidades Ligar e Receber Ligação são as mesmas, porém a funcionalidade de instalação é gerenciada por uma barra de carregamento que, ao completar 100%, exibe a mensagem de instalação concluída. A barra vai aumentando conforme a instalação avança.

![](https://imgur.com/Sdnh9Pm.png)
![enter image description here](https://imgur.com/iVtMaEt.png)
![](https://imgur.com/xlANdad.png)
![](https://imgur.com/naUx2cm.png)
![](https://imgur.com/fDGEsht.png)

Ao finalizar, o usuário pode retornar ao menu inicial teclando a opção 3.
![enter image description here](https://imgur.com/Zq4Ln6j.png)
![](https://imgur.com/BnUqDJ7.png)


## 3. Validação e testes
### 3.1 Usando o celular sem tê-lo criado anteriormente
Quando o usuário tenta utilizar a funcionalidade de acesso ao aparelho sem tê-lo criado previamente, a aplicação exibe uma mensagem informando que o aparelho não está disponível e retorna ao menu anterior inicial automaticamente.
![](https://imgur.com/0uQ35Au.png)
![](https://imgur.com/xjMnA7X.png)

### 3.2. Validando os fabricantes
Caso o usuário informe um fabricante inexistente (que não seja iPhone ou Nokia), a aplicação retorna um erro dizendo que o modelo não está disponível e pede que novamente seja inserido o fabricante.
![](https://imgur.com/NxWWZcC.png)
![](https://imgur.com/wmPz0zy.png)

A mensagem de erro só desaparecerá quando a entrada for válida.
![](https://imgur.com/HqZ2g6m.png)

### 3.3. Validando os estados
Se o usuário digitar um estado que não seja válido, isto é, que não esteja dentro das 26 UFs do Brasil e o Distrito Federal, o programa exibirá um erro dizendo que o estado é inválido.
![](https://imgur.com/6HQ3eGQ.png)
![](https://imgur.com/zL5kor2.png)
Somente após se inserir um estado válido é que o programa avançará para a próxima fase.
### 3.3. Validando a memória
Caso a opção de memória seja inválida, o programa apresentará uma mensagem dizendo que não há aparelhos para aquela memória, prosseguindo apenas caso a memória seja 4, 8 ou 16 GB.

![](https://imgur.com/d6YkqH3.png)
![](https://imgur.com/TSnCBon.png)
![](https://imgur.com/2YnQipZ.png)

### 3.4. Validando as opções de menu
Os menus não aceitam opções fora daqueles estabelecidos pela mensagem mostrada no console. No menu inicial, a aplicação fica "parada" no mesmo estado enquanto não for digitado um comando válido.

![](https://imgur.com/tXMW3FA.png)
![](https://imgur.com/fVZgWZo.png)

Já no menu de acesso aos celulares, caso a opção seja inválida, o programa exibe um erro dizendo que o comando é inválido.

![](https://imgur.com/kGTApuP.png)
![](https://imgur.com/c0HoGUt.png)

## 4. Considerações finais
Nesse desafio acredito que a melhor maneira que aplicar o conceito de orientação a objeto seria, de fato, criar uma aplicação que simulasse o manuseio em um contexto real. Procurei deixar a aplicação o mais completa possível, considerando também aspectos de segurança e usabilidade para o usuário final. 

O código está comentado e pode ser acessado no repositório acima.
