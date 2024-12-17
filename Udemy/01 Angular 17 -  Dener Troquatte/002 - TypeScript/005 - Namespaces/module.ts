/*
Resumidamente os módulos em JavaScript ou Typescritp é uma forma de voçê
compattilhar informações entre arquivos, desa foram, todos os arquivos que
realizarem a importações desse módelo poderão utilizar e usufruir de suas
funções ou informaçoes que foram expostas. 

import = Importa informações de uma class, namespace, const, let, etc.
export = Export para outras pessoas consumirem informações

*/

import { Pessoa1 } from "./pessoa-1";
import { Pessoa } from "./namespace-aninhados";

export { Pessoa1, Pessoa};