using Gastos.GastoParcela;
using Gastos.GastosMensais;
using Gastos.GastoUnico;
using Gastos.Salario;

namespace fc_logic.Gastos
{
    public class Gastos
    {

        #region PRIVATE
        private decimal _gastosTotaisMensal { get; set; }
        private int _option { get; set; }

        private GastoMensal _mensal = new GastoMensal();
        private GastoParcela _parcela = new GastoParcela();
        private GastoUnico _gastoUnico = new GastoUnico();
        private Salario _salario = new Salario();
        #endregion

        #region CONSTRUCTOR
        public Gastos()
        {



        }
        #endregion CONSTRUCTOR

        public void GastosMain()
        {

            do
            {

                Console.Clear();
                Console.WriteLine("Bem vinda a página de gastos");
                Console.WriteLine("1) Adicionar gasto mensal\n2) Adicionar gasto único (feito apenas uma vez nesse mês)\n3) Adicionar gasto em parcelas\n4) Alterar salário");
                Console.WriteLine($"\n\nGanhos totais mensal: {this._gastosTotaisMensal}");

                Console.WriteLine("Escolha sua opção: ");
                _option = Convert.ToInt32(Console.ReadLine());

                this.GastosOptions(this._option);

            } while(_option != 0);

        }

        private void GastosOptions(int option)
        {



            switch(option)
            {

                case 1:
                    this._mensal.GastoMensalService();
                    break;
                case 2:
                    this._gastoUnico.GastoUnicoService();
                    break;
                case 3:
                    this._parcela.ParcelaService();
                    break;
                case 4:
                    this._salario.SalarioService();
                    break;

            }

        }

    }
}
