public class MinhaClasse1 {

public static void main (String [] args){
  
    String primeiroNome = "Leandro";
    String segundoNome = "Vilar";
    String nomeCompleto =  nomeCompleto(primeiroNome, segundoNome);

    System.out.println(nomeCompleto);

}

public static String nomeCompleto (String primeiroNome, String segundoNome){
    return "Resultado do método " + primeiroNome.concat(" ").concat(segundoNome);
}

}
