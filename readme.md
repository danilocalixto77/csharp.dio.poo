# Programando com Orientação a Objeto com C# 
#### Curso: dio. - Professor: Leonardo Buta

- 1. Introdução

- 2. Conhecendo a Programação Orientada a Objetos
    - É um tipo de paradigma de programação, uma técnica de se programar.
    - Tem por fundamento aproximar o mundo real do mundo da programação. 
    - Os pilares da POO se complementam e não dependem um do outro. Exceto o polimorfismo que depende da herança.
    - Pilares da POO:
      - Abstração
      - Encapsulamento
      - Herança
      - Polimorfismo
    - Principais conceitos da OO estão ligados a classes e objetos.
      - Classe: é um molde é uma abstração do mundo real.
      - Objeto: é a materialização da classe é algo que pode ser manipulado e se possa trabalhar.

  - Tipo de Pararadigmas
    - Programação orientada a objetos
    - Programação estruturada
    - Programação imperativa
    - programação procedural
    - Programação orientada a eventos
    - Programação lógica

- 3. Abstração
  - Abstrai do mundo real de acordo com o contexto em que o objeto estiver inserido, considerando os atributos importantes.
  - Criando projeto:
    - Criando uma solution:
      - dotnet new sln --name ExemploPOO
    - Criando o projeto tipo console:	
      - Cria pasta com nome do projeto
        - mkdir ExemploPOO
      - Executa comando para criar um projeto tipo console dentro da pasta ExemploPOO:
        - dotnet new console
    - Adicionando arquivo de projeto na solution.
      - dotnet sln add ExemploPOO/ExemploPOO.cspro

- 4. Encapsulamento
  - Tem por objetivo proteger ou limitar o acesso a classe.
  - Ou mesmo ocultar comportamentes e mostrar somente aquilo que for definido como necessário.

- 5. Herança
  - Permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
  - Neste pilar da orientação a objetos temos uma das grandes vantagens deste paradigma no reaproveitamento de código.

- 6. Polimorfismo
  - Do grego significa "muitas formas".
  - Com o polimorfismo podemos sobrescrever um método da classe pai na classe filha, caso ele não tenha o comportamento desejado.
  - De maneira a ter a sua própria implementação na filha.
  - Na classe mãe insere na declaração da assinatura 
  - Dois tipos de polimorfismo:
    - Em tempo de compilação:
      - Overload/Early Binding. Sobrecarga de métodos.
      - Desta maneira o método ele será o mesmo dentro da classe recebendo a mesma assinatura, entretanto, com mudança nos parâmetros a ser inserido no método.
    - Em tempo de execução:
      - Override/Late Binding. Sobrescrita de métodos. 
      - Desta maneira o método na classe mãe receberá uma notação na sua declaração como "virtual" e na classe filha ao declarar o método deverá haver a notação de "override". Desta maneira o método poderá ser ser sobrescrito na classe filha.

- 7. Classes abstratas
  - Classe abstrata caracteristicas:
    - Funciona como um molde. Este molde fornece atributos e métodos.
    - Os métodos da classe abstrata podem ser abstratos assim como também podem não ser abstratos.
      - Método abstrato: serão somente declarados e sua implementação será feita na classe que herdar a classe abstrata.
      - Método não abstrato: este é opcional, o método será sobrescrito conforme a necessida, caso o funcionamento do mesmo já atenda, não necessita sobrescrever, caso contrário, através do polimorfismo poderá ser sobrescrito.
    - Desta forma temos dois pilares da POO diretamente sendo aplicados em classes abstratas: 
      - Herança 
      - Polimorfismo 
    - Classe abstrata nã pode ser instanciada, somente herdada.
  - Classe Selada.
    - Este tipo de classe tem por objetivo impedir que outras classe façam herança a partir dela. Ou seja não permite "Herança".
    - As classes também podem ter propriedades e métodos selados.  Entretanto a classe não seria selada, permitindo a herança. Contudo não permitem "Polimorfismo".
    - A classe selada é o ponto final da herança de uma classe.
  - Classe Object
    - É a classe mãe de todas as classes do C#.
    - Todas as classe originalmente herdam desta classe.
    - Tem por objetivo prover serviços de baixo nível para as classes.
    - Métodos exemplos:
      - Equals(Object)
      - Finalize()
      - GetType()
      - ToString()
    - Alguns do métodos da classe object permitem sobrescrita, podendo usar do Polimorfismo. Como por exemplo o ToString().

- 8. Interfaces
  - A interface é um contrato que pode ser implementado por uma classe.
  - A interface possue uma grande semalhança com as classes abstratas.
  - A Interface não pode ser instanciada.
  - Como no C# não há o conceito de herança múltipas de classe, com a interface esse conceito é possível.
  - Métodos das interface são obrigatórios de serem implementados nas classes que as herdam. Semelhantemente aos métodos abstratos das classes.
  - Atalho VSCode "Ctrl + ." implent Interfaces.
  - Interfaces com implementação de métodos.
    - Para o caso de métodos da interface que possuem implementação na própria interface, não há necessidade/obrigatoriedade de fazer a implementação nas classes que vierem a implementar esta interface. Este recurso veio a partir do C# 8.

- 9. Manipulando arquivos
  - Vejamos como através do C# podemos fazer essas manipulações.
  - É necessário fazer uso da System.IO
  - Classes que possibilitam estas ações:
    - File
    - Directory
    - Path

---



