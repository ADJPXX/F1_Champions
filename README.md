# F1 Champions

Quiz de linha de comando para testar seus conhecimentos sobre os campeões mundiais de pilotos da Fórmula 1.

O programa percorre as temporadas cadastradas de 1950 a 2025 e pede o nome do campeão de cada ano. A lista de respostas fica em `ChampionsList.cs`.

## Requisitos

- SDK do .NET 10
- Terminal compatível com aplicações de console

## Executar

Na pasta do projeto, restaure e execute com:

```powershell
dotnet restore .\F1_Champions.sln
dotnet run --project .\F1_Champions.csproj
```

Para compilar sem iniciar o quiz:

```powershell
dotnet build .\F1_Champions.sln --configuration Release
```

## Como jogar

- Informe o nome completo do campeão ou qualquer palavra do nome. A comparação ignora maiúsculas e minúsculas; por exemplo, `Ayrton` ou `Senna` são aceitos para Ayrton Senna.
- Se não souber uma resposta durante a primeira rodada, digite `p` para pular o ano.
- Depois da primeira rodada, o programa mostra os anos pulados e pergunta novamente por cada um. Nessa rodada, é necessário responder corretamente para continuar.
- Respostas incorretas são solicitadas novamente. Entradas vazias também são ignoradas.

Quando todos os anos forem respondidos, o programa termina. Ele não mantém pontuação nem mostra uma tela final de resultados.

## Dados dos campeões

As temporadas e os nomes esperados estão definidos diretamente no dicionário `Champions` de `ChampionsList.cs`. O conjunto atual cobre 1950–2026. Para incluir outra temporada ou corrigir um nome, atualize esse dicionário.