# Cliente21

Solução do desafio proposto. <br />
Criada uma tela inicial para a importação do arquivo xml, ao realizar a importação os Titulos são exibidos no DataGridView. <br />
Para abrir a tela de edição / exclusão, basta dar um duplo clique na linha desejada. <br />
<br />
Foram criadas procedures para realizar a inserção do xml, alteração dos Titulos e exclusão dos mesmos.<br />
A procedure de inserção recebe um arquivo xml, e dentro dele são lidos os nós, inseridos em uma tabela temporária e então inseridos na tabela "Titulos".<br />
Solução feita em camadas. <br />
<br />
Data <br />
Negocio <br />
Forms <br />
Entidade <br />
<br />

ConnectionString na classe ADTitulos, dentro da pasta "Data" <br />
Backup do banco de dados dentro da pasta "SQL"<br />



