# Strings, express�es regulares e a classe Object

## Objetivos ao completar os estudos

- Aprenda a manipular strings no C#
- Use os m�todos IndexOf, Substring, Contains e outros da classe String
- Use express�es regulares
- Conhe�a a classe Regex
- Use os m�todos da classe Object

## Ementas:

### Mais sobre a String
- Argumentos em paginas da internet
- Imutabilidade e Substring
- M�todo Substring
- M�os na massa
- O que aprendi?
	- No C# e .NET strings s�o imut�veis;
	- Podemos criar uma nova string, a partir da por��o de outra, com o m�todo `Substring`;

### M�todos e propriedades
- IsNullOrEmpty e palavra chave string
- Propriedade Length e sobrecargas de IndexOf
- Trabalhando com Strings
- M�os na massa
- O que aprendi?
	- M�todo `IndexOf`;
	- M�todo est�tico `IsNullOrEmpty`;
	- A palavra reservada `string` �, na verdade, o tipo `String`;
	- A palavra reservada `int` �, na verdade, o tipo `Int32`;
	- A palavra reservada `double` �, na verdade, o tipo `Double`;
	- A sobrecarga `String::IndexOf(string)`;
	- A propriedade `String::Length`.

### Mais m�todos de manipula��o
- Usando o m�todo Remove
- Usando ToLower e ToUpper
- StartsWith EndsWith e Contains
- M�todos de String
- M�os na massa
- O que aprendi?
	- O `IndexOf` retorna sempre o �ndice da primeira ocorr�ncia que buscamos;
	- O m�todo `Remove(char)`;
	- O m�todo `Remove(char, int)`;
	- Sele��o quadrada no Visual Studio com o `Shift + Alt`;
	- O `IndexOf` retorna `-1` quando o valor n�o � encontrado.
	- O m�todo `Replace`;
	- O m�todo `ToUpper` e `ToLower`;
	- O m�todo `StartsWith`, `EndsWith` e `Contains`;

### Express�es regulares
- Conhecendo express�es regulares
- Quantificadores
- Quantificadores com intervalos
- Testando Regex
- M�os na massa
- O que aprendi?
	- Grupos de caracteres, como `[0123456789]`;
	- Intervalos de caracteres, como `[0-9]`;
	- Quantificadores: `{4,5}`, `{4}` e `{?}`;
	- O m�todo est�tico `Regex.IsMatch` e `Regex.Match`;

### Class Object
- Classe object
- M�todo ToString
- M�todo Equals
- Projeto final do curso
- Refer�ncias de Object
- M�os na massa
- O que aprendi?
	- Todos os tipos derivam de `Object`;
	- O m�todo `ToString`;
	- Como usar interpola��es de string (string interpolation);
	- Cast com a palavra reservada `as`;