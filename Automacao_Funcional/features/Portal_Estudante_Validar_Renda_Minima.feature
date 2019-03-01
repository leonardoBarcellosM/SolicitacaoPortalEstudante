﻿Feature: H-Portal_Estudante_Validar_Renda_Minima
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

@01_AcessarPagina
Scenario: 01 Acessar o endereco
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

@02_1Etapa
Scenario: 02 Iniciar Fluxo Comece Agora
Given Preencher os dados
When Clicar em Comece agora sem compromisso
Then Validar se o fluxo e iniciado

@02_1Etapa
Scenario: 03 Iniciar Solicitacao
Given Acessar a opcao solicitacao
When Clicar em quero solicitar o credito
Then Validar o direcionamento com sucesso

@02_1Etapa
Scenario: 04 Selecionar Instituicao
Given Selecionar instituicao "CENTRO UNIVERSITARIO IESB (GRADUACAO)"
When Selecionar curso "ENGENHARIA MECANICA-MATUTINO-EDSON MACHADO (SUL)"
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

@02_2Etapa
Scenario: 05 Preencher Dados Do Estudante
Given Clicar no botao enviar
Then Validar direcionamento para etapa 3

@03_Renda_Minima
Scenario: 06 Validar DB
Then Consultar renda "minima" no db

@03_Renda_Minima
Scenario: 07 Validar o comportamento com a renda inferior ao minimo exigido
Given Informo valor inferior ao minimo
Then Apresenta mensagem informando que o valor é insuficiente
And O botao Enviar ficara desabilitado
And A opcao quero continuar mesmo assim e apresentada

@03_Renda_Minima
Scenario: 08 Validar o comportamento com a renda superior ao minimo exigido
Given Informo valor superior ao minimo
Then Apresenta mensagem informando que o valor é suficiente
And O botao Enviar ficara habilitado

@03_Renda_Minima
Scenario: 09 Validar o comportamento da renda minima utilizando dois fiadores com renda insuficiente
Given Informo a metade do valor com o primeiro fiador
When Seleciono a opcao para informar um segundo fiador
And Informo valor inferior ao minimo com o segundo fiador
Then Apresenta mensagem informando que o valor é insuficiente para os dois fiadores
#And O botao Enviar ficara desabilitado
And A opcao quero continuar mesmo assim e apresentada para os dois fiadores

@03_Renda_Minima
Scenario: 10 Validar o comportamento da renda minima utilizando dois fiadores com renda suficiente
Given Informo a primeira metade do valor com o primeiro fiador
When Informo a segunda metade do valor com o segundo fiador
Then Apresenta mensagem informando que o valor é suficiente para dois fiadores
#And O botao Enviar ficara habilitado