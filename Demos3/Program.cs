﻿using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Ricardo";
p1.Idade = 30;
p1.EnderecoPessoa = new Endereco() {
    Logradouro = "Rua Teste",
    CEP = "00000",
    Cidade = "São Paulo",
};

WriteLine("Fim");