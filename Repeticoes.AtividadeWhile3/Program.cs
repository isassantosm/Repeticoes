// Defina uma senha secreta em uma variável (por exemplo: "programadora2026").
//     Peça para a usuária digitar a senha no terminal usando Console.ReadLine().
//     Utilize o laço while para verificar se a senha digitada é diferente da senha secreta (!=).
// Enquanto a senha for incorreta, exiba a mensagem "Senha incorreta! Tente novamente:" e leia o valor novamente.
//     Quando a senha correta for digitada, encerre o laço e exiba: "🔓 Acesso liberado! Bem-vinda ao sistema!".
//     Saída Esperada no Console:
// Digite a senha de acesso:
// 1234
// Senha incorreta! Tente novamente:
// admin
//     Senha incorreta! Tente novamente:
// programadora2026
//     🔓 Acesso liberado! Bem-vinda ao sistema!
//     💡 Dica: A condição do while deve verificar se a senha digitada é diferente da senha correta: while (senhaDigitada != senhaCorreta).


Console.Write("Digite a senha de acesso: ");
var senhaDigitada = Console.ReadLine();


while (senhaDigitada != "67")
{
    Console.Write("Senha incorreta! Tente novamente: ");
    senhaDigitada = Console.ReadLine();
    
}
    Console.WriteLine("Acesso liberado! Bem-vinda ao sistema!");
    
  