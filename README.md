# GerenciamentoBiblioteca
Ferramentas utilizadas

Visual Studio Code: IDE utilizada para desenvolver o programa.

.NET Core (C#): Linguagem e framework utilizado para o desenvolvimento.


Etapas Implementadas

1. Cadastro de Livro: Possibilidade de adicionar um novo livro ao catálogo, inserindo o título, autor e quantidade disponível.


2. Consulta ao Catálogo: Listagem dos livros disponíveis no sistema, mostrando o título, autor e quantidade disponível.


3. Empréstimo de Livro: O sistema permite reduzir a quantidade de exemplares disponíveis quando um livro é emprestado.


4. Devolução de Livro: Aumenta a quantidade de exemplares disponíveis quando um livro é devolvido.


5. Salvar Catálogo: Salva o catálogo em um arquivo catalogo.txt ao final da execução.


6. Carregar Catálogo: Carrega o catálogo do arquivo catalogo.txt no início da execução, se o arquivo existir.



Possíveis melhorias e backlog:

1. Validações:

Adicionar validação de entradas para prevenir erros como inserir letras em campos numéricos ou deixar campos em branco.

Prevenir a tentativa de empréstimo quando a quantidade disponível for zero.



2. Persistência automática:

Salvar automaticamente o catálogo sempre que uma operação for feita (em vez de só salvar ao sair).



3. Tratamento de Erros:

Melhorar o tratamento de exceções para erros como falhas na leitura/escrita de arquivos.



4. Busca por outros critérios:

Adicionar a possibilidade de buscar livros por autor, além do título.



5. Interface Gráfica:

Expandir para uma aplicação com interface gráfica (GUI) para melhorar a usabilidade, usando tecnologias como WPF ou WinForms.



6. Histórico de Empréstimos:

Implementar um registro de quem emprestou o livro e a data de empréstimo.

Conclusão do Projeto

O projeto de biblioteca foi concluído com sucesso, fornecendo um sistema funcional para o gerenciamento de um catálogo de livros. As funcionalidades principais incluem o cadastro de novos livros, consulta ao catálogo, empréstimo e devolução de livros, além de salvamento e carregamento do catálogo em arquivo. O sistema foi desenvolvido utilizando C# com as ferramentas adequadas (Visual Studio Code e .NET Core), criando um fluxo simples, mas eficiente, para o gerenciamento de livros.
