type alphanumeric = string | number;

let dados: alphanumeric;
let dados2: alphanumeric;

dados: 1
dados: "Leandro"
dados: true // Há um erro aqui. O TypeScript sinaliza um erro porque true é do tipo boolean, que não está incluído na definição do tipo alphanumeric.

dados2: 1
dados2: "Leandro"
dados2: true //  Há um erro aqui. O TypeScript sinaliza um erro porque true é do tipo boolean, que não está incluído na definição do tipo alphanumeric.