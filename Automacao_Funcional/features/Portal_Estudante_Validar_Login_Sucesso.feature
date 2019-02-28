Feature: H-Portal_Estudante_Validar_Login_Sucesso
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

@02_RealizarLogin
Scenario: 02 Realizar login
Given Clico no botao Entrar
When Preencho os campos nome e senha
| Field		| Value			 |
| CPF		| 802.204.500-48 |
| Senha		| teste123		 |
And Clico em Entrar
Then Login deve ser ralizado com sucesso

@03_ValidarServicoCarregarSolicitacao
Scenario: 03 Validar Servico Carregar Solicitacao
Given Consultar o servico de carregar a solicitacao