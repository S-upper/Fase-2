
from datetime import datetime

# Definindo as classes (equivalente ao namespace Fase2 e classes internas)
class Banco:
    def __init__(self):
        self.nome = None
        self.codigo_bacen = None

class Transacao:
    def __init__(self):
        self.valor = 0.0
        self.data = None
        self.tipo = None

class ContaBancaria:
    def __init__(self, agencia, numero_conta):
        self.agencia = agencia
        self.numero_conta = numero_conta
        self._saldo = 0.0  # O underline indica que é "protegido"

    @property
    def saldo(self):
        """Equivalente ao 'get' do C#"""
        return self._saldo

# --- Execução Principal (Equivalente ao static void Main) ---
if __name__ == "__main__":
    # Instanciando e configurando o Banco
    banco = Banco()
    banco.nome = "Banco do Brasil"
    banco.codigo_bacen = "001"

    # Instanciando e configurando a Transação
    minha_transacao = Transacao()
    minha_transacao.valor = 250.00
    minha_transacao.data = datetime.now()
    minha_transacao.tipo = "PIX"

    # Exibindo os dados no console
    print("--- REGISTRO BACEN ---")
    print(f"Banco: {banco.nome}")
    print(f"Código: {banco.codigo_bacen}")
    print("---------------------")
    print(f"Tipo: {minha_transacao.tipo}")
    print(f"Valor: R$ {minha_transacao.valor:.2f}")
    print(f"Data: {minha_transacao.data.strftime('%d/%m/%Y %H:%M:%S')}")