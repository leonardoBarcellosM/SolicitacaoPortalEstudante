﻿Feature: Portal_Estudante_credNEX
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

#@01_AcessarPagina
#Scenario: 01 Acessar o endereco
#Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
#Then Validar o carregamento
#
#@02_1Etapa
#Scenario: 02 Iniciar Fluxo Comece Agora
#Given Preencher os dados
#When Clicar em Comece agora sem compromisso
#Then Validar se o fluxo e iniciado
#
#@02_1Etapa
#Scenario: 03 Iniciar Solicitacao
#Given Acessar a opcao solicitacao
#When Clicar em quero solicitar o credito
#Then Validar o direcionamento com sucesso
#
#@02_1Etapa
#Scenario: 04 Selecionar Instituicao
#Given Selecionar instituicao "COLÉGIO ULBRA CRISTO SALVADOR"
#When Selecionar curso "ENSINO MÉDIO"
#And Seleciono a opcao Sou o responsavel pela assinatura
#And Clicar no botao aceito os termos
#Then Validar solicitacao enviada
#
#@02_1Etapa
#Scenario: 05 Validar DB solicitação iniciada
#Then Validar status de solicitacao no db "Solicitacao"
#
#@02_1Etapa
#Scenario: 05 Preencher os dados do dependente
#Given Preencho os dados do dependente
#When Clico em enviar
#Then Os dados devem ser salvos com sucesso na tabela dependentes
