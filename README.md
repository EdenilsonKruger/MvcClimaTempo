# Clima tempo
Informações sobre a previsão do tempo

### Descrição
Joyce Vieira é uma agente de turismo da empresa Passe Bem. Quando em consultoria ela precisa dar informações quanto a previsão do tempo para seus clientes. 
Como consultora ela precisa:
  1.	Informar quais são as 3 cidades que terão a maior temperatura;
  2.	Informar quais são as 3 cidades que terão a menor temperatura;

Qual será a previsão do tempo para os próximos 7 dias na cidade que ela selecionar;

## Construído com
* Microsoft.AspNet.Mvc 5.2.7;
* .NetFramework 4.6.1;
* Bootstrap 3.4.1;
* Font Awesome Free 6.2.0;
* Select2 4.1.0;

## Começando
### Dependências
* Visual Studio 2019 ou posterior;
* Sql Server 2019;

### Executando programa
* Para criar o banco de dados é necessário executar o script 01 na pasta App_Data:

![image](https://user-images.githubusercontent.com/115954543/196060877-c9ea31e6-7d7c-414b-8eb8-7b2c0fcffef3.png)

* Necessário configurar a conexão com o banco de dados no arquivo Web.Config:

![image](https://user-images.githubusercontent.com/115954543/196060881-a7161f5f-44d7-4847-ab3d-342beec78943.png)
![image](https://user-images.githubusercontent.com/115954543/196060885-49f8f959-214e-4772-a43a-09e1a446f5c1.png)

* Executando o sistema se não existir nenhum registro na tabela “PrevisaoClima” o sistema realiza uma carga inicial de dados:

![image](https://user-images.githubusercontent.com/115954543/196060888-04c1d9a7-871f-4092-a9e6-7b9911faf4fa.png)
 
* A primeira página contém os dados do autor:

![image](https://user-images.githubusercontent.com/115954543/196060890-4fa71d92-93e3-4e14-84a7-dea270ba81ea.png)
 
* Na segunda página contém os dados da previsão do tempo:

![image](https://user-images.githubusercontent.com/115954543/196060893-edbfd5ad-3b20-43e3-adda-37b37ad0226f.png)

É apresentado as três cidades mais quentes e frias do dia de hoje;

Depois que selecionar a cidade é carregada os próximos sete dias da previsão do tempo da cidade:

![image](https://user-images.githubusercontent.com/115954543/196060894-7f29ea00-98da-4512-ab42-94ee6af2d5f0.png)
 
## Autor
* Edenilson Krüger – edenilsonkruger@hotmail.com

## Histórico de versões
* 1.0 - Lançamento inicial
