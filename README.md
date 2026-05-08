# Xadrez de Console em C#

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Orientação a Objetos](https://img.shields.io/badge/POO-Fundamentos-orange?style=for-the-badge)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/Doidokonng/xadrez-console/blob/main/LICENSE)

# Sobre

Um sistema de xadrez completo e funcional jogável diretamente no terminal (console), construído totalmente do zero utilizando C# e fortes princípios de Programação Orientada a Objetos (POO). 

Este projeto foi desenvolvido como forma de consolidar conceitos avançados de arquitetura de software, controle de estado e lógica de matrizes.

---

## Funcionalidades Implementadas

O motor do jogo aplica rigorosamente as regras do xadrez, incluindo:
*   **Movimentação e Validação:** Cada peça (Peão, Torre, Cavalo, Bispo, Dama, Rei) possui sua própria lógica de movimento calculada dinamicamente na matriz.
*   **Sistema de Turnos e Cores:** Alternância automática entre jogadores (Brancas e Pretas) com bloqueio de movimentos de peças adversárias.
*   **Detecção de Xeque e Xeque-Mate:** Algoritmo que simula rotas de ataque para proteger o Rei e identificar o fim da partida.
*   **Jogadas Especiais:** Implementação de regras complexas como o **Roque (Pequeno e Grande)**.
*   **Interface no Console:** Impressão do tabuleiro com cores dinâmicas, destacando as posições possíveis quando uma peça é selecionada.

---

## Como Executar o Projeto

Você pode testar o projeto de duas formas:

### Opção 1: Baixar a versão compilada (Recomendado para testes rápidos)
Vá até a aba **[Releases](https://github.com/Doidokonng/xadrez-console/releases/tag/v1.0)** deste repositório e baixe o arquivo `.zip` mais recente. Descompacte e execute para jogar.

### Opção 2: Rodar o código fonte localmente
Se você for um desenvolvedor e quiser rodar via terminal, certifique-se de ter o SDK do .NET instalado e siga os passos:

```bash
# Clone o repositório
git clone [https://github.com/doidokonng/xadrez-console.git](https://github.com/doidokonng/xadrez-console.git)

# Entre na pasta do projeto
cd xadrez-console

# Execute a aplicação
dotnet run
