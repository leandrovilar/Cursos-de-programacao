-- Desafio de SQL


-- 1
SELECT 
    Nome, 
    Ano
FROM 
    Filmes
ORDER BY 
    Ano ASC;


-- 2
SELECT 
    Nome, 
    Ano, 
    Duracao
FROM 
    Filmes
ORDER BY 
    Ano ASC;


-- 3
SELECT * 
FROM Filmes
WHERE Nome LIKE 'De Volta para o Futuro%'
ORDER BY Nome, Ano, Duracao;

-- 4
SELECT *
FROM Filmes
WHERE Ano LIKE '1997%';


-- 5
SELECT *
FROM Filmes
WHERE Ano > 2000;


--6
SELECT *
FROM Filmes
WHERE Duracao > 100 and Duracao < 150
ORDER BY Duracao;


--7
SELECT 
    Ano,
    COUNT(*) AS QuantidadeFilmes
FROM 
    Filmes
GROUP BY 
    Ano
ORDER BY 
    QuantidadeFilmes DESC;


-- 8 
SELECT 
    Id,
    PrimeiroNome,
    UltimoNome,
    Genero
FROM
    Atores
WHERE
    Genero = 'M';


-- 9
SELECT 
    Id,
    PrimeiroNome,
    UltimoNome,
    Genero
FROM
    Atores
WHERE
    Genero = 'F'
ORDER BY 
    PrimeiroNome;


-- 10
SELECT 
    Filmes.Nome,
    Generos.Genero
      
FROM
    Filmes
INNER JOIN FilmesGenero
    ON Filmes.Id = FilmesGenero.IdFilme
INNER JOIN Generos
    ON FilmesGenero.IdGenero = Generos.Id;


-- 11
SELECT 
    Filmes.Nome,
    Generos.Genero
FROM
    Filmes
INNER JOIN FilmesGenero
    ON Filmes.Id = FilmesGenero.IdFilme
INNER JOIN Generos
    ON FilmesGenero.IdGenero = Generos.Id
WHERE
    Generos.Genero = 'Mistério';


-- 12
SELECT
    Filmes.Nome,
    Atores.PrimeiroNome,
    Atores.UltimoNome,
    ElencoFilme.Papel
FROM
    Filmes
INNER JOIN ElencoFilme
    ON Filmes.Id = ElencoFilme.IdFilme
INNER JOIN Atores
    ON ElencoFilme.IdAtor = Atores.Id;