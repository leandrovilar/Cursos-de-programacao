// Enum é aglutinador de dados especificos

enum EMes {
    JAN = "Janeiro",
    FEV = "Fevereiro",
    MAR = "Março",
    ABR = "Abril",
    MAI = "Maio",
    JUN = "Junho",
}

const pessoa: {nome: string; mesAniversario: string} = { 
    nome: "Dener",
    mesAniversario: EMes.JUN,
};

if (pessoa.mesAniversario === EMes.JUN) {
    console.log(pessoa);
}