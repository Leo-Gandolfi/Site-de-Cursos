OnlineCourses

Um sistema web para gerenciamento de cursos online, desenvolvido em ASP.NET Core MVC, com TailwindCSS e Bootstrap para estilização. O projeto inclui funcionalidades para exibir cursos em progresso e irá recomendar cursos com base em uma busca personalizada.

![image](https://github.com/user-attachments/assets/6b66e186-e485-47e1-9b6a-fb7276b64459)

Funcionalidades

Cursos em Progresso: Mostra os cursos que o usuário está atualmente cursando, com progresso visual.

Recomendações de Cursos: Exibe cursos recomendados que poderão ser filtrados por título ou descrição por meio de uma barra de pesquisa.

Interface Responsiva: Desenvolvido com TailwindCSS e Bootstrap para garantir uma experiência consistente em diferentes dispositivos.

Tema Escuro/Claro: Botão de alternância de tema na barra de navegação.

Sidebar de Navegação: Links rápidos para as principais seções, como Meus Cursos, Certificados e Configurações.

Tecnologias Utilizadas

Backend:

ASP.NET Core MVC

Linguagem C#

Frontend:

Razor Views

TailwindCSS

Bootstrap

Outras Dependências:

Google Fonts (Material Icons)

Estrutura do Projeto

Controllers:

HomeController: Responsável por renderizar a página inicial com os cursos em progresso e os cursos recomendados, filtrados por uma query de pesquisa. Este, atualmente, guarda os cursos e os recomenda de uma maneira estática. Deixei fácil para voltar a esse projeto e integra-lo a um banco de dados.

Views:

Index.cshtml: View principal que exibe os cursos em progresso e recomendados.

Layout.cshtml: Layout compartilhado com header, sidebar e configurações de estilo global.

Models:

Course: Representa os cursos com propriedades como Id, Title, Description, ThumbnailUrl e Progress.


Cursos em Progresso

![image](https://github.com/user-attachments/assets/2c996fb5-d14c-4974-85f6-637706c0be10)


Cursos Recomendados

![image](https://github.com/user-attachments/assets/0d3418cb-2f22-4ede-a933-f10aa646e384)


Melhorias Futuras

Implementar autenticação e controle de acesso.

Adicionar funcionalidade de cadastro e gerenciamento de cursos.

Melhorar o design responsivo para dispositivos menores.


Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo LICENSE para mais informações.

