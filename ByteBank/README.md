# Strings, expressões regulares e a classe Object

## Objetivos ao completar os estudos

- Aprenda a manipular strings no C#
- Use os métodos IndexOf, Substring, Contains e outros da classe String
- Use expressões regulares
- Conheça a classe Regex
- Use os métodos da classe Object

## Ementas:

### Mais sobre a String
- Argumentos em paginas da internet
- Imutabilidade e Substring
- Método Substring
- Mãos na massa
- O que aprendi?
	- No C# e .NET strings são imutáveis;
	- Podemos criar uma nova string, a partir da porção de outra, com o método `Substring`;

### Métodos e propriedades
- IsNullOrEmpty e palavra chave string
- Propriedade Length e sobrecargas de IndexOf
- Trabalhando com Strings
- Mãos na massa
- O que aprendi?
	- Método `IndexOf`;
	- Método estático `IsNullOrEmpty`;
	- A palavra reservada `string` é, na verdade, o tipo `String`;
	- A palavra reservada `int` é, na verdade, o tipo `Int32`;
	- A palavra reservada `double` é, na verdade, o tipo `Double`;
	- A sobrecarga `String::IndexOf(string)`;
	- A propriedade `String::Length`.

### Mais métodos de manipulação
- Usando o método Remove
- Usando ToLower e ToUpper
- StartsWith EndsWith e Contains
- Métodos de String
- Mãos na massa
- O que aprendi?
	- O `IndexOf` retorna sempre o índice da primeira ocorrência que buscamos;
	- O método `Remove(char)`;
	- O método `Remove(char, int)`;
	- Seleção quadrada no Visual Studio com o `Shift + Alt`;
	- O `IndexOf` retorna `-1` quando o valor não é encontrado.
	- O método `Replace`;
	- O método `ToUpper` e `ToLower`;
	- O método `StartsWith`, `EndsWith` e `Contains`;

### Expressões regulares
- Conhecendo expressões regulares
- Quantificadores
- Quantificadores com intervalos
- Testando Regex
- Mãos na massa
- O que aprendi?
	- Grupos de caracteres, como `[0123456789]`;
	- Intervalos de caracteres, como `[0-9]`;
	- Quantificadores: `{4,5}`, `{4}` e `{?}`;
	- O método estático `Regex.IsMatch` e `Regex.Match`;

### Class Object
- Classe object
- Método ToString
- Método Equals
- Projeto final do curso
- Referências de Object
- Mãos na massa
- O que aprendi?
	- Todos os tipos derivam de `Object`;
	- O método `ToString`;
	- Como usar interpolações de string (string interpolation);
	- Cast com a palavra reservada `as`;